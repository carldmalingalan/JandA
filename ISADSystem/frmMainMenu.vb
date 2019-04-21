
Imports System.Runtime.InteropServices

Public Class frmMainMenu


    <DllImport("user32.dll", Entrypoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", Entrypoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelSystem_MouseMove(sender As Object, e As MouseEventArgs) 
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        If panelItemList.Width = 234 Then
            timeHide.Enabled = True
        ElseIf panelItemList.Width <> 65 Then
            timeShow.Enabled = True
        End If
    End Sub

    Private Sub timeHide_Tick(sender As Object, e As EventArgs) 
        If panelItemList.Width <= 65 Then
            Me.timeHide.Enabled = False
        Else
            Me.panelItemList.Width = panelItemList.Width - 20
        End If
    End Sub

    Private Sub timeShow_Tick(sender As Object, e As EventArgs) 
        If panelItemList.Width >= 234 Then
            Me.timeShow.Enabled = False
        Else
            Me.panelItemList.Width = panelItemList.Width + 20
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        panelChoice.Top = btnHome.Top
        panelChoice.Height = btnHome.Height
        OpenPanel(New frmHome)
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs)
        panelChoice.Top = btnAccounts.Top
        panelChoice.Height = btnAccounts.Height
        OpenPanel(New frmAccounts)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs)
        panelChoice.Top = btnInventory.Top
        panelChoice.Height = btnInventory.Height
        OpenPanel(New frmInventory)
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs)
        panelChoice.Top = btnRecords.Top
        panelChoice.Height = btnRecords.Height
        OpenPanel(New frmAccounts)

    End Sub

    Private Sub panelOpen_Paint(sender As Object, e As PaintEventArgs) 

    End Sub
End Class