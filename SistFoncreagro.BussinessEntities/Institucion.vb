Public Class Institucion
    Public Property IdInstitucion As Int32
    Public Property IdConvenio As Int32
    Public Property IdProveedorCliente As Int32
    Public Property Tipo As String
    Public Property _Instituciones As ProveedorCliente

    Public ReadOnly Property NombreInstituciones As String
        Get
            Return _Instituciones.RazonSocial
        End Get
    End Property
End Class
