Public Class report_cattle

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub


    Private Sub report_cattle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Refresh()
        Dim rep As New CrystalReport_cattle
        CrystalReportViewer1.ReportSource = rep
        CrystalReportViewer1.Refresh()
    End Sub
End Class