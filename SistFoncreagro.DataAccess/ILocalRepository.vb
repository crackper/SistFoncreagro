Imports SistFoncreagro.BussinessEntities
Public Interface ILocalRepository
    Function GetAllFromLOCAL() As List(Of Local)
    Function GetLOCALByIdLocal(ByVal IdLocal As Int32) As Local
    Sub UpdateEstadoLOCAL(ByVal IdLocal As Int32)
    Sub SaveLOCAL(ByVal _Local As Local)
    Sub DeleteLOCAL(ByVal IdLocal As Int32)
End Interface
