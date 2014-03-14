Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmPonderacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnCerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCerrar.Click
        Response.Redirect("~\Monitoreo\Formularios\Defecto.aspx")
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscar.Click
        Panel1.Visible = True
        BtnBuscar.Visible = False
    End Sub

    Protected Sub BtnOcultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOcultar.Click
        Panel1.Visible = False
        BtnBuscar.Visible = True
    End Sub

    Protected Sub RGProyecto_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGProyecto.ItemCommand
        If e.CommandName = "Select" Then
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim miId As String
            miId = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdProyAct")
            HFIdProyecto.Value = miId
            LblProyecto.Text = Me.RGProyecto.Items(editeditem.ItemIndex)("Nombre").Text
            Panel1.Visible = False
            BtnBuscar.Visible = True
        End If
    End Sub
End Class