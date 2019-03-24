Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text

Module Module1

    Sub Main()
        Dim sSourceData As String
        Dim tmpSource() As Byte
        Dim tmpHash() As Byte
        sSourceData = "s"
        'Create a byte array from source data.
        tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData)

        'Compute hash based on source data.
        tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpSource)
        Console.WriteLine(ByteArrayToString(tmpHash))

        sSourceData = "NotMySourceData"
        tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData)

        Dim tmpNewHash() As Byte
        Dim bEqual As Boolean = False
        tmpNewHash = New MD5CryptoServiceProvider().ComputeHash(tmpSource)

        If tmpNewHash.Length = tmpHash.Length Then
            Dim i As Integer
            Do While (i < tmpNewHash.Length) AndAlso (tmpNewHash(i) = tmpHash(i))
                i += 1
            Loop
            If i = tmpNewHash.Length Then
                bEqual = True
            End If
        End If

        If bEqual Then
            Console.WriteLine("The two hash values are the same")
        Else
            Console.WriteLine("The two hash values are not the same")
        End If
        Console.ReadLine()
    End Sub


    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
    End Function
End Module

Public Class frmUserControl


    Dim sSourceData As String
    Dim tmpSource() As Byte
    Dim tmpHash() As Byte


    Private Sub frmUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
'Time