Imports SistFoncreagro.Report
Public Class ReporteBalanceComprobacionAcumuladoDet
    Inherits System.Web.UI.Page
    Dim Fecha As String
    Dim idProyecto As String
    Dim idMoneda As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        idProyecto = Request.QueryString("idProyecto")
        idMoneda = Request.QueryString("idMoneda")
        Me.ReportViewer1.Report = New RepBalanceComprobacionAcumuladoNivelDetalle
        Me.ReportViewer1.Report.ReportParameters(0).Value = Fecha
        Me.ReportViewer1.Report.ReportParameters(1).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(2).Value = idMoneda
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WebForms.ZoomMode.PageWidth
    End Sub
End Class