Imports SistFoncreagro.BussinessEntities
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class DetalleReqCotizacionRepository : Inherits MasterDataAccess : Implements IDetalleReqCotizacionRepository

    Dim detalleRequerimiento As IDetalleRequerimientoRepository
    Sub New()
        detalleRequerimiento = New DetalleRequerimientoRepository
    End Sub
    Public Sub SaveDetalleReqCotizacion(ByVal detalleReqCoti As BussinessEntities.DetalleReqCotizacion) Implements IDetalleReqCotizacionRepository.SaveDetalleReqCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDetalleReqCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", detalleReqCoti.IdCotizacion)
        command.Parameters.AddWithValue("IdDetalleRequerimiento", detalleReqCoti.IdDetalleRequerimiento)
        command.Parameters.AddWithValue("IdCatalogo", detalleReqCoti.IdCatalogo)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveDetalleReqCotizacion1(ByVal detalleReqCoti As System.Collections.Generic.List(Of BussinessEntities.DetalleReqCotizacion), ByVal idCotizacion As Integer) Implements IDetalleReqCotizacionRepository.SaveDetalleReqCotizacion1
        For Each det As DetalleReqCotizacion In detalleReqCoti
            det.IdCotizacion = idCotizacion
            SaveDetalleReqCotizacion(det)
        Next
    End Sub
    Public Function GetAllDetalleRequerimientoCotizacionByIdCotizacion(ByVal idCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleReqCotizacion) Implements IDetalleReqCotizacionRepository.GetAllDetalleRequerimientoCotizacionByIdCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleRequerimientoCotizacionByIdCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", idCotizacion)
        Return SelectObjectFactoryDetalleReqCotizacion(command)
    End Function
    Private Function SelectObjectFactoryDetalleReqCotizacion(ByVal command As SqlCommand) As List(Of DetalleReqCotizacion)
        Dim listaDetalleReqCotizacion As New List(Of DetalleReqCotizacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim detalleReqCotizacion As New DetalleReqCotizacion
                With detalleReqCotizacion
                    .IdDetalleReqCotizacion = reader.GetInt32(0)
                    .IdCotizacion = reader.GetInt32(1)
                    .IdDetalleRequerimiento = reader.GetInt32(2)
                    .IdCatalogo = reader.GetInt32(3)
                End With
                detalleReqCotizacion.DetalleReq = detalleRequerimiento.GetDetalleRequerimientoByIdDetalleReq(reader.GetInt32(2))
                listaDetalleReqCotizacion.Add(detalleReqCotizacion)
            End While
        End Using
        Return listaDetalleReqCotizacion
    End Function

    Public Sub SaveItemDetalleReqCotizacon(ByVal detalleReqCoti As BussinessEntities.DetalleReqCotizacion) Implements IDetalleReqCotizacionRepository.SaveItemDetalleReqCotizacon
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveItemDetalleReqCotizacon")
        command.Parameters.AddWithValue("IdCotizacion", detalleReqCoti.IdCotizacion)
        command.Parameters.AddWithValue("IdDetalleRequerimiento", detalleReqCoti.IdDetalleRequerimiento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub DeleteItemDetalleReqCotizacion(ByVal IdDetalleReqCotizacion As Integer) Implements IDetalleReqCotizacionRepository.DeleteItemDetalleReqCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteItemDetalleReqCotizacion")
        command.Parameters.AddWithValue("IdDetalleReqCotizacion", IdDetalleReqCotizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
