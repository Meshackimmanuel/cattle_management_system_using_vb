Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection
    Public Function connect()
        Try
            'con = New OleDbConnection("provider=sqloledb;server=172.16.2.5;database=CMP4NM15CS084;uid=4nm15cs084;pwd=4nm15cs084")
            con = New OleDbConnection("provider=sqloledb;server=MALCOLM\SQLEXPRESS;database=NEWPROJECT;Integrated Security=SSPI")
            con.Open()
            MsgBox("Connected to the Database")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module
