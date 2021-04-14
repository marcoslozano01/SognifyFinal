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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Album:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Length:"
        '
        'BottonPlay
        '
        Me.BottonPlay.Location = New System.Drawing.Point(53, 262)
        Me.BottonPlay.Name = "BottonPlay"
        Me.BottonPlay.Size = New System.Drawing.Size(119, 37)
        Me.BottonPlay.TabIndex = 6
        Me.BottonPlay.Text = "PlaySong"
        Me.BottonPlay.UseVisualStyleBackColor = True
        '
        'BottonHistory
        '
        Me.BottonHistory.Location = New System.Drawing.Point(427, 262)
        Me.BottonHistory.Name = "BottonHistory"
        Me.BottonHistory.Size = New System.Drawing.Size(147, 37)
        Me.BottonHistory.TabIndex = 7
        Me.BottonHistory.Text = "PlayBackHistory"
        Me.BottonHistory.UseVisualStyleBackColor = True
        '
        'BoxName
        '
        Me.BoxName.Location = New System.Drawing.Point(114, 55)
        Me.BoxName.Name = "BoxName"
        Me.BoxName.Size = New System.Drawing.Size(170, 26)
        Me.BoxName.TabIndex = 8
        '
        'BoxAlbum
        '
        Me.BoxAlbum.Location = New System.Drawing.Point(113, 101)
        Me.BoxAlbum.Name = "BoxAlbum"
        Me.BoxAlbum.Size = New System.Drawing.Size(171, 26)
        Me.BoxAlbum.TabIndex = 9
        '
        'BoxLenght
        '
        Me.BoxLenght.Location = New System.Drawing.Point(113, 154)
        Me.BoxLenght.Name = "BoxLenght"
        Me.BoxLenght.Size = New System.Drawing.Size(171, 26)
        Me.BoxLenght.TabIndex = 10
        '
        'SongForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BoxLenght)
        Me.Controls.Add(Me.BoxAlbum)
        Me.Controls.Add(Me.BoxName)
        Me.Controls.Add(Me.BottonHistory)
        Me.Controls.Add(Me.BottonPlay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SongForm"
        Me.Text = "SongForm"
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
End Class
