Imports SistFoncreagro.BussinessEntities
Public Interface IUnidadMedidaBL
    Function GetAllFromUnidadMedida() As List(Of UnidadMedida)
    Function GetAllFromUnidadMedidaByIdUnidadMedida(ByVal IdUnidadMedida As Int32) As UnidadMedida
    Sub SaveUnidadMedida(ByVal unidadMedida As UnidadMedida)
    Sub DeleteUnidadMedida(ByVal IdUnidaMedida As Int32)
End Interface
