<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPasswordCreate))
        Me.FormSkin1 = New InventorySystem.FormSkin()
        Me.txtPassword2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblName = New InventorySystem.FlatLabel()
        Me.FlatLabel2 = New InventorySystem.FlatLabel()
        Me.lblUsername = New InventorySystem.FlatLabel()
        Me.FlatLabel3 = New InventorySystem.FlatLabel()
        Me.lblAccessType = New InventorySystem.FlatLabel()
        Me.FlatLabel1 = New InventorySystem.FlatLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnContinue = New InventorySystem.FlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.txtPassword2)
        Me.FormSkin1.Controls.Add(Me.txtPassword1)
        Me.FormSkin1.Controls.Add(Me.lblName)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.lblUsername)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.lblAccessType)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.btnContinue)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(464, 377)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "J and A"
        '
        'txtPassword2
        '
        Me.txtPassword2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.ForeColor = System.Drawing.Color.White
        Me.txtPassword2.HintForeColor = System.Drawing.Color.Silver
        Me.txtPassword2.HintText = "Repeat Your New Password"
        Me.txtPassword2.isPassword = False
        Me.txtPassword2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword2.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword2.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword2.LineThickness = 3
        Me.txtPassword2.Location = New System.Drawing.Point(59, 273)
        Me.txtPassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(353, 39)
        Me.txtPassword2.TabIndex = 36
        Me.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword1
        '
        Me.txtPassword1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtPassword1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.ForeColor = System.Drawing.Color.White
        Me.txtPassword1.HintForeColor = System.Drawing.Color.Silver
        Me.txtPassword1.HintText = "Type Your New Password"
        Me.txtPassword1.isPassword = False
        Me.txtPassword1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword1.LineThickness = 3
        Me.txtPassword1.Location = New System.Drawing.Point(59, 226)
        Me.txtPassword1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(353, 39)
        Me.txtPassword1.TabIndex = 35
        Me.txtPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(277, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 19)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(187, 73)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(45, 19)
        Me.FlatLabel2.TabIndex = 9
        Me.FlatLabel2.Text = "Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(277, 133)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(71, 19)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(187, 133)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(71, 19)
        Me.FlatLabel3.TabIndex = 9
        Me.FlatLabel3.Text = "Username"
        '
        'lblAccessType
        '
        Me.lblAccessType.AutoSize = True
        Me.lblAccessType.BackColor = System.Drawing.Color.Transparent
        Me.lblAccessType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAccessType.ForeColor = System.Drawing.Color.White
        Me.lblAccessType.Location = New System.Drawing.Point(277, 103)
        Me.lblAccessType.Name = "lblAccessType"
        Me.lblAccessType.Size = New System.Drawing.Size(77, 19)
        Me.lblAccessType.TabIndex = 9
        Me.lblAccessType.Text = "AccessType"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(187, 103)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(77, 19)
        Me.FlatLabel1.TabIndex = 9
        Me.FlatLabel1.Text = "AccessType"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PictureBox1.Image = Global.InventorySystem.My.Resources.Resources.LogoApp
        Me.PictureBox1.Location = New System.Drawing.Point(3, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Transparent
        Me.btnContinue.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnContinue.Location = New System.Drawing.Point(132, 325)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Rounded = False
        Me.btnContinue.Size = New System.Drawing.Size(190, 42)
        Me.btnContinue.TabIndex = 7
        Me.btnContinue.Text = "CONTINUE"
        Me.btnContinue.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmPasswordCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 377)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPasswordCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "J and A"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents btnContinue As FlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As FlatLabel
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents lblAccessType As FlatLabel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents txtPassword2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPassword1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblUsername As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
End Class
