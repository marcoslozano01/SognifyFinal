Public Class SearcherForm
    Dim song As Song
    Dim artist As Artist
    Dim album As Album
    Public Property user As User
    Public Property filePath As String

    Public Sub New(ByRef user As User, ByRef filePath As String)
        InitializeComponent()
        Me.user = user
        Me.filePath = filePath
    End Sub
    Private Sub BuscadorTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearcherTextBox.TextChanged

        Dim s As Song = New Song
        Dim a As Artist = New Artist
        Dim al As Album = New Album
        ListSongs.Items.Clear()
        ListArtists.Items.Clear()
        ListAlbums.Items.Clear()
        If SearcherTextBox.Text <> "" Then
            Try
                s.ReadSearcher(SearcherTextBox.Text)
                a.ReadSearcher(SearcherTextBox.Text)
                al.ReadSearcher(SearcherTextBox.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            For Each song In s.SongDAO.songs
                ListSongs.Items.Add(song)
            Next
            For Each artist In a.ArtistDAO.Artists
                ListArtists.Items.Add(artist)
            Next
            For Each album In al.AlbumDAO.Albums
                ListAlbums.Items.Add(album)
            Next
        End If

    End Sub
    Private Sub ListSongs_DoubleClick(sender As Object, e As EventArgs) Handles ListSongs.DoubleClick
        If ListSongs.SelectedItem IsNot Nothing Then
            Dim song As Song
            Try
                song = CType(ListSongs.SelectedItem, Song)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Dim f As Form = New SongForm(song, user)
            f.Show()
        End If
    End Sub

    Private Sub ListArtists_DoubleClick(sender As Object, e As EventArgs) Handles ListArtists.DoubleClick
        If ListArtists.SelectedItem IsNot Nothing Then
            Dim artist As Artist
            Try
                artist = CType(ListArtists.SelectedItem, Artist)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Dim f As Form = New ArtistForm(artist, user, filePath)
            f.Show()
        End If
    End Sub
    Private Sub ListAlbums_DoubleClick(sender As Object, e As EventArgs) Handles ListAlbums.DoubleClick
        If ListAlbums.SelectedItem IsNot Nothing Then
            Dim album As Album
            Try
                album = CType(ListAlbums.SelectedItem, Album)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Dim f As Form = New AlbumForm(album, user, filePath)
            f.Show()
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        loginForm.Show()
        Hide()
    End Sub

    Private Sub UsersByPB_Click(sender As Object, e As EventArgs) Handles UsersByPB.Click
        Dim u As User = New User()
        Dim User As User
        Dim chain As String = ""
        Try
            u.readUserShort()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For Each User In u.UserDAO.Users
            chain = chain & User.Email & vbCrLf
        Next
        MessageBox.Show(chain)
    End Sub

    Private Sub ArtistsByPB_Click(sender As Object, e As EventArgs) Handles ArtistsByPB.Click
        Dim a As Artist = New Artist()
        Dim artist As Artist
        Dim chain As String = ""
        Try
            a.ReadArtistsSort()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For Each artist In a.ArtistDAO.Artists
            chain = chain & artist.aName & vbCrLf
        Next
        MessageBox.Show(chain)
    End Sub

    Private Sub SongsByPB_Click(sender As Object, e As EventArgs) Handles SongsByPB.Click
        Dim s As Song = New Song()
        Dim song As Song
        Dim chain As String = ""
        Try
            s.ReadSongsSort()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For Each song In s.SongDAO.songs
            chain = chain & song.sName & vbCrLf
        Next
        MessageBox.Show(chain)
    End Sub

    Private Sub PBTimeOfFav_Click(sender As Object, e As EventArgs) Handles PBTimeOfFav.Click
        Try
            If user.ReadTotalTime = "" Then
                MessageBox.Show(secondsLength(0))
            Else
                MessageBox.Show(secondsLength(CType(user.ReadTotalTime, Integer)))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ArtistsByUserPB_Click(sender As Object, e As EventArgs) Handles ArtistsByUserPB.Click
        Dim f As Form = New DatesForm(user)
        f.Show()
    End Sub
    Private Function secondsLength(segundos As Integer) As String
        Dim hor As Integer
        Dim min As Integer
        Dim seg As Integer
        hor = CType(Math.Floor(segundos / 3600), Integer)
        min = CType(Math.Floor((segundos - hor * 3600) / 60), Integer)
        seg = segundos - (hor * 3600 + min * 60)
        Return hor & " h " & min & " m " & seg & " s"
    End Function
End Class