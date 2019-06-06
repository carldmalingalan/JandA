<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.FormSkin1 = New InventorySystem.FormSkin()
        Me.btnUtilities = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnInventory = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnRecords = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnAccounts = New Bunifu.Framework.UI.BunifuTileButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnUtilities)
        Me.FormSkin1.Controls.Add(Me.btnInventory)
        Me.FormSkin1.Controls.Add(Me.btnRecords)
        Me.FormSkin1.Controls.Add(Me.btnAccounts)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(618, 296)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "J and A"
        '
        'btnUtilities
        '
        Me.btnUtilities.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnUtilities.color = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnUtilities.colorActive = System.Drawing.Color.Violet
        Me.btnUtilities.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUtilities.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnUtilities.ForeColor = System.Drawing.Color.White
        Me.btnUtilities.Image = CType(resources.GetObject("btnUtilities.Image"), System.Drawing.Image)
        Me.btnUtilities.ImagePosition = 20
        Me.btnUtilities.ImageZoom = 50
        Me.btnUtilities.LabelPosition = 41
        Me.btnUtilities.LabelText = "Utilities"
        Me.btnUtilities.Location = New System.Drawing.Point(454, 104)
        Me.btnUtilities.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUtilities.Name = "btnUtilities"
        Me.btnUtilities.Size = New System.Drawing.Size(128, 129)
        Me.btnUtilities.TabIndex = 0
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.SeaGreen
        Me.btnInventory.color = System.Drawing.Color.SeaGreen
        Me.btnInventory.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImagePosition = 20
        Me.btnInventory.ImageZoom = 50
        Me.btnInventory.LabelPosition = 41
        Me.btnInventory.LabelText = "Inventory"
        Me.btnInventory.Location = New System.Drawing.Point(174, 104)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(6)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(128, 129)
        Me.btnInventory.TabIndex = 0
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.Goldenrod
        Me.btnRecords.color = System.Drawing.Color.Goldenrod
        Me.btnRecords.colorActive = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnRecords.ForeColor = System.Drawing.Color.White
        Me.btnRecords.Image = CType(resources.GetObject("btnRecords.Image"), System.Drawing.Image)
        Me.btnRecords.ImagePosition = 20
        Me.btnRecords.ImageZoom = 50
        Me.btnRecords.LabelPosition = 41
        Me.btnRecords.LabelText = "Records"
        Me.btnRecords.Location = New System.Drawing.Point(314, 104)
        Me.btnRecords.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(128, 129)
        Me.btnRecords.TabIndex = 0
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnAccounts.color = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnAccounts.colorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccounts.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnAccounts.ForeColor = System.Drawing.Color.White
        Me.btnAccounts.Image = CType(resources.GetObject("btnAccounts.Image"), System.Drawing.Image)
        Me.btnAccounts.ImagePosition = 20
        Me.btnAccounts.ImageZoom = 50
        Me.btnAccounts.LabelPosition = 41
        Me.btnAccounts.LabelText = "Accounts"
        Me.btnAccounts.Location = New System.Drawing.Point(34, 104)
        Me.btnAccounts.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(128, 129)
        Me.btnAccounts.TabIndex = 0
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 296)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "J and A"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents btnUtilities As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnInventory As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnRecords As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnAccounts As Bunifu.Framework.UI.BunifuTileButton
End Class
