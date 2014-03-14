Public Class CCostoxDetalleRequerimiento

    Public Property IdCCostoxDetalleRequerimiento As Int32
    Public Property IdDetalleRequerimiento As Int32
    Public Property IdCentroCosto As Int32
    Public Property centroCosto As CCosto
    Public Property nombreCatalogo As Catalogo

    Public ReadOnly Property nombreProducto As String
        Get
            Return nombreCatalogo.Descripcion
        End Get
    End Property

    Public ReadOnly Property CodigoCentroCosto As String
        Get
            Return centroCosto.Codigo & " - " & centroCosto.Unidad
        End Get
    End Property

    Function ccostoxDetalleRequerimiento() As Object
        Throw New NotImplementedException
    End Function

End Class
