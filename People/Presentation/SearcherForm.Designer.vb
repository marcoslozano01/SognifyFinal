<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearcherForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SearcherTextBox = New System.Windows.Forms.TextBox()
        Me.textSearcher = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListArtists = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListSongs = New System.Windows.Forms.ListBox()
        Me.ListAlbums = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearcherTextBox
        '
        Me.SearcherTextBox.Location = New System.Drawing.Point(298, 49)
        Me.SearcherTextBox.Name = "SearcherTextBox"
        Me.SearcherTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SearcherTextBox.TabIndex = 0
        '
        'textSearcher
        '
        Me.textSearcher.AutoSize = True
        Me.textSearcher.Location = New System.Drawing.Point(298, 12)
        Me.textSearcher.Name = "textSearcher"
        Me.textSearcher.Size = New System.Drawing.Size(74, 20)
        Me.textSearcher.TabIndex = 1
        Me.textSearcher.Text = "Searcher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Artists"
        '
        'ListArtists
        '
        Me.ListArtists.FormattingEnabled = True
        Me.ListArtists.ItemHeight = 20
        Me.ListArtists.Location = New System.Drawing.Point(38, 162)
        Me.ListArtists.Name = "ListArtists"
        Me.ListArtists.Size = New System.Drawing.Size(186, 104)
        Me.ListArtists.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Songs"
        '
        'ListSongs
        '
        Me.ListSongs.FormattingEnabled = True
        Me.ListSongs.ItemHeight = 20
        Me.ListSongs.Location = New System.Drawing.Point(302, 162)
        Me.ListSongs.Name = "ListSongs"
        Me.ListSongs.Size = New System.Drawing.Size(186, 104)
        Me.ListSongs.TabIndex = 5
        '
        'ListAlbums
        '
        Me.ListAlbums.FormattingEnabled = True
        Me.ListAlbums.ItemHeight = 20
        Me.ListAlbums.Location = New System.Drawing.Point(566, 162)
        Me.ListAlbums.Name = "ListAlbums"
        Me.ListAlbums.Size = New System.Drawing.Size(186, 104)
        Me.ListAlbums.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(616, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Albums"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(38, 18)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(52, 34)
        Me.backButton.TabIndex = 8
        Me.backButton.Text = "<--"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'SearcherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListAlbums)
        Me.Controls.Add(Me.ListSongs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListArtists)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textSearcher)
        Me.Controls.Add(Me.SearcherTextBox)
        Me.Name = "SearcherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Songify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearcherTextBox As TextBox
    Friend WithEvents textSearcher As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents ListArtists As ListBox
    Public WithEvents ListSongs As ListBox
    Public WithEvents ListAlbums As ListBox
    Friend WithEvents backButton As Button
End Class
