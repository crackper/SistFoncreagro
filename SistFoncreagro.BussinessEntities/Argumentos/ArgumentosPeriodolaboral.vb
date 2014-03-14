Public Class ArgumentosPeriodolaboral
    Public Property DevolverPersonal As ArgumentosPersonal
    Public Property DevolverContratoActual As ArgumentosContrato
    Public Property DevolverCategoria As Boolean
    Public Property DevolverTipoTrabajador As Boolean
    Public Property DevolverMotivoFinDePeriodo As Boolean
    Public Property DevolverListaTelefono As Boolean
    Public Property DevolverListaContratosConvenios As Boolean

    Sub New(ByVal _DevolverPersonal As ArgumentosPersonal, ByVal _DevolverContratoActual As ArgumentosContrato,
            ByVal _DevolverCategoria As Boolean, ByVal _DevolverTipoTrabajador As Boolean,
            ByVal _DevolverMotivoFinDePeriodo As Boolean, ByVal _DevolverListaTelefono As Boolean,
            ByVal _DevolverListaContratosConvenios As Boolean)

        DevolverPersonal = _DevolverPersonal
        DevolverContratoActual = _DevolverContratoActual
        DevolverCategoria = _DevolverCategoria
        DevolverTipoTrabajador = _DevolverTipoTrabajador
        DevolverMotivoFinDePeriodo = _DevolverMotivoFinDePeriodo
        DevolverListaTelefono = _DevolverListaTelefono
        DevolverListaContratosConvenios = _DevolverListaContratosConvenios
    End Sub
End Class
