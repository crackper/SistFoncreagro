Imports SistFoncreagro.BussinessEntities

Public Interface ITurnosRegularesRepository
    Function GetTurnosRegularesByIdHorarioIdJornadaTrabajo(ByVal IdHorario As Int32, ByVal IdJornadaTrabajo As Int32) As List(Of TurnosRegulares)
    Function GetAllFromTURNOSREGULARES() As List(Of TurnosRegulares)
    Function GetTURNOSREGULARESByIdTurno(ByVal _IdTurno As Int32) As TurnosRegulares

End Interface
