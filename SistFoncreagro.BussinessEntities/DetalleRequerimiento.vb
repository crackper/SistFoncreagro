Public Class DetalleRequerimiento
    Public Property IdDetalleRequerimiento As Int32
    Public Property IdRequerimiento As Int32
    Public Property IdCatalogo As Int32
    Public Property IdUnidadMedida As Int32
    Public Property observacion As String
    Public Property Cantidad As Decimal
    Public Property PrecioCompra As Decimal
    Public Property AfectoIgv As Boolean
    Public Property IdCentroCosto As Integer
    Public Property Estado As Integer
    Public Property cat As Catalogo
    Public Property unidad As UnidadMedida
    Public ReadOnly Property nombreCatalogo As String
        Get
            Return cat.Descripcion
        End Get
    End Property

    Public ReadOnly Property codigoCatalogo As String
        Get
            Return cat.Codigo
        End Get
    End Property

    Public ReadOnly Property unidadAbreviatura As String
        Get
            Return unidad.Abreviacion
        End Get
    End Property

    Public ReadOnly Property SubTotal As Decimal
        Get
            Return Cantidad * PrecioCompra
        End Get
    End Property
End Class
