Imports SistFoncreagro.BussinesLogic
Imports System.Collections.Generic
Imports Telerik.Web.UI
Public Class ListaCuentasCierre
    Inherits System.Web.UI.Page
    Dim CierreContableBL As New CierreContableBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Delete" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            ID = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCierre")
            CierreContableBL.DeleteCIERRECONTABLE(ID)
            Me.RadGrid1.DataBind()
        ElseIf e.CommandName = "InitInsert" Then
            e.Canceled = True
            Response.Redirect("FrmCuentasCierre.aspx")
        ElseIf e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub

    Protected Sub RadGrid1_EditCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.EditCommand
        Dim id As String
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCierre")
        e.Canceled = True

        Response.Redirect("FrmCuentasCierre.aspx?IdCierre=" + id.ToString)
    End Sub
End Class