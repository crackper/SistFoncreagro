Imports SistFoncreagro.BussinessEntities

Public Interface ICronogramaRecuperacionBL
    Function GetCronogramaRecuperacionByFecha(ByVal Fecha As DateTime) As List(Of CronogramaRecuperacion)
    Function GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo(ByVal Fecha As DateTime, ByVal Idturno As Int32, ByVal IdHorario As Int32, ByVal IdJornadaTrabajo As Int32) As CronogramaRecuperacion
    Sub DeleteCronogramaRecuperacion(ByVal _Id As Int32)
    Sub SaveCronogramaRecuperacion(ByVal _Cronograma As CronogramaRecuperacion)
    Sub CrearCronogramaRecuperacion(ByVal __NumDias As Int32, ByVal _FechaInicio As Date, ByVal _HoraInicio As String, ByVal _HoraFin As String, ByVal _IdTurno As Int32, ByVal _IdFeriado As Int32)
    Function GetAllfromCronogramaRecuperacion() As List(Of CronogramaRecuperacion)
    Function GetCronogramaRecuperacionById(ByVal _Id As Int32) As CronogramaRecuperacion
    Function GetCronogramaRecuperacionByIdFeriado(ByVal _IdFeriado As Int32) As List(Of CronogramaRecuperacion)
End Interface
