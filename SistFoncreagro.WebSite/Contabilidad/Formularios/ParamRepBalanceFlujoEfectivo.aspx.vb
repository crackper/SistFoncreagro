Public Class ParamRepBalanceFlujoEfectivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
        Me.RadComboBox1.Filter = 1
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim IdProyecto As Int32 = 0
        Dim cadena_java As String

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            IdProyecto = Me.RadComboBox3.SelectedValue
        End If

        If Me.RadioButtonList1.SelectedValue = "M" Then
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteBalanceFlujoEfectivoMayor.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&tipo=" + Me.RadComboBox1.SelectedValue.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "&idProyecto=" + IdProyecto.ToString + "&proyecto=" + Me.RadComboBox3.Text.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf Me.RadioButtonList1.SelectedValue = "D" Then
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteBalanceFlujoEfectivoSubDivisionaria.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&tipo=" + Me.RadComboBox1.SelectedValue.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "&idProyecto=" + IdProyecto.ToString + "&proyecto=" + Me.RadComboBox3.Text.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        Else
            cadena_java = "<script type='text/javascript'> " & _
                                        " window.open('ReporteBalanceFlujoEfectivoSubDivisionaria1.aspx?Fecha=" + Me.RadDatePicker1.SelectedDate.ToString + "&tipo=" + Me.RadComboBox1.SelectedValue.ToString + "&idMoneda=" + Me.RadioButtonList2.SelectedValue.ToString + "&idProyecto=" + IdProyecto.ToString + "&proyecto=" + Me.RadComboBox3.Text.ToString + "' ); " & _
                                        Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
        
    End Sub

    Protected Sub RadComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        If Me.RadComboBox1.SelectedValue = "A" Then
            Me.RadComboBox3.Enabled = True
        Else
            Me.RadComboBox3.Enabled = False
        End If
    End Sub
End Class