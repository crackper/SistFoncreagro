Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EstadoOrdenCompraBL : Implements IEstadoOrdenCompraBL
    Dim estadoOrden As IEstadoOrdenCompraRepository
    Sub New()
        estadoOrden = New EstadoOrdenCompraRepository
    End Sub

    Public Function GetAllFromEstadoOrdenCompraByIdOrdenCompra(ByVal IdOrdenCompra As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoOrdenCompra) Implements IEstadoOrdenCompraBL.GetAllFromEstadoOrdenCompraByIdOrdenCompra
        Return estadoOrden.GetAllFromEstadoOrdenCompraByIdOrdenCompra(IdOrdenCompra)
    End Function
End Class
