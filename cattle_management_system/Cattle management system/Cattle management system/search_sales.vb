Imports System.Data.OleDb
Public Class search_sales

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Dim sql As String
        If TextBox1.Text = "" Then
            MsgBox("kindly enter required details")
            TextBox1.Focus()
            Exit Sub
        End If
        If RadioButton2.Checked = False Then
            Dim id As String = Trim(TextBox1.Text)
            sql = "select * from sales where sales_id='" & id & "' "
        Else
            Dim type As String = Trim(TextBox1.Text)
            If type = "milk" Then
                sql = "select * from sales where type='m'"
            ElseIf type = "cattle" Then
                sql = "select * from sales where type='c'"
            Else
                MsgBox("enter valid details")
            End If
        End If
        Try
            adapt = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If Me.WindowState <> FormWindowState.Minimized Then
    '        Me.DataGridView1.Size = New Size(Me.ClientRectangle.Width - 100, Me.ClientRectangle.Height - 100)
    '    End If
    'End Sub
    Private Sub search_sales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class