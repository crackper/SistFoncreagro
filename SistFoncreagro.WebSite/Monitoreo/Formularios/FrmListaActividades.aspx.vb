Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Data.OleDb
Public Class FrmListaActividades
    Inherits System.Web.UI.Page
    Dim Subactividad As SubActividad
    Dim _SubActividad As New SubActividad
    Dim SubActividadBL As New SubActividadBL
    Dim Tarea As Tarea
    Dim _Tarea As New Tarea
    Dim TareaBL As New TareaBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub RadAjaxManager1_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            Me.RadGrid3.Rebind()
        End If

        If e.Argument.StartsWith("Generar") Then
            Dim j() As String
            Dim valor As String
            j = Split(e.Argument, "|")

            valor = j(1)
            If valor = "true" Then
                SubActividadBL.GenerarPoaTecnico(Session("IdProyecto"))
                Me.RadGrid3.DataBind()
                Me.Button1.Visible = False
            End If
        End If
    End Sub
    Protected Sub RadGrid3_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid3.ItemDataBound
        If e.Item.OwnerTableView.Items.Count = 0 Then
            Me.Button1.Visible = True
        Else
            Me.Button1.Visible = False
        End If
        If "Tareas".Equals(e.Item.OwnerTableView.Name) Then
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.White
            Next
        Else
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.BurlyWood
            Next
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena_java As String = _
                                          "<script type='text/javascript'> " & _
                                        "function f(){radconfirm('¡Se Generará el POA Tecnico a partir de los C. Costo ingresados!', confirmCallBackFn, 330, 100, null, 'Mensaje de Confirmación'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);" & _
                                        Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
    End Sub

    Protected Sub RadGrid3_DeleteCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        If "Tareas".Equals(e.Item.OwnerTableView.Name) Then
            Try
                Dim ID As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTarea").ToString
                TareaBL.DeleteTAREA(ID)
                ' Me.RadGrid1.Rebind()
            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try
        Else
            Try
                Dim ID As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdSubActividad").ToString
                SubActividadBL.DeleteSubActividad(ID)
                ' Me.RadGrid1.Rebind()
            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try
        End If

    End Sub

    Protected Sub RadGrid3_InsertCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.InsertCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "Tareas".Equals(e.Item.OwnerTableView.Name) Then
            _Tarea.Codigo = CType(userControl.FindControl("TextBox1"), TextBox).Text
            If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
                _Tarea.FinalizaActividad = "S"
            Else
                _Tarea.FinalizaActividad = "N"
            End If
            _Tarea.IdSubActividad = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdSubActividad").ToString
           _Tarea.NomTarea = CType(userControl.FindControl("TextBox3"), TextBox).Text
            _Tarea.Porcentaje = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
            _Tarea.Unidad = CType(userControl.FindControl("TextBox2"), TextBox).Text
            TareaBL.SaveTAREA(_Tarea)
        Else
            _SubActividad.Codigo = CType(userControl.FindControl("TextBox1"), TextBox).Text
            _SubActividad.IdElemGasto = CType(userControl.FindControl("RadComboBox9"), RadComboBox).SelectedValue
            _SubActividad.IdProyAct = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
            _SubActividad.Porcentaje = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
            _SubActividad.Unidad = CType(userControl.FindControl("TextBox2"), TextBox).Text
            SubActividadBL.SaveSUBACTIVIDAD(_SubActividad)
        End If

    End Sub

    Protected Sub RadGrid3_UpdateCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "Tareas".Equals(e.Item.OwnerTableView.Name) Then
            _Tarea.Codigo = CType(userControl.FindControl("TextBox1"), TextBox).Text
            If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
                _Tarea.FinalizaActividad = "S"
            Else
                _Tarea.FinalizaActividad = "N"
            End If
            _Tarea.IdTarea = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdTarea")
            _Tarea.NomTarea = CType(userControl.FindControl("TextBox3"), TextBox).Text
            _Tarea.Porcentaje = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
            _Tarea.Unidad = CType(userControl.FindControl("TextBox2"), TextBox).Text
            TareaBL.SaveTAREA(_Tarea)
        Else

            _SubActividad.IdSubActividad = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdSubActividad")
            _SubActividad.Codigo = CType(userControl.FindControl("TextBox1"), TextBox).Text
            _SubActividad.IdElemGasto = CType(userControl.FindControl("RadComboBox9"), RadComboBox).SelectedValue
            _SubActividad.IdProyAct = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
            _SubActividad.Porcentaje = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
            _SubActividad.Unidad = CType(userControl.FindControl("TextBox2"), TextBox).Text
            SubActividadBL.SaveSUBACTIVIDAD(_SubActividad)
        End If
    End Sub
End Class
