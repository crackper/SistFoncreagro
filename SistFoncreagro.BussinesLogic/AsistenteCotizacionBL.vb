Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AsistenteCotizacionBL : Implements IAsistenteCotizacionBL
    Dim factoryRepository As IAsistenteCotizacionRepository
    Sub New()
        factoryRepository = New AsistenteCotizacionRepository
    End Sub
    Public Sub DeleteAsistenteCotizacion(ByVal IdAsistenteCotizacion As Integer) Implements IAsistenteCotizacionBL.DeleteAsistenteCotizacion
        factoryRepository.DeleteAsistenteCotizacion(IdAsistenteCotizacion)
    End Sub

    Public Function GetAllFromAsistennteCotizacionByIdCotizacion(ByVal IdCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.AsistenteCotizacion) Implements IAsistenteCotizacionBL.GetAllFromAsistennteCotizacionByIdCotizacion
        Return factoryRepository.GetAllFromAsistennteCotizacionByIdCotizacion(IdCotizacion)
    End Function

    Public Sub SaveAsistenteCotizacion(ByVal asistenteCotizacion As BussinessEntities.AsistenteCotizacion) Implements IAsistenteCotizacionBL.SaveAsistenteCotizacion
        factoryRepository.SaveAsistenteCotizacion(asistenteCotizacion)
    End Sub
End Class
