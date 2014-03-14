Public Class ProveedorCliente

    Public Property IdProveedorCliente As Int32
    Public Property Ruc As String
    Public Property RazonSocial As String
    Public Property Direccion As String
    Public Property Rubro As String
    Public Property Ciudad As String
    Public Property Web As String
    Public Property Mail As String
    Public Property Contacto As String
    Public Property Telefono1 As String
    Public Property Telefono2 As String
    Public Property Celular1 As String
    Public Property Celular2 As String
    Public Property Tipo As Int32
    Public Property IdTipoDocumento As Int32
    Public Property Idusuario As Int32
    Public Property TipoCuenta As String
    Public Property CuentaAbono As String
    Public Property IdMoneda As Int32
    Public Property TipoPersona As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property PrimerNombre As String
    Public Property SegundoNombre As String
    Public Property NombreComercial As String
    Public Property InternoExterno As Boolean
    Public ReadOnly Property NombreProveedor
        Get
            Return Ruc & " - " & RazonSocial
        End Get
    End Property


End Class
