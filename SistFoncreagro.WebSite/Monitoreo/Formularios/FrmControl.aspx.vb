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
Public Class FrmControl
    Inherits System.Web.UI.Page
    Dim _Control As New Control
    Dim ControlBL As New ControlBL
    Dim Control As Control
    Dim IdControl As String
    Dim _ubigeo As UbigeoDatos
    Dim ubigeoBL As New UbigeoDatosBL
    Dim IdProyecto As String
    Dim _Vehiculo As New Vehiculo
    Dim VehiculoBL As New VehiculoBL
    Dim _Sustento As New Sustento
    Dim SustentoBL As New SustentoBL
    Dim _integrante As New Integrante
    Dim IntegranteBL As New IntegranteBL
    Dim _Insumos As New Insumos
    Dim AsistentesBL As New AsistenteBL
    Dim _Asistente As New Asistente
    Dim ActitudInteresadoBL As New ActitudInteresadoBL
    Dim _ActitudInteresado As New ActitudInteresado
    Dim InsumosBL As New InsumosBL
    Dim Total As Decimal
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdControl = Request.QueryString("IdControl")
        IdProyecto = Request.QueryString("IdProyecto")
        Me.RadComboBox1.Filter = 1
        If Page.IsPostBack = False Then
            Me.txtDate.Text = Date.Now

            If IdControl > 0 Then
                'para recuperar datos 
                Control = ControlBL.GetCONTROLByIdControl(IdControl)

                Me.RadComboBox6.DataSourceID = "SqlTareas"
                Me.SqlTareas.SelectParameters("IdProyecto").DefaultValue = IdProyecto
                Me.RadComboBox6.DataBind()

                If Control.IdTarea > 0 Then
                    Me.RadComboBox6.SelectedValue = "T" + Control.IdTarea.ToString + "-" + Control.IdSubActividad.ToString
                Else
                    Me.RadComboBox6.SelectedValue = "S" + Control.IdSubActividad.ToString
                End If

                Me.TextBox5.Text = Control.Descripcion
                Me.RadNumericTextBox2.Text = Control.Cantidad

                _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(Control.IdUbigeo)
                Me.RadComboBox1.DataSourceID = "OdsUbigeo"
                Me.OdsUbigeo.SelectParameters("texto").DefaultValue = _ubigeo.Nombre
                Me.RadComboBox1.DataBind()
                Me.RadComboBox1.SelectedValue = Control.IdUbigeo

                If Control.IdFamilia > 0 Then
                    Me.RadComboBox7.SelectedValue = Control.IdFamilia
                End If
                Me.txtDate.Text = Control.Fecha
                Me.TextBox8.Text = Control.ClimaSocial
                Me.DropDownList4.SelectedValue = Control.NivelApoyo
                Me.TextBox9.Text = Control.Quejas
                Me.TextBox10.Text = Control.AccionesTomadas
                Me.TextBox11.Text = Control.Observaciones
            End If
        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim Tipo As String
        Dim tamanio As Int32
        Dim subactividad As Int32
        Dim tarea As String

        _Control.AccionesTomadas = Me.TextBox10.Text
        _Control.Cantidad = Me.RadNumericTextBox2.Text
        _Control.ClimaSocial = Me.TextBox8.Text
        _Control.Descripcion = Me.TextBox5.Text
        _Control.Fecha = Me.txtDate.Text
        _Control.IdControl = IdControl
        If Me.RadComboBox7.Text.Length > 0 Then
            _Control.IdFamilia = Me.RadComboBox7.SelectedValue
        Else
            _Control.IdFamilia.Equals(DBNull.Value)
        End If

        Tipo = Me.RadComboBox6.SelectedValue.Substring(0, 1)
        If Tipo = "T" Then
            Dim j() As String
            j = Split(Me.RadComboBox6.SelectedValue, "-")

            subactividad = j(1)
            tarea = j(0)
            tamanio = Len(tarea)
            tarea = tarea.ToString.Substring(1, tamanio - 1)
            _Control.IdTarea = tarea
            _Control.IdSubActividad = subactividad
        Else
            tamanio = Len(Me.RadComboBox6.SelectedValue)
            subactividad = Me.RadComboBox6.SelectedValue.Substring(1, tamanio - 1)
            _Control.IdTarea.Equals(DBNull.Value)
            _Control.IdSubActividad = subactividad
        End If
        _Control.IdUbigeo = Me.RadComboBox1.SelectedValue
        _Control.IdUser = Session("IdUser")
        _Control.NivelApoyo = Me.DropDownList4.SelectedValue
        _Control.Observaciones = Me.TextBox11.Text
        _Control.Quejas = Me.TextBox9.Text

        If IdControl > 0 Then
            ControlBL.SaveCONTROL(_Control)
        Else
            IdControl = ControlBL.SaveCONTROL(_Control)
        End If
        Response.Redirect("FrmControl.aspx?IdControl=" + IdControl.ToString + "&IdProyecto=" + IdProyecto.ToString)

    End Sub
    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        'Dim Departamento As String
        Dim Provincia As String
        Dim Distrito As String
        Dim CPoblado As String
        Dim Caserio As String
        Dim Nivel As String

        'Departamento = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Departamento.ToString()
        Provincia = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Provincia.ToString()
        Distrito = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Distrito.ToString()
        CPoblado = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CentroPoblado.ToString()
        Caserio = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Caserio.ToString()
        Nivel = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Nivel.ToString()

        e.Item.Text = Provincia + "-" + Distrito + "-" + CPoblado + "-" + Caserio + " (" + Nivel + ")"
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CUBIGEO.ToString()
    End Sub

    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox1.DataSourceID = "OdsUbigeo"
            Me.OdsUbigeo.SelectParameters("texto").DefaultValue = e.Text.ToString
            Me.RadComboBox1.DataBind()
        End If
    End Sub

    Protected Sub RadGrid4_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Vehiculo.IdVehiculo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdVehiculo")

        _Vehiculo.IdDetalleEje = IdControl
        _Vehiculo.Marca = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Vehiculo.Modelo = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Vehiculo.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Vehiculo.Placa = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Vehiculo.Tipo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Vehiculo.Implementacion = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Mantenimiento = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Incidente = CType(userControl.FindControl("TextBox5"), TextBox).Text
        VehiculoBL.SaveVEHICULO(_Vehiculo)
    End Sub

    Protected Sub RadGrid4_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdVehiculo")
        VehiculoBL.DeleteVEHICULO(id)
    End Sub

    Protected Sub RadGrid4_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Vehiculo.IdDetalleEje = IdControl
        _Vehiculo.Marca = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Vehiculo.Modelo = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Vehiculo.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Vehiculo.Placa = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Vehiculo.Tipo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Vehiculo.Implementacion = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Mantenimiento = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Incidente = CType(userControl.FindControl("TextBox5"), TextBox).Text
        VehiculoBL.SaveVEHICULO(_Vehiculo)
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _integrante.IdEjecucion = IdControl
        If CType(userControl.FindControl("CheckBox2"), CheckBox).Checked Then
            _integrante.Conduce = "S"
        Else
            _integrante.Conduce = "N"
        End If
        _integrante.Documento = CType(userControl.FindControl("TextBox3"), TextBox).Text
        If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
            _integrante.EsResponsable = "S"
        Else
            _integrante.EsResponsable = "N"
        End If

        _integrante.IdPersonal = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue.Length > 0 Then
            _integrante.IdVehiculo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        End If

        _integrante.Observacion = CType(userControl.FindControl("TextBox5"), TextBox).Text

        IntegranteBL.SaveINTEGRANTE(_integrante)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _integrante.IdIntegrante = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdIntegrante")

        _integrante.IdEjecucion = IdControl
        If CType(userControl.FindControl("CheckBox2"), CheckBox).Checked Then
            _integrante.Conduce = "S"
        Else
            _integrante.Conduce = "N"
        End If
        _integrante.Documento = CType(userControl.FindControl("TextBox3"), TextBox).Text
        If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
            _integrante.EsResponsable = "S"
        Else
            _integrante.EsResponsable = "N"
        End If

        _integrante.IdPersonal = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue.Length > 0 Then
            _integrante.IdVehiculo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        End If
        _integrante.Observacion = CType(userControl.FindControl("TextBox5"), TextBox).Text

        IntegranteBL.SaveINTEGRANTE(_integrante)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdIntegrante")
        IntegranteBL.DeleteINTEGRANTE(id)
    End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Sustento.IdControl = IdControl
        _Sustento.Archivo = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Sustento.Descripcion = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Sustento.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Sustento.Nombre = CType(userControl.FindControl("TextBox1"), TextBox).Text


        SustentoBL.SaveSUSTENTO(_Sustento)
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdSustento")
        SustentoBL.DeleteSUSTENTO(id)
    End Sub

    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Sustento.IdSustento = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdSustento")

        _Sustento.IdControl = IdControl
        _Sustento.Archivo = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Sustento.Descripcion = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Sustento.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Sustento.Nombre = CType(userControl.FindControl("TextBox1"), TextBox).Text

        SustentoBL.SaveSUSTENTO(_Sustento)
    End Sub

    Protected Sub RadGrid3_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Insumos.IdControl = IdControl
        _Insumos.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Insumos.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Insumos.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Insumos.PrecioUnitario = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Insumos.Unidad = CType(userControl.FindControl("TextBox2"), TextBox).Text

        InsumosBL.SaveINSUMOS(_Insumos)
    End Sub

    Protected Sub RadGrid3_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Insumos.IdInsumo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInsumo")

        _Insumos.IdControl = IdControl
        _Insumos.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Insumos.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Insumos.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Insumos.PrecioUnitario = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Insumos.Unidad = CType(userControl.FindControl("TextBox2"), TextBox).Text

        InsumosBL.SaveINSUMOS(_Insumos)
    End Sub

    Protected Sub RadGrid3_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInsumo")
        InsumosBL.DeleteINSUMOS(id)
    End Sub

    Protected Sub RadGrid3_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid3.ItemDataBound

        If (TypeOf e.Item Is GridDataItem) Then
            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            Dim fieldValue As Decimal = Decimal.Parse(dataItem("Total").Text)
            Total = (Total + fieldValue)
        End If
        If (TypeOf e.Item Is GridFooterItem) Then
            Dim footerItem As GridFooterItem = CType(e.Item, GridFooterItem)
            footerItem("PrecioUnitario").Text = "TOTAL (S/.): "
            footerItem("Total").Text = Total.ToString()
        End If

    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmControl.aspx?IdControl=0" + "&IdProyecto=" + IdProyecto.ToString)
    End Sub

    Protected Sub RadTabStrip1_TabClick(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadTabStripEventArgs) Handles RadTabStrip1.TabClick
        If IdControl = 0 Then
            Dim cadena_java As String
            cadena_java = _
                                    "<script type='text/javascript'> " & _
                                    " alert('¡Debe Grabar la Información General!'); " & _
                                    Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub RadGrid5_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid5.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Asistente.IdControl = IdControl
        _Asistente.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _Asistente.Observaciones = ""
        AsistentesBL.SaveASISTENTE(_Asistente)

        _ActitudInteresado.Actitud = CType(userControl.FindControl("DropDownList4"), DropDownList).SelectedValue
        _ActitudInteresado.Comentario = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _ActitudInteresado.Dialogo = CType(userControl.FindControl("DropDownList6"), DropDownList).SelectedValue
        _ActitudInteresado.FechaInicio = Me.txtDate.Text
        _ActitudInteresado.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _ActitudInteresado.IdUsuario = Session("IdUser")
        _ActitudInteresado.PlanAccion = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _ActitudInteresado.Poder = CType(userControl.FindControl("DropDownList5"), DropDownList).SelectedValue
        ActitudInteresadoBL.SaveACTITUDINTERESADO(_ActitudInteresado)
    End Sub

    Protected Sub RadGrid5_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid5.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Asistente.IdAsistente = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAsistente")
        _Asistente.IdControl = IdControl
        _Asistente.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _Asistente.Observaciones = ""
        AsistentesBL.SaveASISTENTE(_Asistente)

        _ActitudInteresado.IdActitud = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdActitud")
        _ActitudInteresado.Actitud = CType(userControl.FindControl("DropDownList4"), DropDownList).SelectedValue
        _ActitudInteresado.Comentario = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _ActitudInteresado.Dialogo = CType(userControl.FindControl("DropDownList6"), DropDownList).SelectedValue
        _ActitudInteresado.FechaInicio = Me.txtDate.Text
        _ActitudInteresado.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _ActitudInteresado.IdUsuario = Session("IdUser")
        _ActitudInteresado.PlanAccion = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _ActitudInteresado.Poder = CType(userControl.FindControl("DropDownList5"), DropDownList).SelectedValue
        ActitudInteresadoBL.SaveACTITUDINTERESADO(_ActitudInteresado)

    End Sub

    Protected Sub RadGrid5_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid5.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id1 As Int32
        Dim id2 As Int32

        id1 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAsistente")
        id2 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdActitud")

        ActitudInteresadoBL.DeleteACTITUDINTERESADO(id2)
        AsistentesBL.DeleteASISTENTE(id1)
    End Sub
End Class