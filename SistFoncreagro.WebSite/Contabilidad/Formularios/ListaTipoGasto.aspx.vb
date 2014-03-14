Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Collections
Imports System.Configuration
Imports System
Imports System.Web.UI
Public Class ListaTipoGasto
    Inherits System.Web.UI.Page
    Dim _TipoGasto As New TipoGasto
    Dim TipogastoBL As New TipoGastoBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _TipoGasto.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _TipoGasto.IdPlan = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        TipogastoBL.SaveTIPOGASTO(_TipoGasto)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
      
        _TipoGasto.IdTipoGasto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdTipoGasto")
        _TipoGasto.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _TipoGasto.IdPlan = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        TipogastoBL.SaveTIPOGASTO(_TipoGasto)
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub
End Class