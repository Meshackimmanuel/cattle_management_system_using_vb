Imports System.Data.OleDb
Public Class update_cattle

    Private Sub update_cattle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Dim adapt As OleDbDataAdapter
        Dim adaptt As OleDbDataAdapter
        Dim adapttt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from cattle", con)
            adaptt = New OleDbDataAdapter("select id from pasture", con)
            adapttt = New OleDbDataAdapter("select id from cattle", con)
            dt = New DataTable
            dt1 = New DataTable
            dt2 = New DataTable
            adapt.Fill(dt)
            adaptt.Fill(dt1)
            adapttt.Fill(dt2)
            DataGridView1.DataSource = dt
            ComboBox1.DataSource = dt1
            ComboBox1.DisplayMember = "id"
            ComboBox2.DataSource = dt2
            ComboBox2.DisplayMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox2.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        TextBox3.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox1.Enabled = False
    End Sub
    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If Me.WindowState <> FormWindowState.Minimized Then
    '        Me.DataGridView1.Size = New Size(Me.ClientRectangle.Width - 100, Me.ClientRectangle.Height - 100)
    '    End If
    'End Sub


    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then

            TextBox2.Enabled = True

        ElseIf CheckBox2.Checked = False Then

            TextBox2.Enabled = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then

            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True

        ElseIf CheckBox3.Checked = False Then

            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then

            TextBox3.Enabled = True

        ElseIf CheckBox4.Checked = False Then

            TextBox3.Enabled = False
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = True Then

            DateTimePicker1.Enabled = True

        ElseIf CheckBox5.Checked = False Then
            DateTimePicker1.Enabled = False

        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.Checked = True Then

            ComboBox1.Enabled = True

        ElseIf CheckBox6.Checked = False Then

            ComboBox1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim id As String
        Dim age As Integer
        Dim dob As String
        Dim dat As Date
        Dim pid As Integer
        Dim type As String
        Dim sid As String = Trim(ComboBox2.Text)
        Dim strQ As String = "SELECT id,C_type,age,dob,pasture_id FROM cattle WHERE id = '" & sid & "'"
        Dim cmdQ As OleDbCommand = New OleDbCommand(strQ, con)
        Dim QReader As OleDbDataReader
        QReader = cmdQ.ExecuteReader
        If QReader.HasRows Then
            While QReader.Read
                id = QReader.Item("id")
                age = QReader.Item("age")
                dat = QReader.Item("dob")
                dob = dat.ToString("dd MMM, yyyy")
                pid = QReader.Item("pasture_id")
                type = QReader.Item("C_type")
            End While
        End If

        If CheckBox2.Checked Then
            id = Trim(TextBox2.Text)
            If TextBox2.Text = "" Then
                MsgBox("kindly enter the cattle id")
                TextBox2.Focus()
                Exit Sub
            End If
        End If

        If CheckBox3.Checked Then
            If RadioButton1.Checked Then
                type = "cow"
            ElseIf RadioButton2.Checked Then
                type = "bull"
            Else
                type = "calf"
            End If
        End If


        If CheckBox4.Checked Then
            age = Val(TextBox3.Text)
            If TextBox3.Text = "" Then
                MsgBox("kindly enter the cattle age")
                TextBox3.Focus()
                Exit Sub
            End If
            If Not IsNumeric(TextBox3.Text) Then
                MsgBox("kindly enter proper age")
                TextBox3.Focus()
                TextBox3.SelectAll()
                Exit Sub
            End If
        End If

        If CheckBox5.Checked Then
            dob = DateTimePicker1.Text
            MsgBox(dob)
        End If

        If CheckBox6.Checked Then
            pid = Trim(ComboBox1.Text)
        End If

        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "update cattle set age=" & age & ",id='" & id & "',dob = convert(datetime2,'" + dob + "',20),pasture_id=" & pid & ",c_type='" & type & "' where id ='" & sid & "'"
            com.ExecuteNonQuery()
            MsgBox("DATA UPDATED SUCCESSFULLY")

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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub


End Class