Imports System.Collections.Generic
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ListaRendiciones
    Inherits System.Web.UI.Page
    Dim RendicionBL As New RendicionBL
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim idRendicion As Int32
        Dim estadoMes As String = ""
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))

        If e.CommandName = "InitInsert" Then
            e.Canceled = True
            Response.Redirect("~\Contabilidad\Formularios\FrmRendicion.aspx?IdRendicion=0")
            e.Canceled = True
        ElseIf e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            idRendicion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRendicion")
            RendicionBL.UpdateEstadoRENDICION(idRendicion, "A")
            Me.RadGrid1.DataBind()
        End If
    End Sub

    Protected Sub RadGrid1_EditCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.EditCommand
        Dim idRendicion As Int32
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        idRendicion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRendicion")

        e.Canceled = True

        Response.Redirect("~\Contabilidad\Formularios\FrmRendicion.aspx?IdRendicion=" + idRendicion.ToString)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim idRendicion As Int32
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        idRendicion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRendicion")
        RendicionBL.DeleteRENDICION(idRendicion)
    End Sub
    Public Function Color(ByVal Estado As String) As Drawing.Color
        Dim col As Drawing.Color
        Select Case Estado
            Case "Pendiente"
                col = Drawing.Color.Red
            Case "Para Aprobacion"
                col = Drawing.Color.Green
            Case "Aprobado"
                col = Drawing.Color.Blue
            Case "Observado"
                col = Drawing.Color.Orange
            Case "Anulado"
                col = Drawing.Color.Gray
        End Select

        Return col
    End Function

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.Items.Item(i)("eliminar").Enabled = False
                Me.RadGrid1.Items.Item(i)("anular").Enabled = False
                e.Item.OwnerTableView.Items.Item(i)("eliminar").BackColor = Drawing.Color.Gray
                e.Item.OwnerTableView.Items.Item(i)("anular").BackColor = Drawing.Color.Gray
            Next
        Else
            For i = 0 To Me.RadGrid1.Items.Count - 1
                If (CType(Me.RadGrid1.Items(i).FindControl("Label1"), Label).Text = "Para Aprobacion") Then
                    Me.RadGrid1.Items.Item(i)("editar").Enabled = False
                    Me.RadGrid1.Items.Item(i)("eliminar").Enabled = False
                    Me.RadGrid1.Items.Item(i)("anular").Enabled = False
                ElseIf (CType(Me.RadGrid1.Items(i).FindControl("Label1"), Label).Text = "Observado") Then
                    Me.RadGrid1.Items.Item(i)("editar").Enabled = True
                    Me.RadGrid1.Items.Item(i)("eliminar").Enabled = False
                    Me.RadGrid1.Items.Item(i)("anular").Enabled = False
                End If
            Next
        End If
    End Sub
End Class