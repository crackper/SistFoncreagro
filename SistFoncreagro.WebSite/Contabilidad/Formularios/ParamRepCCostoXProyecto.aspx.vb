Public Class ParamRepCCostoXProyecto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteCCostoXProyecto.aspx?IdProyecto=" + Me.RadComboBox3.SelectedValue.ToString + "&Proyecto=" + Me.RadComboBox3.Text.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class