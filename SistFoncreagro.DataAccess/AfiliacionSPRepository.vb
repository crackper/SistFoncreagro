Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AfiliacionSPRepository : Inherits MasterDataAccess : Implements IAfiliacionSPRepository

    Public Function GetAFILIACIONSPByIdAfiliacionSPAndIdPersonalAndIdSistemaPensiones(ByVal IdAfiliacionSP As Integer, ByVal IdPersonal As Integer, ByVal IdSistemaPensiones As Integer) As BussinessEntities.AfiliacionSP Implements IAfiliacionSPRepository.GetAFILIACIONSPByIdAfiliacionSPAndIdPersonalAndIdSistemaPensiones
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAFILIACIONSPByIdAfiliacionSPAndIdPersonalAndIdSistemaPensiones")
        command.Parameters.AddWithValue("IdAfiliacionSP", IdAfiliacionSP)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("IdSistemaPensiones", IdSistemaPensiones)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetAFILIACIONSPByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPRepository.GetAFILIACIONSPByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAFILIACIONSPByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAFILIACIONSPByIdPersonalAndActiva(ByVal IdPersonal As Integer) As BussinessEntities.AfiliacionSP Implements IAfiliacionSPRepository.GetAFILIACIONSPByIdPersonalAndActiva
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAFILIACIONSPByIdPersonalAndActiva")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetAFILIACIONSPByIdSistemaPensiones(ByVal IdSistemaPensiones As Integer) As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPRepository.GetAFILIACIONSPByIdSistemaPensiones
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAFILIACIONSPByIdSistemaPensiones")
        command.Parameters.AddWithValue("IdSistemaPensiones", IdSistemaPensiones)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAFILIACIONSPByIdSistemaPensionesAndActivos(ByVal IdSistemaPensiones As Integer) As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPRepository.GetAFILIACIONSPByIdSistemaPensionesAndActivos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAFILIACIONSPByIdSistemaPensionesAndActivos")
        command.Parameters.AddWithValue("IdSistemaPensiones", IdSistemaPensiones)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromAFILIACIONSP() As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPRepository.GetAllFromAFILIACIONSP
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromAFILIACIONSP")
        Return SelectObjectFactory(command)
    End Function

    Sub DeleteAfiliacionSP(ByVal IdAfiliacionSP As Integer, ByVal IdPersonal As Integer, ByVal IdSistemaPensiones As Integer) Implements IAfiliacionSPRepository.DeleteAfiliacionSP
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAfiliacionSP")
        command.Parameters.AddWithValue("IdAfiliacionSP", IdAfiliacionSP)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("IdSistemaPensiones", IdSistemaPensiones)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function SaveAFILIACIONSP(ByVal afiliacionSP As BussinessEntities.AfiliacionSP) As Integer Implements IAfiliacionSPRepository.SaveAFILIACIONSP
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAFILIACIONSP")
        command.Parameters.AddWithValue("CUSPP", afiliacionSP.CUSPP)
        command.Parameters.AddWithValue("Estado", afiliacionSP.Estado)
        command.Parameters.AddWithValue("FechaAfiliacion", afiliacionSP.FechaAfiliacion)
        command.Parameters.AddWithValue("IdAfiliacionSP", afiliacionSP.IdAfiliacionSP)
        command.Parameters.AddWithValue("IdPersonal", afiliacionSP.IdPersonal)
        command.Parameters.AddWithValue("IdSistemaPensiones", afiliacionSP.IdSistemaPensiones)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AfiliacionSP)
        Dim lista As New List(Of AfiliacionSP)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New AfiliacionSP
                If Not reader.IsDBNull(reader.GetOrdinal("CUSPP")) Then
                    entity.CUSPP = reader.GetValue(reader.GetOrdinal("CUSPP"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Estado")) Then
                    entity.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaAfiliacion")) Then
                    entity.FechaAfiliacion = reader.GetValue(reader.GetOrdinal("FechaAfiliacion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdAfiliacionSP")) Then
                    entity.IdAfiliacionSP = reader.GetValue(reader.GetOrdinal("IdAfiliacionSP"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPersonal")) Then
                    entity.IdPersonal = reader.GetValue(reader.GetOrdinal("IdPersonal"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdSistemaPensiones")) Then
                    entity.IdSistemaPensiones = reader.GetValue(reader.GetOrdinal("IdSistemaPensiones"))
                    Dim spRepository As New SistemaDePensionesRepository
                    entity.SistemaDePensionesEntity = New SistemaDePensiones
                    entity.SistemaDePensionesEntity = spRepository.GetSistemaDePensionesByIdSistemaPensiones(entity.IdSistemaPensiones)
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
