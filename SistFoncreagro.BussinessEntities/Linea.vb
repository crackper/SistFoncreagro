Public Class Linea
    Public Property IdLinea As Int32
    Public Property IdTransaccion As Int32
    Public Property IdPlan As Int32
    Public Property MontoCargo As Decimal
    Public Property MontoAbono As Decimal
    Public Property Glosa As String
    Public Property IdCCosto As System.Nullable(Of Int32)
    Public Property IdProveedorCliente As System.Nullable(Of Int32)
    Public Property IdTipoDocumento As System.Nullable(Of Int32)
    Public Property NroDocumento As System.Nullable(Of Int64)
    Public Property SerieDocumento As String
    Public Property FechaDocumento As DateTime
    Public Property Flag As String
    Public Property CtaEnlace As String
    Public Property CCosto As CCosto
    Public Property PlanContable As PlanContable
    Public Property TipoDocumento As TipoDocumento
    Public Property TipoCambio As Decimal
    Public Property Estado As String
    Public Property IdMoneda As Int32
    Public Property CargoMN As Decimal
    Public Property CargoME As Decimal
    Public Property AbonoMN As Decimal
    Public Property AbonoME As Decimal
    Public Property Enlace As String
    Public Property FechaPago As Nullable(Of DateTime)
    Public Property FechaVencimiento As Nullable(Of DateTime)
    Public Property Proveedor As ProveedorCliente
    Public Property Transaccion As Transaccion
    Public ReadOnly Property Registro As String
        Get
            If IdTipoDocumento.HasValue Then
                Return TipoDocumento.Codigo + " " + SerieDocumento + " " + NroDocumento.ToString
            Else
                Return ""
            End If
        End Get


    End Property
    Public ReadOnly Property Cuenta As String
        Get
            Return PlanContable.Codigo + " " + PlanContable.Nombre
        End Get
    End Property
    Public ReadOnly Property Coa As String
        Get
            If IdProveedorCliente.HasValue Then
                Return Proveedor.Ruc
            Else
                Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property Codigo As String
        Get
            Return Transaccion.IdSubDiario.ToString + "-" + Transaccion.Codigo
        End Get
    End Property
    Public ReadOnly Property CentroCosto As String
        Get
            If IdCCosto.HasValue Then
                Return CCosto.Codigo
            Else
                Return ""
            End If
        End Get
    End Property
End Class
