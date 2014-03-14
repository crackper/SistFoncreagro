Imports System.Collections.Generic
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic

Public Class RegTipoCambio
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub RadGrid1_EditCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.EditCommand
        Dim id As String
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        e.Canceled = True
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdTipoCambio")
        Response.Redirect("~\Contabilidad\Formularios\FrmTipoCambio.aspx?IdTipoCambio=" + id.ToString + "&ventana=1")
        'MsgBox(id)
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
        If e.CommandName = "InitInsert" Then
            e.Canceled = True
            Response.Redirect("~/Contabilidad/Formularios/FrmTipoCambio.aspx?IdTipoCambio=0&ventana=1")
        End If
    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim id As Int32
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdTipoCambio")
        TipoCambioBL.DeleteTIPOCAMBIO(id)
    End Sub
    Public Function NomMes(ByVal id As Int32) As String
        Dim Nombre As String = ""
        Select Case id
            Case 1
                Nombre = "Enero"
            Case 2
                Nombre = "Febrero"
            Case 3
                Nombre = "Marzo"
            Case 4
                Nombre = "Abril"
            Case 5
                Nombre = "Mayo"
            Case 6
                Nombre = "Junio"
            Case 7
                Nombre = "Julio"
            Case 8
                Nombre = "Agosto"
            Case 9
                Nombre = "Setiembre"
            Case 10
                Nombre = "Octubre"
            Case 11
                Nombre = "Noviembre"
            Case 12
                Nombre = "Diciembre"
        End Select
        Return Nombre
    End Function
End Class