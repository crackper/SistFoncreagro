Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities
Public Class DetalleComprobanteRepository : Inherits MasterDataAccess : Implements IDetalleComprobanteRepository
    Public Sub SaveDetalleComprobante(ByVal detalleComprobante As BussinessEntities.DetalleComprobante) Implements IDetalleComprobanteRepository.SaveDetalleComprobante
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDetalleComprobante")
        command.Parameters.AddWithValue("IdOcxFactura", detalleComprobante.IdOcxfactura)
        command.Parameters.AddWithValue("IdCatalogo", detalleComprobante.IdCatalogo)
        command.Parameters.AddWithValue("IdCentroCosto", detalleComprobante.IdCentroCosto)
        command.Parameters.AddWithValue("Cantidad", detalleComprobante.Cantidad)
        command.Parameters.AddWithValue("Precio", detalleComprobante.Precio)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub DeleteDetalleComprobante(ByVal idDetalleComprobante As Integer) Implements IDetalleComprobanteRepository.DeleteDetalleComprobante
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDetalleComprobante")
        command.Parameters.AddWithValue("IdDetalleComprobante", idDetalleComprobante)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactoryComprobante(ByVal command As SqlCommand) As List(Of DetalleComprobante)
        Dim lista As New List(Of DetalleComprobante)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim detalle As New DetalleComprobante() With
                    {.IdDetalleComprobante = reader.GetInt32(0),
                     .Cantidad = reader.GetDecimal(1),
                     .Precio = reader.GetDecimal(2),
                     .NombreCatalogo = reader.GetString(3),
                     .NombreCentroCosto = reader.GetString(4)
                    }
                lista.Add(detalle)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromDetalleComprobanteByIdOcxFactura(ByVal idOcxFactura As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleComprobante) Implements IDetalleComprobanteRepository.GetAllFromDetalleComprobanteByIdOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDetalleComprobanteByIdOcxFactura")
        command.Parameters.AddWithValue("IdOcxFactura", idOcxFactura)
        Return SelectObjectFactoryComprobante(command)
    End Function
End Class
