Imports SistFoncreagro.BussinesLogic
Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports System.Data.Common
Imports System.Collections.Generic
Public Class BalanceComprobacionGeneral
    Inherits System.Web.UI.Page
    Dim ProyectoBL As New ProyectoBL
    Dim Fecha As String
    Dim Proyecto As String
    Dim NomProyecto As String
    Dim NomMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        Proyecto = Request.QueryString("Proyecto")
        If Proyecto > 0 Then
            NomProyecto = " - PROYECTO: " + ProyectoBL.GetFromProyectoByIdProyecto(Proyecto).AreaProyecto
        Else
            NomProyecto = ""
        End If

        Me.Label3.Text = "BALANCE DE COMPROBACIÓN AL " + Fecha.ToString.Substring(0, 10) + NomProyecto.ToString
    End Sub
    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound

        If e.Item.ItemType = GridItemType.Item OrElse e.Item.ItemType = GridItemType.AlternatingItem Then
            Dim target As ImageButton = e.Item.FindControl("ImageButton1")
            If Not [Object].Equals(target, Nothing) Then
                Dim currentRow As DataRowView = DirectCast(e.Item.DataItem, DataRowView)
                Dim Cuenta As String = currentRow.Row("Codigo").ToString

                target.Attributes.Add("onClick", "Abrir('" & Fecha & "'," & Proyecto & ",'" & Cuenta & "'); return false;")
            End If
        End If

    End Sub
End Class