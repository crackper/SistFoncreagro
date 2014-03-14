Imports SistFoncreagro.BussinessEntities
Public Interface IOficinaRepository
    Function GetAllFromOFICINA() As List(Of Oficina)
    Function GetOFICINAByIdOficina(ByVal IdOficina As Int32) As Oficina
    Function GetOFICINAByIdLocal(ByVal IdLocal As Int32) As List(Of Oficina)
    Sub UpdateEstadoOFICINA(ByVal IdOficina As Int32)
    Sub SaveOFICINA(ByVal _Oficina As Oficina)
    Sub DeleteOFICINA(ByVal IdOficina As Int32)
End Interface
