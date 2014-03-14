Imports SistFoncreagro.Report
Public Class ReporteSemovientes
    Inherits System.Web.UI.Page
    Dim Tipo As String
    Dim Proyecto As String
    Dim Cpd As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tipo = Request.QueryString("Tipo")
        Proyecto = Request.QueryString("Proyecto")
        Cpd = Request.QueryString("Cpd")
        Me.ReportViewer1.Report = New RepSemovientes
        Me.ReportViewer1.Report.ReportParameters(0).Value = Proyecto
        Me.ReportViewer1.Report.ReportParameters(1).Value = Cpd
        Me.ReportViewer1.Report.ReportParameters(2).Value = Tipo
    End Sub

End Class