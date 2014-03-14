Imports SistFoncreagro.BussinessEntities
Public Interface ICondicionesContratoRepository
    Function GetAllFromCondicionesContrato(ByVal argCondContrato As ArgumentosCondicionesContrato) As List(Of CondicionesContrato)
    Function GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral(ByVal idCondicion As Int32, ByVal idContrato As Int32, ByVal idPeriodoLaboral As Int32, ByVal argCondContrato As ArgumentosCondicionesContrato) As CondicionesContrato
    Function GetCondicionesContratoByIdContratoByIdPeriodoLaboral(ByVal idContratoConvenio As Int32, ByVal idPeriodoLaboral As Int32, ByVal argCondContrato As ArgumentosCondicionesContrato) As List(Of CondicionesContrato)
    Function GetCondicionesContratoActualByIdContratoByIdPeriodo(ByVal idContratoConvenio As Int32, ByVal idPeriodoLaboral As Int32, ByVal argCondContrato As ArgumentosCondicionesContrato) As CondicionesContrato
    Function GetAllCondicionesContratoActual(ByVal argCondContrato As ArgumentosCondicionesContrato) As List(Of CondicionesContrato)
    Function GetCondicionesContratoValidasByFechaByIdContratoByIdPeriodo(ByVal Fecha As DateTime, ByVal IdContrato As Int32, ByVal IdPeriodoLaboral As Int32, ByVal argCondContrato As ArgumentosCondicionesContrato) As CondicionesContrato
    Function GetCondicionesContratoValidasByFechaByIdPosicion(ByVal Fecha As DateTime, ByVal IdPosicion As Int32) As List(Of CondicionesContrato)
    Function SaveCondicionesContrato(ByVal condicionContrato As CondicionesContrato) As Int32
    Sub DeleteCondicionContrato(ByVal idCondicion As Int32, ByVal idContrato As Int32, ByVal idPeriodoLaboral As Int32)
    Sub UpdateArchivoAdenda(ByVal IdPeriodoLaboral As Int32, ByVal IdContrato As Int32, ByVal Idcondicion As Int32, ByVal Archivo As String)

End Interface
