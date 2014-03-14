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
Public Class FrmFacturar
    Inherits System.Web.UI.Page
    Dim ParametroBL As New ParametrosBL
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    Dim IGV As Decimal
    Dim EjercicioBL As New EjercicioBL
    Dim VentaBL As New VentaBL
    Dim _Venta As New Venta
    Dim Venta As Venta
    Dim _DetalleVenta As New DetalleVenta
    Dim DetalleVentaBL As New DetalleVentaBL
    Dim _Bonificacion As New BonificacionVenta
    Dim BonificacionBL As New BonificacionVentaBL
    Dim estadoMes As String = ""
    Dim IdVenta As String
    Dim Edit As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdVenta = Request.QueryString("IdVenta")
        Edit = Request.QueryString("Edit")
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))

        If estadoMes = "C" Then
            Me.ImageButton3.Visible = False
            Me.ImageButton4.Visible = False
            Me.ImageButton5.Visible = False
            Me.ImageButton6.Visible = False
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If

        'para agregarle un evento 
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")
        Me.ImageButton6.Attributes.Add("onClick", "radconfirm('¿Está seguro de enviar el Comprobante para su Aprobación?', confirmCallBackFn, 330, 100, null,'Mensaje de Confirmación'); return false;")
        Me.txtDate.Attributes.Add("onChange", "ValidarFecha();")


        'para obtener el valor del IGV
        IGV = ParametroBL.GetPARAMETROSByNombre("IGV").valor
        Me.RadNumericTextBox8.Text = IGV

        Me.RadComboBox3.Filter = 1
        Me.RadComboBox8.Filter = 1

        If Page.IsPostBack = False Then
            Me.txtDate.Text = Session("Fecha").ToString

            If IdVenta > 0 Then
                If Edit = 1 Then
                    Me.RadGrid1.MasterTableView.InsertItem()
                End If
                'para recuperar datos de la venta
                Venta = VentaBL.GetVENTAByIdVenta(IdVenta)
                'Para visualizar el boton facturar
                If Venta.NroSerie <> "" Then
                    Me.ImageButton5.Visible = False
                    Me.ImageButton6.Visible = True
                    Me.DropDownList1.Enabled = False
                Else
                    Me.ImageButton5.Visible = True
                    Me.ImageButton6.Visible = False
                    Me.DropDownList1.Enabled = True
                End If

                If Venta.Estado = "V" Then
                    Me.ImageButton5.Visible = False
                    Me.ImageButton6.Visible = False
                ElseIf Venta.Estado = "O" Then
                    Me.ImageButton5.Visible = False
                ElseIf Venta.Estado = "G" Then
                    Me.ImageButton5.Visible = False
                End If

                Me.RadNumericTextBox8.Text = Venta.ValorIGV
                Me.DropDownList1.SelectedValue = Venta.IdTipoDocumento
                If Venta.IdTipoDocumento = 4 Then 'SI ES BOLETA
                    Me.CheckBox2.Enabled = False
                    Me.CheckBox3.Enabled = False
                Else
                    Me.CheckBox2.Enabled = True
                    Me.CheckBox3.Enabled = True
                End If
                Me.DropDownList2.SelectedValue = Venta.IdTipoVenta
                Me.txtDate.Text = Venta.FechaDocumento
                Me.TextBox1.Text = Venta.NroSerie
                If Venta.NroDocumento.HasValue Then
                    Me.TextBox2.Text = Venta.NroDocumento
                End If
                Me.DropDownList4.SelectedValue = Venta.Modalidad
                If Venta.Modalidad = "I" Then
                    Me.TextBox3.Visible = True
                    Me.TextBox3.Text = Venta.NroNotaInterna
                Else
                    Me.TextBox3.Visible = False
                End If

                Me.DropDownList5.SelectedValue = Venta.TipoPago
                If Venta.TipoPago = "C" Then
                    Me.TextBox4.Visible = True
                    Me.DropDownList3.Visible = True
                    Me.DropDownList3.SelectedValue = Venta.IdBanco
                    Me.TextBox4.Text = Venta.NroVoucher
                Else
                    Me.TextBox4.Visible = False
                    Me.DropDownList3.Visible = False
                End If

                Me.RadComboBox3.SelectedValue = Venta.IdProyecto
                _Proveedor = Proveedor.GetAllFromProveedorClienteById(Venta.IdProveedorCliente)
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = Venta.IdProveedorCliente
                Me.TextBox5.Text = Venta.Referencia
                Me.TextBox6.Text = Venta.Observacion1
                If Venta.Transferencia = "S" Then
                    Me.CheckBox1.Checked = True
                Else
                    Me.CheckBox1.Checked = False
                End If

                If Venta.Estado = "O" Then
                    Me.Label1.Visible = True
                    Me.Label2.Visible = True
                    Me.Label2.Text = Venta.Observacion
                End If

                If Venta.AfectoIGV = "S" Then
                    Me.CheckBox2.Checked = True
                Else
                    Me.CheckBox2.Checked = False
                End If

                If Venta.PrecioConIGV = "S" Then
                    Me.CheckBox3.Checked = True
                Else
                    Me.CheckBox3.Checked = False
                End If
            Else
                Me.ImageButton6.Visible = False
            End If

        End If
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        If Me.CheckBox1.Checked = True Then
           _Venta.Transferencia = "S"
        Else
           _Venta.Transferencia = "N"
        End If
        _Venta.AfectoIGV = "S"
        _Venta.Estado = "P"
        _Venta.FechaDocumento = Me.txtDate.Text
        _Venta.FlagVentaAnimales = "N"
        If Me.DropDownList5.SelectedValue = "C" Then
            _Venta.IdBanco = Me.DropDownList3.SelectedValue
            _Venta.NroVoucher = Me.TextBox4.Text
        Else
            _Venta.IdBanco.Equals(DBNull.Value)
            _Venta.NroVoucher = ""
        End If
        _Venta.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        _Venta.IdProyecto = Me.RadComboBox3.SelectedValue
        _Venta.IdTipoDocumento = Me.DropDownList1.SelectedValue
        _Venta.IdTipoVenta = Me.DropDownList2.SelectedValue
        _Venta.IdUsuario = Session("IdUser")
        _Venta.Modalidad = Me.DropDownList4.SelectedValue
        If Me.DropDownList4.SelectedValue = "I" Then
            _Venta.NroNotaInterna = Me.TextBox3.Text
        Else
            _Venta.NroNotaInterna.Equals(DBNull.Value)
        End If
        _Venta.Referencia = Me.TextBox5.Text
        _Venta.TipoPago = Me.DropDownList5.SelectedValue
        _Venta.IdVenta = IdVenta
        _Venta.ValorIGV = Me.RadNumericTextBox8.Value
        _Venta.Observacion = ""
        _Venta.Observacion1 = Me.TextBox6.Text
        If Me.CheckBox2.Checked Then
            _Venta.AfectoIGV = "S"
        Else
            _Venta.AfectoIGV = "N"
        End If
        If Me.CheckBox3.Checked Then
            _Venta.PrecioConIGV = "S"
        Else
            _Venta.PrecioConIGV = "N"
        End If
        IdVenta = VentaBL.SaveVENTA(_Venta)
        Response.Redirect("FrmFacturar.aspx?IdVenta=" + IdVenta.ToString + "&Edit=1")

    End Sub
    Protected Sub RadComboBox8_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox8.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).Ruc.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub

    Protected Sub RadComboBox8_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox8.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox8.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString
            Me.RadComboBox8.DataBind()
        End If
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList4.SelectedIndexChanged
        If Me.DropDownList4.SelectedValue = "I" Then
            Me.TextBox3.Visible = True
        Else
            Me.TextBox3.Visible = False
        End If
    End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList5.SelectedIndexChanged
        If Me.DropDownList5.SelectedValue = "C" Then
            Me.TextBox4.Visible = True
            Me.DropDownList3.Visible = True
        Else
            Me.TextBox4.Visible = False
            Me.DropDownList3.Visible = False
        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        If Me.CheckBox1.Checked = True Then
           _Venta.Transferencia = "S"
        Else
            _Venta.Transferencia = "N"
        End If
        _Venta.AfectoIGV = "S"
        _Venta.Estado = "P"
        _Venta.FechaDocumento = Me.txtDate.Text
        _Venta.FlagVentaAnimales = "N"
        If Me.DropDownList5.SelectedValue = "C" Then
            _Venta.IdBanco = Me.DropDownList3.SelectedValue
            _Venta.NroVoucher = Me.TextBox4.Text
        Else
            _Venta.IdBanco.Equals(DBNull.Value)
            _Venta.NroVoucher = ""
        End If
        _Venta.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        _Venta.IdProyecto = Me.RadComboBox3.SelectedValue
        _Venta.IdTipoDocumento = Me.DropDownList1.SelectedValue
        _Venta.IdTipoVenta = Me.DropDownList2.SelectedValue
        _Venta.IdUsuario = Session("IdUser")
        _Venta.Modalidad = Me.DropDownList4.SelectedValue
        If Me.DropDownList4.SelectedValue = "I" Then
            _Venta.NroNotaInterna = Me.TextBox3.Text
        Else
            _Venta.NroNotaInterna.Equals(DBNull.Value)
        End If
        _Venta.Referencia = Me.TextBox5.Text
        _Venta.TipoPago = Me.DropDownList5.SelectedValue
        _Venta.IdVenta = IdVenta
        _Venta.ValorIGV = Me.RadNumericTextBox8.Value
        _Venta.Observacion = ""
        _Venta.Observacion1 = Me.TextBox6.Text
        If Me.CheckBox2.Checked Then
            _Venta.AfectoIGV = "S"
        Else
            _Venta.AfectoIGV = "N"
        End If
        If Me.CheckBox3.Checked Then
            _Venta.PrecioConIGV = "S"
        Else
            _Venta.PrecioConIGV = "N"
        End If
        IdVenta = VentaBL.SaveVENTA(_Venta)
        Response.Redirect("FrmFacturar.aspx?IdVenta=" + IdVenta.ToString)

    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmFacturar.aspx?IdVenta=0")
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument.StartsWith("Enviar") Then
            Dim j() As String
            Dim valor As String
            j = Split(e.Argument, "|")

            valor = j(1)
            If valor = "true" Then
                VentaBL.UpdateEstadoVENTA(IdVenta, "V")
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "CloseScript_" + UniqueID, "onClientClose('1');", True)
            End If
        End If
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _DetalleVenta.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Value
        _DetalleVenta.Glosa = CType(userControl.FindControl("TextBox2"), TextBox).Text
        If CType(userControl.FindControl("RadComboBox1"), RadComboBox).Text.Length > 0 Then
            _DetalleVenta.IdCatVenta = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        Else
            _DetalleVenta.IdCatVenta.Equals(DBNull.Value)
        End If
        _DetalleVenta.IdMotivoVenta.Equals(DBNull.Value)
        _DetalleVenta.IdSemoviente.Equals(DBNull.Value)
        _DetalleVenta.IdVenta = IdVenta
        _DetalleVenta.PrecioUnitario = CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Value
        _DetalleVenta.Total = CType(userControl.FindControl("RadNumericTextBox4"), RadNumericTextBox).Value
        DetalleVentaBL.SaveDETALLEVENTA(_DetalleVenta)
        If _DetalleVenta.IdCatVenta.HasValue Then
            VentaBL.UpdateIgvVenta(_DetalleVenta.IdCatVenta, IdVenta)
        End If
        Response.Redirect("FrmFacturar.aspx?IdVenta=" + IdVenta.ToString)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim idDet As Int32

        idDet = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalleVenta")
        DetalleVentaBL.DeleteDETALLEVENTA(idDet)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _DetalleVenta.IdDetalleVenta = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalleVenta")
        _DetalleVenta.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Value
        _DetalleVenta.Glosa = CType(userControl.FindControl("TextBox2"), TextBox).Text
        If CType(userControl.FindControl("RadComboBox1"), RadComboBox).Text.Length > 0 Then
            _DetalleVenta.IdCatVenta = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        Else
            _DetalleVenta.IdCatVenta.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("TextBox4"), TextBox).Text <> "" Then
            _DetalleVenta.IdMotivoVenta = CType(userControl.FindControl("TextBox4"), TextBox).Text
        End If
        If CType(userControl.FindControl("TextBox3"), TextBox).Text <> "" Then
            _DetalleVenta.IdSemoviente = CType(userControl.FindControl("TextBox3"), TextBox).Text
        End If
        _DetalleVenta.IdVenta = IdVenta
        _DetalleVenta.PrecioUnitario = CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Value
        _DetalleVenta.Total = CType(userControl.FindControl("RadNumericTextBox4"), RadNumericTextBox).Value
        DetalleVentaBL.SaveDETALLEVENTA(_DetalleVenta)
        If _DetalleVenta.IdCatVenta.HasValue Then
            VentaBL.UpdateIgvVenta(_DetalleVenta.IdCatVenta, IdVenta)
        End If
        Response.Redirect("FrmFacturar.aspx?IdVenta=" + IdVenta.ToString)
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim idBonificacion As Int32

        idBonificacion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdBonificacion")
        BonificacionBL.DeleteBONIFICACIONVENTA(idBonificacion)
    End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Bonificacion.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Value
        _Bonificacion.Glosa = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Bonificacion.IdTipoBonificacion = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Bonificacion.IdVenta = IdVenta
        _Bonificacion.Importe =CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Value
        BonificacionBL.SaveBONIFICACIONVENTA(_Bonificacion)
    End Sub

    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Bonificacion.IdBonificacion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdBonificacion")
        _Bonificacion.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Value
        _Bonificacion.Glosa = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Bonificacion.IdTipoBonificacion = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Bonificacion.IdVenta = IdVenta
        _Bonificacion.Importe = CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Value
        BonificacionBL.SaveBONIFICACIONVENTA(_Bonificacion)
    End Sub

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        If Me.CheckBox1.Checked = True Then
           _Venta.Transferencia = "S"
        Else
            _Venta.Transferencia = "N"
        End If
        _Venta.AfectoIGV = "S"
        _Venta.Estado = "P"
        _Venta.FechaDocumento = Me.txtDate.Text
        _Venta.FlagVentaAnimales = "N"
        If Me.DropDownList5.SelectedValue = "C" Then
            _Venta.IdBanco = Me.DropDownList3.SelectedValue
            _Venta.NroVoucher = Me.TextBox4.Text
        Else
            _Venta.IdBanco.Equals(DBNull.Value)
            _Venta.NroVoucher = ""
        End If
        _Venta.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        _Venta.IdProyecto = Me.RadComboBox3.SelectedValue
        _Venta.IdTipoDocumento = Me.DropDownList1.SelectedValue
        _Venta.IdTipoVenta = Me.DropDownList2.SelectedValue
        _Venta.IdUsuario = Session("IdUser")
        _Venta.Modalidad = Me.DropDownList4.SelectedValue
        If Me.DropDownList4.SelectedValue = "I" Then
            _Venta.NroNotaInterna = Me.TextBox3.Text
        Else
            _Venta.NroNotaInterna.Equals(DBNull.Value)
        End If
        _Venta.Referencia = Me.TextBox5.Text
        _Venta.TipoPago = Me.DropDownList5.SelectedValue
        _Venta.IdVenta = IdVenta
        _Venta.ValorIGV = Me.RadNumericTextBox8.Value
        _Venta.Observacion = ""
        _Venta.Observacion1 = Me.TextBox6.Text
        If Me.CheckBox2.Checked Then
            _Venta.AfectoIGV = "S"
        Else
            _Venta.AfectoIGV = "N"
        End If
        If Me.CheckBox3.Checked Then
            _Venta.PrecioConIGV = "S"
        Else
            _Venta.PrecioConIGV = "N"
        End If
        IdVenta = VentaBL.SaveVENTA(_Venta)
        Me.RadGrid2.MasterTableView.InsertItem()
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        VentaBL.GenerarComprobanteVenta(IdVenta, Me.RadComboBox3.SelectedValue, Me.DropDownList1.Text)
        Response.Redirect("FrmFacturar.aspx?IdVenta=" + IdVenta.ToString)
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Dim cadena_java As String
        If Me.DropDownList1.SelectedValue = 2 Then
            cadena_java = "<script type='text/javascript'> " & _
                                         " window.open('ReporteFacturaVenta.aspx?IdVenta=" + IdVenta.ToString + "'); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        Else
            cadena_java = "<script type='text/javascript'> " & _
                                        " window.open('ReporteBoletaVenta.aspx?IdVenta=" + IdVenta.ToString + "'); " & _
                                        Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If Me.DropDownList1.SelectedValue = 4 Then 'SI ES BOLETA
            Me.CheckBox2.Enabled = False
            Me.CheckBox3.Enabled = False
            Me.CheckBox3.Checked = True
        Else
            Me.CheckBox2.Enabled = True
            Me.CheckBox3.Enabled = True
            Me.CheckBox3.Checked = False
        End If
    End Sub
End Class