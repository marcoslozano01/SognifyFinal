<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SongForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BottonPlay = New System.Windows.Forms.Button()
        Me.BottonHistory = New System.Windows.Forms.Button()
        Me.BoxName = New System.Windows.Forms.TextBox()
        Me.BoxAlbum = New System.Windows.Forms.TextBox()
        Me.BoxLenght = New System.Windows.Forms.TextBox()
        Me.ListHistory = New System.Windows.Forms.ListBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Album:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Length:"
        '
        'BottonPlay
        '
        Me.BottonPlay.Location = New System.Drawing.Point(61, 164)
        Me.BottonPlay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BottonPlay.Name = "BottonPlay"
        Me.BottonPlay.Size = New System.Drawing.Size(79, 24)
        Me.BottonPlay.TabIndex = 6
        Me.BottonPlay.Text = "PlaySong"
        Me.BottonPlay.UseVisualStyleBackColor = True
        '
        'BottonHistory
        '
        Me.BottonHistory.Location = New System.Drawing.Point(349, 164)
        Me.BottonHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BottonHistory.Name = "BottonHistory"
        Me.BottonHistory.Size = New System.Drawing.Size(98, 24)
        Me.BottonHistory.TabIndex = 7
        Me.BottonHistory.Text = "PlayBackHistory"
        Me.BottonHistory.UseVisualStyleBackColor = True
        '
        'BoxName
        '
        Me.BoxName.Location = New System.Drawing.Point(76, 36)
        Me.BoxName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BoxName.Name = "BoxName"
        Me.BoxName.Size = New System.Drawing.Size(115, 20)
        Me.BoxName.TabIndex = 8
        '
        'BoxAlbum
        '
        Me.BoxAlbum.Location = New System.Drawing.Point(75, 66)
        Me.BoxAlbum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BoxAlbum.Name = "BoxAlbum"
        Me.BoxAlbum.Size = New System.Drawing.Size(115, 20)
        Me.BoxAlbum.TabIndex = 9
        '
        'BoxLenght
        '
        Me.BoxLenght.Location = New System.Drawing.Point(75, 100)
        Me.BoxLenght.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BoxLenght.Name = "BoxLenght"
        Me.BoxLenght.Size = New System.Drawing.Size(115, 20)
        Me.BoxLenght.TabIndex = 10
        '
        'ListHistory
        '
        Me.ListHistory.FormattingEnabled = True
        Me.ListHistory.Location = New System.Drawing.Point(255, 36)
        Me.ListHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListHistory.Name = "ListHistory"
        Me.ListHistory.Size = New System.Drawing.Size(252, 95)
        Me.ListHistory.TabIndex = 11
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(12, 11)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(35, 22)
        Me.backButton.TabIndex = 12
        Me.backButton.Text = "<--"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'SongForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(533, 253)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.ListHistory)
        Me.Controls.Add(Me.BoxLenght)
        Me.Controls.Add(Me.BoxAlbum)
        Me.Controls.Add(Me.BoxName)
        Me.Controls.Add(Me.BottonHistory)
        Me.Controls.Add(Me.BottonPlay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SongForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Songify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BottonPlay As Button
    Friend WithEvents BottonHistory As Button
    Friend WithEvents BoxName As TextBox
    Friend WithEvents BoxAlbum As TextBox
    Friend WithEvents BoxLenght As TextBox
    Friend WithEvents ListHistory As ListBox
    Friend WithEvents backButton As Button
End Class
