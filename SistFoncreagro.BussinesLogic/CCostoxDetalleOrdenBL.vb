Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CCostoxDetalleOrdenBL : Implements ICCostoxDetalleOrdenBL
    Dim factoryRepository As ICCostoxDetalleOrden
    Sub New()
        factoryRepository = New CCostoxDetalleOrdenRepository
    End Sub

    Public Function GetAllFromCCostoDetalleOrdenByIdDetalleOrden(ByVal idDetalleOrden As Integer) As System.Collections.Generic.List(Of BussinessEntities.CCostoxDetalleOrden) Implements ICCostoxDetalleOrdenBL.GetAllFromCCostoDetalleOrdenByIdDetalleOrden
        Return factoryRepository.GetAllFromCCostoDetalleOrdenByIdDetalleOrden(idDetalleOrden)
    End Function
End Class
