Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class OrdenCompraBL : Implements IOrdenCompraBL
    Private mOrdenCompra As New OrdenCompra
    Private mListaLlenar As New List(Of OrdenCompra)
    Dim factoryRepository As IOrdenCompraRepository
    Sub New()
        factoryRepository = New OrdenCompraRepository
    End Sub
    Public Function GetAllFromOrdenCompraByIdComprador(ByVal idComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraByIdComprador
        Return factoryRepository.GetAllFromOrdenCompraByIdComprador(idComprador)
    End Function

    Public Function GetOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Integer, ByVal detalle As Boolean) As BussinessEntities.OrdenCompra Implements IOrdenCompraBL.GetOrdenCompraByIdOrdenCompra
        Return factoryRepository.GetOrdenCompraByIdOrdenCompra(idOrdenCompra, detalle)
    End Function

    Public Sub UpdateOrdenCompra(ByVal ordenCompra As BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.UpdateOrdenCompra
        factoryRepository.UpdateOrdenCompra(ordenCompra)
    End Sub

    Public Function GetAllFromDetalleOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra) Implements IOrdenCompraBL.GetAllFromDetalleOrdenCompraByIdOrdenCompra
        Return factoryRepository.GetAllFromDetalleOrdenCompraByIdOrdenCompra(idOrdenCompra)
    End Function


    Public Sub UpdateOcEnviarProveedor(ByVal idOrdenCompra As Integer, ByVal idLugarRecepcion As Integer, ByVal fechaEntregaEjecucion As Date) Implements IOrdenCompraBL.UpdateOcEnviarProveedor
        factoryRepository.UpdateOcEnviarProveedor(idOrdenCompra, idLugarRecepcion, fechaEntregaEjecucion)
    End Sub

    Public Function GetAllFromOrdenCompraEnviadasRecepcionadas() As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraEnviadasRecepcionadas
        Return factoryRepository.GetAllFromOrdenCompraEnviadasRecepcionadas
    End Function

    Public Function GetAllFromOrdenCompraControlPatrimonial() As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraControlPatrimonial
        mListaLlenar = GetAllFromOrdenCompraEnviadasRecepcionadas().FindAll(Function(mOrdenCompra) mOrdenCompra.IdProveedor <> 3)
        Return mListaLlenar
    End Function
    Public Function GetAllFromOrdenCompraInternas() As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraInternas
        mListaLlenar = GetAllFromOrdenCompraEnviadasRecepcionadas().FindAll(Function(mOrdenCompra) mOrdenCompra.IdProveedor = 3)
        Return mListaLlenar
    End Function

    Public Sub SaveRecepcionOrdenCompra(ByVal ordenCompra As BussinessEntities.OrdenCompra, ByVal tipoRecepcion As Boolean) Implements IOrdenCompraBL.SaveRecepcionOrdenCompra
        factoryRepository.SaveRecepcionOrdenCompra(ordenCompra, tipoRecepcion)
    End Sub

    Public Function GetAllFromOrdenCompraPorAprobarByIdResponsable(ByVal idResponsable As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraPorAprobarByIdResponsable
        Return factoryRepository.GetAllFromOrdenCompraPorAprobarByIdResponsable(idResponsable)
    End Function

    Public Sub AprobarOrdenCompra(ByVal IdOrdenCompra As Integer, ByVal IdPersonal As Integer) Implements IOrdenCompraBL.AprobarOrdenCompra
        factoryRepository.AprobarOrdenCompra(IdOrdenCompra, IdPersonal)
    End Sub

    Public Function GetAllFromOrdenCompraAprobadasEnviadasByIdComprador(ByVal IdComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraAprobadasEnviadasByIdComprador
        Return factoryRepository.GetAllFromOrdenCompraAprobadasEnviadasByIdComprador(IdComprador)
    End Function
    Public Sub AnularOrdenCompra(ByVal idOrdenCompra As Integer, ByVal idPersonal As Integer, ByVal Motivo As String, ByVal tipo As Integer) Implements IOrdenCompraBL.AnularOrdenCompra
        factoryRepository.AnularOrdenCompra(idOrdenCompra, idPersonal, Motivo, tipo)
    End Sub

    Public Function GetAllFromOrdenCompraEnviadasRecepcionadasByTipo(ByVal tipo As String) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraEnviadasRecepcionadasByTipo
        Return factoryRepository.GetAllFromOrdenCompraEnviadasRecepcionadasByTipo(tipo)
    End Function

    Public Function GetAllFromOrdenCompraByIdResponsableAprobar(ByVal IdPersonaAprueba As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompraByIdResponsableAprobar
        Return factoryRepository.GetAllFromOrdenCompraByIdResponsableAprobar(IdPersonaAprueba)
    End Function

    Public Function GetAllFromDetalleByIdCCosto(ByVal IdCcosto As Integer, ByVal IdOrden As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra) Implements IOrdenCompraBL.GetAllFromDetalleByIdCCosto
        Return factoryRepository.GetAllFromDetalleByIdCCosto(IdCcosto, IdOrden)
    End Function

    Public Sub SolicitarAprobacion(ByVal idOrdenCompra As Integer, ByVal IdTipoPago As Integer, ByVal anticipo As Decimal) Implements IOrdenCompraBL.SolicitarAprobacion
        factoryRepository.SolicitarAprobacion(idOrdenCompra, IdTipoPago, anticipo)
    End Sub

    Public Function GetAllFromOrdenCompra(ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraBL.GetAllFromOrdenCompra
        Return factoryRepository.GetAllFromOrdenCompra(parametro)
    End Function
End Class
