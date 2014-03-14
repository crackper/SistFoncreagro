Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleConciliacionRepository
    Sub SaveDETALLECONCILIACION(ByVal _DetalleConciliacion As DetalleConciliacion)
    Function GetDETALLECONCILIACIONByIdConciliacion(ByVal IdConciliacion As Int32) As List(Of DetalleConciliacion)
    Function GetDETALLECONCILIACIONByIdDetalle(ByVal IdDetalle As Int32) As DetalleConciliacion
    Sub DeleteDETALLECONCILIACION(ByVal IdDetalle As Int32)
End Interface
