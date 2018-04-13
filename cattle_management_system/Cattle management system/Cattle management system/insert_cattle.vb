Imports System.Data.OleDb
Public Class insert_cattle

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim id As String = Trim(TextBox2.Text)
        Dim age As Integer = Val(TextBox3.Text)
        Dim dob As Date = DateTimePicker1.Value.Date
        Dim pid As Integer = Val(ComboBox1.Text)
        Dim type As String
       

        If Not IsNumeric(TextBox3.Text) Then
            MsgBox("kindly enter proper age")
            TextBox3.Focus()
            TextBox3.SelectAll()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MsgBox("kindly enter the cattle id")
            TextBox2.Focus()
            Exit Sub
        End If

        If RadioButton1.Checked Then
            type = "cow"
        ElseIf RadioButton2.Checked Then
            type = "bull"
        Else
            type = "calf"
        End If

        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "insert into cattle values('" & _
                                     id & "','" & type & "'," & age & ",convert(datetime2,'" + DateTimePicker1.Text + "',20)," & pid & ")"
            com.ExecuteNonQuery()
            MsgBox("DATA INSERTED SUCCESSFULLY")

            'repeated====
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable
            Try
                adapt = New OleDbDataAdapter("select * from cattle", con)
                dt = New DataTable
                adapt.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'over----------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If Me.WindowState <> FormWindowState.Minimized Then
    '        Me.DataGridView1.Size = New Size(Me.ClientRectangle.Width - 100, Me.ClientRectangle.Height - 100)
    '    End If
    'End Sub
    Private Sub insert_cattle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Dim adapt As OleDbDataAdapter
        Dim adaptt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt1 As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from cattle", con)
            adaptt = New OleDbDataAdapter("select id from pasture", con)
            dt = New DataTable
            dt1 = New DataTable
            adapt.Fill(dt)
            adaptt.Fill(dt1)
            DataGridView1.DataSource = dt
            ComboBox1.DataSource = dt1
            ComboBox1.DisplayMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class