<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnCreateStocks = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDeductStocks = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAddInventoryStocks = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(12, 12)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(760, 349)
        Me.BunifuCustomDataGrid1.TabIndex = 0
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(227, 367)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(303, 36)
        Me.BunifuDatepicker1.TabIndex = 5
        Me.BunifuDatepicker1.Value = New Date(2019, 4, 4, 8, 44, 50, 885)
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.btnCreateStocks)
        Me.BunifuCards1.Controls.Add(Me.btnDeductStocks)
        Me.BunifuCards1.Controls.Add(Me.btnAddInventoryStocks)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(11, 367)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(106, 134)
        Me.BunifuCards1.TabIndex = 6
        '
        'btnCreateStocks
        '
        Me.btnCreateStocks.ActiveBorderThickness = 1
        Me.btnCreateStocks.ActiveCornerRadius = 20
        Me.btnCreateStocks.ActiveFillColor = System.Drawing.Color.Orchid
        Me.btnCreateStocks.ActiveForecolor = System.Drawing.Color.White
        Me.btnCreateStocks.ActiveLineColor = System.Drawing.Color.Orchid
        Me.btnCreateStocks.BackColor = System.Drawing.Color.White
        Me.btnCreateStocks.BackgroundImage = CType(resources.GetObject("btnCreateStocks.BackgroundImage"), System.Drawing.Image)
        Me.btnCreateStocks.ButtonText = "Create"
        Me.btnCreateStocks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateStocks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateStocks.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCreateStocks.IdleBorderThickness = 1
        Me.btnCreateStocks.IdleCornerRadius = 20
        Me.btnCreateStocks.IdleFillColor = System.Drawing.Color.White
        Me.btnCreateStocks.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnCreateStocks.IdleLineColor = System.Drawing.Color.Orchid
        Me.btnCreateStocks.Location = New System.Drawing.Point(3, 88)
        Me.btnCreateStocks.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCreateStocks.Name = "btnCreateStocks"
        Me.btnCreateStocks.Size = New System.Drawing.Size(95, 41)
        Me.btnCreateStocks.TabIndex = 5
        Me.btnCreateStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeductStocks
        '
        Me.btnDeductStocks.ActiveBorderThickness = 1
        Me.btnDeductStocks.ActiveCornerRadius = 20
        Me.btnDeductStocks.ActiveFillColor = System.Drawing.Color.Orchid
        Me.btnDeductStocks.ActiveForecolor = System.Drawing.Color.White
        Me.btnDeductStocks.ActiveLineColor = System.Drawing.Color.Orchid
        Me.btnDeductStocks.BackColor = System.Drawing.Color.White
        Me.btnDeductStocks.BackgroundImage = CType(resources.GetObject("btnDeductStocks.BackgroundImage"), System.Drawing.Image)
        Me.btnDeductStocks.ButtonText = "Deduct"
        Me.btnDeductStocks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeductStocks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeductStocks.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDeductStocks.IdleBorderThickness = 1
        Me.btnDeductStocks.IdleCornerRadius = 20
        Me.btnDeductStocks.IdleFillColor = System.Drawing.Color.White
        Me.btnDeductStocks.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnDeductStocks.IdleLineColor = System.Drawing.Color.Orchid
        Me.btnDeductStocks.Location = New System.Drawing.Point(3, 51)
        Me.btnDeductStocks.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDeductStocks.Name = "btnDeductStocks"
        Me.btnDeductStocks.Size = New System.Drawing.Size(95, 41)
        Me.btnDeductStocks.TabIndex = 6
        Me.btnDeductStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddInventoryStocks
        '
        Me.btnAddInventoryStocks.ActiveBorderThickness = 1
        Me.btnAddInventoryStocks.ActiveCornerRadius = 20
        Me.btnAddInventoryStocks.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAddInventoryStocks.ActiveForecolor = System.Drawing.Color.White
        Me.btnAddInventoryStocks.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAddInventoryStocks.BackColor = System.Drawing.Color.White
        Me.btnAddInventoryStocks.BackgroundImage = CType(resources.GetObject("btnAddInventoryStocks.BackgroundImage"), System.Drawing.Image)
        Me.btnAddInventoryStocks.ButtonText = "Add"
        Me.btnAddInventoryStocks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddInventoryStocks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddInventoryStocks.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAddInventoryStocks.IdleBorderThickness = 1
        Me.btnAddInventoryStocks.IdleCornerRadius = 20
        Me.btnAddInventoryStocks.IdleFillColor = System.Drawing.Color.White
        Me.btnAddInventoryStocks.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnAddInventoryStocks.IdleLineColor = System.Drawing.Color.Orchid
        Me.btnAddInventoryStocks.Location = New System.Drawing.Point(5, 14)
        Me.btnAddInventoryStocks.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddInventoryStocks.Name = "btnAddInventoryStocks"
        Me.btnAddInventoryStocks.Size = New System.Drawing.Size(95, 41)
        Me.btnAddInventoryStocks.TabIndex = 7
        Me.btnAddInventoryStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 537)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnCreateStocks As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDeductStocks As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnAddInventoryStocks As Bunifu.Framework.UI.BunifuThinButton2
End Class
