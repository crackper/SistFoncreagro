Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoPagoBL : Implements ITipoPagoBL

    Dim factoryRepsoitory As ITipoPagoRepository
    Sub New()
        factoryRepsoitory = New TipoPagoRepository
    End Sub

    Public Function GetAllFromTipoPago() As System.Collections.Generic.List(Of BussinessEntities.TipoPago) Implements ITipoPagoBL.GetAllFromTipoPago
        Return factoryRepsoitory.GetAllFromTipoPago
    End Function

    Public Sub SaveTipoPago(ByVal tipoPago As BussinessEntities.TipoPago) Implements ITipoPagoBL.SaveTipoPago
        factoryRepsoitory.SaveTipoPago(tipoPago)
    End Sub

    Public Function GetAllFromTipoPagoByIdTipo(ByVal idTipoPago As Integer) As BussinessEntities.TipoPago Implements ITipoPagoBL.GetAllFromTipoPagoByIdTipo
        Return factoryRepsoitory.GetAllFromTipoPagoByIdTipo(idTipoPago)
    End Function
End Class
