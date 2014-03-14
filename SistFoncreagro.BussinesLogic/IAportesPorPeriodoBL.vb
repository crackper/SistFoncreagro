Imports SistFoncreagro.BussinessEntities

Public Interface IAportesPorPeriodoBL
    Sub SaveAportesPorPeriodo(ByVal aportesPeriodo As AportesPorPeriodo)
    Sub SaveListaAportes1(ByVal aportePerido As List(Of AportesPorPeriodo))
    Sub UpdateListaAportes1(ByVal aportePerido As List(Of AportesPorPeriodo))
    Function GetFromAportePorPeridoAnterior(ByVal idPeriodoDeclaracionas As Int32) As AportesPorPeriodo
    Function GetFromAportePorPeriodoBandeja() As List(Of AportesPorPeriodo)
End Interface
