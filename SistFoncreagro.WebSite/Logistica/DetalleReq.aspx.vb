Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI
Public Class DetalleReq
    Inherits System.Web.UI.Page

    Dim _requerimientoBL As IRequerimientoBL
    Dim _detalleRequerimientoBL As IDetalleRequerimientoBL
    Dim catalogoBl As ICatalogoBL
    Dim iRuta As IRutaRequerimientoBL
    Dim iProyecto As IProyectoBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim IdReq As Integer
            IdReq = CInt(Request.QueryString("IdReq"))
            _requerimientoBL = New RequerimientoBL
            Dim requerimiento = _requerimientoBL.GetAllFromRequerimientoByIdReq(IdReq)
            cargarRequerimiento(requerimiento)
        End If
    End Sub

    Public Sub cargarRequerimiento(ByVal requerimiento As Requerimiento)
        Dim eliminar As Int32
        iProyecto = New ProyectoBL
        rcbProyecto.DataSource = iProyecto.GetAllFromProyecto
        rcbProyecto.DataTextField = "AreaProyecto"
        rcbProyecto.DataValueField = "IdProyecto"
        rcbProyecto.DataBind()
        lblNroRequerimiento.Text = requerimiento.Numero
        lblRequeridoPor.Text = requerimiento.NombreRequiere
        lblFechaRequerimiento.Text = Convert.ToString(requerimiento.FechaRequerimiento)
        lblEstadoRequerimiento.Text = requerimiento.Estado
        lblTipoRequerimiento.Text = requerimiento.Tipo
        rcbProyecto.SelectedValue = requerimiento.IdProyectoArea
        rcbCentroCosto.SelectedValue = requerimiento.IdCentroCosto
        ddlMoneda.SelectedValue = requerimiento.IdMoneda
        txtObservacion.Text = requerimiento.Observacion
        txtSustento.Text = requerimiento.Sustento
        If requerimiento.Tipo = "SERVICIO" Then
            txtTipoCatalogoRequerimiento.Text = "1"
            cbPeriodo.Enabled = True
            cbRuta.Enabled = True
            If requerimiento.Periodo = True Then
                cbPeriodo.Checked = True
                rdpPeriodoInicio.SelectedDate = DateValue(requerimiento.FechaInicioServicio)
                rdpPeriodoFin.SelectedDate = DateValue(requerimiento.FechaFinServicio)
                rdpPeriodoInicio.Enabled = True
                rdpPeriodoFin.Enabled = True
            End If
            If requerimiento.Ruta = True Then
                cbRuta.Checked = True
                rcbOrigen.Enabled = True
                rcbDestino.Enabled = True
                rcbOrigen.SelectedValue = requerimiento.IdRutaOrigen
                rcbDestino.SelectedValue = requerimiento.IdRutaDestino
            End If
        End If
        If requerimiento.Estado <> "En Espera" Then
            If requerimiento.Estado = "Rechazado" Then
                eliminar = 1
            Else
                Inhabilitar(False)
                eliminar = 0
            End If
        Else
            eliminar = 1
        End If
        If requerimiento.IdResponsableAprobar >= 0 Then
            lbHistorico.Visible = True
        End If
        If requerimiento.ActivarCentroCosto = False Then
            gvDetalleRequerimiento.Columns(8).Visible = False
        Else
            gvDetalleRequerimiento.Columns(9).Visible = False
        End If
        If gvDetalleRequerimiento.Rows.Count > 0 Then
            rcbProyecto.Enabled = False
        End If
        rcbProyecto.Filter = 1
        rcbCentroCosto.Filter = 1
        lbHistorico.Attributes.Add("onClick", "CargarHistorico(" & requerimiento.IdRequerimiento & "); return false;")
        EliminarFila(CInt(txtTipoCatalogoRequerimiento.Text))
    End Sub

    Sub Inhabilitar(ByVal rutaPeriodo As Boolean)
        PanelBusquedaItems.Visible = False
        ddlMoneda.Enabled = False
        rcbProyecto.Enabled = False
        rcbCentroCosto.Enabled = False
        txtObservacion.Enabled = False
        txtSustento.Enabled = False
        gvDetalleRequerimiento.Columns(0).Visible = False
        panelAnular.Visible = False
        If rutaPeriodo = False Then
            cbRuta.Enabled = False
            cbPeriodo.Enabled = False
            rdpPeriodoInicio.Enabled = False
            rdpPeriodoFin.Enabled = False
            rcbOrigen.Enabled = False
            rcbDestino.Enabled = False
        End If
        lbResponsable.Visible = True
    End Sub

    Protected Sub EliminarFila(ByVal tipo As Int32)
        If tipo = 0 Then
            cbPeriodo.Visible = False
            cbRuta.Visible = False
            rdpPeriodoInicio.Visible = False
            rdpPeriodoFin.Visible = False
            rcbOrigen.Visible = False
            rcbDestino.Visible = False
        Else
        End If
        Dim codigo As String
        codigo = "<script type='text/javascript'> eliminarFila('" & tipo & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "eliminarFilaRC", codigo.ToString, False)

    End Sub

    Protected Sub cbPeriodo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbPeriodo.CheckedChanged
        If cbPeriodo.Checked = True Then
            EnableRdtpPeriodo(True)
        Else
            EnableRdtpPeriodo(False)
        End If
        EliminarFila(CInt(txtTipoCatalogoRequerimiento.Text))
    End Sub

    Protected Sub cbRuta_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRuta.CheckedChanged
        If cbRuta.Checked = True Then
            EnableRcmRuta(True)
        Else
            EnableRcmRuta(False)
        End If
        EliminarFila(CInt(txtTipoCatalogoRequerimiento.Text))
    End Sub

    Sub EnableRcmRuta(ByVal valor As Boolean)
        rcbOrigen.Enabled = valor
        rcbDestino.Enabled = valor
    End Sub

    Sub EnableRdtpPeriodo(ByVal valor As Boolean)
        rdpPeriodoInicio.Enabled = valor
        rdpPeriodoFin.Enabled = valor
        rdpPeriodoInicio.SelectedDate = Nothing
        rdpPeriodoFin.SelectedDate = Nothing
    End Sub


    Sub GuardarDetalle()
        Dim listaDetalle As New List(Of DetalleRequerimiento)
        Dim i As Integer
        For i = 0 To gvDetalleRequerimiento.Rows.Count - 1
            Dim detalleRequerimiento As New DetalleRequerimiento
            Dim afecto As Boolean
            Dim txtIdDetalleRequerimiento As TextBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("txtIdDetReq"), TextBox)
            Dim ddlUnidad As DropDownList = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("ddlUnidadMedida"), DropDownList)
            Dim txtCantidad As TextBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("txtCantidad"), TextBox)
            Dim cbAfectoIgv As CheckBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("cbAfectoIgv"), CheckBox)
            Dim rcbCentroCostoDetalle As RadComboBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("rcbCentroCostoDetalle"), RadComboBox)
            Dim txtObservacionDetalle As TextBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("txtDetalleObservacion"), TextBox)
            If cbAfectoIgv.Checked = True Then
                afecto = True
            Else
                afecto = False
            End If
            detalleRequerimiento.IdDetalleRequerimiento = CInt(txtIdDetalleRequerimiento.Text)
            detalleRequerimiento.IdUnidadMedida = ddlUnidad.SelectedValue
            detalleRequerimiento.IdCentroCosto = rcbCentroCostoDetalle.SelectedValue
            detalleRequerimiento.Cantidad = CDec(txtCantidad.Text)
            detalleRequerimiento.observacion = txtObservacionDetalle.Text
            detalleRequerimiento.AfectoIgv = afecto
            listaDetalle.Add(detalleRequerimiento)
        Next
        Dim requerimientoBL = New RequerimientoBL
        requerimientoBL.SaveDetalleRequerimiento(listaDetalle)
        gvDetalleRequerimiento.DataBind()
    End Sub
    Protected Sub lbAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregar.Click
        Dim _detalleRequerimiento As New DetalleRequerimiento
        _detalleRequerimientoBL = New DetalleRequerimientoBL
        Dim IdReq As Integer
        IdReq = CInt(Request.QueryString("IdReq"))
        _detalleRequerimiento.IdRequerimiento = IdReq
        _detalleRequerimiento.IdCatalogo = rcbProductoServicio.SelectedValue
        _detalleRequerimiento.IdCentroCosto = rcbCentroCosto.SelectedValue
        _detalleRequerimientoBL.SaveDetalleRequerimiento(_detalleRequerimiento)
        gvDetalleRequerimiento.DataBind()
        If gvDetalleRequerimiento.Rows.Count > 0 Then
            rcbProyecto.Enabled = False
        End If
    End Sub
    Protected Sub gvDetalleRequerimiento_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvDetalleRequerimiento.DataBound
        Dim i As Integer
        Dim estado As String
        If lblEstadoRequerimiento.Text = "En Espera" Then
            estado = "1"
        Else
            estado = "0"
        End If
        For i = 0 To gvDetalleRequerimiento.Rows.Count - 1
            Dim idDetalle As String = gvDetalleRequerimiento.DataKeys(i).Item(0).ToString
            Dim idProyecto As String = rcbProyecto.SelectedValue.ToString
            Dim producto As String = gvDetalleRequerimiento.DataKeys(i).Item(1).ToString & " - " & gvDetalleRequerimiento.DataKeys(i).Item(2).ToString
            Dim rcbCentroCostoDet As RadComboBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("rcbCentroCostoDetalle"), RadComboBox)
            rcbCentroCostoDet.Filter = 1
            Dim lbCentroCosto As LinkButton = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("lbCentroCosto"), LinkButton)
            lbCentroCosto.Attributes.Add("onClick", "CargarVentana(" & idDetalle & "," & idProyecto & ",'" & producto & "', " & estado & "); return false;")
        Next
    End Sub
    Protected Sub gvDetalleRequerimiento_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvDetalleRequerimiento.RowCommand
        _detalleRequerimientoBL = New DetalleRequerimientoBL
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim txtIdDetalleRequerimiento As TextBox = CType(gvDetalleRequerimiento.Rows(index).FindControl("txtIdDetReq"), TextBox)
            _detalleRequerimientoBL.EliminarDetalle(CInt(txtIdDetalleRequerimiento.Text))
            gvDetalleRequerimiento.DataBind()
        End If
    End Sub
    Protected Sub rcbProductoServicio_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbProductoServicio.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Catalogo)).CodigoDescripcion.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Catalogo)).IdCatalogo.ToString()
    End Sub
    Protected Sub rcbProductoServicio_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbProductoServicio.ItemsRequested
        If e.Text.Length > 2 Then
            Me.odsCatalogoBusqueda.SelectParameters("parametro").DefaultValue = e.Text.ToString
            Me.rcbProductoServicio.DataBind()
        End If
    End Sub
    Protected Sub lbAnularRequerimientoR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAnularRequerimientoR.Click
        _requerimientoBL = New RequerimientoBL
        _requerimientoBL.AnularRequerimiento(CInt(Request.QueryString("IdReq")), Session("IdUser"), txtMotivoAnula.Text, 1)
        Me.Response.Redirect("FrmListaRequerimientos.aspx")
    End Sub
End Class