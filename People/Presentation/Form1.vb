﻿Class Form1
    Property ofdPath1 As OpenFileDialog = New OpenFileDialog
    Dim filePath As String
    Dim user As User
    Dim s As Song
    Dim a As Artist
    Dim al As Album



    Private Sub ChooseDB_Click(sender As Object, e As EventArgs) Handles ChooseDB.Click
        ofdPath1.Filter = "Microsoft Access Database (.accdb)|*.accdb"
        Try
            If ofdPath1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                filePath = ofdPath1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        loginBtt.Enabled = True
    End Sub

    Private Sub loginBtt_Click(sender As Object, e As EventArgs) Handles loginBtt.Click
        Dim u As User = New User
        Dim usr As User
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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginBtt.Enabled = False
        ComboBox.Items.Add("Song")
        ComboBox.Items.Add("Album")
        ComboBox.Items.Add("Artist")
        ComboBox.Items.Add("User")
        resetLabels()
        updateBtt.Enabled = False
        deleteBtt.Enabled = False

    End Sub

    Private Sub readallSongs()
        Dim song As Song
        s = New Song
        Me.s.ReadAllSongs(filePath)
        Try
            For Each song In Me.s.SongDAO.songs
                ListBox.Items.Add(song.sName)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub readallArtist()
        Dim artist As Artist
        a = New Artist
        Me.a.ReadAllArtists(filePath)
        Try
            For Each artist In Me.a.ArtistDAO.Artists
                ListBox.Items.Add(artist.aName)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub readallAlbums()
        Dim album As Album
        al = New Album
        Me.al.ReadAllAlbums(filePath)
        Try
            For Each album In Me.al.AlbumDAO.Albums
                ListBox.Items.Add(album.aName)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub readallUsers()
        Dim u As User
        user = New User
        Me.user.ReadAllUsers(filePath)
        Try
            For Each u In Me.user.UserDAO.Users
                ListBox.Items.Add(u.Email)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub insertBtt_Click(sender As Object, e As EventArgs) Handles insertBtt.Click
        Select Case ComboBox.SelectedIndex
            Case 0
                'insertSong()
                readallSongs()
            Case 1
                'insertAlbum()
                readallAlbums()

            Case 2
                'insertArtist()
                readallArtist()
        End Select


    End Sub

    Public Sub clearBoxes()
        nameBox.Clear()
        relaseDateBox.Clear()
        artistBox.Clear()
        albumBox.Clear()
        nameBox.Clear()
        countryBox.Clear()
        coverBox.Clear()
        emailBox.Clear()
        birthDateBox.Clear()
        surnameBox.Clear()
        lengthBox.Clear()

    End Sub
    Private Sub initSongBox()
        nameBox.Enabled = True
        nameLabel.Enabled = True
        albumBox.Enabled = True
        albumLabel.Enabled = True
        lengthBox.Enabled = True
        lengthLabel.Enabled = True
    End Sub
    Private Sub initAlbumBox()
        albumBox.Enabled = True
        albumLabel.Enabled = True
        relaseDateBox.Enabled = True
        relaseLabel.Enabled = True
        artistBox.Enabled = True
        artistLabel.Enabled = True
        coverBox.Enabled = True
        coverLabel.Enabled = True
    End Sub
    Private Sub initArtistBox()
        artistBox.Enabled = True
        artistLabel.Enabled = True
        countryBox.Enabled = True
        countryLabel.Enabled = True
    End Sub
    Private Sub initUserBox()
        emailBox.Enabled = True
        EmailLabel.Enabled = True
        nameBox.Enabled = True
        nameLabel.Enabled = True
        surnameBox.Enabled = True
        surnameLabel.Enabled = True
        birthDateBox.Enabled = True
        birthdateLabel.Enabled = True
    End Sub

    Private Sub ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedValueChanged
        resetLabels()
        ListBox.Items.Clear()

        Select Case ComboBox.SelectedIndex
            Case 0
                initSongBox()
                readallSongs()
            Case 1
                initAlbumBox()
                readallAlbums()
            Case 2
                initArtistBox()
                readallArtist()
            Case 3
                initUserBox()
                readallUsers()
        End Select
    End Sub
    Private Sub resetLabels()
        nameBox.Enabled = False
        nameLabel.Enabled = False
        birthDateBox.Enabled = False
        birthdateLabel.Enabled = False
        relaseDateBox.Enabled = False
        relaseLabel.Enabled = False
        artistBox.Enabled = False
        artistLabel.Enabled = False
        albumBox.Enabled = False
        albumLabel.Enabled = False
        coverBox.Enabled = False
        coverLabel.Enabled = False
        countryBox.Enabled = False
        countryLabel.Enabled = False
        emailBox.Enabled = False
        EmailLabel.Enabled = False
        surnameBox.Enabled = False
        surnameLabel.Enabled = False
        lengthBox.Enabled = False
        lengthLabel.Enabled = False
    End Sub

End Class