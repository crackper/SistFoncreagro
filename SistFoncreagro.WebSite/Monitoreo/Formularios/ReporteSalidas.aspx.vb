Imports SistFoncreagro.Report
Public Class ReporteSalidas
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Dim fechaInicio As String
    Dim fechaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Session("IdProyecto")
        fechaInicio = Request.QueryString("fechaInicio")
        fechaFin = Request.QueryString("fechaFin")
        Me.ReportViewer1.Report = New RepProgramacionActividades
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(1).Value = fechaInicio
        Me.ReportViewer1.Report.ReportParameters(2).Value = fechaFin
    End Sub

End Class