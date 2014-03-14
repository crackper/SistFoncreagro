
Public Class CCosto

    Public Property IdCCosto As Int32
    Public Property Codigo As String
    Public Property IdProyAct As Int32
    Public Property IdElemGasto As Int32
    Public Property Unidad As String
    Public Property Porcentaje As Decimal
    Public Property _ElementoGasto As ElementoGasto
    Public Property _ProyAct As ProyAct
    Public Property _ProyComp As ProyComp
    Public Property _Actividad As Actividad
    Public Property _Componente As Componente
    Public Property _ConvProy As ConveProy
    Public Property _Convenio As Convenio
    Public Property _Proyecto As Proyecto
    Public Property IdOrdenCompra As Int32
    Public ReadOnly Property CodigoElementoGasto As String
        Get
            Return Codigo + "-" + _ElementoGasto.NomElemGasto
        End Get
    End Property
End Class

