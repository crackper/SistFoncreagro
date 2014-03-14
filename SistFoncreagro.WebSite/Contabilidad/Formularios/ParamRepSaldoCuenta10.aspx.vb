Public Class ParamRepSaldoCuenta10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1

        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim IdProyecto As Int32 = 0
        Dim Proyecto As String = ""
        Dim cadena_java As String

       If Me.RadComboBox3.SelectedValue.Length > 0 Then
            IdProyecto = Me.RadComboBox3.SelectedValue
            Proyecto = Me.RadComboBox3.Text
        End If
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteSaldoCuenta10.aspx?IdMoneda=" + Me.RadioButtonList1.SelectedValue + "&FechaFin=" + Me.RadDatePicker1.SelectedDate.ToString + "&IdProyecto=" + IdProyecto.ToString + "&Proyecto=" + Proyecto.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class