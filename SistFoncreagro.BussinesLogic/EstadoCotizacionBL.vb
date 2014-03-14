Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EstadoCotizacionBL : Implements IEstadoCotizacionBL
    Dim estadoCotizacion As IEstadoCotizacionRepository
    Sub New()
        estadoCotizacion = New EstadoCotizacionRepository
    End Sub

    Public Function GetAllFromEstadoCotizacionByIdCotizacion(ByVal IdCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoCotizacion) Implements IEstadoCotizacionBL.GetAllFromEstadoCotizacionByIdCotizacion
        Return estadoCotizacion.GetAllFromEstadoCotizacionByIdCotizacion(IdCotizacion)
    End Function
End Class
