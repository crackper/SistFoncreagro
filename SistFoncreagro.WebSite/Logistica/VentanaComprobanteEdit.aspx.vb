Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class VentanaComprobanteEdit
    Inherits System.Web.UI.Page
    Dim mOcfactura As New OcxFactura
    Dim mIocfacturaBl As New OcxFacturaBL
    Dim mDetalleComprobante As New DetalleComprobante
    Dim mIDetalleBl As New DetalleComprobanteBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            rcmProyecto.SelectedValue = Request.QueryString("idArea")
            rcbProveedor.DataSourceID = "odsProveedor"
            odsProveedor.SelectParameters("parametro").DefaultValue = Request.QueryString("nomProv")
            rcbProveedor.DataBind()
            rcbProveedor.SelectedValue = Request.QueryString("idProveedor")
            rcbTipoDocumento.SelectedValue = Request.QueryString("idTipoDoc")
            ddlMoneda.SelectedValue = Request.QueryString("idMoneda")
            txtSerie.Text = Request.QueryString("serie")
            txtNumero.Text = Request.QueryString("numero")
            txtMonto.Text = Request.QueryString("monto")
            rdpFecha.SelectedDate = CDate(Request.QueryString("fecha"))
            txtObservaciones.Text = Request.QueryString("obs")
            RadNrovales.Text = Request.QueryString("nrovales")
            rdpFechaRecepcion.SelectedDate = CDate(Request.QueryString("fechaRecep"))
            If Request.QueryString("n") = 0 Then
                btnGuardar.Visible = False
                btnAgregarDetalle.Visible = False
                gvDetalleComprobante.Columns(0).Visible = False
            Else
                If gvDetalleComprobante.Rows.Count > 0 Then
                    btnFinalizar.Visible = True
                End If
            End If
            rcmProyecto.Filter = 1
            rcbCentroCosto.Filter = 1
        End If
    End Sub
    Protected Sub rcbProveedor_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbProveedor.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub
    Protected Sub rcbProveedor_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbProveedor.ItemsRequested
        If e.Text.Length > 3 Then
            Me.odsProveedor.SelectParameters("parametro").DefaultValue = e.Text.ToString
            Me.rcbProveedor.DataBind()
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
    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        Dim idc As Int32
        mOcfactura.IdOcxFactura = Request.QueryString("idc")
        mOcfactura.Serie = txtSerie.Text
        mOcfactura.Numero = txtNumero.Text
        mOcfactura.Monto = CDec(txtMonto.Text)
        mOcfactura.Fecha = rdpFecha.SelectedDate
        mOcfactura.IdTipoDocumento = rcbTipoDocumento.SelectedValue
        mOcfactura.IdArea = rcmProyecto.SelectedValue
        mOcfactura.IdProveedor = rcbProveedor.SelectedValue
        mOcfactura.IdMoneda = ddlMoneda.SelectedValue
        mOcfactura.NroVales = CInt(RadNrovales.Text)
        mOcfactura.Observaciones = txtObservaciones.Text
        mOcfactura.FechaRecepcion = rdpFechaRecepcion.SelectedDate
        idc = mIocfacturaBl.UpdateOcxFacturaComprobante(mOcfactura)
        If idc = 0 Then
            ScriptManager.RegisterStartupScript(Me.Page, GetType(Page), "AlertaX", "<script language='javascript'>alert('No se puede actualizar el comprobante, verifique las cantidades ingresadas en el detalle.');</script>".ToString, False)
        Else
            rcbCentroCosto.DataBind()
            ScriptManager.RegisterStartupScript(Me.Page, GetType(Page), "AlertaX", "<script language='javascript'>alert('Comprobante Actualizado.');</script>".ToString, False)
        End If
    End Sub
    Protected Sub btnAgregarDetalle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregarDetalle.Click
        mDetalleComprobante.IdOcxfactura = Request.QueryString("idc")
        mDetalleComprobante.IdCatalogo = rcbProductoServicio.SelectedValue
        mDetalleComprobante.IdCentroCosto = rcbCentroCosto.SelectedValue
        mDetalleComprobante.Cantidad = CDec(RadCantidad.Text)
        mDetalleComprobante.Precio = CDec(RadPrecio.Text)
        mIDetalleBl.SaveDetalleComprobante(mDetalleComprobante)
        gvDetalleComprobante.DataBind()
        rcbProductoServicio.Text = ""
        rcbCentroCosto.Text = ""
        RadCantidad.Text = ""
        RadPrecio.Text = ""
        btnFinalizar.Visible = True
    End Sub

    Protected Sub gvDetalleComprobante_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvDetalleComprobante.RowCommand
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim txtId As TextBox = CType(gvDetalleComprobante.Rows(index).FindControl("txtIdDetalle"), TextBox)
            mIDetalleBl.DeleteDetalleComprobante(CInt(txtId.Text))
            gvDetalleComprobante.DataBind()
        End If
    End Sub
    Public Function calculo(ByVal can, ByVal precio) As Decimal
        Return can * precio
    End Function

    Protected Sub btnFinalizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFinalizar.Click
        Dim resultado As Int32
        resultado = mIocfacturaBl.FinalizarRegistroComprobante(Request.QueryString("idc"))
        If resultado = 0 Then
            ScriptManager.RegisterStartupScript(Me.Page, GetType(Page), "AlertaX", "<script language='javascript'>alert('Verificar el monto del comprobante.');</script>".ToString, False)
        Else
            Dim cadenaJava As String
            cadenaJava = "<script type='text/javascript'> " & _
                          " CerrarVentana(1); " & _
                          Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadenaJava.ToString, False)
        End If
    End Sub
End Class