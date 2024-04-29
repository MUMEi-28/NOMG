Public Class frmAccountInformation

	Public listUsers As New List(Of User)
	Public strCurrentUser As User

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Dim user1 As New User()
		Dim user2 As New User()
		Dim user3 As New User()


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
		Private boolIsFirstBaby As Boolean
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
			boolIsFirstBaby = boolTmpIsFirstBaby
			intGestationalAge = intTmpGesAge
		End Sub

		Public Sub SetUserCredentials(ByVal strTempName As String, ByVal strTempAddress As String,
					   ByVal strTempEmail As String, ByVal strTempPass As String,
					   ByVal strIntAge As Integer, ByVal boolTmpIsFirstBaby As Boolean,
					   ByVal intTmpGesAge As Integer)
			strName = strTempName
			strAddress = strTempAddress
			strEmail = strTempEmail
			strPass = strTempPass
			intAge = strIntAge
			boolIsFirstBaby = boolTmpIsFirstBaby
			intGestationalAge = intTmpGesAge
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
		Public Function GetIsFirstBaby() As Boolean
			Return boolIsFirstBaby
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


		Dim intCounter = 0
		Do While intCounter < listUsers.Count
			If txtEmail.Text = listUsers(intCounter).GetEmail() And txtPassword.Text = listUsers(intCounter).GetPass() Then
				MsgBox("log in succesful")

				'		Form2.Show()
				Me.Hide()
				strCurrentUser = listUsers(intCounter)
			End If
			intCounter += 1
		Loop

		'	TxtUserName.Clear()
		txtPassword.Clear()

		'	Form1.Show()
		Me.Hide()
	End Sub


End Class