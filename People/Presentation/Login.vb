Public Class Login
    Property ofdPath1 As OpenFileDialog = New OpenFileDialog
    Dim filePath As String
    Dim user As User
    Dim usr As User



    Private Sub ChooseDB_Click(sender As Object, e As EventArgs) Handles ChooseDB.Click
        Try
            If ofdPath1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                filePath = ofdPath1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub loginBtt_Click(sender As Object, e As EventArgs) Handles loginBtt.Click
        Dim u As User = New User
        u.ReadAllUsers(filePath)
        Dim check As Boolean
        Try
            For Each user In u.UserDAO.Users
                If user.Email = TextBoxEmail.Text Then
                    check = True
                    usr = New User(TextBoxEmail.Text)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If check = True Then
            Me.Hide()
            usr.ReadUser()
            Dim b As Buscador = New Buscador(usr)
            b.Show()
        Else
            MessageBox.Show("Login incorrect")
        End If
    End Sub


End Class