Imports SistFoncreagro.BussinessEntities
Public Interface IEstadoCotizacionRepository
    Function GetAllFromEstadoCotizacionByIdCotizacion(ByVal IdRequerimiento As Int32) As List(Of EstadoCotizacion)
End Interface
