Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AportesPorPeriodoBL : Implements IAportesPorPeriodoBL
    Dim factoryRepository As IAportesPorPeriodoRepository
    Sub New()
        factoryRepository = New AportesPorPeriodoRepository
    End Sub
    Public Sub SaveAportesPorPeriodo(ByVal aportesPeriodo As BussinessEntities.AportesPorPeriodo) Implements IAportesPorPeriodoBL.SaveAportesPorPeriodo
        factoryRepository.SaveAportesPorPeriodo(aportesPeriodo)
    End Sub

    Public Function GetFromAportePorPeridoAnterior(ByVal idPeriodoDeclaracionas As Integer) As BussinessEntities.AportesPorPeriodo Implements IAportesPorPeriodoBL.GetFromAportePorPeridoAnterior
        Return factoryRepository.GetFromAportePorPeridoAnterior(idPeriodoDeclaracionas)
    End Function

    Public Sub SaveListaAportes1(ByVal aportePerido As System.Collections.Generic.List(Of BussinessEntities.AportesPorPeriodo)) Implements IAportesPorPeriodoBL.SaveListaAportes1
        Try
            factoryRepository.SaveListaAportes1(aportePerido)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Function GetFromAportePorPeriodoBandeja() As System.Collections.Generic.List(Of BussinessEntities.AportesPorPeriodo) Implements IAportesPorPeriodoBL.GetFromAportePorPeriodoBandeja
        Return factoryRepository.GetFromAportePorPeriodoBandeja()
    End Function

    Public Sub UpdateListaAportes1(ByVal aportePerido As System.Collections.Generic.List(Of BussinessEntities.AportesPorPeriodo)) Implements IAportesPorPeriodoBL.UpdateListaAportes1
        factoryRepository.UpdateListaAportes1(aportePerido)
    End Sub
End Class
