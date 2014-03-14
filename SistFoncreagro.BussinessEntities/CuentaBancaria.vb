Public Class CuentaBancaria
    Public Property Descripcion As String
    Public Property IdBanco As Int32
    Public Property IdCtaBancaria As Int32
    Public Property IdMoneda As Int32
    Public Property IdPlan As Int32
    Public Property IdTipoCtaBancaria As Int32
    Public Property NroCta As String
    Public Property Saldo As Decimal
    Public Property Estado As String
    Public Property IdSubdiario As Int32
    Public Property Moneda As Moneda
    Public Property Banco As New Banco
    Public Property Plan As New PlanContable
    Public Property TipoCta As New TipoCtaBancaria
    Public Property SubDiario As New Subdiario
    Public ReadOnly Property NomBanco As String
        Get
            Return Banco.Nombre
        End Get
    End Property
    Public ReadOnly Property Cuenta As String
        Get
            Return Plan.Codigo
        End Get
    End Property
    Public ReadOnly Property Tipo As String
        Get
            Return TipoCta.Descripcion
        End Get
    End Property
    Public ReadOnly Property NomMoneda As String
        Get
            Return Moneda.Siglas
        End Get
    End Property
    Public ReadOnly Property NomSubDiario As String
        Get
            Return SubDiario.Descripcion
        End Get
    End Property
End Class
