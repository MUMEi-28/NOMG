Public Class frmAccountInformation

	Public listUsers As New List(Of User)
	Public strCurrentUser As User
	Public listDoctors As New List(Of Doctor)
	Public intDoctor As New Integer
	Public Sub New()
		InitializeComponent()

		Dim dr1 As New Doctor("Dr. Richard U. Aganon", 36, "Male", "Niña's Ville Subdivision, Tarlac City", "Angeles University Foundation")
		Dim dr2 As New Doctor("Dr. Maya Grace S. Ramos", 35, "Female", "Macabulos Drive, Tarlac City", "University of the Philippines Manila")
		Dim dr3 As New Doctor("Dr. Maria D. Lopez", 38, "Female", "San Sebastian Village, Tarlac City", "Saint Louis University")

		listDoctors.Add(dr1)
		listDoctors.Add(dr2)
		listDoctors.Add(dr3)

		Dim user1 As New User("Jose", "Tarlac", "jose@email", "1234", 24, "y", 20, listDoctors(0), 1)
		Dim user2 As New User("Juana", "Pangasinan", "juana@email", "1234", 35, "y", 15, listDoctors(1), 1)
		Dim user3 As New User("Cardo", "Davao", "cardo@email", "1234", 30, "n", 12, listDoctors(2), 1)

		listUsers.Add(user1)
		listUsers.Add(user2)
		listUsers.Add(user3)

		intDoctor = 1
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
		Private intDoctor As Integer

		' Constructor with no parameters
		Public Sub New()

		End Sub

		' User Constructor
		Public Sub New(ByVal strTempName As String, ByVal strTempAddress As String,
					   ByVal strTempEmail As String, ByVal strTempPass As String,
					   ByVal strIntAge As Integer, ByVal strTmpIsFirstBaby As String,
					   ByVal intTmpGesAge As Integer, ByVal tempDoctor As Doctor,
					   ByVal intTmpDoctor As Integer)
			strName = strTempName
			strAddress = strTempAddress
			strEmail = strTempEmail
			strPass = strTempPass
			intAge = strIntAge
			intGestationalAge = intTmpGesAge
			doctor = tempDoctor
			intTmpDoctor = 1

			strIsFirstBaby = strTmpIsFirstBaby
		End Sub

		Public Sub SetUserCredentials(ByVal strTempName As String, ByVal strTempAddress As String,
					   ByVal strTempEmail As String, ByVal strTempPass As String,
					   ByVal strIntAge As Integer, ByVal strTmpIsFirstBaby As String,
					   ByVal intTmpGesAge As Integer)
			strName = strTempName
			strAddress = strTempAddress
			strEmail = strTempEmail
			strPass = strTempPass
			intAge = strIntAge
			intGestationalAge = intTmpGesAge

			strIsFirstBaby = strTmpIsFirstBaby

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
		Public Function GetDoctorInt() As Integer
			Return intDoctor
		End Function
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
			MsgBox("Can only digit")
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
			MsgBox("Can only digit")
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
			MsgBox("Can only write y / n")
		End If
	End Sub

	Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

		'		Check If any TextBox Is empty
		If txtName.Text = "" Then
			MsgBox("Please enter your name")
			Return


		ElseIf txtAddress.Text = "" Then
			MsgBox("Please enter your address")
			Return

		ElseIf txtEmail.Text = "" Then
			MsgBox("Please enter your email")
			Return

		ElseIf txtPassword.Text = "" Then
			MsgBox("Please enter your password")
			Return
		Else
			frmAccountInformation_Continuation.Show()
			Me.Hide()
		End If

	End Sub
End Class