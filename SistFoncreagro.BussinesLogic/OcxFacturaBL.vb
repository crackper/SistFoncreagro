Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class OcxFacturaBL : Implements IOcxFacturaBL
    Dim factoryrepository As IOcxFacturaRepository
    Public Sub New()
        factoryrepository = New OcxFacturaRepository
    End Sub
    Public Function GetAllFromOcxFacturaById(ByVal IdOcxFactura As Integer) As BussinessEntities.OcxFactura Implements IOcxFacturaBL.GetAllFromOcxFacturaById
        Return factoryrepository.GetAllFromOcxFacturaById(IdOcxFactura)
    End Function
    Public Function GetAllFromOcxFacturaByIdOrdenCompra(ByVal IdOrdenCompra As Integer) As System.Collections.Generic.List(Of BussinessEntities.OcxFactura) Implements IOcxFacturaBL.GetAllFromOcxFacturaByIdOrdenCompra
        Return factoryrepository.GetAllFromOcxFacturaByIdOrdenCompra(IdOrdenCompra)
    End Function
    Public Sub SaveOcxFactura(ByVal ocFac As BussinessEntities.OcxFactura) Implements IOcxFacturaBL.SaveOcxFactura
        factoryrepository.SaveOcxFactura(ocFac)
    End Sub
    Public Sub UpdateOcxFactura(ByVal ocFac As BussinessEntities.OcxFactura) Implements IOcxFacturaBL.UpdateOcxFactura
        factoryrepository.UpdateOcxFactura(ocFac)
    End Sub
    Public Sub DeletaOcxFactura(ByVal IdOcxFac As Integer) Implements IOcxFacturaBL.DeletaOcxFactura
        factoryrepository.DeletaOcxFactura(IdOcxFac)
    End Sub
    Public Sub RechazarOcxFactura(ByVal IdOcxFac As Integer, ByVal motivo As String) Implements IOcxFacturaBL.RechazarOcxFactura
        factoryrepository.RechazarOcxFactura(IdOcxFac, motivo)
    End Sub
    Public Function FinalizarRegistroComprobante(ByVal IdOcxFac As Integer) As Integer Implements IOcxFacturaBL.FinalizarRegistroComprobante
        Return factoryrepository.FinalizarRegistroComprobante(IdOcxFac)
    End Function
    Public Function GetAllFromOcxFacturaComprobante() As System.Collections.Generic.List(Of BussinessEntities.OcxFactura) Implements IOcxFacturaBL.GetAllFromOcxFacturaComprobante
        Return factoryrepository.GetAllFromOcxFacturaComprobante()
    End Function
    Public Function SaveOcxFacturaComprobante(ByVal ocFac As BussinessEntities.OcxFactura) As Integer Implements IOcxFacturaBL.SaveOcxFacturaComprobante
        Return factoryrepository.SaveOcxFacturaComprobante(ocFac)
    End Function
    Public Function UpdateOcxFacturaComprobante(ByVal ocFac As BussinessEntities.OcxFactura) As Integer Implements IOcxFacturaBL.UpdateOcxFacturaComprobante
        Return factoryrepository.UpdateOcxFacturaComprobante(ocFac)
    End Function
End Class
