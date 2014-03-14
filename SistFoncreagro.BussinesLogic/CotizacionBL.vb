Imports SistFoncreagro.DataAccess
Imports SistFoncreagro.BussinessEntities

Public Class CotizacionBL : Implements ICotizacionBL
    Dim factoryRepository As ICotizacionRepository
    Public Sub New()
        factoryRepository = New CotizacionRepository
    End Sub
    Public Sub SaveCotizacion(ByVal coti As BussinessEntities.Cotizacion) Implements ICotizacionBL.SaveCotizacion
        factoryRepository.SaveCotizacion(coti)
    End Sub

    Public Sub GenerarOrdenCompraOfIdCotizacion(ByVal idCotizacion As Integer) Implements ICotizacionBL.GenerarOrdenCompraOfIdCotizacion
        factoryRepository.GenerarOrdenCompraOfIdCotizacion(idCotizacion)
    End Sub

    Public Function GetFromCotizacionByIdCotizacion(ByVal idCotizacion As Integer) As BussinessEntities.Cotizacion Implements ICotizacionBL.GetFromCotizacionByIdCotizacion
        Return factoryRepository.GetFromCotizacionByIdCotizacion(idCotizacion)
    End Function

    Public Sub UpdateCotizacion(ByVal cotizacion As BussinessEntities.Cotizacion) Implements ICotizacionBL.UpdateCotizacion
        factoryRepository.UpdateCotizacion(cotizacion)
    End Sub

    Public Function GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot(ByVal idCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleReqCotizacion) Implements ICotizacionBL.GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot
        Return factoryRepository.GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot(idCotizacion)
    End Function

    Public Function GetAllFromCotizacionesByIdComprador(ByVal idComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.Cotizacion) Implements ICotizacionBL.GetAllFromCotizacionesByIdComprador
        Return factoryRepository.GetAllFromCotizacionesByIdComprador(idComprador)
    End Function

    Public Sub SaveItemDetalleReqCotizacon(ByVal detalleReqCoti As BussinessEntities.DetalleReqCotizacion) Implements ICotizacionBL.SaveItemDetalleReqCotizacon
        factoryRepository.SaveItemDetalleReqCotizacon(detalleReqCoti)
    End Sub

    Public Sub DeleteItemDetalleReqCotizacion(ByVal IdDetalleReqCotizacion As Integer) Implements ICotizacionBL.DeleteItemDetalleReqCotizacion
        factoryRepository.DeleteItemDetalleReqCotizacion(IdDetalleReqCotizacion)
    End Sub

    Public Sub FinalizarCotizacion(ByVal IdContizacion As Integer) Implements ICotizacionBL.FinalizarCotizacion
        factoryRepository.FinalizarCotizacion(IdContizacion)
    End Sub

    Public Sub ModificarCotizacionCompleta(ByVal IdContizacion As Integer) Implements ICotizacionBL.ModificarCotizacionCompleta
        factoryRepository.ModificarCotizacionCompleta(IdContizacion)
    End Sub

    Public Sub AnularCotizacion(ByVal IdContizacion As Integer) Implements ICotizacionBL.AnularCotizacion
        factoryRepository.AnularCotizacion(IdContizacion)
    End Sub

    Public Function GetAllFromCotizacionesByIdResponsable(ByVal idResponsable As Integer) As System.Collections.Generic.List(Of BussinessEntities.Cotizacion) Implements ICotizacionBL.GetAllFromCotizacionesByIdResponsable
        Return factoryRepository.GetAllFromCotizacionesByIdResponsable(idResponsable)
    End Function

    Public Sub SolicitarAprobacionSoulSource(ByVal IdContizacion As Integer, ByVal IdRazon As Integer) Implements ICotizacionBL.SolicitarAprobacionSoulSource
        factoryRepository.SolicitarAprobacionSoulSource(IdContizacion, IdRazon)
    End Sub

    Public Sub AprobarSoulSource(ByVal IdContizacion As Integer, ByVal IdPersonal As Integer) Implements ICotizacionBL.AprobarSoulSource
        factoryRepository.AprobarSoulSource(IdContizacion, IdPersonal)
    End Sub

    Public Sub AnularSoulSource(ByVal IdContizacion As Integer, ByVal IdPersonal As Integer) Implements ICotizacionBL.AnularSoulSource
        factoryRepository.AnularSoulSource(IdContizacion, IdPersonal)
    End Sub
End Class
