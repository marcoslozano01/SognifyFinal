Public Class SongDAO

    Public ReadOnly Property songs As Collection

    Public Sub New()
        Me.songs = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim S As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM SONGS ORDER BY idSong")
        For Each aux In col
            S = New Song(CType(aux(1).ToString, Integer))
            S.sName = aux(2).ToString
            S.album = New Album(CType(aux(3).ToString, Integer))
            S.length = CType(aux(4).ToString, Integer)
            Me.songs.Add(S)
        Next
    End Sub

    Public Sub Read(ByRef s As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM SONGS WHERE idSong=" & s.idSong & ";")
        For Each aux In col
            s.sName = aux(2).ToString
            s.album = New Album(CType(aux(3).ToString, Integer))
            s.length = CType(aux(4).ToString, Integer)
        Next
    End Sub

    Public Sub ReadSearcher(search As String)
        Dim song As Song
        Dim chain As String = search + "%"
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM SONGS WHERE sName LIKE '" + chain + "';")
        For Each aux In col
            song = New Song(CType(aux(1).ToString, Integer))
            song.sName = aux(2).ToString
            song.album = New Album(CType(aux(3).ToString, Integer))
            song.length = CType(aux(4).ToString, Integer)
            Me.songs.Add(song)
        Next
    End Sub

    Public Sub ReadByName(ByRef s As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM SONGS WHERE sName='" & s.sName & "';")
        For Each aux In col
            s.idSong = CType(aux(1).ToString, Integer)
            s.album = New Album(CType(aux(3).ToString, Integer))
            s.length = CType(aux(4).ToString, Integer)
        Next
    End Sub
    Public Sub ReadAllByAlbum(ByRef a As Album, path As String)
        Dim S As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM SONGS WHERE Album=" & a.idAlbum & ";")
        For Each aux In col
            S = New Song(CType(aux(1).ToString, Integer))
            S.sName = aux(2).ToString
            S.album = New Album(CType(aux(3).ToString, Integer))
            S.length = CType(aux(4).ToString, Integer)
            Me.songs.Add(S)
        Next
    End Sub

    Public Function Insert(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO [SONGS] ([sName],[Album],[length]) VALUES ('" & s.sName & "'," & s.album.idAlbum & "," & s.length & ");")
    End Function

    Public Function DeleteByAlbum(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM SONGS WHERE Album=" & s.album.idAlbum & ";")
    End Function

    Public Function Delete(ByVal s As Song) As Integer

        Return DBBroker.GetBroker.Change("DELETE FROM SONGS WHERE IdSong=" & s.idSong & ";")

    End Function

    Public Function Update(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE SONGS SET sName='" & s.sName & "', length=" & s.length & " WHERE idSong=" & s.idSong & ";")
    End Function

End Class
