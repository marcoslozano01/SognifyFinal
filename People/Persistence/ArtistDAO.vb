Public Class ArtistDAO

    Public ReadOnly Property Artists As Collection
    Public ReadOnly Property FavArtists As Collection

    Public Sub New()
        Me.Artists = New Collection
        Me.FavArtists = New Collection
    End Sub

    Public Sub ReadAllArtist(path As String)
        Dim a As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM ARTISTS ORDER BY idArtist")
        For Each aux In col
            a = New Artist(CType(aux(1).ToString, Integer))
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
            Me.Artists.Add(a)
        Next
    End Sub

    Public Sub ReadArtist(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ARTISTS WHERE idArtist=" & a.idArtist & ";")
        For Each aux In col
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
        Next
    End Sub


    Public Sub ReadAllFavArtist(path As String)
        Dim a As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM FAV_ARTIST ORDER BY idArtist")
        For Each aux In col
            a = New Artist(New User(aux(1).ToString), New Artist(CType(aux(2).ToString, Integer)))
            a.favDate = aux(3).ToString
            Me.Artists.Add(a)
        Next
    End Sub

    Public Function ReadFavArtist(ByRef a As Artist) As Integer
        Dim check As Integer = 0
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM FAV_ARTISTS WHERE user='" & a.user.Email & "' AND  artist=" & a.artist.idArtist & ";")
        For Each aux In col
            check = 1
            a.favDate = aux(3).ToString
        Next
        Return check
    End Function

    Public Sub ReadSearcher(search As String)
        Dim a As Artist
        Dim chain As String = search + "%"
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ARTISTS WHERE aName LIKE '" + chain + "';")
        For Each aux In col
            a = New Artist(CType(aux(1).ToString, Integer))
            a.aName = aux(2).ToString
            a.country = aux(3).ToString
            a.image = aux(4).ToString
            Me.Artists.Add(a)
        Next
    End Sub

    Public Function InsertFav(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO [FAV_ARTISTS] ([user],[artist],[favDate]) VALUES ('" & a.user.Email & "'," & a.artist.idArtist & ",#" & a.favDate & "#);")
    End Function
    Public Function Insert(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO [ARTISTS] ([aName],[country],[image]) VALUES ('" & a.aName & "','" & a.country & "','" & a.image & "');")
    End Function

    Public Function Delete(ByVal a As Artist) As Integer
        Dim columns As Integer
        columns += DBBroker.GetBroker.Change("DELETE DISTINCTROW PLAYBACKS.* FROM ((PLAYBACKS INNER JOIN SONGS  ON PLAYBACKS.song = SONGS.IdSong) INNER JOIN ALBUMS ON SONGS.Album= ALBUMS.IdAlbum) INNER JOIN ARTISTS ON ALBUMS.Artist= ARTISTS.IdArtist WHERE ARTISTS.IdArtist=" & a.idArtist & ";")
        columns += DBBroker.GetBroker.Change("DELETE DISTINCTROW SONGS.* FROM (SONGS INNER JOIN ALBUMS ON SONGS.Album = ALBUMS.IdAlbum) INNER JOIN ARTISTS ON ALBUMS.Artist = ARTISTS.IdArtist WHERE ARTISTS.IdArtist=" & a.idArtist & ";")
        columns += DBBroker.GetBroker.Change("Delete * From AlBUMS Where Exists( Select 1 From ARTISTS Where ALBUMS.Artist =" & a.idArtist & ") = True;")
        columns += DBBroker.GetBroker.Change("DELETE FROM ARTISTS WHERE IdArtist=" & a.idArtist & ";")
        Return columns
    End Function

    Public Function DeleteFav(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM [FAV_ARTISTS] WHERE user='" & a.user.Email & "' AND artist=" & a.artist.idArtist & ";")
    End Function

    Public Function Update(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE [ARTISTS] SET [aName]='" & a.aName & "', [country]='" & a.country & "', [image]='" & a.image & "' WHERE [idArtist]=" & a.idArtist & ";")
    End Function

End Class