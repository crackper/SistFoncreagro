Public Class ParamRepTabuladoMes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox11.Filter = 1
        Me.RadComboBox9.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
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

        If Me.CheckBox1.Checked Then
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteTabuladoMesDetalle.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&IdProyecto=" + idProyecto.ToString + "&CuentaInicio=" + Me.RadComboBox1.SelectedValue.ToString + "&CuentaFin=" + Me.RadComboBox11.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        Else
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteTabuladoMes.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&IdProyecto=" + idProyecto.ToString + "&CuentaInicio=" + Me.RadComboBox1.SelectedValue.ToString + "&CuentaFin=" + Me.RadComboBox11.SelectedValue.ToString + "' ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
       
    End Sub

    Protected Sub RadComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        Me.RadComboBox11.Text = ""
        Me.RadComboBox11.SelectedValue = Me.RadComboBox1.SelectedValue
        Me.RadComboBox11.Text = Me.RadComboBox1.Text
    End Sub
End Class