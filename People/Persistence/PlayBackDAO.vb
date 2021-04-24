Public Class PlayBackDAO
    Public ReadOnly Property PlayBacks As Collection

    Public Sub New()
        Me.PlayBacks = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim p As PlayBack
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM PLAYBACKS ORDER BY idPlay")
        For Each aux In col
            p = New PlayBack(CType(aux(1).ToString, Integer))
            p.user = New User(aux(2).ToString)
            p.song = New Song(CType(aux(3).ToString, Integer))
            p.plDate = aux(4).ToString
            Me.PlayBacks.Add(p)
        Next
    End Sub

    Public Sub ReadAllHistory(ByRef s As Song)
        Dim p As PlayBack
        Dim col, aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM PLAYBACKS WHERE song=" & s.idSong & ";")
        For Each aux In col
            p = New PlayBack(CType(aux(1).ToString, Integer))
            p.user = New User(aux(2).ToString)
            p.song = New Song(CType(aux(3).ToString, Integer))
            p.plDate = aux(4).ToString
            Me.PlayBacks.Add(p)
        Next
    End Sub



    Public Sub Read(ByRef p As PlayBack)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM PLAYBACKS WHERE idPlay='" & p.idPlay & "';")
        For Each aux In col
            p.user = New User(aux(2).ToString)
            p.song = New Song(CType(aux(3).ToString, Integer))
            p.plDate = aux(4).ToString
        Next
    End Sub

    Public Function Insert(ByVal p As PlayBack) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO [PLAYBACKS] ([user],[song],[plDate]) VALUES ('" & p.user.Email & "'," & p.song.idSong & ",#" & p.plDate & "#);")
    End Function

End Class
