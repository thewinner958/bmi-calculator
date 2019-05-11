Public Class frmBMI
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblBMI.Text = Val(txtWeight.Text) / (Val(txtHeight.Text) ^ 2)
        If lblBMI.Text < 19 Then
            MsgBox("Your body mass is below the norm", 0, "Dr.House says...")
        End If
        If lblBMI.Text >= 30 Then
            MsgBox("You have reached obesity", 0, "Dr.House says...")
        End If
        If lblBMI.Text >= 19 And lblBMI.Text < 25 Then
            MsgBox("Your bio mass is perfect", 0, "Dr.House says...")
        End If
        If lblBMI.Text >= 25 And lblBMI.Text < 30 Then
            MsgBox("Your bio mass is over the norm", 0, "Dr.House says...")
        End If
    End Sub
End Class