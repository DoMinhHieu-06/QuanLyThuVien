Public Class frmMain

    ' Hàm dùng để load UserControl
    Public Sub LoadUserControl(ctrl As UserControl)
        PanelMain.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        PanelMain.Controls.Add(ctrl)
    End Sub

    ' Sự kiện click menu "Sách"
    Private Sub SáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchToolStripMenuItem.Click
        LoadUserControl(New ucSach())
    End Sub
    Private Sub ĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐộcGiảToolStripMenuItem.Click
        LoadUserControl(New ucDocgia())
    End Sub
    Private Sub MượnTrảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MượnTrảToolStripMenuItem.Click
        LoadUserControl(New ucMuontra())
    End Sub
    Private Sub BáoCáoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoToolStripMenuItem.Click
        LoadUserControl(New ucBaoCao())
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub
End Class