Imports SistFoncreagro.Report
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class VentanaReporteSolicitarCotizacion
    Inherits System.Web.UI.Page
    Dim reporteSolicitud As ReportSolicitudCotizacion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rcmbLugar.Filter = 1
        rcmbLugar.SelectedValue = 3
    End Sub
    Protected Sub btnMostrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMostrar.Click
        reporteSolicitud = New ReportSolicitudCotizacion
        Me.ReportViewer1.Report = reporteSolicitud
        Me.ReportViewer1.Report.ReportParameters(0).Value = CInt(Request.QueryString("idReq"))
        Me.ReportViewer1.Report.ReportParameters(1).Value = rcmbLugar.Text
        Me.ReportViewer1.Report.ReportParameters(2).Value = txtPlazo.Text
    End Sub
End Class