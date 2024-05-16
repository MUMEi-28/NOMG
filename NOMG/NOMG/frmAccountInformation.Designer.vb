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
		Me.pnlMain = New System.Windows.Forms.Panel()
		Me.btnContinue = New System.Windows.Forms.Button()
		Me.btnBackToStart = New System.Windows.Forms.Button()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.lblNewAcc = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.lblName = New System.Windows.Forms.Label()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.lblTItle = New System.Windows.Forms.Label()
		Me.ptbDr = New System.Windows.Forms.PictureBox()
		Me.pnlMain.SuspendLayout()
		CType(Me.ptbDr, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlMain
		'
		Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.pnlMain.Controls.Add(Me.btnContinue)
		Me.pnlMain.Controls.Add(Me.btnBackToStart)
		Me.pnlMain.Controls.Add(Me.lblAddress)
		Me.pnlMain.Controls.Add(Me.lblNewAcc)
		Me.pnlMain.Controls.Add(Me.txtPassword)
		Me.pnlMain.Controls.Add(Me.lblName)
		Me.pnlMain.Controls.Add(Me.txtAddress)
		Me.pnlMain.Controls.Add(Me.lblPassword)
		Me.pnlMain.Controls.Add(Me.txtEmail)
		Me.pnlMain.Controls.Add(Me.lblEmail)
		Me.pnlMain.Controls.Add(Me.txtName)
		Me.pnlMain.Location = New System.Drawing.Point(12, 101)
		Me.pnlMain.Name = "pnlMain"
		Me.pnlMain.Size = New System.Drawing.Size(474, 473)
		Me.pnlMain.TabIndex = 2
		'
		'btnContinue
		'
		Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnContinue.Location = New System.Drawing.Point(258, 317)
		Me.btnContinue.Name = "btnContinue"
		Me.btnContinue.Size = New System.Drawing.Size(190, 59)
		Me.btnContinue.TabIndex = 5
		Me.btnContinue.Text = "CONTINUE"
		Me.btnContinue.UseVisualStyleBackColor = False
		'
		'btnBackToStart
		'
		Me.btnBackToStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnBackToStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBackToStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnBackToStart.Location = New System.Drawing.Point(17, 317)
		Me.btnBackToStart.Name = "btnBackToStart"
		Me.btnBackToStart.Size = New System.Drawing.Size(190, 59)
		Me.btnBackToStart.TabIndex = 4
		Me.btnBackToStart.Text = "BACK"
		Me.btnBackToStart.UseVisualStyleBackColor = False
		'
		'lblAddress
		'
		Me.lblAddress.AutoSize = True
		Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblAddress.Location = New System.Drawing.Point(16, 135)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(60, 17)
		Me.lblAddress.TabIndex = 13
		Me.lblAddress.Text = "Address"
		'
		'lblNewAcc
		'
		Me.lblNewAcc.AutoSize = True
		Me.lblNewAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblNewAcc.Location = New System.Drawing.Point(170, 13)
		Me.lblNewAcc.Name = "lblNewAcc"
		Me.lblNewAcc.Size = New System.Drawing.Size(158, 62)
		Me.lblNewAcc.TabIndex = 10
		Me.lblNewAcc.Text = "Create New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account"
		Me.lblNewAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtPassword
		'
		Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtPassword.Location = New System.Drawing.Point(18, 263)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(430, 23)
		Me.txtPassword.TabIndex = 3
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblName.Location = New System.Drawing.Point(16, 79)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(45, 17)
		Me.lblName.TabIndex = 5
		Me.lblName.Text = "Name"
		'
		'txtAddress
		'
		Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtAddress.Location = New System.Drawing.Point(19, 155)
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(430, 23)
		Me.txtAddress.TabIndex = 1
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblPassword.Location = New System.Drawing.Point(16, 243)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(69, 17)
		Me.lblPassword.TabIndex = 3
		Me.lblPassword.Text = "Password"
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
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblEmail.Location = New System.Drawing.Point(16, 191)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(42, 17)
		Me.lblEmail.TabIndex = 1
		Me.lblEmail.Text = "Email"
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
		'lblTItle
		'
		Me.lblTItle.AutoSize = True
		Me.lblTItle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTItle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblTItle.Location = New System.Drawing.Point(194, 19)
		Me.lblTItle.Name = "lblTItle"
		Me.lblTItle.Size = New System.Drawing.Size(148, 46)
		Me.lblTItle.TabIndex = 2
		Me.lblTItle.Text = "NOMG"
		Me.lblTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ptbDr
		'
		Me.ptbDr.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ptbDr.Image = Global.NOMG.My.Resources.Resources.drLogin_2
		Me.ptbDr.Location = New System.Drawing.Point(489, -15)
		Me.ptbDr.Name = "ptbDr"
		Me.ptbDr.Size = New System.Drawing.Size(521, 765)
		Me.ptbDr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ptbDr.TabIndex = 13
		Me.ptbDr.TabStop = False
		'
		'frmAccountInformation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(987, 689)
		Me.Controls.Add(Me.ptbDr)
		Me.Controls.Add(Me.lblTItle)
		Me.Controls.Add(Me.pnlMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "frmAccountInformation"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Register"
		Me.pnlMain.ResumeLayout(False)
		Me.pnlMain.PerformLayout()
		CType(Me.ptbDr, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents pnlMain As Panel
	Friend WithEvents lblTItle As Label
	Friend WithEvents btnBackToStart As Button
	Friend WithEvents btnContinue As Button
	Friend WithEvents lblNewAcc As Label
	Friend WithEvents lblAddress As Label
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents lblName As Label
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents lblPassword As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents lblEmail As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents ptbDr As PictureBox
End Class
