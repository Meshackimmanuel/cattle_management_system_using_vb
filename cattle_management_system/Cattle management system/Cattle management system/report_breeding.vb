Public Class report_breeding

    Private Sub report_breeding_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Refresh()
        Dim rep As New CrystalReport_breeding
        CrystalReportViewer1.ReportSource = rep
        CrystalReportViewer1.Refresh()
    End Sub
End Class