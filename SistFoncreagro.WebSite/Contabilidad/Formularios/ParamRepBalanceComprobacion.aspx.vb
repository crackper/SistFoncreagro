Public Class ParamRepBalanceComprobacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
        Me.RadComboBox1.Filter = 1
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idProyecto As Int32 = 0

        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            idProyecto = Me.RadComboBox1.SelectedValue
        End If

        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteBalanceComprobacion.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&idProyecto=" + idProyecto.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "&tipo=" + Me.RadComboBox4.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

    End Sub

    Protected Sub RadComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox4.SelectedIndexChanged
        If Me.RadComboBox4.SelectedValue = "A" Then
            Me.RadComboBox1.Enabled = True
        Else
            Me.RadComboBox1.Enabled = False
        End If
    End Sub
End Class