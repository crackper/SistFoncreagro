Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class DetOcxFacturaBL : Implements IDetOcxFacturaBL
    Dim factoryRep As IDetOcxFacturaRepository
    Sub New()
        factoryRep = New DetOcxFacturaRepository
    End Sub
    Public Sub DeleteDetOcxFactura(ByVal IdDetOc As Integer) Implements IDetOcxFacturaBL.DeleteDetOcxFactura
        factoryRep.DeleteDetOcxFactura(IdDetOc)
    End Sub

    Public Function GetAllFromDetOcxFacturaById(ByVal idOcFact As Object) As System.Collections.Generic.List(Of BussinessEntities.DetOcxFactura) Implements IDetOcxFacturaBL.GetAllFromDetOcxFacturaById
        Return factoryRep.GetAllFromDetOcxFacturaById(idOcFact)
    End Function

    Public Sub SaveDetOcxFactura(ByVal detOcxFact As BussinessEntities.DetOcxFactura) Implements IDetOcxFacturaBL.SaveDetOcxFactura
        factoryRep.SaveDetOcxFactura(detOcxFact)
    End Sub

    Public Sub SaveDetOcxFactura1(ByVal detOcxFact As System.Collections.Generic.List(Of BussinessEntities.DetOcxFactura)) Implements IDetOcxFacturaBL.SaveDetOcxFactura1
        factoryRep.SaveDetOcxFactura1(detOcxFact)
    End Sub

    Public Sub FinalizarRegistroDetOcxFactura(ByVal idOcFact As Integer) Implements IDetOcxFacturaBL.FinalizarRegistroDetOcxFactura
        factoryRep.FinalizarRegistroDetOcxFactura(idOcFact)
    End Sub

    Public Sub SaveDetOcxFacturaPrec(ByVal detOcxFact As BussinessEntities.DetOcxFactura) Implements IDetOcxFacturaBL.SaveDetOcxFacturaPrec
        factoryRep.SaveDetOcxFacturaPrec(detOcxFact)
    End Sub

    Public Sub SaveDetOcxFacturaPrec1(ByVal detOcxFact As System.Collections.Generic.List(Of BussinessEntities.DetOcxFactura)) Implements IDetOcxFacturaBL.SaveDetOcxFacturaPrec1
        factoryRep.SaveDetOcxFacturaPrec1(detOcxFact)
    End Sub
End Class
