Imports SistFoncreagro.Report
Public Class ReporteDepreciacionActivo
    Inherits System.Web.UI.Page
    Dim fecha As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fecha = Request.QueryString("fecha")
        Me.ReportViewer1.Report = New RepDepreciacionActivo
        Me.ReportViewer1.Report.ReportParameters(0).Value = fecha
    End Sub

End Class