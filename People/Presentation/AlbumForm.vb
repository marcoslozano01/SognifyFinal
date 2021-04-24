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
        Try
            ar.ReadArtist()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        artistBox.Text = ar.aName
        albumLength(ReadAllSongsByAlbum())

    End Sub

    Private Sub albumLength(segundos As Integer)
        Dim hor As Integer
        Dim min As Integer
        Dim seg As Integer
        hor = CType(Math.Floor(segundos / 3600), Integer)
        min = CType(Math.Floor((segundos - hor * 3600) / 60), Integer)
        seg = segundos - (hor * 3600 + min * 60)
        lengthTextBox.Text = hor & " h " & min & " m " & seg & " s"
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

    Private Function ReadAllSongsByAlbum() As Integer
        Dim s As Song = New Song()
        Dim song As Song
        Dim length As Integer
        length = 0
        Try
            s.ReadAllSongsByAlbum(filePath, album)
            For Each song In s.SongDAO.songs
                songsBox.Items.Add(song.sName)
                length += song.length
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return length
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Hide()
    End Sub

End Class