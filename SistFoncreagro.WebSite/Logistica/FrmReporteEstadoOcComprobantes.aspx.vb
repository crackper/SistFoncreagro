Public Class FrmReporteEstadoOcComprobantes
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.rcmbProyecto.Filter = 1
        Me.rcmbProveedor.Filter = 1
    End Sub
    Protected Sub rcmbProveedor_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcmbProveedor.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).Ruc.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub
    Protected Sub rcmbProveedor_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcmbProveedor.ItemsRequested
        If e.Text.Length > 2 Then
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString
            Me.rcmbProveedor.DataBind()
        End If
    End Sub
    Protected Sub rcmbOrdenCompra_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcmbOrdenCompra.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.OrdenCompra)).numeroOrdenCompra.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.OrdenCompra)).IdOrdenCompra.ToString()
    End Sub
    Protected Sub rcmbOrdenCompra_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcmbOrdenCompra.ItemsRequested
        If e.Text.Length > 2 Then
            Me.odsOrdenCompra.SelectParameters("parametro").DefaultValue = e.Text.ToString
            Me.rcmbOrdenCompra.DataBind()
        End If
    End Sub
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim IdProyecto As Int32
        Dim IdProveedor As Int32
        Dim IdOrden As Int32
        Dim fechas As Int32

        If Me.rcmbOrdenCompra.SelectedValue.Length > 0 Then
            IdOrden = rcmbOrdenCompra.SelectedValue
            IdProyecto = 0
            IdProveedor = 0
            fechas = 0
        Else
            If Me.rcmbProyecto.SelectedValue.Length > 0 Then
                IdProyecto = rcmbProyecto.SelectedValue
            Else
                IdProyecto = 0
            End If
            If Me.rcmbProveedor.SelectedValue.Length > 0 Then
                IdProveedor = rcmbProveedor.SelectedValue
            Else
                IdProveedor = 0
            End If
            If Me.rdpFechaInicio.SelectedDate.ToString.Length > 0 And Me.rdpFechaFin.SelectedDate.ToString.Length > 0 Then
                fechas = 1
            Else
                fechas = 0
            End If
        End If
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('VentanaEstadoOcComprobantes.aspx?fec=" + fechas.ToString + "&fechaIni=" + Me.rdpFechaInicio.SelectedDate.ToString + "&fechaFin=" + Me.rdpFechaFin.SelectedDate.ToString + "&proyecto=" + IdProyecto.ToString + "&proveedor=" + IdProveedor.ToString + "&idoc=" + IdOrden.ToString + "','','width=1000, height=700'); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

End Class