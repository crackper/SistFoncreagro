Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmProyectoAmbito
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim miId As String
            miId = Request.QueryString("IdProyecto")
            HFIdProyecto.Value = miId
            Dim _Proyecto As New Proyecto
            Dim _ProyectoBL As New ProyectoBL
            _Proyecto = _ProyectoBL.GetFromProyectoByIdProyecto(miId)
            LblProyecto.Text = _Proyecto.Nombre

        End If
    End Sub

    Protected Sub RdbDistrito_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RdbDistrito.CheckedChanged
        If RdbDistrito.Checked = True Then
            HFNivel.Value = "Distrito"
            RdbCP.Checked = False
            RdbCas.Checked = False
            RadGrid2.Columns(4).FilterControlWidth = 80%
            RadGrid2.Columns(5).FilterControlWidth = 0%
            RadGrid2.Columns(6).FilterControlWidth = 0%
            RadGrid2.Columns(6).HeaderStyle.Width = 0%
            RadGrid2.Columns(5).HeaderStyle.Width = 0%
            RadGrid2.Columns(4).HeaderStyle.Width = 33%
            RadGrid2.Columns(3).HeaderStyle.Width = 33%
            RadGrid2.Columns(2).HeaderStyle.Width = 33%
        End If

    End Sub

    Protected Sub RdbCP_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RdbCP.CheckedChanged
        If RdbCP.Checked = True Then
            HFNivel.Value = "Centro Poblado"
            RdbDistrito.Checked = False
            RdbCas.Checked = False
            RadGrid2.Columns(4).FilterControlWidth = 80%
            RadGrid2.Columns(5).FilterControlWidth = 80%
            RadGrid2.Columns(6).FilterControlWidth = 0%
            RadGrid2.Columns(6).HeaderStyle.Width = 0%
            RadGrid2.Columns(5).HeaderStyle.Width = 23%
            RadGrid2.Columns(4).HeaderStyle.Width = 23%
            RadGrid2.Columns(3).HeaderStyle.Width = 22%
            RadGrid2.Columns(2).HeaderStyle.Width = 22%
        End If

    End Sub

    Protected Sub RdbCas_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RdbCas.CheckedChanged
        If RdbCas.Checked = True Then
            HFNivel.Value = "Caserio"
            RdbDistrito.Checked = False
            RdbCP.Checked = False
            RadGrid2.Columns(4).FilterControlWidth = 80%
            RadGrid2.Columns(5).FilterControlWidth = 80%
            RadGrid2.Columns(6).FilterControlWidth = 80%
            RadGrid2.Columns(6).HeaderStyle.Width = 19%
            RadGrid2.Columns(5).HeaderStyle.Width = 19%
            RadGrid2.Columns(4).HeaderStyle.Width = 19%
            RadGrid2.Columns(3).HeaderStyle.Width = 19%
            RadGrid2.Columns(2).HeaderStyle.Width = 19%
        End If

    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim AmbProyBL As New AmbitoProyectoBL
        Dim EditedItem As GridEditableItem
        EditedItem = CType(e.Item, GridEditableItem)
        Dim miId As Int32
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdAmbProy")
        AmbProyBL.DeleteAmbitoProyecto(miId)
        RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Select" Then
            Dim EditedItem As GridEditableItem
            EditedItem = CType(e.Item, GridEditableItem)
            Dim miId As String
            miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("CUBIGEO")
            Dim _AmbitoProyectoBL As New AmbitoProyectoBL
            Dim _LsAmbitoProyecto As New List(Of AmbitoProyecto)
            Dim _AmbitoProyecto As New AmbitoProyecto
            _AmbitoProyecto.CUbigeo = miId
            _AmbitoProyecto.IdProyecto = Integer.Parse(HFIdProyecto.Value)
            _LsAmbitoProyecto.Add(_AmbitoProyecto)
            _AmbitoProyectoBL.SaveAmbitoProyecto(_LsAmbitoProyecto)
            RadGrid1.DataBind()
        End If
        
    End Sub

    Protected Sub ImgActualizar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgActualizar.Click
        Dim _LsAmbitoProy As New List(Of AmbitoProyecto)
        Dim _AmbitoProy As AmbitoProyecto
        Dim cad As String

        For i = 0 To RadGrid1.Items.Count - 1
            _AmbitoProy = New AmbitoProyecto
            _AmbitoProy.IdAmbProy = Integer.Parse(RadGrid1.Items(i)("IdAmbProy").Text)
            cad = CType(RadGrid1.Items(i).FindControl("RNBeneficiarios"), RadNumericTextBox).Text
            If (cad = "") Then _AmbitoProy.Beneficiarios = 0 Else _AmbitoProy.Beneficiarios = Decimal.Parse(cad)
            _LsAmbitoProy.Add(_AmbitoProy)
        Next
        Dim _AmbProyBL As New AmbitoProyectoBL
        _AmbProyBL.SaveAmbitoProyecto(_LsAmbitoProy)
    End Sub
End Class