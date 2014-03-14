Public Class ParamRepGastos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim cadena_java As String
        Dim IdProyecto As Int32 = 0

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            IdProyecto = Me.RadComboBox3.SelectedValue
        End If
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteGastos.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&IdProyecto=" + IdProyecto.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class