Imports System.Data.OleDb
Public Class insert_milking

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dat As Date = DateTimePicker1.Value.Date
        Dim cid As String = Trim(ComboBox1.Text)
        Dim mid As String = Trim(TextBox1.Text)
        Dim quantity As String = Val(TextBox2.Text)


        If TextBox1.Text = "" Then
            MsgBox("kindly enter the milk id")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MsgBox("kindly enter the milk quantity")
            TextBox2.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("kindly enter the cattle id")
            ComboBox1.Focus()
            Exit Sub
        End If
        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "insert into milking values('" & _
                                     mid & "',convert(datetime2,'" + DateTimePicker1.Text + "',20),'" & cid & "'," & quantity & ")"
            com.ExecuteNonQuery()
            MsgBox("DATA INSERTED SUCCESSFULLY")

            'repeated====
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable
            Try
                adapt = New OleDbDataAdapter("select * from milking", con)
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
    Private Sub insert_milking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapt As OleDbDataAdapter
        Dim adaptt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt1 As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from milking", con)
            adaptt = New OleDbDataAdapter("select id from cattle where c_type = 'cow'", con)
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