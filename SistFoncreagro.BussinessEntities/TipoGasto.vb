Public Class TipoGasto
    Public Property IdTipoGasto As Int32
    Public Property Descripcion As String
    Public Property IdPlan As System.Nullable(Of Int32)
    Public Property PlanContable As PlanContable
    Public ReadOnly Property Cuenta As String
        Get
            If IdPlan.HasValue Then
                Return PlanContable.Codigo + " " + PlanContable.Nombre
            Else
                Return ""
            End If

        End Get
    End Property
End Class
