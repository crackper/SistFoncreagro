Imports SistFoncreagro.BussinessEntities

Public Interface IHorarioBL
    Function GetHorarioByIdHorario(ByVal IdHorario As Int32, ByVal IdJornadaTrabajo As Int32) As Horario
    Function GetAllFromHORARIO() As List(Of Horario)
End Interface
