<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnExisting = New System.Windows.Forms.Button()
		Me.btnNew = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(150, 52)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(199, 63)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "NOMG"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'btnExisting
		'
		Me.btnExisting.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.btnExisting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExisting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.btnExisting.Location = New System.Drawing.Point(125, 235)
		Me.btnExisting.Name = "btnExisting"
		Me.btnExisting.Size = New System.Drawing.Size(252, 59)
		Me.btnExisting.TabIndex = 1
		Me.btnExisting.Text = "I AM AN EXISTING PATIENT"
		Me.btnExisting.UseVisualStyleBackColor = False
		'
		'btnNew
		'
		Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.btnNew.Location = New System.Drawing.Point(125, 300)
		Me.btnNew.Name = "btnNew"
		Me.btnNew.Size = New System.Drawing.Size(252, 59)
		Me.btnNew.TabIndex = 2
		Me.btnNew.Text = "I AM A NEW PATIENT"
		Me.btnNew.UseVisualStyleBackColor = False
		'
		'frmStart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(484, 562)
		Me.Controls.Add(Me.btnNew)
		Me.Controls.Add(Me.btnExisting)
		Me.Controls.Add(Me.Label3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmStart"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmRegistration"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label3 As Label
	Friend WithEvents btnExisting As Button
	Friend WithEvents btnNew As Button
End Class
