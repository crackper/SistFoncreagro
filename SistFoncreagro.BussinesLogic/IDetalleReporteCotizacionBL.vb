Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleReporteCotizacionBL
    Sub SaveDetalleReporteCotizacion(ByVal detalleReporteCotizacion As DetalleReporteCotizacion)
    Sub UpdateDetalleReporteCotizacion(ByVal detalleReporteCotizacion As DetalleReporteCotizacion)
    Sub DeleteDetalleReporteCotizacion(ByVal IdDetalleReporteCotizacion As Int32)
    Function GetAllFromDetalleReporteCotizacionByIdCotizacion(ByVal idCotizacion As Int32) As List(Of DetalleReporteCotizacion)
End Interface
