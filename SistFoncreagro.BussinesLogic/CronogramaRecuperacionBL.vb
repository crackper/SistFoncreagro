Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class CronogramaRecuperacionBL : Implements ICronogramaRecuperacionBL

    Dim factoryrepository As ICronogramaRecuperacionRepository

    Public Sub New()
        factoryrepository = New CronogramaRecuperacionRepository
    End Sub

    Public Sub DeleteCronogramaRecuperacion(ByVal _Id As Integer) Implements ICronogramaRecuperacionBL.DeleteCronogramaRecuperacion
        factoryrepository.DeleteCronogramaRecuperacion(_Id)
    End Sub

    Public Function GetAllfromCronogramaRecuperacion() As System.Collections.Generic.List(Of BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionBL.GetAllfromCronogramaRecuperacion
        Return factoryrepository.GetAllfromCronogramaRecuperacion
    End Function

    Public Function GetCronogramaRecuperacionByFecha(ByVal Fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionBL.GetCronogramaRecuperacionByFecha
        Return factoryrepository.GetCronogramaRecuperacionByFecha(Fecha)
    End Function

    Public Function GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo(ByVal Fecha As Date, ByVal Idturno As Integer, ByVal IdHorario As Integer, ByVal IdJornadaTrabajo As Integer) As BussinessEntities.CronogramaRecuperacion Implements ICronogramaRecuperacionBL.GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo
        Return factoryrepository.GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo(Fecha, Idturno, IdHorario, IdJornadaTrabajo)
    End Function

    Public Function GetCronogramaRecuperacionById(ByVal _Id As Integer) As BussinessEntities.CronogramaRecuperacion Implements ICronogramaRecuperacionBL.GetCronogramaRecuperacionById
        Return factoryrepository.GetCronogramaRecuperacionById(_Id)
    End Function

    Public Function GetCronogramaRecuperacionByIdFeriado(ByVal _IdFeriado As Integer) As System.Collections.Generic.List(Of BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionBL.GetCronogramaRecuperacionByIdFeriado
        Return factoryrepository.GetCronogramaRecuperacionByIdFeriado(_IdFeriado)
    End Function

    Public Sub SaveCronogramaRecuperacion(ByVal _Cronograma As BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionBL.SaveCronogramaRecuperacion
        factoryrepository.SaveCronogramaRecuperacion(_Cronograma)
    End Sub

    Public Sub CrearCronogramaRecuperacion(ByVal __NumDias As Integer, ByVal _FechaInicio As Date, ByVal _HoraInicio As String, ByVal _HoraFin As String, ByVal _IdTurno As Integer, ByVal _IdFeriado As Integer) Implements ICronogramaRecuperacionBL.CrearCronogramaRecuperacion
        factoryrepository.CrearCronogramaRecuperacion(__NumDias, _FechaInicio, _HoraInicio, _HoraFin, _IdTurno, _IdFeriado)
    End Sub
End Class
