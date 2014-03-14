Imports SistFoncreagro.BussinesLogic
Public Class VentanaEnviarOrdenCompra
    Inherits System.Web.UI.Page

    Dim _ordenCompra As IOrdenCompraBL

    Protected Sub imGuardarDatos_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imGuardarDatos.Click
        _ordenCompra = New OrdenCompraBL
        _ordenCompra.UpdateOcEnviarProveedor(CInt(Me.Request.QueryString("id")), cmbLugarEntrega.SelectedValue, dpFechaLlegada.SelectedDate)
        Dim cadenaJava As String
        cadenaJava = "<script type='text/javascript'> " & _
                      " CerrarVentana(1); " & _
                      Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadenaJava.ToString, False)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        txtNroOrdenCOmpra.Text = Me.Request.QueryString("nro")
    End Sub
End Class