Public Class Frm_menu

    Private Sub DISPLAYToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DISPLAYToolStripMenuItem.Click

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EMPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EMPToolStripMenuItem.Click
        display_cattle.Show()
    End Sub

    Private Sub Frm_menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call connect()
    End Sub

    Private Sub DEPTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DEPTToolStripMenuItem.Click
        display_pasture.Show()
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        display_purchase.Show()
    End Sub

    Private Sub SALESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SALESToolStripMenuItem.Click
        display_sales.Show()
    End Sub

    Private Sub MILKINGToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MILKINGToolStripMenuItem.Click
        display_milking.Show()
    End Sub

    Private Sub BREEDINGToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BREEDINGToolStripMenuItem.Click
        display_breeding.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        insert_cattle.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        insert_pasture.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        insert_purchase.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        insert_sales.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        insert_milking.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem6.Click
        insert_breeding.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        delete_cattle.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem8.Click
        delete_pasture.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem9.Click
        delete_purchase.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem10.Click
        delete_sales.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem11.Click
        delete_milking.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem12.Click
        delete_breeding.Show()
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem19.Click
        search_cattle.Show()
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem20.Click
        search_pasture.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem21.Click
        search_purchase.Show()
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem22.Click
        search_sales.Show()
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem23.Click
        search_milking.Show()
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem24.Click
        search_breeding.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem13.Click
        update_cattle.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem14.Click
        update_pasture.Show()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem15.Click
        update_purchase.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem16.Click
        update_sales.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem17.Click
        update_milking.Show()
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem18.Click
        update_breeding.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CATTLEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CATTLEToolStripMenuItem.Click
        report_cattle.Show()
    End Sub

    Private Sub PASTUREToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PASTUREToolStripMenuItem.Click
        report_pasture.Show()
    End Sub

    Private Sub BREEDINGToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BREEDINGToolStripMenuItem1.Click
        report_breeding.Show()
    End Sub

    Private Sub MILKINGToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MILKINGToolStripMenuItem1.Click
        report_milking.Show()
    End Sub

    Private Sub SALESToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SALESToolStripMenuItem1.Click
        report_sales.Show()
    End Sub

    Private Sub PURCHASEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PURCHASEToolStripMenuItem.Click
        report_purchase.Show()
    End Sub
End Class