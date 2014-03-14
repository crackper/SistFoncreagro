Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmProyectoActividad
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Me.BtnNueAct.Attributes.Add("onClick", "NuevoActividad(" & Request.QueryString("IdProyecto") & "); return false;")

            Dim miId As String
            miId = Request.QueryString("IdProyecto")
            HFIdProyecto.Value = miId
            Dim _Proyecto As New Proyecto
            Dim _ProyectoBL As New ProyectoBL
            _Proyecto = _ProyectoBL.GetFromProyectoByIdProyecto(miId)
            LblProyecto.Text = _Proyecto.Nombre

        End If
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Select" Then
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim miId As String
            miId = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdProyComp")
            HFIdProyComp.Value = miId
            TxtComponente.Text = Me.RadGrid2.Items(editeditem.ItemIndex)("Componente").Text
        End If
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Select" Then
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim miId As String
            miId = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdProyAct")
            HFIdProyComp.Value = miId
            Dim _ProyActBL As New ProyActBL
            Dim _ProyAct As New ProyAct
            HFIdProyAct.Value = miId
            _ProyAct = _ProyActBL.GetProyActById(miId)
            HFIdActividad.Value = _ProyAct.IdActividad
            HFIdProyComp.Value = _ProyAct.IdProycomp
            TxtComponente.Text = Me.RadGrid1.Items(editeditem.ItemIndex)("Componente").Text
            TxtActividad.Text = Me.RadGrid1.Items(editeditem.ItemIndex)("Actividad").Text
            Panel1.Visible = True
            Panel2.Visible = True
        ElseIf e.CommandName = "Delete" Then

        End If
    End Sub

    Protected Sub BtnAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAgregar.Click
        Panel1.Visible = True
        Panel2.Visible = True
        BtnAgregar.Visible = False
    End Sub

    Protected Sub RadGrid3_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.ItemCommand
        If e.CommandName = "Select" Then
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim miId As String
            miId = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdActividad")
            HFIdActividad.Value = miId
            TxtActividad.Text = Me.RadGrid3.Items(editeditem.ItemIndex)("Actividad").Text
        End If
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click
        If HFIdProyComp.Value = "" Then RWMensajes.RadAlert("Es necesario un componente", 200, 100, "Error", "") : Exit Sub
        If HFIdActividad.Value = "" Then RWMensajes.RadAlert("Es necesario una actividad", 200, 100, "Error", "") : Exit Sub

        Dim _ProyAct As New ProyAct
        Dim _ProyActBL As New ProyActBL
        If HFIdProyAct.Value <> "" Then _ProyAct.IdProyAct = CInt(HFIdProyAct.Value)
        _ProyAct.IdActividad = CInt(HFIdActividad.Value)
        _ProyAct.IdProycomp = CInt(HFIdProyComp.Value)
        _ProyAct.Porcentaje = CDbl(TxtPorcentaje.Text)
        Dim mensaje As String
        mensaje = _ProyActBL.SaveProyAct(_ProyAct)
        If mensaje = "" Then
            Panel2.Visible = False
            RadGrid1.DataBind()
            Panel1.Visible = False
        Else
            RWMensajes.RadAlert(mensaje, 300, 100, "Error", "") : Exit Sub
        End If
        BtnAgregar.Visible = True
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim _ProyAct As New ProyAct
        Dim _ProyActBL As New ProyActBL
        Dim EditedItem As GridEditableItem
        EditedItem = CType(e.Item, GridEditableItem)
        Dim miError As String
        Dim miId As Int32
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdProyAct")
        miError = _ProyActBL.DeleteProyAct(miId)
        If miError <> "" Then
            RWMensajes.RadAlert(miError, 300, 120, "ERROR", "")
        End If
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        If HFIdProyecto.Value = "" Then RWMensajes.RadAlert("Seleccione un proyecto", 230, 100, "Error", "") : Exit Sub
        Select Case e.Item.Value
            Case "Datos"
                Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Convenio"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoConvenio.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Componentes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoComponentes.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Actividades"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoActividad.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "CCostos"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoCCosto.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Ambito"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAmbito.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Informes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoInformes.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "ForFin"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuesto.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "ForAnual"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuestoAnual.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "AvanFis"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAvanceFisico.aspx?IdProyecto=" + HFIdProyecto.Value)
        End Select
    End Sub

    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelar.Click
        Panel1.Visible = False
        Panel2.Visible = False
        BtnAgregar.Visible = True
        BtnAgregar.Visible = True
    End Sub

    Protected Sub AJAX_MANAGER_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles AJAX_MANAGER.AjaxRequest
        If e.Argument.StartsWith("ActualizarGrilla") Then
            Me.RadGrid3.DataBind()
        End If
    End Sub
End Class