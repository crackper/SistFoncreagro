Imports SistFoncreagro.BussinessEntities

Public Interface ICotizacionBL
    Sub SaveCotizacion(ByVal coti As Cotizacion)
    Sub SaveItemDetalleReqCotizacon(ByVal detalleReqCoti As DetalleReqCotizacion)
    Sub DeleteItemDetalleReqCotizacion(ByVal IdDetalleReqCotizacion As Int32)
    Sub UpdateCotizacion(ByVal cotizacion As Cotizacion)
    Sub FinalizarCotizacion(ByVal IdContizacion As Int32)
    Sub ModificarCotizacionCompleta(ByVal IdContizacion As Int32)
    Sub GenerarOrdenCompraOfIdCotizacion(ByVal idCotizacion As Int32)
    Sub AnularCotizacion(ByVal IdContizacion As Int32)
    Sub SolicitarAprobacionSoulSource(ByVal IdContizacion As Int32, ByVal IdRazon As Int32)
    Sub AprobarSoulSource(ByVal IdContizacion As Int32, ByVal IdPersonal As Int32)
    Sub AnularSoulSource(ByVal IdContizacion As Int32, ByVal IdPersonal As Int32)
    Function GetFromCotizacionByIdCotizacion(ByVal idCotizacion As Int32) As Cotizacion
    Function GetAllFromCotizacionesByIdComprador(ByVal idComprador As Int32) As List(Of Cotizacion)
    Function GetAllFromCotizacionesByIdResponsable(ByVal idResponsable As Int32) As List(Of Cotizacion)
    Function GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot(ByVal idCotizacion As Int32) As List(Of DetalleReqCotizacion)
End Interface
