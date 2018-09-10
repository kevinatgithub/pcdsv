Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Database

    Public connection As MySqlConnection
    Public host As String = "localhost"
    Public user As String = "root"
    Public password As String = ""
    Public database As String = "nbbnets_merge"
    Public command As MySqlCommand

    Public Shared db As New Database

    Sub openConnection()
        If connection IsNot Nothing Then
            connection.Close()
        End If
        connection = New MySqlConnection
        connection.ConnectionString = "server=" & host & ";userid=" & user & ";password=" & password & ";database=" & database

        Try
            connection.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function execute(query As String)
        openConnection()
        Dim reader As MySqlDataReader
        Try
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            Return reader
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function executeDataSet(query As String)
        openConnection()
        Dim adapter As MySqlDataAdapter
        Try
            adapter = New MySqlDataAdapter(query, connection)
            Return adapter
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function saveFinger(seqno As String, converted As Byte(), mode As Integer)
        openConnection()
        Dim sql As String
        If mode = 0 Then
            sql = "UPDATE donor SET lfinger = @finger WHERE seqno = @seqno"
        Else
            sql = "UPDATE donor SET rfinger = @finger WHERE seqno = @seqno"
        End If
        Dim cmd As New MySqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@finger", converted)
        cmd.Parameters.AddWithValue("@seqno", seqno)
        cmd.ExecuteNonQuery()

        Return True
    End Function

    Public Function hash(input As String)
        Using hasher As MD5 = MD5.Create()
            ' Convert to byte array and get hash
            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(input))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using
    End Function
End Class
