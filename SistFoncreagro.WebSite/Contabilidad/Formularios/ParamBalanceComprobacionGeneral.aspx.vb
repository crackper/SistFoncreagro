Public Class ParamBalanceComprobacionGeneral
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim IdProyecto As Int32 = 0

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            IdProyecto = Me.RadComboBox3.SelectedValue
        End If

        Response.Redirect("BalanceComprobacionGeneral.aspx?Fecha=" + (Me.RadDatePicker1.SelectedDate.ToString).Substring(0, 10) + "&Proyecto=" + IdProyecto.ToString)
    End Sub
End Class