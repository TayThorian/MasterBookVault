﻿Imports Newtonsoft.Json
Imports System.Text
Imports System.IO
Imports System.Web

Public Class Form1
    Private rootFolderPath As String = "C:\Applications\GitHubs\MasterBookVault\Book Vault"
    Private bookDictionary As New Dictionary(Of String, Book)

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.ImageList = ImageList1
        InitializeTreeView()

        ' Set DrawMode to OwnerDrawFixed
        ListBoxBooksToSource.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxPDFToSource.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxBooksOnOrder.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxTOC.DrawMode = DrawMode.OwnerDrawFixed

        ' Populate ListBoxes
        PopulateBooksToSourceListBox()
        PopulatePDFToSourceListBox()
        PopulateBooksOnOrderListBox()

        ' Add DrawItem event handlers
        AddHandler ListBoxBooksToSource.DrawItem, AddressOf ListBoxBooks_DrawItem
        AddHandler ListBoxPDFToSource.DrawItem, AddressOf ListBoxBooks_DrawItem
        AddHandler ListBoxBooksOnOrder.DrawItem, AddressOf ListBoxBooks_DrawItem


        ' Ensure WebView2 is initialized
        Await WebView2Description.EnsureCoreWebView2Async(Nothing)

        ' Setup DataGridView columns
        With DataGridViewBookDetails
            .Columns.Clear()
            .Columns.Add("BookCode", "Code")
            .Columns.Add("BookName", "Name")
            .Columns.Add("BookISBN", "ISBN")
            .Columns.Add("BookPhysical", "Physical")
            .Columns.Add("BookOwnedPDF", "Owned PDF")
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With

        ' Create a context menu strip
        Dim treeViewContextMenu As New ContextMenuStrip()
        Dim openItem As New ToolStripMenuItem("Open in JSON Editor")
        AddHandler openItem.Click, AddressOf OpenJsonFile
        treeViewContextMenu.Items.Add(openItem)

        ' Assign the context menu to TreeView1
        TreeView1.ContextMenuStrip = treeViewContextMenu

    End Sub

    Private Sub ClearAllData()
        ' Clear TreeViews
        TreeView1.Nodes.Clear()
        TreeView2.Nodes.Clear()

        ' Clear dictionaries or other data structures
        bookDictionary.Clear()

        ' Clear ListBoxes
        ListBoxBooksToSource.Items.Clear()
        ListBoxPDFToSource.Items.Clear()
        ListBoxBooksOnOrder.Items.Clear()

        ' Clear DataGridView
        DataGridViewBookDetails.Rows.Clear()

        ' Clear any other UI elements that hold data
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear existing data
        ClearAllData()

        ' Reinitialize TreeView and other components
        InitializeTreeView()
        PopulateBooksToSourceListBox()
        PopulatePDFToSourceListBox()
        PopulateBooksOnOrderListBox()

        ' Clear details and ToC
        ClearBookDetails()
        ListBoxTOC.Items.Clear()
    End Sub



    Private Sub InitializeTreeView()
        TreeView1.Nodes.Clear()
        Dim rootNode As New TreeNode(Path.GetFileName(rootFolderPath))
        TreeView1.Nodes.Add(rootNode)
        PopulateTreeView(rootNode, rootFolderPath)
        TreeView1.ExpandAll()
    End Sub

    Private Sub PopulateTreeView(parentNode As TreeNode, folderPath As String)
        Dim subfolders() As String = Directory.GetDirectories(folderPath)
        Dim files() As String = Directory.GetFiles(folderPath)

        For Each subfolder In subfolders
            Dim subfolderNode As New TreeNode(Path.GetFileName(subfolder), 0, 0)
            subfolderNode.Tag = subfolder
            parentNode.Nodes.Add(subfolderNode)
            PopulateTreeView(subfolderNode, subfolder)
        Next

        For Each file In files
            Dim fileName As String = Path.GetFileNameWithoutExtension(file)
            Dim fileNode As New TreeNode(fileName, 1, 1)
            fileNode.Tag = file
            parentNode.Nodes.Add(fileNode)
        Next
    End Sub


    ' This method is triggered when a node is selected in TreeView1.
    ' It populates TreeView2 based on the JSON file associated with the selected node.
    ' The method clears any existing nodes in TreeView2 and the bookDictionary.
    ' It then reads the JSON file linked to the selected node, which contains book data.
    ' The books are grouped first by edition and then by series within each edition.
    ' Both the edition groups and the series groups are sorted alphabetically.
    ' For each series, the books are also sorted alphabetically by their names.
    ' This creates a structured and alphabetically ordered hierarchy in TreeView2,
    ' allowing users to navigate through the book collection efficiently.
    ' Each book's name is also stored in the bookDictionary for quick access to its details.
    ' The method includes error handling for file reading and JSON parsing issues.

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        TreeView2.Nodes.Clear()
        bookDictionary.Clear()

        If e.Node.Tag IsNot Nothing AndAlso File.Exists(e.Node.Tag.ToString()) Then
            Dim jsonData As String = File.ReadAllText(e.Node.Tag.ToString())
            Try
                Dim books As List(Of Book) = JsonConvert.DeserializeObject(Of List(Of Book))(jsonData)
                If books IsNot Nothing AndAlso books.Any() Then
                    Dim groupedByRules = books.GroupBy(Function(b) b.BookRules).OrderBy(Function(g) g.Key)

                    For Each rulesGroup In groupedByRules
                        Dim rulesNode As TreeNode = TreeView2.Nodes.Add(rulesGroup.Key)

                        Dim groupedBySeries = rulesGroup.GroupBy(Function(b) b.BookSeries).OrderBy(Function(g) g.Key)
                        For Each seriesGroup In groupedBySeries
                            Dim seriesNode As TreeNode = rulesNode.Nodes.Add(seriesGroup.Key)

                            For Each book In seriesGroup.OrderBy(Function(b) b.BookName)
                                If Not String.IsNullOrEmpty(book.BookName) Then
                                    seriesNode.Nodes.Add(book.BookName)
                                    bookDictionary(book.BookName) = book
                                End If
                            Next
                        Next
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("Error reading or parsing file: " & e.Node.Tag.ToString() & vbCrLf & ex.ToString())
            End Try
        End If
    End Sub

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
        ClearBookDetails()
        DataGridViewBookDetails.Rows.Clear()
        ListBoxTOC.Items.Clear() ' Clear the ToC list box

        If e.Node.Level = 2 Then ' Level 2 indicates a book node
            Dim bookName As String = e.Node.Text
            DisplayBookDetails(bookName) ' Assuming DisplayBookDetails expects a book name (string)

            ' Retrieve the selected book and display its ToC
            Dim selectedBook As Book = Nothing
            If bookDictionary.TryGetValue(bookName, selectedBook) Then
                DisplayTableOfContents(selectedBook) ' DisplayTableOfContents expects a Book object
            End If
        ElseIf e.Node.Level = 1 Then ' Level 1 might be a series or category
            For Each childNode As TreeNode In e.Node.Nodes
                AddBookToDataGridView(childNode.Text)
            Next
        End If
    End Sub



    Private Sub DisplayBookDetails(bookName As String)
        Dim selectedBook As Book = Nothing
        If bookDictionary.TryGetValue(bookName, selectedBook) Then
            UpdateTextBoxes(selectedBook)

            ' Update WebView2 with the book description
            If selectedBook.BookDescription IsNot Nothing AndAlso selectedBook.BookDescription.Length > 0 Then
                WebView2Description.NavigateToString(FormatDescriptionAsHtml(selectedBook.BookDescription))
            Else
                WebView2Description.NavigateToString("<html><body>No description available.</body></html>")
            End If

            ' Update PictureBox1 with the first page of the PDF
            If selectedBook.BookPDF IsNot Nothing AndAlso selectedBook.BookPDF.Any() Then
                ' Assuming PdfUtilities.GetPdfFirstPageAsImage is a method that returns an Image object
                ' for the first page of the given PDF file path.
                Dim firstPdfPath As String = selectedBook.BookPDF(0)
                If File.Exists(firstPdfPath) Then
                    PictureBox1.Image = PdfUtilities.GetPdfFirstPageAsImage(firstPdfPath)
                Else
                    PictureBox1.Image = Nothing
                End If
            Else
                PictureBox1.Image = Nothing
            End If

            ' Update PanelPdfLinks with PDF links
            PanelPdfLinks.Controls.Clear()
            If selectedBook.BookPDF IsNot Nothing AndAlso selectedBook.BookPDF.Any() Then
                Dim yOffset As Integer = 0
                For Each pdfPath In selectedBook.BookPDF
                    Dim link As New LinkLabel()
                    link.Text = Path.GetFileName(pdfPath)
                    link.Tag = pdfPath
                    link.AutoSize = True
                    link.Location = New Point(0, yOffset) ' Set Y position for each link
                    yOffset += link.Height + 5 ' Increment Y offset for the next link
                    AddHandler link.Click, AddressOf PdfLink_Click
                    PanelPdfLinks.Controls.Add(link)
                Next
                PanelPdfLinks.AutoScroll = True ' Enable scrolling if needed
            End If
        End If
    End Sub


    'Populate the Physical To Source List Box
    Private Sub PopulateBooksToSourceListBox()
        ListBoxBooksToSource.Items.Clear()
        Dim allFiles() As String = Directory.GetFiles(rootFolderPath, "*.json", SearchOption.AllDirectories)
        Dim allBooksToSource As New List(Of Book)

        ' Collect all books to source from all files
        For Each file In allFiles
            Try
                Dim jsonData As String = System.IO.File.ReadAllText(file)
                Dim books As List(Of Book) = JsonConvert.DeserializeObject(Of List(Of Book))(jsonData)
                If books IsNot Nothing Then
                    allBooksToSource.AddRange(books.Where(Function(b) b.BookPhysical = "To Source"))
                End If
            Catch ex As Exception
                MessageBox.Show("Error reading or parsing file: " & file & vbCrLf & ex.ToString())
            End Try
        Next

        ' Group by publisher
        Dim groupedByPublisher = allBooksToSource.GroupBy(Function(b) b.BookPublisher)

        ' Add grouped books to ListBox
        For Each publisherGroup In groupedByPublisher
            ListBoxBooksToSource.Items.Add("Publisher: " & publisherGroup.Key)
            For Each book In publisherGroup
                ListBoxBooksToSource.Items.Add("    " & book.BookCode & " - " & book.BookName)
            Next
        Next
    End Sub

    'Populate the PDF To Source List Box
    Private Sub PopulatePDFToSourceListBox()
        ListBoxPDFToSource.Items.Clear()
        Dim allFiles() As String = Directory.GetFiles(rootFolderPath, "*.json", SearchOption.AllDirectories)
        Dim allPDFToSource As New List(Of Book)

        ' Collect all books to source from all files
        For Each file In allFiles
            Try
                Dim jsonData As String = System.IO.File.ReadAllText(file)
                Dim books As List(Of Book) = JsonConvert.DeserializeObject(Of List(Of Book))(jsonData)
                If books IsNot Nothing Then
                    allPDFToSource.AddRange(books.Where(Function(b) b.BookOwnedPDF = "To Source"))
                End If
            Catch ex As Exception
                MessageBox.Show("Error reading or parsing file: " & file & vbCrLf & ex.ToString())
            End Try
        Next

        ' Group by publisher
        Dim groupedByPublisher = allPDFToSource.GroupBy(Function(b) b.BookPublisher)

        ' Add grouped books to ListBox
        For Each publisherGroup In groupedByPublisher
            ListBoxPDFToSource.Items.Add("Publisher: " & publisherGroup.Key)
            For Each book In publisherGroup
                ListBoxPDFToSource.Items.Add("    " & book.BookCode & " - " & book.BookName)
            Next
        Next
    End Sub




    'Populate the Physical On Order List Box
    Private Sub PopulateBooksOnOrderListBox()
        ListBoxBooksOnOrder.Items.Clear()
        Dim allFiles() As String = Directory.GetFiles(rootFolderPath, "*.json", SearchOption.AllDirectories)
        Dim allBooksOnOrder As New List(Of Book)

        ' Collect all books on order from all files
        For Each file In allFiles
            Try
                Dim jsonData As String = System.IO.File.ReadAllText(file)
                Dim books As List(Of Book) = JsonConvert.DeserializeObject(Of List(Of Book))(jsonData)
                If books IsNot Nothing Then
                    allBooksOnOrder.AddRange(books.Where(Function(b) b.BookPhysical = "On Order"))
                End If
            Catch ex As Exception
                MessageBox.Show("Error reading or parsing file: " & file & vbCrLf & ex.ToString())
            End Try
        Next

        ' Group by publisher
        Dim groupedByPublisher = allBooksOnOrder.GroupBy(Function(b) b.BookPublisher)

        ' Add grouped books to ListBox
        For Each publisherGroup In groupedByPublisher
            ListBoxBooksOnOrder.Items.Add("Publisher: " & publisherGroup.Key)
            For Each book In publisherGroup
                ListBoxBooksOnOrder.Items.Add("    " & book.BookCode & " - " & book.BookName)
            Next
        Next
    End Sub

    Private Sub ListBoxBooks_DrawItem(sender As Object, e As DrawItemEventArgs)
        If e.Index = -1 Then Return

        Dim listBox As ListBox = DirectCast(sender, ListBox)
        Dim text As String = listBox.Items(e.Index).ToString()

        ' Check if the item is a header
        Dim isHeader As Boolean = text.StartsWith("Publisher:")

        ' Set the font
        Dim font As Font
        If isHeader Then
            font = New Font(e.Font, FontStyle.Bold)
            text = text.Substring("Publisher:".Length)  ' Remove the header tag
        Else
            font = e.Font
        End If

        ' Background & text color
        e.DrawBackground()
        Dim brush As New SolidBrush(e.ForeColor)

        ' Draw the text
        e.Graphics.DrawString(text, font, brush, e.Bounds)

        e.DrawFocusRectangle()
    End Sub

    Private Sub AddBookToDataGridView(bookName As String)
        Dim selectedBook As Book = Nothing
        If bookDictionary.TryGetValue(bookName, selectedBook) Then
            With DataGridViewBookDetails
                Dim row As String() = {
                    selectedBook.BookCode,
                    selectedBook.BookName,
                    selectedBook.BookISBN,
                    selectedBook.BookPhysical,
                    selectedBook.BookOwnedPDF
                }
                .Rows.Add(row)
            End With
        End If
    End Sub

    Private Sub ClearBookDetails()
        TextBoxBookName.Text = String.Empty
        TextBoxCode.Text = String.Empty
        TextBoxPublisher.Text = String.Empty
        TextBoxISBN.Text = String.Empty
        TextBoxAuthor.Text = String.Empty
        TextBoxPublicationYear.Text = String.Empty
        TextBoxRules.Text = String.Empty
        TextBoxEdition.Text = String.Empty
        TextBoxSetting.Text = String.Empty
        TextBoxType.Text = String.Empty
        TextBoxFormat.Text = String.Empty
        TextBoxSeries.Text = String.Empty
        TextBoxPhysical.Text = String.Empty
        TextBoxOwnedPDF.Text = String.Empty
        PanelPdfLinks.Controls.Clear()
        PictureBox1.Image = Nothing
        WebView2Description.NavigateToString("<html><body></body></html>")
    End Sub

    Private Sub UpdateTextBoxes(selectedBook As Book)
        TextBoxBookName.Text = selectedBook.BookName
        TextBoxCode.Text = selectedBook.BookCode
        TextBoxPublisher.Text = selectedBook.BookPublisher
        TextBoxISBN.Text = selectedBook.BookISBN
        TextBoxAuthor.Text = selectedBook.BookAuthor
        TextBoxPublicationYear.Text = selectedBook.BookPublished.ToString()
        TextBoxRules.Text = selectedBook.BookRules
        TextBoxEdition.Text = selectedBook.BookEdition
        TextBoxSetting.Text = selectedBook.BookSetting
        TextBoxType.Text = selectedBook.BookType
        TextBoxFormat.Text = selectedBook.BookFormat
        TextBoxSeries.Text = selectedBook.BookSeries
        TextBoxPhysical.Text = selectedBook.BookPhysical
        TextBoxOwnedPDF.Text = selectedBook.BookOwnedPDF
    End Sub

    Private Sub PdfLink_Click(sender As Object, e As EventArgs)
        Dim link As LinkLabel = DirectCast(sender, LinkLabel)
        Dim filePath As String = link.Tag.ToString()
        If Not String.IsNullOrWhiteSpace(filePath) AndAlso File.Exists(filePath) Then
            Try
                Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
            Catch ex As Exception
                MessageBox.Show("Error opening PDF file: " & ex.Message)
            End Try
        Else
            MessageBox.Show("File does not exist: " & filePath)
        End If
    End Sub

    Private Function FormatDescriptionAsHtml(descriptions As String()) As String
        Dim htmlBuilder As New StringBuilder("<html><body style='font-family: Arial;'>")

        For Each desc In descriptions
            htmlBuilder.Append(desc)
            htmlBuilder.Append("<br><br>")
        Next

        htmlBuilder.Append("</body></html>")
        Return htmlBuilder.ToString()
    End Function

    Private Sub btnGenerateMD_Click(sender As Object, e As EventArgs) Handles btnGenerateMD.Click
        Dim markdownContent As New StringBuilder

        ' Header for the markdown file
        markdownContent.AppendLine("# Master Book Vault")

        ' Physical Books Section
        markdownContent.AppendLine("# Physical Books to Source")
        AddBooksToList(markdownContent, ListBoxBooksToSource)

        ' PDF Books Section
        markdownContent.AppendLine("# PDF's Books to Source")
        AddBooksToList(markdownContent, ListBoxPDFToSource)

        ' Write to file
        File.WriteAllText("C:\Applications\GitHubs\MasterBookVault\README.md", markdownContent.ToString())
    End Sub

    Private Sub AddBooksToList(markdownContent As StringBuilder, listBox As ListBox)
        Dim currentPublisher As String = String.Empty

        For Each item As String In listBox.Items
            If item.StartsWith("Publisher: ") Then
                ' New Publisher
                currentPublisher = item.Replace("Publisher: ", "").Trim()
                markdownContent.AppendLine($"## {currentPublisher}")
            Else
                ' Book item
                Dim trimmedItem = item.Trim()
                If Not String.IsNullOrWhiteSpace(trimmedItem) Then
                    ' Splitting the string at the first occurrence of " - "
                    Dim delimiter As String = " - "
                    Dim delimiterIndex = trimmedItem.IndexOf(delimiter)
                    If delimiterIndex > -1 Then
                        Dim bookCode = trimmedItem.Substring(0, delimiterIndex).Trim()
                        Dim bookName = trimmedItem.Substring(delimiterIndex + delimiter.Length).Trim()
                        markdownContent.AppendLine($"- {bookCode} - {bookName}")
                    Else
                        ' Handling the case where there is no " - " delimiter
                        markdownContent.AppendLine($"- {trimmedItem}")
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub DisplayTableOfContents(selectedBook As Book)
        If selectedBook.TableOfContents IsNot Nothing AndAlso selectedBook.TableOfContents.Chapters IsNot Nothing Then
            ListBoxTOC.Items.Clear()
            For Each chapter As Chapter In selectedBook.TableOfContents.Chapters
                ListBoxTOC.Items.Add("Page " & chapter.Page.ToString() & ": " & chapter.Title)
            Next
        End If
    End Sub

    Private Sub ListBoxTOC_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBoxTOC.DrawItem
        If e.Index = -1 Then Return

        e.DrawBackground()

        Dim item As String = ListBoxTOC.Items(e.Index).ToString()
        Dim parts As String() = item.Split(New String() {": "}, StringSplitOptions.None)

        If parts.Length > 1 Then
            Dim pagePart As String = parts(0) & ": "
            Dim titlePart As String = parts(1)

            Dim boldFont As New Font(e.Font, FontStyle.Bold)
            Dim regularFont As New Font(e.Font, FontStyle.Regular)

            ' Measure the width of the "Page" part
            Dim pagePartWidth As Integer = CInt(e.Graphics.MeasureString(pagePart, boldFont).Width)

            ' Draw the "Page" part in bold
            e.Graphics.DrawString(pagePart, boldFont, New SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top)

            ' Draw the "Title" part in regular font
            e.Graphics.DrawString(titlePart, regularFont, New SolidBrush(e.ForeColor), e.Bounds.Left + pagePartWidth, e.Bounds.Top)
        End If

        e.DrawFocusRectangle()
    End Sub

    Private Sub ButtonRunEditor_Click(sender As Object, e As EventArgs) Handles ButtonRunEditor.Click
        ' Ensure the path exists
        If Not System.IO.Directory.Exists(rootFolderPath) Then
            MessageBox.Show("Folder path does not exist.")
            Return
        End If

        ' Attempt to open the folder in the default JSON editor
        Try
            Process.Start("explorer.exe", rootFolderPath)
        Catch ex As Exception
            MessageBox.Show("Error opening folder: " & ex.Message)
        End Try
    End Sub

    Private Sub OpenJsonFile(sender As Object, e As EventArgs)
        If TreeView1.SelectedNode IsNot Nothing AndAlso TreeView1.SelectedNode.Tag IsNot Nothing Then
            Dim filePath As String = TreeView1.SelectedNode.Tag.ToString()

            ' Check if the file is a JSON file
            If Path.GetExtension(filePath).Equals(".json", StringComparison.OrdinalIgnoreCase) Then
                Try
                    Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
                Catch ex As Exception
                    MessageBox.Show("Error opening file: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub TreeView1_MouseUp(sender As Object, e As MouseEventArgs) Handles TreeView1.MouseUp
        If e.Button = MouseButtons.Right Then
            ' Select the node under the mouse pointer
            Dim node As TreeNode = TreeView1.GetNodeAt(e.X, e.Y)
            If node IsNot Nothing Then
                TreeView1.SelectedNode = node
            End If
        End If
    End Sub

End Class
