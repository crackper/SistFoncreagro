Imports SistFoncreagro.BussinessEntities
Public Interface ICatalogoVentaRepository
    Function GetCATALOGOVENTAByIdCatVenta(ByVal IdCatVenta As Int32) As CatalogoVenta
    Function GetAllFromCATALOGOVENTAS() As List(Of CatalogoVenta)
    Sub SaveCATALOGOVENTA(ByVal _CatalogoVenta As CatalogoVenta)
    Sub UpdateEstadoCATALOGOVENTA(ByVal IdCatVenta As Int32)
End Interface
