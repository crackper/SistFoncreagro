Imports SistFoncreagro.BussinessEntities
Public Interface IEstadoBienMuebleRepository
    Sub DeleteESTADOBIENMUEBLE(ByVal IdEstado As Int32)
    Sub SaveESTADOBIENMUEBLE(ByVal _EstadoBienMueble As EstadoBienMueble)
    Function GetESTADOBIENMUEBLEByIdEstado(ByVal IdEstado As Int32) As EstadoBienMueble
    Function GetESTADOBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Int32) As List(Of EstadoBienMueble)
End Interface
