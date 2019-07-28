Public Class frmMenu
    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        frmAccounts.Show()
        Me.Close()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim ask = MsgBox("Are you sure you want to logout?", MsgBoxStyle.Exclamation + vbYesNo, ProductName)
        If ask = vbYes Then
            Dim methodName$ = System.Reflection.MethodBase.GetCurrentMethod().Name
            Call AddAppLogs(AccountName, methodName)
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class