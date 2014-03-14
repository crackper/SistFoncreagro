Public Class ParamRepGastosDet
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox2.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idProyecto As Int32 = 0
        Dim idSubdiario As Int32 = 0
        Dim cadena_java As String

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            idProyecto = Me.RadComboBox3.SelectedValue
        End If
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            idSubdiario = Me.RadComboBox2.SelectedValue
        End If

        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteConsolidadoGastos.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&idProyecto=" + idProyecto.ToString + "&idSubdiario=" + idSubdiario.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class