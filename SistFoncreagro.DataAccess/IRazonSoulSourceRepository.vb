Imports SistFoncreagro.BussinessEntities
Public Interface IRazonSoulSourceRepository
    Function GetAllFromRazones() As List(Of RazonSoulSource)
    Sub UpdateRazonCotizaconSoulSource(ByVal IdContizacion As Int32, ByVal IdRazon As Int32)
End Interface
