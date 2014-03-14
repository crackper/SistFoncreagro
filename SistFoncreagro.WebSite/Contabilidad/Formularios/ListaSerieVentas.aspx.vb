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
Public Class ListaSerieVentas
    Inherits System.Web.UI.Page
    Dim _Serie As New Serie
    Dim SerieBL As New SerieBL
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        If CType(userControl.FindControl("RadComboBox1"), RadComboBox).Text.Length > 0 Then
            _Serie.IdProyecto = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        Else
            _Serie.IdProyecto.Equals(DBNull.Value)
        End If
        _Serie.IdTipoDoumento = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Serie.IdUsuario = Session("IdUser")
        _Serie.Serie = CType(userControl.FindControl("TextBox1"), TextBox).Text
        SerieBL.SaveSERIE(_Serie)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        _Serie.IdSerie = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdSerie")
         If CType(userControl.FindControl("RadComboBox1"), RadComboBox).Text.Length > 0 Then
            _Serie.IdProyecto = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        Else
            _Serie.IdProyecto.Equals(DBNull.Value)
        End If
        _Serie.IdTipoDoumento = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Serie.IdUsuario = Session("IdUser")
        _Serie.Serie = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Serie.Actual = CType(userControl.FindControl("TextBox2"), TextBox).Text
        SerieBL.SaveSERIE(_Serie)
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        ElseIf e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdSerie = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdSerie")
            SerieBL.UpdateEstadoSERIE(IdSerie)
            Me.RadGrid1.Rebind()
        End If
    End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.Items.Item(i)("Editar").Text = ""
                Me.RadGrid1.Items.Item(i)("Anular").Text = ""
            Next
        Else
            For i = 0 To Me.RadGrid1.Items.Count - 1
                If Me.RadGrid1.Items.Item(i)("Estado").Text = "I" Then
                    Me.RadGrid1.Items.Item(i)("Editar").Enabled = False
                    Me.RadGrid1.Items.Item(i)("Anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
                End If
            Next
        End If
    End Sub
End Class