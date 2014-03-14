Public Class Transaccion
    Public Property Idtransaccion As Int32
    Public Property IdOrdenCompra As System.Nullable(Of Int32)
    Public Property IdSubDiario As Int32
    Public Property Codigo As String
    Public Property FechaContable As DateTime
    Public Property IdOpFinanciera As System.Nullable(Of Int32)
    Public Property IdDocumentoCont As System.Nullable(Of Int32)
    Public Property SerieDocumento As String
    Public Property NroDocumento As Int64
    Public Property FechaDocumento As DateTime
    Public Property TipoCambio As Decimal
    Public Property Glosa As String
    Public Property DiasVencimiento As Int32
    Public Property FechaVencimiento As DateTime
    ' Public Property FechaVencimiento As System.Nullable(Of DateTime)
    Public Property IdTipoBaseImp As Int32
    Public Property IdTipoDocRef As Int32
    Public Property NroDocRef As Int32
    Public Property FechaDocRef As DateTime
    Public Property SerieDocRef As String
    Public Property TipoCambioDocRef As Decimal
    Public Property IdDetraccion As Int32
    Public Property Total As Decimal
    Public Property BaseImponible As Decimal
    Public Property MontoIgv As Decimal
    Public Property Otros As Decimal
    Public Property Anio As Int32
    Public Property Mes As Int32
    Public Property Usuario As Int32
    Public Property ValorIgv As Int32
    Public Property Estado As String
    Public Property IdProveedorCliente As System.Nullable(Of Int32)
    Public Property BaseInafecto As Decimal
    Public Property IdCtaBancaria As System.Nullable(Of Int32)
    Public Property NroCheque As String
    Public Property IdPersonal As Int32
    Public Property IdMoneda As Int32
    Public Property NroExoneracion As String
    Public Property MontoRetencion As Decimal
    Public Property AfectoIgv As String
    Public Property Flag As String
    Public Property IdProyecto As Int32
    Public Property Enlace As String
    Public Property IdTipoMedioPago As System.Nullable(Of Int32)
    Public Property DocumentoContabilizado As DocumentoContabilizado
    Public Property TipoDocumento As TipoDocumento
    Public Property OperacionFinanciera As OperacionFinanciera
    Public Property ProveedorCliente As ProveedorCliente
    Public Property AfectoSistPen As String
    Public Property IdAfp As System.Nullable(Of Int32)
    Public Property Comision As Decimal
    Public Property Seguro As Decimal
    Public Property MontoSistPen As Decimal
    Public Property AporteAfp As Decimal
    Public ReadOnly Property Registro As String
        Get
            If IdDocumentoCont.HasValue Then
                Return TipoDocumento.Codigo + " " + SerieDocumento + " " + NroDocumento.ToString
            Else
                Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property Operacion As String
        Get
            If IdOpFinanciera.HasValue Then
                Return OperacionFinanciera.Descripcion
            Else
                Return ""
            End If

        End Get
    End Property

    Public ReadOnly Property NombreProveedor
        Get
            If IdProveedorCliente.HasValue Then
                Return ProveedorCliente.Ruc & " - " & ProveedorCliente.RazonSocial
            Else
                Return ""
            End If

        End Get
    End Property
    Public ReadOnly Property Coa
        Get
            If IdProveedorCliente.HasValue Then
                Return ProveedorCliente.Ruc
            Else
                Return ""
            End If

        End Get
    End Property
End Class
