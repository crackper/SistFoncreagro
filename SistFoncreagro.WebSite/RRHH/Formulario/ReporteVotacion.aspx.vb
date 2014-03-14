Imports SistFoncreagro.Report
Public Class ReporteVotacion
    Inherits System.Web.UI.Page
    Dim IdEncuesta As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdEncuesta = Me.Request.QueryString("IdEncuesta")

        Me.ReportViewer1.Report = New RepVotacion
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdEncuesta
    End Sub

End Class