Public Class Clasificacion
    Public Property IdClasificacion As Int32
    Public Property Descripcion As String
    Public Property Tipo As Int32
    Public Property IdPlan As Int32
    Public Property IdPlanDonacion As System.Nullable(Of Int32)
    Public Property IdPlanActivoFijo As System.Nullable(Of Int32)
    Public Property IdPorcDepreciacion As System.Nullable(Of Int32)
    Public Property IdPlanDepreciacion As System.Nullable(Of Int32)
    Public Property IdPlanDepreciacion1 As System.Nullable(Of Int32)
    Public Property Codigo As String
    Public Property Plan As PlanContable
    Public ReadOnly Property NombrePlan As String
        Get
            Return Plan.Nombre
        End Get
    End Property
End Class