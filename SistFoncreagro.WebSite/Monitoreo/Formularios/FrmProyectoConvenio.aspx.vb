Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmProyectoConvenio
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

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Panel2.Visible = True
        RadGrid2.DataBind()
    End Sub

    Protected Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnAceptar.Click
        Dim _ConveProy As New ConveProy
        Dim _ConveProyBL As New ConveProyBL

        _ConveProy.IdConvenio = CInt(HFIdConvenio.Value)
        _ConveProy.IdProyecto = CInt(HFIdProyecto.Value)
        _ConveProy.MontoAprobado = CDbl(TxtMonto.Text)
        _ConveProyBL.SaveConveProy(_ConveProy)
        Panel1.Visible = False
        RadGrid1.DataBind()

    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Seleccionar" Then
            Dim id As Int32
            Dim nombre As String
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            ID = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdConvenio")
            nombre = Me.RadGrid2.Items(editeditem.ItemIndex)("Nombre").Text
            TxtConvenio.Text = nombre
            TxtMonto.Text = 0
            HFIdConvenio.Value = id.ToString
            Panel1.Visible = True
            Panel2.Visible = False
        End If
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim _ConveProy As New ConveProy
        Dim _ConveProyBL As New ConveProyBL
        Dim EditedItem As GridEditableItem
        EditedItem = CType(e.Item, GridEditableItem)
        Dim miError As String
        Dim miId As Int32
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdConvProy")
        miError = _ConveProyBL.DeleteConveProy(miId)
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
        TxtMonto.Text = 0
        Panel1.Visible = False
        Dim miId As String
        miId = Request.QueryString("IdProyecto")
        Response.Redirect("~\Monitoreo\Formularios\FrmProyectoConvenio.aspx?IdProyecto=" + miId)
        
    End Sub
End Class