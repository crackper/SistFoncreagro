Public Class CuentaEnlace
    Public Property IdCtaEnlace As Int32
    Public Property Origen As String
    Public Property Destino As String
    Public Property CtaOperacion As System.Nullable(Of Int32)
    Public Property CtaPagar As System.Nullable(Of Int32)
    Public Property CtaCobrar As System.Nullable(Of Int32)
    Public Property Tipo As String
    Public Property Estado As String
    'Public Property PlanContable As PlanContable
    'Public Property PlanContable1 As PlanContable

    'Public ReadOnly Property CuentaPagar As String
    '    Get
    '        If CtaPagar.HasValue Then
    '            Return PlanContable.Codigo + " " + PlanContable.Nombre
    '        Else
    '            Return ""
    '        End If

    '    End Get
    'End Property
    'Public ReadOnly Property CuentaCobrar As String
    '    Get
    '        If CtaCobrar.HasValue Then
    '            Return PlanContable1.Codigo + " " + PlanContable1.Nombre
    '        Else
    '            Return ""
    '        End If

    '    End Get
    'End Property
   
End Class
