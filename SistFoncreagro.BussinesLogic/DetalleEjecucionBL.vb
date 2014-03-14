Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleEjecucionBL : Implements IDetalleEjecucionBL
    Dim factoryrepository As IDetalleEjecucionRepository
    Public Sub New()
        factoryrepository = New DetalleEjecucionRepository
    End Sub

    Public Sub DeletetDETALLEEJECUCION(ByVal IdDetalleEje As Integer) Implements IDetalleEjecucionBL.DeletetDETALLEEJECUCION
        factoryrepository.DeletetDETALLEEJECUCION(IdDetalleEje)
    End Sub

    Public Function GetDETALLEEJECUCIONByIdDetalleEje(ByVal IdDetalleEje As Integer) As BussinessEntities.DetalleEjecucion Implements IDetalleEjecucionBL.GetDETALLEEJECUCIONByIdDetalleEje
        Return factoryrepository.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje)
    End Function

    Public Function GetDETALLEEJECUCIONByIdProyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleEjecucion) Implements IDetalleEjecucionBL.GetDETALLEEJECUCIONByIdProyecto
        Return factoryrepository.GetDETALLEEJECUCIONByIdProyecto(IdProyecto)
    End Function

    Public Function SaveDETALLEEJECUCION(ByVal _DetalleEjecucion As BussinessEntities.DetalleEjecucion) As Integer Implements IDetalleEjecucionBL.SaveDETALLEEJECUCION
        Return factoryrepository.SaveDETALLEEJECUCION(_DetalleEjecucion)
    End Function

    Public Sub UpdateEstadoDetalleejecucion(ByVal IdDetalleEje As Integer) Implements IDetalleEjecucionBL.UpdateEstadoDetalleejecucion
        factoryrepository.UpdateEstadoDetalleejecucion(IdDetalleEje)
    End Sub
End Class
