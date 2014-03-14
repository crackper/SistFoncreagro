Imports SistFoncreagro.Report
Public Class ReporteBalanceComprobacionXarea
    Inherits System.Web.UI.Page
    Dim Fecha As String
    Dim idProyecto As String
    Dim Tipo As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        idProyecto = Request.QueryString("idProyecto")
        Tipo = Request.QueryString("Tipo")
        Me.ReportViewer1.Report = New RepBalanceComprobacionXarea
        Me.ReportViewer1.Report.ReportParameters(0).Value = Fecha
        Me.ReportViewer1.Report.ReportParameters(1).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(2).Value = Tipo
        Me.ReportViewer1.ZoomPercent = 150
    End Sub

End Class