Public Class AlbumForm

    Public Property album As Album
    Public Property user As User

    Public Property filePath As String


    Public Sub New(ByRef album As Album, ByRef user As User, ByRef filePath As String)
        InitializeComponent()
        Me.album = album
        Me.user = user
        Me.filePath = filePath
    End Sub

    Private Sub AlbumForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ar As Artist = album.artist
        nameTextbox.Text = album.aName
        releaseTextBox.Text = album.releaseDate
        loadCover(album.cover)
        ar.ReadArtist()
        artistBox.Text = ar.aName
        ReadAllSongsByAlbum()
    End Sub

    Public Sub loadCover(url As String)
        Try
            PictureBox1.Image = Image.FromFile(url)
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch e As Exception
            PictureBox1.Enabled = False
        End Try

    End Sub

    Private Sub ReadAllSongsByAlbum()
        Dim s As Song = New Song()
        Dim song As Song
        s.ReadAllSongsByAlbum(album, filePath)
        Try
            For Each song In s.SongDAO.songs
                songsBox.Items.Add(song.sName)

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Hide()
    End Sub
End Class