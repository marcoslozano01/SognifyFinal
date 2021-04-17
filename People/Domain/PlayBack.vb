Public Class PlayBack
    Public Property idPlay As Integer
    Public Property user As User
    Public Property song As Song
    Public Property plDate As String
    Public ReadOnly Property PlayBackDAO As PlayBackDAO

    Public Sub New()
        Me.PlayBackDAO = New PlayBackDAO
    End Sub

    Public Sub New(id As Integer)
        Me.PlayBackDAO = New PlayBackDAO
        Me.idPlay = id
    End Sub

    Public Sub ReadAllPlayBAcks(path As String)
        Me.PlayBackDAO.ReadAll(path)
    End Sub

    Public Sub ReadHistory(s As Song)
        Me.PlayBackDAO.ReadByName(s)
    End Sub
    Public Sub ReadPlayBack()
        Me.PlayBackDAO.Read(Me)
    End Sub

    Public Function InsertPlayBack() As Integer
        Return Me.PlayBackDAO.Insert(Me)
    End Function

    Public Function deletePlayBack() As Integer
        Return Me.PlayBackDAO.Delete(Me)
    End Function

End Class
