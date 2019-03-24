Option Explicit On

Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlTypes
Imports Excel = Microsoft.Office.Interop.Excel


Module connect
    Public Connection As SqlConnection
    Private Server As String
    Private Database As String
    Private UID As String
    Private Password As String

    Public Loginname As String
    Public Reset As String
    Public loginDate As DateTime

    Public reader As SqlDataReader
    Public dataadapter As New SqlDataAdapter
    Public cmd As SqlCommand
    Public strSQL As String


    Public Sub ConnectTOSQLServer()
        Connection = New SqlConnection("Server=.\SQLEXPRESS;Database=JandA;Trusted_Connection=True;")
        Try
            Connection.Open()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")

            End
        End Try
    End Sub

    Public Sub DisConnectSQLServer()
        Try

            Connection.Close()
        Catch ex As Exception
            MsgBox("Can not close connection ! ")
        End Try
    End Sub

    Public Sub Login(id As String, pass As String)
        Call ConnectTOSQLServer()
        Dim RequesterID = id
        strSQL = "select distinct Fullname, username, IsReset, AccountType, getdate() from tblAppLogin where username = '" & id.ToUpper & "' and password = '" & pass & "'"


        Console.WriteLine(strSQL)

        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                Loginname = reader.GetString(0)
                Reset = reader.GetString(2)
                loginDate = reader.GetDateTime(4)
            Loop
            reader.NextResult()
        Loop

        reader.Close()

        Call DisConnectSQLServer()
    End Sub
End Module
