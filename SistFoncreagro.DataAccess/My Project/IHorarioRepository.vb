Imports SistFoncreagro.BussinessEntities
Public Interface IHorarioRepository
    'Function GetAllFromHorario() As List(Of Horario)
    Function GetHorarioByIdHorario(ByVal IdHorario As Int32, ByVal IdJornadaTrabajo As Int32) As Horario
    Function GetAllFromHORARIO() As List(Of Horario)
    'Sub SaveHorario(ByVal horario As Horario)
    'Sub DeleteHorario(ByVal idHorario As Int32)
End Interface
