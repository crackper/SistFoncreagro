Imports SistFoncreagro.BussinessEntities
Public Interface ISustentoRepository
    Function GetSUSTENTOByIdControl(ByVal IdControl As Int32) As List(Of Sustento)
    Function GetSUSTENTOByIdDetalleEje(ByVal IdDetalleEje As Int32) As List(Of Sustento)
    Function GetSUSTENTOByIdSustento(ByVal IdSUstento As Int32) As Sustento
    Sub DeleteSUSTENTO(ByVal IdSustento As Int32)
    Sub SaveSUSTENTO(ByVal _Sustento As Sustento)
End Interface
