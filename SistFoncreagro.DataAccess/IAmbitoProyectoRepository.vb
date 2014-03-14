Imports SistFoncreagro.BussinessEntities

Public Interface IAmbitoProyectoRepository
    Function GetAllFromAmbitoProyecto() As List(Of AmbitoProyecto)
    Function GetFromAmbitoProyectoById(ByVal _id As Int32) As AmbitoProyecto
    Function GetAmbitoProyectoByIdProy(ByVal _IdProy As Int32) As List(Of AmbitoProyecto)
    Sub SaveAmbitoProyecto1(ByVal _AmbitoProyecto As AmbitoProyecto)
    Sub SaveAmbitoProyecto(ByVal detalle As List(Of AmbitoProyecto))
    Sub SaveAmbitoProyectoBeneficiarios(ByVal _AmbitoProyecto As AmbitoProyecto)
    Sub DeleteAmbitoProyecto(ByVal _id As Int32)
End Interface
