Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PlanillaDetalleConceptoBL : Implements IPlanillaDetalleConceptoBL

    Dim factoryrepository As IPlanillaDetalleConceptoRepository

    Public Sub New()
        factoryrepository = New PlanillaDetalleConceptoRepository
    End Sub

    Public Sub DeletePlanillaDetalleConcepto(ByVal IdPlanillaDetalleConcepto As Integer) Implements IPlanillaDetalleConceptoBL.DeletePlanillaDetalleConcepto
        factoryrepository.DeletePlanillaDetalleConcepto(IdPlanillaDetalleConcepto)
    End Sub

    Public Function GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto(ByVal IdTipoPlanillaTrabajador As Integer, ByVal IdDetalleConcepto As Integer) As BussinessEntities.PlanillaDetalleConcepto Implements IPlanillaDetalleConceptoBL.GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto
        Return factoryrepository.GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto(IdTipoPlanillaTrabajador, IdDetalleConcepto)
    End Function

    Public Function SavePlanillaDetalleConcepto(ByVal planillaDetalleConcepto As BussinessEntities.PlanillaDetalleConcepto) As Integer Implements IPlanillaDetalleConceptoBL.SavePlanillaDetalleConcepto
        Return factoryrepository.SavePlanillaDetalleConcepto(planillaDetalleConcepto)
    End Function

    Public Sub SaveAndDeleteListaTipoTrabajador(ByVal listaCrear As System.Collections.Generic.List(Of BussinessEntities.PlanillaDetalleConcepto), ByVal listaEliminar As System.Collections.Generic.List(Of Integer)) Implements IPlanillaDetalleConceptoBL.SaveAndDeleteListaTipoTrabajador
        If listaEliminar.Count > 0 Then
            For i = 0 To listaEliminar.Count - 1
                DeletePlanillaDetalleConcepto(listaEliminar(i))
            Next
        End If

        If listaCrear.Count > 0 Then
            For i = 0 To listaCrear.Count - 1
                SavePlanillaDetalleConcepto(listaCrear(i))
            Next
        End If
    End Sub

End Class
