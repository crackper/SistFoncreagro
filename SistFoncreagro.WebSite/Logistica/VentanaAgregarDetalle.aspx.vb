Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class VentanaAgregarDetalle1
    Inherits System.Web.UI.Page
    Dim detalleReporteCotizacion As DetalleReporteCotizacion
    Dim detalleReporteCotizacionBl As New DetalleReporteCotizacionBL

    Protected Sub lbAgregarTexto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregarTexto.Click
        detalleReporteCotizacion = New DetalleReporteCotizacion
        detalleReporteCotizacion.Texto = txtTexto.Text
        detalleReporteCotizacion.IdCotizacion = CInt(Request.QueryString("IdCotizacion"))
        detalleReporteCotizacionBl.SaveDetalleReporteCotizacion(detalleReporteCotizacion)
        gvDetalleCotizacion.DataBind()
    End Sub

    Protected Sub gvDetalleCotizacion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvDetalleCotizacion.RowCommand
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim txtIdDetalleReporteCotizacion As TextBox = CType(gvDetalleCotizacion.Rows(index).FindControl("txtIdDetalleReporteCotizacion"), TextBox)
            Dim labelId As Label = CType(gvDetalleCotizacion.Rows(index).FindControl("Label1"), Label)
            detalleReporteCotizacionBl.DeleteDetalleReporteCotizacion(CInt(txtIdDetalleReporteCotizacion.Text))
            gvDetalleCotizacion.DataBind()
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Request.QueryString("tip") = 4 Then
                lblNombre.Text = "Justificación :"
            End If
            If Request.QueryString("Edit") = 1 Then
                lbAgregarTexto.Visible = False
            End If
        End If
    End Sub
End Class