Public Class frmAccountInformation

	Public listUsers As New List(Of User)
	Public strCurrentUser As User

	Public Sub New()
		InitializeComponent()


		Dim user1 As New User("Jose", "Tarlac", "jose@email", "1234", 24, True, 20)
		Dim user2 As New User("Juana", "Pangasinan", "juana@email", "1234", 35, False, 15)
		Dim user3 As New User("Cardo", "Davao", "cardo@email", "1234", 30, False, 12)

		listUsers.Add(user1)
		listUsers.Add(user2)
		listUsers.Add(user3)
	End Sub
	Class User
		Private strName As String
		Private strAddress As String
		Private strEmail As String
		Private strPass As String
		Private intAge As Integer
		Private strIsFirstBaby As String
		Private intGestationalAge As Integer

		' Constructor with no parameters
		Public Sub New()

		End Sub

		' User Constructor
		Public Sub New(ByVal strTempName As String, ByVal strTempAddress As String,
					   ByVal strTempEmail As String, ByVal strTempPass As String,
					   ByVal strIntAge As Integer, ByVal boolTmpIsFirstBaby As Boolean,
					   ByVal intTmpGesAge As Integer)
			strName = strTempName
			strAddress = strTempAddress
			strEmail = strTempEmail
			strPass = strTempPass
			intAge = strIntAge
			strIsFirstBaby = boolTmpIsFirstBaby
			intGestationalAge = intTmpGesAge
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

			If strTmpIsFirstBaby = "y" Then
				strIsFirstBaby = "yes"
			ElseIf strTmpIsFirstBaby = "n" Then
				strIsFirstBaby = "no"
			End If
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
	End Class
	Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
		frmStart.Show()
		Me.Hide()

	End Sub

	Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
		' Check if any TextBox is empty
		If txtName.Text = "" Then
			MsgBox("Please enter your name")
			Return
		End If

		If txtAddress.Text = "" Then
			MsgBox("Please enter your address")
			Return
		End If

		If txtEmail.Text = "" Then
			MsgBox("Please enter your email")
			Return
		End If

		If txtPassword.Text = "" Then
			MsgBox("Please enter your password")
			Return
		End If

		If txtAge.Text = "" Then
			MsgBox("Please enter your age")
			Return
		End If

		If txtFirstBaby.Text = "" Then
			MsgBox("Please enter details about your first baby")
			Return
		End If

		If txtGasAge.Text = "" Then
			MsgBox("Please enter the age of your gestational age")
			Return ' Exit the method if any TextBox is empty
		End If

		' Create a new user instance
		Dim newUser As New User()
		newUser.SetUserCredentials(txtName.Text, txtAddress.Text, txtEmail.Text, txtPassword.Text, txtAge.Text, txtFirstBaby.Text, txtGasAge.Text)
		listUsers.Add(newUser)

		' Clear all TextBoxes
		txtName.Clear()
		txtAddress.Clear()
		txtEmail.Clear()
		txtPassword.Clear()
		txtAge.Clear()
		txtFirstBaby.Clear()
		txtGasAge.Clear()

		' Hide the current form and show the login form
		Me.Hide()
		frmLogIn.Show()
	End Sub

	Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
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


End Class