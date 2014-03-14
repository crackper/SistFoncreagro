Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class Dialog5
    Inherits System.Web.UI.Page

    Dim IdDetalleEje As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdDetalleEje = Request.QueryString("IdDetalleEje")
    End Sub

End Class