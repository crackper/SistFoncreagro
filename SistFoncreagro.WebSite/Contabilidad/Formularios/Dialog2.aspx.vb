Public Class Dialog2
    Inherits System.Web.UI.Page
    Dim IdVenta As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdVenta = Request.QueryString("IdVenta")
    End Sub

End Class