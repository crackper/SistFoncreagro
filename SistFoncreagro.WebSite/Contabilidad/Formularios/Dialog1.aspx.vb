Public Class Dialog1
    Inherits System.Web.UI.Page
    Dim idOCxFactura As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        idOCxFactura = Request.QueryString("idOCxFactura")
    End Sub

End Class