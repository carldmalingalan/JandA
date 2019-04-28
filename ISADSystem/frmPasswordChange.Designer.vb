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
        Me.FormSkin1 = New ISADSystem.FormSkin()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnChangePass = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtPass2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPass1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnChangePass)
        Me.FormSkin1.Controls.Add(Me.txtPass2)
        Me.FormSkin1.Controls.Add(Me.txtPass1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(467, 307)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "J & A  Inventory Management"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnChangePass
        '
        Me.btnChangePass.ActiveBorderThickness = 1
        Me.btnChangePass.ActiveCornerRadius = 20
        Me.btnChangePass.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnChangePass.ActiveForecolor = System.Drawing.Color.White
        Me.btnChangePass.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnChangePass.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
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
        Me.btnChangePass.Location = New System.Drawing.Point(143, 178)
        Me.btnChangePass.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(180, 51)
        Me.btnChangePass.TabIndex = 17
        Me.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtPass2.Location = New System.Drawing.Point(143, 131)
        Me.txtPass2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(180, 33)
        Me.txtPass2.TabIndex = 18
        Me.txtPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtPass1.Location = New System.Drawing.Point(143, 78)
        Me.txtPass1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.Size = New System.Drawing.Size(180, 33)
        Me.txtPass1.TabIndex = 19
        Me.txtPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmPasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 307)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPasswordChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPasswordChange"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents btnChangePass As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPass2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPass1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
