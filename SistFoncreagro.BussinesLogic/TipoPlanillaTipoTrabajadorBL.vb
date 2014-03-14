Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoPlanillaTipoTrabajadorBL : Implements ITipoPlanillaTipoTrabajadorBL

    Dim factoryrepository As ITipoPlanillaTipoTrabajadorRepository

    Public Sub New()
        factoryrepository = New TipoPlanillaTipoTrabajadorRepository
    End Sub
    Public Sub DeleteTIPOPLANILLATIPOTRABAJADOR(ByVal IdTipoPlanilla As Integer, ByVal IdTipoTrabajador As Integer, ByVal IdCategoria As Integer) Implements ITipoPlanillaTipoTrabajadorBL.DeleteTIPOPLANILLATIPOTRABAJADOR
        factoryrepository.DeleteTIPOPLANILLATIPOTRABAJADOR(IdTipoPlanilla, IdTipoTrabajador, IdCategoria)
    End Sub

    Public Function GetAllFromTIPOPLANILLATIPOTRABAJADOR() As System.Collections.Generic.List(Of BussinessEntities.TipoPlanillaTipoTrabajador) Implements ITipoPlanillaTipoTrabajadorBL.GetAllFromTIPOPLANILLATIPOTRABAJADOR
        Return factoryrepository.GetAllFromTIPOPLANILLATIPOTRABAJADOR()
    End Function

    Public Function GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla(ByVal IdTipoPlanilla As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoPlanillaTipoTrabajador) Implements ITipoPlanillaTipoTrabajadorBL.GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla
        Return factoryrepository.GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla(IdTipoPlanilla)
    End Function

    Public Sub SaveTIPOPLANILLATIPOTRABAJADOR(ByVal tipoPlanillaTipoTrabajador As BussinessEntities.TipoPlanillaTipoTrabajador) Implements ITipoPlanillaTipoTrabajadorBL.SaveTIPOPLANILLATIPOTRABAJADOR
        factoryrepository.SaveTIPOPLANILLATIPOTRABAJADOR(tipoPlanillaTipoTrabajador)
    End Sub

    Public Sub SaveAndDeleteListaTipoTrabajador(ByVal listaCrear As System.Collections.Generic.List(Of BussinessEntities.TipoPlanillaTipoTrabajador), ByVal listaEliminar As System.Collections.Generic.List(Of BussinessEntities.TipoPlanillaTipoTrabajador)) Implements ITipoPlanillaTipoTrabajadorBL.SaveAndDeleteListaTipoTrabajador
        If listaEliminar.Count > 0 Then
            For i = 0 To listaEliminar.Count - 1
                DeleteTIPOPLANILLATIPOTRABAJADOR(listaEliminar(i).IdTipoPlanilla, listaEliminar(i).IdTipoTrabajador, listaEliminar(i).IdCategoria)
            Next
        End If

        If listaCrear.Count > 0 Then
            For i = 0 To listaCrear.Count - 1
                SaveTIPOPLANILLATIPOTRABAJADOR(listaCrear(i))
            Next
        End If
    End Sub
    ''''''

    Public Function GetAllFromTipoPlanillaTipoTrabajadorYAplicableAUnConcepto(ByVal IdDetalleConcepto As Int32) As List(Of TipoPlanillaTipoTrabajador)
        Dim listaTPTT = GetAllFromTIPOPLANILLATIPOTRABAJADOR()
        Dim tipoPlanillaBL As New TipoPlanillaBL
        Dim tipoTrabajadorBL As New TipoTrabajadorBL
        Dim planillaDetalleConceptoBL As New PlanillaDetalleConceptoBL
        Dim planillaDetalleConcepto As New PlanillaDetalleConcepto
        For Each tPTT In listaTPTT
            tPTT.NombreTipoPlanilla = tipoPlanillaBL.GetTIPOPLANILLAByIdTipoPlanilla(tPTT.IdTipoPlanilla).NombrePlanilla
            tPTT.NombreTipoTrabajador = tipoTrabajadorBL.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(tPTT.IdTipoTrabajador, tPTT.IdCategoria).Descripcion

            If IdDetalleConcepto = 0 Then
                tPTT.AplicaParaUnConcepto = False
            Else
                planillaDetalleConcepto = planillaDetalleConceptoBL.GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto(tPTT.IdTipoPlanillaTrabajador, IdDetalleConcepto)
                If Not planillaDetalleConcepto Is Nothing Then
                    tPTT.AplicaParaUnConcepto = True
                    tPTT.IdPlanillaDetalleConcepto = planillaDetalleConcepto.IdPlanillaDetalleConcepto
                Else
                    tPTT.AplicaParaUnConcepto = False
                End If
            End If
        Next
        Return listaTPTT
    End Function

End Class
