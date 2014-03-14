Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ControlAsistenciaRepository : Inherits MasterDataAccess : Implements IControlAsistenciaRepository
    Public Function GetControlAsistenciaByIdPeriodoLaboralAndByFecha(ByVal IdPeriodoLaboral As Integer, ByVal Fecha As Date) As List(Of ControlAsistencia) Implements IControlAsistenciaRepository.GetControlAsistenciaByIdPeriodoLaboralAndByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetControlAsistenciaByIdPeriodoLaboralAndByFecha")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Fecha", Fecha)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo(ByVal IdPeriodoLaboral As Integer, ByVal Fecha As Date, ByVal Tipo As String) As List(Of ControlAsistencia) Implements IControlAsistenciaRepository.GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha(ByVal IdPeriodoLaboral As Integer, ByVal FechaInicial As Date, ByVal FechaFinal As Date) As System.Collections.Generic.List(Of BussinessEntities.ControlAsistencia) Implements IControlAsistenciaRepository.GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("FechaInicial", FechaInicial)
        command.Parameters.AddWithValue("FechaFinal", FechaFinal)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo(ByVal IdPeriodoLaboral As Integer, ByVal Fecha As Date, ByVal tipo As String) Implements IControlAsistenciaRepository.DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteControlAsistenciaByIdPeriodoLaboralByIdFecha")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("tipo", tipo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha(ByVal controlAsistencia As ControlAsistencia, ByVal FechaInicial As Date, ByVal FechaFinal As Date) Implements IControlAsistenciaRepository.SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha")
        command.Parameters.AddWithValue("IdPeriodoLaboral", controlAsistencia.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdResponsableControl", controlAsistencia.IdResponsableControl)
        command.Parameters.AddWithValue("HoraIngresoReal", controlAsistencia.HoraIngresoReal)
        command.Parameters.AddWithValue("HoraSalidaReal", controlAsistencia.HoraSalidaReal)
        command.Parameters.AddWithValue("CondicionReal", controlAsistencia.CondicionReal)
        command.Parameters.AddWithValue("HorasTrabajadas", controlAsistencia.HorasTrabajadas)
        command.Parameters.AddWithValue("HorasExtra", controlAsistencia.HorasExtra)
        command.Parameters.AddWithValue("TiempoTardanza", controlAsistencia.TiempoTardanza)
        command.Parameters.AddWithValue("IdRecuperacion", controlAsistencia.IdRecuperacion)
        command.Parameters.AddWithValue("IdFeriado", controlAsistencia.IdFeriado)
        command.Parameters.AddWithValue("IdAusencia", controlAsistencia.IdAusencia)

        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function SaveCONTROLASISTENCIA(ByVal controlAsistencia As BussinessEntities.ControlAsistencia) As Integer Implements IControlAsistenciaRepository.SaveCONTROLASISTENCIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONTROLASISTENCIA")
        command.Parameters.AddWithValue("IdControlAsistencia", controlAsistencia.IdControlAsistencia)
        command.Parameters.AddWithValue("IdPeriodoLaboral", controlAsistencia.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdResponsableControl", controlAsistencia.IdResponsableControl)
        command.Parameters.AddWithValue("Fecha", controlAsistencia.Fecha)
        command.Parameters.AddWithValue("Turno", controlAsistencia.Turno)
        command.Parameters.AddWithValue("HoraIngresoProg", controlAsistencia.HoraIngresoProg)
        command.Parameters.AddWithValue("HoraSalidaProg", controlAsistencia.HoraSalidaProg)
        command.Parameters.AddWithValue("CondicionPro", controlAsistencia.CondicionPro)
        command.Parameters.AddWithValue("HoraIngresoReal", controlAsistencia.HoraIngresoReal)
        command.Parameters.AddWithValue("HoraSalidaReal", controlAsistencia.HoraSalidaReal)
        command.Parameters.AddWithValue("CondicionReal", controlAsistencia.CondicionReal)
        command.Parameters.AddWithValue("HorasProgramadas", controlAsistencia.HorasProgramadas)
        command.Parameters.AddWithValue("HorasTrabajadas", controlAsistencia.HorasTrabajadas)
        command.Parameters.AddWithValue("HorasExtra", controlAsistencia.HorasExtra)
        command.Parameters.AddWithValue("TiempoTardanza", controlAsistencia.TiempoTardanza)
        command.Parameters.AddWithValue("Tipo", controlAsistencia.tipo)
        command.Parameters.AddWithValue("IdRecuperacion", controlAsistencia.IdRecuperacion)
        command.Parameters.AddWithValue("IdFeriado", controlAsistencia.IdFeriado)
        command.Parameters.AddWithValue("IdAusencia", controlAsistencia.IdAusencia)

        'command.Parameters("idCargo").Direction = ParameterDirection.Output

        'MyBase.ExecuteNonQuery(command)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If
            Else
                i = 0 'command.Parameters("idCargo").Value
            End If
        End Using


        Return i
        'command.ExecuteReader(CommandBehavior.SingleRow).Item(0)
    End Function
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ControlAsistencia)
        Dim lista As New List(Of ControlAsistencia)
        Dim PeriodoLaboralRepository As New PeriodoLaboralRepository
        'Dim PersonalRepository As New PersonalRepository
        'Dim argPeriodoLaboral As New ArgumentosPeriodolaboral(Nothing, Nothing, 0, 0, 0, 0, 0)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New ControlAsistencia
                If Not reader.IsDBNull(reader.GetOrdinal("CondicionPro")) Then
                    entity.CondicionPro = reader.GetValue(reader.GetOrdinal("CondicionPro"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CondicionReal")) Then
                    entity.CondicionReal = reader.GetValue(reader.GetOrdinal("CondicionReal"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Fecha")) Then
                    entity.Fecha = reader.GetValue(reader.GetOrdinal("Fecha"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraIngresoProg")) Then
                    entity.HoraIngresoProg = reader.GetValue(reader.GetOrdinal("HoraIngresoProg"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraIngresoReal")) Then
                    entity.HoraIngresoReal = reader.GetValue(reader.GetOrdinal("HoraIngresoReal"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraSalidaProg")) Then
                    entity.HoraSalidaProg = reader.GetValue(reader.GetOrdinal("HoraSalidaProg"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HoraSalidaReal")) Then
                    entity.HoraSalidaReal = reader.GetValue(reader.GetOrdinal("HoraSalidaReal"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HorasExtra")) Then
                    entity.HorasExtra = reader.GetValue(reader.GetOrdinal("HorasExtra"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HorasProgramadas")) Then
                    entity.HorasProgramadas = reader.GetValue(reader.GetOrdinal("HorasProgramadas"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("HorasTrabajadas")) Then
                    entity.HorasTrabajadas = reader.GetValue(reader.GetOrdinal("HorasTrabajadas"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdAusencia")) Then
                    entity.IdAusencia = reader.GetValue(reader.GetOrdinal("IdAusencia"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdControlAsistencia")) Then
                    entity.IdControlAsistencia = reader.GetValue(reader.GetOrdinal("IdControlAsistencia"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdFeriado")) Then
                    entity.IdFeriado = reader.GetValue(reader.GetOrdinal("IdFeriado"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdRecuperacion")) Then
                    entity.IdRecuperacion = reader.GetValue(reader.GetOrdinal("IdRecuperacion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdResponsableControl")) Then
                    entity.IdResponsableControl = reader.GetValue(reader.GetOrdinal("IdResponsableControl"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("TiempoTardanza")) Then
                    entity.TiempoTardanza = reader.GetValue(reader.GetOrdinal("TiempoTardanza"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("tipo")) Then
                    entity.tipo = reader.GetValue(reader.GetOrdinal("tipo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Turno")) Then
                    entity.Turno = reader.GetValue(reader.GetOrdinal("Turno"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Observacion")) Then
                    entity.Observacion = reader.GetValue(reader.GetOrdinal("Observacion"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
    Public Sub UpdateCONTROLASISTENCIA(ByVal _controlAsistencia As BussinessEntities.ControlAsistencia) Implements IControlAsistenciaRepository.UpdateCONTROLASISTENCIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateCONTROLASISTENCIA")
        command.Parameters.AddWithValue("IdControlAsistencia", _controlAsistencia.IdControlAsistencia)
        command.Parameters.AddWithValue("IdPeriodoLaboral", _controlAsistencia.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdResponsableControl", _controlAsistencia.IdResponsableControl)
        command.Parameters.AddWithValue("HoraIngresoReal", _controlAsistencia.HoraIngresoReal)
        command.Parameters.AddWithValue("HoraSalidaReal", _controlAsistencia.HoraSalidaReal)
        command.Parameters.AddWithValue("CondicionReal", _controlAsistencia.CondicionReal)
        command.Parameters.AddWithValue("Observacion", _controlAsistencia.Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetControlAsistenciaByIdPersonalAndByFecha(ByVal IdPersonal As Integer, ByVal Fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.ControlAsistencia) Implements IControlAsistenciaRepository.GetControlAsistenciaByIdPersonalAndByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetControlAsistenciaByIdPersonalAndByFecha")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("Fecha", Fecha)
        Return SelectObjectFactory(command)
    End Function
End Class
