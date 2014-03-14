Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleComprobanteRepository
    Sub SaveDetalleComprobante(ByVal detalleComprobante As DetalleComprobante)
    Sub DeleteDetalleComprobante(ByVal idDetalleComprobante As Int32)
    Function GetAllFromDetalleComprobanteByIdOcxFactura(ByVal idOcxFactura As Int32) As List(Of DetalleComprobante)
End Interface
