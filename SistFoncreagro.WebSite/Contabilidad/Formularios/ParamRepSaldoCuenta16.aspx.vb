Public Class ParamRepSaldoCuenta16
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox8.Filter = 1
        Me.RadComboBox3.Filter = 1

        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim IdProveedor As Int32 = 0
        Dim IdProyecto As Int32 = 0
        Dim Proyecto As String = ""
        Dim cadena_java As String

        If Me.RadComboBox8.SelectedValue.Length > 0 Then

            IdProveedor = Me.RadComboBox8.SelectedValue
        End If
        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            IdProyecto = Me.RadComboBox3.SelectedValue
            Proyecto = Me.RadComboBox3.Text
        End If
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteSaldoCuenta16.aspx?IdMoneda=" + Me.RadioButtonList1.SelectedValue + "&IdProveedor=" + IdProveedor.ToString + "&FechaFin=" + Me.RadDatePicker1.SelectedDate.ToString + "&IdProyecto=" + IdProyecto.ToString + "&Proyecto=" + Proyecto.ToString + "' ); " & _
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