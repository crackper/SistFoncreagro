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
Public Class ListaBancos
    Inherits System.Web.UI.Page
    Dim BancoBL As New BancoBL
    Dim _Banco As New Banco

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
        Dim Id As String = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdBanco")

        _Banco.Contacto = CType(e.Item.FindControl("TextBox6"), TextBox).Text
        _Banco.Direccion = CType(e.Item.FindControl("TextBox2"), TextBox).Text
        _Banco.IdBanco = Id
        _Banco.Nombre = CType(e.Item.FindControl("TextBox1"), TextBox).Text
        _Banco.Telefono1 = CType(e.Item.FindControl("TextBox3"), TextBox).Text
        _Banco.Telefono2 = CType(e.Item.FindControl("TextBox4"), TextBox).Text
        _Banco.Telefono3 = CType(e.Item.FindControl("TextBox5"), TextBox).Text
        BancoBL.SaveBanco(_Banco)
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
       
        _Banco.Contacto = CType(e.Item.FindControl("TextBox6"), TextBox).Text
        _Banco.Direccion = CType(e.Item.FindControl("TextBox2"), TextBox).Text
        _Banco.Nombre = CType(e.Item.FindControl("TextBox1"), TextBox).Text
        _Banco.Telefono1 = CType(e.Item.FindControl("TextBox3"), TextBox).Text
        _Banco.Telefono2 = CType(e.Item.FindControl("TextBox4"), TextBox).Text
        _Banco.Telefono3 = CType(e.Item.FindControl("TextBox5"), TextBox).Text
        BancoBL.SaveBanco(_Banco)
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub
End Class