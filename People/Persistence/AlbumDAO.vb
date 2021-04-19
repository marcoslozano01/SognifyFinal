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

    Public Sub ReadAllByArtist(path As String, ByRef al As Album)
        Dim a As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM ALBUMS WHERE artist=" & al.artist.idArtist & ";")
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
    Public Sub ReadByName(ByRef al As Album)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ALBUMS WHERE aName='" & al.aName & "';")
        For Each aux In col
            al.idAlbum = CType(aux(1).ToString, Integer)
            al.releaseDate = aux(3).ToString
            al.artist = New Artist(CType(aux(4).ToString, Integer))
            al.cover = aux(5).ToString
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

    Public Function Insert(ByVal al As Album) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO [ALBUMS] ([aName],[releaseDate],[artist],[cover]) VALUES ('" & al.aName & "',#" & al.releaseDate & "#," & al.artist.idArtist & ",'" & al.cover & "');")
    End Function

    Public Function DeleteByArtist(ByVal al As Album) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM ALBUMS WHERE artist=" & al.artist.idArtist & ";")
    End Function

    Public Function Delete(ByVal al As Album) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM ALBUMS WHERE IdAlbum=" & al.idAlbum & ";")
    End Function

    Public Function Update(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("UPDATE ALBUMS SET aName='" & a.aName & "', releaseDate='" & a.releaseDate & "', cover='" & a.cover & "' WHERE idAlbum=" & a.idAlbum & ";")
    End Function

End Class