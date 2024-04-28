<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnLogIn = New System.Windows.Forms.Button()
		Me.btnBackToStart = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnLogIn
		'
		Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnLogIn.Location = New System.Drawing.Point(319, 226)
		Me.btnLogIn.Name = "btnLogIn"
		Me.btnLogIn.Size = New System.Drawing.Size(190, 59)
		Me.btnLogIn.TabIndex = 12
		Me.btnLogIn.Text = "REGISTER"
		Me.btnLogIn.UseVisualStyleBackColor = False
		'
		'btnBackToStart
		'
		Me.btnBackToStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.btnBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnBackToStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBackToStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnBackToStart.Location = New System.Drawing.Point(35, 226)
		Me.btnBackToStart.Name = "btnBackToStart"
		Me.btnBackToStart.Size = New System.Drawing.Size(190, 59)
		Me.btnBackToStart.TabIndex = 11
		Me.btnBackToStart.Text = "BACK"
		Me.btnBackToStart.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(215, 22)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(106, 31)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "LOG IN"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.TextBox2)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.TextBox1)
		Me.Panel1.Location = New System.Drawing.Point(25, 85)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(474, 119)
		Me.Panel1.TabIndex = 10
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(324, 53)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(88, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "PASSWORD"
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.TextBox2.Location = New System.Drawing.Point(21, 50)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(297, 20)
		Me.TextBox2.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(324, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "EMAIL"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.TextBox1.Location = New System.Drawing.Point(21, 21)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(297, 23)
		Me.TextBox1.TabIndex = 0
		'
		'frmLogIn
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(522, 308)
		Me.Controls.Add(Me.btnLogIn)
		Me.Controls.Add(Me.btnBackToStart)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmLogIn"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmLogIn"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnLogIn As Button
	Friend WithEvents btnBackToStart As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
End Class
