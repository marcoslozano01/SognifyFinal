Public Class Buscador
    Dim song As Song
    Dim artist As Artist
    Dim album As Album
    Public Property user As User

    Public Sub New(ByRef user As User)
        InitializeComponent()
        Me.user = user
    End Sub
    Private Sub BuscadorTextBox_TextChanged(sender As Object, e As EventArgs) Handles BuscadorTextBox.TextChanged

        Dim s As Song = New Song
        Dim a As Artist = New Artist
        Dim al As Album = New Album
        ListSongs.Items.Clear()
        ListArtists.Items.Clear()
        ListAlbums.Items.Clear()
        If BuscadorTextBox.Text <> "" Then
            Try
                s.ReadSearcher(BuscadorTextBox.Text)
                a.ReadSearcher(BuscadorTextBox.Text)
                al.ReadSearcher(BuscadorTextBox.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            For Each song In s.SongDAO.songs
                ListSongs.Items.Add(song.sName)
            Next
            For Each artist In a.ArtistDAO.Artists
                ListArtists.Items.Add(artist.aName)
            Next
            For Each album In al.AlbumDAO.Albums
                ListAlbums.Items.Add(album.aName)
            Next
        End If

    End Sub

    Private Sub ListAlbums_DoubleClick(sender As Object, e As EventArgs) Handles ListAlbums.DoubleClick

    End Sub

    Private Sub ListSongs_DoubleClick(sender As Object, e As EventArgs) Handles ListSongs.DoubleClick
        Dim song As Song = New Song()
        song.sName = ListSongs.SelectedItem.ToString
        song.ReadSongByName()
        Dim f As Form = New SongForm(song, user)
        f.Show()
    End Sub

    Private Sub ListArtists_DoubleClick(sender As Object, e As EventArgs) Handles ListArtists.DoubleClick
        Dim artist As Artist = New Artist()
        artist.aName = ListArtists.SelectedItem.ToString
        artist.ReadArtistByName()
        Dim f As Form = New ArtistForm(artist, user)
        f.Show()
    End Sub

    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class