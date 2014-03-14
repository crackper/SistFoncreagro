Imports SistFoncreagro.BussinessEntities

Public Interface IDetEjerPresupRepository
    Function GetAllFromDetEjerPresup() As List(Of DetEjerPresup)
    Function GetDetEjerPresupByIdDetEjerPresup(ByVal _id As Int32) As DetEjerPresup
    Sub SaveDetEjerPresup(ByVal _DetEjerPresup As DetEjerPresup)
    Sub SaveDetEjerPresup1(ByVal _DetEjerPresup As List(Of DetEjerPresup))
    Sub DeleteDetEjerPresup(ByVal _id As Int32)
End Interface
