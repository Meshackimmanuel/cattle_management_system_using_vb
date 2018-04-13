Public Class report_milking

    Private Sub report_milking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Refresh()
        Dim rep As New CrystalReport_milking
        CrystalReportViewer1.ReportSource = rep
        CrystalReportViewer1.Refresh()
    End Sub
End Class