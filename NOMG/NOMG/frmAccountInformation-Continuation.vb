Public Class frmAccountInformation_Continuation
	Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
		frmAccountInformation.Show()
		Me.Hide()
	End Sub

	Private Sub btnDoctorChoosing_Click(sender As Object, e As EventArgs) Handles btnDoctorChoosing.Click

		'Check if text boxes are empty
		If txtAge.Text = "" Then
			MsgBox("please enter your age")
			Return

		ElseIf txtFirstBaby.Text = "" Then
			MsgBox("please enter details about your first baby")
			Return

		ElseIf txtGasAge.Text = "" Then
			MsgBox("please enter the age of your gestational age")
			Return ' exit the method if any textbox is empty

		Else
			AccountInformation_Doctor.Show()
			Me.Hide()
		End If

	End Sub

	Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress

		Console.WriteLine("AGE PRESS")
		' Check if the pressed key is a control key (e.g., backspace, delete, arrow keys)
		If Char.IsControl(e.KeyChar) Then
			' Allow control keys
			Exit Sub
		End If

		' Check if the pressed key is a digit
		If Not Char.IsDigit(e.KeyChar) Then
			' Suppress the non-digit key
			e.Handled = True
			MsgBox("Can only digit")
		End If
	End Sub

	Private Sub txtGasAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGasAge.KeyPress
		' Check if the pressed key is a control key (e.g., backspace, delete, arrow keys)
		If Char.IsControl(e.KeyChar) Then
			' Allow control keys
			Exit Sub
		End If

		' Check if the pressed key is a digit
		If Not Char.IsDigit(e.KeyChar) Then
			' Suppress the non-digit key
			e.Handled = True
			MsgBox("Can only digit")
		End If
	End Sub

	Private Sub txtFirstBaby_TextChanged(sender As Object, e As EventArgs) Handles txtFirstBaby.TextChanged
		Dim textBox As TextBox = CType(sender, TextBox)
		Dim input As String = textBox.Text.ToLower()

		' Check if the input is not 'y' or 'n'
		If input <> "y" AndAlso input <> "n" AndAlso input <> "" Then
			' Clear the TextBox
			textBox.Clear()

			' Show message box for invalid input
			MsgBox("Can only write y / n")
		End If
	End Sub

	Private Sub dtpLMC_ValueChanged(sender As Object, e As EventArgs) Handles dtpLMC.ValueChanged
		If dtpLMC.Value.Date > Date.Today.Date Then
			MsgBox("The date chosen is not allowed. Last Menstrual Cycle is not in the future. Please pick again.", vbRetryCancel + vbCritical, "Error")
		End If
	End Sub
End Class