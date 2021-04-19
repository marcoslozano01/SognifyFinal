Public Class ArtistForm

    Public Property artist As Artist
    Public Property user As User
    Public Property filePath As String

    Public Sub New(ByRef artist As Artist, ByRef user As User, filePath As String)
        InitializeComponent()
        Me.artist = artist
        Me.user = user
        Me.filePath = filePath
    End Sub
    Private Sub ArtistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameBox.Text = artist.aName
        countryBox.Text = artist.country
        ' PictureBox1.Image = Image.FromFile(artist.image)
        readAllAlbumsByArtist()
        checkFavArtist()
    End Sub

    Public Sub checkFavArtist()
        artist.user = Me.user
        artist.artist = Me.artist
        MessageBox.Show(artist.artist.aName)
        Try
            If artist.ReadFavArtist() = 0 Then
                favArtistBox.Checked = False
            Else
                favArtistBox.Checked = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub readAllAlbumsByArtist()
        Dim album As Album = New Album
        Dim a As Album
        album.artist = Me.artist
        Try
            album.ReadAllAlbumsByArtist(filePath)
            For Each a In album.AlbumDAO.Albums
                albumList.Items.Add(a.aName)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub favArtistBox_Click(sender As Object, e As EventArgs) Handles favArtistBox.Click
        Dim artist = New Artist
        artist.user = Me.user
        artist.artist = Me.artist
        artist.favDate = DateTime.Now.ToString("dd/MM/yyyy")
        If favArtistBox.CheckState = 1 Then
            Try
                artist.InsertArtistFav()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            Try
                artist.DeleteArtistFav()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub
End Class