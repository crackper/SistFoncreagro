Imports SistFoncreagro.BussinessEntities
Public Interface IAdjuntoRequerimientoRepository
    Sub SaveAdjuntoRequerimiento(ByVal adjunto As AdjuntoRequerimiento)
    Sub DeleteadjuntoRequerimiento(ByVal IdAdjuntoRequerimiento As Int32, ByVal IdRequerimiento As Int32)
    Function GetAllFromAdjuntoReqByIdReq(ByVal IdRequerimiento As Int32) As List(Of AdjuntoRequerimiento)
End Interface
