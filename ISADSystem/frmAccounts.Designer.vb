<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccounts))
        Me.dgvAccountList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnActivate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCreate = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.dgvAccountList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccountList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvAccountList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccountList.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvAccountList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAccountList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccountList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccountList.DoubleBuffered = True
        Me.dgvAccountList.EnableHeadersVisualStyles = False
        Me.dgvAccountList.HeaderBgColor = System.Drawing.Color.Violet
        Me.dgvAccountList.HeaderForeColor = System.Drawing.Color.SeaShell
        Me.dgvAccountList.Location = New System.Drawing.Point(12, 12)
        Me.dgvAccountList.Name = "dgvAccountList"
        Me.dgvAccountList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAccountList.Size = New System.Drawing.Size(760, 349)
        Me.dgvAccountList.TabIndex = 0
        '
        'btnActivate
        '
        Me.btnActivate.ActiveBorderThickness = 1
        Me.btnActivate.ActiveCornerRadius = 20
        Me.btnActivate.ActiveFillColor = System.Drawing.Color.Orchid
        Me.btnActivate.ActiveForecolor = System.Drawing.Color.White
        Me.btnActivate.ActiveLineColor = System.Drawing.Color.Orchid
        Me.btnActivate.BackColor = System.Drawing.SystemColors.Control
        Me.btnActivate.BackgroundImage = CType(resources.GetObject("btnActivate.BackgroundImage"), System.Drawing.Image)
        Me.btnActivate.ButtonText = "Enable"
        Me.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActivate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnActivate.IdleBorderThickness = 1
        Me.btnActivate.IdleCornerRadius = 20
        Me.btnActivate.IdleFillColor = System.Drawing.Color.White
        Me.btnActivate.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnActivate.IdleLineColor = System.Drawing.Color.Orchid
        Me.btnActivate.Location = New System.Drawing.Point(14, 441)
        Me.btnActivate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(95, 41)
        Me.btnActivate.TabIndex = 1
        Me.btnActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.ActiveBorderThickness = 1
        Me.btnEdit.ActiveCornerRadius = 20
        Me.btnEdit.ActiveFillColor = System.Drawing.Color.Orchid
        Me.btnEdit.ActiveForecolor = System.Drawing.Color.White
        Me.btnEdit.ActiveLineColor = System.Drawing.Color.Orchid
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.ButtonText = "Edit"
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.IdleBorderThickness = 1
        Me.btnEdit.IdleCornerRadius = 20
        Me.btnEdit.IdleFillColor = System.Drawing.Color.White
        Me.btnEdit.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnEdit.IdleLineColor = System.Drawing.Color.Orchid
        Me.btnEdit.Location = New System.Drawing.Point(14, 405)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 41)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreate
        '
        Me.btnCreate.ActiveBorderThickness = 1
        Me.btnCreate.ActiveCornerRadius = 20
        Me.btnCreate.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnCreate.ActiveForecolor = System.Drawing.Color.White
        Me.btnCreate.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnCreate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreate.BackgroundImage = CType(resources.GetObject("btnCreate.BackgroundImage"), System.Drawing.Image)
        Me.btnCreate.ButtonText = "Create"
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCreate.IdleBorderThickness = 1
        Me.btnCreate.IdleCornerRadius = 20
        Me.btnCreate.IdleFillColor = System.Drawing.Color.White
        Me.btnCreate.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnCreate.IdleLineColor = System.Drawing.Color.Orchid
        Me.btnCreate.Location = New System.Drawing.Point(14, 369)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(95, 41)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 537)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dgvAccountList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAccounts"
        Me.Text = "frmAccounts"
        CType(Me.dgvAccountList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAccountList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnCreate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnActivate As Bunifu.Framework.UI.BunifuThinButton2
End Class
