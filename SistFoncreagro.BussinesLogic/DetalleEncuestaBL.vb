Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleEncuestaBL : Implements IDetalleEncuestaBL
    Dim factoryrepository As IDetalleEncuestaRepository

    Public Sub New()
        factoryrepository = New DetalleEncuestaRepository
    End Sub

    Public Sub DeleteDETALLEENCUESTA(ByVal IdDetalle As Integer) Implements IDetalleEncuestaBL.DeleteDETALLEENCUESTA
        factoryrepository.DeleteDETALLEENCUESTA(IdDetalle)
    End Sub

    Public Function GetDETALLEENCUESTAByIdEncuesta(ByVal IdEncuesta As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleEncuesta) Implements IDetalleEncuestaBL.GetDETALLEENCUESTAByIdEncuesta
        Return factoryrepository.GetDETALLEENCUESTAByIdEncuesta(IdEncuesta)
    End Function

    Public Sub SaveDETALLEENCUESTA(ByVal _detalle As BussinessEntities.DetalleEncuesta) Implements IDetalleEncuestaBL.SaveDETALLEENCUESTA
        factoryrepository.SaveDETALLEENCUESTA(_detalle)
    End Sub
End Class
