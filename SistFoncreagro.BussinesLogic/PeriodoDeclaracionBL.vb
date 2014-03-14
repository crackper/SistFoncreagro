Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PeriodoDeclaracionBL : Implements IPeriodoDeclaracionBL
    Dim factoryRepository As IPeriodoDeclaracionRepository
    Sub New()
        factoryRepository = New PeriodoDeclaracionRepository
    End Sub
    Public Function GetAllFromPeriodoDeclaracion() As System.Collections.Generic.List(Of BussinessEntities.PeriodoDeclaracion) Implements IPeriodoDeclaracionBL.GetAllFromPeriodoDeclaracion
        Return factoryRepository.GetAllFromPeriodoDeclaracion
    End Function

    Public Function GetPeriodoDeclaracionByIdPeriodoDeclaracion(ByVal idPeriodoDeclaracion As Integer) As BussinessEntities.PeriodoDeclaracion Implements IPeriodoDeclaracionBL.GetPeriodoDeclaracionByIdPeriodoDeclaracion
        Return factoryRepository.GetPeriodoDeclaracionByIdPeriodoDeclaracion(idPeriodoDeclaracion)
    End Function

    Public Function SavePeriodoDeclaracion(ByVal periodoDeclaracion As BussinessEntities.PeriodoDeclaracion) As Integer Implements IPeriodoDeclaracionBL.SavePeriodoDeclaracion
        Return factoryRepository.SavePeriodoDeclaracion(periodoDeclaracion)
    End Function
End Class
