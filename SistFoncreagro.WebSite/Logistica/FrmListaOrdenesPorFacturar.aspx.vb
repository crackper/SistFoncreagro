Imports Telerik.Web.UI
Public Class FrmListaOrdenesPorFacturar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub RadGrid1_ItemCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemCreated
        If TypeOf e.Item Is GridDataItem Then
            Dim linkb As LinkButton = DirectCast(e.Item.FindControl("lbComprobante"), LinkButton)
            Dim idOrdenCompra = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdOrdenCompra")
            Dim nroOc = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("NumeroOrden")
            Dim area = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("CodigoAreaD")
            Dim factura = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("factura")
            Dim total = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Total")
            Dim moneda = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("AbreviacionMonedaD")
            linkb.Attributes.Add("onClick", "CargarBandejaFactura(" & idOrdenCompra & ", '" & factura & "', '" & nroOc & "', '" & area & "'," & total & ", '" & moneda & "'); return false;")
            'lbRegistroComprobante.Attributes.Add("onClick", "CargarBandejaFactura(" & idOrdenCompra & ", '" & factura & "', '" & nroOc & "', '" & area & "'," & total & ", '" & moneda & "'); return false;")
        End If
    End Sub
End Class