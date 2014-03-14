Public Class TipoDocumento
    Public Property Codigo As String
    Public Property Estado As String
    Public Property IdTipoDocumento As Int32
    Public Property Nombre As String
    Public Property SujetoRetencion As String
    Public ReadOnly Property Documento As String
        Get
            Return Codigo + " " + Nombre
        End Get
    End Property
End Class
