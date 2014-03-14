Public Class AportesPorPeriodo
    Public Property IdPeridoDeclaracion As Int32
    Public Property IdSistemaPensiones As Integer
    Public Property IdAporteSp As Int32
    Public Property Porcentaje As Decimal
    Public Property IdAportesPorPerido As Int32
    Public Property Bandeja As Boolean
    Public Property peridoDeclaracion As PeriodoDeclaracion
    Public Property sistemaPensiones As SistemaDePensiones

    Public ReadOnly Property NombrePeridoDeclaracion As String
        Get
            Return peridoDeclaracion.Mes & " - " & peridoDeclaracion.Anio
        End Get
    End Property

    Public ReadOnly Property NombreSistemPensiones As String
        Get
            Return sistemaPensiones.Descripcion
        End Get
    End Property

    Public ReadOnly Property IdTipoSistemaPensiones As Int32
        Get
            Return sistemaPensiones.IdTipoSp
        End Get
    End Property
End Class
