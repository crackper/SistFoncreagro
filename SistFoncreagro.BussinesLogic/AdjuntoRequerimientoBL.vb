Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AdjuntoRequerimientoBL : Implements IAdjuntoRequerimientoBL

    Dim fAdjuntoReq As IAdjuntoRequerimientoRepository
    Sub New()
        fAdjuntoReq = New AdjuntoRequerimientoRepository
    End Sub
    Public Sub DeleteadjuntoRequerimiento(ByVal IdAdjuntoRequerimiento As Integer, ByVal IdRequerimiento As Integer) Implements IAdjuntoRequerimientoBL.DeleteadjuntoRequerimiento
        fAdjuntoReq.DeleteadjuntoRequerimiento(IdAdjuntoRequerimiento, IdRequerimiento)
    End Sub
    Public Function GetAllFromAdjuntoReqByIdReq(ByVal IdRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.AdjuntoRequerimiento) Implements IAdjuntoRequerimientoBL.GetAllFromAdjuntoReqByIdReq
        Return fAdjuntoReq.GetAllFromAdjuntoReqByIdReq(IdRequerimiento)
    End Function

    Public Sub SaveAdjuntoRequerimiento(ByVal adjunto As BussinessEntities.AdjuntoRequerimiento) Implements IAdjuntoRequerimientoBL.SaveAdjuntoRequerimiento
        fAdjuntoReq.SaveAdjuntoRequerimiento(adjunto)
    End Sub
End Class
