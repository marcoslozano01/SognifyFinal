<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.birthDateBox = New System.Windows.Forms.TextBox()
        Me.birthdateLabel = New System.Windows.Forms.Label()
        Me.surnameBox = New System.Windows.Forms.TextBox()
        Me.surnameLabel = New System.Windows.Forms.Label()
        Me.emailBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.countryBox = New System.Windows.Forms.TextBox()
        Me.countryLabel = New System.Windows.Forms.Label()
        Me.coverBox = New System.Windows.Forms.TextBox()
        Me.coverLabel = New System.Windows.Forms.Label()
        Me.artistLabel = New System.Windows.Forms.Label()
        Me.relaseDateBox = New System.Windows.Forms.TextBox()
        Me.relaseLabel = New System.Windows.Forms.Label()
        Me.lengthBox = New System.Windows.Forms.TextBox()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.albumLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.ClearBtt = New System.Windows.Forms.Button()
        Me.deleteBtt = New System.Windows.Forms.Button()
        Me.updateBtt = New System.Windows.Forms.Button()
        Me.insertBtt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginBtt = New System.Windows.Forms.Button()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ChooseDB = New System.Windows.Forms.Button()
        Me.Songify = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(185, 150)
        Me.ListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(139, 134)
        Me.ListBox.TabIndex = 60
        '
        'birthDateBox
        '
        Me.birthDateBox.Location = New System.Drawing.Point(416, 276)
        Me.birthDateBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.birthDateBox.Name = "birthDateBox"
        Me.birthDateBox.Size = New System.Drawing.Size(119, 20)
        Me.birthDateBox.TabIndex = 59
        '
        'birthdateLabel
        '
        Me.birthdateLabel.AutoSize = True
        Me.birthdateLabel.Location = New System.Drawing.Point(353, 278)
        Me.birthdateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.birthdateLabel.Name = "birthdateLabel"
        Me.birthdateLabel.Size = New System.Drawing.Size(51, 13)
        Me.birthdateLabel.TabIndex = 58
        Me.birthdateLabel.Text = "BirthDate"
        '
        'surnameBox
        '
        Me.surnameBox.Location = New System.Drawing.Point(416, 243)
        Me.surnameBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.surnameBox.Name = "surnameBox"
        Me.surnameBox.Size = New System.Drawing.Size(119, 20)
        Me.surnameBox.TabIndex = 57
        '
        'surnameLabel
        '
        Me.surnameLabel.AutoSize = True
        Me.surnameLabel.Location = New System.Drawing.Point(353, 243)
        Me.surnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.surnameLabel.Name = "surnameLabel"
        Me.surnameLabel.Size = New System.Drawing.Size(49, 13)
        Me.surnameLabel.TabIndex = 56
        Me.surnameLabel.Text = "Surname"
        '
        'emailBox
        '
        Me.emailBox.Location = New System.Drawing.Point(416, 213)
        Me.emailBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.emailBox.Name = "emailBox"
        Me.emailBox.Size = New System.Drawing.Size(119, 20)
        Me.emailBox.TabIndex = 55
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(357, 213)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 54
        Me.EmailLabel.Text = "Email"
        '
        'countryBox
        '
        Me.countryBox.Location = New System.Drawing.Point(416, 183)
        Me.countryBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.countryBox.Name = "countryBox"
        Me.countryBox.Size = New System.Drawing.Size(119, 20)
        Me.countryBox.TabIndex = 53
        '
        'countryLabel
        '
        Me.countryLabel.AutoSize = True
        Me.countryLabel.Location = New System.Drawing.Point(353, 185)
        Me.countryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(43, 13)
        Me.countryLabel.TabIndex = 52
        Me.countryLabel.Text = "Country"
        '
        'coverBox
        '
        Me.coverBox.Location = New System.Drawing.Point(416, 155)
        Me.coverBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.coverBox.Name = "coverBox"
        Me.coverBox.Size = New System.Drawing.Size(119, 20)
        Me.coverBox.TabIndex = 51
        '
        'coverLabel
        '
        Me.coverLabel.AutoSize = True
        Me.coverLabel.Location = New System.Drawing.Point(353, 157)
        Me.coverLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.coverLabel.Name = "coverLabel"
        Me.coverLabel.Size = New System.Drawing.Size(35, 13)
        Me.coverLabel.TabIndex = 50
        Me.coverLabel.Text = "Cover"
        '
        'artistLabel
        '
        Me.artistLabel.AutoSize = True
        Me.artistLabel.Location = New System.Drawing.Point(357, 122)
        Me.artistLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.artistLabel.Name = "artistLabel"
        Me.artistLabel.Size = New System.Drawing.Size(30, 13)
        Me.artistLabel.TabIndex = 48
        Me.artistLabel.Text = "Artist"
        '
        'relaseDateBox
        '
        Me.relaseDateBox.Location = New System.Drawing.Point(416, 93)
        Me.relaseDateBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.relaseDateBox.Name = "relaseDateBox"
        Me.relaseDateBox.Size = New System.Drawing.Size(119, 20)
        Me.relaseDateBox.TabIndex = 47
        '
        'relaseLabel
        '
        Me.relaseLabel.AutoSize = True
        Me.relaseLabel.Location = New System.Drawing.Point(353, 93)
        Me.relaseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.relaseLabel.Name = "relaseLabel"
        Me.relaseLabel.Size = New System.Drawing.Size(63, 13)
        Me.relaseLabel.TabIndex = 46
        Me.relaseLabel.Text = "RelaseDate"
        '
        'lengthBox
        '
        Me.lengthBox.Location = New System.Drawing.Point(416, 63)
        Me.lengthBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lengthBox.Name = "lengthBox"
        Me.lengthBox.Size = New System.Drawing.Size(119, 20)
        Me.lengthBox.TabIndex = 45
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(353, 63)
        Me.lengthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(40, 13)
        Me.lengthLabel.TabIndex = 44
        Me.lengthLabel.Text = "Length"
        '
        'albumLabel
        '
        Me.albumLabel.AutoSize = True
        Me.albumLabel.Location = New System.Drawing.Point(353, 35)
        Me.albumLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.albumLabel.Name = "albumLabel"
        Me.albumLabel.Size = New System.Drawing.Size(36, 13)
        Me.albumLabel.TabIndex = 42
        Me.albumLabel.Text = "Album"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(416, 8)
        Me.nameBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(119, 20)
        Me.nameBox.TabIndex = 41
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(352, 6)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 40
        Me.nameLabel.Text = "Name"
        '
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(17, 93)
        Me.ComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox.TabIndex = 39
        '
        'ClearBtt
        '
        Me.ClearBtt.Location = New System.Drawing.Point(85, 238)
        Me.ClearBtt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClearBtt.Name = "ClearBtt"
        Me.ClearBtt.Size = New System.Drawing.Size(50, 25)
        Me.ClearBtt.TabIndex = 38
        Me.ClearBtt.Text = "Clear"
        Me.ClearBtt.UseVisualStyleBackColor = True
        '
        'deleteBtt
        '
        Me.deleteBtt.Location = New System.Drawing.Point(3, 238)
        Me.deleteBtt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.deleteBtt.Name = "deleteBtt"
        Me.deleteBtt.Size = New System.Drawing.Size(50, 25)
        Me.deleteBtt.TabIndex = 37
        Me.deleteBtt.Text = "Delete"
        Me.deleteBtt.UseVisualStyleBackColor = True
        '
        'updateBtt
        '
        Me.updateBtt.Location = New System.Drawing.Point(85, 184)
        Me.updateBtt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.updateBtt.Name = "updateBtt"
        Me.updateBtt.Size = New System.Drawing.Size(50, 27)
        Me.updateBtt.TabIndex = 36
        Me.updateBtt.Text = "update"
        Me.updateBtt.UseVisualStyleBackColor = True
        '
        'insertBtt
        '
        Me.insertBtt.Location = New System.Drawing.Point(3, 184)
        Me.insertBtt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.insertBtt.Name = "insertBtt"
        Me.insertBtt.Size = New System.Drawing.Size(50, 27)
        Me.insertBtt.TabIndex = 35
        Me.insertBtt.Text = "Insert"
        Me.insertBtt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Login"
        '
        'loginBtt
        '
        Me.loginBtt.Location = New System.Drawing.Point(11, 51)
        Me.loginBtt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.loginBtt.Name = "loginBtt"
        Me.loginBtt.Size = New System.Drawing.Size(50, 27)
        Me.loginBtt.TabIndex = 33
        Me.loginBtt.Text = "Login"
        Me.loginBtt.UseVisualStyleBackColor = True
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(46, 14)
        Me.TextBoxEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxEmail.TabIndex = 32
        '
        'ChooseDB
        '
        Me.ChooseDB.Location = New System.Drawing.Point(85, 51)
        Me.ChooseDB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChooseDB.Name = "ChooseDB"
        Me.ChooseDB.Size = New System.Drawing.Size(78, 27)
        Me.ChooseDB.TabIndex = 31
        Me.ChooseDB.Text = "ChooseDB"
        Me.ChooseDB.UseVisualStyleBackColor = True
        '
        'Songify
        '
        Me.Songify.AutoSize = True
        Me.Songify.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Songify.Location = New System.Drawing.Point(193, 44)
        Me.Songify.Name = "Songify"
        Me.Songify.Size = New System.Drawing.Size(115, 38)
        Me.Songify.TabIndex = 61
        Me.Songify.Text = "Songify"
        Me.Songify.UseMnemonic = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(416, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(119, 21)
        Me.ComboBox1.TabIndex = 62
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(414, 122)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 63
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(549, 312)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Songify)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.birthDateBox)
        Me.Controls.Add(Me.birthdateLabel)
        Me.Controls.Add(Me.surnameBox)
        Me.Controls.Add(Me.surnameLabel)
        Me.Controls.Add(Me.emailBox)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.countryBox)
        Me.Controls.Add(Me.countryLabel)
        Me.Controls.Add(Me.coverBox)
        Me.Controls.Add(Me.coverLabel)
        Me.Controls.Add(Me.artistLabel)
        Me.Controls.Add(Me.relaseDateBox)
        Me.Controls.Add(Me.relaseLabel)
        Me.Controls.Add(Me.lengthBox)
        Me.Controls.Add(Me.lengthLabel)
        Me.Controls.Add(Me.albumLabel)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.ClearBtt)
        Me.Controls.Add(Me.deleteBtt)
        Me.Controls.Add(Me.updateBtt)
        Me.Controls.Add(Me.insertBtt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginBtt)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.ChooseDB)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Songify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox As ListBox
    Friend WithEvents birthDateBox As TextBox
    Friend WithEvents birthdateLabel As Label
    Friend WithEvents surnameBox As TextBox
    Friend WithEvents surnameLabel As Label
    Friend WithEvents emailBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents countryBox As TextBox
    Friend WithEvents countryLabel As Label
    Friend WithEvents coverBox As TextBox
    Friend WithEvents coverLabel As Label
    Friend WithEvents artistLabel As Label
    Friend WithEvents relaseDateBox As TextBox
    Friend WithEvents relaseLabel As Label
    Friend WithEvents lengthBox As TextBox
    Friend WithEvents lengthLabel As Label
    Friend WithEvents albumLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents ClearBtt As Button
    Friend WithEvents deleteBtt As Button
    Friend WithEvents updateBtt As Button
    Friend WithEvents insertBtt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents loginBtt As Button
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ChooseDB As Button
    Friend WithEvents Songify As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
