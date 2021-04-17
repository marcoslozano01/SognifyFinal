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
        Me.insertBtt = New System.Windows.Forms.Button()
        Me.updateBtt = New System.Windows.Forms.Button()
        Me.deleteBtt = New System.Windows.Forms.Button()
        Me.ClearBtt = New System.Windows.Forms.Button()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.albumBox = New System.Windows.Forms.TextBox()
        Me.albumLabel = New System.Windows.Forms.Label()
        Me.lengthBox = New System.Windows.Forms.TextBox()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.relaseDateBox = New System.Windows.Forms.TextBox()
        Me.relaseLabel = New System.Windows.Forms.Label()
        Me.artistBox = New System.Windows.Forms.TextBox()
        Me.artistLabel = New System.Windows.Forms.Label()
        Me.coverBox = New System.Windows.Forms.TextBox()
        Me.coverLabel = New System.Windows.Forms.Label()
        Me.countryBox = New System.Windows.Forms.TextBox()
        Me.countryLabel = New System.Windows.Forms.Label()
        Me.emailBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.surnameBox = New System.Windows.Forms.TextBox()
        Me.surnameLabel = New System.Windows.Forms.Label()
        Me.birthDateBox = New System.Windows.Forms.TextBox()
        Me.birthdateLabel = New System.Windows.Forms.Label()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ChooseDB
        '
        Me.ChooseDB.Location = New System.Drawing.Point(156, 96)
        Me.ChooseDB.Name = "ChooseDB"
        Me.ChooseDB.Size = New System.Drawing.Size(95, 51)
        Me.ChooseDB.TabIndex = 0
        Me.ChooseDB.Text = "ChooseDB"
        Me.ChooseDB.UseVisualStyleBackColor = True
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(97, 45)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(154, 26)
        Me.TextBoxEmail.TabIndex = 1
        '
        'loginBtt
        '
        Me.loginBtt.Location = New System.Drawing.Point(32, 101)
        Me.loginBtt.Name = "loginBtt"
        Me.loginBtt.Size = New System.Drawing.Size(75, 41)
        Me.loginBtt.TabIndex = 3
        Me.loginBtt.Text = "Login"
        Me.loginBtt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login"
        '
        'insertBtt
        '
        Me.insertBtt.Location = New System.Drawing.Point(32, 306)
        Me.insertBtt.Name = "insertBtt"
        Me.insertBtt.Size = New System.Drawing.Size(75, 41)
        Me.insertBtt.TabIndex = 5
        Me.insertBtt.Text = "Insert"
        Me.insertBtt.UseVisualStyleBackColor = True
        '
        'updateBtt
        '
        Me.updateBtt.Location = New System.Drawing.Point(156, 306)
        Me.updateBtt.Name = "updateBtt"
        Me.updateBtt.Size = New System.Drawing.Size(75, 41)
        Me.updateBtt.TabIndex = 6
        Me.updateBtt.Text = "update"
        Me.updateBtt.UseVisualStyleBackColor = True
        '
        'deleteBtt
        '
        Me.deleteBtt.Location = New System.Drawing.Point(32, 389)
        Me.deleteBtt.Name = "deleteBtt"
        Me.deleteBtt.Size = New System.Drawing.Size(75, 38)
        Me.deleteBtt.TabIndex = 7
        Me.deleteBtt.Text = "Delete"
        Me.deleteBtt.UseVisualStyleBackColor = True
        '
        'ClearBtt
        '
        Me.ClearBtt.Location = New System.Drawing.Point(156, 389)
        Me.ClearBtt.Name = "ClearBtt"
        Me.ClearBtt.Size = New System.Drawing.Size(75, 38)
        Me.ClearBtt.TabIndex = 8
        Me.ClearBtt.Text = "Clear"
        Me.ClearBtt.UseVisualStyleBackColor = True
        '
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(32, 177)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(175, 28)
        Me.ComboBox.TabIndex = 9
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(557, 22)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(51, 20)
        Me.nameLabel.TabIndex = 10
        Me.nameLabel.Text = "Name"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(652, 22)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(176, 26)
        Me.nameBox.TabIndex = 11
        '
        'albumBox
        '
        Me.albumBox.Location = New System.Drawing.Point(652, 67)
        Me.albumBox.Name = "albumBox"
        Me.albumBox.Size = New System.Drawing.Size(176, 26)
        Me.albumBox.TabIndex = 13
        '
        'albumLabel
        '
        Me.albumLabel.AutoSize = True
        Me.albumLabel.Location = New System.Drawing.Point(557, 67)
        Me.albumLabel.Name = "albumLabel"
        Me.albumLabel.Size = New System.Drawing.Size(54, 20)
        Me.albumLabel.TabIndex = 12
        Me.albumLabel.Text = "Album"
        '
        'lengthBox
        '
        Me.lengthBox.Location = New System.Drawing.Point(652, 120)
        Me.lengthBox.Name = "lengthBox"
        Me.lengthBox.Size = New System.Drawing.Size(176, 26)
        Me.lengthBox.TabIndex = 15
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(557, 120)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(59, 20)
        Me.lengthLabel.TabIndex = 14
        Me.lengthLabel.Text = "Length"
        '
        'relaseDateBox
        '
        Me.relaseDateBox.Location = New System.Drawing.Point(652, 166)
        Me.relaseDateBox.Name = "relaseDateBox"
        Me.relaseDateBox.Size = New System.Drawing.Size(176, 26)
        Me.relaseDateBox.TabIndex = 17
        '
        'relaseLabel
        '
        Me.relaseLabel.AutoSize = True
        Me.relaseLabel.Location = New System.Drawing.Point(557, 166)
        Me.relaseLabel.Name = "relaseLabel"
        Me.relaseLabel.Size = New System.Drawing.Size(94, 20)
        Me.relaseLabel.TabIndex = 16
        Me.relaseLabel.Text = "RelaseDate"
        '
        'artistBox
        '
        Me.artistBox.Location = New System.Drawing.Point(652, 208)
        Me.artistBox.Name = "artistBox"
        Me.artistBox.Size = New System.Drawing.Size(176, 26)
        Me.artistBox.TabIndex = 19
        '
        'artistLabel
        '
        Me.artistLabel.AutoSize = True
        Me.artistLabel.Location = New System.Drawing.Point(563, 211)
        Me.artistLabel.Name = "artistLabel"
        Me.artistLabel.Size = New System.Drawing.Size(46, 20)
        Me.artistLabel.TabIndex = 18
        Me.artistLabel.Text = "Artist"
        '
        'coverBox
        '
        Me.coverBox.Location = New System.Drawing.Point(652, 261)
        Me.coverBox.Name = "coverBox"
        Me.coverBox.Size = New System.Drawing.Size(176, 26)
        Me.coverBox.TabIndex = 21
        '
        'coverLabel
        '
        Me.coverLabel.AutoSize = True
        Me.coverLabel.Location = New System.Drawing.Point(557, 264)
        Me.coverLabel.Name = "coverLabel"
        Me.coverLabel.Size = New System.Drawing.Size(50, 20)
        Me.coverLabel.TabIndex = 20
        Me.coverLabel.Text = "Cover"
        '
        'countryBox
        '
        Me.countryBox.Location = New System.Drawing.Point(652, 305)
        Me.countryBox.Name = "countryBox"
        Me.countryBox.Size = New System.Drawing.Size(176, 26)
        Me.countryBox.TabIndex = 23
        '
        'countryLabel
        '
        Me.countryLabel.AutoSize = True
        Me.countryLabel.Location = New System.Drawing.Point(557, 308)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(64, 20)
        Me.countryLabel.TabIndex = 22
        Me.countryLabel.Text = "Country"
        '
        'emailBox
        '
        Me.emailBox.Location = New System.Drawing.Point(652, 351)
        Me.emailBox.Name = "emailBox"
        Me.emailBox.Size = New System.Drawing.Size(176, 26)
        Me.emailBox.TabIndex = 25
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(563, 351)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(48, 20)
        Me.EmailLabel.TabIndex = 24
        Me.EmailLabel.Text = "Email"
        '
        'surnameBox
        '
        Me.surnameBox.Location = New System.Drawing.Point(652, 397)
        Me.surnameBox.Name = "surnameBox"
        Me.surnameBox.Size = New System.Drawing.Size(176, 26)
        Me.surnameBox.TabIndex = 27
        '
        'surnameLabel
        '
        Me.surnameLabel.AutoSize = True
        Me.surnameLabel.Location = New System.Drawing.Point(557, 397)
        Me.surnameLabel.Name = "surnameLabel"
        Me.surnameLabel.Size = New System.Drawing.Size(74, 20)
        Me.surnameLabel.TabIndex = 26
        Me.surnameLabel.Text = "Surname"
        '
        'birthDateBox
        '
        Me.birthDateBox.Location = New System.Drawing.Point(652, 448)
        Me.birthDateBox.Name = "birthDateBox"
        Me.birthDateBox.Size = New System.Drawing.Size(176, 26)
        Me.birthDateBox.TabIndex = 29
        '
        'birthdateLabel
        '
        Me.birthdateLabel.AutoSize = True
        Me.birthdateLabel.Location = New System.Drawing.Point(557, 451)
        Me.birthdateLabel.Name = "birthdateLabel"
        Me.birthdateLabel.Size = New System.Drawing.Size(77, 20)
        Me.birthdateLabel.TabIndex = 28
        Me.birthdateLabel.Text = "BirthDate"
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 20
        Me.ListBox.Location = New System.Drawing.Point(306, 254)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(207, 204)
        Me.ListBox.TabIndex = 30
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 497)
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
        Me.Controls.Add(Me.artistBox)
        Me.Controls.Add(Me.artistLabel)
        Me.Controls.Add(Me.relaseDateBox)
        Me.Controls.Add(Me.relaseLabel)
        Me.Controls.Add(Me.lengthBox)
        Me.Controls.Add(Me.lengthLabel)
        Me.Controls.Add(Me.albumBox)
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
    Friend WithEvents insertBtt As Button
    Friend WithEvents updateBtt As Button
    Friend WithEvents deleteBtt As Button
    Friend WithEvents ClearBtt As Button
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents albumBox As TextBox
    Friend WithEvents albumLabel As Label
    Friend WithEvents lengthBox As TextBox
    Friend WithEvents lengthLabel As Label
    Friend WithEvents relaseDateBox As TextBox
    Friend WithEvents relaseLabel As Label
    Friend WithEvents artistBox As TextBox
    Friend WithEvents artistLabel As Label
    Friend WithEvents coverBox As TextBox
    Friend WithEvents coverLabel As Label
    Friend WithEvents countryBox As TextBox
    Friend WithEvents countryLabel As Label
    Friend WithEvents emailBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents surnameBox As TextBox
    Friend WithEvents surnameLabel As Label
    Friend WithEvents birthDateBox As TextBox
    Friend WithEvents birthdateLabel As Label
    Friend WithEvents ListBox As ListBox

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
