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
Public Class ListaDocumentoConta
    Inherits System.Web.UI.Page
    Dim DocumentoContaBL As New DocumentoContabilizadoBL
    Dim _DocumentoConta As New DocumentoContabilizado
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            Dim Id As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdDocumentoCont").ToString
            DocumentoContaBL.UpdateEstadoDOCUMENTOCONTABILIZADO(Id)
            Me.RadGrid1.DataBind()
        ElseIf e.CommandName = "InitInsert" Then
            e.Canceled = True
            Response.Redirect("FrmDocumentoConta.aspx")
        ElseIf e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand

    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand

    End Sub

    Protected Sub RadGrid1_EditCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.EditCommand
        Dim id As String
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDocumentoCont")
        
        e.Canceled = True
        Response.Redirect("~\Contabilidad\Formularios\FrmDocumentoConta.aspx?IdDocumentoCont=" + id.ToString)
    End Sub
End Class