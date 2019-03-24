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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.panelSystem = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelItemList = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelChoice = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timeShow = New System.Windows.Forms.Timer(Me.components)
        Me.timeHide = New System.Windows.Forms.Timer(Me.components)
        Me.panelOpen = New System.Windows.Forms.Panel()
        Me.panelSystem.SuspendLayout()
        Me.panelItemList.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSystem
        '
        Me.panelSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.panelSystem.Controls.Add(Me.btnMinimize)
        Me.panelSystem.Controls.Add(Me.btnExit)
        Me.panelSystem.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSystem.Location = New System.Drawing.Point(0, 0)
        Me.panelSystem.Name = "panelSystem"
        Me.panelSystem.Size = New System.Drawing.Size(1034, 30)
        Me.panelSystem.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnMinimize.Location = New System.Drawing.Point(975, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(1003, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(30, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'panelItemList
        '
        Me.panelItemList.BackColor = System.Drawing.SystemColors.GrayText
        Me.panelItemList.Controls.Add(Me.PictureBox1)
        Me.panelItemList.Controls.Add(Me.panelChoice)
        Me.panelItemList.Controls.Add(Me.btnLogout)
        Me.panelItemList.Controls.Add(Me.btnRecords)
        Me.panelItemList.Controls.Add(Me.btnInventory)
        Me.panelItemList.Controls.Add(Me.btnAccounts)
        Me.panelItemList.Controls.Add(Me.btnHome)
        Me.panelItemList.Controls.Add(Me.btnMenu)
        Me.panelItemList.Controls.Add(Me.Panel1)
        Me.panelItemList.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelItemList.Location = New System.Drawing.Point(0, 30)
        Me.panelItemList.Name = "panelItemList"
        Me.panelItemList.Size = New System.Drawing.Size(234, 576)
        Me.panelItemList.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ISADSystem.My.Resources.Resources.logo_2_
        Me.PictureBox1.Location = New System.Drawing.Point(-100, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'panelChoice
        '
        Me.panelChoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelChoice.Location = New System.Drawing.Point(0, 190)
        Me.panelChoice.Name = "panelChoice"
        Me.panelChoice.Size = New System.Drawing.Size(8, 55)
        Me.panelChoice.TabIndex = 5
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Image = Global.ISADSystem.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(6, 418)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(228, 55)
        Me.btnLogout.TabIndex = 4
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
        Me.btnRecords.Location = New System.Drawing.Point(6, 359)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(228, 55)
        Me.btnRecords.TabIndex = 4
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
        Me.btnInventory.Location = New System.Drawing.Point(6, 299)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(228, 55)
        Me.btnInventory.TabIndex = 4
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
        Me.btnAccounts.Location = New System.Drawing.Point(6, 247)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(228, 55)
        Me.btnAccounts.TabIndex = 4
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
        Me.btnHome.Location = New System.Drawing.Point(6, 190)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(228, 55)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = Global.ISADSystem.My.Resources.Resources.menu
        Me.btnMenu.Location = New System.Drawing.Point(186, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(45, 38)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(93, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 79)
        Me.Panel1.TabIndex = 2
        '
        'timeShow
        '
        Me.timeShow.Interval = 40
        '
        'timeHide
        '
        Me.timeHide.Interval = 40
        '
        'panelOpen
        '
        Me.panelOpen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpen.Location = New System.Drawing.Point(234, 30)
        Me.panelOpen.Name = "panelOpen"
        Me.panelOpen.Size = New System.Drawing.Size(800, 576)
        Me.panelOpen.TabIndex = 2
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 606)
        Me.Controls.Add(Me.panelOpen)
        Me.Controls.Add(Me.panelItemList)
        Me.Controls.Add(Me.panelSystem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "J&A Salon"
        Me.panelSystem.ResumeLayout(False)
        Me.panelItemList.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSystem As Panel
    Friend WithEvents panelItemList As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents timeShow As Timer
    Friend WithEvents timeHide As Timer
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents panelChoice As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents panelOpen As Panel
End Class
