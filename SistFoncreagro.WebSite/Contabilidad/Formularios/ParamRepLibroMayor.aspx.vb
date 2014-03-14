Public Class ParamRepLibroMayor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
        Me.RadComboBox9.Filter = 1
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox11.Filter = 1
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idProyecto As Int32 = 0
        Dim CuentaInicio As String = " "
        Dim CuentaFin As String = " "

        If Me.RadComboBox9.SelectedValue.Length > 0 Then
            idProyecto = Me.RadComboBox9.SelectedValue
        End If
        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            CuentaInicio = Me.RadComboBox1.SelectedValue
        End If
        If Me.RadComboBox11.SelectedValue.Length > 0 Then
            CuentaFin = Me.RadComboBox11.SelectedValue
        End If

        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteLibroMayor.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&IdProyecto=" + idProyecto.ToString + "&CuentaInicio=" + CuentaInicio.ToString + "&CuentaFin=" + CuentaFin.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

    End Sub
End Class