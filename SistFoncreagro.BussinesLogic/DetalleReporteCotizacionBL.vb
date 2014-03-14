Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleReporteCotizacionBL : Implements IDetalleReporteCotizacionRepository
    Dim factoryRepository As IDetalleReporteCotizacionRepository
    Sub New()
        factoryRepository = New DetalleReporteCotizacionRepository
    End Sub

    Public Sub DeleteDetalleReporteCotizacion(ByVal IdDetalleReporteCotizacion As Integer) Implements DataAccess.IDetalleReporteCotizacionRepository.DeleteDetalleReporteCotizacion
        factoryRepository.DeleteDetalleReporteCotizacion(IdDetalleReporteCotizacion)
    End Sub

    Public Function GetAllFromDetalleReporteCotizacionByIdCotizacion(ByVal idCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleReporteCotizacion) Implements DataAccess.IDetalleReporteCotizacionRepository.GetAllFromDetalleReporteCotizacionByIdCotizacion
        Return factoryRepository.GetAllFromDetalleReporteCotizacionByIdCotizacion(idCotizacion)
    End Function

    Public Sub SaveDetalleReporteCotizacion(ByVal detalleReporteCotizacion As BussinessEntities.DetalleReporteCotizacion) Implements DataAccess.IDetalleReporteCotizacionRepository.SaveDetalleReporteCotizacion
        factoryRepository.SaveDetalleReporteCotizacion(detalleReporteCotizacion)
    End Sub

    Public Sub UpdateDetalleReporteCotizacion(ByVal detalleReporteCotizacion As BussinessEntities.DetalleReporteCotizacion) Implements DataAccess.IDetalleReporteCotizacionRepository.UpdateDetalleReporteCotizacion
        factoryRepository.UpdateDetalleReporteCotizacion(detalleReporteCotizacion)
    End Sub
End Class
