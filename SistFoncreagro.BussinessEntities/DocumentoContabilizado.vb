Public Class DocumentoContabilizado
    Public Property IdDocumentoCont As Int32
    Public Property Codigo As String
    Public Property IdTipoDocumento As Int32
    Public Property IdMoneda As Int32
    Public Property Descripcion As String
    Public Property CtaIgv As Int32
    Public Property CtaDebe As Int32
    Public Property CtaHaber As Int32
    Public Property CtaDetraccion As Int32
    Public Property CtaRetencion As Int32
    Public Property AfectoIvap As String
    Public Property Estado As String
    Public Property Moneda As Moneda
    Public Property CtaIngresosIvap As System.Nullable(Of Int32)
    Public Property CtagastosIvap As System.Nullable(Of Int32)
    Public ReadOnly Property Documento As String
        Get
            Return Codigo + "  " + Descripcion + " - " + Moneda.Nombre
        End Get
    End Property
End Class
