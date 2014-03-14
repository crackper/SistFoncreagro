Imports SistFoncreagro.BussinessEntities
Public Interface ILimiteRCRepository
    Function GetLimiteRCByIdDetalleConcepto(ByVal IdDetalleConcepto As Int32) As List(Of LimitesRC)
    Function SaveLimeteRC(ByVal limiteRC As LimitesRC) As Int32
    Sub DeleteLIMITESRC(ByVal IdLimitesRC As Int32)
End Interface
