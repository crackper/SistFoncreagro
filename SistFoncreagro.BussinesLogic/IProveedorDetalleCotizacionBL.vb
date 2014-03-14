Imports SistFoncreagro.BussinessEntities

Public Interface IProveedorDetalleCotizacionBL
    Sub SaveProveedorDetalleCotizacion1(ByVal proveedorDetalleCoti As List(Of ProveedorDetalleCotizacion))
    'Sub UpdateProveedorDetalleCotizacion(ByVal proveedorDetalleCoti As ProveedorDetalleCotizacion)
    Sub UpdateProveedorDetalleCotizacion1(ByVal proveedorDetalleCoti As List(Of ProveedorDetalleCotizacion))
    Sub DeleteProveedor1(ByVal proveedorDetCot As List(Of ProveedorDetalleCotizacion))
    Sub UpdateIgvCotizacion(ByVal IdDetalleRequerimiento As Int32, ByVal valor As Boolean)
    Function GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion(ByVal idDetalleReqCotizacion As Int32) As List(Of ProveedorDetalleCotizacion)
End Interface
