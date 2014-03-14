Imports SistFoncreagro.Report
Public Class ReporteNotasFlujoEfectivo
    Inherits System.Web.UI.Page
    Dim FechaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaFin = Request.QueryString("FechaFin")
        Me.ReportViewer1.Report = New RepNotasFlujoEfectivo
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaFin
    End Sub

End Class