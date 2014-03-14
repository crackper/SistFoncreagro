Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub LoginUsuarioFoncre_LoggedIn(ByVal sender As Object, ByVal e As EventArgs) Handles LoginUsuarioFoncre.LoggedIn
        Dim usuarioPersonal As New Usuario
        Dim usuarioPersonalBL As New UsuarioBL
        usuarioPersonal = usuarioPersonalBL.GetUsuarioByNombreUsuarioSistema(Me.LoginUsuarioFoncre.UserName.ToString)
        Session("IdUser") = usuarioPersonal.IdUsuario
        Session("NombreCompleto") = usuarioPersonal.NombrePersonalCompleto
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Session.Contents.RemoveAll()
    End Sub
End Class