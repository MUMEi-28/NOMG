Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text

Public Class frmMain
	Dim dteTracker As Date
	Public txtFrmMainPD As New List(Of TextBox)
	Public txtFrmMainCI As New List(Of TextBox)

	Public blnLogOut As Boolean
	Public blnSavedBilling As Boolean = True

	Dim intI As Integer
	Dim counter As Integer

	Private Sub dtpFirstAppointment_ValueChanged(sender As Object, e As EventArgs) Handles dtpFirstAppointment.ValueChanged
		If blnLogOut = False And frmAccountInformation.currentUser.GetListAppointments.Count = 0 Then
			If dtpFirstAppointment.Value.DayOfWeek = 0 Or dtpFirstAppointment.Value.DayOfWeek = 1 Then
				MsgBox("The date chosen is not allowed. Sunday and Monday are not available. Please pick again.", vbOKCancel + vbCritical, "Error")
			ElseIf dtpFirstAppointment.Value.Date < Date.Today.Date Then
				MsgBox("Dates in the past can not be chosen. Please pick again.", vbOKCancel + vbCritical, "Error")
			Else
				intI = 0
				counter = 0
				Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
					If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dtpFirstAppointment.Value Then
						counter = counter + 1
					End If

					intI = intI + 1
				Loop

				' Checks if higher than 4 because the other 1 of the 5 is the date being set
				If counter > 4 Then
					MsgBox("The date is fully booked.")
				Else
					frmAccountInformation.currentUser.GetListAppointments.Add(dtpFirstAppointment.Value.Date)
					frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dtpFirstAppointment.Value.Date)
					dtpFirstAppointment.Hide()
					lblAppointment.Text = "Next Check Up: " & vbCrLf & frmAccountInformation.currentUser.GetListAppointments(0)
				End If
			End If
		End If
	End Sub

	Private Sub btnViewDoctors_Click(sender As Object, e As EventArgs) Handles btnViewDoctors.Click
		frmDoctors.Show()
		Me.Hide()
	End Sub

	Public Sub New()
		InitializeComponent()

		txtFrmMainCI.Add(txtCIName)
		txtFrmMainCI.Add(txtCIAddress)
		txtFrmMainCI.Add(txtCIOperationalDays)
		For Each txt In txtFrmMainCI
			txt.Font = New Font("Nunito", 12, FontStyle.Bold)
			txt.TextAlign = HorizontalAlignment.Center
			txt.Enabled = False
		Next

		txtFrmMainPD.Add(txtPDName)
		txtFrmMainPD.Add(txtPDAddress)
		txtFrmMainPD.Add(txtPDAge)
		txtFrmMainPD.Add(txtPDFirstBaby)
		txtFrmMainPD.Add(txtPDGestationalAge)
		txtFrmMainPD.Add(txtPDAdditionalInfo)
		For Each txt In txtFrmMainPD
			txt.Font = New Font("Nunito", 12, FontStyle.Bold)
			txt.TextAlign = HorizontalAlignment.Center
			txt.Enabled = False
		Next
	End Sub

	Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
		' Resets flu vac clicked if it is not yet paid
		If frmAccountInformation.currentUser.GetClickedFV And frmAccountInformation.currentUser.GetHadFluVac = False Then
			frmAccountInformation.currentUser.SetBill(frmAccountInformation.currentUser.GetBill - 1500)
		End If
		frmAccountInformation.currentUser.SetClickedFV(False)

		frmRoutine.cbxMed1.Enabled = True
		frmRoutine.cbxMed1.Checked = False
		frmAccountInformation.currentUser.SetCBX1(0)
		blnSavedBilling = True

		ExportFileData()

		frmStart.Show()
		Me.Hide()
		blnLogOut = True

		'It is not set to current date because if it is set to the said date, users could not set it to the current date.
		dtpFirstAppointment.Value = New Date(Date.Today.Year, Date.Today.Month, Date.Today.Day - 1)
	End Sub

	Private Sub btnSeeRoutine_Click(sender As Object, e As EventArgs) Handles btnSeeRoutine.Click
		If frmAccountInformation.currentUser.GetListAppointments.Count > 0 Then
			' Checks if the user has appointments to prevent setting more
			If frmAccountInformation.currentUser.GetListAppointments.Count < 2 Then

				frmAccountInformation.currentUser.SetDteLMC(frmAccountInformation_Continuation.dtpLMC.Value.Date)
				dteTracker = frmAccountInformation.currentUser.GetListAppointments(0)

				Do While dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(9)
					If dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(3) Then
						' Checks if the clinic is open
						Do While dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1
							dteTracker = dteTracker.AddDays(1)
						Loop

						' Checks if the doctor is fully booked
						counter = 0
						intI = 0
						Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
							If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
								counter = counter + 1
							End If

							intI = intI + 1
						Loop

						' Checks if higher than 4 because the other 1 of the 5 is the date being set
						If counter > 4 Then
							MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
							dteTracker = dteTracker.AddDays(1)
						Else
							dteTracker = dteTracker.AddDays(30)
							frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
							frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
						End If

					ElseIf dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(6) Then
						' Checks if the clinic is open
						Do While dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1
							dteTracker = dteTracker.AddDays(1)
						Loop

						' Checks if the doctor is fully booked
						counter = 0
						intI = 0
						Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
							If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
								counter = counter + 1
							End If

							intI = intI + 1
						Loop

						' Checks if higher than 4 because the other 1 of the 5 is the date being set
						If counter > 4 Then
							MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
							dteTracker = dteTracker.AddDays(1)
						Else
							dteTracker = dteTracker.AddDays(20)
							frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
							frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
						End If
					Else
						' Checks if the clinic is open
						If dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1 Then
							Do While dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1
								dteTracker = dteTracker.AddDays(1)
							Loop
						End If

						' Checks if the doctor is fully booked
						counter = 0
						intI = 0
						Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
							If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
								counter = counter + 1
							End If

							intI = intI + 1
						Loop

						' Checks if higher than 4 because the other 1 of the 5 is the date being set
						If counter > 4 Then
							MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
							dteTracker = dteTracker.AddDays(1)
						Else
							dteTracker = dteTracker.AddDays(10)
							frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
							frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
						End If
					End If
				Loop
			End If

			For Each appointment In frmAccountInformation.currentUser.GetListAppointments
				frmRoutine.clbAppointments.Items.Add(appointment)
			Next

			If frmAccountInformation.currentUser.GetListCheckedAppointments.Count > 0 Then
				Dim total As Integer = frmAccountInformation.currentUser.GetListCheckedAppointments.Count
				Dim intI As Integer = 0

				While intI < total
					frmRoutine.clbAppointments.SetItemChecked(intI, True)
					intI = intI + 1

				End While
			End If

			frmRoutine.DailyMeds()

			If frmAccountInformation.currentUser.GetHadFluVac Then
				frmRoutine.cbxMed1.Enabled = False
			End If

			frmRoutine.Show()
			Me.Hide()
		Else
			MsgBox("First appointment is not set.", vbOKCancel + vbCritical, "Error")
		End If

	End Sub
	Private Sub ExportFileData()
		Try
			Dim filePath As String = txtPDName.Text + ".txt"
			Using file As New FileStream(filePath, FileMode.Create, FileAccess.Write)
				Dim textToWrite1 As String = String.Empty
				Dim textToWrite2 As String = String.Empty

				' User details with an extra line break after gestational age
				textToWrite1 = "Name: " + txtPDName.Text + vbCrLf +
						   "Address: " + txtPDAddress.Text + vbCrLf +
						   "Age: " + txtPDAge.Text + vbCrLf +
						   "First Baby: " + txtPDFirstBaby.Text + vbCrLf +
						   "Gestational Age: " + txtPDGestationalAge.Text + vbCrLf + vbCrLf

				' List Appointments
				If frmAccountInformation.currentUser.GetListAppointments().Count <= 0 Then
					textToWrite2 += "List Appointments: Nothing" + vbCrLf + vbCrLf
				Else
					textToWrite2 += "List Appointments:" + vbCrLf
					For Each appointment In frmAccountInformation.currentUser.GetListAppointments()
						textToWrite2 += appointment.ToString() + vbCrLf
					Next
					textToWrite2 += vbCrLf ' Add an extra line break after the list of appointments
				End If

				' Payment status
				If frmAccountInformation.currentUser.GetListIsPaid().Count <= 0 Then
					textToWrite2 += "List is paid: No" + vbCrLf + vbCrLf
				Else
					'	textToWrite2 += "List is paid: Yes" + vbCrLf + vbCrLf
					textToWrite2 += "List Is paid:" + vbCrLf
					For Each appointment In frmAccountInformation.currentUser.GetListIsPaid()

						textToWrite2 += appointment.ToString() + vbCrLf
					Next
					textToWrite2 += vbCrLf ' Add an extra line break after the list of appointments
				End If

				' List Checked Appointments
				If frmAccountInformation.currentUser.GetListCheckedAppointments().Count <= 0 Then
					textToWrite2 += "List Checked Appointments: None" + vbCrLf
				Else
					textToWrite2 += "List Checked Appointments: "
					For Each checkedAppointment In frmAccountInformation.currentUser.GetListCheckedAppointments()
						textToWrite2 += checkedAppointment.ToString() + ", "
					Next

					' Remove the trailing comma and space, and add a newline
					If textToWrite2.EndsWith(", ") Then
						textToWrite2 = textToWrite2.Substring(0, textToWrite2.Length - 2) + vbCrLf
					End If
				End If

				Dim textToWrite3 As String = String.Empty

				' Bill
				Dim billAmount As Double = frmAccountInformation.currentUser.GetBill()
				Dim amountToSubtract As Double = 0

				' Attempt to parse the amount to subtract from frmBilling.txtAmount5.Text
				If Double.TryParse(frmBilling.txtAmount5.Text, amountToSubtract) Then
					billAmount -= amountToSubtract
				End If

				If billAmount <= 0 Then
					textToWrite3 = "Bill: Nothing" + vbCrLf
				Else
					textToWrite3 = "Bill: " + billAmount.ToString() + vbCrLf
				End If


				Dim textToWrite4 As String = String.Empty
				textToWrite4 = "Had Flu Vaccine: " + frmAccountInformation.currentUser.GetHadFluVac().ToString()

				' Write to file
				Dim bytesToWrite() As Byte = Encoding.UTF8.GetBytes(textToWrite1 + textToWrite2 + vbCrLf + textToWrite3 + vbCrLf + textToWrite4)
				file.Write(bytesToWrite, 0, bytesToWrite.Length)
			End Using
		Catch ex As Exception
			' Handle any exceptions (e.g., file access, permissions, etc.)
			MsgBox("Error: Can't export file. " & ex.Message)
		End Try
	End Sub

	Private Sub btnBillingInfo_Click(sender As Object, e As EventArgs) Handles btnBillingInfo.Click
		If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = 0 Then
			frmBilling.ClearBillingFields()
		ElseIf blnSavedBilling Then
			frmBilling.SavedBilling()
		End If

		frmBilling.txtName.Text = frmAccountInformation.currentUser.GetName()
		frmBilling.Show()
		Me.Hide()
	End Sub
End Class