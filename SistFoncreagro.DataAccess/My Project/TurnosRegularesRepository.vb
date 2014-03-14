Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TurnosRegularesRepository : Inherits MasterDataAccess : Implements ITurnosRegularesRepository

    Public Function GetTurnosRegularesByIdHorarioIdJornadaTrabajo(ByVal IdHorario As Integer, ByVal IdJornadaTrabajo As Integer) As System.Collections.Generic.List(Of BussinessEntities.TurnosRegulares) Implements ITurnosRegularesRepository.GetTurnosRegularesByIdHorarioIdJornadaTrabajo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTurnosRegularesByIdHorarioIdJornadaTrabajo")
        command.Parameters.AddWithValue("IdHorario", IdHorario)
        command.Parameters.AddWithValue("IdJornadaTrabajo", IdJornadaTrabajo)
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TurnosRegulares)
        Dim lista As New List(Of TurnosRegulares)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TurnosRegulares
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraFin")) Then
                    entity.HoraFin = reader.GetValue(reader.GetOrdinal("HoraFin"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraInicio")) Then
                    entity.HoraInicio = reader.GetValue(reader.GetOrdinal("HoraInicio"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdHorario")) Then
                    entity.IdHorario = reader.GetValue(reader.GetOrdinal("IdHorario"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdJornadaTrabajo")) Then
                    entity.IdJornadaTrabajo = reader.GetValue(reader.GetOrdinal("IdJornadaTrabajo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTurno")) Then
                    entity.IdTurno = reader.GetValue(reader.GetOrdinal("IdTurno"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Public Function GetAllFromTURNOSREGULARES() As System.Collections.Generic.List(Of BussinessEntities.TurnosRegulares) Implements ITurnosRegularesRepository.GetAllFromTURNOSREGULARES
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTURNOSREGULARES")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTURNOSREGULARESByIdTurno(ByVal _IdTurno As Integer) As BussinessEntities.TurnosRegulares Implements ITurnosRegularesRepository.GetTURNOSREGULARESByIdTurno
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTURNOSREGULARESByIdTurno")
        command.Parameters.AddWithValue("IdTurno", _IdTurno)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
