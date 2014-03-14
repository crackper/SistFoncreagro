Imports SistFoncreagro.Report
Public Class ReporteConciliacionBancaria
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
        Me.ReportViewer1.Report = New RepConciliacionBancaria
        Me.ReportViewer1.Report.ReportParameters(0).Value = Session("IdConciliacion")
    End Sub

End Class