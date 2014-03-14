Public Class Dialog6
    Inherits System.Web.UI.Page
    Dim IdControl As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdControl = Request.QueryString("IdControl")
    End Sub

End Class