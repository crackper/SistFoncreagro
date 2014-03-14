Imports SistFoncreagro.BussinessEntities
Public Interface ITipoInmuebleRepository
    Function GetAllFromTIPOINMUEBLE() As List(Of TipoInmueble)
    Function GetTIPOINMUEBLEByIdTipo(ByVal IdTipo As Int32) As TipoInmueble
    Sub DeleteTIPOINMUEBLE(ByVal IdTipo As Int32)
    Sub SaveTIPOINMUEBLE(ByVal _TipoInmueble As TipoInmueble)
End Interface
