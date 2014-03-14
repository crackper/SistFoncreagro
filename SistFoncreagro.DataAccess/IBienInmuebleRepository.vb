Imports SistFoncreagro.BussinessEntities
Public Interface IBienInmuebleRepository
    Sub UpdateEstadoBIENINMUEBLE(ByVal IdBienInmueble As Int32, ByVal Estado As String)
    Function GetBIENINMUEBLEByIdBienInmueble(ByVal IdBienInmueble As Int32) As BienInmueble
    Function SaveBIENINMUEBLE(ByVal _BienInmueble As BienInmueble) As Int32
End Interface
