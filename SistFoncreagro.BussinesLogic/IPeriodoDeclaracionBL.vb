Imports SistFoncreagro.BussinessEntities
Public Interface IPeriodoDeclaracionBL
    Function SavePeriodoDeclaracion(ByVal periodoDeclaracion As PeriodoDeclaracion) As Int32
    Function GetAllFromPeriodoDeclaracion() As List(Of PeriodoDeclaracion)
    Function GetPeriodoDeclaracionByIdPeriodoDeclaracion(ByVal idPeriodoDeclaracion As Int32) As PeriodoDeclaracion
End Interface
