Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmCotizacionEditar
    Inherits System.Web.UI.Page
    Dim cotizacionBl As New CotizacionBL
    Dim proveedorDetalleCotizBl As IProveedorDetalleCotizacionBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            txtIdCotizacion.Text = Request.QueryString("IdCoti")
            txtIdRequerimiento.Text = Request.QueryString("IdReq")
            Dim idCotizacion As String = Request.QueryString("IdCoti")
            rcbProductoServicio.Filter = 1
            Dim coti = cotizacionBl.GetFromCotizacionByIdCotizacion(CInt(idCotizacion.ToString))
            CargarCotizacion(coti)
        End If
    End Sub
    Public Sub CargarCotizacion(ByVal coti As Cotizacion)
        Dim estado As Int32
        ddlTipo.SelectedValue = coti.IdTipoCotizacion
        ddlMoneda.SelectedValue = coti.IdMoneda
        txtNombre.Text = coti.Nombre
        lblRequerimiento.Text = coti.NroRequerimiento
        lblEstado.Text = coti.Estado
        lblArea.Text = coti.CodigoArea
        txtObservaciones.Text = coti.Observaciones
        lblFechaRegistro.Text = coti.FechaRegistro.ToShortDateString
        If coti.Estado = "En Espera" Then
            If coti.IdTipoCotizacion = 4 Then
                lblFechaRegistro.Visible = False
                lbSolicitarAprobacion.Enabled = True
                lblFecha.Text = "Razón :"
                ddlRazonCotizacion.Visible = True
                ddlRazonCotizacion.SelectedValue = coti.IdRazon
            End If
            'If gvDetalleCotizacion.Rows.Count > 0 Then
            '    Dim gvProveedorCotizacion As GridView = CType(gvDetalleCotizacion.Rows(0).FindControl("gvProveedor"), GridView)
            '    If (gvProveedorCotizacion.Rows.Count > 0) Then
            '        lbFinalizar.Visible = True
            '    End If
            'End If
            estado = 0
        Else
            If coti.Estado = "Pendiente" Then
                lbGenerarOc.Visible = True
                lbAgregarProveedor.Visible = False
                lbAgregarProductoServicio.Visible = False
                lbGuardarDetalle.Visible = False
                ''Habilito la opcion modificar
                lbGuardarCabezera.Text = "Modificar Registro"
                estado = 0
            Else
                If coti.Estado = "Finalizado" Or coti.Estado = "Anulado" Then
                    lbGuardarCabezera.Visible = False
                    lbAgregarProveedor.Visible = False
                    lbAgregarProductoServicio.Visible = False
                    lbGuardarDetalle.Visible = False
                    lbAnularCotizacion.Visible = False
                    estado = 1
                Else
                    If coti.Estado = "Aprobado" Then
                        lbGenerarOc.Visible = True
                        lbAgregarProveedor.Visible = False
                        lbAgregarProductoServicio.Visible = False
                        lbGuardarDetalle.Visible = False
                        lbSolicitarAprobacion.visible = False
                        lbAnularCotizacion.Visible = False
                        lbGuardarCabezera.Visible = False
                        estado = 1
                    Else
                        lbGenerarOc.Visible = False
                        lbAgregarProveedor.Visible = False
                        lbAgregarProductoServicio.Visible = False
                        lbGuardarDetalle.Visible = False
                        lbSolicitarAprobacion.visible = False
                        lbAnularCotizacion.Visible = False
                        lbGuardarCabezera.Visible = False
                        estado = 1
                    End If
                End If
            End If
            gvDetalleCotizacion.Columns(1).Visible = False
            For i = 0 To gvDetalleCotizacion.Rows.Count - 1
                Dim gvProveedorBloq As GridView = CType(Me.gvDetalleCotizacion.Rows(i).FindControl("gvProveedor"), GridView)
                gvProveedorBloq.Columns(0).Visible = False
                gvProveedorBloq.Columns(1).Visible = False
            Next
        End If
        lbAdjuntarArchivo.Attributes.Add("onClick", "CargarVentanaCotizacion(" & estado & "); return false;")
        CargarParrafo(coti.IdTipoCotizacion, estado)
        CargarDatos(coti.IdCotizacion)
    End Sub
    Sub CargarParrafo(ByVal tipo As Int32, ByVal est As Int32)
        lbAgregarParrafo.Attributes.Add("onClick", "CargarVentanaDetalle(" & tipo & ", " & est & "); return false;")
        If tipo = 4 Then
            lbAgregarParrafo.Text = "Agregar justificación"
        Else
            lbAgregarParrafo.Text = "Agregar detalle"
        End If
    End Sub
    Protected Sub CargarDatos(ByVal idCotizacion As Int32)
        Dim cj As String
        cj = "<script type='text/javascript'> cargarDatos('" & idCotizacion & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "cargarDatos", cj.ToString, False)
    End Sub
    Protected Sub rcbProveedor_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbProveedor.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub

    Protected Sub rcbProveedor_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbProveedor.ItemsRequested
        If e.Text.Length > 3 Then
            Me.odsProveedor.SelectParameters("parametro").DefaultValue = e.Text.ToString
            Me.rcbProveedor.DataBind()
        End If
    End Sub

    Protected Sub lbAgregarProveedor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregarProveedor.Click
        Dim listaProveedorDetalleCoti As New List(Of ProveedorDetalleCotizacion)
        For i = 0 To gvDetalleCotizacion.Rows.Count - 1
            Dim proveedorDetalleCotiz As New ProveedorDetalleCotizacion
            Dim txtIdDetalleReqCotizacion As TextBox = CType(Me.gvDetalleCotizacion.Rows(i).FindControl("txtIdDetReqCoti"), TextBox)
            proveedorDetalleCotiz.IdDetalleReqCotizacion = CInt(txtIdDetalleReqCotizacion.Text)
            proveedorDetalleCotiz.IdProveedor = rcbProveedor.SelectedValue
            listaProveedorDetalleCoti.Add(proveedorDetalleCotiz)
        Next
        proveedorDetalleCotizBl = New ProveedorDetalleCotizacionBL
        proveedorDetalleCotizBl.SaveProveedorDetalleCotizacion1(listaProveedorDetalleCoti)
        rcbProveedor.Text = Nothing
        gvDetalleCotizacion.DataBind()
    End Sub

    Protected Sub gvProveedor_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)
        proveedorDetalleCotizBl = New ProveedorDetalleCotizacionBL
        Dim listaProveedorDetalleCotizacion As New List(Of ProveedorDetalleCotizacion)
        Dim gvProv As GridView = CType(sender, GridView)
        Dim index = e.CommandArgument
        If e.CommandName = "DeleteCommand" Then
            Dim txtIdProveedor As TextBox = CType(gvProv.Rows(index).FindControl("txtIdProveedor"), TextBox)
            For i = 0 To gvDetalleCotizacion.Rows.Count - 1
                Dim proveedorDetalleCotizacion As New ProveedorDetalleCotizacion
                Dim txtIdDetalleReqCotizacion As TextBox = CType(gvDetalleCotizacion.Rows(i).FindControl("txtIdDetalleReqCotizacion"), TextBox)
                proveedorDetalleCotizacion.IdDetalleReqCotizacion = CInt(txtIdDetalleReqCotizacion.Text)
                proveedorDetalleCotizacion.IdProveedor = CInt(txtIdProveedor.Text)
                listaProveedorDetalleCotizacion.Add(proveedorDetalleCotizacion)
            Next
            proveedorDetalleCotizBl.DeleteProveedor1(listaProveedorDetalleCotizacion)
            gvDetalleCotizacion.DataBind()
        End If
    End Sub
    Protected Sub gvDetalleCotizacion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvDetalleCotizacion.RowCommand
        Dim index = e.CommandArgument
        If e.CommandName = "DeleteItem" Then
            Dim txtDetalleReqCotizacion As TextBox = CType(gvDetalleCotizacion.Rows(index).FindControl("txtIdDetReqCoti"), TextBox)
            cotizacionBl.DeleteItemDetalleReqCotizacion(CInt(txtDetalleReqCotizacion.Text))
            gvDetalleCotizacion.DataBind()
            rcbProductoServicio.DataBind()
        End If
    End Sub
    Protected Sub lbAgregarProductoServicio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregarProductoServicio.Click
        Dim detalleReqCoti As New DetalleReqCotizacion
        detalleReqCoti.IdCotizacion = CInt(txtIdCotizacion.Text)
        detalleReqCoti.IdDetalleRequerimiento = CInt(rcbProductoServicio.SelectedValue)
        cotizacionBl.SaveItemDetalleReqCotizacon(detalleReqCoti)
        rcbProductoServicio.Text = Nothing
        gvDetalleCotizacion.DataBind()
        rcbProductoServicio.DataBind()
    End Sub

    Protected Sub gvProveedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim gvProv As GridView = CType(sender, GridView)
        For i = 0 To gvProv.Rows.Count - 1
            Dim rButon As RadioButton = CType(gvProv.Rows(i).FindControl("rbSeleccionarProveedor"), RadioButton)
            rButon.Checked = False
            gvProv.Rows(i).BackColor = Nothing
        Next
        gvProv.SelectedRow.BackColor = Drawing.Color.Gainsboro
        Dim rButonSelec As RadioButton = CType(gvProv.SelectedRow.FindControl("rbSeleccionarProveedor"), RadioButton)
        rButonSelec.Checked = True
        txtValidar.Text = "0"
        lblMensaje.Visible = False
    End Sub

    Protected Sub lbGuardarDetalle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbGuardarDetalle.Click
        Dim listaProveedorDetalleCotizacion As New List(Of ProveedorDetalleCotizacion)
        For i = 0 To gvDetalleCotizacion.Rows.Count - 1
            If txtValidar.Text = "0" Then
                Dim gvProveedorCotizacion As GridView = CType(gvDetalleCotizacion.Rows(i).FindControl("gvProveedor"), GridView)
                For j = 0 To gvProveedorCotizacion.Rows.Count - 1
                    Dim proveedorDetalleCotizacion As New ProveedorDetalleCotizacion
                    Dim txtIdProveedorDetalleCoti As TextBox = CType(gvProveedorCotizacion.Rows(j).FindControl("txtIdProveedorDetalleCotizacion"), TextBox)
                    Dim txtMonto As TextBox = CType(gvProveedorCotizacion.Rows(j).FindControl("txtPrecio"), TextBox)
                    Dim rButon As RadioButton = CType(gvProveedorCotizacion.Rows(j).FindControl("rbSeleccionarProveedor"), RadioButton)
                    proveedorDetalleCotizacion.IdProveedorDetalleCotizacion = CInt(txtIdProveedorDetalleCoti.Text)
                    proveedorDetalleCotizacion.Monto = CDec(txtMonto.Text)
                    proveedorDetalleCotizacion.Estado = IIf(rButon.Checked = True, True, False)
                    listaProveedorDetalleCotizacion.Add(proveedorDetalleCotizacion)
                    If rButon.Checked = True And CDec(txtMonto.Text) > 0 Then
                        txtValidar.Text = "1"
                    End If
                Next
                If txtValidar.Text = "1" Then
                    txtValidar.Text = "0"
                Else
                    txtValidar2.Text = CStr(i + 1)
                End If
            End If
        Next
        If CInt(txtValidar2.Text) > 0 Then
            lblMensaje.Visible = True
            lblMensaje.Text = "Debe seleccionar un Proveedor o verificar el Precio para el Item: " + txtValidar2.Text
            txtValidar2.Text = "0"
        Else
            lblMensaje.Visible = False
            lbFinalizar.Visible = True
        End If
        proveedorDetalleCotizBl = New ProveedorDetalleCotizacionBL
        proveedorDetalleCotizBl.UpdateProveedorDetalleCotizacion1(listaProveedorDetalleCotizacion)
        If ddlTipo.SelectedValue = 4 Then
            lbSolicitarAprobacion.Enabled = True
            lbFinalizar.Visible = False
        Else
            lbSolicitarAprobacion.Enabled = False
        End If
    End Sub

    Protected Sub lbGenerarOc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbGenerarOc.Click
        cotizacionBl.GenerarOrdenCompraOfIdCotizacion(CInt(txtIdCotizacion.Text))
        Response.Redirect("FrmListaOrdenesCompra.aspx")
    End Sub

    Protected Sub lbGuardarCabezera_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbGuardarCabezera.Click
        If lblEstado.Text = "En Espera" Then
            Dim cotizacionEntity As New Cotizacion
            cotizacionEntity.IdCotizacion = CInt(txtIdCotizacion.Text)
            cotizacionEntity.IdTipoCotizacion = ddlTipo.SelectedValue
            cotizacionEntity.IdMoneda = ddlMoneda.SelectedValue
            cotizacionEntity.Nombre = txtNombre.Text
            cotizacionEntity.Observaciones = txtObservaciones.Text
            If ddlTipo.SelectedValue = 4 Then
                cotizacionEntity.IdRazon = ddlRazonCotizacion.SelectedValue
                lbSolicitarAprobacion.Enabled = True
            Else
                cotizacionEntity.IdRazon = 0
                lbSolicitarAprobacion.Enabled = False
            End If
            cotizacionBl.UpdateCotizacion(cotizacionEntity)
            CargarParrafo(cotizacionEntity.IdTipoCotizacion, 1)
        Else
            cotizacionBl.ModificarCotizacionCompleta(CInt(txtIdCotizacion.Text))
            Response.Redirect("FrmCotizacionEditar.aspx?IdCoti=" + txtIdCotizacion.Text + "&IdReq=" + txtIdRequerimiento.Text)
        End If
    End Sub

    Protected Sub lbFinalizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbFinalizar.Click
        For i = 0 To gvDetalleCotizacion.Rows.Count - 1
            If txtValidar.Text = "0" Then
                Dim gvProveedorCotizacion As GridView = CType(gvDetalleCotizacion.Rows(i).FindControl("gvProveedor"), GridView)
                For j = 0 To gvProveedorCotizacion.Rows.Count - 1
                    Dim txtMonto As TextBox = CType(gvProveedorCotizacion.Rows(j).FindControl("txtPrecio"), TextBox)
                    Dim rButon As RadioButton = CType(gvProveedorCotizacion.Rows(j).FindControl("rbSeleccionarProveedor"), RadioButton)
                    If rButon.Checked = True And (CDec(txtMonto.Text) > 0) Then
                        txtValidar.Text = "1"
                    End If
                Next
                If txtValidar.Text = "1" Then
                    txtValidar.Text = "0"
                Else
                    txtValidar.Text = "3"
                    lblMensaje.Visible = True
                    lblMensaje.Text = "Verifique el Proveedor o el monto del Item: " + CStr(i + 1)
                    gvProveedorCotizacion.DataBind()
                    'Exit Sub
                End If
            End If
        Next
        If txtValidar.Text = "3" Then
            txtValidar.Text = "0"
            lblMensaje.Text = "Verifique el Proveedor o el monto ingresado."
        Else
            cotizacionBl.FinalizarCotizacion(CInt(txtIdCotizacion.Text))
            Response.Redirect("FrmCotizacionEditar.aspx?IdCoti=" + txtIdCotizacion.Text + "&IdReq=" + txtIdRequerimiento.Text)
        End If
        
    End Sub
    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "AnularCotizacion" Then
            cotizacionBl.AnularCotizacion(CInt(txtIdCotizacion.Text))
            Response.Redirect("FrmListaCotizacionPendiente.aspx")
        End If
    End Sub
    Protected Sub ddlTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlTipo.SelectedIndexChanged
        If ddlTipo.SelectedValue <> 4 Then
            querid.Enabled = False
            lblFecha.Text = "Fecha :"
            lblFechaRegistro.Visible = True
            ddlRazonCotizacion.Visible = False
        Else
            ddlRazonCotizacion.Visible = False
            lblFecha.Text = "Razón :"
            ddlRazonCotizacion.Visible = True
            querid.Enabled = True
            lblFechaRegistro.Visible = False
        End If
    End Sub
    Protected Sub lbSolicitarAprobacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbSolicitarAprobacion.Click
        cotizacionBl.SolicitarAprobacionSoulSource(CInt(txtIdCotizacion.Text), ddlRazonCotizacion.SelectedValue)
        Response.Redirect("FrmListaCotizacionPendiente.aspx")
    End Sub
End Class