﻿Public Class ParamRepAnticiposRendiciones
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox8.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idProveedor As Int32 = 0
        Dim idProyecto As Int32 = 0

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            idProyecto = Me.RadComboBox3.SelectedValue
        End If

        If Me.RadComboBox8.SelectedValue.Length > 0 Then
            idProveedor = Me.RadComboBox8.SelectedValue
        End If

        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteAnticiposRendiciones.aspx?fechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&fechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&Idmoneda=" + Me.RadioButtonList1.SelectedValue + "&idProyecto=" + idProyecto.ToString + "&idProveedor=" + idProveedor.ToString + "&Estado=" + Me.DropDownList1.SelectedValue + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

    Protected Sub RadComboBox8_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox8.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).Ruc.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub

    Protected Sub RadComboBox8_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox8.ItemsRequested
        If e.Text.Length > 2 Then

            Me.RadComboBox8.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString

            Me.RadComboBox8.DataBind()
        End If
    End Sub
End Class