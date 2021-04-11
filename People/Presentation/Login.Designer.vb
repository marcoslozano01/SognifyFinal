<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.ChooseDB = New System.Windows.Forms.Button()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.loginBtt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ChooseDB
        '
        Me.ChooseDB.Location = New System.Drawing.Point(48, 342)
        Me.ChooseDB.Name = "ChooseDB"
        Me.ChooseDB.Size = New System.Drawing.Size(95, 51)
        Me.ChooseDB.TabIndex = 0
        Me.ChooseDB.Text = "ChooseDB"
        Me.ChooseDB.UseVisualStyleBackColor = True
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(463, 98)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(154, 26)
        Me.TextBoxEmail.TabIndex = 1
        '
        'loginBtt
        '
        Me.loginBtt.Location = New System.Drawing.Point(463, 161)
        Me.loginBtt.Name = "loginBtt"
        Me.loginBtt.Size = New System.Drawing.Size(75, 41)
        Me.loginBtt.TabIndex = 3
        Me.loginBtt.Text = "Login"
        Me.loginBtt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(459, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginBtt)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.ChooseDB)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChooseDB As Button
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents login As Label
    Friend WithEvents loginBtt As Button
    Friend WithEvents Label1 As Label
End Class
