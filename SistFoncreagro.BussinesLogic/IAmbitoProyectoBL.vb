Imports SistFoncreagro.BussinessEntities

Public Interface IAmbitoProyectoBL
    Function GetAllFromAmbitoProyecto() As List(Of AmbitoProyecto)
    Function GetFromAmbitoProyectoById(ByVal _id As Int32) As AmbitoProyecto
    Function GetAmbitoProyectoByIdProy(ByVal _IdProy As Int32) As List(Of AmbitoProyecto)
    Sub SaveAmbitoProyecto(ByVal _AmbitoProyecto As List(Of AmbitoProyecto))
    Sub DeleteAmbitoProyecto(ByVal _id As Int32)
End Interface
