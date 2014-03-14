Public Class Subdiario
    Public Property IdSubDiario As Int32
    Public Property Descripcion As String
    Public Property IdTipoProceso As Int32
    Public Property Estado As String
    Public Property IdOpFinanciera As Int32
    Public Property TipoProceso As TipoProceso
    Public Property OpeFinanciera As OperacionFinanciera

    Public ReadOnly Property Codigo As String
        Get
            Return IdSubDiario.ToString + " - " + Descripcion
        End Get
    End Property
    Public ReadOnly Property NomTipoProceso As String
        Get
            Return TipoProceso.Descripcion
        End Get
    End Property
    Public ReadOnly Property NomOpFinanciera As String
        Get
            Return OpeFinanciera.Descripcion
        End Get
    End Property
End Class
