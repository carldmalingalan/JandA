Imports System.Data.SqlClient

Public Class frmInventory


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmItemManagement.ShowDialog()
        dtpItemListing.Enabled = True
    End Sub



    Private Sub viewItems()
        Call ConnectTOSQLServer()
        strSQL = "select [Item Name],[Item Quantity],[Item Classification],LastModifiedBy,LastModifiedDate from tblItemList"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet()
        dataadapter.Fill(ds, "tblItemlist")
        dgvItemList.DataSource = ds
        dgvItemList.DataMember = "tblItemlist"
        Call DisConnectSQLServer()
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewItems()
    End Sub

    Private Sub dtpItemListing_EnabledChanged(sender As Object, e As EventArgs) Handles dtpItemListing.EnabledChanged
        If (dtpItemListing.Enabled = True) Then
            Call viewItems()
        Else
            Call viewItems()
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class