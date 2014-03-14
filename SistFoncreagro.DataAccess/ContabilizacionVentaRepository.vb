Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ContabilizacionVentaRepository : Inherits MasterDataAccess : Implements IContabilizacionVentaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ContabilizacionVenta)
        Dim lista As New List(Of ContabilizacionVenta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ContabilizacionVenta As New ContabilizacionVenta() With
                {
                .IdContaVenta = reader.GetValue(0),
                .IdClasificacion = reader.GetValue(1),
                .IdProyecto = reader.GetValue(2),
                .Estado = reader.GetValue(5)
                }
                If Not (reader.IsDBNull(3)) Then
                    _ContabilizacionVenta.IdPlanVentaInterna = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _ContabilizacionVenta.IdPlanVentaExterna = reader.GetValue(4)
                End If
                lista.Add(_ContabilizacionVenta)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromCONTABILIZACIONVENTA() As System.Collections.Generic.List(Of BussinessEntities.ContabilizacionVenta) Implements IContabilizacionVentaRepository.GetAllFromCONTABILIZACIONVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCONTABILIZACIONVENTA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCONTABILIZACIONVENTAByIdContaVenta(ByVal IdContaVenta As Integer) As BussinessEntities.ContabilizacionVenta Implements IContabilizacionVentaRepository.GetCONTABILIZACIONVENTAByIdContaVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONTABILIZACIONVENTAByIdContaVenta")
        command.Parameters.AddWithValue("IdContaVenta", IdContaVenta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveCONTABILIZACIONVENTA(ByVal _ContabilizacionVenta As BussinessEntities.ContabilizacionVenta) Implements IContabilizacionVentaRepository.SaveCONTABILIZACIONVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONTABILIZACIONVENTA")
        command.Parameters.AddWithValue("IdClasificacion", _ContabilizacionVenta.IdClasificacion)
        command.Parameters.AddWithValue("IdContaVenta", _ContabilizacionVenta.IdContaVenta)
        command.Parameters.AddWithValue("IdPlanVentaExterna", _ContabilizacionVenta.IdPlanVentaExterna)
        command.Parameters.AddWithValue("IdPlanVentaInterna", _ContabilizacionVenta.IdPlanVentaInterna)
        command.Parameters.AddWithValue("IdProyecto", _ContabilizacionVenta.IdProyecto)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoCONTABILIZACIONVENTA(ByVal IdContaVenta As Integer) Implements IContabilizacionVentaRepository.UpdateEstadoCONTABILIZACIONVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCONTABILIZACIONVENTA")
        command.Parameters.AddWithValue("IdContaVenta", IdContaVenta)
        MyBase.ExecuteReader(command)
    End Sub
End Class
