Imports System.Data.SqlClient
Imports System.IO

Public Class frmItemManagement

    Dim bytImage() As Byte

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images | *.png ; *.bmp ; *.jpg ; *.jpeg ; *.gif ; *.ico;")
                .FilterIndex = 4
            End With
            'clears the filename
            OpenFileDialog1.FileName = ""
            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                pbItemPicture.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnProceedCreateItem_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

        If (txtItemName.Text <> "" And txtItemQuantity.Text <> "" And IsNumeric(txtItemQuantity.Text)) Then
            Dim ask = MsgBox("Are you sure you want to save this to the inventory?", MsgBoxStyle.Exclamation + vbYesNo, ProductName)
            If (ask = vbYes) Then
                Call ConnectTOSQLServer()
                Dim sql As String = "INSERT INTO [dbo].[tblItemList]([Item Name],[Item Quantity],[Item Classification],[LastModifiedBy],[LastModifiedDate],[CreatedBy],[CreationDate]) VALUES(@ItemName,@ItemQuantity,@ItemClassification,@Modifier,getdate(),@Creator,getdate())"

                'Dim sql As String = "INSERT INTO [dbo].[tblItemList]([Item Name],[Item Quantity],[Item Classification],[Item Picture],[LastModifiedBy],[LastModifiedDate],[CreatedBy],[CreationDate]) VALUES(@ItemName,@ItemQuantity,@ItemClassification,@ItemPicture,@Modifier,getdate(),@Creator,getdate())"
                Using Connection As New SqlConnection(sqlConnectionString),
              cmd As New SqlCommand(sql, Connection)

                    cmd.Parameters.AddWithValue("@ItemName", SqlDbType.VarChar).Value = txtItemName.Text
                    cmd.Parameters.AddWithValue("@ItemQuantity", SqlDbType.VarChar).Value = txtItemQuantity.Text
                    cmd.Parameters.AddWithValue("@ItemClassification", SqlDbType.VarChar).Value = txtItemDescription.Text
                    cmd.Parameters.AddWithValue("@Modifier", SqlDbType.VarChar).Value = AccountName
                    cmd.Parameters.AddWithValue("@Creator", SqlDbType.VarChar).Value = AccountName
                    'Dim ms As New MemoryStream()
                    'pbItemPicture.BackgroundImage.Save(ms, pbItemPicture.BackgroundImage.RawFormat)
                    'Dim data As Byte() = ms.GetBuffer()
                    'Dim p As New SqlParameter("@ItemPicture", SqlDbType.Image)
                    'p.Value = data
                    'cmd.Parameters.Add(p)


                    Connection.Open()
                    cmd.ExecuteNonQuery()
                    'If cmd.ExecuteNonQuery() = 1 Then
                    '    MessageBox.Show("Image Inserted")
                    'Else
                    '    MessageBox.Show("Image Not Inserted")
                    'End If
                    MsgBox("Item has been successfully added to the inventory.", MsgBoxStyle.Information, ProductName)
                    Connection.Close()
                    Console.WriteLine(sql)
                    Dim methodName$ = System.Reflection.MethodBase.GetCurrentMethod().Name
                    Call AddAppLogs(AccountName, methodName)
                End Using

                Call DisConnectSQLServer()
                Call clearfields()
                frmInventory.dtpItemListing.Enabled = True
                Me.Close()
            End If
        Else
            If (IsNumeric(txtItemQuantity.Text)) Then
                MsgBox("Fill all required fields!", MsgBoxStyle.Information, ProductName)
            Else
                MsgBox("Item Quantity should only be numeric!", MsgBoxStyle.Information, ProductName)
            End If
        End If

    End Sub

    Private Sub clearfields()
        txtItemDescription.Text = ""
        txtItemName.Text = ""
        txtItemQuantity.Text = ""
        cboItemClassification.SelectedIndex = -1

    End Sub
End Class