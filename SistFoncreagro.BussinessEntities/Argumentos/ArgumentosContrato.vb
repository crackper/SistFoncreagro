Public Class ArgumentosContrato
    Public Property DevolverCondicionesContratoActual As ArgumentosCondicionesContrato
    Public Property DevolverPeriodoLaboral As Boolean
    Public Property DevolverHorarioActual As Boolean
    
    Sub New(ByVal _devolverCondicionesContratoActual As ArgumentosCondicionesContrato, ByVal _devolverPeriodoLaboral As Boolean, ByVal _devolverHorarioActual As Boolean)
        DevolverCondicionesContratoActual = _devolverCondicionesContratoActual
        DevolverPeriodoLaboral = _devolverPeriodoLaboral
        DevolverHorarioActual = _devolverHorarioActual
    End Sub
End Class
