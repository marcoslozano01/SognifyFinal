Public Class UserDAO

    Public ReadOnly Property Users As Collection

    Public Sub New()
        Me.Users = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim u As User
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM USERS ORDER BY Email")
        For Each aux In col
            u = New User(aux(1).ToString)
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthdate = aux(4).ToString
            Me.Users.Add(u)
        Next
    End Sub
    Public Function ReadTotalTime(ByRef u As User) As String
        Dim s As String
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT Sum(SONGS.length) FROM (((FAV_ARTISTS INNER JOIN ALBUMS ON FAV_ARTISTS.artist = ALBUMS.artist) INNER JOIN SONGS ON ALBUMS.idAlbum = SONGS.album) INNER JOIN PLAYBACKS ON SONGS.idSong = PLAYBACKS.song) WHERE PLAYBACKS.user='" & u.Email & "' ORDER BY count(SONGS.length) DESC;")
        For Each aux In col
            s = aux(1).ToString
        Next
        Return s
    End Function

    Public Sub ReadUsersSort()
        Dim u As User
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT PLAYBACKS.user, Sum(SONGS.length) FROM PLAYBACKS INNER JOIN SONGS ON SONGS.idSong = PLAYBACKS.song GROUP BY PLAYBACKS.user ORDER BY Sum(SONGS.length) DESC;")
        Dim s As String = ""
        For Each aux In col
            u = New User(aux(1).ToString)
            Me.Users.Add(u)
        Next
    End Sub

    Public Sub Read(ByRef u As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM USERS WHERE Email='" & u.Email & "';")
        For Each aux In col
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthdate = aux(4).ToString
        Next
    End Sub

    Public Function Delete(ByVal u As User) As Integer
        Dim columns As Integer
        columns += DBBroker.GetBroker.Change("Delete * From FAV_ARTISTS Where Exists( Select 1 From USERS Where FAV_ARTISTS.user='" & u.Email & "') = True;")
        columns += DBBroker.GetBroker.Change("Delete * From PLAYBACKS Where Exists( Select 1 From USERS Where PLAYBACKS.user='" & u.Email & "') = True;")
        columns += DBBroker.GetBroker.Change("DELETE FROM USERS WHERE Email='" & u.Email & "';")
        Return columns
    End Function

    Public Function Insert(ByVal u As User) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO [USERS]  VALUES ('" & u.Email & "','" & u.uName & "','" & u.uSurname & "',#" & u.birthdate & "#);")
    End Function

    Public Function Update(ByVal u As User) As Integer
        Return DBBroker.GetBroker.Change("UPDATE USERS SET uName='" & u.uName & "', uSurname='" & u.uSurname & "', birthdate='" & u.birthdate & "' WHERE Email='" & u.Email & "';")
    End Function
End Class
