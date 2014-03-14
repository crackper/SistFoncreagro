Public Class PeriodoDeclaracion
    Public Property IdPeriodoDeclaracion As Int32
    Public Property CodPeriodo As String
    Public Property Mes As String
    Public Property Anio As String

    Public ReadOnly Property NombreGeneral As String
        Get
            Return Mes & " - " & Anio
        End Get
    End Property
End Class
