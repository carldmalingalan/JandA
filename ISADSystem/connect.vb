Option Explicit On
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlTypes


Module connect

    Public ExcelConnection As New System.Data.OleDb.OleDbConnection
    Private ExcelPath As String

    Public Connection As SqlConnection
    Public Connection2 As SqlConnection
    Private Server As String
    Private Database As String
    Private UID As String
    Private Password As String

    'Login Readers
    Public Fullname As String
    Public isReset As String
    Public AccountType As String
    Public AccountID As String


    Public cmd As SqlCommand
    Public strSQL As String
    Public strSQL1 As String

    Public reader As SqlDataReader
    Public dataadapter As New SqlDataAdapter


    Dim pword As String
    Dim passwordSHA As String

    Public Sub ConnectTOSQLServer()
        Connection = New SqlConnection("Server=MARCO\SQLEXPRESS;Database=JandA;Trusted_Connection=True;")
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
        Dim un As New String(Environment.UserName)
        Fullname = ""
        strSQL = "select distinct FullName, IsReset,AccountType,accountID from tblAppLogin where Username = '" & id & "' and (Password = '' or DefaultPassword = '" & pass & "')"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()

        Do While reader.HasRows

            Do While reader.Read()
                Fullname = reader.GetString(0)
                isReset = reader.GetString(1)
                AccountType = reader.GetString(2)
                AccountID = reader.GetInt32(3)
            Loop
            reader.NextResult()
        Loop
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

    Public Sub ChangePassword(hashp As String, fullname As String)
        strSQL = "update tblAppLogin set Password ='" & hashp & "' where AccountID = '" & AccountID & "'"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
    End Sub

End Module
