Imports SistFoncreagro.BussinessEntities
Public Interface ITipoCotizacionRepository
    Sub SaveTipoCotizacion(ByVal tipoCotizacion As TipoCotizacion)
    Function GetAllFromTipoCotizacion() As List(Of TipoCotizacion)
End Interface
