Imports SistFoncreagro.BussinessEntities
Public Interface IEjecucionRepository
    Function GetEJECUCIONByIdProyecto(ByVal IdProyecto As Int32) As List(Of Ejecucion)
    Sub DeleteEJECUCION(ByVal IdEjecucion As Int32)
    Function GetEJECUCIONByIdEjecucion(ByVal IdEjecucion As Int32) As Ejecucion
    Function SaveEJECUCION(ByVal _Ejecucion As Ejecucion) As Int32
End Interface
