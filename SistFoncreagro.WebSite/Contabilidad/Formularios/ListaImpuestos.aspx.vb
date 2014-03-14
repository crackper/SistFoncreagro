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
Public Class ListaImpuestos
    Inherits System.Web.UI.Page
    Dim ParametrosBL As New ParametrosBL
    Dim _Parametros As New Parametros
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

        If CType(e.Item.FindControl("txtDate1"), TextBox).Text.Length > 0 Then
            _Parametros.FechaFin = CType(e.Item.FindControl("txtDate1"), TextBox).Text
        Else
            _Parametros.FechaFin.Equals(DBNull.Value)
        End If

        _Parametros.FechaInicio = CType(e.Item.FindControl("txtDate"), TextBox).Text

        If CType(e.Item.FindControl("RadNumericTextBox4"), RadNumericTextBox).Text <> "" Then
            _Parametros.MontoLimite = CType(e.Item.FindControl("RadNumericTextBox4"), RadNumericTextBox).Text
        Else
            _Parametros.MontoLimite.Equals(DBNull.Value)
        End If

        _Parametros.Nombre = CType(e.Item.FindControl("TextBox2"), TextBox).Text
        _Parametros.valor = CType(e.Item.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        ParametrosBL.SavePARAMETROS(_Parametros)
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        If CType(e.Item.FindControl("txtDate1"), TextBox).Text.Length > 0 Then
            _Parametros.FechaFin = CType(e.Item.FindControl("txtDate1"), TextBox).Text
        Else
            _Parametros.FechaFin.Equals(DBNull.Value)
        End If

        _Parametros.FechaInicio = CType(e.Item.FindControl("txtDate"), TextBox).Text

        If CType(e.Item.FindControl("RadNumericTextBox3"), RadNumericTextBox).Text <> "" Then
            _Parametros.MontoLimite = CType(e.Item.FindControl("RadNumericTextBox3"), RadNumericTextBox).Text
        Else
            _Parametros.MontoLimite.Equals(DBNull.Value)
        End If

        _Parametros.Nombre = CType(e.Item.FindControl("TextBox1"), TextBox).Text
        _Parametros.valor = CType(e.Item.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Parametros.IdParametro = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdParametro")
        ParametrosBL.SavePARAMETROS(_Parametros)
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            Dim Id As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdParametro").ToString
            ParametrosBL.UpdateEstadoPARAMETROS(Id)
            Me.RadGrid1.DataBind()
        ElseIf e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        For i = 0 To e.Item.OwnerTableView.Items.Count - 1
            If (e.Item.OwnerTableView.Items.Item(i)("Estado").Text = "Inactivo") Then
                e.Item.OwnerTableView.Items.Item(i)("Editar").Enabled = False
                e.Item.OwnerTableView.Items.Item(i)("Anular").Enabled = False
                e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
            End If
        Next
    End Sub
End Class