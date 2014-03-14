Imports SistFoncreagro.BussinessEntities
Public Interface IRazonSoulSourceBL
    Function GetAllFromRazones() As List(Of RazonSoulSource)
    Sub UpdateRazonCotizaconSoulSource(ByVal IdContizacion As Int32, ByVal IdRazon As Int32)
End Interface
