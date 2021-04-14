Public Class AlbumDAO

    Public ReadOnly Property Albums As Collection

    Public Sub New()
        Me.Albums = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim a As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM ALBUMS ORDER BY idAlbum")
        For Each aux In col
            a = New Album(CType(aux(1).ToString, Integer))
            a.aName = aux(2).ToString
            a.releaseDate = aux(3).ToString
            a.artist = New Artist(CType(aux(4).ToString, Integer))
            a.cover = aux(5).ToString
            Me.Albums.Add(a)
        Next
    End Sub

    Public Sub Read(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ALBUMS WHERE idAlbum=" & a.idAlbum & ";")
        For Each aux In col
            a.aName = aux(2).ToString
            a.releaseDate = aux(3).ToString
            a.artist = New Artist(CType(aux(4).ToString, Integer))
            a.cover = aux(5).ToString
        Next
    End Sub

    Public Sub ReadSearcher(search As String)
        Dim a As Album
        Dim chain As String = search + "%"
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ALBUMS WHERE aName LIKE '" + chain + "';")
        For Each aux In col
            a = New Album(CType(aux(1).ToString, Integer))
            a.aName = aux(2).ToString
            a.releaseDate = aux(3).ToString
            a.artist = New Artist(CType(aux(4).ToString, Integer))
            a.cover = aux(5).ToString
            Me.Albums.Add(a)
        Next
    End Sub

End Class