Imports SistFoncreagro.BussinessEntities

Public Interface IRutaRequerimientoRepository
    Function GetAllFromRutaRequerimiento() As List(Of RutaRequerimiento)
    Function GetRutaRequerimientoByIdRuta(ByVal idRutaRequerimiento As Integer) As RutaRequerimiento
    Sub SaveRutaRequerimiento(ByVal rutaRequerimiento As RutaRequerimiento)
    Sub DeleteRutaRequerimiento(ByVal idRutaRequerimiento As Integer)
End Interface
