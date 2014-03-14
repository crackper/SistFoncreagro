Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class Register
    Inherits System.Web.UI.Page
    Dim userBl As New UsuarioBL
    Dim userEntity As New Usuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RegisterUser.ContinueDestinationPageUrl = Request.QueryString("ReturnUrl")
    End Sub

    Protected Sub RegisterUser_CreatedUser(ByVal sender As Object, ByVal e As EventArgs) Handles RegisterUser.CreatedUser
        FormsAuthentication.SetAuthCookie(RegisterUser.UserName, False)
        Dim continueUrl As String = RegisterUser.ContinueDestinationPageUrl
        If String.IsNullOrEmpty(continueUrl) Then
            continueUrl = "~/"
        End If
        Dim ddlPersonal As DropDownList = CType(Me.RegisterUser.CreateUserStep.ContentTemplateContainer.FindControl("ddlPersonal"), DropDownList)
        userEntity.IdUsuario = ddlPersonal.SelectedValue
        userEntity.NombreUsuario = RegisterUser.UserName
        userBl.ActualizarUsuarioRegistrado(userEntity)
        'Response.Redirect(continueUrl)
        Response.Redirect("FrmListaUsuarios.aspx")
    End Sub
End Class