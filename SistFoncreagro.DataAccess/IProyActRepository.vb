Imports SistFoncreagro.BussinessEntities

Public Interface IProyActRepository
    Function GetAllFromProyAct() As List(Of ProyAct)
    Function GetProyActById(ByVal _id As Int32) As ProyAct
    Function GetProyActByIdProyecto(ByVal _idProy As Int32) As List(Of ProyAct)
    Function SaveProyAct(ByVal _ProyAct As ProyAct) As String
    Function DeleteProyAct(ByVal _id As Int32) As String
End Interface
