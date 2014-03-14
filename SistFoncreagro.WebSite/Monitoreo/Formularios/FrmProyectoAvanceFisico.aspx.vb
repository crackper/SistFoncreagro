Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmProyectoAvanceFisico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim _Id As String
        _Id = Request.QueryString("IdProyecto")
        HFIdProyecto.Value = _Id
        Dim _DatosActual As New DatosActualBL
        TxtAnio.Text = _DatosActual.GetAnioActual

        Dim dv As DataView = CType(SqlDataSource1.Select(DataSourceSelectArguments.Empty), DataView)

        Dim dr As DataRowView = dv.Item(0)

        Fechaserv.Text = dr.Item("FechaServ")

    End Sub

    Private Sub CbMes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbMes.TextChanged
        HFNumMes.Value = Numero_Mes(CbMes.Text)
        RadGrid1.DataBind()
    End Sub

    Public Function Numero_Mes(ByVal nomMes As String) As Int32
        Dim NumMes As Int32

        Select Case nomMes
            Case "Ene", "ENERO" : NumMes = 1
            Case "Feb", "FEBRERO" : NumMes = 2
            Case "Mar", "MARZO" : NumMes = 3
            Case "Abr", "ABRIL" : NumMes = 4
            Case "Mayo", "MAYO" : NumMes = 5
            Case "Jun", "JUNIO" : NumMes = 6
            Case "Jul", "JULIO" : NumMes = 7
            Case "Ago", "AGOSTO" : NumMes = 8
            Case "Sep", "SEPTIEMBRE" : NumMes = 9
            Case "Oct", "OCTUBRE" : NumMes = 10
            Case "Nov", "NOVIEMBRE" : NumMes = 11
            Case "Dic", "DICIEMBRE" : NumMes = 12
        End Select
        Return NumMes
    End Function

    Private Sub RadGrid1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadGrid1.DataBound
        Dim _MesActual As New DatosActualBL
        Dim _Mostrar As String
        If HFNumMes.Value = "" Then HFNumMes.Value = Numero_Mes(CbMes.Text)
        _Mostrar = _MesActual.GetMesActual(Integer.Parse(HFNumMes.Value))
        If _Mostrar = "no" Then
            RadGrid1.Columns(5).Visible = False
            RadGrid1.Columns(6).Visible = False
        Else
            RadGrid1.Columns(5).Visible = True
            RadGrid1.Columns(6).Visible = True
        End If
        If RadGrid1.Items.Count = 0 Then BtnCrear.Visible = True Else BtnCrear.Visible = False
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Agregar" Then
            Dim mIdAvanceFisico As Int32
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            mIdAvanceFisico = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdAvanceFisico")
            Dim _AvanceFisico As New AvanceFisico
            Dim _AvanceFisicoBL As New AvanceFisicoBL
            Dim mValor As Decimal
            mValor = Decimal.Parse(CType(RadGrid1.Items(e.Item.ItemIndex).FindControl("TxtValor"), RadNumericTextBox).Text)
            _AvanceFisico.IdAvanceFisico = mIdAvanceFisico
            _AvanceFisico.Valor = mValor
            _AvanceFisicoBL.SaveAvanceFisico(_AvanceFisico)
            RadGrid1.DataBind()
        End If
    End Sub

    Protected Sub BtnCrear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCrear.Click
        Dim _Avance As New AvanceFisicoBL
        _Avance.NewAvanceFisico(Integer.Parse(HFIdProyecto.Value), Integer.Parse(TxtAnio.Text), Integer.Parse(HFNumMes.Value))
        RadGrid1.DataBind()
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        If HFIdProyecto.Value = "" Then RWMensajes.RadAlert("no ha seleccionado ningún proyecto", 230, 100, "Error", "") : Exit Sub
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
End Class