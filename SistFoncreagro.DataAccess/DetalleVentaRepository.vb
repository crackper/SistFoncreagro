Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DetalleVentaRepository : Inherits MasterDataAccess : Implements IDetalleVentaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleVenta)
        Dim lista As New List(Of DetalleVenta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DetalleVenta As New DetalleVenta() With
                {
                 .IdDetalleVenta = reader.GetValue(0),
                 .IdVenta = reader.GetValue(1),
                 .Cantidad = reader.GetValue(2),
                 .PrecioUnitario = reader.GetValue(3),
                 .Glosa = reader.GetValue(5),
                 .Total = reader.GetValue(6)
                }
                If Not (reader.IsDBNull(6)) Then
                    _DetalleVenta.IdSemoviente = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _DetalleVenta.IdMotivoVenta = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _DetalleVenta.IdCatVenta = reader.GetValue(4)
                End If

                lista.Add(_DetalleVenta)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteDETALLEVENTA(ByVal IdDetalleVenta As Integer) Implements IDetalleVentaRepository.DeleteDETALLEVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDETALLEVENTA")
        command.Parameters.AddWithValue("IdDetalleVenta", IdDetalleVenta)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDETALLEVENTAByIdDetalleVenta(ByVal IdDetalleVenta As Integer) As BussinessEntities.DetalleVenta Implements IDetalleVentaRepository.GetDETALLEVENTAByIdDetalleVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETALLEVENTAByIdDetalleVenta")
        command.Parameters.AddWithValue("IdDetalleVenta", IdDetalleVenta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetDETALLEVENTAByIdVenta(ByVal IdVenta As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleVenta) Implements IDetalleVentaRepository.GetDETALLEVENTAByIdVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETALLEVENTAByIdVenta")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveDETALLEVENTA(ByVal _DetalleVenta As BussinessEntities.DetalleVenta) Implements IDetalleVentaRepository.SaveDETALLEVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDETALLEVENTA")
        command.Parameters.AddWithValue("Cantidad", _DetalleVenta.Cantidad)
        command.Parameters.AddWithValue("Glosa", _DetalleVenta.Glosa)
        command.Parameters.AddWithValue("IdCatVenta", _DetalleVenta.IdCatVenta)
        command.Parameters.AddWithValue("IdDetalleVenta", _DetalleVenta.IdDetalleVenta)
        command.Parameters.AddWithValue("IdMotivoVenta", _DetalleVenta.IdMotivoVenta)
        command.Parameters.AddWithValue("IdSemoviente", _DetalleVenta.IdSemoviente)
        command.Parameters.AddWithValue("IdVenta", _DetalleVenta.IdVenta)
        command.Parameters.AddWithValue("PrecioUnitario", _DetalleVenta.PrecioUnitario)
        command.Parameters.AddWithValue("Total", _DetalleVenta.Total)
        MyBase.ExecuteNonQuery(command)

    End Sub
End Class
