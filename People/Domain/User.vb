Public Class User
    Public Property Email As String

    Public Property uName As String

    Public Property uSurname As String

    Public Property birthdate As String

    Public ReadOnly Property UserDAO As UserDAO

    Public Sub New()
        Me.UserDAO = New UserDAO

    End Sub
    Public Sub New(Email As String)
        Me.UserDAO = New UserDAO
        Me.Email = Email
    End Sub

    Public Sub ReadAllUsers(path As String)
        Me.UserDAO.ReadAll(path)
    End Sub

    Public Sub ReadUser()
        Me.UserDAO.Read(Me)
    End Sub
End Class
