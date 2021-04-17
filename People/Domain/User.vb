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

    Public Function DeleteUser() As Integer
        Return Me.UserDAO.Delete(Me)
    End Function

    Public Function insertUser() As Integer
        Return Me.UserDAO.Insert(Me)
    End Function


End Class
