Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUser.Text <> "" And txtPass.Text <> "") Then
            Call Login(txtUser.Text.Replace("'", ""), txtPass.Text.Replace("'", ""))
            If (Loginname = "") Then
                MsgBox("Invalid access!", MsgBoxStyle.Critical, "J&A Salon")
            Else
                Me.Hide()
                frmMainMenu.Show()
            End If
        End If
    End Sub
    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyPress, txtUser.KeyPress
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If

    End Sub
End Class
