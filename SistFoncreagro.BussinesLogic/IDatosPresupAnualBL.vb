Imports SistFoncreagro.BussinessEntities

Public Interface IDatosPresupAnualBL
    Function GetDatosPresupAnualByParameters(ByVal _IdProyecto As Int32, ByVal _IdEjerPresup As Int32, ByVal _Anio As Int32) As List(Of DatosPresupAnual)
    Sub CrearPresupAnual(ByVal _IdProyecto As Int32, ByVal _IdEjerPresup As Int32)
End Interface
