Public Class login
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

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        If ListBox.SelectedItem IsNot Nothing Then
            clearBoxes()
            insertBtt.Enabled = False
            deleteBtt.Enabled = True
            updateBtt.Enabled = True
            Select Case ComboBox.SelectedIndex
                Case 0
                    readSong()
                Case 1
                    readAlbum()
                Case 2
                    readArtist()
                Case 3
                    readuser()
            End Select
        End If
    End Sub

    Public Sub readSong()
        Dim song As Song = New Song()
        song.sName = ListBox.SelectedItem.ToString
        Try
            song.ReadSongByName()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        nameBox.Text = song.sName
        song.album.ReadAlbum()
        albumBox.Text = song.album.aName
        lengthBox.Text = CType(song.length, String)
    End Sub

    Public Sub readAlbum()
        Dim album As Album = New Album()
        album.aName = ListBox.SelectedItem.ToString
        Try
            album.ReadAlbumByName()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        albumBox.Text = album.aName
        relaseDateBox.Text = album.releaseDate
        album.artist.ReadArtist()
        coverBox.Text = album.cover
        artistBox.Text = album.artist.aName
    End Sub

    Public Sub readArtist()
        Dim artist As Artist = New Artist()
        artist.aName = ListBox.SelectedItem.ToString
        Try
            artist.ReadArtistByName()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        artistBox.Text = artist.aName
        countryBox.Text = artist.country
    End Sub

    Public Sub readuser()
        Dim user As User = New User(ListBox.SelectedItem.ToString)
        Try
            user.ReadUser()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        emailBox.Text = user.Email
        nameBox.Text = user.uName
        surnameBox.Text = user.uSurname
        birthDateBox.Text = user.birthdate
    End Sub

    Public Sub deleteUser()
        Dim user As User = New User(emailBox.Text)
        Dim playback = New PlayBack
        Dim fav_artist = New Artist
        playback.user = New User(user.Email)
        fav_artist.user = New User(user.Email)
        Try
            fav_artist.deletefavArtistByUser()
            playback.deletePlayBackByUser()
            user.DeleteUser()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()
    End Sub

    Public Sub deleteArtist(aName As String)
        Dim artist = New Artist()
        Dim album As Album
        Dim fav_artist = New Artist
        al = New Album
        artist.aName = aName
        artist.ReadArtistByName()
        Me.al.ReadAllAlbums(filePath)
        fav_artist.artist = New Artist(artist.idArtist)
        fav_artist.ReadArtist()
        Try
            For Each album In Me.al.AlbumDAO.Albums
                album.artist.ReadArtist()
                If album.artist.idArtist = artist.idArtist Then
                    deleteAlbum(album.aName)
                End If
            Next
            fav_artist.deletefavArtistByArtist()
            artist.DeleteArtist()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()


    End Sub

    Public Sub deleteAlbum(aName As String)
        Dim album As Album = New Album()
        Dim song As Song
        Me.s = New Song
        album.aName = aName
        album.ReadAlbumByName()
        Me.s.ReadAllSongs(filePath)
        Try
            For Each song In Me.s.SongDAO.songs
                song.album.ReadAlbum()
                If song.album.idAlbum = album.idAlbum Then
                    deleteSong(song.sName)
                End If
            Next
            album.DeleteAlbum()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()

    End Sub

    Private Sub deleteSong(sName As String)

        Dim song As Song = New Song()
        Dim playBack = New PlayBack
        song.sName = sName
        Try
            song.ReadSongByName()
            playBack.song = song
            playBack.deletePlayBackBySong()
            song.Delete()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()

    End Sub

    Private Sub insertUser(email As String)
        Me.user = New User(email)
        user.uName = nameBox.Text
        user.uSurname = surnameBox.Text
        user.birthdate = birthDateBox.Text
        Try
            If user.insertUser <> 1 Then
                MessageBox.Show("This user already exists")
                Exit Sub
            End If
            ListBox.Items.Add(user.Email)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function insertArtist(aName As String) As Integer
        Me.a = New Artist()
        a.aName = artistBox.Text
        a.country = countryBox.Text
        Try
            If a.InsertArtist <> 1 Then
                MessageBox.Show("This artist already exist")
                Exit Function
            End If
            ListBox.Items.Add(a.aName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        a.ReadArtistByName()
        Return a.idArtist
    End Function

    Private Sub insertAlbum(aName As String)
        Me.al = New Album()
        Dim artist = New Artist
        al.aName = albumBox.Text
        al.releaseDate = relaseDateBox.Text
        artist.aName = artistBox.Text
        artist.ReadArtistByName()
        If artist.idArtist = 0 And countryBox.Enabled = False Then
            MessageBox.Show("This artist doesnt exists")
            initArtistBox()
        Else
            al.artist = New Artist(insertArtist(artistBox.Text))
            MessageBox.Show(CType(al.artist.idArtist, String))
            Try
                If al.InsertAlbum <> 1 Then
                    MessageBox.Show("This artist already exist")
                    Exit Sub
                End If
                ListBox.Items.Add(al.aName)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub deleteBtt_Click(sender As Object, e As EventArgs) Handles deleteBtt.Click
        Select Case ComboBox.SelectedIndex
            Case 0
                deleteSong(ListBox.SelectedItem.ToString)
                ListBox.Items.RemoveAt(ListBox.SelectedIndex)
            Case 1
                deleteAlbum(ListBox.SelectedItem.ToString)
                ListBox.Items.RemoveAt(ListBox.SelectedIndex)
            Case 2
                deleteArtist(ListBox.SelectedItem.ToString)
                ListBox.Items.RemoveAt(ListBox.SelectedIndex)
            Case 3
                deleteUser()
                ListBox.Items.RemoveAt(ListBox.SelectedIndex)
        End Select
    End Sub
    Private Sub insertBtt_Click(sender As Object, e As EventArgs) Handles insertBtt.Click
        Select Case ComboBox.SelectedIndex
            Case 0
                'insertSong()
                readallSongs()
            Case 1
                insertAlbum(albumBox.Text)
                clearBoxes()

            Case 2
                insertArtist(artistBox.Text)
                clearBoxes()
            Case 3
                insertUser(emailBox.Text)
                clearBoxes()
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
        clearBoxes()
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

    Private Sub ClearBtt_Click(sender As Object, e As EventArgs) Handles ClearBtt.Click
        clearBoxes()
        insertBtt.Enabled = True
        updateBtt.Enabled = False
        deleteBtt.Enabled = False

    End Sub


End Class