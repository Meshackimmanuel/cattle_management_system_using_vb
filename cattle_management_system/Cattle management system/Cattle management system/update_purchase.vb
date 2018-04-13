Imports System.Data.OleDb
Public Class update_purchase

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim amount As String
        Dim sno As Integer
        Dim sname As String
        Dim dat As String
        Dim dob As Date
        Dim pid As Integer
        Dim type As String
        Dim sid As String = Trim(ComboBox2.Text)
        Dim strQ As String = "SELECT purchase_id,amount,date,seller_name,seller_no,type FROM purchase WHERE purchase_id = '" & sid & "'"
        Dim cmdQ As OleDbCommand = New OleDbCommand(strQ, con)
        Dim QReader As OleDbDataReader
        QReader = cmdQ.ExecuteReader
        If QReader.HasRows Then
            While QReader.Read
                pid = QReader.Item("purchase_id")
                amount = QReader.Item("amount")
                dob = QReader.Item("date")
                dat = dob.ToString("dd MMM, yyyy")
                sname = QReader.Item("seller_name")
                sno = QReader.Item("seller_no")
                type = QReader.Item("type")
            End While
        End If
        If CheckBox1.Checked Then
            If RadioButton1.Checked Then
                type = "C"
            Else
                type = "P"
            End If
        End If

        If CheckBox2.Checked Then
            pid = Trim(TextBox2.Text)
            If TextBox1.Text = "" Then
                MsgBox("kindly enter the purchase id")
                TextBox1.Focus()
                Exit Sub
            End If
        End If


        If CheckBox3.Checked Then
            dat = DateTimePicker1.Text
        End If

        If CheckBox4.Checked Then
            amount = Trim(TextBox2.Text)
            If TextBox2.Text = "" Then
                MsgBox("kindly enter the purchase amount")
                TextBox2.Focus()
                Exit Sub
            End If
        End If

        If CheckBox5.Checked Then
            sname = Trim(TextBox3.Text)
            If TextBox3.Text = "" Then
                MsgBox("kindly enter the seller name")
                TextBox3.Focus()
                Exit Sub
            End If
        End If
        If CheckBox6.Checked Then
            sno = Trim(TextBox4.Text)
            If TextBox4.Text = "" Then
                MsgBox("kindly enter the seller number")
                TextBox4.Focus()
                Exit Sub
            End If
        End If
        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "update purchase set purchase_id = '" & pid & "',date =convert(datetime2,'" + dat + "',20),seller_name='" & sname & "',amount=" & amount & ",seller_no=" & sno & ",type='" & type & "' where purchase_id ='" & sid & "'"
            com.ExecuteNonQuery()
            MsgBox("DATA UPDATED SUCCESSFULLY")

            'repeated====
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable
            Try
                adapt = New OleDbDataAdapter("select * from purchase", con)
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
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            RadioButton1.Enabled = True
            RadioButton2.Enabled = True

        ElseIf CheckBox1.Checked = False Then

            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
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
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = True Then

            TextBox3.Enabled = True

        ElseIf CheckBox5.Checked = False Then

            TextBox3.Enabled = False
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.Checked = True Then

            TextBox4.Enabled = True

        ElseIf CheckBox6.Checked = False Then

            TextBox4.Enabled = False
        End If
    End Sub
    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If Me.WindowState <> FormWindowState.Minimized Then
    '        Me.DataGridView1.Size = New Size(Me.ClientRectangle.Width - 100, Me.ClientRectangle.Height - 100)
    '    End If
    'End Sub
    Private Sub update_purchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapt As OleDbDataAdapter
        Dim adaptt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt1 As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from purchase", con)
            adaptt = New OleDbDataAdapter("select purchase_id from purchase ", con)
            dt = New DataTable
            dt1 = New DataTable
            adapt.Fill(dt)
            adaptt.Fill(dt1)
            DataGridView1.DataSource = dt
            ComboBox2.DataSource = dt1
            ComboBox2.DisplayMember = "purchase_id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        DateTimePicker1.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class