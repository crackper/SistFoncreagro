Imports SistFoncreagro.BussinessEntities
Public Interface IVentaRepository
    Function SaveVENTA(ByVal _Venta As Venta) As Int32
    Function GetVENTAByIdVenta(ByVal IdVenta As Int32) As Venta
    Function GetVENTAByAnio(ByVal Anio As Int32) As List(Of Venta)
    Function GetVENTAByEstado(ByVal Estado As String) As List(Of Venta)
    Sub DeleteVENTA(ByVal IdVenta As Int32)
    Sub UpdateEstadoVENTA(ByVal IdVenta As Int32, ByVal Estado As String)
    Sub GenerarComprobanteVenta(ByVal IdVenta As Int32, ByVal IdProyecto As Int32, ByVal IdTipoDocumento As Int32)
    Sub UpdateIgvVenta(ByVal IdCatVenta As Int32, ByVal IdVenta As Int32)
    Sub UpdateObservacionVENTA(ByVal IdVenta As Int32, ByVal Observacion As String)
    Function VerifyVentaTituloGratuito(ByVal serie As String, ByVal numero As Int32, ByVal tipo As Int32) As String
    Function VerifyVentaSemovientes(ByVal serie As String, ByVal numero As Int32, ByVal tipo As Int32) As String
    Sub GenerarAsientoTraslado(ByVal FechaContable As DateTime, ByVal anio As Int32, ByVal mes As Int32, ByVal usuario As Int32)
End Interface
