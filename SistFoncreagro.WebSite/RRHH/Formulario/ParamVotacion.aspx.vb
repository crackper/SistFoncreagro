Public Class ParamVotacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadNumericTextBox1.Text = Date.Now.Year
        End If
    End Sub
    Protected Sub RadNumericTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox1.TextChanged
        Me.RadComboBox1.DataBind()
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteVotacion.aspx?IdEncuesta=" + Me.RadComboBox1.SelectedValue.ToString + "' ); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class