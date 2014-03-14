Public Class ArgumentosCondicionesContrato
    Public Property DevolverContrato As Boolean
    Public Property DevolverPeriodoLaboral As Boolean
    Public Property DevolverPosicion As ArgumentosPosicion
    

    Sub New(ByVal _devolverContrato As Boolean, ByVal _devolverPeriodoLaboral As Boolean, ByVal _devolverPosicion As ArgumentosPosicion)
        DevolverContrato = _devolverContrato
        DevolverPeriodoLaboral = _devolverPeriodoLaboral
        DevolverPosicion = _devolverPosicion
    End Sub
End Class
