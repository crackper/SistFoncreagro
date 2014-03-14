Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleConciliacionBL : Implements IDetalleConciliacionBL
    Dim factoryrepository As IDetalleConciliacionRepository

    Public Sub New()
        factoryrepository = New DetalleConciliacionRepository
    End Sub

    Public Sub DeleteDETALLECONCILIACION(ByVal IdDetalle As Integer) Implements IDetalleConciliacionBL.DeleteDETALLECONCILIACION
        factoryrepository.DeleteDETALLECONCILIACION(IdDetalle)
    End Sub

    Public Function GetDETALLECONCILIACIONByIdConciliacion(ByVal IdConciliacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleConciliacion) Implements IDetalleConciliacionBL.GetDETALLECONCILIACIONByIdConciliacion
        Return factoryrepository.GetDETALLECONCILIACIONByIdConciliacion(IdConciliacion)
    End Function

    Public Function GetDETALLECONCILIACIONByIdDetalle(ByVal IdDetalle As Integer) As BussinessEntities.DetalleConciliacion Implements IDetalleConciliacionBL.GetDETALLECONCILIACIONByIdDetalle
        Return factoryrepository.GetDETALLECONCILIACIONByIdDetalle(IdDetalle)
    End Function

    Public Sub SaveDETALLECONCILIACION(ByVal _DetalleConciliacion As BussinessEntities.DetalleConciliacion) Implements IDetalleConciliacionBL.SaveDETALLECONCILIACION
        factoryrepository.SaveDETALLECONCILIACION(_DetalleConciliacion)
    End Sub
End Class
