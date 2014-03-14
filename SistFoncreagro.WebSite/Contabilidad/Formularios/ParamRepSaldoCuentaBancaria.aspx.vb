Public Class ParamRepSaldoCuentaBancaria
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idPlan As Int32 = 0
        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            idPlan = Me.RadComboBox1.SelectedValue
        End If

        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteSaldosCuentaBancaria.aspx?idPlan=" + idPlan.ToString + "&Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class