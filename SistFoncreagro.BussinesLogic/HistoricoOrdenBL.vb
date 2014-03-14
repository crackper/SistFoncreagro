Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class HistoricoOrdenBL : Implements IHistoricoOrdenBL
    Dim historyOrdenFactory As IHistoricoOrdenRepository
    Sub New()
        historyOrdenFactory = New HistoricoOrdenRepository
    End Sub

    Public Function GetAllFromHistoricoByIdOrdenCompra(ByVal IdOrdenCOmpra As Integer) As System.Collections.Generic.List(Of BussinessEntities.HistoricoOrden) Implements IHistoricoOrdenBL.GetAllFromHistoricoByIdOrdenCompra
        Return historyOrdenFactory.GetAllFromHistoricoByIdOrdenCompra(IdOrdenCOmpra)
    End Function

    Public Sub RechazarOrden(ByVal historicoOrden As BussinessEntities.HistoricoOrden) Implements IHistoricoOrdenBL.RechazarOrden
        historyOrdenFactory.RechazarOrden(historicoOrden)
    End Sub
End Class
