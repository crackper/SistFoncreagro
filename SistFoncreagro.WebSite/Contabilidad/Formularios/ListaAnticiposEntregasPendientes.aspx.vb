Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ListaAnticiposEntregasPendientes
    Inherits System.Web.UI.Page
    Dim TransaccionBL As New TransaccionBL
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim IdTran As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTransaccion").ToString
        If e.CommandName = "Procesar" Then
            TransaccionBL.UpdateEstadoTRANSACCION(IdTran, "R")
            Response.Redirect("~\Contabilidad\Formularios\ListaAnticiposEntregasPendientes.aspx")
            End If
    End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.Items.Item(i)("procesar").Text = ""

            Next
        End If
    End Sub
End Class