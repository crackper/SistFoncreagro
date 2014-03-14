Public Class VentanaCentroCostoxDetalleOrden
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = Request.QueryString("Producto")
    End Sub

End Class