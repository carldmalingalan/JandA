

Imports System.Data.SqlClient

Public Class frmAccounts

    Private selectedRow As Integer
    Private RecordSearch As Integer

    Private Sub frmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewRecords()
    End Sub

    Public Sub viewRecords()
        Call ConnectTOSQLServer()
        If (txtUsername.Text <> "") Then
            strSQL = "select Lastname, Firstname, Accountname, Username,AccessType, AccountType as AccountStatus from tblLogins where  AccountType = 'ACTIVE' and Firstname like '%" & txtUsername.Text & "%' or Lastname like '%" & txtUsername.Text & "%' or Username like '%" & txtUsername.Text & "%'"

        Else
            strSQL = "Select Lastname, Firstname, Accountname, Username,AccessType, AccountType As AccountStatus from tblLogins where AccountType = 'ACTIVE'"

        End If

        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim Userlist As New DataSet()

        dataadapter.Fill(Userlist, "tblLogins")
        dgvUserList.DataSource = Userlist
        dgvUserList.DataMember = "tblLogins"
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        edit = 0
        btnEdit.Enabled = False
        frmUserManage.ShowDialog()
    End Sub

    Private Sub btnEdit_EnabledChanged(sender As Object, e As EventArgs) Handles btnEdit.EnabledChanged
        Call viewRecords()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        frmUserManage.txtLastname.Text = dgvUserList.Rows(selectedRow).Cells(0).Value()
        frmUserManage.txtFirstname.Text = dgvUserList.Rows(selectedRow).Cells(1).Value()
        frmUserManage.txtUsername.Text = dgvUserList.Rows(selectedRow).Cells(3).Value()
        frmUserManage.cboAccountType.Text = dgvUserList.Rows(selectedRow).Cells(4).Value()
        UsernameOrig = dgvUserList.Rows(selectedRow).Cells(3).Value()

        frmUserManage.ShowDialog()
        btnEdit.Enabled = False

    End Sub


    Private Sub dgvUserList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellContentDoubleClick
        edit = 1
        UsernameOrig = dgvUserList.Rows(selectedRow).Cells(3).Value()
        frmUserManage.txtLastname.Text = dgvUserList.Rows(selectedRow).Cells(0).Value()
        frmUserManage.txtFirstname.Text = dgvUserList.Rows(selectedRow).Cells(1).Value()
        frmUserManage.txtUsername.Text = dgvUserList.Rows(selectedRow).Cells(3).Value()
        frmUserManage.cboAccountType.Text = dgvUserList.Rows(selectedRow).Cells(4).Value()
        frmUserManage.ShowDialog()
        btnEdit.Enabled = False
    End Sub

    Private Sub dgvUserList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellContentClick
        If (dgvUserList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtUsername_OnValueChanged(sender As Object, e As EventArgs) Handles txtUsername.OnValueChanged
        Call viewRecords()
    End Sub

    'Private Sub dgvUserList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvUserList.MouseClick
    '    If e.Button = MouseButtons.Right Then
    '        Dim m As New ContextMenu()

    '        Dim currentMouseOverRow As Integer = dgvUserList.HitTest(e.X, e.Y).RowIndex
    '        If currentMouseOverRow >= 0 Then
    '            m.MenuItems.Add(New MenuItem(String.Format("Disable Account")))
    '        End If
    '        m.Show(dgvUserList, New Point(e.X, e.Y))
    '    End If
    'End Sub


End Class