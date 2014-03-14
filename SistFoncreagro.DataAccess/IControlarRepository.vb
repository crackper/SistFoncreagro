Imports SistFoncreagro.BussinessEntities
Public Interface IControlarRepository
    Function GetCONTROLARByIdDetalleEje(ByVal IdDetalleEje) As List(Of Controlar)
    Function GetCONTROLARByIdControl(ByVal IdControl As Int32) As Controlar
    Sub DeleteCONTROLAR(ByVal IdControl As Int32)
    Sub SaveCONTROLAR(ByVal _Controlar As Controlar)
End Interface
