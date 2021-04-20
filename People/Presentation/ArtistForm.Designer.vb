<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtistForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.nameLb = New System.Windows.Forms.Label()
        Me.countryLb = New System.Windows.Forms.Label()
        Me.countryBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.favArtistBox = New System.Windows.Forms.CheckBox()
        Me.albumList = New System.Windows.Forms.ListBox()
        Me.backButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(83, 47)
        Me.nameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(119, 20)
        Me.nameBox.TabIndex = 0
        '
        'nameLb
        '
        Me.nameLb.AutoSize = True
        Me.nameLb.Location = New System.Drawing.Point(21, 51)
        Me.nameLb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLb.Name = "nameLb"
        Me.nameLb.Size = New System.Drawing.Size(35, 13)
        Me.nameLb.TabIndex = 1
        Me.nameLb.Text = "Name"
        '
        'countryLb
        '
        Me.countryLb.AutoSize = True
        Me.countryLb.Location = New System.Drawing.Point(21, 90)
        Me.countryLb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.countryLb.Name = "countryLb"
        Me.countryLb.Size = New System.Drawing.Size(43, 13)
        Me.countryLb.TabIndex = 3
        Me.countryLb.Text = "Country"
        '
        'countryBox
        '
        Me.countryBox.Location = New System.Drawing.Point(83, 86)
        Me.countryBox.Margin = New System.Windows.Forms.Padding(2)
        Me.countryBox.Name = "countryBox"
        Me.countryBox.Size = New System.Drawing.Size(119, 20)
        Me.countryBox.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(313, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 120)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'favArtistBox
        '
        Me.favArtistBox.AutoSize = True
        Me.favArtistBox.Location = New System.Drawing.Point(24, 131)
        Me.favArtistBox.Margin = New System.Windows.Forms.Padding(2)
        Me.favArtistBox.Name = "favArtistBox"
        Me.favArtistBox.Size = New System.Drawing.Size(64, 17)
        Me.favArtistBox.TabIndex = 5
        Me.favArtistBox.Text = "favArtist"
        Me.favArtistBox.UseVisualStyleBackColor = True
        '
        'albumList
        '
        Me.albumList.FormattingEnabled = True
        Me.albumList.Location = New System.Drawing.Point(24, 186)
        Me.albumList.Margin = New System.Windows.Forms.Padding(2)
        Me.albumList.Name = "albumList"
        Me.albumList.Size = New System.Drawing.Size(148, 69)
        Me.albumList.TabIndex = 6
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(21, 12)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(35, 22)
        Me.backButton.TabIndex = 9
        Me.backButton.Text = "<--"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'ArtistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.albumList)
        Me.Controls.Add(Me.favArtistBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.countryLb)
        Me.Controls.Add(Me.countryBox)
        Me.Controls.Add(Me.nameLb)
        Me.Controls.Add(Me.nameBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ArtistForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Songify"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameBox As TextBox
    Friend WithEvents nameLb As Label
    Friend WithEvents countryLb As Label
    Friend WithEvents countryBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents favArtistBox As CheckBox
    Friend WithEvents albumList As ListBox
    Friend WithEvents backButton As Button
End Class
