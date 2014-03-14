Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class HorarioRepository : Inherits MasterDataAccess : Implements IHorarioRepository

    Public Function GetHorarioByIdHorario(ByVal idHorario As Int32, ByVal idJornadaTrabajo As Int32) As BussinessEntities.Horario Implements IHorarioRepository.GetHorarioByIdHorario
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetHORARIOByIdHorarioIdJornadaTrabajo")
        command.Parameters.AddWithValue("IdHorario", idHorario)
        command.Parameters.AddWithValue("IdJornadaTrabajo", idJornadaTrabajo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetAllFromHORARIO() As System.Collections.Generic.List(Of BussinessEntities.Horario) Implements IHorarioRepository.GetAllFromHORARIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromHORARIO")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Horario)
        Dim lista As New List(Of Horario)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Horario
                If Not reader.IsDBNull(reader.GetOrdinal("ciclo")) Then
                    entity.ciclo = reader.GetValue(reader.GetOrdinal("ciclo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("DiaIniDescanso")) Then
                    entity.DiaIniDescanso = reader.GetValue(reader.GetOrdinal("DiaIniDescanso"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdHorario")) Then
                    entity.IdHorario = reader.GetValue(reader.GetOrdinal("IdHorario"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdJornadaTrabajo")) Then
                    entity.IdJornadaDeTrabajo = reader.GetValue(reader.GetOrdinal("IdJornadaTrabajo"))
                End If

                If entity.IdHorario.HasValue And entity.IdJornadaDeTrabajo.HasValue Then
                    Dim turnosRegularesRepository As New TurnosRegularesRepository

                    entity.ListaTurnosRegulares = turnosRegularesRepository.GetTurnosRegularesByIdHorarioIdJornadaTrabajo(entity.IdHorario, entity.IdJornadaDeTrabajo)
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
