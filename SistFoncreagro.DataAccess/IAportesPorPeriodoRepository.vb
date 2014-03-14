Imports SistFoncreagro.BussinessEntities
Public Interface IAportesPorPeriodoRepository
    Sub SaveAportesPorPeriodo(ByVal aportesPeriodo As AportesPorPeriodo)
    Sub SaveListaAportes(ByVal aportePerido As AportesPorPeriodo)
    Sub SaveListaAportes1(ByVal aportePerido As List(Of AportesPorPeriodo))
    Function GetFromAportePorPeridoAnterior(ByVal idPeriodoDeclaracionas As Int32) As AportesPorPeriodo
    Function GetFromAportePorPeriodoBandeja() As List(Of AportesPorPeriodo)
    Sub UpdateListaAportes(ByVal aportePerido As AportesPorPeriodo)
    Sub UpdateListaAportes1(ByVal aportePerido As List(Of AportesPorPeriodo))

    Function GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP(ByVal IdPeriodoDeclaracion As Int32, ByVal IdSistemaPensiones As Int32, ByVal IdAporteSP As Int32) As AportesPorPeriodo

End Interface
