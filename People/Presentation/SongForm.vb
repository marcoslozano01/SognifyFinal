Public Class SongForm
    Public Property song As Song
    Public Property user As User
    Public Sub New(ByRef song As Song, ByRef user As User)
        InitializeComponent()
        Me.song = song
        Me.user = user
    End Sub
    Private Sub SongForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BoxName.Text = song.sName
        song.album.ReadAlbum()
        BoxAlbum.Text = song.album.aName
        songLength(song.length)
        MessageBox.Show(user.Email)
    End Sub
    Private Sub songLength(segundos As Integer)
        Dim hor As Integer
        Dim min As Integer
        Dim seg As Integer
        hor = CType(Math.Floor(segundos / 3600), Integer)
        min = CType(Math.Floor((segundos - hor * 3600) / 60), Integer)
        seg = segundos - (hor * 3600 + min * 60)
        BoxLenght.Text = hor & " h " & min & " m " & seg & " s"
    End Sub

    Private Sub BottonPlay_Click(sender As Object, e As EventArgs) Handles BottonPlay.Click
        Dim playBack As PlayBack = New PlayBack
        playBack.user = user
        playBack.song = song
        MessageBox.Show(DateTime.Now.ToString("dd/MM/yyyy"))
        playBack.plDate = DateTime.Now.ToString("dd/MM/yyyy")
        playBack.InsertPlayBack()
    End Sub
End Class