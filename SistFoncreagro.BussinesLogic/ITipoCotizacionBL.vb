Imports SistFoncreagro.BussinessEntities

Public Interface ITipoCotizacionBL
    Sub SaveTipoCotizacion(ByVal tipoCotizacion As TipoCotizacion)
    Function GetAllFromTipoCotizacion() As List(Of TipoCotizacion)
End Interface
