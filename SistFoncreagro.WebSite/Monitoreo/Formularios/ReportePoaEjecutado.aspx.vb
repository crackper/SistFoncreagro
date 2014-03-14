Imports SistFoncreagro.Report
Public Class ReportePoaEjecutado
    Inherits System.Web.UI.Page

    Dim IdProyecto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Session("IdProyecto")
        If Page.IsPostBack = False Then
            Me.TextBox1.Text = Date.Now.Year
        End If
        Me.ReportViewer1.Report = New RepPoa
        Me.ReportViewer1.Report.ReportParameters(0).Value = Me.TextBox1.Text
        Me.ReportViewer1.Report.ReportParameters(1).Value = IdProyecto
    End Sub
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.ReportViewer1.Report = New RepPoa
        Me.ReportViewer1.Report.ReportParameters(0).Value = Me.TextBox1.Text
        Me.ReportViewer1.Report.ReportParameters(1).Value = IdProyecto
    End Sub
End Class