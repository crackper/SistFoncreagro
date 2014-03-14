Public Class ParamRepretencionesCuarta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
        Me.RadComboBox8.Filter = 1
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idProveedorCliente As Int32 = 0

        If Me.RadComboBox8.SelectedValue.Length > 0 Then
            idProveedorCliente = Me.RadComboBox8.SelectedValue
        End If

        If Me.RadioButtonList1.SelectedValue = "C" Then
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteRetencionesCuarta.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&idProveedorCliente=" + idProveedorCliente.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf Me.RadioButtonList1.SelectedValue = "R" Then
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteListaRetencionesCuarta.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&idProveedorCliente=" + idProveedorCliente.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf Me.RadioButtonList1.SelectedValue = "A" Then
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteRetencionesCuarta.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&idProveedorCliente=" + idProveedorCliente.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "' ); " & _
                                         " window.open('ReporteListaRetencionesCuarta.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&idProveedorCliente=" + idProveedorCliente.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
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