<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MượnTrảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HệThốngToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1115, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 48)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1115, 505)
        Me.PanelMain.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.HệThốngToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1115, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchToolStripMenuItem, Me.ĐộcGiảToolStripMenuItem, Me.MượnTrảToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HệThốngToolStripMenuItem.Text = "Quản lý"
        '
        'SáchToolStripMenuItem
        '
        Me.SáchToolStripMenuItem.Name = "SáchToolStripMenuItem"
        Me.SáchToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SáchToolStripMenuItem.Text = "quản lý sách"
        '
        'ĐộcGiảToolStripMenuItem
        '
        Me.ĐộcGiảToolStripMenuItem.Name = "ĐộcGiảToolStripMenuItem"
        Me.ĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ĐộcGiảToolStripMenuItem.Text = "quản lý độc giả"
        '
        'MượnTrảToolStripMenuItem
        '
        Me.MượnTrảToolStripMenuItem.Name = "MượnTrảToolStripMenuItem"
        Me.MượnTrảToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MượnTrảToolStripMenuItem.Text = "quản lý mượn trả"
        '
        'HệThốngToolStripMenuItem1
        '
        Me.HệThốngToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BáoCáoToolStripMenuItem})
        Me.HệThốngToolStripMenuItem1.Name = "HệThốngToolStripMenuItem1"
        Me.HệThốngToolStripMenuItem1.Size = New System.Drawing.Size(69, 20)
        Me.HệThốngToolStripMenuItem1.Text = "Hệ thống"
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        Me.BáoCáoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BáoCáoToolStripMenuItem.Text = "Báo cáo"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 553)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Form2"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PanelMain As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MượnTrảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HệThốngToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As ToolStripMenuItem
End Class
