Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmListaStakeholders
    Inherits System.Web.UI.Page
    Dim InteressadosBL As New InteresadosBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub RadGrid4_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.ItemCommand
        Dim IdInteresado As String
        Dim cadena_java As String

        If e.CommandName = "Edit" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdInteresado = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInteresado")
            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                             " radopen('FrmStakeholders.aspx?IdProyecto=" + Session("IdProyecto").ToString + "&IdInteresado=" + IdInteresado + "','Formulario'); " & _
                                             Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "InitInsert" Then
            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                              " radopen('FrmStakeholders.aspx?IdProyecto=" + Session("IdProyecto").ToString + "&IdInteresado=0','Formulario'); " & _
                                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "Delete" Then
            Try
                Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
                IdInteresado = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInteresado")
                InteressadosBL.DeleteINTERESADOS(IdInteresado)

            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try
        End If

    End Sub
    Protected Sub RadGrid4_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        Try
            Dim ID As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdInteresado").ToString
            InteressadosBL.DeleteINTERESADOS(ID)

        Catch ex As Exception
            Dim cadena_java As String = _
                                           "<script type='text/javascript'> " & _
                                           " alert('¡No se puede Eliminar el Registro, primero elimine los detalles!'); " & _
                                           Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            e.Canceled = True
        End Try
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            Me.RadGrid4.Rebind()
        End If
    End Sub
End Class