Imports Telerik.Web.UI
Public Class ProbandoRadWindowNuevoCargo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadWindowManager1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles RadWindowManager1.Load

    End Sub

    Protected Sub AJAX_MANAGER_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles AJAX_MANAGER.AjaxRequest
        If e.Argument.StartsWith("ActualizarCombo") Then
            Dim j() As String
            Dim idCargo As Int32
            j = Split(e.Argument, "|")

            idCargo = Convert.ToInt32(j(1))

            Me.RadComboBox1.DataBind()
            Me.RadComboBox1.SelectedValue = idCargo
        End If
    End Sub
End Class