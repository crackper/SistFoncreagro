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
Public Class FrmDiario
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL
    Dim ParametroBL As New ParametrosBL
    Dim TransaccionBL As New TransaccionBL
    Dim Transaccion As New Transaccion
    Dim _Transaccion As Transaccion
    Dim _Proveedor As ProveedorCliente
    Dim Proveedor As New ProveedorClienteBL
    Dim _Linea As New Linea
    Dim Linea As Linea
    Dim LineaBL As New LineaBL
    Dim _DocumentoContabilizado As DocumentoContabilizado
    Dim DocumentoContabilizadoBL As New DocumentoContabilizadoBL
    Dim IdTransaccion As String
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Dim Flag As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox8.Filter = 1
        Me.RadComboBox10.Filter = 1
        Flag = Request.QueryString("Flag")
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))

        If estadoMes = "C" Then
            Me.ImageButton3.Visible = False
            Me.ImageButton4.Visible = False
            Me.ImageButton9.Visible = False
            Me.ImageButton10.Visible = False
            Me.ImageButton13.Visible = False
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If

        'para agregar un evento 
        Me.txtDate.Attributes.Add("onChange", "ValidarFecha();")

        If Page.IsPostBack = False Then
            Me.txtDate.Text = Session("Fecha").ToString
            Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Session("Fecha").ToString)


            If Session("IdTransaccion") > 0 Then
                'para recuperar datos de transaccion
                _Transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
                If _Transaccion.IdOpFinanciera.HasValue Then
                    Me.DropDownList1.SelectedValue = _Transaccion.IdOpFinanciera
                End If
                Me.RadComboBox10.DataSourceID = "odsSubDiario1"
                Me.RadComboBox10.DataBind()
                Me.RadComboBox10.SelectedValue = _Transaccion.IdSubDiario
                Me.RadComboBox10.Enabled = False
                Me.DropDownList1.Enabled = False
                Me.TextBox3.Text = _Transaccion.Codigo
                Me.RadComboBox3.SelectedValue = _Transaccion.IdProyecto
                Me.txtDate.Text = _Transaccion.FechaContable
                Me.RadNumericTextBox1.Text = _Transaccion.TipoCambio
                Me.TextBox5.Text = _Transaccion.Glosa

                If _Transaccion.IdProveedorCliente.HasValue Then
                    _Proveedor = Proveedor.GetAllFromProveedorClienteById(_Transaccion.IdProveedorCliente)
                    Me.RadComboBox8.DataSourceID = "odsProveedor"
                    Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                    Me.RadComboBox8.DataBind()
                    Me.RadComboBox8.SelectedValue = _Transaccion.IdProveedorCliente
                End If
            Else
                Me.DropDownList1.SelectedValue = 4
                Me.RadComboBox10.DataSourceID = "odsSubDiario"
                Me.RadComboBox10.DataBind()
            End If

        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        'Grabar transaccion
        Transaccion.Anio = Session("Anio")
        Transaccion.BaseImponible = 0
        Transaccion.BaseInafecto = 0
        Transaccion.IdCtaBancaria.Equals(DBNull.Value)
        Transaccion.DiasVencimiento = 0
        Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
        Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.FechaDocumento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.Glosa = Me.TextBox5.Text
        Transaccion.IdDetraccion.Equals(DBNull.Value)
        Transaccion.IdDocumentoCont = 0
        Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
        ' Transaccion.IdOrdenCompra = Nothing
        Transaccion.IdMoneda = 1
        Transaccion.IdPersonal.Equals(DBNull.Value)

        If Me.RadComboBox8.SelectedValue.Length > 0 Then
            Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        Else
            Transaccion.IdProveedorCliente.Equals(DBNull.Value)
        End If
        Transaccion.IdSubDiario = Me.RadComboBox10.SelectedValue
        Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
        Transaccion.Idtransaccion = Session("IdTransaccion")
        Transaccion.Mes = Session("Mes")
        Transaccion.MontoIgv = 0
        Transaccion.NroCheque = ""
        Transaccion.NroDocumento.Equals(DBNull.Value)
        Transaccion.Otros = 0
        Transaccion.SerieDocumento = ""
        Transaccion.TipoCambio = RadNumericTextBox1.Text
        Transaccion.TipoCambioDocRef = 0
        Transaccion.Total = 0
        Transaccion.Usuario = Session("IdUser")
        Transaccion.ValorIgv = 0
        Transaccion.NroExoneracion = ""
        Transaccion.MontoRetencion = 0
        Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
        Transaccion.Flag = "O"
        If Session("IdTransaccion") > 0 Then
            TransaccionBL.SaveTransaccion(Transaccion)
        Else
            Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
        End If
        'verificamos que registros estan chequeados
        For i = 0 To Me.RadGrid2.Items.Count - 1
            Dim ch As CheckBox = CType(Me.RadGrid2.Items(i).FindControl("CheckBox2"), CheckBox)
         
            Dim idLinea As Int32

            If ch.Checked = True Then

                'grabamos las lineas
                _Linea.IdTransaccion = Session("IdTransaccion")
                _Linea.FechaDocumento = Me.RadGrid2.Items(i)("FechaDocumento").Text.ToString
                _Linea.Glosa = CType(Me.RadGrid2.Items(i).FindControl("TextBox1"), TextBox).Text
                _Linea.IdCCosto.Equals(DBNull.Value)
                _Linea.IdPlan = Me.RadGrid2.Items(i)("IdPlan").Text.ToString
                _Linea.IdProveedorCliente = Me.RadGrid2.Items(i)("IdProveedorCliente").Text.ToString
                _Linea.IdTipoDocumento = Me.RadGrid2.Items(i)("IdTipoDocumento").Text.ToString
                If Me.RadGrid2.Items(i)("CargoMN").Text.ToString > 0 Then
                    _Linea.MontoCargo = 0
                    _Linea.MontoAbono = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                Else
                    _Linea.MontoCargo = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                    _Linea.MontoAbono = 0
                End If
               
                _Linea.NroDocumento = Me.RadGrid2.Items(i)("NroDocumento").Text.ToString
                _Linea.SerieDocumento = Me.RadGrid2.Items(i)("SerieDocumento").Text.ToString
                _Linea.TipoCambio = Me.RadNumericTextBox1.Text
                _Linea.Estado = "C"
                _Linea.Flag = "U"
                _Linea.Enlace = "N"
                _Linea.IdMoneda = Me.RadGrid2.Items(i)("IdMoneda").Text.ToString
                _Linea.TipoCambio = Me.RadNumericTextBox1.Text
                idLinea = LineaBL.SaveLINEA(_Linea)

                'verificamos si se esta cancelando el total del comprobante
                If (Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoCargo Or Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoAbono) Then
                    'actualizamos el estado de la transaccion y de OCxFactura
                    TransaccionBL.CancelarCtaXPagar(_Linea.IdTipoDocumento, _Linea.SerieDocumento, _Linea.NroDocumento, _Linea.IdProveedorCliente, "C")
                End If
            End If
        Next

        Me.RadGrid1.DataBind()
        Me.RadGrid2.Visible = False
        Me.RadGrid2.DataBind()
        Me.TextBox3.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo
        Me.RadComboBox10.Enabled = False
        Me.DropDownList1.Enabled = False
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32

        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdLinea")
        Linea = LineaBL.GetLINEAByIdLinea(id)
        If Linea.IdTipoDocumento > 0 And Linea.NroDocumento > 0 And Linea.IdProveedorCliente > 0 Then
            TransaccionBL.CancelarCtaXPagar(Linea.IdTipoDocumento, Linea.SerieDocumento, Linea.NroDocumento, Linea.IdProveedorCliente, "P")
        End If

        LineaBL.DeleteLINEA(id)
        Me.RadGrid2.DataBind()
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        If Session("IdTransaccion") > 0 Then
            If (TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Or TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "A") Then
                Dim cadena_java As String = _
                                          "<script type='text/javascript'> " & _
                                          " alert('¡Debe validar el Voucher!'); " & _
                                          Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            Else
                Session("IdTransaccion") = 0
                Response.Redirect("~\Contabilidad\Formularios\FrmDiario.aspx?Flag=N")
            End If
        Else
            Session("IdTransaccion") = 0
            Response.Redirect("~\Contabilidad\Formularios\FrmDiario.aspx?Flag=N")
        End If
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim idLinea As Int32

        _Linea.Glosa = CType(userControl.FindControl("TextBox2"), TextBox).Text
        If CType(userControl.FindControl("RadComboBox2"), RadComboBox).Text.Length > 0 Then
            _Linea.IdCCosto = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
        Else
            _Linea.IdCCosto.Equals(DBNull.Value)
        End If
        _Linea.IdPlan = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("RadComboBox8"), RadComboBox).Text.Length > 0 Then
            _Linea.IdProveedorCliente = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Else
            _Linea.IdProveedorCliente.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("RadComboBox6"), RadComboBox).Text.Length > 0 Then
            _Linea.IdTipoDocumento = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        Else
            _Linea.IdTipoDocumento.Equals(DBNull.Value)
        End If
        _Linea.FechaDocumento = FormatDateTime(CType(userControl.FindControl("txtDate1"), TextBox).Text, DateFormat.LongDate)
        _Linea.IdTransaccion = Session("IdTransaccion")
        _Linea.MontoAbono = CType(userControl.FindControl("RadNumericTextBox4"), RadNumericTextBox).Text
        _Linea.MontoCargo = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
      
        If CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text.Length > 0 Then
            _Linea.NroDocumento = CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text
        Else
            _Linea.NroDocumento.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("TextBox3"), TextBox).Text.Length > 0 Then
            _Linea.SerieDocumento = CType(userControl.FindControl("TextBox3"), TextBox).Text
        Else
            _Linea.SerieDocumento = ""
        End If
        _Linea.TipoCambio = Me.RadNumericTextBox1.Text
        _Linea.Flag = "U"
        _Linea.IdMoneda = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        If CType(userControl.FindControl("txtDate3"), TextBox).Text.Length > 0 Then
            _Linea.FechaPago = FormatDateTime(CType(userControl.FindControl("txtDate3"), TextBox).Text, DateFormat.LongDate)
        End If
        If CType(userControl.FindControl("txtDate2"), TextBox).Text.Length > 0 Then
            _Linea.FechaVencimiento = FormatDateTime(CType(userControl.FindControl("txtDate2"), TextBox).Text, DateFormat.LongDate)
        End If
        idLinea = LineaBL.SaveLINEA(_Linea)
        ' LineaBL.UpdateMontosLINEA1(idLinea)

    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim idLinea As Int32

        _Linea.IdLinea = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdLinea")
        _Linea.Glosa = CType(userControl.FindControl("TextBox2"), TextBox).Text
        If CType(userControl.FindControl("RadComboBox2"), RadComboBox).Text.Length > 0 Then
            _Linea.IdCCosto = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
        Else
            _Linea.IdCCosto.Equals(DBNull.Value)
        End If
        _Linea.IdPlan = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("RadComboBox8"), RadComboBox).Text.Length > 0 Then
            _Linea.IdProveedorCliente = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Else
            _Linea.IdProveedorCliente.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("RadComboBox6"), RadComboBox).Text.Length > 0 Then
            _Linea.IdTipoDocumento = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        Else
            _Linea.IdTipoDocumento.Equals(DBNull.Value)
        End If
        _Linea.FechaDocumento = FormatDateTime(CType(userControl.FindControl("txtDate1"), TextBox).Text, DateFormat.LongDate)
        _Linea.IdTransaccion = Session("IdTransaccion")
       
        If CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text.Length > 0 Then
            _Linea.NroDocumento = CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text
        Else
            _Linea.NroDocumento.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("TextBox3"), TextBox).Text.Length > 0 Then
            _Linea.SerieDocumento = CType(userControl.FindControl("TextBox3"), TextBox).Text
        Else
            _Linea.SerieDocumento = ""
        End If
        If Me.RadComboBox10.SelectedValue = 6 Then  'SI ES FONDO FIJO
            _Linea.TipoCambio = CType(userControl.FindControl("NHiddenField1"), HiddenField).Value
        Else
            _Linea.TipoCambio = Me.RadNumericTextBox1.Text
        End If
        _Linea.Flag = "U"
        _Linea.IdMoneda = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        If _Linea.IdMoneda = 1 Then
            _Linea.MontoCargo = CType(userControl.FindControl("NTextBox4"), TextBox).Text
            _Linea.MontoAbono = CType(userControl.FindControl("NTextBox5"), TextBox).Text
            _Linea.CargoMN = CType(userControl.FindControl("NTextBox4"), TextBox).Text
            _Linea.AbonoMN = CType(userControl.FindControl("NTextBox5"), TextBox).Text
            _Linea.CargoME = CType(userControl.FindControl("NTextBox6"), TextBox).Text
            _Linea.AbonoME = CType(userControl.FindControl("NTextBox7"), TextBox).Text
        Else
            _Linea.MontoCargo = CType(userControl.FindControl("NTextBox6"), TextBox).Text
            _Linea.MontoAbono = CType(userControl.FindControl("NTextBox7"), TextBox).Text
            _Linea.CargoMN = CType(userControl.FindControl("NTextBox4"), TextBox).Text
            _Linea.AbonoMN = CType(userControl.FindControl("NTextBox5"), TextBox).Text
            _Linea.CargoME = CType(userControl.FindControl("NTextBox6"), TextBox).Text
            _Linea.AbonoME = CType(userControl.FindControl("NTextBox7"), TextBox).Text
        End If
        If CType(userControl.FindControl("txtDate3"), TextBox).Text.Length > 0 Then
            _Linea.FechaPago = FormatDateTime(CType(userControl.FindControl("txtDate3"), TextBox).Text, DateFormat.LongDate)
        End If
        If CType(userControl.FindControl("txtDate2"), TextBox).Text.Length > 0 Then
            _Linea.FechaVencimiento = FormatDateTime(CType(userControl.FindControl("txtDate2"), TextBox).Text, DateFormat.LongDate)
        End If


        idLinea = LineaBL.SaveLINEA(_Linea)
        ' LineaBL.UpdateMontosLINEA1(idLinea)
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        'Grabar transaccion
        Transaccion.Anio = Session("Anio")
        Transaccion.BaseImponible = 0
        Transaccion.BaseInafecto = 0
        Transaccion.IdCtaBancaria.Equals(DBNull.Value)
        Transaccion.DiasVencimiento = 0
        Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
        Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.FechaDocumento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.Glosa = Me.TextBox5.Text
        Transaccion.IdDetraccion.Equals(DBNull.Value)
        Transaccion.IdDocumentoCont.Equals(DBNull.Value)
        Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
        Transaccion.IdMoneda = 1
        ' Transaccion.IdOrdenCompra = Nothing
        Transaccion.IdPersonal.Equals(DBNull.Value)
        If Me.RadComboBox8.SelectedValue.Length > 0 Then
            Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        Else
            Transaccion.IdProveedorCliente.Equals(DBNull.Value)
        End If
        Transaccion.IdSubDiario = Me.RadComboBox10.SelectedValue
        Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
        Transaccion.Idtransaccion = Session("IdTransaccion")
        Transaccion.Mes = Session("Mes")
        Transaccion.MontoIgv = 0
        Transaccion.NroCheque = ""
        Transaccion.NroDocumento.Equals(DBNull.Value)
        Transaccion.Otros = 0
        Transaccion.SerieDocumento = ""
        Transaccion.TipoCambio = RadNumericTextBox1.Text
        Transaccion.TipoCambioDocRef = 0
        Transaccion.Total = 0
        Transaccion.Usuario = Session("IdUser")
        Transaccion.ValorIgv = 0
        Transaccion.NroExoneracion = ""
        Transaccion.MontoRetencion = 0
        Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
        Transaccion.Flag = "O"

        If Session("IdTransaccion") > 0 Then
            TransaccionBL.SaveTransaccion(Transaccion)
        Else
            Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
        End If
        Me.TextBox3.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo
        Me.RadComboBox10.Enabled = False
        Me.DropDownList1.Enabled = False
        Me.RadGrid1.MasterTableView.InsertItem()
    End Sub

    'Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
    '    If Session("IdTransaccion") > 0 Then
    '        If TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Then
    '            Dim cadena_java As String = _
    '                                      "<script type='text/javascript'> " & _
    '                                      " alert('¡Debe validar el Voucher!'); " & _
    '                                      Chr(60) & "/script>"
    '            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
    '        Else
    '            If Flag <> "N" Then
    '                Response.Redirect(Session("Ventana") + "?Idsubdiario=5&Flag=" + Flag.ToString)
    '            Else
    '                Response.Redirect(Session("Ventana") + "?Idsubdiario=5")
    '            End If
    '        End If
    '    Else
    '        If Flag <> "N" Then
    '            Response.Redirect(Session("Ventana") + "?Idsubdiario=5&Flag=" + Flag.ToString)
    '        Else
    '            Response.Redirect(Session("Ventana") + "?Idsubdiario=5")
    '        End If
    '    End If

    'End Sub

    Protected Sub RadGrid2_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid2.DataBound
        For i = 0 To Me.RadGrid2.Items.Count - 1
            CType(Me.RadGrid2.Items(i).FindControl("TextBox1"), TextBox).Text = "Cancelacion Factura " + Me.RadGrid2.Items(i)("SerieDocumento").Text + " " + Me.RadGrid2.Items(i)("NroDocumento").Text
        Next
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        If Me.RadComboBox10.SelectedValue = 6 Then
            TransaccionBL.GenerarLineaFondoFijo(Session("IdTransaccion"))
        Else
            TransaccionBL.GenerarDestinoDiario(Session("IdTransaccion"))
        End If
        Me.RadGrid1.Rebind()
    End Sub

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        LineaBL.DeleteLINEAByFlag(Session("IdTransaccion"))
        Me.RadGrid1.Rebind()
    End Sub

    Protected Sub RadGrid1_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.DataBound
        Dim registros As Int32
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.MasterTableView.Items.Item(i)("editar").Text = ""
                Me.RadGrid1.MasterTableView.Items.Item(i)("eliminar").Text = ""
            Next

        Else
            'para mostrar los botones
            If Session("IdTransaccion") > 0 Then
                registros = LineaBL.GetNumeroRegistrosFromLINEA1(Session("IdTransaccion")) 'para verificar si la transaccion contiene cuentas que generan destino
                If registros > 0 Then
                    registros = LineaBL.GetNumeroRegistrosFromLINEA(Session("IdTransaccion")) 'para verificar si la transaccion cuentas que generan destino ya contiene cuentas de destino
                    If registros > 0 Then
                        Me.ImageButton10.Visible = True
                        Me.ImageButton13.Visible = True
                        Me.ImageButton9.Visible = False
                        'para deshabilitar los botones de la grilla
                        For i = 0 To Me.RadGrid1.Items.Count - 1
                            Me.RadGrid1.Items.Item(i)("editar").Enabled = False
                            Me.RadGrid1.Items.Item(i)("eliminar").Enabled = False
                        Next
                        Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
                    Else
                        Me.ImageButton10.Visible = False
                        Me.ImageButton13.Visible = False
                        Me.ImageButton9.Visible = True
                        'para habilitar los botones de la grilla
                        For i = 0 To Me.RadGrid1.Items.Count - 1
                            Me.RadGrid1.Items.Item(i)("editar").Enabled = True
                            Me.RadGrid1.Items.Item(i)("eliminar").Enabled = True
                        Next
                        Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.Top
                    End If
                Else
                    Me.ImageButton10.Visible = False
                    Me.ImageButton13.Visible = True
                    Me.ImageButton9.Visible = False
                End If


            Else
                Me.ImageButton10.Visible = False
                Me.ImageButton13.Visible = False
                Me.ImageButton9.Visible = False
                'para habilitar los botones de la grilla
                For i = 0 To Me.RadGrid1.Items.Count - 1
                    Me.RadGrid1.Items.Item(i)("editar").Enabled = True
                    Me.RadGrid1.Items.Item(i)("eliminar").Enabled = True
                Next
                Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.Top
            End If
        End If
    End Sub

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
    '    Me.RadGrid2.Visible = True
    'End Sub

    'Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    '    Me.RadGrid2.Visible = False
    'End Sub
    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
       If e.Argument = "ValidarFecha" Then
            If Me.txtDate.Text.Length > 0 Then
                If (CDate(Me.txtDate.Text).Month <> Session("Mes") Or CDate(Me.txtDate.Text) > CDate(Session("Fecha"))) Then
                    Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡La Fecha Contable es incorrecta!'); Foco(); " & _
                                       Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                    Me.RadNumericTextBox1.Text = 0
                    Me.RadNumericTextBox1.Focus()
                End If
                Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Me.txtDate.Text)

            End If
        End If
    End Sub

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('Voucher.aspx?Tipo=D'); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
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

    Protected Sub CheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim check As CheckBox = DirectCast(sender, CheckBox)
        Dim i As Integer


        If check.Checked = True Then
            For i = 0 To Me.RadGrid2.Items.Count - 1
                Dim ch As CheckBox = CType(Me.RadGrid2.Items(i).FindControl("CheckBox2"), CheckBox)
                ch.Checked = True
            Next
        Else
            For i = 0 To Me.RadGrid2.Items.Count - 1
                Dim ch As CheckBox = CType(Me.RadGrid2.Items(i).FindControl("CheckBox2"), CheckBox)
                ch.Checked = False
            Next
        End If
       
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        Dim totalDebeMN As Decimal
        Dim totalhaberMN As Decimal
        Dim totalDebeME As Decimal
        Dim totalhaberME As Decimal

        For i = 0 To Me.RadGrid1.Items.Count - 1
            'PARA CALCULAR EL TOTAL

            totalDebeMN = totalDebeMN + Decimal.Parse(Me.RadGrid1.Items(i)("CargoMN").Text.ToString)
            totalhaberMN = totalhaberMN + Decimal.Parse(Me.RadGrid1.Items(i)("AbonoMN").Text.ToString)

            totalDebeME = totalDebeME + Decimal.Parse(Me.RadGrid1.Items(i)("CargoME").Text.ToString)
            totalhaberME = totalhaberME + Decimal.Parse(Me.RadGrid1.Items(i)("AbonoME").Text.ToString)

        Next
        'If RadComboBox10.SelectedValue <> 1 And RadComboBox10.SelectedValue <> 54 And RadComboBox10.SelectedValue <> 56 And RadComboBox10.SelectedValue <> 55 Then
        '    If (totalDebeMN <> totalhaberMN Or totalDebeME <> totalhaberME) Then
        '        Dim cadena_java As String = _
        '                                  "<script type='text/javascript'> " & _
        '                                  " Alerta('¡No coinciden los Montos, Debe Cuadrar el Voucher!'); " & _
        '                                  Chr(60) & "/script>"
        '        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        '        TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "S")
        '    Else
        '        Dim cadena_java As String = _
        '                                   "<script type='text/javascript'> " & _
        '                                   " Alerta('¡Voucher " + Me.RadComboBox10.SelectedValue.ToString + "-" + Me.TextBox3.Text.ToString + "  creado correctamente!'); " & _
        '                                   Chr(60) & "/script>"
        '        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        '        TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "P")
        '    End If
        'Else
        If (totalDebeMN <> totalhaberMN And totalDebeME <> totalhaberME) Then
            Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡No coinciden los Montos, Debe Cuadrar el Voucher!'); " & _
                                      Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "S")
        Else
            TransaccionBL.CuadrarVoucherDiario(Session("IdTransaccion"))
            Me.RadGrid1.Rebind()

            Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡Voucher " + Me.RadComboBox10.SelectedValue.ToString + "-" + Me.TextBox3.Text.ToString + "  creado correctamente!'); " & _
                                       Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "P")
        End If
        'End If
    End Sub

    Protected Sub ImageButton14_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Me.RadGrid2.Rebind()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.RadGrid2.Visible = True
        Me.RadGrid2.DataSourceID = "SqlCuentasPendientes"
        If Me.RadComboBox11.Text.Length > 0 Then
            Me.SqlCuentasPendientes.SelectParameters("idProveedor").DefaultValue = Me.RadComboBox11.SelectedValue
            Me.SqlCuentasPendientes.SelectParameters("idProyecto").DefaultValue = Me.RadComboBox3.SelectedValue
        Else
            Me.SqlCuentasPendientes.SelectParameters("idProveedor").DefaultValue = Me.RadComboBox8.SelectedValue
            Me.SqlCuentasPendientes.SelectParameters("idProyecto").DefaultValue = Me.RadComboBox3.SelectedValue
        End If

    End Sub

   
    Protected Sub RadComboBox11_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox11.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).Ruc.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub

    Protected Sub RadComboBox11_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox11.ItemsRequested
        If e.Text.Length > 2 Then

            Me.RadComboBox11.DataSourceID = "odsProveedor1"
            Me.odsProveedor1.SelectParameters("Parametro").DefaultValue = e.Text.ToString

            Me.RadComboBox11.DataBind()
        End If
    End Sub

    Protected Sub Cerrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Me.RadGrid2.Visible = False
    End Sub

    Protected Sub ImageButton11_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('Voucher.aspx?Tipo=D'); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.RadComboBox10.Text = ""
    End Sub
End Class

