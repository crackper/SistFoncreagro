Imports SistFoncreagro.BussinessEntities

Public Interface IProyCompRepository
    Function GetAllFromProyComp() As List(Of ProyComp)
    Function GetProyCompById(ByVal _id As Int32) As ProyComp
    Function GetProyCompByIdProyecto(ByVal _idProy As Int32) As List(Of ProyComp)
    Function SaveProyComp(ByVal _ProyComp As ProyComp) As String
    Function DeleteProyComp(ByVal _id As Int32) As String
End Interface
