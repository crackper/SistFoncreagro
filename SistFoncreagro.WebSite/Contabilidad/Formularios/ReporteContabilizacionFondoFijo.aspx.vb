Imports SistFoncreagro.Report
Public Class ReporteContabilizacionFondoFijo
    Inherits System.Web.UI.Page
    Dim IdRendicion As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdRendicion = Request.QueryString("IdRendicion")
        Me.ReportViewer1.Report = New RepContabilizacionFondoFijo
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdRendicion
    End Sub

End Class