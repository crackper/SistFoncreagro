Imports SistFoncreagro.Report
Public Class ReporteMuebles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ReportViewer1.Report = New RepBienesMuebles
    End Sub

End Class