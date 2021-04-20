﻿Public Class SearcherForm
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
        Dim f As Form = New ArtistForm(artist, user, filePath)
        f.Show()
    End Sub

    Private Sub ListAlbums_DoubleClick(sender As Object, e As EventArgs) Handles ListAlbums.DoubleClick
        Dim album As Album = New Album()
        album.aName = ListAlbums.SelectedItem.ToString
        album.ReadAlbumByName()
        Dim f As Form = New AlbumForm(album, user, filePath)
        f.Show()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        loginForm.Show()
        Hide()
    End Sub
End Class