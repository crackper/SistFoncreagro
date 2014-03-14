'Imports System
'Imports System.Collections.Generic
'Imports System.Linq
'Imports System.Web
'Imports System.Web.UI
'Imports System.Web.UI.WebControls
'Imports System.Web.Security

Public Class VentanaRoles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim usuario As Object = Request.QueryString("Nombre")
            lblUsuario.Text = usuario.ToString
            ''Dim rolesUsuario As List(Of String) = Roles.GetAllR
            'Dim rolesUsuario As List(Of String) = Roles.GetRolesForUser(lblUsuario.Text)
            Dim rolesDeUsuario() As String = Roles.GetRolesForUser(lblUsuario.Text)
            lbRolesForUser.DataSource = rolesDeUsuario
            lbRolesForUser.DataBind()

            Dim todosRoles() As String = Roles.GetAllRoles()
            Dim dispRoles = todosRoles.Except(rolesDeUsuario)

            lbRoles.DataSource = dispRoles
            lbRoles.DataBind()

            If lbRoles.Items.Count = 0 Then
                btnAgregar.Enabled = False
            End If
            If lbRolesForUser.Items.Count = 0 Then
                btnQuitar.Enabled = False
            End If
        End If

    End Sub

    Protected Sub btnAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregar.Click
        If Not (lbRoles.SelectedItem) Is Nothing Then
            Roles.AddUserToRole(lblUsuario.Text, lbRoles.SelectedItem.Text)
            Response.Redirect("VentanaRoles.aspx?Nombre=" + lblUsuario.Text)
        End If
    End Sub

    Protected Sub btnQuitar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuitar.Click
        If Not (lbRolesForUser.SelectedItem) Is Nothing Then
            Roles.RemoveUserFromRole(lblUsuario.Text, lbRolesForUser.SelectedItem.Text)
            Response.Redirect("VentanaRoles.aspx?Nombre=" + lblUsuario.Text)
        End If
    End Sub
End Class