Imports SistFoncreagro.BussinessEntities
Public Interface IResponsableBienMuebleRepository
    Function GetRESPONSABLEBIENMUEBLEByIdResponsable(ByVal IdResponsable As Int32) As ResponsableBienMueble
    Function GetRESPONSABLEBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Int32) As List(Of ResponsableBienMueble)
    Sub DeleteRESPONSABLEBIENMUEBLE(ByVal IdResponsable As Int32)
    Sub SaveRESPONSABLEBIENMUEBLE(ByVal _ResponsableBienMueble As ResponsableBienMueble)
End Interface
