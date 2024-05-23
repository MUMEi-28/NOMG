<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogIn
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
		Me.btnLogIn = New System.Windows.Forms.Button()
		Me.btnBackToStart = New System.Windows.Forms.Button()
		Me.lblLogIn = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.pnlMain = New System.Windows.Forms.Panel()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.ptbDr = New System.Windows.Forms.PictureBox()
		Me.pnlMain.SuspendLayout()
		CType(Me.ptbDr, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnLogIn
		'
		Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnLogIn.Location = New System.Drawing.Point(132, 244)
		Me.btnLogIn.Name = "btnLogIn"
		Me.btnLogIn.Size = New System.Drawing.Size(190, 59)
		Me.btnLogIn.TabIndex = 2
		Me.btnLogIn.Text = "Continue"
		Me.btnLogIn.UseVisualStyleBackColor = False
		'
		'btnBackToStart
		'
		Me.btnBackToStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnBackToStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBackToStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnBackToStart.Location = New System.Drawing.Point(132, 335)
		Me.btnBackToStart.Name = "btnBackToStart"
		Me.btnBackToStart.Size = New System.Drawing.Size(190, 59)
		Me.btnBackToStart.TabIndex = 3
		Me.btnBackToStart.Text = "Back"
		Me.btnBackToStart.UseVisualStyleBackColor = False
		'
		'lblLogIn
		'
		Me.lblLogIn.AutoSize = True
		Me.lblLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblLogIn.Location = New System.Drawing.Point(189, 38)
		Me.lblLogIn.Name = "lblLogIn"
		Me.lblLogIn.Size = New System.Drawing.Size(112, 31)
		Me.lblLogIn.TabIndex = 9
		Me.lblLogIn.Text = "LOG IN"
		'
		'txtEmail
		'
		Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtEmail.Location = New System.Drawing.Point(34, 128)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(395, 23)
		Me.txtEmail.TabIndex = 0
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblEmail.Location = New System.Drawing.Point(31, 108)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(42, 17)
		Me.lblEmail.TabIndex = 1
		Me.lblEmail.Text = "Email"
		'
		'pnlMain
		'
		Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.pnlMain.Controls.Add(Me.lblPassword)
		Me.pnlMain.Controls.Add(Me.txtPassword)
		Me.pnlMain.Controls.Add(Me.btnBackToStart)
		Me.pnlMain.Controls.Add(Me.btnLogIn)
		Me.pnlMain.Controls.Add(Me.lblEmail)
		Me.pnlMain.Controls.Add(Me.lblLogIn)
		Me.pnlMain.Controls.Add(Me.txtEmail)
		Me.pnlMain.Location = New System.Drawing.Point(12, 91)
		Me.pnlMain.Name = "pnlMain"
		Me.pnlMain.Size = New System.Drawing.Size(474, 428)
		Me.pnlMain.TabIndex = 10
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblPassword.Location = New System.Drawing.Point(31, 172)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(69, 17)
		Me.lblPassword.TabIndex = 14
		Me.lblPassword.Text = "Password"
		'
		'txtPassword
		'
		Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtPassword.Location = New System.Drawing.Point(34, 192)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(395, 23)
		Me.txtPassword.TabIndex = 1
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblTitle.Location = New System.Drawing.Point(175, 25)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(148, 46)
		Me.lblTitle.TabIndex = 14
		Me.lblTitle.Text = "NOMG"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ptbDr
		'
		Me.ptbDr.Image = Global.NOMG.My.Resources.Resources.Dr_Login
		Me.ptbDr.Location = New System.Drawing.Point(492, -66)
		Me.ptbDr.Name = "ptbDr"
		Me.ptbDr.Size = New System.Drawing.Size(495, 876)
		Me.ptbDr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ptbDr.TabIndex = 15
		Me.ptbDr.TabStop = False
		'
		'frmLogIn
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(987, 689)
		Me.Controls.Add(Me.ptbDr)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.pnlMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "frmLogIn"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmLogIn"
		Me.pnlMain.ResumeLayout(False)
		Me.pnlMain.PerformLayout()
		CType(Me.ptbDr, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnLogIn As Button
	Friend WithEvents btnBackToStart As Button
	Friend WithEvents lblLogIn As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents ptbDr As PictureBox
End Class
