﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoutine
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.clbAppointments = New System.Windows.Forms.CheckedListBox()
        Me.btnViewCalendar = New System.Windows.Forms.Button()
        Me.ptbAppointments = New System.Windows.Forms.PictureBox()
        CType(Me.ptbAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(460, 674)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(359, 48)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'clbAppointments
        '
        Me.clbAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAppointments.FormattingEnabled = True
        Me.clbAppointments.Location = New System.Drawing.Point(35, 334)
        Me.clbAppointments.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clbAppointments.Name = "clbAppointments"
        Me.clbAppointments.Size = New System.Drawing.Size(361, 204)
        Me.clbAppointments.TabIndex = 3
        '
        'btnViewCalendar
        '
        Me.btnViewCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCalendar.Location = New System.Drawing.Point(79, 566)
        Me.btnViewCalendar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewCalendar.Name = "btnViewCalendar"
        Me.btnViewCalendar.Size = New System.Drawing.Size(276, 44)
        Me.btnViewCalendar.TabIndex = 5
        Me.btnViewCalendar.Text = "View Calendar"
        Me.btnViewCalendar.UseVisualStyleBackColor = True
        '
        'ptbAppointments
        '
        Me.ptbAppointments.Image = Global.NOMG.My.Resources.Resources._5
        Me.ptbAppointments.Location = New System.Drawing.Point(0, 1)
        Me.ptbAppointments.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptbAppointments.Name = "ptbAppointments"
        Me.ptbAppointments.Size = New System.Drawing.Size(1280, 800)
        Me.ptbAppointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAppointments.TabIndex = 1
        Me.ptbAppointments.TabStop = False
        '
        'frmRoutine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 801)
        Me.Controls.Add(Me.btnViewCalendar)
        Me.Controls.Add(Me.clbAppointments)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ptbAppointments)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRoutine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Routine"
        CType(Me.ptbAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ptbAppointments As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents clbAppointments As CheckedListBox
    Friend WithEvents btnViewCalendar As Button
End Class