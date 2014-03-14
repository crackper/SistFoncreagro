Imports SistFoncreagro.Report
Public Class ReporteResumenBeneficiariosActividad
    Inherits System.Web.UI.Page

    Dim FechaInicio As String
    Dim FechaFin As String
    Dim IdActividad As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaInicio = Request.QueryString("FechaInicio")
        FechaFin = Request.QueryString("FechaFin")
        IdActividad = Request.QueryString("IdActividad")
        Me.ReportViewer1.Report = New RepResumenBeneficiarios
        Me.ReportViewer1.Report.ReportParameters(0).Value = Session("IdProyecto")
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(2).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(3).Value = IdActividad
    End Sub

End Class