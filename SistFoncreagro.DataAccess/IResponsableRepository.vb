Imports SistFoncreagro.BussinessEntities
Public Interface IResponsableRepository
    Sub DeleteRESPONSABLE(ByVal IdResponsable As Int32)
    Sub SaveRESPONSABLE(ByVal _Responsable As Responsable)
    Function GetRESPONSABLEByIdControl(ByVal IdControl As Int32) As List(Of Responsable)
    Function GetRESPONSABLEByIdResponsable(ByVal IdResponsable As Int32) As Responsable
End Interface
