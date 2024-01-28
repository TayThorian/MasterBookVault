Public Class Book
    Public Property BookName As String

    Public Property BookShortName As String
    Public Property BookPublisher As String
    Public Property BookCode As String
    Public Property BookISBN As String
    Public Property BookAuthor As String
    Public Property BookPublished As String
    Public Property BookCover As String
    Public Property BookRules As String
    Public Property BookEdition As String
    Public Property BookPhysical As String
    Public Property BookOwnedPDF As String
    Public Property BookLibrary As String
    Public Property BookSetting As String
    Public Property BookType As String
    Public Property BookFormat As String
    Public Property BookSeries As String
    Public Property BookCharacterLevel As String
    Public Property BookPDF As List(Of String)
    Public Property BookDescription As String()

    Public Property TableOfContents As TableOfContents

    ' Add any additional properties as necessary
End Class

Public Class Chapter
    Public Property Page As Integer
    Public Property Title As String
End Class

Public Class TableOfContents
    Public Property Title As String
    Public Property Chapters As List(Of Chapter)
End Class
