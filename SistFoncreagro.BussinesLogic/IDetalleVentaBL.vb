Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleVentaBL
    Sub SaveDETALLEVENTA(ByVal _DetalleVenta As DetalleVenta)
    Function GetDETALLEVENTAByIdDetalleVenta(ByVal IdDetalleVenta As Int32) As DetalleVenta
    Function GetDETALLEVENTAByIdVenta(ByVal IdVenta As Int32) As List(Of DetalleVenta)
    Sub DeleteDETALLEVENTA(ByVal IdDetalleVenta As Int32)
End Interface
