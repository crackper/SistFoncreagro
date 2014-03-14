Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Form1.Load
        If Not Me.Page.User.Identity.IsAuthenticated Then
            Response.Redirect("~/Login.aspx")
        Else
            If Len(Trim(Session("NombreCompleto"))) > 0 Then
                lblUsuario.Text = "USUARIO : " & Session("NombreCompleto")
            Else
                Response.Redirect("~/Login.aspx")
                'lblUsuario.Text = ""
            End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub
End Class