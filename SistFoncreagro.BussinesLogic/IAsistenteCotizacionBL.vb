Imports SistFoncreagro.BussinessEntities
Public Interface IAsistenteCotizacionBL
    Sub SaveAsistenteCotizacion(ByVal asistenteCotizacion As AsistenteCotizacion)
    Sub DeleteAsistenteCotizacion(ByVal IdAsistenteCotizacion As Int32)
    Function GetAllFromAsistennteCotizacionByIdCotizacion(ByVal IdCotizacion As Int32) As List(Of AsistenteCotizacion)
End Interface
