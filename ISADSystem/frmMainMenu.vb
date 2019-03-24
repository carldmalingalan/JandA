
Imports System.Runtime.InteropServices

Public Class frmMainMenu


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

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If panelItemList.Width = 234 Then
            timeHide.Enabled = True
        ElseIf panelItemList.Width <> 65 Then
            timeShow.Enabled = True
        End If
    End Sub

    Private Sub timeHide_Tick(sender As Object, e As EventArgs) Handles timeHide.Tick
        If panelItemList.Width <= 65 Then
            Me.timeHide.Enabled = False
        Else
            Me.panelItemList.Width = panelItemList.Width - 20
        End If
    End Sub

    Private Sub timeShow_Tick(sender As Object, e As EventArgs) Handles timeShow.Tick
        If panelItemList.Width >= 234 Then
            Me.timeShow.Enabled = False
        Else
            Me.panelItemList.Width = panelItemList.Width + 20
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub


    Private Sub OpenPanel(ByVal Childform As Object)
        If Me.panelOpen.Controls.Count > 0 Then
            Me.panelOpen.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Childform, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        Me.panelOpen.Controls.Add(fh)
        Me.panelOpen.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        panelChoice.Top = btnHome.Top
        panelChoice.Height = btnHome.Height
        OpenPanel(New frmHome)
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        panelChoice.Top = btnAccounts.Top
        panelChoice.Height = btnAccounts.Height
        OpenPanel(New frmAccounts)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        panelChoice.Top = btnInventory.Top
        panelChoice.Height = btnInventory.Height
        OpenPanel(New frmAccounts)
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        panelChoice.Top = btnRecords.Top
        panelChoice.Height = btnRecords.Height
        OpenPanel(New frmAccounts)

    End Sub
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        btnHome.PerformClick()
    End Sub

End Class