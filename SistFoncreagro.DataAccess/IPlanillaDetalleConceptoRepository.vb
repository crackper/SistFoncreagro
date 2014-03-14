Imports SistFoncreagro.BussinessEntities
Public Interface IPlanillaDetalleConceptoRepository
    Function GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto(ByVal IdTipoPlanillaTrabajador As Int32, ByVal IdDetalleConcepto As Int32) As PlanillaDetalleConcepto
    Function SavePlanillaDetalleConcepto(ByVal planillaDetalleConcepto As PlanillaDetalleConcepto) As Int32
    Sub DeletePlanillaDetalleConcepto(ByVal IdPlanillaDetalleConcepto As Int32)
End Interface
