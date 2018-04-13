Public Class welcome

    Private Property AutoRedraw As Boolean

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        main.Show()
    End Sub
 
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        register.Show()
    End Sub
    'Dim waitTime As Integer = 500 'ms
    'Dim speed As Integer = 60 'ms
    'Dim text2 As String = "Free cattle management software."
    'Dim text3 As String = "Manage your animals and plots,"
    'Dim text4 As String = "milk production,sales and"
    'Dim text5 As String = "purchases."
    Private Sub welcome_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
        'animationTimer.Enabled = True
        'animationTimer.Enabled = True
        'animationTimer.Interval = speed
        'waitTimer.Interval = waitTime
        'waitTimer.Enabled = True
        'Label2.Text = ""
        'Label3.Text = ""
        'Label4.Text = ""
        'Label5.Text = ""
    End Sub
    Private Sub waitTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waitTimer.Tick
        'waitTimer.Enabled = False
        'animationTimer.Enabled = True
    End Sub
    Private Sub animationTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animationTimer.Tick
     

        'Label2.Text += text2.Substring(Label2.Text.Length, 1)
        'If Label2.Text = text2 Then animationTimer.Enabled = False
        'animationTimer.Enabled = True
        'Label3.Text += text3.Substring(Label3.Text.Length, 1)
        'If Label3.Text = text3 Then animationTimer.Enabled = False
        'animationTimer.Enabled = True
        'Label4.Text += text4.Substring(Label4.Text.Length, 1)
        'If Label4.Text = text4 Then animationTimer.Enabled = False
        'animationTimer.Enabled = True
        'Label5.Text += text5.Substring(Label5.Text.Length, 1)
        'If Label5.Text = text5 Then animationTimer.Enabled = False
        'MyPictureBox.Location = New Point(MyPictureBox.Location.X, MyPictureBox.Location.Y + 1)
        'If MyPictureBox.Location.Y = 205 Then animationTimer.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        about.Show()
    End Sub
End Class
