Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration

Public Class FrmComponentes1
    Inherits System.Web.UI.Page

    Dim _ComponenteBL As New ComponenteBL
    Dim _Componente As New Componente

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
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdComponente")
        miError = _ComponenteBL.DeleteComponente(miId)
        If miError <> "" Then
            RadWindowManager1.RadAlert(miError, 300, 120, "ERROR", "")
        End If
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim mUserControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim Cad As String = CType(mUserControl.FindControl("TxtIdComponente"), TextBox).Text
        Dim idComponente As Int32
        If Cad <> "" Then _Componente.IdComponente = CInt(Cad)
        '_Componente.Codigo = UCase(CType(mUserControl.FindControl("TxtCodigo"), TextBox).Text)
        _Componente.Nombre = UCase(CType(mUserControl.FindControl("txtNombre"), TextBox).Text)
        _Componente.Descripcion = UCase(CType(mUserControl.FindControl("txtDesc"), TextBox).Text)
        idComponente = _ComponenteBL.SaveComponente(_Componente)

        Dim cadena_java As String
        If Request.QueryString("IdProyecto") > 0 Then
            cadena_java = "<script type='text/javascript'> " & _
                              " CerrarVentana(" & Convert.ToString(idComponente) & "); " & _
                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)


        _Componente.IdComponente = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdComponente")

        '_Componente.Codigo = UCase(CType(userControl.FindControl("Txtcodigo"), TextBox).Text)
        _Componente.Nombre = UCase(CType(userControl.FindControl("TxtNombre"), TextBox).Text)
        _Componente.Descripcion = UCase(CType(userControl.FindControl("TxtDesc"), TextBox).Text)

        _ComponenteBL.SaveComponente(_Componente)
    End Sub
End Class