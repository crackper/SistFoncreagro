Imports SistFoncreagro.Report
Public Class VentanaReporteCurvaSporProyecto
    Inherits System.Web.UI.Page
    Dim fechaIni As String
    Dim fechaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fechaIni = Me.Request.QueryString("fechaIni")
        fechaFin = Me.Request.QueryString("fechaFin")
        Me.ReportViewer1.Report = New ReporteCurvaSporProyecto
        Me.ReportViewer1.Report.ReportParameters(0).Value = Request.QueryString("proyecto")
        Me.ReportViewer1.Report.ReportParameters(1).Value = Request.QueryString("componente")
        Me.ReportViewer1.Report.ReportParameters(2).Value = Request.QueryString("actividad")
        Me.ReportViewer1.Report.ReportParameters(3).Value = Request.QueryString("ccosto")
        Me.ReportViewer1.Report.ReportParameters(4).Value = Request.QueryString("moneda")
        Me.ReportViewer1.Report.ReportParameters(5).Value = CDate(fechaIni)
        Me.ReportViewer1.Report.ReportParameters(6).Value = CDate(fechaFin)
        Me.ReportViewer1.ZoomPercent = 100
    End Sub

End Class




