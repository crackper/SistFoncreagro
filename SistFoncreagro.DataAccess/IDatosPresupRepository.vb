Imports SistFoncreagro.BussinessEntities

Public Interface IDatosPresupRepository
    Function GetDatosPresupByParameters(ByVal _IdProyecto As Int32, ByVal _IdEjerPresup As Int32, ByVal _Anio As Int32) As List(Of DatosPresup)
    Sub CrearPresup(ByVal _IdProyecto As Int32, ByVal _IdEjerPresup As Int32)

End Interface
