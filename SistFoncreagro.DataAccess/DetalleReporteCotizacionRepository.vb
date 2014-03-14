Imports System.Data.SqlClient
Imports System.Data.Common
Imports SistFoncreagro.BussinessEntities
Public Class DetalleReporteCotizacionRepository : Inherits MasterDataAccess : Implements IDetalleReporteCotizacionRepository


    Public Sub DeleteDetalleReporteCotizacion(ByVal IdDetalleReporteCotizacion As Integer) Implements IDetalleReporteCotizacionRepository.DeleteDetalleReporteCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDetalleReporteCotizacion")
        command.Parameters.AddWithValue("IdDetalleReporteCotizacion", IdDetalleReporteCotizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveDetalleReporteCotizacion(ByVal detalleReporteCotizacion As BussinessEntities.DetalleReporteCotizacion) Implements IDetalleReporteCotizacionRepository.SaveDetalleReporteCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDetalleReporteCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", detalleReporteCotizacion.IdCotizacion)
        command.Parameters.AddWithValue("Texto", detalleReporteCotizacion.Texto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateDetalleReporteCotizacion(ByVal detalleReporteCotizacion As BussinessEntities.DetalleReporteCotizacion) Implements IDetalleReporteCotizacionRepository.UpdateDetalleReporteCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateDetalleReporteCotizacion")
        command.Parameters.AddWithValue("IdDetalleReporteCotizacion", detalleReporteCotizacion.IdDetalleReporteCotizacion)
        command.Parameters.AddWithValue("Texto", detalleReporteCotizacion.Texto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromDetalleReporteCotizacionByIdCotizacion(ByVal idCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleReporteCotizacion) Implements IDetalleReporteCotizacionRepository.GetAllFromDetalleReporteCotizacionByIdCotizacion
        Dim command As SqlCommand =
       MyBase.CreateSPCommand("GetAllFromDetalleReporteCotizacionByIdCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", idCotizacion)

        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleReporteCotizacion)
        Dim listaDetalleReporteCotizacion As New List(Of DetalleReporteCotizacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim detalleReporteCotizacion As New DetalleReporteCotizacion()
                With detalleReporteCotizacion
                    .IdDetalleReporteCotizacion = reader.GetInt32(0)
                    .IdCotizacion = reader.GetInt32(1)
                    .Texto = reader.GetString(2)
                End With
                listaDetalleReporteCotizacion.Add(detalleReporteCotizacion)
            End While
        End Using
        Return listaDetalleReporteCotizacion
    End Function
End Class
