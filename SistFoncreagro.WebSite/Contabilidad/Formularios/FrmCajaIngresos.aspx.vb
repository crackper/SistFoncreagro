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
Public Class FrmCaja
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL
    Dim ParametroBL As New ParametrosBL
    Dim TransaccionBL As New TransaccionBL
    Dim _Transaccion As New Transaccion
    Dim Transaccion As Transaccion
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    Dim _Linea As New Linea
    Dim _Linea1 As New Linea
    Dim _Linea2 As New Linea
    Dim _Linea3 As New Linea
    Dim Linea As Linea
    Dim LineaBL As New LineaBL
    Dim CtaBancaria As CuentaBancaria
    Dim CtaBancariaBL As New CuentaBancariaBL
    Dim IdTransaccion As String
    Dim Flag As String
    Dim IdTransaccionEnlace As Int32 = 0
    Dim CuentaEnlaceBL As New CuentaEnlaceBL
    Dim PlanContableBL As New PlanContableBL
    Dim ProyectoBL As New ProyectoBL
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Dim SumDebe As Decimal = 0
    Dim SumHaber As Decimal = 0
    Dim TotalCaja As Decimal = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.ImageButton3.Visible = False
            Me.ImageButton4.Visible = False
            Me.ImageButton9.Visible = False
            Me.ImageButton10.Visible = False
            Me.ImageButton13.Visible = False
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If

        Flag = Request.QueryString("Flag")
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox8.Filter = 1
        Me.RadComboBox10.Filter = 1

        'para agregarle un evento al boton registrar clientes
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")


        'para agregar un evento 
        Me.txtDate.Attributes.Add("onChange", "ValidarFecha();")

        If Page.IsPostBack = False Then
            Me.DropDownList1.Focus()
            Me.txtDate.Text = Session("Fecha").ToString
            Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Session("Fecha").ToString)

            If Session("IdTransaccion") > 0 Then
                'para recuperar datos de transaccion
                Transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
                Me.DropDownList1.SelectedValue = Transaccion.IdOpFinanciera
                Me.RadComboBox10.DataSourceID = "odsSubDiario1"
                Me.RadComboBox10.DataBind()
                Me.RadComboBox10.SelectedValue = Transaccion.IdSubDiario
                Me.RadComboBox10.Enabled = False
                Me.TextBox3.Text = Transaccion.Codigo
                Me.RadComboBox3.SelectedValue = Transaccion.IdProyecto
                Me.txtDate.Text = Transaccion.FechaContable
                If Transaccion.IdSubDiario = 57 Or Transaccion.IdSubDiario = 5 Then
                    If Transaccion.IdCtaBancaria > 0 Then
                        Me.RadComboBox9.DataSourceID = "SqlCuentaBancaria1"
                        Me.RadComboBox9.DataBind()
                        Me.RadComboBox9.SelectedValue = Transaccion.IdCtaBancaria
                        Me.RadComboBox9.Enabled = False
                        Me.TextBox2.Enabled = False
                    End If

                Else
                    If Transaccion.IdCtaBancaria > 0 Then
                        Me.RadComboBox9.DataSourceID = "SqlCuentaBancaria"
                        Me.SqlCuentaBancaria.SelectParameters("IdProyecto").DefaultValue = Transaccion.IdProyecto
                        Me.SqlCuentaBancaria.SelectParameters("idSubdiario").DefaultValue = Transaccion.IdSubDiario
                        Me.RadComboBox9.DataBind()
                        Me.RadComboBox9.SelectedValue = Transaccion.IdCtaBancaria
                    End If

                End If

                _Proveedor = Proveedor.GetAllFromProveedorClienteById(Transaccion.IdProveedorCliente)
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = Transaccion.IdProveedorCliente

                Me.RadNumericTextBox1.Text = Transaccion.TipoCambio
                Me.TextBox5.Text = Transaccion.Glosa
                Me.HiddenField1.Value = Transaccion.IdMoneda
                Me.TextBox2.Text = Transaccion.Enlace
            Else
                Me.DropDownList1.SelectedValue = 1
                Me.RadComboBox10.DataSourceID = "odsSubDiario"
                Me.RadComboBox10.DataBind()
            End If



        End If
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        'grabamos la transaccion
        _Transaccion.Anio = Session("Anio")
        _Transaccion.BaseImponible = 0
        _Transaccion.BaseInafecto = 0
        _Transaccion.IdCtaBancaria = Me.RadComboBox9.SelectedValue
        _Transaccion.DiasVencimiento = 0
        _Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
        _Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
        _Transaccion.FechaDocumento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        _Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        _Transaccion.Flag = Flag
        _Transaccion.Glosa = Me.TextBox5.Text
        _Transaccion.IdDetraccion.Equals(DBNull.Value)
        _Transaccion.IdDocumentoCont.Equals(DBNull.Value)
        _Transaccion.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
        _Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
        _Transaccion.IdOrdenCompra.Equals(DBNull.Value)
        _Transaccion.IdPersonal.Equals(DBNull.Value)
        _Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        _Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
        _Transaccion.IdSubDiario = Me.RadComboBox10.SelectedValue
        _Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
        _Transaccion.IdTipoDocRef.Equals(DBNull.Value)
        _Transaccion.Idtransaccion = Session("IdTransaccion")
        _Transaccion.Mes = Session("Mes")
        _Transaccion.MontoIgv = 0
        _Transaccion.MontoRetencion = 0
        _Transaccion.NroCheque = ""
        _Transaccion.NroDocRef.Equals(DBNull.Value)
        _Transaccion.NroDocumento.Equals(DBNull.Value)
        _Transaccion.NroExoneracion = ""
        _Transaccion.Otros = 0
        _Transaccion.SerieDocRef = ""
        _Transaccion.SerieDocumento = ""
        _Transaccion.TipoCambio = Me.RadNumericTextBox1.Text
        _Transaccion.TipoCambioDocRef = 0
        _Transaccion.Total = 0
        _Transaccion.Usuario = Session("IdUser")
        _Transaccion.ValorIgv = 0
        If Session("IdTransaccion") > 0 Then
            TransaccionBL.SaveTransaccion(_Transaccion)
        Else
            Session("IdTransaccion") = TransaccionBL.SaveTransaccion(_Transaccion)
        End If

        'Me.RadTextBox9.Text = "S"
        Me.TextBox3.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo

        Me.RadGrid1.MasterTableView.InsertItem()
    End Sub
    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim monedaCaja As Int32

        monedaCaja = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
        'grabamos la transaccion
        _Transaccion.Anio = Session("Anio")
        _Transaccion.BaseImponible = 0
        _Transaccion.BaseInafecto = 0
        _Transaccion.IdCtaBancaria = Me.RadComboBox9.SelectedValue
        _Transaccion.DiasVencimiento = 0
        _Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
        _Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
        _Transaccion.FechaDocumento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        _Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        _Transaccion.Flag = Flag
        _Transaccion.Glosa = Me.TextBox5.Text
        _Transaccion.IdDetraccion.Equals(DBNull.Value)
        _Transaccion.IdDocumentoCont.Equals(DBNull.Value)
        _Transaccion.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
        _Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
        _Transaccion.IdOrdenCompra.Equals(DBNull.Value)
        _Transaccion.IdPersonal.Equals(DBNull.Value)
        _Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        _Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
        _Transaccion.IdSubDiario = Me.RadComboBox10.SelectedValue
        _Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
        _Transaccion.IdTipoDocRef.Equals(DBNull.Value)
        _Transaccion.Idtransaccion = Session("IdTransaccion")
        _Transaccion.Mes = Session("Mes")
        _Transaccion.MontoIgv = 0
        _Transaccion.MontoRetencion = 0
        _Transaccion.NroCheque = ""
        _Transaccion.NroDocRef.Equals(DBNull.Value)
        _Transaccion.NroDocumento.Equals(DBNull.Value)
        _Transaccion.NroExoneracion = ""
        _Transaccion.Otros = 0
        _Transaccion.SerieDocRef = ""
        _Transaccion.SerieDocumento = ""
        _Transaccion.TipoCambio = Me.RadNumericTextBox1.Text
        _Transaccion.TipoCambioDocRef = 0
        _Transaccion.Total = 0
        _Transaccion.Usuario = Session("IdUser")
        _Transaccion.ValorIgv = 0
        If Session("IdTransaccion") > 0 Then
            TransaccionBL.SaveTransaccion(_Transaccion)
        Else
            Session("IdTransaccion") = TransaccionBL.SaveTransaccion(_Transaccion)
        End If

        'verificamos que registros estan chequeados
        For i = 0 To Me.RadGrid2.Items.Count - 1
            Dim ch As CheckBox = CType(Me.RadGrid2.Items(i).FindControl("CheckBox2"), CheckBox)
            Dim idLinea As Int32
            Dim CtaEnlace As Int32
            Dim Cta As Int32

            If ch.Checked = True Then
                If CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).SelectedValue.Length > 0 Then
                    CtaEnlace = PlanContableBL.GetPLANCONTABLEByCodigo(CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).SelectedValue).IdPlan
                    'grabamos las lineas
                    _Linea.IdTransaccion = Session("IdTransaccion")
                    _Linea.FechaDocumento = Me.RadGrid2.Items(i)("FechaDocumento").Text.ToString
                    _Linea.Glosa = CType(Me.RadGrid2.Items(i).FindControl("TextBox1"), TextBox).Text
                    _Linea.IdCCosto.Equals(DBNull.Value)
                    _Linea.IdPlan = CtaEnlace
                    _Linea.IdProveedorCliente = Me.RadGrid2.Items(i)("IdProveedorCliente").Text.ToString
                    _Linea.IdTipoDocumento = Me.RadGrid2.Items(i)("IdTipoDocumento").Text.ToString
                    If Me.RadGrid2.Items(i)("CargoMN").Text > 0 Then
                        If Me.RadGrid2.Items(i)("IdMoneda").Text.ToString = 1 Then
                            _Linea.MontoCargo = 0
                            _Linea.MontoAbono = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.CargoMN = 0
                            _Linea.AbonoMN = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.CargoME = 0
                            _Linea.AbonoME = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text / Me.RadNumericTextBox1.Text), 2)
                        Else
                            _Linea.MontoCargo = 0
                            _Linea.MontoAbono = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.CargoMN = 0
                            _Linea.AbonoMN = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text * Me.RadNumericTextBox1.Text), 2)
                            _Linea.CargoME = 0
                            _Linea.AbonoME = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                        End If

                    Else
                        If Me.RadGrid2.Items(i)("IdMoneda").Text.ToString = 1 Then
                            _Linea.MontoCargo = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.MontoAbono = 0
                            _Linea.CargoMN = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.AbonoMN = 0
                            _Linea.CargoME = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text / Me.RadNumericTextBox1.Text), 2)
                            _Linea.AbonoME = 0
                        Else
                            _Linea.MontoCargo = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.MontoAbono = 0
                            _Linea.CargoMN = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text * Me.RadNumericTextBox1.Text), 2)
                            _Linea.AbonoMN = 0
                            _Linea.CargoME = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.AbonoME = 0
                        End If

                    End If
                    _Linea.NroDocumento = Me.RadGrid2.Items(i)("NroDocumento").Text.ToString
                    _Linea.SerieDocumento = Me.RadGrid2.Items(i)("SerieDocumento").Text.ToString
                    _Linea.Estado = "C"
                    _Linea.Flag = "U"
                    _Linea.IdMoneda = Me.RadGrid2.Items(i)("IdMoneda").Text.ToString
                    _Linea.TipoCambio = Me.RadNumericTextBox1.Text
                    _Linea.Enlace = "S"
                    _Linea.CtaEnlace = Me.RadGrid2.Items(i)("Cuenta").Text.ToString

                    'verificamos si se esta cancelando el total del comprobante
                    If (Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoCargo Or Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoAbono) Then
                        'actualizamos el estado de la transaccion y de OCxFactura
                        TransaccionBL.CancelarCtaXCobrar(_Linea.IdTipoDocumento, _Linea.SerieDocumento, _Linea.NroDocumento, _Linea.IdProveedorCliente, "C")
                    End If
                    LineaBL.SaveLINEA(_Linea)

                Else
                    Cta = Me.RadGrid2.Items(i)("IdPlan").Text.ToString
                    'grabamos las lineas
                    _Linea.IdTransaccion = Session("IdTransaccion")
                    _Linea.FechaDocumento = Me.RadGrid2.Items(i)("FechaDocumento").Text.ToString
                    _Linea.Glosa = CType(Me.RadGrid2.Items(i).FindControl("TextBox1"), TextBox).Text
                    _Linea.IdCCosto.Equals(DBNull.Value)
                    _Linea.IdPlan = Cta
                    _Linea.IdProveedorCliente = Me.RadGrid2.Items(i)("IdProveedorCliente").Text.ToString
                    _Linea.IdTipoDocumento = Me.RadGrid2.Items(i)("IdTipoDocumento").Text.ToString
                    If Me.RadGrid2.Items(i)("CargoMN").Text > 0 Then
                        If Me.RadGrid2.Items(i)("IdMoneda").Text.ToString = 1 Then
                            _Linea.MontoCargo = 0
                            _Linea.MontoAbono = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.CargoMN = 0
                            _Linea.AbonoMN = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.CargoME = 0
                            _Linea.AbonoME = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text / Me.RadNumericTextBox1.Text), 2)
                        Else
                            _Linea.MontoCargo = 0
                            _Linea.MontoAbono = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.CargoMN = 0
                            _Linea.AbonoMN = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text * Me.RadNumericTextBox1.Text), 2)
                            _Linea.CargoME = 0
                            _Linea.AbonoME = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                        End If

                    Else
                        If Me.RadGrid2.Items(i)("IdMoneda").Text.ToString = 1 Then
                            _Linea.MontoCargo = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.MontoAbono = 0
                            _Linea.CargoMN = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.AbonoMN = 0
                            _Linea.CargoME = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text / Me.RadNumericTextBox1.Text), 2)
                            _Linea.AbonoME = 0
                        Else
                            _Linea.MontoCargo = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.MontoAbono = 0
                            _Linea.CargoMN = Decimal.Round(Decimal.Parse(CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text * Me.RadNumericTextBox1.Text), 2)
                            _Linea.AbonoMN = 0
                            _Linea.CargoME = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                            _Linea.AbonoME = 0
                        End If

                    End If
                    _Linea.NroDocumento = Me.RadGrid2.Items(i)("NroDocumento").Text.ToString
                    _Linea.SerieDocumento = Me.RadGrid2.Items(i)("SerieDocumento").Text.ToString
                    _Linea.Estado = "C"
                    _Linea.Flag = "U"
                    _Linea.IdMoneda = Me.RadGrid2.Items(i)("IdMoneda").Text.ToString
                    _Linea.TipoCambio = Me.RadNumericTextBox1.Text
                    _Linea.Enlace = "N"

                    'verificamos si se esta cancelando el total del comprobante
                    If (Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoCargo Or Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoAbono) Then
                        'actualizamos el estado de la transaccion y de OCxFactura
                        ' TransaccionBL.CancelarCtaXCobrar(_Linea.IdTipoDocumento, _Linea.SerieDocumento, _Linea.NroDocumento, _Linea.IdProveedorCliente, "C")
                    End If
                    LineaBL.SaveLINEA(_Linea)
                End If
                
            End If
        Next
        Me.RadGrid1.DataBind()
        Me.TextBox3.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo
        Me.RadGrid2.Visible = False
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
    '            Response.Redirect(Session("Ventana") + "?Flag=" + Flag.ToString)
    '        End If
    '    Else
    '        Response.Redirect(Session("Ventana") + "?Flag=" + Flag.ToString)
    '    End If

    'End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        If Session("IdTransaccion") > 0 Then
            If TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Then
                Dim cadena_java As String = _
                                          "<script type='text/javascript'> " & _
                                          " alert('¡Debe validar el Voucher!'); " & _
                                          Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            Else
                Session("Ventana") = "~\Contabilidad\Formularios\ListaCaja.aspx"
                Session("IdTransaccion") = 0
                Response.Redirect("~\Contabilidad\Formularios\FrmCajaIngresos.aspx?Flag=" + Flag.ToString)
            End If
        Else
            Session("Ventana") = "~\Contabilidad\Formularios\ListaCaja.aspx"
            Session("IdTransaccion") = 0
            Response.Redirect("~\Contabilidad\Formularios\FrmCajaIngresos.aspx?Flag=" + Flag.ToString)
        End If
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

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        If (Me.RadComboBox10.SelectedValue = 5 Or Me.RadComboBox10.SelectedValue = 57) Then
            TransaccionBL.GenerarDestinoDiario(Session("IdTransaccion"))
            Me.RadGrid1.Rebind()
        Else
            For i = 0 To Me.RadGrid1.Items.Count - 1
                'PARA CALCULAR EL TOTAL
                If CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda = 1 Then
                    SumDebe = SumDebe + Decimal.Parse(Me.RadGrid1.Items(i)("CargoMN").Text.ToString)
                    SumHaber = SumHaber + Decimal.Parse(Me.RadGrid1.Items(i)("AbonoMN").Text.ToString)
                    'total = total + Decimal.Parse(Me.RadGrid1.Items(i)("CargoMN").Text.ToString)

                Else
                    'total = total + Decimal.Parse(Me.RadGrid1.Items(i)("CargoME").Text.ToString)
                    SumDebe = SumDebe + Decimal.Parse(Me.RadGrid1.Items(i)("CargoME").Text.ToString)
                    SumHaber = SumHaber + Decimal.Parse(Me.RadGrid1.Items(i)("AbonoME").Text.ToString)
                End If

                TotalCaja = SumHaber - SumDebe
            Next

            'grabamos la linea de caja y bancos
            _Linea1.IdTransaccion = Session("IdTransaccion")
            _Linea1.FechaDocumento = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
            _Linea1.Glosa = Me.TextBox5.Text
            _Linea1.IdCCosto.Equals(DBNull.Value)
            _Linea1.IdPlan = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdPlan
            _Linea1.IdProveedorCliente.Equals(DBNull.Value)
            _Linea1.IdTipoDocumento.Equals(DBNull.Value)
            _Linea1.MontoCargo = TotalCaja
            _Linea1.MontoAbono = 0
            _Linea1.NroDocumento.Equals(DBNull.Value)
            _Linea1.SerieDocumento = ""
            _Linea1.TipoCambio = Me.RadNumericTextBox1.Text
            _Linea1.Flag = "B"
            _Linea1.Estado = "C"
            _Linea1.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
            LineaBL.SaveLINEA(_Linea1)
            LineaBL.GenerarLINEACaja(Session("IdTransaccion"))
            Me.RadGrid1.Rebind()
        End If

        
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
                If RadComboBox10.SelectedValue = 57 Or RadComboBox10.SelectedValue = 5 Then
                    registros = LineaBL.GetNumeroRegistrosFromLINEA1(Session("IdTransaccion")) 'para verificar si la transaccion contiene cuenta 9
                    If registros > 0 Then
                        registros = LineaBL.GetNumeroRegistrosFromLINEA(Session("IdTransaccion")) 'para verificar si la transaccion de cuenta 9 ya contiene cuentas de destino
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
                    registros = LineaBL.GetNumeroRegistrosFromLINEA(Session("IdTransaccion"))
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
                    'End If
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
        _Linea.Estado = "C"
        _Linea.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
        If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
            _Linea.Enlace = "S"
            _Linea.Flag = "E"
        Else
            _Linea.Enlace = "N"
            _Linea.Flag = "U"
        End If
        idLinea = LineaBL.SaveLINEA(_Linea)
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
        _Linea.TipoCambio = Me.RadNumericTextBox1.Text
        _Linea.Flag = "U"
        _Linea.Estado = "C"
        _Linea.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
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
        If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
            _Linea.Enlace = "S"
            _Linea.Flag = "E"
        Else
            _Linea.Enlace = "N"
            _Linea.Flag = "U"
        End If
        idLinea = LineaBL.SaveLINEA(_Linea)
        ' LineaBL.UpdateMontosLINEA1(idLinea)
    End Sub
    Protected Sub RadComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox3.SelectedIndexChanged
        Me.RadComboBox9.Text = ""
        Me.RadGrid2.DataBind()
    End Sub

    Protected Sub RadGrid2_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid2.DataBound
        Dim texto As String = ""
        For i = 0 To Me.RadGrid2.Items.Count - 1
            CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).Filter = 1
            CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).DataSourceID = "odsCuentaEnlace"
            CType(Me.RadGrid2.Items(i).FindControl("odsCuentaEnlace"), ObjectDataSource).SelectParameters("CtaOperacion").DefaultValue = PlanContableBL.GetCodigoFromPLANCONTABLE(Me.RadGrid2.Items(i)("IdPlan").Text).Codigo
            CType(Me.RadGrid2.Items(i).FindControl("odsCuentaEnlace"), ObjectDataSource).SelectParameters("Destino").DefaultValue = ProyectoBL.GetCodigoFromPROYECTO(Me.RadComboBox3.SelectedValue).Codigo
            CType(Me.RadGrid2.Items(i).FindControl("odsCuentaEnlace"), ObjectDataSource).SelectParameters("Tipo").DefaultValue = "I"
            CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).DataBind()
            If Me.RadGrid2.Items(i)("IdTipoDocumento").Text = 2 Then
                texto = "CANCELACION FACTURA "
            ElseIf Me.RadGrid2.Items(i)("IdTipoDocumento").Text = 4 Then
                texto = "CANCELACION BOLETA "
            End If
            CType(Me.RadGrid2.Items(i).FindControl("TextBox1"), TextBox).Text = texto + Me.RadGrid2.Items(i)("SerieDocumento").Text + " " + Me.RadGrid2.Items(i)("NroDocumento").Text

        Next
    End Sub
    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs)
        e.Item.Text = PlanContableBL.GetPLANCONTABLEByCodigo((DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.CuentaEnlace)).CtaCobrar.ToString()).Cuenta
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.CuentaEnlace)).CtaCobrar.ToString()
    End Sub
    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs)
        'Dim comboBox As RadComboBox = DirectCast(sender, RadComboBox)
        'If e.Text.Length > 2 Then

        '    For i = 0 To Me.RadGrid2.Items.Count - 1
        '        CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).Filter = 1
        '        CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).DataSourceID = "odsCuentaEnlace"
        '        CType(Me.RadGrid2.Items(i).FindControl("odsCuentaEnlace"), ObjectDataSource).SelectParameters("CtaEgreso").DefaultValue = Me.RadGrid2.Items(i)("IdPlan").Text
        '        CType(Me.RadGrid2.Items(i).FindControl("odsCuentaEnlace"), ObjectDataSource).SelectParameters("Destino").DefaultValue = Me.RadComboBox3.SelectedValue
        '        CType(Me.RadGrid2.Items(i).FindControl("odsCuentaEnlace"), ObjectDataSource).SelectParameters("Texto").DefaultValue = e.Text.ToString
        '        CType(Me.RadGrid2.Items(i).FindControl("RadComboBox1"), RadComboBox).DataBind()
        '        CType(Me.RadGrid2.Items(i).FindControl("TextBox1"), TextBox).Text = "Cancelacion Factura " + Me.RadGrid2.Items(i)("SerieDocumento").Text + " " + Me.RadGrid2.Items(i)("NroDocumento").Text

        '    Next
        '    comboBox.DataBind()
        'End If



    End Sub
    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "ActualizarLista" Then
            Me.RadComboBox8.DataBind()
        ElseIf e.Argument = "ValidarFecha" Then
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
                Me.RadComboBox9.Focus()
            End If
        ElseIf e.Argument = "Actualizar" Then
            Me.HiddenField1.Value = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda

        ElseIf e.Argument = "ActualizarGrilla" Then
            Me.RadGrid2.DataBind()
        End If
    End Sub

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Me.RadGrid2.Visible = False
    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('Voucher.aspx?Tipo=I'); " & _
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

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.RadGrid2.Visible = True
        Me.RadGrid2.DataSourceID = "SqlLineasCaja"
        If Me.RadComboBox11.Text.Length > 0 Then
            Me.SqlLineasCaja.SelectParameters("idProveedor").DefaultValue = Me.RadComboBox11.SelectedValue
        Else
            Me.SqlLineasCaja.SelectParameters("idProveedor").DefaultValue = Me.RadComboBox8.SelectedValue
        End If
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        Dim totalDebeMN As Decimal
        Dim totalhaberMN As Decimal
        Dim totalDebeME As Decimal
        Dim totalhaberME As Decimal
        Dim total As Decimal = 0
        Dim idLinea As Int32
        Dim disponible As Decimal = 0
        Dim monedaXPagar As Int32 = 0
        Dim monedaCaja As Int32 = 0
        Dim IdTransaccionEnlace As Int32
        Dim CrearTransaccionEnlace As String = "S"
        Dim origen As String
        Dim ctaEnlace As String
        Dim area As String
        Dim cuenta As Int32
        Dim codigo As String = ""
        Dim enlace As String = ""
        Dim plan As String = "N"
        Dim enlace1 As String

        Area = ProyectoBL.GetFromProyectoByIdProyecto(Me.RadComboBox3.SelectedValue).Codigo
        monedaCaja = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda

        For i = 0 To Me.RadGrid1.Items.Count - 1
            'PARA CALCULAR EL TOTAL
            totalDebeMN = totalDebeMN + Decimal.Parse(Me.RadGrid1.Items(i)("CargoMN").Text.ToString)
            totalhaberMN = totalhaberMN + Decimal.Parse(Me.RadGrid1.Items(i)("AbonoMN").Text.ToString)

            totalDebeME = totalDebeME + Decimal.Parse(Me.RadGrid1.Items(i)("CargoME").Text.ToString)
            totalhaberME = totalhaberME + Decimal.Parse(Me.RadGrid1.Items(i)("AbonoME").Text.ToString)

        Next

        If (totalDebeMN <> totalhaberMN And CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda = 1) Then
            Dim cadena_java As String = _
                                     "<script type='text/javascript'> " & _
                                     " Alerta('¡No coinciden los Montos, Debe Cuadrar el Voucher!'); " & _
                                     Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "S")
        ElseIf (totalDebeME <> totalhaberME And CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda = 2) Then
            Dim cadena_java As String = _
                                     "<script type='text/javascript'> " & _
                                     " Alerta('¡No coinciden los Montos, Debe Cuadrar el Voucher!'); " & _
                                     Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "S")
        Else
            TransaccionBL.CuadrarVoucherCaja(Session("IdTransaccion"))
            Me.RadGrid1.Rebind()
            If Me.TextBox2.Text.Length = 0 Then

                For i = 0 To Me.RadGrid1.Items.Count - 1
                    'para verificar si la linea es de enlace
                    If Me.RadGrid1.Items(i)("Enlace").Text = "S" Then
                        'para sacar el idplan de la primera linea chequeada

                        If plan <> Me.RadGrid1.Items(i)("IdPlan").Text Then
                            'grabamos la transaccion de enlace
                            _Transaccion.Anio = Session("Anio")
                            _Transaccion.BaseImponible = 0
                            _Transaccion.BaseInafecto = 0
                            _Transaccion.IdCtaBancaria = Me.RadComboBox9.SelectedValue
                            _Transaccion.DiasVencimiento = 0
                            _Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
                            _Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
                            _Transaccion.FechaDocumento = FormatDateTime("01/01/1900", DateFormat.LongDate)
                            _Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
                            _Transaccion.Flag = "I"
                            _Transaccion.Glosa = "ASIENTO AUTOMÁTICO 16-46"
                            _Transaccion.IdDetraccion.Equals(DBNull.Value)
                            _Transaccion.IdDocumentoCont.Equals(DBNull.Value)
                            _Transaccion.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text
                            _Transaccion.IdOpFinanciera = 3 'CUENTAS POR COBRAR
                            _Transaccion.IdOrdenCompra.Equals(DBNull.Value)
                            _Transaccion.IdPersonal.Equals(DBNull.Value)
                            _Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
                            _Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
                            _Transaccion.IdSubDiario = 57 'INGRESOS AUTOMATICO
                            _Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
                            _Transaccion.IdTipoDocRef.Equals(DBNull.Value)
                            _Transaccion.Mes = Session("Mes")
                            _Transaccion.MontoIgv = 0
                            _Transaccion.MontoRetencion = 0
                            _Transaccion.NroCheque = ""
                            _Transaccion.NroDocRef.Equals(DBNull.Value)
                            _Transaccion.NroDocumento.Equals(DBNull.Value)
                            _Transaccion.NroExoneracion = ""
                            _Transaccion.Otros = 0
                            _Transaccion.SerieDocRef = ""
                            _Transaccion.SerieDocumento = ""
                            _Transaccion.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            _Transaccion.TipoCambioDocRef = 0
                            _Transaccion.Total = 0
                            _Transaccion.Usuario = Session("IdUser")
                            _Transaccion.ValorIgv = 0

                            IdTransaccionEnlace = TransaccionBL.SaveTransaccion(_Transaccion)
                            TransaccionBL.UpdateEstadoTRANSACCION(IdTransaccionEnlace, "P")
                            codigo = TransaccionBL.GetTransaccionByIdTransaccion(IdTransaccionEnlace).IdSubDiario.ToString + "-" + TransaccionBL.GetTransaccionByIdTransaccion(IdTransaccionEnlace).Codigo
                            'para actualizar el campo enlace en la transaccion
                            enlace = enlace + "/" + Session("Anio").ToString + "-" + Session("Mes").ToString + "-" + codigo.ToString

                        End If

                        If Me.RadGrid1.Items(i)("Flag").Text = "E" Then
                            'grabamos las lineas del cargo
                            _Linea2.IdTransaccion = IdTransaccionEnlace
                            _Linea2.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea2.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea2.IdCCosto.Equals(DBNull.Value)

                            ctaEnlace = PlanContableBL.GetPLANCONTABLEByIdPlan(Me.RadGrid1.Items(i)("IdPlan").Text).Codigo
                            cuenta = PlanContableBL.GetPLANCONTABLEByCodigo(CuentaEnlaceBL.GetCtaPagarByCtaCobrarAndDestino(ctaEnlace, area, "I")).IdPlan
                            _Linea2.IdPlan = cuenta
                            _Linea2.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            If Not Me.RadGrid1.Items(i)("IdTipoDocumento").Text = "" Then
                                _Linea2.IdTipoDocumento = Int32.Parse(Me.RadGrid1.Items(i)("IdTipoDocumento").Text)
                            End If
                            _Linea2.MontoAbono = 0
                            _Linea2.MontoCargo = Me.RadGrid1.Items(i)("Abono").Text
                            If Not Me.RadGrid1.Items(i)("NroDocumento").Text = "" Then
                                _Linea2.NroDocumento = Int32.Parse(Me.RadGrid1.Items(i)("NroDocumento").Text)
                            End If
                            _Linea2.SerieDocumento = Me.RadGrid1.Items(i)("SerieDocumento").Text
                            _Linea2.Flag = "E"
                            _Linea2.Estado = "C"
                            _Linea2.Enlace = "N"
                            _Linea2.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text.ToString
                            _Linea2.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            idLinea = LineaBL.SaveLINEA(_Linea2)

                            'grabamos las lineas del abono
                            _Linea1.IdTransaccion = IdTransaccionEnlace
                            _Linea1.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea1.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea1.IdCCosto.Equals(DBNull.Value)

                            ctaEnlace = PlanContableBL.GetPLANCONTABLEByIdPlan(Me.RadGrid1.Items(i)("IdPlan").Text).Codigo
                            cuenta = PlanContableBL.GetPLANCONTABLEByCodigo(CuentaEnlaceBL.GetCtaOperacionByCtaCobrarAndDestino(ctaEnlace, area, "I")).IdPlan
                            _Linea1.IdPlan = cuenta
                            _Linea1.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            If Not Me.RadGrid1.Items(i)("IdTipoDocumento").Text = "" Then
                                _Linea2.IdTipoDocumento = Int32.Parse(Me.RadGrid1.Items(i)("IdTipoDocumento").Text)
                            End If
                            _Linea1.MontoAbono = Me.RadGrid1.Items(i)("Abono").Text
                            _Linea1.MontoCargo = 0
                            If Not Me.RadGrid1.Items(i)("NroDocumento").Text = "" Then
                                _Linea2.NroDocumento = Int32.Parse(Me.RadGrid1.Items(i)("NroDocumento").Text)
                            End If
                            _Linea1.SerieDocumento = Me.RadGrid1.Items(i)("SerieDocumento").Text
                            _Linea1.Flag = "E"
                            _Linea1.Estado = "C"
                            _Linea1.Enlace = "N"
                            _Linea1.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text.ToString
                            _Linea1.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            idLinea = LineaBL.SaveLINEA(_Linea1)

                            'CrearTransaccionEnlace = "N"
                            plan = Me.RadGrid1.Items(i)("IdPlan").Text
                            origen = CuentaEnlaceBL.GetOrigenCtaEnlace1(Me.RadGrid1.Items(i)("IdPlan").Text, area)
                        Else
                            'grabamos las lineas del cargo
                            _Linea2.IdTransaccion = IdTransaccionEnlace
                            _Linea2.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea2.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea2.IdCCosto.Equals(DBNull.Value)


                            ctaEnlace = PlanContableBL.GetPLANCONTABLEByIdPlan(Me.RadGrid1.Items(i)("IdPlan").Text).Codigo
                            '   ctaEnlace1 = PlanContableBL.GetPLANCONTABLEByIdPlan(LineaBL.GetLINEAByRegistro(Me.RadGrid1.Items(i)("Registro").Text, Me.RadGrid1.Items(i)("Coa").Text, Me.RadGrid1.Items(i)("CtaEnlace").Text).IdPlan).Codigo
                            cuenta = PlanContableBL.GetPLANCONTABLEByCodigo(CuentaEnlaceBL.GetCUENTAENLACEByCtaOperacionAndCtaCobrar(Me.RadGrid1.Items(i)("CtaEnlace").Text, area, ctaEnlace, "I").CtaPagar).IdPlan

                            _Linea2.IdPlan = cuenta
                            _Linea2.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            _Linea2.IdTipoDocumento = Me.RadGrid1.Items(i)("IdTipoDocumento").Text
                            _Linea2.MontoAbono = 0
                            _Linea2.MontoCargo = Me.RadGrid1.Items(i)("Abono").Text
                            _Linea2.NroDocumento = Me.RadGrid1.Items(i)("NroDocumento").Text
                            _Linea2.SerieDocumento = Me.RadGrid1.Items(i)("SerieDocumento").Text
                            _Linea2.Flag = "E"
                            _Linea2.Estado = "C"
                            _Linea.Enlace = "N"
                            _Linea2.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text.ToString
                            _Linea2.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            idLinea = LineaBL.SaveLINEA(_Linea2)


                            'grabamos las lineas del abono
                            _Linea1.IdTransaccion = IdTransaccionEnlace
                            _Linea1.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea1.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea1.IdCCosto.Equals(DBNull.Value)
                            _Linea1.IdPlan = LineaBL.GetLINEAByRegistro(Me.RadGrid1.Items(i)("Registro").Text, Me.RadGrid1.Items(i)("Coa").Text, Me.RadGrid1.Items(i)("CtaEnlace").Text).IdPlan
                            _Linea1.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            _Linea1.IdTipoDocumento = Me.RadGrid1.Items(i)("IdTipoDocumento").Text
                            _Linea1.MontoAbono = Me.RadGrid1.Items(i)("Abono").Text
                            _Linea1.MontoCargo = 0
                            _Linea1.NroDocumento = Me.RadGrid1.Items(i)("NroDocumento").Text
                            _Linea1.SerieDocumento = Me.RadGrid1.Items(i)("SerieDocumento").Text
                            _Linea1.Flag = "E"
                            _Linea1.Estado = "C"
                            _Linea.Enlace = "N"
                            _Linea1.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text.ToString
                            _Linea1.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            idLinea = LineaBL.SaveLINEA(_Linea1)
                            plan = Me.RadGrid1.Items(i)("IdPlan").Text
                            origen = CuentaEnlaceBL.GetOrigenCtaEnlace1(Me.RadGrid1.Items(i)("IdPlan").Text, area)
                        End If
                        'para actualizar el proyecto en la transaccion de enlace

                        TransaccionBL.UpdateProyectoTRANSACCION(IdTransaccionEnlace, origen)

                        'Para actualizar el enlace
                        enlace1 = Session("Anio").ToString + "-" + Session("Mes").ToString + "-" + Me.RadComboBox10.SelectedValue.ToString + "-" + Me.TextBox3.Text
                        TransaccionBL.UpdateEnlaceTRANSACCION(IdTransaccionEnlace, enlace1)
                    End If

                Next
                'para sacar el codigo de la transaccion de enlace
                If IdTransaccionEnlace > 0 Then
                    TransaccionBL.UpdateEnlaceTRANSACCION(Session("IdTransaccion"), enlace)
                    Me.TextBox2.Text = enlace
                    Dim cadena_java As String = _
                                           "<script type='text/javascript'> " & _
                                           " Alerta('Se ha generado el asiento automático: " + enlace.ToString + "'); " & _
                                           Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                Else
                    Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡Voucher " + Me.RadComboBox10.SelectedValue.ToString + "-" + Me.TextBox3.Text.ToString + "  creado correctamente!'); " & _
                                      Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                    TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "P")
                End If
            Else
                Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡Voucher " + Me.RadComboBox10.SelectedValue.ToString + "-" + Me.TextBox3.Text.ToString + "  creado correctamente!'); " & _
                                      Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "P")
            End If

        End If
    End Sub
End Class