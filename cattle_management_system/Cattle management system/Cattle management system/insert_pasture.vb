Imports System.Data.OleDb
Public Class insert_pasture

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim name As String = Trim(TextBox1.Text)
        Dim id As String = Trim(TextBox2.Text)
        Dim location As String = Trim(TextBox3.Text)
        Dim area As Decimal = Val(TextBox4.Text)


        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("kindly enter valid area")
            TextBox4.Focus()
            TextBox4.SelectAll()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MsgBox("kindly enter the pasture id")
            TextBox2.Focus()
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            MsgBox("kindly enter the pasture location")
            TextBox3.Focus()
            Exit Sub
        End If

      

        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "insert into pasture values('" & _
                                     name & "','" & id & "','" & location & "'," & area & ")"
            com.ExecuteNonQuery()
            MsgBox("DATA INSERTED SUCCESSFULLY")

            'repeated====
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable
            Try
                adapt = New OleDbDataAdapter("select * from pasture", con)
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
    Private Sub insert_pasture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from pasture", con)
            dt = New DataTable
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class