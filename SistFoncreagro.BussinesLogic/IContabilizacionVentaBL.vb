Imports SistFoncreagro.BussinessEntities
Public Interface IContabilizacionVentaBL
    Function GetCONTABILIZACIONVENTAByIdContaVenta(ByVal IdContaVenta As Int32) As ContabilizacionVenta
    Function GetAllFromCONTABILIZACIONVENTA() As List(Of ContabilizacionVenta)
    Sub SaveCONTABILIZACIONVENTA(ByVal _ContabilizacionVenta As ContabilizacionVenta)
    Sub UpdateEstadoCONTABILIZACIONVENTA(ByVal IdContaVenta As Int32)
End Interface
