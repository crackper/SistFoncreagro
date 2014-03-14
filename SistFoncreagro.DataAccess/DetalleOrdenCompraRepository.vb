Imports System.Data.SqlClient
Imports System.Data.Common
Imports SistFoncreagro.BussinessEntities

Public Class DetalleOrdenCompraRepository : Inherits MasterDataAccess : Implements IDetalleOrdenCompraRepository
    Dim catalogo As ICatalogoRepository
    Dim unidadMed As IUnidadMedidaRepository
    Sub New()
        catalogo = New CatalogoRepository
        unidadMed = New UnidadMedidaRepository
    End Sub

    Public Function GetAllFromDetalleOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra) Implements IDetalleOrdenCompraRepository.GetAllFromDetalleOrdenCompraByIdOrdenCompra
        Dim command As SqlCommand =
         MyBase.CreateSPCommand("GetAllFromDetalleOrdenCompraByIdOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", idOrdenCompra)
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateDetalleOrdenCompra(ByVal detalleOrdenCompra As BussinessEntities.DetalleOrdenCompra) Implements IDetalleOrdenCompraRepository.UpdateDetalleOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateDetalleOrdenCompra")
        command.Parameters.AddWithValue("IdCotizacion", detalleOrdenCompra.IdCatalogo)
        command.Parameters.AddWithValue("IdDetalleRequerimiento", detalleOrdenCompra.IdDetalleRequerimiento)
        command.Parameters.AddWithValue("IdProveedor", detalleOrdenCompra.IdUnidad)
        command.Parameters.AddWithValue("IdDetalleOrdenCompra", detalleOrdenCompra.IdDetalleOrdenCompra)
        command.Parameters.AddWithValue("Precio", detalleOrdenCompra.PrecioCompra)
        command.Parameters.AddWithValue("AfectoIgv", detalleOrdenCompra.AfectoIgv)
        command.Parameters.AddWithValue("IdcCosto", detalleOrdenCompra.IdCentroCosto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateDetalleOrdenCompra1(ByVal detalle As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra)) Implements IDetalleOrdenCompraRepository.UpdateDetalleOrdenCompra1
        For Each det As DetalleOrdenCompra In detalle
            UpdateDetalleOrdenCompra(det)
        Next
    End Sub

    Public Sub UpdateDetalleOrdenCompraRecepcion(ByVal detalleOrdenCompra As BussinessEntities.DetalleOrdenCompra) Implements IDetalleOrdenCompraRepository.UpdateDetalleOrdenCompraRecepcion
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateDetalleOrdenCompraRecepcion")
        command.Parameters.AddWithValue("IdDetalleOrdenCompra", detalleOrdenCompra.IdDetalleOrdenCompra)
        command.Parameters.AddWithValue("CantidadComprada", detalleOrdenCompra.CantidadComprada)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateDetalleOrdenCompraRecepcion1(ByVal detalle As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra)) Implements IDetalleOrdenCompraRepository.UpdateDetalleOrdenCompraRecepcion1
        For Each det As DetalleOrdenCompra In detalle
            UpdateDetalleOrdenCompraRecepcion(det)
        Next
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleOrdenCompra)
        Dim listaDetalleOrdenCompra As New List(Of DetalleOrdenCompra)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim detalleOrdenCompra As New DetalleOrdenCompra()
                With detalleOrdenCompra
                    .IdDetalleOrdenCompra = reader.GetInt32(0)
                    .IdOrdenCompra = reader.GetInt32(1)
                    .IdCatalogo = reader.GetInt32(2)
                    .IdUnidad = reader.GetInt32(3)
                    .CantidadSolicitada = reader.GetDecimal(5)
                    .PrecioCompra = reader.GetDecimal(6)
                    .AfectoIgv = reader.GetBoolean(7)
                    .CantidadComprada = reader.GetDecimal(8)
                    .IdCentroCosto = reader.GetInt32(10)
                    .IdDetalleRequerimiento = reader.GetInt32(11)
                End With
                detalleOrdenCompra.catalogo = catalogo.GetAllFromCatalogoByIdCatalogo(reader.GetInt32(2))
                detalleOrdenCompra.unidad = unidadMed.GetAllFromUnidadMedidaByIdUnidadMedida(reader.GetInt32(3))
                If Not reader.IsDBNull(4) Then
                    detalleOrdenCompra.Observacion = reader.GetString(4)
                End If
                If Not reader.IsDBNull(9) Then
                    detalleOrdenCompra.CantidadPendiente = reader.GetBoolean(9)
                End If
                listaDetalleOrdenCompra.Add(detalleOrdenCompra)
            End While
        End Using
        Return listaDetalleOrdenCompra
    End Function

    Private Function SelectObjectFactoryDetFact(ByVal command As SqlCommand) As List(Of DetalleOrdenCompra)
        Dim listaDetalleOrdenCompra As New List(Of DetalleOrdenCompra)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim detalleOrdenCompra As New DetalleOrdenCompra()
                With detalleOrdenCompra
                    .IdDetalleOrdenCompra = reader.GetInt32(0)
                    .IdOrdenCompra = reader.GetInt32(1)
                    If Not reader.IsDBNull(2) Then
                        .DescripcionGen = reader.GetString(2)
                    End If
                    .CantidadComprada = reader.GetDecimal(3)
                    .EstadoFactura = reader.GetBoolean(4)
                    .IdCentroCosto = reader.GetInt32(5)
                    .PrecioCompra = reader.GetDecimal(6)
                End With
                listaDetalleOrdenCompra.Add(detalleOrdenCompra)
            End While
        End Using
        Return listaDetalleOrdenCompra
    End Function

    Public Function GetAllFromDetalleByIdCCosto(ByVal IdCcosto As Integer, ByVal idOc As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra) Implements IDetalleOrdenCompraRepository.GetAllFromDetalleByIdCCosto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDetalleByIdCCosto")
        command.Parameters.AddWithValue("IdCcosto", IdCcosto)
        command.Parameters.AddWithValue("IdOrdenCompra", idOc)
        Return SelectObjectFactoryDetFact(command)
    End Function
End Class
