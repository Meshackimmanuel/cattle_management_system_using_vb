Public Class register

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("kindly enter your first name")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            MsgBox("kindly enter your  email")
            TextBox4.Focus()
            Exit Sub
        End If
        If TextBox5.Text = "" Then
            MsgBox("kindly enter a password")
            TextBox5.Focus()
            Exit Sub
        End If
        MsgBox("THANK YOU for registering with us!!You will mailed with the login details soon")
      
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class