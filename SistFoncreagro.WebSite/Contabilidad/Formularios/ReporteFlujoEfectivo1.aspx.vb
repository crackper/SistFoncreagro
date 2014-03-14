Imports SistFoncreagro.Report
Public Class ReporteFlujoEfectivo1
    Inherits System.Web.UI.Page
    Dim Fecha As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        Me.ReportViewer1.Report = New RepFlujoEfectivo1
        Me.ReportViewer1.Report.ReportParameters(0).Value = Fecha
    End Sub

End Class