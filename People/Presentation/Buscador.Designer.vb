<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Buscador
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
        Me.BuscadorTextBox = New System.Windows.Forms.TextBox()
        Me.textBuscador = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListArtists = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListSongs = New System.Windows.Forms.ListBox()
        Me.ListAlbums = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BuscadorTextBox
        '
        Me.BuscadorTextBox.Location = New System.Drawing.Point(298, 49)
        Me.BuscadorTextBox.Name = "BuscadorTextBox"
        Me.BuscadorTextBox.Size = New System.Drawing.Size(200, 26)
        Me.BuscadorTextBox.TabIndex = 0
        '
        'textBuscador
        '
        Me.textBuscador.AutoSize = True
        Me.textBuscador.Location = New System.Drawing.Point(298, 13)
        Me.textBuscador.Name = "textBuscador"
        Me.textBuscador.Size = New System.Drawing.Size(77, 20)
        Me.textBuscador.TabIndex = 1
        Me.textBuscador.Text = "Buscador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Artists"
        '
        'ListArtists
        '
        Me.ListArtists.FormattingEnabled = True
        Me.ListArtists.ItemHeight = 20
        Me.ListArtists.Location = New System.Drawing.Point(38, 161)
        Me.ListArtists.Name = "ListArtists"
        Me.ListArtists.Size = New System.Drawing.Size(186, 104)
        Me.ListArtists.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Songs"
        '
        'ListSongs
        '
        Me.ListSongs.FormattingEnabled = True
        Me.ListSongs.ItemHeight = 20
        Me.ListSongs.Location = New System.Drawing.Point(302, 161)
        Me.ListSongs.Name = "ListSongs"
        Me.ListSongs.Size = New System.Drawing.Size(186, 104)
        Me.ListSongs.TabIndex = 5
        '
        'ListAlbums
        '
        Me.ListAlbums.FormattingEnabled = True
        Me.ListAlbums.ItemHeight = 20
        Me.ListAlbums.Location = New System.Drawing.Point(565, 161)
        Me.ListAlbums.Name = "ListAlbums"
        Me.ListAlbums.Size = New System.Drawing.Size(186, 104)
        Me.ListAlbums.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(616, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Albums"
        '
        'Buscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListAlbums)
        Me.Controls.Add(Me.ListSongs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListArtists)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textBuscador)
        Me.Controls.Add(Me.BuscadorTextBox)
        Me.Name = "Buscador"
        Me.Text = "Buscador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuscadorTextBox As TextBox
    Friend WithEvents textBuscador As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListArtists As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListSongs As ListBox
    Friend WithEvents ListAlbums As ListBox
    Friend WithEvents Label3 As Label
End Class
