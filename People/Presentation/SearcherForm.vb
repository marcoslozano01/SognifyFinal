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
        Dim song As Song
        song = CType(ListSongs.SelectedItem, Song)
        Dim f As Form = New SongForm(song, user)
        f.Show()
    End Sub

    Private Sub ListArtists_DoubleClick(sender As Object, e As EventArgs) Handles ListArtists.DoubleClick
        Dim artist As Artist
        artist = CType(ListArtists.SelectedItem, Artist)
        Dim f As Form = New ArtistForm(artist, user, filePath)
        f.Show()
    End Sub

    Private Sub ListAlbums_DoubleClick(sender As Object, e As EventArgs) Handles ListAlbums.DoubleClick
        Dim album As Album
        album = CType(ListAlbums.SelectedItem, Album)
        Dim f As Form = New AlbumForm(album, user, filePath)
        f.Show()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        loginForm.Show()
        Hide()
    End Sub
End Class