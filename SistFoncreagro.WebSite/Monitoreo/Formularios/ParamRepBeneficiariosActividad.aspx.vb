Public Class ParamRepBeneficiariosActividad
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1

        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Now
            Me.RadDatePicker2.SelectedDate = Date.Now
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteBeneficiariosActividad.aspx?fechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&fechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&IdActividad=" + Me.RadComboBox3.SelectedValue.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class