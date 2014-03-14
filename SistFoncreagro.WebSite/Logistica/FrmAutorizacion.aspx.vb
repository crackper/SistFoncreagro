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
Public Class FrmAutorizacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            Me.RadGrid2.Rebind()
        End If
    End Sub

    Protected Sub RadGrid2_ItemCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        Dim cadena_java As String
        If e.CommandName = "Edit" Then
            e.Canceled = True
            Dim IdPermisoUsuario As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdPermisoUsuario").ToString
            Dim Nombre As String = (CType(e.Item, GridDataItem)).OwnerTableView.Items(e.Item.ItemIndex)("ApellidosNombres").Text
            Dim IdPersonal As String = (CType(e.Item, GridDataItem)).OwnerTableView.Items(e.Item.ItemIndex)("IdPersonal").Text

            cadena_java = "<script type='text/javascript'> " & _
                                            " radopen('VentanaAutorizacion.aspx?Nombre=" + Nombre.ToString + "&IdPersonal=" + IdPersonal.ToString + "&IdPermisoUsuario=" + IdPermisoUsuario.ToString + "','Ventana'); " & _
                                            Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub
  
End Class