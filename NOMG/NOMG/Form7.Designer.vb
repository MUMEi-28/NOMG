<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount:"
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(133, 58)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(125, 31)
        Me.txtPayment.TabIndex = 1
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnPay.Location = New System.Drawing.Point(286, 42)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(80, 29)
        Me.btnPay.TabIndex = 2
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(286, 77)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 29)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 157)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPayment"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnCancel As Button
End Class
