Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleConceptoPeriodoRepository
    Function GetRemuneracionAfectaAUndetalleConcepto(ByVal Cod As String, ByVal IdAfectacion As Int32, ByVal IdPlanilla As Int32) As Decimal
End Interface
