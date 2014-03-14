Public Class ParamRepSemovientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox1.Filter = 1
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim Proyecto As Int32 = 0
        Dim Cpd As Int32 = 0
        Dim Tipo As Int32 = 0

        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            Proyecto = Me.RadComboBox1.SelectedValue
        End If
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            Cpd = Me.RadComboBox2.SelectedValue
        End If
        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            Tipo = Me.RadComboBox3.SelectedValue
        End If

        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteSemovientes.aspx?Proyecto=" + Proyecto.ToString + "&Cpd=" + Cpd.ToString + "&Tipo=" + Tipo.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class