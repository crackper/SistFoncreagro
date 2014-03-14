Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration

Public Class FrmElementoGasto
    Inherits System.Web.UI.Page

    Dim _ElemGastoBL As New ElementoGastoBL
    Dim _ElemGasto As New ElementoGasto

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            If Request.QueryString("IdProyecto") > 0 Then
                Me.RadGrid1.MasterTableView.InsertItem()
            End If
        End If

    End Sub

    Private Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim EditedItem As GridEditableItem
        EditedItem = CType(e.Item, GridEditableItem)
        Dim miError As String
        Dim miId As Int32
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdElemGasto")
        miError = _ElemGastoBL.DeleteElementoGasto(miId)
        If miError <> "" Then
            RadWindowManager1.RadAlert(miError, 300, 120, "ERROR", "")
        End If
    End Sub

    Private Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim mUserControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim Cad As String = CType(mUserControl.FindControl("TxtIdElemGasto"), TextBox).Text
        Dim idElem As Int32
        If Cad <> "" Then _ElemGasto.IdElemGasto = CInt(Cad)
        '_ElemGasto.CodElemGasto = UCase(CType(mUserControl.FindControl("TxtCodigo"), TextBox).Text)
        _ElemGasto.NomElemGasto = UCase(CType(mUserControl.FindControl("txtNombre"), TextBox).Text)
        _ElemGasto.DesElemGasto = UCase(CType(mUserControl.FindControl("txtDesc"), TextBox).Text)
        _ElemGasto.IdClasificacion = UCase(CType(mUserControl.FindControl("CbClasificacion"), RadComboBox).SelectedValue)
        idElem = _ElemGastoBL.SaveElementoGasto(_ElemGasto)

        Dim cadena_java As String
        If Request.QueryString("IdProyecto") > 0 Then
            cadena_java = "<script type='text/javascript'> " & _
                              " CerrarVentana(" & Convert.ToString(idElem) & "); " & _
                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _ElemGasto.IdElemGasto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdElemGasto")

        '_ElemGasto.CodElemGasto = UCase(CType(userControl.FindControl("Txtcodigo"), TextBox).Text)
        _ElemGasto.NomElemGasto = UCase(CType(userControl.FindControl("TxtNombre"), TextBox).Text)
        _ElemGasto.DesElemGasto = UCase(CType(userControl.FindControl("TxtDesc"), TextBox).Text)
        _ElemGasto.IdClasificacion = UCase(CType(userControl.FindControl("CbClasificacion"), RadComboBox).SelectedValue)
        _ElemGastoBL.SaveElementoGasto(_ElemGasto)
    End Sub
End Class