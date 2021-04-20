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
        Me.albumBox = New System.Windows.Forms.ComboBox()
        Me.ArtistBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 20
        Me.ListBox.Location = New System.Drawing.Point(278, 231)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(206, 204)
        Me.ListBox.TabIndex = 60
        '
        'birthDateBox
        '
        Me.birthDateBox.Location = New System.Drawing.Point(624, 425)
        Me.birthDateBox.Name = "birthDateBox"
        Me.birthDateBox.Size = New System.Drawing.Size(176, 26)
        Me.birthDateBox.TabIndex = 59
        '
        'birthdateLabel
        '
        Me.birthdateLabel.AutoSize = True
        Me.birthdateLabel.Location = New System.Drawing.Point(530, 428)
        Me.birthdateLabel.Name = "birthdateLabel"
        Me.birthdateLabel.Size = New System.Drawing.Size(77, 20)
        Me.birthdateLabel.TabIndex = 58
        Me.birthdateLabel.Text = "BirthDate"
        '
        'surnameBox
        '
        Me.surnameBox.Location = New System.Drawing.Point(624, 374)
        Me.surnameBox.Name = "surnameBox"
        Me.surnameBox.Size = New System.Drawing.Size(176, 26)
        Me.surnameBox.TabIndex = 57
        '
        'surnameLabel
        '
        Me.surnameLabel.AutoSize = True
        Me.surnameLabel.Location = New System.Drawing.Point(530, 374)
        Me.surnameLabel.Name = "surnameLabel"
        Me.surnameLabel.Size = New System.Drawing.Size(74, 20)
        Me.surnameLabel.TabIndex = 56
        Me.surnameLabel.Text = "Surname"
        '
        'emailBox
        '
        Me.emailBox.Location = New System.Drawing.Point(624, 328)
        Me.emailBox.Name = "emailBox"
        Me.emailBox.Size = New System.Drawing.Size(176, 26)
        Me.emailBox.TabIndex = 55
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(536, 328)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(48, 20)
        Me.EmailLabel.TabIndex = 54
        Me.EmailLabel.Text = "Email"
        '
        'countryBox
        '
        Me.countryBox.Location = New System.Drawing.Point(624, 282)
        Me.countryBox.Name = "countryBox"
        Me.countryBox.Size = New System.Drawing.Size(176, 26)
        Me.countryBox.TabIndex = 53
        '
        'countryLabel
        '
        Me.countryLabel.AutoSize = True
        Me.countryLabel.Location = New System.Drawing.Point(530, 285)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(64, 20)
        Me.countryLabel.TabIndex = 52
        Me.countryLabel.Text = "Country"
        '
        'coverBox
        '
        Me.coverBox.Location = New System.Drawing.Point(624, 238)
        Me.coverBox.Name = "coverBox"
        Me.coverBox.Size = New System.Drawing.Size(176, 26)
        Me.coverBox.TabIndex = 51
        '
        'coverLabel
        '
        Me.coverLabel.AutoSize = True
        Me.coverLabel.Location = New System.Drawing.Point(530, 242)
        Me.coverLabel.Name = "coverLabel"
        Me.coverLabel.Size = New System.Drawing.Size(50, 20)
        Me.coverLabel.TabIndex = 50
        Me.coverLabel.Text = "Cover"
        '
        'artistLabel
        '
        Me.artistLabel.AutoSize = True
        Me.artistLabel.Location = New System.Drawing.Point(536, 188)
        Me.artistLabel.Name = "artistLabel"
        Me.artistLabel.Size = New System.Drawing.Size(46, 20)
        Me.artistLabel.TabIndex = 48
        Me.artistLabel.Text = "Artist"
        '
        'relaseDateBox
        '
        Me.relaseDateBox.Location = New System.Drawing.Point(624, 143)
        Me.relaseDateBox.Name = "relaseDateBox"
        Me.relaseDateBox.Size = New System.Drawing.Size(176, 26)
        Me.relaseDateBox.TabIndex = 47
        '
        'relaseLabel
        '
        Me.relaseLabel.AutoSize = True
        Me.relaseLabel.Location = New System.Drawing.Point(530, 143)
        Me.relaseLabel.Name = "relaseLabel"
        Me.relaseLabel.Size = New System.Drawing.Size(94, 20)
        Me.relaseLabel.TabIndex = 46
        Me.relaseLabel.Text = "RelaseDate"
        '
        'lengthBox
        '
        Me.lengthBox.Location = New System.Drawing.Point(624, 97)
        Me.lengthBox.Name = "lengthBox"
        Me.lengthBox.Size = New System.Drawing.Size(176, 26)
        Me.lengthBox.TabIndex = 45
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(530, 97)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(59, 20)
        Me.lengthLabel.TabIndex = 44
        Me.lengthLabel.Text = "Length"
        '
        'albumLabel
        '
        Me.albumLabel.AutoSize = True
        Me.albumLabel.Location = New System.Drawing.Point(530, 54)
        Me.albumLabel.Name = "albumLabel"
        Me.albumLabel.Size = New System.Drawing.Size(54, 20)
        Me.albumLabel.TabIndex = 42
        Me.albumLabel.Text = "Album"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(624, 12)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(176, 26)
        Me.nameBox.TabIndex = 41
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(528, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(51, 20)
        Me.nameLabel.TabIndex = 40
        Me.nameLabel.Text = "Name"
        '
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(26, 143)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(175, 28)
        Me.ComboBox.TabIndex = 39
        '
        'ClearBtt
        '
        Me.ClearBtt.Location = New System.Drawing.Point(128, 366)
        Me.ClearBtt.Name = "ClearBtt"
        Me.ClearBtt.Size = New System.Drawing.Size(75, 38)
        Me.ClearBtt.TabIndex = 38
        Me.ClearBtt.Text = "Clear"
        Me.ClearBtt.UseVisualStyleBackColor = True
        '
        'deleteBtt
        '
        Me.deleteBtt.Location = New System.Drawing.Point(4, 366)
        Me.deleteBtt.Name = "deleteBtt"
        Me.deleteBtt.Size = New System.Drawing.Size(75, 38)
        Me.deleteBtt.TabIndex = 37
        Me.deleteBtt.Text = "Delete"
        Me.deleteBtt.UseVisualStyleBackColor = True
        '
        'updateBtt
        '
        Me.updateBtt.Location = New System.Drawing.Point(128, 283)
        Me.updateBtt.Name = "updateBtt"
        Me.updateBtt.Size = New System.Drawing.Size(75, 42)
        Me.updateBtt.TabIndex = 36
        Me.updateBtt.Text = "update"
        Me.updateBtt.UseVisualStyleBackColor = True
        '
        'insertBtt
        '
        Me.insertBtt.Location = New System.Drawing.Point(4, 283)
        Me.insertBtt.Name = "insertBtt"
        Me.insertBtt.Size = New System.Drawing.Size(75, 42)
        Me.insertBtt.TabIndex = 35
        Me.insertBtt.Text = "Insert"
        Me.insertBtt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Login"
        '
        'loginBtt
        '
        Me.loginBtt.Location = New System.Drawing.Point(16, 78)
        Me.loginBtt.Name = "loginBtt"
        Me.loginBtt.Size = New System.Drawing.Size(75, 42)
        Me.loginBtt.TabIndex = 33
        Me.loginBtt.Text = "Login"
        Me.loginBtt.UseVisualStyleBackColor = True
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(69, 22)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(154, 26)
        Me.TextBoxEmail.TabIndex = 32
        '
        'ChooseDB
        '
        Me.ChooseDB.Location = New System.Drawing.Point(128, 78)
        Me.ChooseDB.Name = "ChooseDB"
        Me.ChooseDB.Size = New System.Drawing.Size(117, 42)
        Me.ChooseDB.TabIndex = 31
        Me.ChooseDB.Text = "ChooseDB"
        Me.ChooseDB.UseVisualStyleBackColor = True
        '
        'Songify
        '
        Me.Songify.AutoSize = True
        Me.Songify.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Songify.Location = New System.Drawing.Point(290, 68)
        Me.Songify.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Songify.Name = "Songify"
        Me.Songify.Size = New System.Drawing.Size(173, 58)
        Me.Songify.TabIndex = 61
        Me.Songify.Text = "Songify"
        Me.Songify.UseMnemonic = False
        '
        'albumBox
        '
        Me.albumBox.FormattingEnabled = True
        Me.albumBox.Location = New System.Drawing.Point(624, 57)
        Me.albumBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.albumBox.Name = "albumBox"
        Me.albumBox.Size = New System.Drawing.Size(176, 28)
        Me.albumBox.TabIndex = 62
        '
        'ArtistBox
        '
        Me.ArtistBox.FormattingEnabled = True
        Me.ArtistBox.Location = New System.Drawing.Point(621, 188)
        Me.ArtistBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ArtistBox.Name = "ArtistBox"
        Me.ArtistBox.Size = New System.Drawing.Size(180, 28)
        Me.ArtistBox.TabIndex = 63
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(824, 480)
        Me.Controls.Add(Me.ArtistBox)
        Me.Controls.Add(Me.albumBox)
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
    Friend WithEvents albumBox As ComboBox
    Friend WithEvents ArtistBox As ComboBox
End Class
