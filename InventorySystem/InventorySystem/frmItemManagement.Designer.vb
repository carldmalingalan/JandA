<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemManagement))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FormSkin1 = New InventorySystem.FormSkin()
        Me.btnProceed = New InventorySystem.FlatButton()
        Me.btnBrowse = New InventorySystem.FlatButton()
        Me.pbItemPicture = New System.Windows.Forms.PictureBox()
        Me.cboItemClassification = New InventorySystem.FlatComboBox()
        Me.txtItemDescription = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtItemQuantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtItemName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnProceed)
        Me.FormSkin1.Controls.Add(Me.btnBrowse)
        Me.FormSkin1.Controls.Add(Me.pbItemPicture)
        Me.FormSkin1.Controls.Add(Me.cboItemClassification)
        Me.FormSkin1.Controls.Add(Me.txtItemDescription)
        Me.FormSkin1.Controls.Add(Me.txtItemQuantity)
        Me.FormSkin1.Controls.Add(Me.txtItemName)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(647, 447)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "J and A"
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Transparent
        Me.btnProceed.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProceed.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnProceed.Location = New System.Drawing.Point(176, 345)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Rounded = False
        Me.btnProceed.Size = New System.Drawing.Size(291, 33)
        Me.btnProceed.TabIndex = 45
        Me.btnProceed.Text = "PROCEED"
        Me.btnProceed.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBrowse.Location = New System.Drawing.Point(495, 261)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Rounded = False
        Me.btnBrowse.Size = New System.Drawing.Size(106, 32)
        Me.btnBrowse.TabIndex = 44
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnBrowse.Visible = False
        '
        'pbItemPicture
        '
        Me.pbItemPicture.Location = New System.Drawing.Point(457, 67)
        Me.pbItemPicture.Name = "pbItemPicture"
        Me.pbItemPicture.Size = New System.Drawing.Size(178, 188)
        Me.pbItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbItemPicture.TabIndex = 43
        Me.pbItemPicture.TabStop = False
        Me.pbItemPicture.Visible = False
        '
        'cboItemClassification
        '
        Me.cboItemClassification.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cboItemClassification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboItemClassification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboItemClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemClassification.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cboItemClassification.ForeColor = System.Drawing.Color.White
        Me.cboItemClassification.FormattingEnabled = True
        Me.cboItemClassification.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboItemClassification.ItemHeight = 18
        Me.cboItemClassification.Items.AddRange(New Object() {"HAIR", "MASSAGE", "NAILS"})
        Me.cboItemClassification.Location = New System.Drawing.Point(13, 231)
        Me.cboItemClassification.Name = "cboItemClassification"
        Me.cboItemClassification.Size = New System.Drawing.Size(420, 24)
        Me.cboItemClassification.TabIndex = 44
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtItemDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemDescription.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtItemDescription.ForeColor = System.Drawing.Color.White
        Me.txtItemDescription.HintForeColor = System.Drawing.Color.Silver
        Me.txtItemDescription.HintText = "Item Description"
        Me.txtItemDescription.isPassword = False
        Me.txtItemDescription.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItemDescription.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtItemDescription.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItemDescription.LineThickness = 3
        Me.txtItemDescription.Location = New System.Drawing.Point(13, 179)
        Me.txtItemDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(420, 31)
        Me.txtItemDescription.TabIndex = 43
        Me.txtItemDescription.TabStop = False
        Me.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtItemQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemQuantity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtItemQuantity.ForeColor = System.Drawing.Color.White
        Me.txtItemQuantity.HintForeColor = System.Drawing.Color.Silver
        Me.txtItemQuantity.HintText = "Item Quantity"
        Me.txtItemQuantity.isPassword = False
        Me.txtItemQuantity.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItemQuantity.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtItemQuantity.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItemQuantity.LineThickness = 3
        Me.txtItemQuantity.Location = New System.Drawing.Point(13, 140)
        Me.txtItemQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.Size = New System.Drawing.Size(420, 31)
        Me.txtItemQuantity.TabIndex = 42
        Me.txtItemQuantity.TabStop = False
        Me.txtItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtItemName.ForeColor = System.Drawing.Color.White
        Me.txtItemName.HintForeColor = System.Drawing.Color.Silver
        Me.txtItemName.HintText = "Item Name"
        Me.txtItemName.isPassword = False
        Me.txtItemName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItemName.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtItemName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItemName.LineThickness = 3
        Me.txtItemName.Location = New System.Drawing.Point(13, 101)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(420, 31)
        Me.txtItemName.TabIndex = 41
        Me.txtItemName.TabStop = False
        Me.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmItemManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 447)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmItemManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "J and A"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents txtItemDescription As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtItemQuantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtItemName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cboItemClassification As FlatComboBox
    Friend WithEvents btnProceed As FlatButton
    Friend WithEvents btnBrowse As FlatButton
    Friend WithEvents pbItemPicture As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
