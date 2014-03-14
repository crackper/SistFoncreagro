Public Class ControlAsistencia
    Public Property IdControlAsistencia As System.Nullable(Of Int32)
    Public Property IdPeriodoLaboral As System.Nullable(Of Int32)
    Public Property IdResponsableControl As System.Nullable(Of Int32)
    Public Property Fecha As System.Nullable(Of DateTime)
    Public Property Turno As String
    Public Property HoraIngresoProg As String
    Public Property HoraSalidaProg As String
    Public Property CondicionPro As String
    Public Property HoraIngresoReal As String
    Public Property HoraSalidaReal As String
    Public Property CondicionReal As String
    Public Property HorasProgramadas As System.Nullable(Of Decimal)
    Public Property HorasTrabajadas As System.Nullable(Of Decimal)
    Public Property HorasExtra As System.Nullable(Of Decimal)
    Public Property TiempoTardanza As System.Nullable(Of Decimal)
    Public Property tipo As String
    Public Property IdRecuperacion As System.Nullable(Of Int32)
    Public Property IdFeriado As System.Nullable(Of Int32)
    Public Property IdAusencia As System.Nullable(Of Int32)
    Public Property IdTurno As System.Nullable(Of Int32)
    Public Property IdHorario As System.Nullable(Of Int32)
    Public Property IdJornadaTrabajo As System.Nullable(Of Int32)
    Public Property Observacion As String
    'Public Property PeriodoLaboral As PeriodoLaboral
    'Public Property Personal As Personal
    'Public ReadOnly Property NombrePersonal As String
    '    Get
    '        Return Personal.nombreCompleto
    '    End Get
    'End Property
End Class
