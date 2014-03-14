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
Public Class ListaSubdiarios
    Inherits System.Web.UI.Page
    Dim SubDiarioBL As New SubdiarioBL
    Dim _SubDiario As New Subdiario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _SubDiario.Descripcion = CType(e.Item.FindControl("TextBox1"), TextBox).Text
        _SubDiario.IdSubDiario = CType(e.Item.FindControl("Label3"), Label).Text
        _SubDiario.IdTipoProceso = CType(e.Item.FindControl("DropDownList1"), DropDownList).SelectedValue
        _SubDiario.IdOpFinanciera = CType(e.Item.FindControl("DropDownList2"), DropDownList).SelectedValue
        SubDiarioBL.SaveSUBDIARIO(_SubDiario)
        Me.RadGrid1.DataBind()

    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _SubDiario.Descripcion = CType(e.Item.FindControl("TextBox1"), TextBox).Text
        _SubDiario.IdTipoProceso = CType(e.Item.FindControl("DropDownList1"), DropDownList).SelectedValue
        _SubDiario.IdOpFinanciera = CType(e.Item.FindControl("DropDownList2"), DropDownList).SelectedValue
        SubDiarioBL.SaveSUBDIARIO(_SubDiario)
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            Dim Id As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdSubDiario").ToString
            SubDiarioBL.UpdateEstadoSUBDIARIO(Id)
            Me.RadGrid1.DataBind()
        ElseIf e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub
    Function DescEstado(ByVal estado As String) As String
        If estado = "A" Then
            Return "Activo"
        Else
            Return "Inactivo"
        End If
    End Function
    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        For i = 0 To e.Item.OwnerTableView.Items.Count - 1
            If (CType(e.Item.OwnerTableView.Items(i).FindControl("Label7"), Label).Text = "Inactivo") Then
                e.Item.OwnerTableView.Items.Item(i)("Editar").Enabled = False
                e.Item.OwnerTableView.Items.Item(i)("Eliminar").Enabled = False
                e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
            End If
        Next
    End Sub
End Class