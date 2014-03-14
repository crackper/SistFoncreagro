Imports SistFoncreagro.BussinessEntities
Public Interface IContratoConvenioRepository
    Function GetAllFromContratoConvenio(ByVal argContrato As ArgumentosContrato) As List(Of ContratoConvenio)
    Function GetAllContratoConvenioActuales(ByVal argContrato As ArgumentosContrato) As List(Of ContratoConvenio)
    Function GetContratoConvenioActualByIdPeriodoLaboral(ByVal idPeriodoLaboral As Int32, ByVal argContrato As ArgumentosContrato) As ContratoConvenio
    Function GetContratoConvenioIdPeriodoLaboralAndIdContrato(ByVal idPeriodoLaboral As Int32, ByVal idContrato As Int32, ByVal argContrato As ArgumentosContrato) As ContratoConvenio
    Function GetContratoConveniosIdPeriodoLaboral(ByVal idPeriodoLaboral As Int32, ByVal argContrato As ArgumentosContrato) As List(Of ContratoConvenio)
    Function GetContratosConveniosActivoByFechaAndIdPeriodoLaboral(ByVal Fecha As DateTime, ByVal IdPeriodoLaboral As Int32, ByVal argContrato As BussinessEntities.ArgumentosContrato) As ContratoConvenio
    Function GetUltimaFechaContratoByIdPeriodoLaboral(ByVal fecha As String)
    Function GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato(ByVal IdPeriodoLaboral As Int32, ByVal IdContrato As Int32) As String
    Function SaveContratosConvenios(ByVal contratoConvenio As ContratoConvenio) As Int32

    Sub DeleteContratoConvenio(ByVal idContrato As Int32, ByVal idPeriodoLaboral As Int32)
    Sub UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Int32, ByVal Estado As String)
    Sub UpdateArchivoContratos(ByVal IdPeriodoLaboral As Int32, ByVal IdContrato As Int32, ByVal Archivo As String)
End Interface
