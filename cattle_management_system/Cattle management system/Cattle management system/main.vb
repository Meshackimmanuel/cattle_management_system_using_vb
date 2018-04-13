Public Class main

    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "smart" And TextBox2.Text = "smart" Then
            MsgBox(" Welcome to your database")
            Frm_menu.Show()
        Else
            MsgBox(" try again ")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
