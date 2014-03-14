Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmValidarInmueble
    Inherits System.Web.UI.Page

    Dim bienInmueble As BienInmueble
    Dim bienInmuebleBL As New BienInmuebleBL
    Dim _BienInmueble As New BienInmueble
    Dim IdBienInmueble As String
    Dim _ubigeo As UbigeoDatos
    Dim ubigeoBL As New UbigeoDatosBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdBienInmueble = Request.QueryString("IdBienInmueble")

        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1

        'para agregarle un evento 
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")

        If Page.IsPostBack = False Then
            Me.txtDate.Text = Now

            If IdBienInmueble > 0 Then
                'para recuperar datos de transaccion
                bienInmueble = bienInmuebleBL.GetBIENINMUEBLEByIdBienInmueble(IdBienInmueble)

                Me.TextBox1.Text = bienInmueble.Nombre
                Me.DropDownList1.SelectedValue = bienInmueble.IdTipo

                If bienInmueble.IdUbigeo <> "" Then
                    _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(bienInmueble.IdUbigeo)
                    Me.RadComboBox1.DataSourceID = "OdsUbigeo"
                    Me.OdsUbigeo.SelectParameters("texto").DefaultValue = _ubigeo.Nombre
                    Me.RadComboBox1.DataBind()
                    Me.RadComboBox1.SelectedValue = bienInmueble.IdUbigeo
                End If

                Me.TextBox2.Text = bienInmueble.Direccion
                Me.RadComboBox2.SelectedValue = bienInmueble.IdProyecto

                If bienInmueble.IdCCosto > 0 Then
                    Me.RadComboBox3.SelectedValue = bienInmueble.IdCCosto
                End If

                If bienInmueble.IdProveedorCliente > 0 Then
                    Me.RadComboBox4.SelectedValue = bienInmueble.IdProveedorCliente
                End If

                Me.txtDate.Text = bienInmueble.FechaCompra
                Me.RadNumericTextBox1.Text = bienInmueble.ValorCompra
                Me.RadNumericTextBox4.Text = bienInmueble.TipoCambio
                Me.RadNumericTextBox2.Text = bienInmueble.AreaTotal
                Me.RadNumericTextBox3.Text = bienInmueble.AreaConstruida
                Me.TextBox3.Text = bienInmueble.Observacion
            End If

        End If
    End Sub

    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Departamento.ToString() + " - " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Provincia.ToString() + " - " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Distrito.ToString() + " - " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Nombre.ToString() + " (" + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Nivel.ToString() + ")"
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CUBIGEO.ToString()
    End Sub

    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox1.DataSourceID = "OdsUbigeo"
            Me.OdsUbigeo.SelectParameters("texto").DefaultValue = e.Text.ToString
            Me.RadComboBox1.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox4_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox4.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).Ruc.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub

    Protected Sub RadComboBox4_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox4.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox4.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString
            Me.RadComboBox4.DataBind()
        End If
    End Sub
    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        _BienInmueble.AreaConstruida = Me.RadNumericTextBox3.Text
        _BienInmueble.AreaTotal = Me.RadNumericTextBox2.Text
        _BienInmueble.Direccion = Me.TextBox2.Text
        _BienInmueble.FechaCompra = Me.txtDate.Text
        _BienInmueble.IdBienInmueble = IdBienInmueble
        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            _BienInmueble.IdCCosto = Me.RadComboBox3.SelectedValue
        Else
            _BienInmueble.IdCCosto.Equals(DBNull.Value)
        End If

        _BienInmueble.IdMoneda = Me.DropDownList2.SelectedValue
        If Me.RadComboBox4.SelectedValue.Length > 0 Then
            _BienInmueble.IdProveedorCliente = Me.RadComboBox4.SelectedValue
        Else
            _BienInmueble.IdProyecto.Equals(DBNull.Value)
        End If

        _BienInmueble.IdProyecto = Me.RadComboBox2.SelectedValue
        _BienInmueble.IdTipo = Me.DropDownList1.SelectedValue
        _BienInmueble.IdUbigeo = Me.RadComboBox1.SelectedValue
        _BienInmueble.Nombre = Me.TextBox1.Text
        _BienInmueble.Observacion = Me.TextBox3.Text
        _BienInmueble.TipoCambio = Me.RadNumericTextBox4.Text
        _BienInmueble.ValorCompra = Me.RadNumericTextBox1.Text

        IdBienInmueble = bienInmuebleBL.SaveBIENINMUEBLE(_BienInmueble)
        bienInmuebleBL.UpdateEstadoBIENINMUEBLE(IdBienInmueble, "V")
        Dim cadena_java As String = _
                                   "<script type='text/javascript'> " & _
                                   " alert('¡El Bien Inmueble ha sido Validado correctamente!'); " & _
                                   Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
    End Sub
End Class