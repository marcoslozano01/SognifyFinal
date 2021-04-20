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
        Me.SearcherTextBox.Location = New System.Drawing.Point(199, 32)
        Me.SearcherTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearcherTextBox.Name = "SearcherTextBox"
        Me.SearcherTextBox.Size = New System.Drawing.Size(135, 20)
        Me.SearcherTextBox.TabIndex = 0
        '
        'textSearcher
        '
        Me.textSearcher.AutoSize = True
        Me.textSearcher.Location = New System.Drawing.Point(199, 8)
        Me.textSearcher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.textSearcher.Name = "textSearcher"
        Me.textSearcher.Size = New System.Drawing.Size(50, 13)
        Me.textSearcher.TabIndex = 1
        Me.textSearcher.Text = "Searcher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Artists"
        '
        'ListArtists
        '
        Me.ListArtists.FormattingEnabled = True
        Me.ListArtists.Location = New System.Drawing.Point(25, 105)
        Me.ListArtists.Margin = New System.Windows.Forms.Padding(2)
        Me.ListArtists.Name = "ListArtists"
        Me.ListArtists.Size = New System.Drawing.Size(125, 69)
        Me.ListArtists.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Songs"
        '
        'ListSongs
        '
        Me.ListSongs.FormattingEnabled = True
        Me.ListSongs.Location = New System.Drawing.Point(201, 105)
        Me.ListSongs.Margin = New System.Windows.Forms.Padding(2)
        Me.ListSongs.Name = "ListSongs"
        Me.ListSongs.Size = New System.Drawing.Size(125, 69)
        Me.ListSongs.TabIndex = 5
        '
        'ListAlbums
        '
        Me.ListAlbums.FormattingEnabled = True
        Me.ListAlbums.Location = New System.Drawing.Point(377, 105)
        Me.ListAlbums.Margin = New System.Windows.Forms.Padding(2)
        Me.ListAlbums.Name = "ListAlbums"
        Me.ListAlbums.Size = New System.Drawing.Size(125, 69)
        Me.ListAlbums.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Albums"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(25, 12)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(35, 22)
        Me.backButton.TabIndex = 8
        Me.backButton.Text = "<--"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'SearcherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(533, 234)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListAlbums)
        Me.Controls.Add(Me.ListSongs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListArtists)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textSearcher)
        Me.Controls.Add(Me.SearcherTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
