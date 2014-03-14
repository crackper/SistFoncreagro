Public Class OcxFactura
    Public Property IdOcxFactura As Int32
    Public Property IdOrdenCompra As Int32
    Public Property Serie As String
    Public Property Numero As String
    Public Property Monto As Decimal
    Public Property Fecha As Date
    Public Property IdTipoDocumento As Int32
    Public Property NroOrden As String
    Public Property Area As String
    Public Property NombreTipoDoc As String
    Public Property TipoRendicion As Int32
    Public Property Finalizado As Boolean
    Public Property IdArea As Int32
    Public Property IdProveedor As Int32
    Public Property IdMoneda As Int32
    Public Property NroVales As Int32
    Public Property Observaciones As String
    Public Property NombreArea As String
    Public Property NombreProveedor As String
    Public Property FechaRecepcion As Date
    Public ReadOnly Property NombreDocumento As String
        Get
            Return Serie & " - " & Numero
        End Get
    End Property
End Class
