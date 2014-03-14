Public Class TurnosRegulares
    Public Property IdTurno As System.Nullable(Of Int32)
    Public Property IdHorario As System.Nullable(Of Int32)
    Public Property IdJornadaTrabajo As System.Nullable(Of Int32)
    Public Property Descripcion As String
    Public Property HoraInicio As String
    Public Property HoraFin As String

    Public ReadOnly Property DatosTurno As String
        Get
            Return Descripcion + ":" + HoraInicio + " - " + HoraFin
        End Get
    End Property

End Class
