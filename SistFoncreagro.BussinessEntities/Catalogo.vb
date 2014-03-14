Public Class Catalogo

    Public Property IdCatalogo As Int32
    Public Property Tipo As String
    Public Property Codigo As String
    Public Property Descripcion As String
    Public Property IdMarca As Int32
    Public Property IdUnidadMedida As Int32
    Public Property IdClasificacionGeneral As Int32
    Public Property PrecioCompra As Decimal
    Public Property IdMonedaCompra As Int32
    Public Property AfectoIgv As Int32
    Public Property Observacion As String
    Public Property IdPersonal As Int32
    Public Property marca As Marca
    'Public Property unidadMedida As UnidadMedida
    Public Property clasificacion As Clasificacion

    Public ReadOnly Property CodigoDescripcion As String
        Get
            Return Codigo + " - " + Descripcion
        End Get
    End Property
    'Public ReadOnly Property NombreUnidad As String
    '    Get
    '        Return unidadMedida.Abreviacion
    '    End Get
    'End Property
    Public ReadOnly Property NombreClasificaion As String
        Get
            Return clasificacion.Descripcion
        End Get
    End Property
End Class
