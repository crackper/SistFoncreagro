﻿Public Class FrmReporteComprobantes
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim IdProveedor As Int32
        Dim fechas As Int32
        If rcmbProveedor.SelectedValue.Length > 0 Then
            IdProveedor = rcmbProveedor.SelectedValue
        Else
            IdProveedor = 0
        End If
        If Me.rdpFechaInicio.SelectedDate.ToString.Length > 0 And Me.rdpFechaFin.SelectedDate.ToString.Length > 0 Then
            fechas = 1
        Else
            fechas = 0
        End If

        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('VentanaReporteComprobantes.aspx?fec=" + fechas.ToString + "&fechaIni=" + Me.rdpFechaInicio.SelectedDate.ToString + "&fechaFin=" + Me.rdpFechaFin.SelectedDate.ToString + "&proveedor=" + IdProveedor.ToString + "&nrodoc=" + txtNumeroComprobante.Text + "','','width=1000, height=700'); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

End Class