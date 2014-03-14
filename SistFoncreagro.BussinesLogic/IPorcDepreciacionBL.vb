Imports SistFoncreagro.BussinessEntities
Public Interface IPorcDepreciacionBL
    Sub SavePORCDEPRECIACION(ByVal _PorcDepreciacion As PorcDepreciacion)
    Sub DeletePORCDEPRECIACION(ByVal IdPorcDepreciacion As Int32)
    Function GetPORCDEPRECIACIONByIdPorcDepreciacion(ByVal IdPorcDepreciacion As Int32) As PorcDepreciacion
    Function GetAllFromPorcDepreciacion() As List(Of PorcDepreciacion)
End Interface
