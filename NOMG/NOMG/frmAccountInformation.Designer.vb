<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccountInformation
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cmbFirstBaby = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtGasAge = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnBackToStart = New System.Windows.Forms.Button()
		Me.btnRegister = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtAge = New System.Windows.Forms.TextBox()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtName
		'
		Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtName.Location = New System.Drawing.Point(19, 99)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(430, 23)
		Me.txtName.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(16, 191)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(42, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Email"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.Panel1.Controls.Add(Me.txtAge)
		Me.Panel1.Controls.Add(Me.btnRegister)
		Me.Panel1.Controls.Add(Me.btnBackToStart)
		Me.Panel1.Controls.Add(Me.Label9)
		Me.Panel1.Controls.Add(Me.Label8)
		Me.Panel1.Controls.Add(Me.cmbFirstBaby)
		Me.Panel1.Controls.Add(Me.Label7)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.txtGasAge)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.txtPassword)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.txtAddress)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.txtEmail)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.txtName)
		Me.Panel1.Location = New System.Drawing.Point(12, 101)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(474, 473)
		Me.Panel1.TabIndex = 2
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label9.Location = New System.Drawing.Point(16, 135)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(60, 17)
		Me.Label9.TabIndex = 13
		Me.Label9.Text = "Address"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label8.Location = New System.Drawing.Point(170, 13)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(158, 62)
		Me.Label8.TabIndex = 10
		Me.Label8.Text = "Create New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cmbFirstBaby
		'
		Me.cmbFirstBaby.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.cmbFirstBaby.FormattingEnabled = True
		Me.cmbFirstBaby.Location = New System.Drawing.Point(190, 321)
		Me.cmbFirstBaby.Name = "cmbFirstBaby"
		Me.cmbFirstBaby.Size = New System.Drawing.Size(92, 21)
		Me.cmbFirstBaby.TabIndex = 12
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label7.Location = New System.Drawing.Point(187, 299)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(95, 17)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "FIRST BABY?"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label6.Location = New System.Drawing.Point(311, 299)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(138, 17)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "GASTATIONAL AGE"
		'
		'txtGasAge
		'
		Me.txtGasAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtGasAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGasAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtGasAge.Location = New System.Drawing.Point(314, 319)
		Me.txtGasAge.Name = "txtGasAge"
		Me.txtGasAge.Size = New System.Drawing.Size(134, 23)
		Me.txtGasAge.TabIndex = 8
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(16, 299)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(37, 17)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "AGE"
		'
		'txtPassword
		'
		Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtPassword.Location = New System.Drawing.Point(18, 263)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(430, 23)
		Me.txtPassword.TabIndex = 6
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(16, 79)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(45, 17)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Name"
		'
		'txtAddress
		'
		Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtAddress.Location = New System.Drawing.Point(19, 155)
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(430, 23)
		Me.txtAddress.TabIndex = 4
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(16, 243)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Password"
		'
		'txtEmail
		'
		Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtEmail.Location = New System.Drawing.Point(18, 211)
		Me.txtEmail.Multiline = True
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(430, 20)
		Me.txtEmail.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(194, 19)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(148, 46)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "NOMG"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnBackToStart
		'
		Me.btnBackToStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnBackToStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBackToStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnBackToStart.Location = New System.Drawing.Point(18, 370)
		Me.btnBackToStart.Name = "btnBackToStart"
		Me.btnBackToStart.Size = New System.Drawing.Size(190, 59)
		Me.btnBackToStart.TabIndex = 7
		Me.btnBackToStart.Text = "BACK"
		Me.btnBackToStart.UseVisualStyleBackColor = False
		'
		'btnRegister
		'
		Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnRegister.Location = New System.Drawing.Point(259, 370)
		Me.btnRegister.Name = "btnRegister"
		Me.btnRegister.Size = New System.Drawing.Size(190, 59)
		Me.btnRegister.TabIndex = 8
		Me.btnRegister.Text = "REGISTER"
		Me.btnRegister.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.PictureBox1.Location = New System.Drawing.Point(492, -4)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(498, 692)
		Me.PictureBox1.TabIndex = 9
		Me.PictureBox1.TabStop = False
		'
		'txtAge
		'
		Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtAge.Location = New System.Drawing.Point(19, 319)
		Me.txtAge.Name = "txtAge"
		Me.txtAge.Size = New System.Drawing.Size(134, 23)
		Me.txtAge.TabIndex = 14
		'
		'frmAccountInformation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(987, 689)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmAccountInformation"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmRegistration"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtName As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents btnBackToStart As Button
	Friend WithEvents btnRegister As Button
	Friend WithEvents cmbFirstBaby As ComboBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtGasAge As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents txtAge As TextBox
End Class
