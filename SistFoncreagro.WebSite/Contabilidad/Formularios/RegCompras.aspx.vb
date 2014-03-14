Imports SistFoncreagro.Report
Public Class RegCompras
    Inherits System.Web.UI.Page
    Dim fechaIni As String
    Dim fechaFin As String
    Dim moneda As String
    Dim idProyecto As String
    Dim idProveedorCliente As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fechaIni = Me.Request.QueryString("fechaIni")
        fechaFin = Me.Request.QueryString("fechaFin")
        moneda = Me.Request.QueryString("moneda")
        idProyecto = Me.Request.QueryString("idProyecto")
        idProveedorCliente = Me.Request.QueryString("idProveedorCliente")

        Me.ReportViewer1.Report = New RegistroCompras
        Me.ReportViewer1.Report.ReportParameters(0).Value = fechaIni
        Me.ReportViewer1.Report.ReportParameters(1).Value = fechaFin
        Me.ReportViewer1.Report.ReportParameters(2).Value = moneda
        Me.ReportViewer1.Report.ReportParameters(3).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(4).Value = idProveedorCliente
    End Sub

End Class