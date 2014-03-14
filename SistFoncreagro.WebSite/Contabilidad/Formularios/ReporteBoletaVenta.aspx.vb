Imports SistFoncreagro.Report
Public Class ReporteBoletaVenta
    Inherits System.Web.UI.Page
    Dim IdVenta As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdVenta = Me.Request.QueryString("IdVenta")

        Me.ReportViewer1.Report = New RepBoletaVenta
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdVenta
    End Sub

End Class