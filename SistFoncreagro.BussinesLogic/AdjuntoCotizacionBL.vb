Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AdjuntoCotizacionBL : Implements IAdjuntoCotizacionBL
    Dim factoryRepository As IAdjuntoCotizacionRepository
    Public Sub New()
        factoryRepository = New AdjuntoCotizacionRepository
    End Sub

    Public Sub DeleteadjuntoCotizacion(ByVal IdAdjuntoCotizacion As Integer) Implements IAdjuntoCotizacionBL.DeleteadjuntoCotizacion
        factoryRepository.DeleteadjuntoCotizacion(IdAdjuntoCotizacion)
    End Sub

    Public Function GetAllFromAdjuntoCotizacionByIdCotizacion(ByVal idCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.AdjuntoCotizacion) Implements IAdjuntoCotizacionBL.GetAllFromAdjuntoCotizacionByIdCotizacion
        Return factoryRepository.GetAllFromAdjuntoCotizacionByIdCotizacion(idCotizacion)
    End Function

    Public Sub SaveAdjuntoCotizacion(ByVal adjunto As BussinessEntities.AdjuntoCotizacion) Implements IAdjuntoCotizacionBL.SaveAdjuntoCotizacion
        factoryRepository.SaveAdjuntoCotizacion(adjunto)
    End Sub
End Class
