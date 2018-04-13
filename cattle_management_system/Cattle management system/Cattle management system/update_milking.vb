Imports System.Data.OleDb
Imports System.Globalization

Public Class update_milking

    Private Sub update_milking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapt As OleDbDataAdapter
        Dim adaptt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt1 As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from milking", con)
            adaptt = New OleDbDataAdapter("select cattle_id from milking ", con)
            dt = New DataTable
            dt1 = New DataTable
            adapt.Fill(dt)
            adaptt.Fill(dt1)
            DataGridView1.DataSource = dt
            ComboBox1.DataSource = dt1
            ComboBox1.DisplayMember = "cattle_id"
            ComboBox2.DataSource = dt1
            ComboBox2.DisplayMember = "cattle_id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox1.Enabled = False
    End Sub
    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If Me.WindowState <> FormWindowState.Minimized Then
    '        Me.DataGridView1.Size = New Size(Me.ClientRectangle.Width - 100, Me.ClientRectangle.Height - 100)
    '    End If
    'End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            ComboBox1.Enabled = True

        ElseIf CheckBox1.Checked = False Then

            ComboBox1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then

            TextBox1.Enabled = True

        ElseIf CheckBox2.Checked = False Then

            TextBox1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then

            DateTimePicker1.Enabled = True

        ElseIf CheckBox3.Checked = False Then
            DateTimePicker1.Enabled = False

        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then

            TextBox2.Enabled = True

        ElseIf CheckBox4.Checked = False Then

            TextBox2.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cid As String
        Dim mid As String
        Dim dat As String
        Dim dob As Date
        Dim quantity As Decimal
        Dim sid As String = Trim(ComboBox2.Text)
        Dim strQ As String = "SELECT cattle_id,milking_id,date,quantity FROM milking WHERE cattle_id = '" & sid & "'"
        Dim cmdQ As OleDbCommand = New OleDbCommand(strQ, con)
        Dim QReader As OleDbDataReader
        QReader = cmdQ.ExecuteReader
        If QReader.HasRows Then
            While QReader.Read
                cid = QReader.Item("cattle_id")
                mid = QReader.Item("milking_id")
                dob = QReader.Item("date")
                dat = dob.ToString("dd MMM, yyyy")
                quantity = QReader.Item("quantity")
            End While
        End If
        If CheckBox1.Checked Then
            cid = Trim(ComboBox1.Text)
        End If

        If CheckBox2.Checked Then
            mid = Trim(TextBox1.Text)
            If TextBox1.Text = "" Then
                MsgBox("kindly enter the milk id")
                TextBox1.Focus()
                Exit Sub
            End If
        End If


        If CheckBox3.Checked Then
            dat = DateTimePicker1.Text
        End If

        If CheckBox4.Checked Then
            quantity = Val(TextBox2.Text)
            If TextBox2.Text = "" Then
                MsgBox("kindly enter the milk quantity")
                TextBox2.Focus()
                Exit Sub
            End If
        End If

        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "update milking set cattle_id = '" & cid & "',milking_id='" & mid & "',date=convert(datetime2,'" + dat + "',20),quantity=" & quantity & " where cattle_id ='" & sid & "'"
            com.ExecuteNonQuery()
            MsgBox("DATA UPDATED SUCCESSFULLY")

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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class