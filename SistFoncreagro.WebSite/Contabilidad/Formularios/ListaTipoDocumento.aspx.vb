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
Public Class ListaTipoDocumento
    Inherits System.Web.UI.Page
    Dim TipoDocumentoBL As New TipoDocumentoBL
    Dim _TipoDocumento As New TipoDocumento
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _TipoDocumento.Codigo = CType(e.Item.FindControl("TextBox1"), TextBox).Text
        _TipoDocumento.Nombre = CType(e.Item.FindControl("TextBox2"), TextBox).Text
        _TipoDocumento.SujetoRetencion = CType(e.Item.FindControl("DropDownList1"), DropDownList).SelectedValue
        TipoDocumentoBL.SaveTIPODOCUMENTO(_TipoDocumento)
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            Dim Id As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTipoDocumento").ToString
            TipoDocumentoBL.UpdateEstadoTIPODOCUMENTO(Id)
            Me.RadGrid1.DataBind()
        ElseIf e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim Id As String = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdTipoDocumento")

        _TipoDocumento.Nombre = CType(e.Item.FindControl("TextBox2"), TextBox).Text
        _TipoDocumento.SujetoRetencion = CType(e.Item.FindControl("DropDownList1"), DropDownList).SelectedValue
        _TipoDocumento.IdTipoDocumento = Id
        TipoDocumentoBL.SaveTIPODOCUMENTO(_TipoDocumento)
        Me.RadGrid1.DataBind()
    End Sub
End Class
