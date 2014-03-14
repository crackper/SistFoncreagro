Public Class ParamRepBalanceComprobacionAcumulado
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

        If Me.RadioButtonList1.SelectedValue = "M" Then
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteBalanceComprobacionAcumuladoMayor.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&idProyecto=" + idProyecto.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

        ElseIf Me.RadioButtonList1.SelectedValue = "S" Then
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteBalanceComprobacionAcumuladoSub.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&idProyecto=" + idProyecto.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        Else
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteBalanceComprobacionAcumuladoDet.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&idProyecto=" + idProyecto.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub
End Class