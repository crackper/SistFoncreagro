Imports SistFoncreagro.Report
Public Class ReporteConsolidadoGastos
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Dim FechaInicio As String
    Dim FechaFin As String
    Dim IdSubdiario As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Request.QueryString("IdProyecto")
        FechaInicio = Request.QueryString("FechaInicio")
        FechaFin = Request.QueryString("FechaFin")
        IdSubdiario = Request.QueryString("IdSubdiario")
        Me.ReportViewer1.Report = New RepConsolidadoGastos
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(2).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(3).Value = IdSubdiario
    End Sub

End Class