﻿Public Class FrmSplashScreen

	Private Sub SplashScreenTImer_Tick(sender As Object, e As EventArgs) Handles SplashScreenTImer.Tick
		panelLoading.Width += 6
		If panelLoading.Width > 860 Then
			SplashScreenTImer.Stop()
			frmStart.Show()
			Me.Hide()
		End If
	End Sub
End Class