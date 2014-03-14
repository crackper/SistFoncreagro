Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class OrdenCentroCostoBL : Implements IOrdenCentroCostoBL
    Dim ordenCentroRepository As IOrdenCentroCostoRepository
    Sub New()
        ordenCentroRepository = New OrdenCentroCostoRepository
    End Sub
    Public Function GetAllFromOrdenCentroCostoByIdOrdenCompra(ByVal IdOrdenCOmpra As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCentroCosto) Implements IOrdenCentroCostoBL.GetAllFromOrdenCentroCostoByIdOrdenCompra
        Return ordenCentroRepository.GetAllFromOrdenCentroCostoByIdOrdenCompra(IdOrdenCOmpra)
    End Function

    Public Sub FinalizarRegOrdenCompraCentroCosto(ByVal IdOrdenCentroCosto As Object) Implements IOrdenCentroCostoBL.FinalizarRegOrdenCompraCentroCosto
        ordenCentroRepository.FinalizarRegOrdenCompraCentroCosto(IdOrdenCentroCosto)
    End Sub
End Class
