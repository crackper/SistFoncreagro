Public Class ElementoGasto
    Public Property IdElemGasto As Int32
    Public Property CodElemGasto As String
    Public Property NomElemGasto As String
    Public Property DesElemGasto As String
    Public Property IdClasificacion As Int32
    Public Property _Clasificacion As Clasificacion

    Public ReadOnly Property DescripClasif As String
        Get
            Return _Clasificacion.Descripcion
        End Get
    End Property
End Class
