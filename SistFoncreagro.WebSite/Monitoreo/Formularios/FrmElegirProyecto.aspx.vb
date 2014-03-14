Public Class FrmElegirProyecto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox9.Filter = 1
    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Session("IdProyecto") = Me.RadComboBox9.SelectedValue.ToString
        Response.Redirect("DefaultMonitoreo.aspx")
    End Sub
End Class