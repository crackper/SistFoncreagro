Imports SistFoncreagro.Report
Public Class ReporteCCostoXProyecto
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Dim Proyecto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Me.Request.QueryString("IdProyecto")
        Proyecto = Request.QueryString("Proyecto")
        Me.ReportViewer1.Report = New RepCCostoXProyecto
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(1).Value = Proyecto
    End Sub

End Class