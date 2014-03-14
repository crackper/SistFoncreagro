Public Class ParamRepAnaliticoCCosto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox9.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox10.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim ProyectoInicio As String = ""
        Dim CCostoInicio As String = ""

        If Me.RadComboBox9.SelectedValue.Length > 0 Then
            ProyectoInicio = Me.RadComboBox9.SelectedValue
        End If
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            CCostoInicio = Me.RadComboBox2.SelectedValue
        End If

        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteAnaliticoCCosto.aspx?FechaInicio=" + Me.RadDatePicker1.SelectedDate.ToString + "&FechaFin=" + Me.RadDatePicker2.SelectedDate.ToString + "&ProyectoInicio=" + Me.RadComboBox9.SelectedValue.ToString + "&ProyectoFin=" + Me.RadComboBox3.SelectedValue.ToString + "&CCostoInicio=" + Me.RadComboBox2.SelectedValue.ToString + "&CCostoFin=" + Me.RadComboBox10.SelectedValue.ToString + "' ); " & _
                                     Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

    End Sub

    Protected Sub RadComboBox9_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox9.SelectedIndexChanged
        Me.RadComboBox3.Text = ""
        Me.RadComboBox3.SelectedValue = Me.RadComboBox9.SelectedValue
        Me.RadComboBox3.Text = Me.RadComboBox9.Text
    End Sub

    Protected Sub RadComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox2.SelectedIndexChanged
        Me.RadComboBox10.Text = ""
        Me.RadComboBox10.SelectedValue = Me.RadComboBox2.SelectedValue
        Me.RadComboBox10.Text = Me.RadComboBox2.Text
    End Sub
End Class