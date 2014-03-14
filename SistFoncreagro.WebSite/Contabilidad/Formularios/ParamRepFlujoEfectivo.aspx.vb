Public Class ParamRepFlujoEfectivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim cadena_java As String
        Dim IdProyecto As Int32 = 0

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            IdProyecto = Me.RadComboBox3.SelectedValue
        End If

        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteFlujoEfectivo.aspx?FechaFin=" + Me.RadDatePicker1.SelectedDate.ToString + "&idProyecto=" + IdProyecto.ToString + "&tipo=" + Me.RadComboBox4.SelectedValue.ToString + "&Proyecto=" + Me.RadComboBox3.Text.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

    Protected Sub RadComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox4.SelectedIndexChanged
        If Me.RadComboBox4.SelectedValue = "A" Then
            Me.RadComboBox3.Enabled = True
        Else
            Me.RadComboBox3.Enabled = False
        End If
    End Sub
End Class