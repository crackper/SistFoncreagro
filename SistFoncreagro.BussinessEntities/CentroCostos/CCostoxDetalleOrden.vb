Public Class CCostoxDetalleOrden
    Public Property IdCCostoxDetalleOrdenComrpa As Int32
    Public Property IdDetalleOrdenCompra As Int32
    Public Property IdCentroCosto As Int32
    Public Property centroCosto As CCosto

    Public ReadOnly Property CodigoCentroCosto As String
        Get
            Return centroCosto.Codigo & " - " & centroCosto.Unidad
        End Get
    End Property

End Class

