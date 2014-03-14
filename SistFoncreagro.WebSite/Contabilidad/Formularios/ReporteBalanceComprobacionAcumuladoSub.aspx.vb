Imports SistFoncreagro.Report
Public Class ReporteBalanceComprobacionAcumuladoSub
    Inherits System.Web.UI.Page
    Dim Fecha As String
    Dim idProyecto As String
    Dim IdMoneda As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        idProyecto = Request.QueryString("idProyecto")
        IdMoneda = Request.QueryString("idMoneda")
        Me.ReportViewer1.Report = New RepBalanceComprobacionAcumuladoNivelSubDivisionaria
        Me.ReportViewer1.Report.ReportParameters(0).Value = Fecha
        Me.ReportViewer1.Report.ReportParameters(1).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(2).Value = IdMoneda
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WebForms.ZoomMode.PageWidth
    End Sub

End Class