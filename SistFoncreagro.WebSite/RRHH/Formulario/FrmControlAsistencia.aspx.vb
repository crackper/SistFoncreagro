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
Public Class FrmControlAsistencia
    Inherits System.Web.UI.Page
    Dim ControlAsistenciaBL As New ControlAsistenciaBL
    Dim _ControlAsistencia As New ControlAsistencia
    Dim ControlAsistencia As ControlAsistencia
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Now
        End If
    End Sub
    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim condicion As String = "T"
        If e.CommandName = "Grabar" Then
            _ControlAsistencia.IdControlAsistencia = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdControlAsistencia")
            _ControlAsistencia.IdPeriodoLaboral = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdPeriodoLaboral")
            _ControlAsistencia.IdResponsableControl = Session("IdUser")
            _ControlAsistencia.HoraIngresoReal = CType(Me.RadGrid2.Items(editedItem.ItemIndex).FindControl("TextBox1"), TextBox).Text
            _ControlAsistencia.HoraSalidaReal = CType(Me.RadGrid2.Items(editedItem.ItemIndex).FindControl("TextBox2"), TextBox).Text

            If CType(Me.RadGrid2.Items(editedItem.ItemIndex).FindControl("CheckBox1"), CheckBox).Checked Then
                condicion = "F"
            End If
            _ControlAsistencia.CondicionReal = condicion
            _ControlAsistencia.Observacion = CType(Me.RadGrid2.Items(editedItem.ItemIndex).FindControl("TextBox3"), TextBox).Text
            ControlAsistenciaBL.UpdateCONTROLASISTENCIA(_ControlAsistencia)
        End If
    End Sub
End Class