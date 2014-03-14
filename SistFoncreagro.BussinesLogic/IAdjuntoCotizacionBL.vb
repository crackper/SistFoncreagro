Imports SistFoncreagro.BussinessEntities
Public Interface IAdjuntoCotizacionBL
    Sub SaveAdjuntoCotizacion(ByVal adjunto As AdjuntoCotizacion)
    Sub DeleteadjuntoCotizacion(ByVal IdAdjuntoCotizacion As Int32)
    Function GetAllFromAdjuntoCotizacionByIdCotizacion(ByVal idCotizacion As Int32) As List(Of AdjuntoCotizacion)
End Interface
