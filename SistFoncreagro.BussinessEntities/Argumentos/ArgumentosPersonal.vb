Public Class ArgumentosPersonal

    Public Property DevolverPeriodoLaboralActual As Boolean
    Public Property DevolverContratoActual As Boolean
    Public Property DevolverCondicionesContratoActual As Boolean
    Public Property DevolverPosicionActual As ArgumentosPosicion
    Public Property DevolverJefeInmediato As ArgumentosPosicion
    Public Property DevolverArea As Boolean
    Public Property DevolverJefeAreaGeneral As Boolean
    Public Property DevolverProyectos As Boolean
    Public Property DevolverCategoria As Boolean
    Public Property DevolverTipoTrabajador As Boolean
    Public Property DevolverMotivoFinDePeriodo As Boolean
    Public Property DevolverListaTelefono As Boolean
    Public Property DevolverListaContratosConvenios As Boolean

    Sub New(ByVal _DevolverPeriodoLaboralActual As Boolean, ByVal _DevolverContratoActual As Boolean,
            ByVal _DevolverCondicionesContratoActual As Boolean, ByVal _DevolverPosicionActual As ArgumentosPosicion,
            ByVal _DevolverJefeInmediato As ArgumentosPosicion, ByVal _DevolverArea As Boolean,
            ByVal _DevolverJefeAreaGeneral As Boolean, ByVal _DevolverProyectos As Boolean,
            ByVal _DevolverCategoria As Boolean, ByVal _DevolverTipoTrabajador As Boolean,
            ByVal _DevolverMotivoFinDePeriodo As Boolean, ByVal _DevolverListaTelefono As Boolean,
            ByVal _DevolverListaContratosConvenios As Boolean)

        DevolverPeriodoLaboralActual = _DevolverPeriodoLaboralActual
        DevolverContratoActual = _DevolverContratoActual
        DevolverCondicionesContratoActual = _DevolverCondicionesContratoActual
        DevolverPosicionActual = _DevolverPosicionActual
        DevolverJefeInmediato = _DevolverJefeInmediato
        DevolverArea = _DevolverArea
        DevolverJefeAreaGeneral = _DevolverJefeAreaGeneral
        DevolverProyectos = _DevolverProyectos
        DevolverCategoria = _DevolverCategoria
        DevolverTipoTrabajador = _DevolverTipoTrabajador
        DevolverMotivoFinDePeriodo = _DevolverMotivoFinDePeriodo
        DevolverListaTelefono = _DevolverListaTelefono
        DevolverListaContratosConvenios = _DevolverListaContratosConvenios
    End Sub

End Class
