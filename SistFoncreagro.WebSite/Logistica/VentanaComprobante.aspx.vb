Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class VentanaComprobante
    Inherits System.Web.UI.Page
    Dim mOcfactura As New OcxFactura
    Dim mIocfacturaBl As New OcxFacturaBL
    Dim idc As Int32
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            rcmProyecto.Filter = 1
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
    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
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
        idc = mIocfacturaBl.SaveOcxFacturaComprobante(mOcfactura)
        Response.Redirect("VentanaComprobanteEdit.aspx?n=1&idc=" & idc & "&serie=" & txtSerie.Text & "&numero=" & txtNumero.Text & "&monto=" & txtMonto.Text & "&fecha=" & CStr(rdpFecha.SelectedDate) & "&idTipoDoc=" & rcbTipoDocumento.SelectedValue & "&idArea=" & rcmProyecto.SelectedValue & "&idProveedor=" & rcbProveedor.SelectedValue & "&nomProv=" & rcbProveedor.Text & "&idMoneda=" & ddlMoneda.SelectedValue & "&nrovales=" & RadNrovales.Text & "&obs=" & txtObservaciones.Text & "&fechaRecep=" & CStr(rdpFechaRecepcion.SelectedDate))
      End Sub
End Class