Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmProyectoComponentes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Me.BtnNueComp.Attributes.Add("onClick", "NuevoComponente(" & Request.QueryString("IdProyecto") & "); return false;")

            Dim miId As String
            miId = Request.QueryString("IdProyecto")
            HFIdProyecto.Value = miId
            Dim _Proyecto As New Proyecto
            Dim _ProyectoBL As New ProyectoBL
            _Proyecto = _ProyectoBL.GetFromProyectoByIdProyecto(miId)
            LblProyecto.Text = _Proyecto.Nombre

        End If
    End Sub

    Private Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Select" Then
            Dim id As Int32
            Dim nombre As String
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            id = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdConvProy")
            nombre = Me.RadGrid2.Items(editeditem.ItemIndex)("Convenio").Text
            TxtConvenio.Text = nombre
            HFIdConveProy.Value = id.ToString
            Panel1.Visible = True
        End If
    End Sub

    Protected Sub RadGrid3_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.ItemCommand
        If e.CommandName = "Select" Then
            Dim id As Int32
            Dim nombre As String
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            id = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdComponente")
            nombre = Me.RadGrid3.Items(editeditem.ItemIndex)("Nombre").Text
            TxtComponente.Text = nombre
            HFIdComponente.Value = id.ToString
            If Panel1.Visible = False Then Panel1.Visible = True
        End If
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click
        If HFIdComponente.Value = "" Then RWMensajes.RadAlert("Es necesario un componente", 200, 100, "Error", "") : Exit Sub
        If HFIdConveProy.Value = "" Then RWMensajes.RadAlert("Es necesario un Convenio", 200, 100, "Error", "") : Exit Sub

        Dim _ProyComp As New ProyComp
        Dim _ProyCompBL As New ProyCompBL
        If HFIdProyComp.Value <> "" Then _ProyComp.IdProyComp = Integer.Parse(HFIdProyComp.Value)
        _ProyComp.IdComponente = CInt(HFIdComponente.Value)
        _ProyComp.IdConvProy = CInt(HFIdConveProy.Value)
        _ProyComp.Porcentaje = CDbl(TxtPorcen.Text)
        Dim mensaje As String

        mensaje = _ProyCompBL.SaveProyComp(_ProyComp)
        If mensaje = "" Then
            Panel1.Visible = False
            RadGrid1.DataBind()
        Else
            RWMensajes.RadAlert(mensaje, 300, 100, "Error", "") : Exit Sub
        End If
        
        'Dim footer As GridFooterItem = RadGrid1.MasterTableView.GetItems(GridItemType.Footer)(0)
        'Dim Total As Decimal
        'Total = CDbl(footer("Porcentaje").Text)

    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Panel2.Visible = True
        BtnBuscar.Visible = False
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Select" Then
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim miId As String
            miId = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdProyComp")
            HFIdProyComp.Value = miId
            Dim _ProyCompBL As New ProyCompBL
            Dim _ProyComp As New ProyComp
            _ProyComp = _ProyCompBL.GetProyCompById(Integer.Parse(miId))
            HFIdComponente.Value = _ProyComp.IdComponente
            HFIdConveProy.Value = _ProyComp.IdConvProy
            TxtConvenio.Text = Me.RadGrid1.Items(editeditem.ItemIndex)("Convenio").Text
            TxtComponente.Text = Me.RadGrid1.Items(editeditem.ItemIndex)("Componente").Text
            TxtPorcen.Text = Me.RadGrid1.Items(editeditem.ItemIndex)("Porcentaje").Text
            Panel1.Visible = True
        ElseIf e.CommandName = "Delete" Then

        End If
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim _ProyComp As New ProyComp
        Dim _ProyCompBL As New ProyCompBL
        Dim EditedItem As GridEditableItem
        EditedItem = CType(e.Item, GridEditableItem)
        Dim miError As String
        Dim miId As Int32
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdProyComp")
        miError = _ProyCompBL.DeleteProyComp(miId)
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
        Panel2.Visible = False
        BtnBuscar.Visible = True
    End Sub

    Protected Sub AJAX_MANAGER_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles AJAX_MANAGER.AjaxRequest
        If e.Argument.StartsWith("ActualizarGrilla") Then
            Me.RadGrid3.DataBind()
        End If
    End Sub
End Class