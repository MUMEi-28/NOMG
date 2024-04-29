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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
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
		Me.btnLogIn.TabIndex = 12
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
		Me.btnBackToStart.TabIndex = 11
		Me.btnBackToStart.Text = "Back"
		Me.btnBackToStart.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(189, 38)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(112, 31)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "LOG IN"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.PictureBox1.Location = New System.Drawing.Point(492, -4)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(498, 692)
		Me.PictureBox1.TabIndex = 13
		Me.PictureBox1.TabStop = False
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
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(31, 108)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(42, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Email"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.txtPassword)
		Me.Panel1.Controls.Add(Me.btnBackToStart)
		Me.Panel1.Controls.Add(Me.btnLogIn)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.txtEmail)
		Me.Panel1.Location = New System.Drawing.Point(12, 91)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(474, 428)
		Me.Panel1.TabIndex = 10
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(175, 25)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(148, 46)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "NOMG"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(31, 172)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 17)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "Password"
		'
		'txtPassword
		'
		Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtPassword.Location = New System.Drawing.Point(34, 192)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(395, 23)
		Me.txtPassword.TabIndex = 13
		'
		'frmLogIn
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(987, 689)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmLogIn"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmLogIn"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnLogIn As Button
	Friend WithEvents btnBackToStart As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtPassword As TextBox
End Class
