Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmListaUsuarios
    Inherits System.Web.UI.Page
    Dim usuarioBl As IUsuarioBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub gvRolPersonal_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvRolPersonal.DataBound
        Dim i As Integer
        For i = 0 To gvRolPersonal.Rows.Count - 1
            Dim label As Label = CType(Me.gvRolPersonal.Rows(i).FindControl("lblEstado"), Label)
            Dim linkButonEstadoGrilla As LinkButton = CType(Me.gvRolPersonal.Rows(i).FindControl("lbEstado"), LinkButton)
            Dim linkButonRestaurar As LinkButton = CType(Me.gvRolPersonal.Rows(i).FindControl("lbRestart"), LinkButton)
            Dim idUsuario As Int32 = gvRolPersonal.DataKeys(i).Item(1).ToString
            If label.Text = "True" Then
                linkButonEstadoGrilla.Text = "Desbloquear"
            End If
            linkButonEstadoGrilla.Attributes.Add("onClick", "CargaEstado('" & label.Text & "'," & idUsuario & "); return false;")
            linkButonRestaurar.Attributes.Add("onClick", "Restaurar(" & idUsuario & "); return false;")

            Dim nombreUsuario As String = gvRolPersonal.DataKeys(i).Item(0).ToString
            Dim lbRolesGrilla As LinkButton = CType(Me.gvRolPersonal.Rows(i).FindControl("lbRoles"), LinkButton)
            lbRolesGrilla.Attributes.Add("onClick", "CargarVentana('" & nombreUsuario & "'); return false;")
        Next
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument.StartsWith("CambiarEstado") Then
            Dim j() As String
            Dim estado As String
            Dim idUser As Int32
            j = Split(e.Argument, "|")
            estado = j(1)
            idUser = CInt(j(2))
            usuarioBl = New UsuarioBL
            If estado = "True" Then
                usuarioBl.HabilitarDeshabilitar(idUser, True)
            Else
                usuarioBl.HabilitarDeshabilitar(idUser, False)
            End If
            gvRolPersonal.DataBind()
        ElseIf e.Argument.StartsWith("Restaurar") Then
            Dim j() As String
            Dim idUser As Int32
            j = Split(e.Argument, "|")
            idUser = CInt(j(1))
            usuarioBl = New UsuarioBL
            usuarioBl.RestaurarPaswword(idUser)
        End If
    End Sub
End Class