Imports System.Data.OleDb
Public Class update_breeding

    Private Sub update_breeding_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Dim adapt As OleDbDataAdapter
        Dim adapttt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt2 As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from breeding", con)
            adapttt = New OleDbDataAdapter("select cattle_id from breeding", con)
            dt = New DataTable
            dt2 = New DataTable
            adapt.Fill(dt)
            adapttt.Fill(dt2)
            DataGridView1.DataSource = dt
            ComboBox2.DataSource = dt2
            ComboBox2.DisplayMember = "cattle_id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DateTimePicker1.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
    End Sub
    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    If Me.WindowState <> FormWindowState.Minimized Then
    '        Me.DataGridView1.Size = New Size(Me.ClientRectangle.Width - 100, Me.ClientRectangle.Height - 100)
    '    End If
    'End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            DateTimePicker1.Enabled = True

        ElseIf CheckBox1.Checked = False Then
            DateTimePicker1.Enabled = False

        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then

            RadioButton1.Enabled = True
            RadioButton2.Enabled = True

        ElseIf CheckBox3.Checked = False Then

            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim method As String
        Dim dat As String
        Dim dob As Date
        Dim sid As String = Trim(ComboBox2.Text)
        Dim strQ As String = "SELECT calving_date,method FROM breeding WHERE cattle_id = '" & sid & "'"
        Dim cmdQ As OleDbCommand = New OleDbCommand(strQ, con)
        Dim QReader As OleDbDataReader
        QReader = cmdQ.ExecuteReader
        If QReader.HasRows Then
            While QReader.Read
                method = QReader.Item("method")
                dob = QReader.Item("calving_date")
                dat = dob.ToString("dd MMM, yyyy")
            End While
        End If
        If CheckBox3.Checked Then
            If RadioButton1.Checked Then
                method = "natural mating"
            ElseIf RadioButton2.Checked Then
                method = "artificial insemination"
            End If
        End If
        If CheckBox1.Checked Then
            dat = DateTimePicker1.Text
        End If


        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "update breeding set method = '" & method & "',calving_date=convert(datetime2,'" + dat + "',20) where cattle_id ='" & sid & "'"
            com.ExecuteNonQuery()
            MsgBox("DATA UPDATED SUCCESSFULLY")

            'repeated====
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable
            Try
                adapt = New OleDbDataAdapter("select * from breeding", con)
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