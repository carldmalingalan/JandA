Imports System.Data.SqlClient
Imports System.IO

Public Class frmItemManagement
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images | *.png ; *.bmp ; *.jpg ; *.jpeg ; *.gif ; *.ico;")
                .FilterIndex = 4
            End With
            'clears the filename
            OpenFileDialog1.FileName = ""
            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                pbItemPicture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

        If (txtItemName.Text <> "" And txtItemQuantity.Text <> "") Then
            Dim ms As New MemoryStream
            pbItemPicture.Image.Save(ms, pbItemPicture.Image.)


            Call ConnectTOSQLServer()
            Dim sql As String = "INSERT INTO [dbo].[tblItemList]([Item Name],[Item Quantity],[Item Classification],[Item Picture],[LastModifiedBy],[LastModifiedDate],[CreatedBy],[CreationDate]) VALUES(@ItemName,@ItemQuantity,@ItemClassification,@ItemPicture,@Modifier,getdate(),@Creator,getdate())"
            Using Connection As New SqlConnection(sqlConnectionString),
                  cmd As New SqlCommand(sql, Connection)

                cmd.Parameters.AddWithValue("@ItemName", SqlDbType.VarChar).Value = txtItemName.Text
                cmd.Parameters.AddWithValue("@ItemQuantity", SqlDbType.VarChar).Value = txtItemQuantity.Text
                cmd.Parameters.AddWithValue("@ItemClassification", SqlDbType.VarChar).Value = txtItemDescription.Text
                cmd.Parameters.AddWithValue("@ItemPicture", SqlDbType.Image).Value = ms.ToArray()
                cmd.Parameters.AddWithValue("@Modifier", SqlDbType.VarChar).Value = AccountName
                cmd.Parameters.AddWithValue("@Creator", SqlDbType.VarChar).Value = AccountName

                Connection.Open()
                cmd.ExecuteNonQuery()
                If cmd.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Image Inserted")
                Else
                    MessageBox.Show("Image Not Inserted")
                End If

                Connection.Close()
                Console.WriteLine(sql)

            End Using
            Call DisConnectSQLServer()
        End If
    End Sub
End Class