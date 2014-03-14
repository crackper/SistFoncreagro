Imports SistFoncreagro.BussinessEntities
Public Interface IPlanillaDetalleConceptoBL
    Function GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto(ByVal IdTipoPlanillaTrabajador As Int32, ByVal IdDetalleConcepto As Int32) As PlanillaDetalleConcepto
    Function SavePlanillaDetalleConcepto(ByVal planillaDetalleConcepto As PlanillaDetalleConcepto) As Int32
    Sub DeletePlanillaDetalleConcepto(ByVal IdPlanillaDetalleConcepto As Int32)
    Sub SaveAndDeleteListaTipoTrabajador(ByVal listaCrear As System.Collections.Generic.List(Of BussinessEntities.PlanillaDetalleConcepto), ByVal listaEliminar As System.Collections.Generic.List(Of Integer))
End Interface
