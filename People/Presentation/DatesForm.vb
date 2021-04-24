Public Class DatesForm

    Public Property user As User


    Public Sub New(ByRef user As User)
        InitializeComponent()
        Me.user = user
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iniDate As Date
        Dim endDate As Date
        Dim artist As Artist = New Artist
        Dim a As Artist
        artist.user = Me.user
        iniDate = Initial.Value
        endDate = Ending.Value
        Dim chain As String = ""
        Try
            artist.ReadArtistsDate(iniDate, endDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For Each a In artist.ArtistDAO.Artists
            chain = chain & a.aName & vbCrLf
        Next
        MessageBox.Show(chain)
    End Sub
End Class