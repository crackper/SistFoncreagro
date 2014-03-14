Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class CronogramaRecuperacionRepository : Inherits MasterDataAccess : Implements ICronogramaRecuperacionRepository

    Public Function GetCronogramaRecuperacionByFecha(ByVal fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionRepository.GetCronogramaRecuperacionByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCronogramaRecuperacionByFecha")
        command.Parameters.AddWithValue("Fecha", fecha)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo(ByVal Fecha As Date, ByVal Idturno As Integer, ByVal IdHorario As Integer, ByVal IdJornadaTrabajo As Integer) As BussinessEntities.CronogramaRecuperacion Implements ICronogramaRecuperacionRepository.GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo
        Dim command As SqlCommand = MyBase.CreateSPCommand(" GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo")
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("Idturno", Idturno)
        command.Parameters.AddWithValue("IdHorario", IdHorario)
        command.Parameters.AddWithValue("IdJornadaTrabajo", IdJornadaTrabajo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CronogramaRecuperacion)
        Dim lista As New List(Of CronogramaRecuperacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New CronogramaRecuperacion
                If Not reader.IsDBNull(reader.GetOrdinal("Fecha")) Then
                    entity.Fecha = reader.GetValue(reader.GetOrdinal("Fecha"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraFin")) Then
                    entity.HoraFin = reader.GetValue(reader.GetOrdinal("HoraFin"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraInicio")) Then
                    entity.HoraInicio = reader.GetValue(reader.GetOrdinal("HoraInicio"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdFeriado")) Then
                    entity.IdFeriado = reader.GetValue(reader.GetOrdinal("IdFeriado"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdRecuperacion")) Then
                    entity.IdRecuperacion = reader.GetValue(reader.GetOrdinal("IdRecuperacion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTurno")) Then
                    entity.IdTurno = reader.GetValue(reader.GetOrdinal("IdTurno"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdHorario")) Then
                    entity.IdHorario = reader.GetValue(reader.GetOrdinal("IdHorario"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdJornadaTrabajo")) Then
                    entity.IdJornadaTrabajo = reader.GetValue(reader.GetOrdinal("IdJornadaTrabajo"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Public Sub DeleteCronogramaRecuperacion(ByVal _Id As Integer) Implements ICronogramaRecuperacionRepository.DeleteCronogramaRecuperacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCRONOGRAMARECUPERACION")
        command.Parameters.AddWithValue("idRecuperacion", _Id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllfromCronogramaRecuperacion() As System.Collections.Generic.List(Of BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionRepository.GetAllfromCronogramaRecuperacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCRONOGRAMARECUPERACION")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCronogramaRecuperacionByIdFeriado(ByVal _IdFeriado As Integer) As System.Collections.Generic.List(Of BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionRepository.GetCronogramaRecuperacionByIdFeriado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCRONOGRAMARECUPERACIONByIdFeriado")
        command.Parameters.AddWithValue("idFeriado", _IdFeriado)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveCronogramaRecuperacion(ByVal _Cronograma As BussinessEntities.CronogramaRecuperacion) Implements ICronogramaRecuperacionRepository.SaveCronogramaRecuperacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCronogramaRecuperacion")
        command.Parameters.AddWithValue("IdRecuperacion", _Cronograma.IdRecuperacion)
        command.Parameters.AddWithValue("IdFeriado", _Cronograma.IdFeriado)
        command.Parameters.AddWithValue("Fecha", _Cronograma.Fecha)
        command.Parameters.AddWithValue("IdTurno", _Cronograma.IdTurno)
        command.Parameters.AddWithValue("HoraInicio", _Cronograma.HoraInicio)
        command.Parameters.AddWithValue("HoraFin", _Cronograma.HoraFin)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetCronogramaRecuperacionById(ByVal _Id As Integer) As BussinessEntities.CronogramaRecuperacion Implements ICronogramaRecuperacionRepository.GetCronogramaRecuperacionById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCRONOGRAMARECUPERACIONById")
        command.Parameters.AddWithValue("idRecuperacion", _Id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub CrearCronogramaRecuperacion(ByVal __NumDias As Integer, ByVal _FechaInicio As Date, ByVal _HoraInicio As String, ByVal _HoraFin As String, ByVal _IdTurno As Integer, ByVal _IdFeriado As Integer) Implements ICronogramaRecuperacionRepository.CrearCronogramaRecuperacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("CREARCRONOGRAMARECUPERACION")
        command.Parameters.AddWithValue("NumDias", __NumDias)
        command.Parameters.AddWithValue("FechaInicio", _FechaInicio)
        command.Parameters.AddWithValue("HoraInicio", _HoraInicio)
        command.Parameters.AddWithValue("HoraFin", _HoraFin)
        command.Parameters.AddWithValue("IdTurno", _IdTurno)
        command.Parameters.AddWithValue("IdFeriado", _IdFeriado)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
