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
        playBack.plDate = DateTime.Now.ToString("dd/MM/yyyy")
        Try
            If playBack.InsertPlayBack() <> 1 Then
                MessageBox.Show("The id already exists")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BottonHistory_Click(sender As Object, e As EventArgs) Handles BottonHistory.Click

        Dim p As PlayBack = New PlayBack(1)
        Dim playback As PlayBack
        Try
            p.ReadHistory(song)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ListHistory.Items.Clear()
        For Each playBack In p.PlayBackDAO.PlayBacks
            ListHistory.Items.Add(playback.user.Email & " " & playback.plDate)
        Next

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Hide()
    End Sub
End Class