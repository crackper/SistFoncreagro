Imports SistFoncreagro.Report
Public Class ReporteMueblesAreas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ReportViewer1.Report = New RepBienesMueblesArea
    End Sub

End Class