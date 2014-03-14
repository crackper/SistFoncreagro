Imports System.Data.SqlClient
Imports System.Configuration

Public Class MasterDataAccess
    Dim cnx As SqlConnection

    Public Sub New()
        cnx = New SqlConnection
        cnx.ConnectionString = ConfigurationManager.ConnectionStrings("cnx").ConnectionString
    End Sub

    Public Function CreateSPCommand(ByVal query As String) As SqlCommand
        Dim command As New SqlCommand
        command.CommandText = query
        command.CommandType = CommandType.StoredProcedure
        command.Connection = cnx
        Return command
    End Function

    Public Function ExecuteReader(ByVal command As SqlCommand) As SqlDataReader
        OpenCnx()
        Return command.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Sub ExecuteNonQuery(ByVal command As SqlCommand)
        OpenCnx()
        command.ExecuteNonQuery()
        CloseCnx()
    End Sub

    Private Sub OpenCnx()
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If
    End Sub

    Private Sub CloseCnx()
        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub
End Class
