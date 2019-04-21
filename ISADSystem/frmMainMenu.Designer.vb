<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelOpen = New System.Windows.Forms.Panel()
        Me.panelSystem = New System.Windows.Forms.Panel()
        Me.FlatTextBox1 = New ISADSystem.FlatTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlatGroupBox1 = New ISADSystem.FlatGroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelChoice = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.FlatContextMenuStrip2 = New ISADSystem.FlatContextMenuStrip()
        Me.panelSystem.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 635)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 36)
        Me.Panel1.TabIndex = 0
        '
        'panelOpen
        '
        Me.panelOpen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpen.Location = New System.Drawing.Point(232, 65)
        Me.panelOpen.Name = "panelOpen"
        Me.panelOpen.Size = New System.Drawing.Size(802, 570)
        Me.panelOpen.TabIndex = 5
        '
        'panelSystem
        '
        Me.panelSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panelSystem.Controls.Add(Me.FlatTextBox1)
        Me.panelSystem.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSystem.Location = New System.Drawing.Point(0, 0)
        Me.panelSystem.Name = "panelSystem"
        Me.panelSystem.Size = New System.Drawing.Size(1034, 65)
        Me.panelSystem.TabIndex = 3
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatTextBox1.Location = New System.Drawing.Point(31, 19)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(219, 33)
        Me.FlatTextBox1.TabIndex = 0
        Me.FlatTextBox1.Text = "J & A Inventory Management"
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.FlatGroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 570)
        Me.Panel2.TabIndex = 4
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.PictureBox3)
        Me.FlatGroupBox1.Controls.Add(Me.panelChoice)
        Me.FlatGroupBox1.Controls.Add(Me.btnLogout)
        Me.FlatGroupBox1.Controls.Add(Me.btnRecords)
        Me.FlatGroupBox1.Controls.Add(Me.btnInventory)
        Me.FlatGroupBox1.Controls.Add(Me.btnAccounts)
        Me.FlatGroupBox1.Controls.Add(Me.btnHome)
        Me.FlatGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(231, 570)
        Me.FlatGroupBox1.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.ISADSystem.My.Resources.Resources.J_A_LOGO_SALON_1_
        Me.PictureBox3.Location = New System.Drawing.Point(29, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(172, 146)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'panelChoice
        '
        Me.panelChoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelChoice.Location = New System.Drawing.Point(-2, 218)
        Me.panelChoice.Name = "panelChoice"
        Me.panelChoice.Size = New System.Drawing.Size(8, 55)
        Me.panelChoice.TabIndex = 12
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Image = Global.ISADSystem.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(4, 446)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(228, 55)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnRecords
        '
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRecords.Image = Global.ISADSystem.My.Resources.Resources.clipboard_1_
        Me.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.Location = New System.Drawing.Point(4, 387)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(228, 55)
        Me.btnRecords.TabIndex = 8
        Me.btnRecords.Text = "RECORDS"
        Me.btnRecords.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInventory.Image = Global.ISADSystem.My.Resources.Resources.inventory
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(4, 327)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(228, 55)
        Me.btnInventory.TabIndex = 9
        Me.btnInventory.Text = "INVENTORY"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnAccounts
        '
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnAccounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAccounts.Image = Global.ISADSystem.My.Resources.Resources.user
        Me.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccounts.Location = New System.Drawing.Point(4, 275)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(228, 55)
        Me.btnAccounts.TabIndex = 10
        Me.btnAccounts.Text = "ACCOUNTS"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHome.Image = Global.ISADSystem.My.Resources.Resources.home_2_
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(4, 218)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(228, 55)
        Me.btnHome.TabIndex = 11
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'FlatContextMenuStrip2
        '
        Me.FlatContextMenuStrip2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatContextMenuStrip2.ForeColor = System.Drawing.Color.White
        Me.FlatContextMenuStrip2.Name = "FlatContextMenuStrip2"
        Me.FlatContextMenuStrip2.ShowImageMargin = False
        Me.FlatContextMenuStrip2.Size = New System.Drawing.Size(128, 26)
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 671)
        Me.Controls.Add(Me.panelOpen)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelSystem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "J&A Salon"
        Me.panelSystem.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelOpen As Panel
    Friend WithEvents panelSystem As Panel
    Friend WithEvents FlatTextBox1 As FlatTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents panelChoice As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents FlatContextMenuStrip2 As FlatContextMenuStrip
End Class
