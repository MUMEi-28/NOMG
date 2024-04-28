<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccountRegistration
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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnExisting = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
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
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.TextBox2)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.TextBox1)
		Me.Panel1.Location = New System.Drawing.Point(12, 101)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(416, 108)
		Me.Panel1.TabIndex = 2
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
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(96, 26)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(224, 46)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "REGISTER"
		'
		'btnExisting
		'
		Me.btnExisting.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.btnExisting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExisting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnExisting.Location = New System.Drawing.Point(12, 253)
		Me.btnExisting.Name = "btnExisting"
		Me.btnExisting.Size = New System.Drawing.Size(190, 59)
		Me.btnExisting.TabIndex = 7
		Me.btnExisting.Text = "BACK"
		Me.btnExisting.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Button1.Location = New System.Drawing.Point(238, 253)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(190, 59)
		Me.Button1.TabIndex = 8
		Me.Button1.Text = "REGISTER"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'frmRegistration
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(448, 357)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnExisting)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "frmRegistration"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmRegistration"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents btnExisting As Button
	Friend WithEvents Button1 As Button
End Class
