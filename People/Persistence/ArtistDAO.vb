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

    Public Sub ReadFavArtist(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM FAV_ARTISTS WHERE user='" & a.user.Email & "' AND  artist='" & a.artist.idArtist & "';")
        For Each aux In col
            a.favDate = aux(3).ToString
        Next
    End Sub

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

    Public Sub ReadByName(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM ARTISTS WHERE aName='" & a.aName & "';")
        For Each aux In col
            a.idArtist = CType(aux(1).ToString, Integer)
            a.country = aux(3).ToString
            a.image = aux(4).ToString
        Next
    End Sub

    Public Function Insert(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO [ARTISTS] ([aName],[country],[image]) VALUES ('" & a.aName & "','" & a.country & "','" & a.image & "');")
    End Function

    Public Function Delete(ByVal f As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM FAV_ARTISTS WHERE artist='" & f.idArtist & "';")
    End Function

End Class