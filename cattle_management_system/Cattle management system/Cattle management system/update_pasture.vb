Imports System.Data.OleDb
Public Class update_pasture

    Private Sub update_pasture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapt As OleDbDataAdapter
        Dim adaptt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt1 As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from pasture", con)
            adaptt = New OleDbDataAdapter("select id from pasture ", con)
            dt = New DataTable
            dt1 = New DataTable
            adapt.Fill(dt)
            adaptt.Fill(dt1)
            DataGridView1.DataSource = dt
            ComboBox2.DataSource = dt1
            ComboBox2.DisplayMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False

    End Sub
    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If Me.WindowState <> FormWindowState.Minimized Then
    '        Me.DataGridView1.Size = New Size(Me.ClientRectangle.Width - 100, Me.ClientRectangle.Height - 100)
    '    End If
    'End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            TextBox1.Enabled = True

        ElseIf CheckBox1.Checked = False Then

            TextBox1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then

            TextBox2.Enabled = True

        ElseIf CheckBox2.Checked = False Then

            TextBox2.Enabled = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then

            TextBox3.Enabled = True

        ElseIf CheckBox3.Checked = False Then

            TextBox3.Enabled = False
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then

            TextBox4.Enabled = True

        ElseIf CheckBox4.Checked = False Then

            TextBox4.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim id As String
        Dim location As String
        Dim area As Decimal
        Dim sid As String = Trim(ComboBox2.Text)
        Dim strQ As String = "SELECT name,id,location,area FROM pasture WHERE id = '" & sid & "'"
        Dim cmdQ As OleDbCommand = New OleDbCommand(strQ, con)
        Dim QReader As OleDbDataReader
        QReader = cmdQ.ExecuteReader
        If QReader.HasRows Then
            While QReader.Read
                name = QReader.Item("name")
                id = QReader.Item("id")
                location = QReader.Item("location")
                area = QReader.Item("area")
            End While
        End If
        If CheckBox1.Checked Then
            name = Trim(TextBox1.Text)
            If TextBox1.Text = "" Then
                MsgBox("kindly enter the cattle name")
                TextBox1.Focus()
                Exit Sub
            End If
        End If

        If CheckBox2.Checked Then
            id = Trim(TextBox2.Text)
            If TextBox2.Text = "" Then
                MsgBox("kindly enter the pasture name")
                TextBox2.Focus()
                Exit Sub
            End If
        End If
        If CheckBox4.Checked Then
            area = Trim(TextBox4.Text)
            If TextBox4.Text = "" Then
                MsgBox("kindly enter the pasture area")
                TextBox4.Focus()
                Exit Sub
            End If
        End If

        If CheckBox3.Checked Then
            location = Trim(TextBox3.Text)
            If TextBox3.Text = "" Then
                MsgBox("kindly enter the pasture location")
                TextBox3.Focus()
                Exit Sub
            End If
        End If
     
        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "update pasture set name = '" & name & "',id='" & id & "',location='" & location & "',area=" & area & " where id ='" & sid & "'"
            com.ExecuteNonQuery()
            MsgBox("DATA UPDATED SUCCESSFULLY")

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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class