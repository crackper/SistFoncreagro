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
Public Class FrmStakeholders
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Dim IdInteresado As String
    Dim InteresadoBL As New InteresadosBL
    Dim _Interesado As New Interesados
    Dim Interesado As Interesados
    Dim _ubigeo As UbigeoDatos
    Dim ubigeoBL As New UbigeoDatosBL
    Dim _Actitud As New ActitudInteresado
    Dim ActitudBL As New ActitudInteresadoBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdInteresado = Request.QueryString("IdInteresado")
        IdProyecto = Request.QueryString("IdProyecto")

        Me.RadComboBox1.Filter = 1

        If Page.IsPostBack = False Then
            Me.txtDate.Text = Date.Now

            If IdInteresado > 0 Then
                'para recuperar datos 
                Interesado = InteresadoBL.GetINTERESADOSByIdInteresado(IdInteresado)

                _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(Interesado.IdUbigeo)
                Me.RadComboBox1.DataSourceID = "OdsUbigeo"
                Me.OdsUbigeo.SelectParameters("texto").DefaultValue = _ubigeo.Nombre
                Me.RadComboBox1.DataBind()
                Me.RadComboBox1.SelectedValue = Interesado.IdUbigeo

                Me.txtDate.Text = Interesado.FechaRegistro
                Me.TextBox1.Text = Interesado.Apellidos
                Me.TextBox2.Text = Interesado.Nombres
                Me.TextBox3.Text = Interesado.Telefono
                Me.TextBox4.Text = Interesado.Dni
                Me.TextBox5.Text = Interesado.Direccion
                If Interesado.IdInstitucion > 0 Then
                    Me.DropDownList3.SelectedValue = Interesado.IdInstitucion
                End If
                Me.TextBox6.Text = Interesado.Cargo
                Me.TextBox7.Text = Interesado.Interes
                Me.TextBox8.Text = Interesado.ActividadEconomica
                Me.TextBox9.Text = Interesado.Relaciones
                Me.TextBox10.Text = Interesado.Operaciones
                If Interesado.RedLideres = "NO" Then
                    Me.CheckBox1.Checked = False
                Else
                    Me.CheckBox1.Checked = True
                End If
              
            End If
        End If
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

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim existe As Int32

        If IdInteresado > 0 Then
            _Interesado.ActividadEconomica = Me.TextBox8.Text
            _Interesado.Apellidos = Me.TextBox1.Text
            _Interesado.Cargo = Me.TextBox6.Text
            _Interesado.Direccion = Me.TextBox5.Text
            _Interesado.Dni = Me.TextBox4.Text
            _Interesado.FechaRegistro = Me.txtDate.Text
            If Me.DropDownList3.SelectedValue = 0 Then
                _Interesado.IdInstitucion.Equals(DBNull.Value)
            Else
                _Interesado.IdInstitucion = Me.DropDownList3.SelectedValue
            End If

            _Interesado.IdInteresado = IdInteresado
            _Interesado.IdProyecto = IdProyecto
            _Interesado.IdUbigeo = Me.RadComboBox1.SelectedValue
            _Interesado.IdUsuario = Session("IdUser")
            _Interesado.Interes = Me.TextBox7.Text
            _Interesado.Nombres = Me.TextBox2.Text
            _Interesado.Operaciones = Me.TextBox10.Text
            _Interesado.Relaciones = Me.TextBox9.Text
            _Interesado.Telefono = Me.TextBox3.Text
            If Me.CheckBox1.Checked Then
                _Interesado.RedLideres = "SI"
            Else
                _Interesado.RedLideres = "NO"
            End If

            If IdInteresado > 0 Then
                InteresadoBL.SaveINTERESADO(_Interesado)
            Else
                IdInteresado = InteresadoBL.SaveINTERESADO(_Interesado)
            End If
            Response.Redirect("FrmStakeholders.aspx?IdInteresado=" + IdInteresado.ToString + "&IdProyecto=" + IdProyecto.ToString)

        Else
            If Me.TextBox4.Text <> "" Then
                existe = InteresadoBL.VerifyInteresado(Me.TextBox4.Text)
                If existe = 0 Then
                    _Interesado.ActividadEconomica = Me.TextBox8.Text
                    _Interesado.Apellidos = Me.TextBox1.Text
                    _Interesado.Cargo = Me.TextBox6.Text
                    _Interesado.Direccion = Me.TextBox5.Text
                    _Interesado.Dni = Me.TextBox4.Text
                    _Interesado.FechaRegistro = Me.txtDate.Text
                    If Me.DropDownList3.SelectedValue = 0 Then
                        _Interesado.IdInstitucion.Equals(DBNull.Value)
                    Else
                        _Interesado.IdInstitucion = Me.DropDownList3.SelectedValue
                    End If

                    _Interesado.IdInteresado = IdInteresado
                    _Interesado.IdProyecto = IdProyecto
                    _Interesado.IdUbigeo = Me.RadComboBox1.SelectedValue
                    _Interesado.IdUsuario = Session("IdUser")
                    _Interesado.Interes = Me.TextBox7.Text
                    _Interesado.Nombres = Me.TextBox2.Text
                    _Interesado.Operaciones = Me.TextBox10.Text
                    _Interesado.Relaciones = Me.TextBox9.Text
                    _Interesado.Telefono = Me.TextBox3.Text
                    If Me.CheckBox1.Checked Then
                        _Interesado.RedLideres = "SI"
                    Else
                        _Interesado.RedLideres = "NO"
                    End If

                    If IdInteresado > 0 Then
                        InteresadoBL.SaveINTERESADO(_Interesado)
                    Else
                        IdInteresado = InteresadoBL.SaveINTERESADO(_Interesado)
                    End If
                    Response.Redirect("FrmStakeholders.aspx?IdInteresado=" + IdInteresado.ToString + "&IdProyecto=" + IdProyecto.ToString)
                Else
                    Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡El número de DNI ya está registrado, no se puede guardar!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                    Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                End If
            Else
                existe = InteresadoBL.VerifyInteresado1(Me.TextBox1.Text.Trim + " " + Me.TextBox2.Text.Trim)
                If existe = 0 Then
                    _Interesado.ActividadEconomica = Me.TextBox8.Text
                    _Interesado.Apellidos = Me.TextBox1.Text
                    _Interesado.Cargo = Me.TextBox6.Text
                    _Interesado.Direccion = Me.TextBox5.Text
                    _Interesado.Dni = Me.TextBox4.Text
                    _Interesado.FechaRegistro = Me.txtDate.Text
                    If Me.DropDownList3.SelectedValue = 0 Then
                        _Interesado.IdInstitucion.Equals(DBNull.Value)
                    Else
                        _Interesado.IdInstitucion = Me.DropDownList3.SelectedValue
                    End If

                    _Interesado.IdInteresado = IdInteresado
                    _Interesado.IdProyecto = IdProyecto
                    _Interesado.IdUbigeo = Me.RadComboBox1.SelectedValue
                    _Interesado.IdUsuario = Session("IdUser")
                    _Interesado.Interes = Me.TextBox7.Text
                    _Interesado.Nombres = Me.TextBox2.Text
                    _Interesado.Operaciones = Me.TextBox10.Text
                    _Interesado.Relaciones = Me.TextBox9.Text
                    _Interesado.Telefono = Me.TextBox3.Text
                    If Me.CheckBox1.Checked Then
                        _Interesado.RedLideres = "SI"
                    Else
                        _Interesado.RedLideres = "NO"
                    End If

                    If IdInteresado > 0 Then
                        InteresadoBL.SaveINTERESADO(_Interesado)
                    Else
                        IdInteresado = InteresadoBL.SaveINTERESADO(_Interesado)
                    End If
                    Response.Redirect("FrmStakeholders.aspx?IdInteresado=" + IdInteresado.ToString + "&IdProyecto=" + IdProyecto.ToString)
                Else
                    Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡El nombre ya está registrado, no se puede guardar!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                    Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                End If
            End If

           
        End If
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmStakeholders.aspx?IdInteresado=0&IdProyecto=" + IdProyecto.ToString)
    End Sub

    Protected Sub RadGrid4_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Actitud.IdInteresado = IdInteresado
        _Actitud.Actitud = CType(userControl.FindControl("DropDownList4"), DropDownList).SelectedValue
        _Actitud.Comentario = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Actitud.Dialogo = CType(userControl.FindControl("DropDownList6"), DropDownList).SelectedValue
        _Actitud.FechaInicio = CType(userControl.FindControl("txtDate"), TextBox).Text
        _Actitud.IdUsuario = Session("IdUser")
        _Actitud.PlanAccion = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Actitud.Poder = CType(userControl.FindControl("DropDownList5"), DropDownList).SelectedValue
        ActitudBL.SaveACTITUDINTERESADO(_Actitud)
    End Sub

    Protected Sub RadGrid4_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id1 As Int32

        id1 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdActitud")
        ActitudBL.DeleteACTITUDINTERESADO(id1)
    End Sub

    Protected Sub RadGrid4_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Actitud.IdActitud = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdActitud")
       _Actitud.IdInteresado = IdInteresado
        _Actitud.Actitud = CType(userControl.FindControl("DropDownList4"), DropDownList).SelectedValue
        _Actitud.Comentario = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Actitud.Dialogo = CType(userControl.FindControl("DropDownList6"), DropDownList).SelectedValue
        _Actitud.FechaInicio = CType(userControl.FindControl("txtDate"), TextBox).Text
        _Actitud.IdUsuario = Session("IdUser")
        _Actitud.PlanAccion = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Actitud.Poder = CType(userControl.FindControl("DropDownList5"), DropDownList).SelectedValue
        ActitudBL.SaveACTITUDINTERESADO(_Actitud)
    End Sub
End Class