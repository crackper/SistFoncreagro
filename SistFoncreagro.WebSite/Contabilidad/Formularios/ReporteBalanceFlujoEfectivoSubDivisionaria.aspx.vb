Imports SistFoncreagro.Report
Public Class ReporteBalanceFlujoEfectivo
    Inherits System.Web.UI.Page
    Dim Fecha As String
    Dim tipo As String
    Dim idMoneda As String
    Dim idProyecto As String
    Dim proyecto As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        tipo = Request.QueryString("tipo")
        idMoneda = Request.QueryString("idMoneda")
        idProyecto = Request.QueryString("idProyecto")
        proyecto = Request.QueryString("proyecto")

        Me.ReportViewer1.Report = New RepBalanceFlujoEfectivoSubDivisionaria
        Me.ReportViewer1.Report.ReportParameters(0).Value = Fecha
        Me.ReportViewer1.Report.ReportParameters(1).Value = tipo
        Me.ReportViewer1.Report.ReportParameters(2).Value = idMoneda
        Me.ReportViewer1.Report.ReportParameters(3).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(4).Value = proyecto
        Me.ReportViewer1.ZoomPercent = 110
    End Sub

End Class