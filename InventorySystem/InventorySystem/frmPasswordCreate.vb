Public Class frmPasswordCreate
    Dim flag1, flag2, flag3, flag4 As Boolean

    Private Sub frmPasswordCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = AccountName
        lblAccessType.Text = AccountType
        lblUsername.Text = AccountID
    End Sub

    Private Sub PasswordValidation() 'filters input of password

        If txtPassword1.Text.Trim = "" Then

            ErrorProvider1.SetError(txtPassword1, "Empty password is not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword1, 5)
            flag1 = False

        ElseIf txtPassword1.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then

            ErrorProvider1.SetError(txtPassword1, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword1, 5)
            flag1 = False

        ElseIf txtPassword1.Text.Length < 8 Then

            ErrorProvider1.SetError(txtPassword1, "Password must be at least 8 characters.")
            ErrorProvider1.SetIconPadding(txtPassword1, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtPassword1, "")

        End If

    End Sub

    Private Sub PasswordValidation1() 'filters input of password

        If txtPassword2.Text.Trim = "" Then

            ErrorProvider1.SetError(txtPassword2, "Empty password is not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword2, 5)
            flag2 = False

        ElseIf txtPassword2.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then

            ErrorProvider1.SetError(txtPassword2, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword2, 5)
            flag2 = False

        ElseIf txtPassword2.Text.Length < 8 Then

            ErrorProvider1.SetError(txtPassword2, "Password must be at least 8 characters.")
            ErrorProvider1.SetIconPadding(txtPassword2, 5)
            flag2 = False

        Else
            ErrorProvider1.SetError(txtPassword2, "")
        End If
    End Sub

    Private Sub PasswordValidation2() 'checks if passwords are the same
        If (txtPassword2.Text <> txtPassword1.Text) Then
            ErrorProvider1.SetError(txtPassword1, "Passwords do not match!")
            ErrorProvider1.SetIconPadding(txtPassword1, 5)
            flag3 = False
        ElseIf (txtPassword2.Text = "admin12345") Then
            ErrorProvider1.SetError(txtPassword1, "Please enter a different password!")
            ErrorProvider1.SetIconPadding(txtPassword2, 5)
            flag4 = False
        Else
            ErrorProvider1.SetError(txtPassword1, "")
        End If
    End Sub

    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True

        PasswordValidation()
        PasswordValidation1()
        PasswordValidation2()

        If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Then
            MsgBox("Please complete all the required fields and errors!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, "Chronic Care Records System")
        If (ask = vbYes) Then
            Call PasswordSetter(GetHash(txtPassword2.Text), AccountID)
            MsgBox("Password has been successfully changed!", MsgBoxStyle.Information, "Chronic Care Records System")
            frmMenu.Show()
            Dim methodName$ = System.Reflection.MethodBase.GetCurrentMethod().Name
            Call AddAppLogs(AccountName, methodName)
            Me.Close()
        End If

    End Sub

    Private Sub txtPassword1_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword1.OnValueChanged, txtPassword2.OnValueChanged
        If (txtPassword1.Text <> "") Then
            txtPassword1.isPassword = True
        Else
            txtPassword1.isPassword = False
        End If

        If (txtPassword2.Text <> "") Then
            txtPassword2.isPassword = True
        Else
            txtPassword2.isPassword = False
        End If
    End Sub

    Private Sub txtPassword1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword1.KeyPress, txtPassword2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call btnSavePassword_Click(sender, e)
        End If
    End Sub
End Class