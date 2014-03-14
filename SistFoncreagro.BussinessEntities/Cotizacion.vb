Public Class Cotizacion
    Public Property IdCotizacion As Int32
    Public Property IdComprador As Int32
    Public Property IdTipoCotizacion As Int32
    Public Property IdRequerimiento As Int32
    Public Property IdMoneda As Int32
    Public Property Nombre As String
    Public Property Estado As String
    Public Property FechaRegistro As Date
    Public Property Observaciones As String
    Public Property comprador As Personal
    Public Property detalleReqCoti As List(Of DetalleReqCotizacion)
    Public Property NroRequerimiento As String
    Public Property CodigoArea As String
    Public Property IdRazon As Int32
    Public Property IdResponsable As Int32
    Public ReadOnly Property NombreComprador As String
        Get
            Return comprador.nombreCompleto
        End Get
    End Property
End Class
