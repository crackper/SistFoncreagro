Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleComprobanteBL : Implements IDetalleComprobanteBL
    Dim factoryrepository As IDetalleComprobanteRepository
    Public Sub New()
        factoryrepository = New DetalleComprobanteRepository
    End Sub
    Public Sub DeleteDetalleComprobante(ByVal idDetalleComprobante As Integer) Implements IDetalleComprobanteBL.DeleteDetalleComprobante
        factoryrepository.DeleteDetalleComprobante(idDetalleComprobante)
    End Sub
    Public Sub SaveDetalleComprobante(ByVal detalleComprobante As BussinessEntities.DetalleComprobante) Implements IDetalleComprobanteBL.SaveDetalleComprobante
        factoryrepository.SaveDetalleComprobante(detalleComprobante)
    End Sub

    Public Function GetAllFromDetalleComprobanteByIdOcxFactura(ByVal idOcxFactura As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleComprobante) Implements IDetalleComprobanteBL.GetAllFromDetalleComprobanteByIdOcxFactura
        Return factoryrepository.GetAllFromDetalleComprobanteByIdOcxFactura(idOcxFactura)
    End Function
End Class
