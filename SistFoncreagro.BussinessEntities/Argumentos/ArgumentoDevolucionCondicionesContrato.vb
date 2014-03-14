Public Class ArgumentoDevolucionCondicionesContrato
    Public Property DevolverCondicionesContrato As Boolean
    Public Property ArgCondContrato As ArgumentosCondicionesContrato
    Sub New(ByVal _devolverCondicionesContrato As Boolean, ByVal _ArgCondContrato As ArgumentosCondicionesContrato)
        DevolverCondicionesContrato = _devolverCondicionesContrato
        ArgCondContrato = _ArgCondContrato
    End Sub
End Class
