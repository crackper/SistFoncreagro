Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoPlanillaBL : Implements ITipoPlanillaBL


    Dim factoryrepository As ITipoPlanillaRepository

    Public Sub New()
        factoryrepository = New TipoPlanillaRepository
    End Sub
    Public Sub DeleteTIPOPLANILLA(ByVal IdTipoPlanilla As Integer) Implements ITipoPlanillaBL.DeleteTIPOPLANILLA
        factoryrepository.DeleteTIPOPLANILLA(IdTipoPlanilla)
    End Sub

    Public Function GetAllFromTIPOPLANILLA() As System.Collections.Generic.List(Of BussinessEntities.TipoPlanilla) Implements ITipoPlanillaBL.GetAllFromTIPOPLANILLA
        Return factoryrepository.GetAllFromTIPOPLANILLA
    End Function

    Public Function GetTIPOPLANILLAByIdTipoPlanilla(ByVal IdTipoPlanilla As Integer) As BussinessEntities.TipoPlanilla Implements ITipoPlanillaBL.GetTIPOPLANILLAByIdTipoPlanilla
        Return factoryrepository.GetTIPOPLANILLAByIdTipoPlanilla(IdTipoPlanilla)
    End Function

    Public Function SaveTIPOPLANILLA(ByVal tipoPlanilla As BussinessEntities.TipoPlanilla) As Integer Implements ITipoPlanillaBL.SaveTIPOPLANILLA
        Return factoryrepository.SaveTIPOPLANILLA(tipoPlanilla)
    End Function

    Public Function GetTipoPlanillaYListaTipotrabajador(ByVal IdTipoPlanilla As Integer) As TipoPlanilla
        Dim tipoPlanilla As New TipoPlanilla
        Dim tPTTBL As New TipoPlanillaTipoTrabajadorBL
        tipoPlanilla = GetTIPOPLANILLAByIdTipoPlanilla(IdTipoPlanilla)
        tipoPlanilla.listaTipoPlanillaTipotrabajador = tPTTBL.GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla(IdTipoPlanilla)
        Return tipoPlanilla
    End Function

    Public Function GetAllFromTipoPlanillaYListaTipoTrabajadorConcatenada() As List(Of TipoPlanilla)
        Dim lista As List(Of TipoPlanilla)
        Dim tPTTBL As New TipoPlanillaTipoTrabajadorBL
        Dim tipoTrabajadorBL As New TipoTrabajadorBL
        Dim i As Integer
        lista = factoryrepository.GetAllFromTIPOPLANILLA

        For Each tipoPlanilla In lista
            Dim listaTPTT As New List(Of TipoPlanillaTipoTrabajador)
            listaTPTT = tPTTBL.GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla(tipoPlanilla.IdTipoPlanilla)
            i = 0
            For Each tipoTPTT In listaTPTT
                i = i + 1
                tipoPlanilla.TiposTrabajadorConcatenada = tipoPlanilla.TiposTrabajadorConcatenada & LCase(tipoTrabajadorBL.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(tipoTPTT.IdTipoTrabajador, tipoTPTT.IdCategoria).Descripcion)
                If i < listaTPTT.Count Then
                    tipoPlanilla.TiposTrabajadorConcatenada = tipoPlanilla.TiposTrabajadorConcatenada & ", "
                End If
            Next
        Next
        Return lista
    End Function

End Class
