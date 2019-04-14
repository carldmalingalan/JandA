<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPasswordChange))
        Me.panelSystem = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnChangePass = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPass1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPass2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.panelSystem.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelSystem.Size = New System.Drawing.Size(467, 30)
        Me.panelSystem.TabIndex = 1
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
        'btnChangePass
        '
        Me.btnChangePass.ActiveBorderThickness = 1
        Me.btnChangePass.ActiveCornerRadius = 20
        Me.btnChangePass.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnChangePass.ActiveForecolor = System.Drawing.Color.White
        Me.btnChangePass.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnChangePass.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangePass.BackgroundImage = CType(resources.GetObject("btnChangePass.BackgroundImage"), System.Drawing.Image)
        Me.btnChangePass.ButtonText = "CHANGE PASSWORD"
        Me.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnChangePass.IdleBorderThickness = 1
        Me.btnChangePass.IdleCornerRadius = 20
        Me.btnChangePass.IdleFillColor = System.Drawing.Color.White
        Me.btnChangePass.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnChangePass.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnChangePass.Location = New System.Drawing.Point(183, 242)
        Me.btnChangePass.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(180, 51)
        Me.btnChangePass.TabIndex = 5
        Me.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Repeat Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.ISADSystem.My.Resources.Resources.logo_2_
        Me.PictureBox1.Location = New System.Drawing.Point(97, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txtPass1
        '
        Me.txtPass1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass1.HintForeColor = System.Drawing.Color.Empty
        Me.txtPass1.HintText = ""
        Me.txtPass1.isPassword = False
        Me.txtPass1.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPass1.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPass1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPass1.LineThickness = 3
        Me.txtPass1.Location = New System.Drawing.Point(183, 142)
        Me.txtPass1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.Size = New System.Drawing.Size(180, 33)
        Me.txtPass1.TabIndex = 9
        Me.txtPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPass2
        '
        Me.txtPass2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass2.HintForeColor = System.Drawing.Color.Empty
        Me.txtPass2.HintText = ""
        Me.txtPass2.isPassword = False
        Me.txtPass2.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPass2.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPass2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPass2.LineThickness = 3
        Me.txtPass2.Location = New System.Drawing.Point(183, 195)
        Me.txtPass2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(180, 33)
        Me.txtPass2.TabIndex = 9
        Me.txtPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmPasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 307)
        Me.Controls.Add(Me.txtPass2)
        Me.Controls.Add(Me.txtPass1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.panelSystem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPasswordChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPasswordChange"
        Me.panelSystem.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelSystem As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnChangePass As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPass2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPass1 As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
