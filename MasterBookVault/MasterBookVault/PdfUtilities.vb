Imports PdfiumViewer
Imports System.Drawing

Public Class PdfUtilities
    Public Shared Function GetPdfFirstPageAsImage(pdfFilePath As String) As Image
        Try
            Using pdfDocument As PdfDocument = PdfDocument.Load(pdfFilePath)
                Return pdfDocument.Render(0, 300, 300, True)  ' Renders the first page
            End Using
        Catch ex As Exception
            MessageBox.Show("Error rendering PDF: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class
