Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmSemovientes
    Inherits System.Web.UI.Page
    Dim _Semovientes As New Semovientes
    Dim Semovientes As Semovientes
    Dim SemovientesBL As New SemovientesBL
    Dim IdSemoviente As String
    Dim _ubigeo As UbigeoDatos
    Dim ubigeoBL As New UbigeoDatosBL
    Dim _Ubicacion As New UbicacionSemovientes
    Dim UbicacionBL As New UbicacionSemovientesBL
    Dim _Propiedad As New PropiedadSemovientes
    Dim PropiedadBL As New PropiedadSemovientesBL
    Dim _Adjuntos As New AdjuntoSemovientes
    Dim AdjuntoBL As New AdjuntoSemovientesBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdSemoviente = Request.QueryString("IdSemoviente")
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1
        Me.RadComboBox5.Filter = 1
        Me.RadComboBox6.Filter = 1

        If Page.IsPostBack = False Then
            If IdSemoviente > 0 Then
                'para recuperar datos
                Semovientes = SemovientesBL.GetSEMOVIENTESById(IdSemoviente)

                Me.RadComboBox1.SelectedValue = Semovientes.IdProyecto
                Me.RadComboBox2.SelectedValue = Semovientes.IdProyectoCPD
                Me.TextBox1.Text = Semovientes.Nombre
                Me.TextBox2.Text = Semovientes.Color
                Me.TextBox3.Text = Semovientes.AreteMicrochip
                Me.TextBox4.Text = Semovientes.AreteEstablo
                Me.txtDate.Text = Semovientes.FechaNacimiento
                Me.RadNumericTextBox1.Text = Semovientes.EdadMeses
                Me.DropDownList1.SelectedValue = Semovientes.idEspecie
                Me.DropDownList2.SelectedValue = Semovientes.IdRaza
                Me.RadioButtonList1.SelectedValue = Semovientes.Sexo
                Me.TextBox5.Text = Semovientes.DescSemoviente
                Me.RadioButtonList2.SelectedValue = Semovientes.TipoIngreso

                If Semovientes.IdOrigenSemoviente <> "" Then
                    _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(Semovientes.IdOrigenSemoviente)
                    Me.RadComboBox5.DataSourceID = "OdsUbigeo"
                    Me.OdsUbigeo.SelectParameters("texto").DefaultValue = _ubigeo.Nombre
                    Me.RadComboBox5.DataBind()
                    Me.RadComboBox5.SelectedValue = Semovientes.IdOrigenSemoviente
                End If

                If Semovientes.IdSemovientePadre > 0 Then
                    Me.RadComboBox3.SelectedValue = Semovientes.IdSemovientePadre
                End If

                If Semovientes.IdSemovienteMadre > 0 Then
                    Me.RadComboBox4.SelectedValue = Semovientes.IdSemovienteMadre
                End If

                If Semovientes.IdPlan > 0 Then
                    Me.RadComboBox6.SelectedValue = Semovientes.IdPlan
                End If


            End If

        End If
    End Sub

    Protected Sub txtDate_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDate.TextChanged
        Me.RadNumericTextBox1.Text = DateDiff(DateInterval.Month, Date.Parse(Me.txtDate.Text), Now)
    End Sub

    Protected Sub RadComboBox5_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox5.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Departamento.ToString() + " - " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Provincia.ToString() + " - " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Distrito.ToString() + " - " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Nombre.ToString() + " (" + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Nivel.ToString() + ")"
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CUBIGEO.ToString()
    End Sub

    Protected Sub RadComboBox5_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox5.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox5.DataSourceID = "OdsUbigeo"
            Me.OdsUbigeo.SelectParameters("texto").DefaultValue = e.Text.ToString
            Me.RadComboBox5.DataBind()
        End If
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmSemovientes.aspx?IdSemoviente=0")
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        _Semovientes.AreteEstablo = Me.TextBox4.Text
        _Semovientes.AreteMicrochip = Me.TextBox3.Text
        _Semovientes.Color = Me.TextBox2.Text
        _Semovientes.DescSemoviente = Me.TextBox5.Text
        _Semovientes.EdadMeses = Me.RadNumericTextBox1.Text
        _Semovientes.FechaNacimiento = Me.txtDate.Text
        _Semovientes.FechaRegistro = Date.Now
        If Me.RadComboBox5.SelectedValue.Length > 0 Then
            _Semovientes.IdOrigenSemoviente = Me.RadComboBox5.SelectedValue
        End If

        _Semovientes.IdPlan = Me.RadComboBox6.SelectedValue
        _Semovientes.IdProyecto = Me.RadComboBox1.SelectedValue
        _Semovientes.IdProyectoCPD = Me.RadComboBox2.SelectedValue
        _Semovientes.IdRaza = Me.DropDownList2.SelectedValue
        _Semovientes.IdSemoviente = IdSemoviente
        If Me.RadComboBox4.SelectedValue.Length > 0 Then
            _Semovientes.IdSemovienteMadre = Me.RadComboBox4.SelectedValue
        Else
            _Semovientes.IdSemovienteMadre.Equals(DBNull.Value)
        End If

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            _Semovientes.IdSemovientePadre = Me.RadComboBox3.SelectedValue
        Else
            _Semovientes.IdSemovientePadre.Equals(DBNull.Value)
        End If

        _Semovientes.Nombre = Me.TextBox1.Text
        _Semovientes.Sexo = Me.RadioButtonList1.SelectedValue
        _Semovientes.TipoIngreso = Me.RadioButtonList2.SelectedValue

        If IdSemoviente > 0 Then
            SemovientesBL.SaveSEMOVIENTES(_Semovientes)
        Else
            IdSemoviente = SemovientesBL.SaveSEMOVIENTES(_Semovientes)
        End If

        Response.Redirect("FrmSemovientes.aspx?IdSemoviente=" + IdSemoviente.ToString)

    End Sub

    Protected Sub RadioButtonList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList2.SelectedIndexChanged
        If Me.RadioButtonList2.SelectedValue = 2 Then
            Me.RadComboBox5.Enabled = True
            Me.RadComboBox3.Enabled = False
            Me.RadComboBox4.Enabled = False
        Else
            Me.RadComboBox5.Enabled = False
            Me.RadComboBox3.Enabled = True
            Me.RadComboBox4.Enabled = True
        End If
    End Sub

    Protected Sub RadioButtonList2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList2.TextChanged
        If Me.RadioButtonList2.SelectedValue = 2 Then
            Me.RadComboBox5.Enabled = True
            Me.RadComboBox3.Enabled = False
            Me.RadComboBox4.Enabled = False
        Else
            Me.RadComboBox5.Enabled = False
            Me.RadComboBox3.Enabled = True
            Me.RadComboBox4.Enabled = True
        End If
    End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Ubicacion.FechaFin.Equals(DBNull.Value)
        _Ubicacion.FechaInicio = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Ubicacion.IdProyecto = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Ubicacion.Observacion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Ubicacion.IdSemoviente = IdSemoviente
       
        UbicacionBL.SaveUBICACIONSEMOVIENTES(_Ubicacion)
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdUbicacionSemoviente")
        UbicacionBL.DeleteUBICACIONSEMOVIENTES(id)
    End Sub

    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Ubicacion.IdUbicacionSemoviente = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdUbicacionSemoviente")
        _Ubicacion.FechaInicio = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Ubicacion.IdProyecto = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Ubicacion.Observacion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Ubicacion.IdSemoviente = IdSemoviente

        UbicacionBL.SaveUBICACIONSEMOVIENTES(_Ubicacion)
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Propiedad.FechaFin.Equals(DBNull.Value)
        _Propiedad.FechaInicio = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Propiedad.IdCategoriaAnimal = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Propiedad.IdEstadoSemoviente = CType(userControl.FindControl("DropDownList2"), DropDownList).SelectedValue
        _Propiedad.Peso = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Propiedad.Valor = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Propiedad.IdSemoviente = IdSemoviente

        PropiedadBL.SavePROPIEDADSEMOVIENTES(_Propiedad)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdPropiedadSemoviente")
        PropiedadBL.DeletePROPIEDADSEMOVIENTES(id)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Propiedad.IdPropiedadSemoviente = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdPropiedadSemoviente")
        _Propiedad.FechaInicio = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Propiedad.IdCategoriaAnimal = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Propiedad.IdEstadoSemoviente = CType(userControl.FindControl("DropDownList2"), DropDownList).SelectedValue
        _Propiedad.Peso = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Propiedad.Valor = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Propiedad.IdSemoviente = IdSemoviente

        PropiedadBL.SavePROPIEDADSEMOVIENTES(_Propiedad)
    End Sub

    Protected Sub RadGrid3_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Adjuntos.Archivo = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Adjuntos.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Adjuntos.Nombre = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Adjuntos.IdSemoviente = IdSemoviente

        AdjuntoBL.SaveADJUNTOSEMOVIENTES(_Adjuntos)
    End Sub

    Protected Sub RadGrid3_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAdjuntoSemoviente")
        AdjuntoBL.DeleteADJUNTOSEMOVIENTES(id)
    End Sub

    Protected Sub RadGrid3_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Adjuntos.IdAdjuntoSemoviente = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAdjuntoSemoviente")
         _Adjuntos.Archivo = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Adjuntos.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Adjuntos.Nombre = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Adjuntos.IdSemoviente = IdSemoviente

        AdjuntoBL.SaveADJUNTOSEMOVIENTES(_Adjuntos)
    End Sub
End Class