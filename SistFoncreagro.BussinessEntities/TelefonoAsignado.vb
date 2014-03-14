Public Class TelefonoAsignado
    Public Property IdAsignacionTelefono As System.Nullable(Of Int32)
    Public Property IdTelefCoorporativo As System.Nullable(Of Int32)
    Public Property IdPeriodoLaboral As System.Nullable(Of Int32)
    Public Property Estado As Boolean
    Public Property FechaAsignacion As DateTime

    Public Property TelefonoCoorporativoEntity As TelefonoCoorporativo
    Public Property periodoLaboralEntity As PeriodoLaboral
End Class
