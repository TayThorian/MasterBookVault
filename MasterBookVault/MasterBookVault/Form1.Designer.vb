﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        TreeView1 = New TreeView()
        TreeView2 = New TreeView()
        ImageList1 = New ImageList(components)
        TextBoxBookName = New TextBox()
        TextBoxPublicationYear = New TextBox()
        PanelPdfLinks = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TextBoxISBN = New TextBox()
        Label2 = New Label()
        TextBoxCode = New TextBox()
        TextBoxPublisher = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        TextBoxRules = New TextBox()
        Label6 = New Label()
        TextBoxEdition = New TextBox()
        Label7 = New Label()
        TextBoxPhysical = New TextBox()
        TextBoxOwnedPDF = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        WebView2Description = New Microsoft.Web.WebView2.WinForms.WebView2()
        Label10 = New Label()
        DataGridViewBookDetails = New DataGridView()
        ListBoxBooksToSource = New ListBox()
        ListBoxBooksOnOrder = New ListBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        ListBoxPDFToSource = New ListBox()
        TextBoxSetting = New TextBox()
        Label14 = New Label()
        TextBoxType = New TextBox()
        Label15 = New Label()
        TextBoxFormat = New TextBox()
        TextBoxSeries = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        btnGenerateMD = New Button()
        TextBoxAuthor = New RichTextBox()
        ListBoxTOC = New ListBox()
        Label4 = New Label()
        Label18 = New Label()
        Panel2 = New Panel()
        MDLinksMagicItems = New Panel()
        Label29 = New Label()
        MDLinksMonsters = New Panel()
        Label28 = New Label()
        MDLinksPSpells = New Panel()
        Label27 = New Label()
        Label24 = New Label()
        MDLinksWSpells = New Panel()
        Label20 = New Label()
        PanelMDLInks = New Panel()
        Label19 = New Label()
        Panel3 = New Panel()
        TextBoxCharLvl = New TextBox()
        Label26 = New Label()
        Panel4 = New Panel()
        BookCountListBox = New ListBox()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        ButtonRunEditor = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TextBoxObjectCount = New TextBox()
        Label25 = New Label()
        btnCopyToWiki = New Button()
        TextBoxWikiPageTitle = New TextBox()
        btnOpenWikiPage = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(WebView2Description, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewBookDetails, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(57, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(185, 31)
        Button1.TabIndex = 0
        Button1.Text = "Load all Books"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(73, 82)
        TreeView1.Name = "TreeView1"
        TreeView1.Size = New Size(438, 492)
        TreeView1.TabIndex = 1
        ' 
        ' TreeView2
        ' 
        TreeView2.Location = New Point(14, 511)
        TreeView2.Name = "TreeView2"
        TreeView2.Size = New Size(438, 633)
        TreeView2.TabIndex = 2
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "icons8-folder-48.png")
        ImageList1.Images.SetKeyName(1, "icons8-book-50.png")
        ' 
        ' TextBoxBookName
        ' 
        TextBoxBookName.BackColor = SystemColors.Window
        TextBoxBookName.BorderStyle = BorderStyle.None
        TextBoxBookName.Font = New Font("Eras Bold ITC", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxBookName.Location = New Point(13, 8)
        TextBoxBookName.Name = "TextBoxBookName"
        TextBoxBookName.Size = New Size(1149, 19)
        TextBoxBookName.TabIndex = 3
        ' 
        ' TextBoxPublicationYear
        ' 
        TextBoxPublicationYear.BackColor = SystemColors.Window
        TextBoxPublicationYear.BorderStyle = BorderStyle.None
        TextBoxPublicationYear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPublicationYear.Location = New Point(130, 789)
        TextBoxPublicationYear.Name = "TextBoxPublicationYear"
        TextBoxPublicationYear.Size = New Size(315, 22)
        TextBoxPublicationYear.TabIndex = 5
        ' 
        ' PanelPdfLinks
        ' 
        PanelPdfLinks.AutoScroll = True
        PanelPdfLinks.BackColor = Color.FloralWhite
        PanelPdfLinks.BorderStyle = BorderStyle.Fixed3D
        PanelPdfLinks.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PanelPdfLinks.Location = New Point(646, 680)
        PanelPdfLinks.Name = "PanelPdfLinks"
        PanelPdfLinks.Size = New Size(477, 463)
        PanelPdfLinks.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TreeView2)
        Panel1.Location = New Point(57, 69)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(468, 1155)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Window
        PictureBox1.Location = New Point(646, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(477, 498)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Window
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(29, 789)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 21)
        Label1.TabIndex = 9
        Label1.Text = "Published:"
        ' 
        ' TextBoxISBN
        ' 
        TextBoxISBN.BackColor = SystemColors.Window
        TextBoxISBN.BorderStyle = BorderStyle.None
        TextBoxISBN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxISBN.Location = New Point(130, 761)
        TextBoxISBN.Name = "TextBoxISBN"
        TextBoxISBN.Size = New Size(315, 22)
        TextBoxISBN.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Window
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 762)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 21)
        Label2.TabIndex = 11
        Label2.Text = "ISBN:"
        ' 
        ' TextBoxCode
        ' 
        TextBoxCode.BackColor = SystemColors.Window
        TextBoxCode.BorderStyle = BorderStyle.None
        TextBoxCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCode.Location = New Point(130, 702)
        TextBoxCode.Name = "TextBoxCode"
        TextBoxCode.Size = New Size(315, 22)
        TextBoxCode.TabIndex = 12
        ' 
        ' TextBoxPublisher
        ' 
        TextBoxPublisher.BackColor = SystemColors.Window
        TextBoxPublisher.BorderStyle = BorderStyle.None
        TextBoxPublisher.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPublisher.Location = New Point(130, 733)
        TextBoxPublisher.Name = "TextBoxPublisher"
        TextBoxPublisher.Size = New Size(315, 22)
        TextBoxPublisher.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Window
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(29, 734)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 14
        Label3.Text = "Publisher:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Window
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(29, 817)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 21)
        Label5.TabIndex = 16
        Label5.Text = "Author(s):"
        ' 
        ' TextBoxRules
        ' 
        TextBoxRules.BackColor = SystemColors.Window
        TextBoxRules.BorderStyle = BorderStyle.None
        TextBoxRules.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRules.Location = New Point(130, 882)
        TextBoxRules.Name = "TextBoxRules"
        TextBoxRules.Size = New Size(315, 22)
        TextBoxRules.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Window
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(29, 883)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 21)
        Label6.TabIndex = 18
        Label6.Text = "Rules:"
        ' 
        ' TextBoxEdition
        ' 
        TextBoxEdition.BackColor = SystemColors.Window
        TextBoxEdition.BorderStyle = BorderStyle.None
        TextBoxEdition.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxEdition.Location = New Point(130, 910)
        TextBoxEdition.Name = "TextBoxEdition"
        TextBoxEdition.Size = New Size(315, 22)
        TextBoxEdition.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Window
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(29, 911)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 21)
        Label7.TabIndex = 20
        Label7.Text = "Edition:"
        ' 
        ' TextBoxPhysical
        ' 
        TextBoxPhysical.BackColor = SystemColors.Window
        TextBoxPhysical.BorderStyle = BorderStyle.None
        TextBoxPhysical.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPhysical.Location = New Point(130, 1051)
        TextBoxPhysical.Name = "TextBoxPhysical"
        TextBoxPhysical.Size = New Size(120, 22)
        TextBoxPhysical.TabIndex = 21
        ' 
        ' TextBoxOwnedPDF
        ' 
        TextBoxOwnedPDF.BackColor = SystemColors.Window
        TextBoxOwnedPDF.BorderStyle = BorderStyle.None
        TextBoxOwnedPDF.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxOwnedPDF.Location = New Point(338, 1050)
        TextBoxOwnedPDF.Name = "TextBoxOwnedPDF"
        TextBoxOwnedPDF.Size = New Size(107, 22)
        TextBoxOwnedPDF.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.Window
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(29, 1051)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 21)
        Label8.TabIndex = 23
        Label8.Text = "Physical:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.Window
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(288, 1051)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 21)
        Label9.TabIndex = 24
        Label9.Text = "PDF:"
        ' 
        ' WebView2Description
        ' 
        WebView2Description.AllowExternalDrop = True
        WebView2Description.BackColor = SystemColors.Window
        WebView2Description.CreationProperties = Nothing
        WebView2Description.DefaultBackgroundColor = Color.White
        WebView2Description.Location = New Point(13, 37)
        WebView2Description.Name = "WebView2Description"
        WebView2Description.Size = New Size(627, 587)
        WebView2Description.TabIndex = 25
        WebView2Description.ZoomFactor = 1R
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.Window
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(646, 656)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 21)
        Label10.TabIndex = 26
        Label10.Text = "PDF Links:"
        ' 
        ' DataGridViewBookDetails
        ' 
        DataGridViewBookDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewBookDetails.Location = New Point(2544, 779)
        DataGridViewBookDetails.Name = "DataGridViewBookDetails"
        DataGridViewBookDetails.RowTemplate.Height = 25
        DataGridViewBookDetails.Size = New Size(769, 445)
        DataGridViewBookDetails.TabIndex = 27
        ' 
        ' ListBoxBooksToSource
        ' 
        ListBoxBooksToSource.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxBooksToSource.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBoxBooksToSource.FormattingEnabled = True
        ListBoxBooksToSource.ItemHeight = 15
        ListBoxBooksToSource.Location = New Point(3, 37)
        ListBoxBooksToSource.Name = "ListBoxBooksToSource"
        ListBoxBooksToSource.Size = New Size(348, 364)
        ListBoxBooksToSource.TabIndex = 28
        ' 
        ' ListBoxBooksOnOrder
        ' 
        ListBoxBooksOnOrder.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxBooksOnOrder.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBoxBooksOnOrder.FormattingEnabled = True
        ListBoxBooksOnOrder.ItemHeight = 15
        ListBoxBooksOnOrder.Location = New Point(5, 440)
        ListBoxBooksOnOrder.Name = "ListBoxBooksOnOrder"
        ListBoxBooksOnOrder.Size = New Size(346, 244)
        ListBoxBooksOnOrder.TabIndex = 29
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(3, 13)
        Label11.Name = "Label11"
        Label11.Size = New Size(203, 21)
        Label11.TabIndex = 30
        Label11.Text = "Physical Books to Source:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(357, 11)
        Label12.Name = "Label12"
        Label12.Size = New Size(181, 21)
        Label12.TabIndex = 31
        Label12.Text = "PDF's Books to Source:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(5, 416)
        Label13.Name = "Label13"
        Label13.Size = New Size(201, 21)
        Label13.TabIndex = 32
        Label13.Text = "Physical Books On Order:"
        ' 
        ' ListBoxPDFToSource
        ' 
        ListBoxPDFToSource.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxPDFToSource.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBoxPDFToSource.FormattingEnabled = True
        ListBoxPDFToSource.ItemHeight = 15
        ListBoxPDFToSource.Location = New Point(357, 37)
        ListBoxPDFToSource.Name = "ListBoxPDFToSource"
        ListBoxPDFToSource.Size = New Size(400, 364)
        ListBoxPDFToSource.TabIndex = 33
        ' 
        ' TextBoxSetting
        ' 
        TextBoxSetting.BackColor = SystemColors.Window
        TextBoxSetting.BorderStyle = BorderStyle.None
        TextBoxSetting.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSetting.Location = New Point(130, 938)
        TextBoxSetting.Name = "TextBoxSetting"
        TextBoxSetting.Size = New Size(315, 22)
        TextBoxSetting.TabIndex = 34
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = SystemColors.Window
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(29, 939)
        Label14.Name = "Label14"
        Label14.Size = New Size(69, 21)
        Label14.TabIndex = 35
        Label14.Text = "Setting:"
        ' 
        ' TextBoxType
        ' 
        TextBoxType.BackColor = SystemColors.Window
        TextBoxType.BorderStyle = BorderStyle.None
        TextBoxType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxType.Location = New Point(130, 966)
        TextBoxType.Name = "TextBoxType"
        TextBoxType.Size = New Size(315, 22)
        TextBoxType.TabIndex = 36
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.Window
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(29, 967)
        Label15.Name = "Label15"
        Label15.Size = New Size(50, 21)
        Label15.TabIndex = 37
        Label15.Text = "Type:"
        ' 
        ' TextBoxFormat
        ' 
        TextBoxFormat.BackColor = SystemColors.Window
        TextBoxFormat.BorderStyle = BorderStyle.None
        TextBoxFormat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxFormat.Location = New Point(130, 994)
        TextBoxFormat.Name = "TextBoxFormat"
        TextBoxFormat.Size = New Size(315, 22)
        TextBoxFormat.TabIndex = 38
        ' 
        ' TextBoxSeries
        ' 
        TextBoxSeries.BackColor = SystemColors.Window
        TextBoxSeries.BorderStyle = BorderStyle.None
        TextBoxSeries.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSeries.Location = New Point(130, 1022)
        TextBoxSeries.Name = "TextBoxSeries"
        TextBoxSeries.Size = New Size(315, 22)
        TextBoxSeries.TabIndex = 39
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = SystemColors.Window
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(29, 1023)
        Label16.Name = "Label16"
        Label16.Size = New Size(59, 21)
        Label16.TabIndex = 40
        Label16.Text = "Series:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = SystemColors.Window
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(29, 995)
        Label17.Name = "Label17"
        Label17.Size = New Size(68, 21)
        Label17.TabIndex = 41
        Label17.Text = "Format:"
        ' 
        ' btnGenerateMD
        ' 
        btnGenerateMD.BackColor = SystemColors.ActiveCaption
        btnGenerateMD.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnGenerateMD.Location = New Point(261, 12)
        btnGenerateMD.Name = "btnGenerateMD"
        btnGenerateMD.Size = New Size(185, 31)
        btnGenerateMD.TabIndex = 42
        btnGenerateMD.Text = "Generate MD ReadMe"
        btnGenerateMD.UseVisualStyleBackColor = False
        ' 
        ' TextBoxAuthor
        ' 
        TextBoxAuthor.BackColor = SystemColors.Window
        TextBoxAuthor.BorderStyle = BorderStyle.None
        TextBoxAuthor.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxAuthor.Location = New Point(130, 817)
        TextBoxAuthor.Name = "TextBoxAuthor"
        TextBoxAuthor.ScrollBars = RichTextBoxScrollBars.Vertical
        TextBoxAuthor.Size = New Size(315, 59)
        TextBoxAuthor.TabIndex = 43
        TextBoxAuthor.Text = ""
        ' 
        ' ListBoxTOC
        ' 
        ListBoxTOC.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBoxTOC.FormattingEnabled = True
        ListBoxTOC.HorizontalScrollbar = True
        ListBoxTOC.ItemHeight = 17
        ListBoxTOC.Location = New Point(1131, 37)
        ListBoxTOC.Name = "ListBoxTOC"
        ListBoxTOC.Size = New Size(431, 582)
        ListBoxTOC.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Window
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(29, 702)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 21)
        Label4.TabIndex = 45
        Label4.Text = "Code:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(1131, 11)
        Label18.Name = "Label18"
        Label18.Size = New Size(143, 21)
        Label18.TabIndex = 46
        Label18.Text = "Table of Contents"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Window
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(MDLinksMagicItems)
        Panel2.Controls.Add(Label29)
        Panel2.Controls.Add(MDLinksMonsters)
        Panel2.Controls.Add(Label28)
        Panel2.Controls.Add(MDLinksPSpells)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(Label24)
        Panel2.Controls.Add(MDLinksWSpells)
        Panel2.Controls.Add(Label20)
        Panel2.Controls.Add(PanelMDLInks)
        Panel2.Controls.Add(Label19)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(PanelPdfLinks)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(ListBoxTOC)
        Panel2.Controls.Add(TextBoxPublisher)
        Panel2.Controls.Add(TextBoxISBN)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(TextBoxAuthor)
        Panel2.Controls.Add(TextBoxBookName)
        Panel2.Controls.Add(WebView2Description)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(TextBoxCode)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(TextBoxSeries)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TextBoxFormat)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(TextBoxType)
        Panel2.Controls.Add(TextBoxPhysical)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(TextBoxOwnedPDF)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(TextBoxSetting)
        Panel2.Controls.Add(TextBoxPublicationYear)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(TextBoxRules)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBoxEdition)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(531, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(2007, 1155)
        Panel2.TabIndex = 8
        ' 
        ' MDLinksMagicItems
        ' 
        MDLinksMagicItems.AutoScroll = True
        MDLinksMagicItems.BackColor = Color.FloralWhite
        MDLinksMagicItems.BorderStyle = BorderStyle.Fixed3D
        MDLinksMagicItems.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MDLinksMagicItems.Location = New Point(1573, 960)
        MDLinksMagicItems.Name = "MDLinksMagicItems"
        MDLinksMagicItems.Size = New Size(427, 183)
        MDLinksMagicItems.TabIndex = 55
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.BackColor = SystemColors.Window
        Label29.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label29.Location = New Point(1573, 936)
        Label29.Name = "Label29"
        Label29.Size = New Size(107, 21)
        Label29.TabIndex = 56
        Label29.Text = "Magic Items:"
        ' 
        ' MDLinksMonsters
        ' 
        MDLinksMonsters.AutoScroll = True
        MDLinksMonsters.BackColor = Color.FloralWhite
        MDLinksMonsters.BorderStyle = BorderStyle.Fixed3D
        MDLinksMonsters.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MDLinksMonsters.Location = New Point(1573, 701)
        MDLinksMonsters.Name = "MDLinksMonsters"
        MDLinksMonsters.Size = New Size(427, 231)
        MDLinksMonsters.TabIndex = 54
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.BackColor = SystemColors.Window
        Label28.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label28.Location = New Point(1573, 677)
        Label28.Name = "Label28"
        Label28.Size = New Size(84, 21)
        Label28.TabIndex = 55
        Label28.Text = "Monsters:"
        ' 
        ' MDLinksPSpells
        ' 
        MDLinksPSpells.AutoScroll = True
        MDLinksPSpells.BackColor = Color.FloralWhite
        MDLinksPSpells.BorderStyle = BorderStyle.Fixed3D
        MDLinksPSpells.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MDLinksPSpells.Location = New Point(1573, 402)
        MDLinksPSpells.Name = "MDLinksPSpells"
        MDLinksPSpells.Size = New Size(427, 272)
        MDLinksPSpells.TabIndex = 53
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.BackColor = SystemColors.Window
        Label27.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label27.Location = New Point(1573, 378)
        Label27.Name = "Label27"
        Label27.Size = New Size(106, 21)
        Label27.TabIndex = 54
        Label27.Text = "Priest Spells:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.BackColor = SystemColors.Window
        Label24.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.Location = New Point(1573, 13)
        Label24.Name = "Label24"
        Label24.Size = New Size(117, 21)
        Label24.TabIndex = 53
        Label24.Text = "Wizard Spells:"
        ' 
        ' MDLinksWSpells
        ' 
        MDLinksWSpells.AutoScroll = True
        MDLinksWSpells.BackColor = Color.FloralWhite
        MDLinksWSpells.BorderStyle = BorderStyle.Fixed3D
        MDLinksWSpells.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MDLinksWSpells.Location = New Point(1573, 37)
        MDLinksWSpells.Name = "MDLinksWSpells"
        MDLinksWSpells.Size = New Size(427, 338)
        MDLinksWSpells.TabIndex = 52
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = SystemColors.Window
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(1131, 656)
        Label20.Name = "Label20"
        Label20.Size = New Size(96, 21)
        Label20.TabIndex = 52
        Label20.Text = "Extra Links:"
        ' 
        ' PanelMDLInks
        ' 
        PanelMDLInks.AutoScroll = True
        PanelMDLInks.BackColor = Color.FloralWhite
        PanelMDLInks.BorderStyle = BorderStyle.Fixed3D
        PanelMDLInks.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PanelMDLInks.Location = New Point(1131, 680)
        PanelMDLInks.Name = "PanelMDLInks"
        PanelMDLInks.Size = New Size(431, 463)
        PanelMDLInks.TabIndex = 51
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(11, 656)
        Label19.Name = "Label19"
        Label19.Size = New Size(63, 21)
        Label19.TabIndex = 50
        Label19.Text = "Details"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(TextBoxCharLvl)
        Panel3.Controls.Add(Label26)
        Panel3.Location = New Point(11, 680)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(629, 463)
        Panel3.TabIndex = 49
        ' 
        ' TextBoxCharLvl
        ' 
        TextBoxCharLvl.BackColor = SystemColors.Window
        TextBoxCharLvl.BorderStyle = BorderStyle.None
        TextBoxCharLvl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCharLvl.Location = New Point(117, 400)
        TextBoxCharLvl.Name = "TextBoxCharLvl"
        TextBoxCharLvl.Size = New Size(315, 22)
        TextBoxCharLvl.TabIndex = 48
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.BackColor = SystemColors.Window
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label26.Location = New Point(16, 400)
        Label26.Name = "Label26"
        Label26.Size = New Size(54, 21)
        Label26.TabIndex = 53
        Label26.Text = "Level:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Window
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(BookCountListBox)
        Panel4.Controls.Add(Label21)
        Panel4.Controls.Add(Label22)
        Panel4.Controls.Add(Label23)
        Panel4.Controls.Add(ListBoxPDFToSource)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(ListBoxBooksToSource)
        Panel4.Controls.Add(ListBoxBooksOnOrder)
        Panel4.Location = New Point(2544, 69)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(769, 697)
        Panel4.TabIndex = 47
        ' 
        ' BookCountListBox
        ' 
        BookCountListBox.FormattingEnabled = True
        BookCountListBox.ItemHeight = 15
        BookCountListBox.Location = New Point(357, 440)
        BookCountListBox.Name = "BookCountListBox"
        BookCountListBox.Size = New Size(400, 79)
        BookCountListBox.TabIndex = 50
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(357, 416)
        Label21.Name = "Label21"
        Label21.Size = New Size(103, 21)
        Label21.TabIndex = 33
        Label21.Text = "Book Count:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BackColor = SystemColors.Window
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(685, 982)
        Label22.Name = "Label22"
        Label22.Size = New Size(77, 21)
        Label22.TabIndex = 23
        Label22.Text = "Physical:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = SystemColors.Window
        Label23.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.Location = New Point(939, 982)
        Label23.Name = "Label23"
        Label23.Size = New Size(44, 21)
        Label23.TabIndex = 24
        Label23.Text = "PDF:"
        ' 
        ' ButtonRunEditor
        ' 
        ButtonRunEditor.BackColor = SystemColors.ActiveCaption
        ButtonRunEditor.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonRunEditor.Location = New Point(464, 13)
        ButtonRunEditor.Name = "ButtonRunEditor"
        ButtonRunEditor.Size = New Size(150, 30)
        ButtonRunEditor.TabIndex = 48
        ButtonRunEditor.Text = "Launch Editor"
        ButtonRunEditor.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TextBoxObjectCount
        ' 
        TextBoxObjectCount.BackColor = SystemColors.Menu
        TextBoxObjectCount.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxObjectCount.Location = New Point(747, 14)
        TextBoxObjectCount.Name = "TextBoxObjectCount"
        TextBoxObjectCount.Size = New Size(132, 29)
        TextBoxObjectCount.TabIndex = 49
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.BackColor = SystemColors.Menu
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label25.Location = New Point(639, 17)
        Label25.Name = "Label25"
        Label25.Size = New Size(102, 21)
        Label25.TabIndex = 49
        Label25.Text = "Total Books:"
        Label25.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCopyToWiki
        ' 
        btnCopyToWiki.BackColor = SystemColors.ActiveCaption
        btnCopyToWiki.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCopyToWiki.Location = New Point(910, 17)
        btnCopyToWiki.Name = "btnCopyToWiki"
        btnCopyToWiki.Size = New Size(150, 26)
        btnCopyToWiki.TabIndex = 50
        btnCopyToWiki.Text = "Copy to Wiki"
        btnCopyToWiki.UseVisualStyleBackColor = False
        ' 
        ' TextBoxWikiPageTitle
        ' 
        TextBoxWikiPageTitle.Location = New Point(1093, 20)
        TextBoxWikiPageTitle.Name = "TextBoxWikiPageTitle"
        TextBoxWikiPageTitle.Size = New Size(423, 23)
        TextBoxWikiPageTitle.TabIndex = 51
        ' 
        ' btnOpenWikiPage
        ' 
        btnOpenWikiPage.BackColor = SystemColors.HotTrack
        btnOpenWikiPage.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnOpenWikiPage.ForeColor = SystemColors.ButtonFace
        btnOpenWikiPage.Location = New Point(1522, 17)
        btnOpenWikiPage.Name = "btnOpenWikiPage"
        btnOpenWikiPage.Size = New Size(121, 26)
        btnOpenWikiPage.TabIndex = 52
        btnOpenWikiPage.Text = "Create New"
        btnOpenWikiPage.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(3325, 1263)
        Controls.Add(btnOpenWikiPage)
        Controls.Add(TextBoxWikiPageTitle)
        Controls.Add(btnCopyToWiki)
        Controls.Add(Label25)
        Controls.Add(TextBoxObjectCount)
        Controls.Add(ButtonRunEditor)
        Controls.Add(btnGenerateMD)
        Controls.Add(DataGridViewBookDetails)
        Controls.Add(TreeView1)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Name = "Form1"
        Text = "Master Book Vault"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(WebView2Description, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewBookDetails, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TextBoxBookName As TextBox
    Friend WithEvents TextBoxPublicationYear As TextBox
    Friend WithEvents PanelPdfLinks As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxISBN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents TextBoxPublisher As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxRules As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEdition As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxPhysical As TextBox
    Friend WithEvents TextBoxOwnedPDF As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents WebView2Description As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridViewBookDetails As DataGridView
    Friend WithEvents ListBoxBooksToSource As ListBox
    Friend WithEvents ListBoxBooksOnOrder As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListBoxPDFToSource As ListBox
    Friend WithEvents TextBoxSetting As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxType As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxFormat As TextBox
    Friend WithEvents TextBoxSeries As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnGenerateMD As Button
    Friend WithEvents TextBoxAuthor As RichTextBox
    Friend WithEvents ListBoxTOC As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ButtonRunEditor As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label21 As Label
    Friend WithEvents BookCountListBox As ListBox
    Friend WithEvents TextBoxCharLvl As TextBox
    Friend WithEvents TextBoxObjectCount As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PanelMDLInks As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents btnCopyToWiki As Button
    Friend WithEvents TextBoxWikiPageTitle As TextBox
    Friend WithEvents btnOpenWikiPage As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents MDLinksWSpells As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents MDLinksMagicItems As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents MDLinksMonsters As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents MDLinksPSpells As Panel
End Class
