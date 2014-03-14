Public Class Detraccion

    Public Property IdDetraccion As Int32
    Public Property ElementoAfecto As String
    Public Property Porcentaje As Decimal
    Public Property CtaCargo As System.Nullable(Of Int32)
    Public Property CtaAbono As System.Nullable(Of Int32)
    Public Property Estado As String
    Public Property Codigo As String
    Public Property PlanContableAbono As PlanContable
    Public ReadOnly Property Detraccion As String
        Get
            Return ElementoAfecto + "  " + Porcentaje.ToString + "%"
        End Get
    End Property
    Public ReadOnly Property CuentaAbono As String
        Get
            Return PlanContableAbono.Codigo
        End Get
    End Property

    ''Modificado
End Class
