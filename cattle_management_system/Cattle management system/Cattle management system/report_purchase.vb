Public Class report_purchase

    Private Sub report_purchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Refresh()
        Dim rep As New CrystalReport_purchase
        CrystalReportViewer1.ReportSource = rep
        CrystalReportViewer1.Refresh()
    End Sub
End Class