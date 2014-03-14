Imports SistFoncreagro.Report
Public Class ReporteMovCuentas
    Inherits System.Web.UI.Page
    Dim Fecha As String
    Dim idProyecto As String
    Dim CuentaInicio As String
    Dim CuentaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        idProyecto = Request.QueryString("idProyecto")
        CuentaInicio = Request.QueryString("CuentaInicio")
        CuentaFin = Request.QueryString("CuentaFin")

        Me.ReportViewer1.Report = New RepMovCuentas
        Me.ReportViewer1.Report.ReportParameters(0).Value = Fecha
        Me.ReportViewer1.Report.ReportParameters(1).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(2).Value = CuentaInicio
        Me.ReportViewer1.Report.ReportParameters(3).Value = CuentaFin
    End Sub

End Class