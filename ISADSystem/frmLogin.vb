Imports System.IO
Public Class frmLogin

    Public hashPass As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtPass._TextBox.UseSystemPasswordChar = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = Keys.Enter Then
            ''hashPass = getSHA1Hash(txtPass.Text)
        End If
    End Sub

    Function getSHA1Hash(ByVal strToHash As String) As String

        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim fs As New FileStream("location.txt", FileMode.OpenOrCreate, FileAccess.Write)
        Dim sr As New StreamWriter(fs)
        fs.SetLength(0)
        sr.WriteLine(Me.Location.X)
        sr.WriteLine(Me.Location.Y)
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists("location.txt") Then
            Dim fs As New FileStream("location.txt", FileMode.Open, FileAccess.Read)
            Dim sr As New StreamReader(fs)
            Me.Location = New Point(sr.ReadLine, sr.ReadLine)
            sr.Close()
            fs.Close()
        End If
    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        'If (txtUser.Text.Replace("'", "") <> "" And txtPass.Text.Replace("'", "") <> "") Then
        '    Call Login(txtUser.Text.Replace("'", ""), txtPass.Text.Replace("'", ""), hashPass)
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
        'End If

    End Sub

End Class
