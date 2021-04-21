Public Class Album
    Public Property idAlbum As Integer

    Public Property aName As String = ""

    Public Property releaseDate As String = ""

    Public Property artist As Artist

    Public Property cover As String = ""

    Public ReadOnly Property AlbumDAO As AlbumDAO

    Public Sub New()
        Me.AlbumDAO = New AlbumDAO
    End Sub
    Public Sub New(idAlbum As Integer)
        Me.AlbumDAO = New AlbumDAO
        Me.idAlbum = idAlbum
    End Sub

    Public Sub ReadAllAlbums(path As String)
        Me.AlbumDAO.ReadAll(path)
    End Sub

    Public Sub ReadAllAlbumsByArtist(path As String)
        Me.AlbumDAO.ReadAllByArtist(path, Me)
    End Sub

    Public Sub ReadAlbum()
        Me.AlbumDAO.Read(Me)
    End Sub

    Public Sub ReadSearcher(chain As String)
        Me.AlbumDAO.ReadSearcher(chain)
    End Sub

    Public Function InsertAlbum() As Integer
        Return Me.AlbumDAO.Insert(Me)
    End Function

    Public Function DeleteAlbum() As Integer
        Return Me.AlbumDAO.Delete(Me)
    End Function
    Public Function updateAlbum() As Integer
        Return Me.AlbumDAO.update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.aName
    End Function

End Class
