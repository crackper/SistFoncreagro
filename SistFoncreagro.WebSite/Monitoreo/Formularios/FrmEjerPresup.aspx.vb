Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration

Public Class FrmEjerPresup
    Inherits System.Web.UI.Page

    Public Function ValidarFecha(ByVal Valor As Date) As String
        Dim MisFunciones As New Funciones
        Dim miFecha As String = MisFunciones.CampoFecha(Valor)
        Return miFecha
    End Function

    Protected Sub BtnDefault_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnDefault.Click
        Response.Redirect("~\Monitoreo\Formularios\Defecto.aspx")
    End Sub

    Protected Sub RGPresup_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGPresup.InsertCommand
            Dim mUserControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
            Dim Cad As String = CType(mUserControl.FindControl("HFIdEjerPresup"), HiddenField).Value
            Dim _EjerPresup As New EjerPresup
            Dim _EjerPresupBL As New EjerPresupBL
        Dim miError As String
            If Cad <> "" Then _EjerPresup.IdEjerPresup = CInt(Cad)
            _EjerPresup.FechaInicio = DateValue(CType(mUserControl.FindControl("RDIni"), RadDatePicker).SelectedDate)
            _EjerPresup.FechaFin = DateValue(CType(mUserControl.FindControl("RDFin"), RadDatePicker).SelectedDate)
            _EjerPresup.Estado = UCase(CType(mUserControl.FindControl("CbEstado"), DropDownList).Text)
            _EjerPresup.Tipo = UCase(CType(mUserControl.FindControl("CbTipo"), DropDownList).Text)
            _EjerPresup.Anio = UCase(CType(mUserControl.FindControl("TxtAnio"), RadNumericTextBox).Text)
            Dim sMes As String
            sMes = CType(mUserControl.FindControl("CbMesIni"), DropDownList).Text
            _EjerPresup.MesIni = Numero_Mes(sMes)
        miError = _EjerPresupBL.SaveEjerPresup(_EjerPresup)
        If miError <> "" Then
            RadWindowManager1.RadAlert(miError, 200, 100, "Error", "")
        End If
    End Sub

    Public Function Numero_Mes(ByVal nomMes As String) As Int32
        Dim NumMes As Int32

        Select Case nomMes
            Case "Ene" : NumMes = 1
            Case "Feb" : NumMes = 2
            Case "Mar" : NumMes = 3
            Case "Abr" : NumMes = 4
            Case "Mayo" : NumMes = 5
            Case "Jun" : NumMes = 6
            Case "Jul" : NumMes = 7
            Case "Ago" : NumMes = 8
            Case "Sep" : NumMes = 9
            Case "Oct" : NumMes = 10
            Case "Nov" : NumMes = 11
            Case "Dic" : NumMes = 12
        End Select
        Return NumMes
    End Function

    Protected Sub RGPresup_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGPresup.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim _EjerPresup As New EjerPresup
        Dim _EjerPresupBL As New EjerPresupBL
        _EjerPresup.IdEjerPresup = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdEjerPresup")
        _EjerPresup.Estado = UCase(CType(userControl.FindControl("CbEstado"), DropDownList).Text)
        _EjerPresup.Tipo = UCase(CType(userControl.FindControl("CbTipo"), DropDownList).Text)
        _EjerPresup.FechaInicio = DateValue(CType(userControl.FindControl("RDIni"), RadDatePicker).SelectedDate)
        _EjerPresup.FechaFin = DateValue(CType(userControl.FindControl("RDFin"), RadDatePicker).SelectedDate)
        Dim miError As String
        miError = _EjerPresupBL.SaveEjerPresup(_EjerPresup)
        If miError <> "" Then
            RadWindowManager1.RadAlert(miError, 400, 100, "Error", "")
        End If
    End Sub

    Protected Sub RGPresup_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGPresup.DeleteCommand
        Dim EditedItem As GridEditableItem
        EditedItem = CType(e.Item, GridEditableItem)
        Dim miId As Int32
        miId = EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdEjerPresup")
        Dim _EjerPresupBL As New EjerPresupBL
        _EjerPresupBL.DeleteEjerPresup(miId)
    End Sub

    Protected Sub RGPresup_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGPresup.ItemCommand
        If e.CommandName = "InitInsert" Then
            Dim miError As String
            Dim _EjerPresupBL As New EjerPresupBL
            miError = _EjerPresupBL.EjerPresupEstado
            If miError <> "" Then
                RadWindowManager1.RadAlert(miError, 300, 100, "Error", "")
                e.Canceled = True
            End If
        End If
    End Sub
End Class