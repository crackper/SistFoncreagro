Imports SistFoncreagro.BussinessEntities

Public Interface IActivarPresupuestoBL
    Function GetACTIVARPRESUPByIdEjerPresup(ByVal _IdEjerPresup As Int32) As List(Of ActivarPresupuesto)
    Function GetACTIVARPRESUPByIdProyAndIdEjerPresup(ByVal _IdEjerPresup As Int32, ByVal _IdProyecto As Int32) As ActivarPresupuesto
    Sub NueActivarPresup(ByVal _IdEjerPresup As Int32)
    Sub UpdateActivarPresup(ByVal _ActivarPresup As ActivarPresupuesto)
    Sub UpdateActivarPresup1(ByVal _ActivarPresup As List(Of ActivarPresupuesto))
End Interface
