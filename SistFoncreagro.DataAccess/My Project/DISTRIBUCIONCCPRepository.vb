Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DISTRIBUCIONCCPRepository : Inherits MasterDataAccess : Implements IDISTRIBUCIONCCPRepository

    Public Function GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha(ByVal IdPeriodoLaboral As Integer, ByVal fecha As Date) As BussinessEntities.DistribucionCCP Implements IDISTRIBUCIONCCPRepository.GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Fecha", fecha)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetDISTRIBUCIONCCPByIdDistribucionCCP(ByVal IdDistribucionCCP As Integer) As BussinessEntities.DistribucionCCP Implements IDISTRIBUCIONCCPRepository.GetDISTRIBUCIONCCPByIdDistribucionCCP
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDISTRIBUCIONCCPByIdDistribucionCCP")
        command.Parameters.AddWithValue("IdDistribucionCCP", IdDistribucionCCP)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetDISTRIBUCIONCCPByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCP) Implements IDISTRIBUCIONCCPRepository.GetDISTRIBUCIONCCPByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDISTRIBUCIONCCPByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteDISTRIBUCIONCCP(ByVal IdDistribucionCCP As Integer) Implements IDISTRIBUCIONCCPRepository.DeleteDISTRIBUCIONCCP
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDISTRIBUCIONCCP")
        command.Parameters.AddWithValue("IdDistribucionCCP", IdDistribucionCCP)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DistribucionCCP)
        Dim lista As New List(Of DistribucionCCP)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New DistribucionCCP

                If Not reader.IsDBNull(reader.GetOrdinal("IdDistribucionCCP")) Then
                    entity.IdDistribucionCCP = reader.GetValue(reader.GetOrdinal("IdDistribucionCCP"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaIni")) Then
                    entity.FechaIni = reader.GetValue(reader.GetOrdinal("FechaIni"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Public Function SaveDISTRIBUCIONCCP(ByVal DistribucionPPC As DistribucionCCP) As Integer Implements IDISTRIBUCIONCCPRepository.SaveDISTRIBUCIONCCP
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDISTRIBUCIONCCP")
        command.Parameters.AddWithValue("IdDistribucionCCP", DistribucionPPC.IdDistribucionCCP)
        command.Parameters.AddWithValue("IdPeriodoLaboral", DistribucionPPC.IdPeriodoLaboral)
        command.Parameters.AddWithValue("FechaIni", DistribucionPPC.FechaIni)

        'command.Parameters("idCargo").Direction = ParameterDirection.Output
        'MyBase.ExecuteNonQuery(command)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If
            Else
                i = 0 'command.Parameters("idCargo").Value
            End If
        End Using

        Return i
        'command.ExecuteReader(CommandBehavior.SingleRow).Item(0)
    End Function

End Class
