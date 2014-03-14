Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class HistoricoRequerimientoBL : Implements IHistoricoRequerimientoBL
    Dim historyRequerimientoFactory As IHistoricoRequerimientoRepository
    Sub New()
        historyRequerimientoFactory = New HistoricoRequerimientoRepository
    End Sub

    Public Function GetAllFromHistoricoByIdRequerimiento(ByVal idRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.HistoricoRequerimiento) Implements IHistoricoRequerimientoBL.GetAllFromHistoricoByIdRequerimiento
        Return historyRequerimientoFactory.GetAllFromHistoricoByIdRequerimiento(idRequerimiento)
    End Function

    Public Sub RechazarRequerimiento(ByVal historicoReq As BussinessEntities.HistoricoRequerimiento) Implements IHistoricoRequerimientoBL.RechazarRequerimiento
        historyRequerimientoFactory.RechazarRequerimiento(historicoReq)
    End Sub
End Class
