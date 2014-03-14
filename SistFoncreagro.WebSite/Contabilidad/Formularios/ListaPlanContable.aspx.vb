Imports System.Collections.Generic
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Public Class ListaPlanContable
    Inherits System.Web.UI.Page
    Dim PlanContableBL As New PlanContableBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim id As String
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        ElseIf e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdPlan")
            PlanContableBL.UpdateEstadoPLANCONTABLE(id)
            Me.RadGrid1.DataBind()
        ElseIf e.CommandName = "InitInsert" Then
            e.Canceled = True
            Response.Redirect("FrmPlanContable.aspx")
        End If
    End Sub

    Protected Sub RadGrid1_EditCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.EditCommand
        Dim id As String
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdPlan")
        e.Canceled = True
       
        Response.Redirect("~\Contabilidad\Formularios\FrmPlanContable.aspx?IdPlan=" + id.ToString)
          
    End Sub
End Class