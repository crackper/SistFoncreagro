Imports SistFoncreagro.Report
Public Class VentanaReporteSoulSource
    Inherits System.Web.UI.Page
    Dim reporte As New ReportSoulSource
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ReportViewer1.Report = reporte
        Me.ReportViewer1.Report.ReportParameters(0).Value = Request.QueryString("IdCoti")
    End Sub
End Class