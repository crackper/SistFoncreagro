Imports SistFoncreagro.Report
Public Class ReporteBajaBienes
    Inherits System.Web.UI.Page
    Dim FechaInicio As String
    Dim FechaFin As String
    Dim Tipo As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaInicio = Me.Request.QueryString("FechaInicio")
        FechaFin = Me.Request.QueryString("FechaFin")
        Tipo = Request.QueryString("Tipo")

        Me.ReportViewer1.Report = New RepBajaBienes
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(2).Value = Tipo
    End Sub

End Class