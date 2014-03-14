Imports SistFoncreagro.BussinessEntities
Public Interface IClasificacionCatalogoVentas
    Sub SaveCLASIFICACIONCATALOGOVENTAS(ByVal _ClasificacionCatalogoVentas As ClasificacionCatalogoVentas)
    Function GetCLASIFICACIONCATALOGOVENTASById(ByVal IdClasificacion As Int32) As ClasificacionCatalogoVentas
    Sub UpdateEstadoCLASIFICACIONCATALOGOVENTAS(ByVal IdClasificacion As Int32)
End Interface

