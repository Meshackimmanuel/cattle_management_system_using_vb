Imports System.Data.OleDb
Public Class insert_sales

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim amount As Decimal = Val(TextBox2.Text)
        Dim sid As String = Trim(TextBox1.Text)
        Dim cname As String = Trim(TextBox3.Text)
        Dim cphone As Integer = Val(TextBox4.Text)
        Dim dat As Date = DateTimePicker1.Value.Date
        Dim id As String = Val(TextBox5.Text)
        Dim type As String


        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("kindly enter valid customer number")
            TextBox4.Focus()
            TextBox4.SelectAll()
            Exit Sub
        End If

        If TextBox1.Text = "" Then
            MsgBox("kindly enter the sales id")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MsgBox("kindly enter the customer name")
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("kindly enter the amount")
            TextBox2.Focus()
            Exit Sub
        End If
        If RadioButton1.Checked Then
            type = "M"
        Else
            type = "C"
        End If

        If RadioButton2.Checked Then
            Dim comm As OleDbCommand
            comm = New OleDbCommand
            Try
                comm.Connection = con
                comm.CommandText = "delete from cattle where id = '" & id & "'"
                comm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If

        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "insert into sales values('" & _
                                     sid & "',convert(datetime2,'" + DateTimePicker1.Text + "',20)," & amount & ",'" & cname & "','" & cphone & "','" & type & "')"
            com.ExecuteNonQuery()
            MsgBox("DATA INSERTED SUCCESSFULLY")

            'repeated====
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable
            Try
                adapt = New OleDbDataAdapter("select * from sales", con)
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
    Private Sub insert_sales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from sales", con)
            dt = New DataTable
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class