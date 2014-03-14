Public Class HistoricoOrden
    Public Property IdHistorico As Int32
    Public Property IdOrden As Int32
    Public Property IdPersonal As Int32
    Public Property Fecha As System.Nullable(Of Date)
    Public Property Motivo As String
    Public Property DetalleAprobacion As String
    Public personaRechaza As Personal
    Public ReadOnly Property NombrePersonaRechaza As String
        Get
            Return personaRechaza.nombreCompleto
        End Get
    End Property

End Class
