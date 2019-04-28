Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class frmLogin

    Private Const SaltSize As Integer = 31
    Dim dbPW As String
    Dim dbSalt = CreateNewSalt(SaltSize)
    ' eg: "dsEGWpJpwfAOvdRZyUo9rA=="

    Dim SaltedPWHash As String = GetSaltedHash(dbPW, dbSalt)




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.Text = SaltedPWHash
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        If (txtUsername.Text.Replace("'", "") <> "" And txtUsername.Text.Replace("'", "") <> "") Then
            Call Login(txtUsername.Text.Replace("'", ""), SaltedPWHash)
            If (Fullname = "") Then
                MsgBox("Invalid access!", MsgBoxStyle.Critical, "J&A Inventory Management")
            Else
                If (isReset = "Yes") Then
                    Dim ask = MsgBox("Hi! " + Fullname + ". Your account has been reset. You will be neeeding to change your password to be able to access the app. Would you like to proceed?", MsgBoxStyle.Information + vbYesNo, "J&A Inventory Management")
                    If (ask = vbYes) Then
                        frmPasswordChange.Show()
                        Me.Close()
                    End If
                ElseIf (isReset = "No") Then
                    frmMainMenu.Show()
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs)
        If (txtPassword.Text <> "") Then
            txtPassword.isPassword = True
        Else
            txtPassword.isPassword = False
        End If
    End Sub

    Private Function GetSaltedHash(pw As String, salt As String) As String
        Dim tmp As String = pw & salt

        ' or SHA512Managed
        Using hash As HashAlgorithm = New SHA256Managed()
            ' convert pw+salt to bytes:
            Dim saltyPW = Encoding.UTF8.GetBytes(tmp)
            ' hash the pw+salt bytes:
            Dim hBytes = hash.ComputeHash(saltyPW)
            ' return a B64 string so it can be saved as text 
            Return Convert.ToBase64String(hBytes)
        End Using

    End Function

    Private Function CreateNewSalt(size As Integer) As String
        ' use the crypto random number generator to create
        ' a new random salt 
        Using rng As New RNGCryptoServiceProvider
            ' dont allow very small salt
            Dim data(If(size < 7, 7, size)) As Byte
            ' fill the array
            rng.GetBytes(data)
            ' convert to B64 for saving as text
            Return Convert.ToBase64String(data)
        End Using
    End Function


    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (txtUsername.Text <> "" And txtPassword.Text <> "") Then
                Dim pwTry = txtPassword.Text
                ' hash the login attempt using the salt stored in the DB
                Dim pwLogin = GetSaltedHash(pwTry, dbSalt)

                ' compare the hash of what they entered to whats in the DB:
                If String.Compare(SaltedPWHash, pwLogin, False) = 0 Then
                    ' okay!s
                    Console.Beep()
                End If
                Call Login(txtUsername.Text, pwTry)
            End If
        End If
    End Sub
End Class
