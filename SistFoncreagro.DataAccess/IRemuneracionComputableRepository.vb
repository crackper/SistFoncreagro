Imports SistFoncreagro.BussinessEntities
Public Interface IRemuneracionComputableRepository
    Function GetRemuneracionComputableIdDetalleConcepto(ByVal IdDetalleConcepto As Int32) As List(Of REMUNERACIONCOMPUTABLE)
    Function SaveREMUNERACIONCOMPUTABLE(ByVal remuneracionComputable As REMUNERACIONCOMPUTABLE) As Int32
    Sub DeleteREMUNERACIONCOMPUTABLE(ByVal IdRemComputable As Int32)
End Interface
