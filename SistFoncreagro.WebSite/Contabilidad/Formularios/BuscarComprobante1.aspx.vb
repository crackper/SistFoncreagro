Public Class BuscarComprobante1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.TextBox5.Attributes.Add("onChange", "ponerCeros();")
    End Sub

    'Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
    '    e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).Ruc.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
    '    e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    'End Sub

    'Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
    '    If e.Text.Length > 2 Then

    '        Me.RadComboBox1.DataSourceID = "odsProveedor"
    '        Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString

    '        Me.RadComboBox1.DataBind()
    '    End If
    'End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        'Dim IdProveedorCliente As Int32
        'If Me.RadComboBox1.SelectedValue.Length > 0 Then
        '    IdProveedorCliente = Me.RadComboBox1.SelectedValue
        'Else
        '    IdProveedorCliente = 0
        'End If

        Me.RadGrid1.DataSourceID = "sqlComprobantes"
        ' Me.sqlComprobantes.SelectParameters("IdProveedorCliente").DefaultValue = IdProveedorCliente
        Me.sqlComprobantes.SelectParameters("TipoDocumento").DefaultValue = Me.RadComboBox2.SelectedValue
        Me.sqlComprobantes.SelectParameters("SerieDocumento").DefaultValue = Me.TextBox5.Text
        Me.sqlComprobantes.SelectParameters("NroDocumento").DefaultValue = Me.TextBox2.Text
        Me.RadGrid1.DataBind()
    End Sub
End Class