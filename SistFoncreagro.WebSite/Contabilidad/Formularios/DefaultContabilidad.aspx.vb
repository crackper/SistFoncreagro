Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class DefaultContabilidad
    Inherits System.Web.UI.Page
    Dim TransaccionBL As New TransaccionBL
    Dim IdSubDiario As Integer
    Dim Flag As String
    Dim EjercicioBL As New EjercicioBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
       
    End Sub

End Class