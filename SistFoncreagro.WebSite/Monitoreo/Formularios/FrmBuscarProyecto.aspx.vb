Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class FrmBuscarProyecto
    Inherits System.Web.UI.Page

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("~\Monitoreo\Formularios\Defecto.aspx")
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "InitInsert" Then
            e.Canceled = True
            Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=0")
        ElseIf e.CommandName = "Edit" Then
            Dim id As String
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            e.Canceled = True
            Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=" + id.ToString)
        End If
    End Sub

    Protected Sub RadGrid2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid2.SelectedIndexChanged
        HIdProyecto.Value = RadGrid2.SelectedValue
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        If HIdProyecto.Value = "" Then RWMensajes.RadAlert("Seleccione un proyecto", 230, 100, "Error", "") : Exit Sub
        Dim cadena_java As String

        Select Case e.Item.Value
            Case "Datos"
                Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Convenio"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoConvenio.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Componentes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoComponentes.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Actividades"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoActividad.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "CCostos"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoCCosto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Ambito"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAmbito.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Informes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoInformes.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "ForFin"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuesto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "ForAnual"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuestoAnual.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "AvanFis"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAvanceFisico.aspx?IdProyecto=" + HIdProyecto.Value)
            Case "StakeHolders"
                Dim rw As New RadWindow()
                rw.Width = Unit.Pixel(260)
                rw.Height = Unit.Pixel(300)
                rw.NavigateUrl = "ListaStakeHolders.aspx?IdProyecto" = HIdProyecto.Value
                rw.VisibleOnPageLoad = False
                Me.RWMensajes.Windows.Add(rw)

            Case "POA"
                cadena_java = "<script type='text/javascript'> " & _
                                             " radopen('ListaPoa.aspx','Formulario'); " & _
                                             Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End Select
    End Sub

    Private Sub FrmBuscarProyecto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then TxtBusProy.Text = "FONCREAGRO"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load, Me.Load, Me.Load

    End Sub

   
End Class