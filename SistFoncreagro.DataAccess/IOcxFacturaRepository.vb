Imports SistFoncreagro.BussinessEntities
Public Interface IOcxFacturaRepository
    Sub SaveOcxFactura(ByVal ocFac As OcxFactura)
    Sub UpdateOcxFactura(ByVal ocFac As OcxFactura)
    Sub DeletaOcxFactura(ByVal IdOcxFac As Int32)
    Sub RechazarOcxFactura(ByVal IdOcxFac As Int32, ByVal motivo As String)
    Function GetAllFromOcxFacturaById(ByVal IdOcxFactura As Int32) As OcxFactura
    Function GetAllFromOcxFacturaByIdOrdenCompra(ByVal IdOrdenCompra As Int32) As List(Of OcxFactura)
    Function SaveOcxFacturaComprobante(ByVal ocFac As OcxFactura) As Int32
    Function UpdateOcxFacturaComprobante(ByVal ocFac As OcxFactura) As Int32
    Function GetAllFromOcxFacturaComprobante() As List(Of OcxFactura)
    Function FinalizarRegistroComprobante(ByVal IdOcxFac As Int32) As Int32
End Interface
