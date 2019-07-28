Option Explicit On
Imports System.Security.Cryptography
Imports System.Text

Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlTypes


Module mdlConnect
    Public trigger As Boolean
    Public edit As String
    Public restrictedCharactersForUsername As String = "!@#$%^&*()+=[]\{}|;':,./<>?€‚ƒ„…†‡ˆ‰Š‹ŒŽ‘’""•–—˜™š›œžŸ¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ" & Chr(34) & " " 'Underscores and dash are only allowed
    Public restrictedCharactersForName As String = "!@#$%^&*()=_+[]\{}|;':,/<>?€‚ƒ„…†‡ˆ‰Š‹ŒŽ‘’""•–—˜™š›œžŸ¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ" & Chr(34) 'Dot, dash and spaces are only allowed
    Public restrictedCharactersForPassword As String = "!-=[]\{}|;':,/<>€‚ƒ„…†‡ˆ‰Š‹ŒŽ‘’""•–—˜™š›œžŸ¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ?" & Chr(34) 'Letters and numbers are only allowed
    'Letters and numbers are only allowed
    Public Brandname = "J and A Inventory"
    Public UsernameOrig As String = ""
    Public defaultPassword As String = "41E5653FC7AEB894026D6BB7B2DB7F65902B454945FA8FD65A6327047B5277FB"
    'hasfor admin12345
    Public ExcelConnection As New System.Data.OleDb.OleDbConnection
    Private ExcelPath As String

    Public Connection As SqlConnection
    Public Connection2 As SqlConnection
    Private Server As String
    Private Database As String
    Private UID As String
    Private Password As String

    'Login Readers
    Public AccountName As String
    Public UsernameCheck As String
    Public AccountType As String
    Public AccountID As String
    Public AccountNumber As Int32

    Public sqlConnectionString = "Server=MARCO\SQLEXPRESS;Database=JandA;Trusted_Connection=True;"
    Public cmd As SqlCommand
    Public strSQL As String
    Public strSQL1 As String

    Public reader As SqlDataReader
    Public dataadapter As New SqlDataAdapter
    Function GetHash(theInput As String) As String

        Using hasher As SHA256 = SHA256.Create()    ' create hash object
            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))
            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()
            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n
            Return sBuilder.ToString()
        End Using
    End Function

    Public Sub ConnectTOSQLServer()
        Connection = New SqlConnection(sqlConnectionString)
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


    Public Sub Login(Username As String, Password As String)
        Call ConnectTOSQLServer()
        AccountName = ""
        strSQL = "select AccountName, Username, AccountType,AccountID from tblLogins where Username = @Username and Password = @Password and AccountType = 'ACTIVE'"
        Console.WriteLine(strSQL)
        'cmd = New SqlCommand(strSQL, Connection)
        Using Connection As New SqlConnection(sqlConnectionString),
              cmd As New SqlCommand(strSQL, Connection)

            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Password
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username

            Connection.Open()
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            Do While reader.HasRows

                Do While reader.Read()
                    AccountName = reader.GetString(0)
                    AccountID = reader.GetString(1)
                    AccountType = reader.GetString(2)
                    AccountNumber = reader.GetInt32(3)
                Loop
                reader.NextResult()
            Loop
            reader.Close()

            Console.WriteLine(strSQL)

        End Using
        Call DisConnectSQLServer()
    End Sub

    Public Sub PasswordSetter(password As String, Username As String)

        Dim sql As String = "update tblLogins Set Password = @Password where Username = @Username"

        Using Connection As New SqlConnection(sqlConnectionString),
              cmd As New SqlCommand(sql, Connection)

            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = password
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username

            Connection.Open()
            cmd.ExecuteNonQuery()
            Console.WriteLine(sql)

        End Using
        Call DisConnectSQLServer()
    End Sub

    Public Sub UsernameChecker(Username As String)
        Call ConnectTOSQLServer()
        Dim sql As String = "Select * from tblLogins where Username = @Username"
        UsernameCheck = ""
        Using Connection As New SqlConnection(sqlConnectionString),
              cmd As New SqlCommand(sql, Connection)

            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username

            Connection.Open()
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            Do While reader.HasRows

                Do While reader.Read()
                    UsernameCheck = reader.GetString(4)
                Loop
                reader.NextResult()
            Loop
            reader.Close()
        End Using
        Call DisConnectSQLServer()
    End Sub

    Public Sub CreateAccount(Firstname As String, Lastname As String, Username As String, AccessType As String)
        Dim sql As String = "insert into tblLogins(Lastname, Firstname, Username, Password, AccessType, AccountType,CreationDate,CreatedBy) values(@Lastname,@Firstname,@Username,'" & defaultPassword & "',@AccessType,'ACTIVE',getdate(),'" & AccountID & "')"
        Using Connection As New SqlConnection(sqlConnectionString),
                        cmd As New SqlCommand(sql, Connection)
            cmd.Parameters.AddWithValue("@Firstname", SqlDbType.VarChar).Value = Firstname
            cmd.Parameters.AddWithValue("@Lastname", SqlDbType.VarChar).Value = Lastname
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username
            cmd.Parameters.AddWithValue("@AccessType", SqlDbType.VarChar).Value = AccessType
            Connection.Open()
            cmd.ExecuteNonQuery()
            Console.WriteLine(sql)
        End Using
    End Sub

    Public Sub UpdateAccount(Firstname As String, Lastname As String, username As String, accesstype As String, UsernameOriginal As String)
        Call ConnectTOSQLServer()
        Dim sql As String = "Update tblLogins set Username = @Username, Lastname = @Lastname, Firstname = @Firstname, Accesstype = @AccessType where Username = @UsernameOriginal"
        Using Connection As New SqlConnection(sqlConnectionString),
              cmd As New SqlCommand(sql, Connection)

            cmd.Parameters.AddWithValue("@Lastname", SqlDbType.VarChar).Value = Lastname
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = username
            cmd.Parameters.AddWithValue("@Firstname", SqlDbType.VarChar).Value = Firstname
            cmd.Parameters.AddWithValue("@AccessType", SqlDbType.VarChar).Value = accesstype
            cmd.Parameters.AddWithValue("@UsernameOriginal", SqlDbType.VarChar).Value = UsernameOriginal



            Connection.Open()
            cmd.ExecuteNonQuery()
            Console.WriteLine(sql)

        End Using
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddAppLogs(username As String, buttonname As String)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblAppLogs select getdate(), @Username, @buttonname"
        Using Connection As New SqlConnection(sqlConnectionString),
                        cmd As New SqlCommand(strSQL, Connection)
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = username
            cmd.Parameters.AddWithValue("@buttonname", SqlDbType.VarChar).Value = buttonname

            Connection.Open()
            cmd.ExecuteNonQuery()
            Console.WriteLine(strSQL)
        End Using
        Call DisConnectSQLServer()
    End Sub

End Module
