Public Class report_pasture

    Private Sub report_pasture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Refresh()
        Dim rep As New CrystalReport_pasture
        CrystalReportViewer1.ReportSource = rep
        CrystalReportViewer1.Refresh()
    End Sub
End Class