Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text <> "" And txtPassword.Text <> "") Then
            Dim hashPass = GetHash(txtPassword.Text)
            Call Login(txtUsername.Text, hashPass)
            If (AccountName <> "") Then
                If (hashPass = defaultPassword) Then
                    Dim ask = MsgBox("A new password is required to access your account. Do you want to set it up now?", MsgBoxStyle.Information + vbYesNo, Brandname)
                    If (ask = vbYes) Then
                        frmPasswordCreate.Show()
                    End If
                Else
                    frmMenu.Show()
                End If
                Me.Close()
            Else
                MsgBox("Invalid Credentials!", MsgBoxStyle.Exclamation, Brandname)
            End If
        Else
            MsgBox("Invalid Credentials!", MsgBoxStyle.Exclamation, Brandname)
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress, txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub


    Private Sub checkBoxShow_MouseHover(sender As Object, e As EventArgs) Handles checkBoxShow.MouseHover
        txtPassword.isPassword = False
    End Sub

    Private Sub checkBoxShow_MouseLeave(sender As Object, e As EventArgs) Handles checkBoxShow.MouseLeave
        txtPassword.isPassword = True
    End Sub
    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        If (txtPassword.Text <> "") Then
            txtPassword.isPassword = True
        Else
            txtPassword.isPassword = False
        End If
    End Sub

End Class
