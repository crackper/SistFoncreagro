Imports SistFoncreagro.BussinessEntities
Public Interface IBonificacionVentaRepository
    Sub SaveBONIFICACIONVENTA(ByVal _Bonificacion As BonificacionVenta)
    Sub DeleteBONIFICACIONVENTA(ByVal IdBonificacion As Int32)
    Function GetBONIFICACIONVENTAByIdBonificacion(ByVal IdBonificacion As Int32) As BonificacionVenta
    Function GetBONIFICACIONVENTAByIdVenta(ByVal IdVenta As Int32) As List(Of BonificacionVenta)
End Interface
