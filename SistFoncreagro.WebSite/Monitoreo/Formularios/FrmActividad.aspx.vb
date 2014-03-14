Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration

Public Class FrmActividad
    Inherits System.Web.UI.Page

    Dim _ActividadBL As New ActividadBL
    Dim _Actividad As New Actividad

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
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdActividad")
        miError = _ActividadBL.DeleteActividad(miId)
        If miError <> "" Then
            RadWindowManager1.RadAlert(miError, 300, 120, "ERROR", "")
        End If
    End Sub

    Private Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim mUserControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim Cad As String = CType(mUserControl.FindControl("TxtIdActividad"), TextBox).Text
        Dim idActividad As Int32
        If Cad <> "" Then _Actividad.IdActividad = CInt(Cad)
        '_Actividad.Codigo = UCase(CType(mUserControl.FindControl("TxtCodigo"), TextBox).Text)
        _Actividad.Nombre = UCase(CType(mUserControl.FindControl("txtNombre"), TextBox).Text)
        _Actividad.Descripcion = UCase(CType(mUserControl.FindControl("txtDesc"), TextBox).Text)
        idActividad = _ActividadBL.SaveActividad(_Actividad)

        Dim cadena_java As String
        If Request.QueryString("IdProyecto") > 0 Then
            cadena_java = "<script type='text/javascript'> " & _
                              " CerrarVentana(" & Convert.ToString(idActividad) & "); " & _
                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)


        _Actividad.IdActividad = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdActividad")

        '_Actividad.Codigo = UCase(CType(userControl.FindControl("Txtcodigo"), TextBox).Text)
        _Actividad.Nombre = UCase(CType(userControl.FindControl("TxtNombre"), TextBox).Text)
        _Actividad.Descripcion = UCase(CType(userControl.FindControl("TxtDesc"), TextBox).Text)

        _ActividadBL.SaveActividad(_Actividad)
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("~\Monitoreo\Formularios\Defecto.aspx")
    End Sub
End Class