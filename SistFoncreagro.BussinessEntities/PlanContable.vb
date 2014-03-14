Public Class PlanContable
    Public Property IdPlan As Int32
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property IdTipoCtaCont As System.Nullable(Of Int32)
    Public Property Nivel As String
    Public Property IdEstFinanciero As System.Nullable(Of Int32)
    Public Property CtaPrincipal As System.Nullable(Of Int32)
    Public Property CtaOpcional As System.Nullable(Of Int32)
    Public Property IdTipoCancelacion As System.Nullable(Of Int32)
    Public Property RequiereCodAux As String
    Public Property RequiereCCosto As String
    Public Property RequiereRegistro As String
    Public Property IdTipoAjuste As System.Nullable(Of Int32)
    Public Property CtaGanancia As System.Nullable(Of Int32)
    Public Property CtaPerdida As System.Nullable(Of Int32)
    Public Property IdAplTipoCambio As System.Nullable(Of Int32)
    Public Property GenerarDestino As String
    Public Property CtaCargo As System.Nullable(Of Int32)
    Public Property CtaAbono As System.Nullable(Of Int32)
    Public Property Estado As String
    Public Property IdMoneda As System.Nullable(Of Int32)
    Public ReadOnly Property Cuenta As String
        Get
            Return Codigo + " " + Nombre
        End Get
    End Property
    Public ReadOnly Property DscEstado As String
        Get
            If Estado = "A" Then
                Return "Activo"
            Else
                Return "Inactivo"
            End If
        End Get
    End Property
End Class
