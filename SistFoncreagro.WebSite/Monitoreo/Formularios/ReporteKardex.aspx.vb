Imports SistFoncreagro.Report
Public Class ReporteKardex
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Dim Proyecto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Request.QueryString("IdProyecto")
        Proyecto = Request.QueryString("proyecto")
        Me.ReportViewer1.Report = New Repkardex
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(1).Value = Proyecto
    End Sub

End Class