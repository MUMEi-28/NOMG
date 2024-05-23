Imports System.Drawing.Text
Public Class frmAccountInformation

	Public listUsers As New List(Of User)
	Public currentUser As User
	Public listDoctors As New List(Of Doctor)
	Public Sub New()
		InitializeComponent()

		Dim dr1 As New Doctor("Dr. Richard U. Aganon", 36, "Male", "Niña's Ville Subdivision, Tarlac City", "Angeles University Foundation")
		Dim dr2 As New Doctor("Dr. Maya Grace S. Ramos", 35, "Female", "Macabulos Drive, Tarlac City", "University of the Philippines Manila")
		Dim dr3 As New Doctor("Dr. Maria D. Lopez", 38, "Female", "San Sebastian Village, Tarlac City", "Saint Louis University")

		listDoctors.Add(dr1)
		listDoctors.Add(dr2)
		listDoctors.Add(dr3)
	End Sub
	Class User
		Private strName As String
		Private strAddress As String
		Private strEmail As String
		Private strPass As String
		Private intAge As Integer
		Private strIsFirstBaby As String
		Private intGestationalAge As Integer
		Private listAppointments As New List(Of Date)
		Private doctor As Doctor
		Private dteLMC As Date
		Private listCheckedAppointments As New List(Of Integer)
		Private listIsPaid As New List(Of Boolean)
		Private dblBill As Double
		Private blnHadFluVac As Boolean
		Private intCBX1 As Integer
		Private blnClickedFV As Boolean

		' Constructor with no parameters
		Public Sub New()
			' Ensure doctor is initialized
			'		doctor = New Doctor()
		End Sub

		' User Constructor
		Public Sub New(ByVal strTempName As String, ByVal strTempAddress As String,
					   ByVal strTempEmail As String, ByVal strTempPass As String,
					   ByVal strIntAge As Integer, ByVal strTmpIsFirstBaby As String,
					   ByVal intTmpGesAge As Integer, ByVal tempDoctor As Doctor,
					   ByVal dteTempLMC As Date)
			strName = strTempName
			strAddress = strTempAddress
			strEmail = strTempEmail
			strPass = strTempPass
			intAge = strIntAge
			strIsFirstBaby = strTmpIsFirstBaby
			intGestationalAge = intTmpGesAge
			doctor = tempDoctor
			dteLMC = dteTempLMC
		End Sub

		Public Sub SetUserCredentials(ByVal strTempName As String, ByVal strTempAddress As String,
					   ByVal strTempEmail As String, ByVal strTempPass As String,
					   ByVal strIntAge As Integer, ByVal strTmpIsFirstBaby As String,
					   ByVal intTmpGesAge As Integer, ByVal tempDoctor As Doctor,
					   ByVal dteTempLMC As Date)
			strName = strTempName
			strAddress = strTempAddress
			strEmail = strTempEmail
			strPass = strTempPass
			intAge = strIntAge
			strIsFirstBaby = strTmpIsFirstBaby
			intGestationalAge = intTmpGesAge
			doctor = tempDoctor
			dteLMC = dteTempLMC
		End Sub
		Public Function GetName() As String
			Return strName
		End Function
		Public Function GetAddress() As String
			Return strAddress
		End Function
		Public Function GetEmail() As String
			Return strEmail
		End Function
		Public Function GetPass() As String
			Return strPass
		End Function
		Public Function GetAge() As Integer
			Return intAge
		End Function
		Public Function GetIsFirstBaby() As String
			Return strIsFirstBaby
		End Function
		Public Function GetGestationalAge() As Integer
			Return intGestationalAge
		End Function
		Public Function GetListAppointments() As List(Of Date)
			Return listAppointments
		End Function
		Public Function GetDoctor() As Doctor
			Return doctor
		End Function
		Public Function GetDteLMC() As Date
			Return dteLMC
		End Function
		Public Function GetListCheckedAppointments() As List(Of Integer)
			Return listCheckedAppointments
		End Function
		Public Function GetListIsPaid() As List(Of Boolean)
			Return listIsPaid
		End Function
		Public Function GetBill() As Double
			Return dblBill
		End Function
		Public Function GetHadFluVac() As Boolean
			Return blnHadFluVac
		End Function
		Public Function GetClickedFV() As Boolean
			Return blnClickedFV
		End Function
		Public Function GetCBX1() As Integer
			Return intCBX1
		End Function
		Public Sub SetDoctor(ByVal tempDoctor As Doctor)
			doctor = tempDoctor
		End Sub
		Public Sub SetDteLMC(ByVal dteTempLMC As Date)
			dteLMC = dteTempLMC
		End Sub
		Public Sub SetListCheckedAppointments(ByVal listTempCA As List(Of Integer))
			listCheckedAppointments = listTempCA
		End Sub

		Public Sub SetListIsPaid(ByVal listTempIsPaid As List(Of Boolean))
			listIsPaid = listTempIsPaid
		End Sub
		Public Sub SetBill(ByVal dblTempBill As Double)
			dblBill = dblTempBill
		End Sub
		Public Sub SetHadFluVac(ByVal blnTempHadFluVac As Double)
			blnHadFluVac = blnTempHadFluVac
		End Sub
		Public Sub SetCBX1(ByVal intTempCB1 As Integer)
			intCBX1 = intTempCB1
		End Sub
		Public Sub SetClickedFV(ByVal blnTempClickedFV As Double)
			blnClickedFV = blnTempClickedFV
		End Sub
	End Class

	Class Doctor
		Private strName As String
		Private intAge As Integer
		Private strGender As String
		Private strAddress As String
		Private strEduc As String

		Public listDrAppointments As New List(Of Date)

		Public Sub New(ByVal strTempName As String, ByVal intTempAge As Integer, ByVal strTempGender As String, ByVal strTempAddress As String, ByVal strTempEduc As String)
			strName = strTempName
			intAge = intTempAge
			strGender = strTempGender
			strAddress = strTempAddress
			strEduc = strTempEduc
		End Sub

		Public Sub New()

		End Sub

		Public Function GetListDrAppointment() As List(Of Date)
			Return listDrAppointments
		End Function


		Public Function GetName() As String
			Return strName
		End Function
	End Class
	Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
		frmStart.Show()
		Me.Hide()

	End Sub



	Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs)
		' Check if the pressed key is a control key (e.g., backspace, delete, arrow keys)
		If Char.IsControl(e.KeyChar) Then
			' Allow control keys
			Exit Sub
		End If

		' Check if the pressed key is a digit
		If Not Char.IsDigit(e.KeyChar) Then
			' Suppress the non-digit key
			e.Handled = True
			MsgBox("Can only enter digit", vbOKCancel + vbCritical, "Error")
		End If
	End Sub

	Private Sub txtGasAge_KeyPress(sender As Object, e As KeyPressEventArgs)
		' Check if the pressed key is a control key (e.g., backspace, delete, arrow keys)
		If Char.IsControl(e.KeyChar) Then
			' Allow control keys
			Exit Sub
		End If

		' Check if the pressed key is a digit
		If Not Char.IsDigit(e.KeyChar) Then
			' Suppress the non-digit key
			e.Handled = True
			MsgBox("Can only enter digit", vbOKCancel + vbCritical, "Error")
		End If
	End Sub

	Private Sub txtFirstBaby_TextChanged(sender As Object, e As EventArgs)
		Dim textBox As TextBox = CType(sender, TextBox)
		Dim input As String = textBox.Text.ToLower()

		' Check if the input is not 'y' or 'n'
		If input <> "y" AndAlso input <> "n" AndAlso input <> "" Then
			' Clear the TextBox
			textBox.Clear()

			' Show message box for invalid input
			MsgBox("Can only write y / n", vbOKCancel + vbCritical, "Error")
		End If
	End Sub

	Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

		'		Check If any TextBox Is empty
		If txtName.Text = "" Then
			MsgBox("Please enter your name", vbOKCancel + vbCritical, "Error")
			Return


		ElseIf txtAddress.Text = "" Then
			MsgBox("Please enter your address", vbOKCancel + vbCritical, "Error")
			Return

		ElseIf txtEmail.Text = "" Then
			MsgBox("Please enter your email", vbOKCancel + vbCritical, "Error")
			Return

		ElseIf txtPassword.Text = "" Then
			MsgBox("Please enter your password", vbOKCancel + vbCritical, "Error")
			Return
		Else
			frmAccountInformation_Continuation.Show()
			Me.Hide()
		End If

	End Sub
End Class