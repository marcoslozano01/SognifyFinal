Public Class ArtistForm

    Public Property artist As Artist
    Public Property user As User

    Public Sub New(ByRef artist As Artist, ByRef user As User)
        InitializeComponent()
        Me.artist = artist
        Me.user = user
    End Sub
    Private Sub ArtistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameBox.Text = artist.aName
        countryBox.Text = artist.country
        ' PictureBox1.Image = Image.FromFile(artist.image)

    End Sub

    Private Sub nameLb_Click(sender As Object, e As EventArgs) Handles nameLb.Click

    End Sub

    Private Sub favArtistBox_CheckStateChanged(sender As Object, e As EventArgs) Handles favArtistBox.CheckStateChanged
        If favArtistBox.CheckState = 1 Then
            MessageBox.Show("TRUE")
        Else

        End If
    End Sub

    Private Sub countryLb_Click(sender As Object, e As EventArgs) Handles countryLb.Click

    End Sub
End Class