Imports SistFoncreagro.Report
Public Class ReporteMovSemoviente
    Inherits System.Web.UI.Page
    Dim FechaInicio As String
    Dim FechaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaInicio = Me.Request.QueryString("FechaInicio")
        FechaFin = Me.Request.QueryString("FechaFin")

        Me.ReportViewer1.Report = New RepMovSemovientes
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaFin
    End Sub

End Class