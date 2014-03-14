Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ControlAsistenciaBL : Implements IControlAsistenciaBL
    Dim factoryrepository As IControlAsistenciaRepository

    Public Sub New()
        factoryrepository = New ControlAsistenciaRepository
    End Sub

    Public Function GetControlAsistenciaByIdPeriodoLaboralAndByFecha(ByVal IdPeriodoLaboral As Integer, ByVal Fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.ControlAsistencia) Implements IControlAsistenciaBL.GetControlAsistenciaByIdPeriodoLaboralAndByFecha
        Return factoryrepository.GetControlAsistenciaByIdPeriodoLaboralAndByFecha(IdPeriodoLaboral, Fecha)
    End Function

    Public Function GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo(ByVal IdPeriodoLaboral As Integer, ByVal Fecha As Date, ByVal Tipo As String) As System.Collections.Generic.List(Of BussinessEntities.ControlAsistencia) Implements IControlAsistenciaBL.GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo
        Return factoryrepository.GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo(IdPeriodoLaboral, Fecha, Tipo)
    End Function

    Public Function GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha(ByVal IdPeriodoLaboral As Integer, ByVal FechaInicial As Date, ByVal FechaFinal As Date) As System.Collections.Generic.List(Of BussinessEntities.ControlAsistencia) Implements IControlAsistenciaBL.GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha
        Return factoryrepository.GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha(IdPeriodoLaboral, FechaInicial, FechaFinal)
    End Function

    Public Function SaveCONTROLASISTENCIA(ByVal controlAsistencia As BussinessEntities.ControlAsistencia) As Integer Implements IControlAsistenciaBL.SaveCONTROLASISTENCIA
        Return factoryrepository.SaveCONTROLASISTENCIA(controlAsistencia)
    End Function

    Public Sub DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo(ByVal IdPeriodoLaboral As Integer, ByVal Fecha As Date, ByVal tipo As String) Implements IControlAsistenciaBL.DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo
        factoryrepository.DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo(IdPeriodoLaboral, Fecha, tipo)
    End Sub

    Public Sub SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha(ByVal controlAsistencia As BussinessEntities.ControlAsistencia, ByVal FechaInicial As Date, ByVal FechaFinal As Date) Implements IControlAsistenciaBL.SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha
        factoryrepository.SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha(controlAsistencia, FechaInicial, FechaFinal)
    End Sub

    Public Function GenerarControlAsistenciaByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal FechaIni As Date, ByVal FechaFin As Date) As List(Of ControlAsistencia) Implements IControlAsistenciaBL.GenerarControlAsistenciaByIdPeriodoLaboral
        Dim listaControlAsistenciaDevolver As New List(Of ControlAsistencia)
        Dim HorarioAsignadoRepository As New HorarioAsignadoRepository
        Dim cronogramaRecuperacionRepository As New CronogramaRecuperacionRepository
        Dim controlAsistenciaRepository As New ControlAsistenciaRepository
        Dim feriadoRepository As New FeriadoRepository
        Dim HorarioAsignado As HorarioAsignado
        Dim FechaControl As DateTime

        FechaControl = FechaIni
        Do While FechaControl <= FechaFin
            Dim listaControlAsistencia As List(Of ControlAsistencia)
            'obtenemos Horario
            HorarioAsignado = HorarioAsignadoRepository.GetHorarioAsignadoByIdPeriodoLaboralAndByFecha(IdPeriodoLaboral, FechaControl)

            If HorarioAsignado.HorarioEntity.ciclo = "5x2" Then
                Dim TotDiasDescanso As Integer = 2
                Dim diaDescanso As Integer = HorarioAsignado.HorarioEntity.DiaIniDescanso
                Dim NroDiasDescanso As Integer = 1
                Dim crear As Boolean
                Dim eSdescanso As Boolean
                Dim eSferiado As Boolean
                ' primero obtenemos el control de asistencia, si existe y aún no esvalidado 
                'lo eliminamos e insertamos uno nuevo, si es validado no realizamos cambio.
                listaControlAsistencia = New List(Of ControlAsistencia)
                listaControlAsistencia = controlAsistenciaRepository.GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo(IdPeriodoLaboral, FechaControl, "regular")

                crear = True
                eSdescanso = False
                eSferiado = False

                ' verificamos si ya existen controles para esa fecha
                If listaControlAsistencia.Count > 0 Then
                    'verificamos si dichos controles no están validados
                    For Each controlAsistencia As ControlAsistencia In listaControlAsistencia 'aqui debería ir un bucle que al encontrar la primera condción elimine y ya no vuelva a entrar
                        If Not String.IsNullOrEmpty(controlAsistencia.HoraIngresoReal) Or
                        Not String.IsNullOrEmpty(controlAsistencia.HoraSalidaReal) Then
                            crear = False
                        End If
                    Next
                End If

                'Si no existen controles validado o no existen controles, entonces creamos:
                If crear Then
                    'eliminamos los controles existentes no validados
                    Me.DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo(IdPeriodoLaboral, FechaControl, "regular")

                    ' verificamos si la fecha corresponde a un descanso
                    Do While NroDiasDescanso = TotDiasDescanso
                        If diaDescanso = Weekday(FechaControl, FirstDayOfWeek.Monday) Then
                            eSdescanso = True
                        End If
                        NroDiasDescanso = NroDiasDescanso + 1
                    Loop

                    'verificamos si la fecha corresponde a un feriado 'hacerlo con una fubncion en la BD que devuelva true o false
                    Dim feriado As Feriado = feriadoRepository.GetFeriadoByFecha(FechaControl)
                    If Not feriado Is Nothing Then
                        eSferiado = True
                    End If

                    ' obtenemos cronograma de recuperación para ese dia:
                    Dim ListaCronogramaRecuperacion As New List(Of CronogramaRecuperacion)
                    ListaCronogramaRecuperacion = cronogramaRecuperacionRepository.GetCronogramaRecuperacionByFecha(FechaControl)

                    'Si es feriado o es descanso
                    If eSferiado Or eSdescanso Then
                        If ListaCronogramaRecuperacion.Count > 0 Then ' Si está programada una recuperación por feriado
                            For Each cronogramaRecuperacion As CronogramaRecuperacion In ListaCronogramaRecuperacion
                                Dim controlAsistencia As New ControlAsistencia
                                Dim HI() As String
                                Dim HF() As String
                                Dim hix As Decimal
                                Dim hfx As Decimal

                                controlAsistencia.IdPeriodoLaboral = IdPeriodoLaboral
                                controlAsistencia.Fecha = FechaControl
                                controlAsistencia.HoraIngresoProg = cronogramaRecuperacion.HoraInicio
                                controlAsistencia.HoraSalidaProg = cronogramaRecuperacion.HoraFin
                                controlAsistencia.CondicionPro = "T"
                                controlAsistencia.Turno = cronogramaRecuperacion.IdTurno
                                controlAsistencia.IdRecuperacion = cronogramaRecuperacion.IdRecuperacion

                                HI = Split(cronogramaRecuperacion.HoraInicio, ":")
                                HF = Split(cronogramaRecuperacion.HoraFin, ":")

                                hix = CDec(HI(1)) + CDec(HI(2)) / 60
                                hfx = CDec(HF(1)) + CDec(HF(2)) / 60

                                If hfx > hix Then
                                    controlAsistencia.HorasProgramadas = hfx - hix
                                Else
                                    controlAsistencia.HorasProgramadas = (24 - hfx) + hix
                                End If

                                If eSferiado Then
                                    controlAsistencia.IdFeriado = feriado.IdFeriado
                                End If
                                'Ahora insertamos el control de asistencia:
                                Me.SaveCONTROLASISTENCIA(controlAsistencia)
                            Next
                        Else ' Si no está programada una recuperación por feriado
                            Dim controlAsistencia As New ControlAsistencia
                            controlAsistencia.IdPeriodoLaboral = IdPeriodoLaboral
                            controlAsistencia.Fecha = FechaControl
                            controlAsistencia.HorasProgramadas = 0
                            If eSdescanso Then
                                controlAsistencia.CondicionPro = "D"
                            ElseIf eSferiado Then
                                controlAsistencia.CondicionPro = "DF"
                                controlAsistencia.IdFeriado = feriado.IdFeriado
                            End If
                            Me.SaveCONTROLASISTENCIA(controlAsistencia)
                        End If
                    Else 'si no es feriado ni descanso y podemos crear
                        For Each turnoRegular As TurnosRegulares In HorarioAsignado.HorarioEntity.ListaTurnosRegulares
                            Dim controlAsistencia As New ControlAsistencia
                            Dim cronogramaRecuperacion As New CronogramaRecuperacion
                            cronogramaRecuperacion = cronogramaRecuperacionRepository.GetCronogramaRecuperacionByFechaByIdTurnoByIdHorarioByIdJornadaTrabajo(FechaControl, turnoRegular.IdTurno, HorarioAsignado.HorarioEntity.IdHorario, HorarioAsignado.IdJornadaTrabajo)

                            Dim HI() As String
                            Dim HF() As String
                            Dim hix As Decimal
                            Dim hfx As Decimal

                            controlAsistencia.IdPeriodoLaboral = IdPeriodoLaboral
                            controlAsistencia.Fecha = FechaControl

                            controlAsistencia.HoraIngresoProg = turnoRegular.HoraInicio
                            controlAsistencia.HoraSalidaProg = turnoRegular.HoraFin
                            controlAsistencia.Turno = turnoRegular.Descripcion
                            controlAsistencia.CondicionPro = "T"
                            controlAsistencia.IdHorario = turnoRegular.IdHorario
                            controlAsistencia.IdJornadaTrabajo = turnoRegular.IdJornadaTrabajo
                            controlAsistencia.IdTurno = turnoRegular.IdTurno


                            If Not cronogramaRecuperacion Is Nothing Then
                                If cronogramaRecuperacion.HoraInicio = turnoRegular.HoraFin _
                                    Or cronogramaRecuperacion.HoraFin = turnoRegular.HoraInicio Then
                                    If cronogramaRecuperacion.HoraInicio = turnoRegular.HoraFin Then
                                        controlAsistencia.HoraSalidaProg = cronogramaRecuperacion.HoraFin
                                    Else
                                        controlAsistencia.HoraSalidaProg = turnoRegular.HoraFin
                                    End If

                                    If cronogramaRecuperacion.HoraFin = turnoRegular.HoraInicio Then
                                        controlAsistencia.HoraIngresoProg = cronogramaRecuperacion.HoraInicio
                                    Else
                                        controlAsistencia.HoraIngresoProg = turnoRegular.HoraInicio
                                    End If
                                Else
                                    'Por ver
                                End If
                                controlAsistencia.IdRecuperacion = cronogramaRecuperacion.IdRecuperacion
                            End If

                            HI = Split(controlAsistencia.HoraIngresoProg, ":")
                            HF = Split(controlAsistencia.HoraSalidaProg, ":")

                            hix = CDec(HI(0)) + CDec(HI(1)) / 60
                            hfx = CDec(HF(0)) + CDec(HF(1)) / 60

                            If hfx > hix Then
                                controlAsistencia.HorasProgramadas = hfx - hix
                            Else
                                controlAsistencia.HorasProgramadas = (24 - hfx) + hix
                            End If
                            Me.SaveCONTROLASISTENCIA(controlAsistencia)
                        Next
                    End If
                End If
            End If
            FechaControl = DateAdd(DateInterval.Day, 1, FechaControl)
        Loop

        Dim ausenciaRepository As New AusenciaRepository
        Dim listaAusencia As New List(Of Ausencia)
        Dim FI As DateTime
        Dim FF As DateTime

        listaAusencia = ausenciaRepository.GetAUSENCIAByIdPeriodoLaboralAndRangofechaControlAsistencia(IdPeriodoLaboral, FechaIni, FechaFin)

        For Each Ausencia As Ausencia In listaAusencia

            If FechaIni > Ausencia.FechaInicio Then
                FI = FechaIni
            Else
                FI = Ausencia.FechaInicio
            End If

            If FechaFin > Ausencia.FechaFin Then
                FF = Ausencia.FechaFin
            Else
                FF = FechaFin
            End If

            Dim FechaControlA As DateTime

            FechaControlA = FI

            If Ausencia.MotivoAusenciaEntity.codSunat = "23" Or _
                 Ausencia.MotivoAusenciaEntity.codSunat = "22" Or _
                 Ausencia.MotivoAusenciaEntity.codSunat = "21" Or _
                 Ausencia.MotivoAusenciaEntity.codSunat = "20" Then

                Do While FechaControlA <= FF
                    Dim listaControlAsistenciaA As New List(Of ControlAsistencia)
                    listaControlAsistenciaA = controlAsistenciaRepository.GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo(IdPeriodoLaboral, FechaControlA, "regular")

                    'Dim crearA As Boolean = True
                    ' eSdescanso = False
                    'eSferiado = False

                    ' verificamos si ya existen controles para esa fecha
                    If listaControlAsistenciaA.Count > 0 Then
                        'verificamos si dichos controles no están validados
                        For Each controlAsistenciaA As ControlAsistencia In listaControlAsistenciaA 'aqui debería ir un bucle que al encontrar la primera condción elimine y ya no vuelva a entrar
                            If Not String.IsNullOrEmpty(controlAsistenciaA.HoraIngresoReal) Or
                            Not String.IsNullOrEmpty(controlAsistenciaA.HoraSalidaReal) Then
                                'crearA = False
                                Dim controlAsistenciaActualizarA As New ControlAsistencia
                                controlAsistenciaActualizarA.IdControlAsistencia = controlAsistenciaA.IdControlAsistencia
                                controlAsistenciaActualizarA.IdPeriodoLaboral = controlAsistenciaA.IdPeriodoLaboral
                                controlAsistenciaActualizarA.CondicionPro = controlAsistenciaA.CondicionPro
                                controlAsistenciaActualizarA.CondicionReal = controlAsistenciaA.CondicionReal
                                controlAsistenciaActualizarA.Fecha = controlAsistenciaA.Fecha
                                controlAsistenciaActualizarA.HoraIngresoProg = controlAsistenciaA.HoraIngresoProg
                                controlAsistenciaActualizarA.HoraIngresoReal = controlAsistenciaA.HoraIngresoReal
                                controlAsistenciaActualizarA.HoraSalidaProg = controlAsistenciaA.HoraSalidaProg
                                controlAsistenciaActualizarA.HoraSalidaReal = controlAsistenciaA.HoraSalidaReal
                                controlAsistenciaActualizarA.HorasProgramadas = controlAsistenciaA.HorasProgramadas
                                controlAsistenciaActualizarA.HorasTrabajadas = controlAsistenciaA.HorasTrabajadas
                                controlAsistenciaActualizarA.IdRecuperacion = controlAsistenciaA.IdRecuperacion
                                controlAsistenciaActualizarA.IdResponsableControl = controlAsistenciaA.IdResponsableControl
                                controlAsistenciaActualizarA.Observacion = controlAsistenciaA.Observacion
                                controlAsistenciaActualizarA.TiempoTardanza = controlAsistenciaA.TiempoTardanza
                                controlAsistenciaActualizarA.tipo = "extra"
                                Me.SaveCONTROLASISTENCIA(controlAsistenciaActualizarA)

                            End If
                        Next
                        'eliminar el control existente.
                        Me.DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo(IdPeriodoLaboral, FechaControlA, "regular")
                    End If
                    'creamos un control por dia con el motivo de la ausencia.
                    Dim controlAsistenciaC As New ControlAsistencia
                    controlAsistenciaC.IdControlAsistencia = 0
                    controlAsistenciaC.IdPeriodoLaboral = IdPeriodoLaboral
                    controlAsistenciaC.CondicionPro = Ausencia.MotivoAusenciaEntity.Abreviatura
                    controlAsistenciaC.IdAusencia = Ausencia.IdAusencia
                    'controlAsistenciaC.HorasProgramadas = 
                    Me.SaveCONTROLASISTENCIA(controlAsistenciaC)
                    FechaControlA = DateAdd(DateInterval.Day, 1, FechaControlA)
                Loop
            ElseIf Ausencia.Tiempo = 0 Then
                Dim controlAsistenciaActualizar As New ControlAsistencia
                controlAsistenciaActualizar.IdPeriodoLaboral = IdPeriodoLaboral
                controlAsistenciaActualizar.CondicionReal = Ausencia.MotivoAusenciaEntity.Abreviatura
                controlAsistenciaActualizar.IdAusencia = Ausencia.IdAusencia
                Me.SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha(controlAsistenciaActualizar, FI, FF)
            End If
        Next
        'Me.GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha(IdPeriodoLaboral, FechaIni, FechaFin)
        Return listaControlAsistenciaDevolver

    End Function
    Public Function GetControlAsistenciaByIdPersonalAndByFecha(ByVal IdPersonal As Integer, ByVal Fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.ControlAsistencia) Implements IControlAsistenciaBL.GetControlAsistenciaByIdPersonalAndByFecha
        Return factoryrepository.GetControlAsistenciaByIdPersonalAndByFecha(IdPersonal, Fecha)
    End Function

    Public Sub UpdateCONTROLASISTENCIA(ByVal _controlAsistencia As BussinessEntities.ControlAsistencia) Implements IControlAsistenciaBL.UpdateCONTROLASISTENCIA
        factoryrepository.UpdateCONTROLASISTENCIA(_controlAsistencia)
    End Sub
End Class
