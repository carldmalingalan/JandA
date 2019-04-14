Imports System.Runtime.InteropServices
Imports System.IO
Public Class frmPasswordChange
    ReadOnly AllowedKeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,"
    Private hashp As String
    <DllImport("user32.dll", Entrypoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", Entrypoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelSystem_MouseMove(sender As Object, e As MouseEventArgs) Handles panelSystem.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txtPassword1_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass2.OnValueChanged
        If (txtPass1.Text = txtPass2.Text) Then
            ErrorProvider1.SetError(txtPass2, "Passwords do not match!")
        ElseIf (txtPass1.Text <> "" And txtPass2.Text = "") Then
            ErrorProvider1.SetError(txtPass2, "")
        Else
            ErrorProvider1.SetError(txtPass2, "")
        End If
    End Sub


    Private Sub txtPass2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass2.KeyPress, txtPass1.KeyPress

        Select Case e.KeyChar

            Case Convert.ToChar(Keys.Enter) ' Enter is pressed

            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) AllowedKeys.Contains(c))
                ErrorProvider1.SetError(txtPass2, "")
            Case Else ' Other key is pressed
                If (e.Handled = AllowedKeys.Contains(e.KeyChar)) Then
                    ErrorProvider1.SetError(txtPass2, "Disallowed character pressed! Please use Alphanumeric combinations only.")
                End If
                e.Handled = Not AllowedKeys.Contains(e.KeyChar)

        End Select
    End Sub



    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass2.KeyDown
        If e.KeyValue = Keys.Enter Then
            hashp = getSHA1Hash(txtPass2.Text)
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

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Dim ask = MsgBox("Continue to save?", MsgBoxStyle.Information + vbYesNo, "J&A Inventory Management")
        If (ask = vbYes) Then
            If (txtPass1.Text = txtPass2.Text) Then
                Call ChangePassword(hashp, Fullname)
                MsgBox("Successfully updated password!", MsgBoxStyle.Information, "J&A Inventory Management")
            Else
                MsgBox("Please fill all fields!", MsgBoxStyle.Information, "J&A Inventory Management")
            End If
        End If

    End Sub
End Class