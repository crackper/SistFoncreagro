Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI
Public Class FrmDepreciacion
    Inherits System.Web.UI.Page
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Dim DepreciacionBL As New DepreciacionBL
    Dim _Depreciacion As New Depreciacion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.RadButton1.Visible = False
        Else
            Me.RadButton1.Visible = True
        End If

        If Page.IsPostBack = False Then
            Me.txtDate.Text = Session("Fecha").ToString
        End If

    End Sub

    Protected Sub RadGrid1_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.DataBound
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.MasterTableView.Items.Item(i)("editar").Text = ""
                Me.RadGrid1.MasterTableView.Items.Item(i)("eliminar").Text = ""
            Next
        End If
    End Sub
    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Depreciacion.IdDepreciacion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDepreciacion")
        _Depreciacion.MesesDepreciados = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        If CType(userControl.FindControl("HiddenField2"), HiddenField).Value.Length > 0 Then
            _Depreciacion.IdBienMueble = CType(userControl.FindControl("HiddenField2"), HiddenField).Value
        Else
            _Depreciacion.IdBienMueble.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("HiddenField3"), HiddenField).Value.Length > 0 Then
            _Depreciacion.IdBienInmueble = CType(userControl.FindControl("HiddenField3"), HiddenField).Value
        Else
            _Depreciacion.IdBienInmueble.Equals(DBNull.Value)
        End If
        _Depreciacion.IdUsuario = Session("IdUser")
        _Depreciacion.Porcentaje = CType(userControl.FindControl("HiddenField1"), HiddenField).Value
        _Depreciacion.DepreciacionAcumulada = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        DepreciacionBL.SaveDEPRECIACION(_Depreciacion)

    End Sub

    Protected Sub RadButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton1.Click
        DepreciacionBL.GenerarDepreciacion(Me.txtDate.Text, Session("IdUser"), Session("Anio"), Session("Mes"), Me.RadComboBox1.SelectedValue)
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim idDep As Int32

        idDep = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDepreciacion")
        DepreciacionBL.DeleteDEPRECIACION(idDep)
    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub
End Class