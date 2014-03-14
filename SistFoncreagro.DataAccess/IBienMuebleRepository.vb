Imports SistFoncreagro.BussinessEntities
Public Interface IBienMuebleRepository
    Function GetAllFromBIENMUEBLE() As List(Of BIENMUEBLE)
    Function GetBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Int32) As BIENMUEBLE
    Function SaveBIENMUEBLE(ByVal _BienMueble As BIENMUEBLE) As Int32
    Sub UpdateEstadoBIENMUEBLE(ByVal IdBienMueble As Int32, ByVal Estado As String)
    Function GetBIENMUEBLEByParameter(ByVal texto As String) As List(Of BIENMUEBLE)
End Interface
