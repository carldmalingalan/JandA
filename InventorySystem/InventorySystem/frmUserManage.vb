Public Class frmUserManage

    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Close()
    End Sub

    Private Sub FirstNameValidation()

        If txtFirstname.Text.Trim = "" Then

            ErrorProvider1.SetError(txtFirstname, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False

        ElseIf txtFirstname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtFirstname, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False

        ElseIf IsNumeric(txtFirstname.Text) = True Or txtFirstname.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtFirstname, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False

        Else

            ErrorProvider1.SetError(txtFirstname, "")

        End If

    End Sub

    Private Sub LastNameValidation()

        If txtLastname.Text.Trim = "" Then

            ErrorProvider1.SetError(txtLastname, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False

        ElseIf txtLastname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtLastname, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False

        ElseIf IsNumeric(txtLastname.Text) = True Or txtLastname.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtLastname, "Numeric characters are not characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(txtLastname, "")
        End If
    End Sub
    Private Sub UsernameValidation()

        If txtUsername.Text.Trim = "" Then

            ErrorProvider1.SetError(txtUsername, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.IndexOfAny(restrictedCharactersForUsername) > -1 Then

            ErrorProvider1.SetError(txtUsername, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.IndexOfAny("-_1234567890") = 0 Then

            ErrorProvider1.SetError(txtUsername, "The first character must be a letter.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.Length < 3 Then

            ErrorProvider1.SetError(txtUsername, "Username must me at least 3 characters.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False
        End If
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If (txtLastname.Text <> "" And txtLastname.Text <> "" And txtUsername.Text <> "" And cboAccountType.Text <> "") Then
            If (edit = 0) Then
                Dim ask = MsgBox("Do you want to create this accounts?", MsgBoxStyle.Information + vbYesNo, Brandname)
                If (ask = vbYes) Then
                    Call UsernameChecker(txtUsername.Text)
                    If (UsernameCheck = "") Then
                        Call CreateAccount(txtFirstname.Text, txtLastname.Text, txtUsername.Text, cboAccountType.Text)
                        MsgBox("Account has been created.", MsgBoxStyle.Information, Brandname)
                        frmAccounts.btnEdit.Enabled = True
                        Dim methodName$ = System.Reflection.MethodBase.GetCurrentMethod().Name
                        Call AddAppLogs(AccountName, methodName)
                        Me.Close()
                    End If
                Else
                    ErrorProvider1.SetError(txtUsername, "Username is already taken!")
                End If
            ElseIf (edit = 1) Then
                Dim ask = MsgBox("Do you want to update this account?", MsgBoxStyle.Information + vbYesNo, Brandname)
                If (ask = vbYes) Then
                    Call UsernameChecker(txtUsername.Text)
                    If (UsernameCheck = "") Then
                        Call UpdateAccount(txtFirstname.Text, txtLastname.Text, txtUsername.Text, cboAccountType.Text, UsernameOrig)
                        MsgBox("Account has been updated.", MsgBoxStyle.Information, Brandname)
                        frmAccounts.btnEdit.Enabled = True
                        Dim methodName$ = System.Reflection.MethodBase.GetCurrentMethod().Name
                        Call AddAppLogs(AccountName, methodName)
                        Me.Close()
                    Else
                        ErrorProvider1.SetError(txtUsername, "Username is already taken!")
                    End If
                End If
            End If
        Else
            MsgBox("Please fill up all required fields.", MsgBoxStyle.Information, Brandname)
        End If
    End Sub

    Private Sub frmUserManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True

    End Sub
End Class