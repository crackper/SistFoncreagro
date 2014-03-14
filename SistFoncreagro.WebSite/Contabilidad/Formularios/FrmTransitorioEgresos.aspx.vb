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
Public Class FrmTransitorioEgresos
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL
    Dim ParametroBL As New ParametrosBL
    Dim TransaccionBL As New TransaccionBL
    Dim CuentaEnlaceBL As New CuentaEnlaceBL
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    Dim ProveedorBL As New ProveedorClienteBL
    Dim _Transaccion As New Transaccion
    Dim Transaccion As Transaccion
    Dim _Linea As New Linea
    Dim _Linea1 As New Linea
    Dim _Linea2 As New Linea
    Dim _Linea3 As New Linea
    Dim Linea As Linea
    Dim LineaBL As New LineaBL
    Dim CtaBancaria As CuentaBancaria
    Dim CtaBancariaBL As New CuentaBancariaBL
    Dim CtaBancariaProyecto As New CtaBancariaProyectoBL
    Dim IdTransaccion As String
    Dim Flag As String
    Dim sumaCargoMN As Decimal
    Dim sumaCargoME As Decimal
    Dim sumaAbonoMN As Decimal
    Dim sumaAbonoME As Decimal
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

        'para agregarle un evento
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")
        Me.txtDate.Attributes.Add("onChange", "ValidarFecha();")

        If Page.IsPostBack = False Then
            Me.DropDownList1.Focus()
            Me.txtDate.Text = Session("Fecha").ToString
            Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Session("Fecha").ToString)


            If Session("IdTransaccion") > 0 Then
                'para recuperar datos de transaccion
                Transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
                Me.DropDownList1.SelectedValue = Transaccion.IdOpFinanciera
                Me.RadComboBox10.SelectedValue = Transaccion.IdSubDiario
                Me.RadComboBox10.Enabled = False
                Me.TextBox3.Text = Transaccion.Codigo
                Me.RadComboBox3.SelectedValue = Transaccion.IdProyecto
                Me.txtDate.Text = Transaccion.FechaContable
                Me.RadComboBox9.DataSourceID = "SqlCuentaBancaria"
                Me.RadComboBox9.DataBind()
                Me.RadComboBox9.SelectedValue = Transaccion.IdCtaBancaria

                _Proveedor = Proveedor.GetAllFromProveedorClienteById(Transaccion.IdProveedorCliente)
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = Transaccion.IdProveedorCliente

                Me.RadNumericTextBox1.Text = Transaccion.TipoCambio
                Me.TextBox5.Text = Transaccion.Glosa
                Me.HiddenField1.Value = Transaccion.IdMoneda
            Else
                Me.DropDownList1.SelectedValue = 1
                Me.RadComboBox10.SelectedValue = 65

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
            Dim Cta As Int32
            Dim CtaEnlace As Int32
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
                    If Me.RadGrid2.Items(i)("IdTipoDocumento").Text.ToString <> "" Then
                        _Linea.IdTipoDocumento = Me.RadGrid2.Items(i)("IdTipoDocumento").Text.ToString
                    End If

                    'If _Linea.IdTipoDocumento = 8 Then
                    '    _Linea.MontoCargo = 0
                    '    _Linea.MontoAbono = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                    'Else
                    '    _Linea.MontoCargo = CType(Me.RadGrid2.Items(i).FindControl("MontoIngresado"), RadNumericTextBox).Text
                    '    _Linea.MontoAbono = 0
                    'End If
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

                    If Me.RadGrid2.Items(i)("NroDocumento").Text.ToString <> "" Then
                        _Linea.NroDocumento = Me.RadGrid2.Items(i)("NroDocumento").Text.ToString
                    End If
                    _Linea.SerieDocumento = Me.RadGrid2.Items(i)("SerieDocumento").Text.ToString
                    _Linea.Estado = "C"
                    _Linea.Flag = "U"
                    _Linea.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
                    _Linea.TipoCambio = Me.RadNumericTextBox1.Text
                    _Linea.Enlace = "S"
                    _Linea.CtaEnlace = Me.RadGrid2.Items(i)("Cuenta").Text.ToString

                    LineaBL.SaveLINEA(_Linea)


                    'verificamos si se esta cancelando el total del comprobante
                    If (Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoCargo Or Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoAbono) Then
                        'actualizamos el estado de la transaccion y de OCxFactura
                        TransaccionBL.CancelarCtaXPagar(_Linea.IdTipoDocumento, _Linea.SerieDocumento, _Linea.NroDocumento, _Linea.IdProveedorCliente, "C")
                    End If
                Else
                    Cta = Me.RadGrid2.Items(i)("IdPlan").Text.ToString
                    'grabamos las lineas
                    _Linea.IdTransaccion = Session("IdTransaccion")
                    _Linea.FechaDocumento = Me.RadGrid2.Items(i)("FechaDocumento").Text.ToString
                    _Linea.Glosa = CType(Me.RadGrid2.Items(i).FindControl("TextBox1"), TextBox).Text
                    _Linea.IdCCosto.Equals(DBNull.Value)
                    _Linea.IdPlan = Cta
                    _Linea.IdProveedorCliente = Me.RadGrid2.Items(i)("IdProveedorCliente").Text.ToString
                    If Me.RadGrid2.Items(i)("IdTipoDocumento").Text.ToString <> "" Then
                        _Linea.IdTipoDocumento = Me.RadGrid2.Items(i)("IdTipoDocumento").Text.ToString
                    End If

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
                    If Me.RadGrid2.Items(i)("NroDocumento").Text.ToString <> "" Then
                        _Linea.NroDocumento = Me.RadGrid2.Items(i)("NroDocumento").Text.ToString
                    End If
                    _Linea.SerieDocumento = Me.RadGrid2.Items(i)("SerieDocumento").Text.ToString
                    _Linea.Estado = "C"
                    _Linea.Flag = "U"
                    _Linea.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
                    _Linea.TipoCambio = Me.RadNumericTextBox1.Text
                    _Linea.Enlace = "N"

                    LineaBL.SaveLINEA(_Linea)

                    'verificamos si se esta cancelando el total del comprobante
                    If (Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoCargo Or Me.RadGrid2.Items(i)("Monto").Text.ToString = _Linea.MontoAbono) Then
                        'actualizamos el estado de la transaccion y de OCxFactura
                        TransaccionBL.CancelarCtaXPagar(_Linea.IdTipoDocumento, _Linea.SerieDocumento, _Linea.NroDocumento, _Linea.IdProveedorCliente, "C")
                    End If
                End If

            End If

        Next
        Me.RadGrid1.DataBind()
        Me.TextBox3.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo
        Me.RadGrid2.Visible = False
        Me.RadGrid2.DataBind()
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
                Session("Ventana") = "~\Contabilidad\Formularios\ListaTransitorios.aspx"
                Session("IdTransaccion") = 0
                Response.Redirect("~\Contabilidad\Formularios\FrmTransitorioEgresos.aspx?Flag=" + Flag.ToString)
            End If
        Else
            Session("Ventana") = "~\Contabilidad\Formularios\ListaTransitorios.aspx"
            Session("IdTransaccion") = 0
            Response.Redirect("~\Contabilidad\Formularios\FrmTransitorioEgresos.aspx?Flag=" + Flag.ToString)
        End If

    End Sub
    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32

        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdLinea")
        LineaBL.DeleteLINEA(id)

    End Sub
    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
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

            TotalCaja = SumDebe - SumHaber
        Next

        'validamos si el proyecto cuenta con saldo
        Dim SaldoProyecto As Decimal
        Dim Diferencia As Decimal

        SaldoProyecto = CtaBancariaProyecto.GetSaldosCuentasBancarias(Me.RadComboBox9.SelectedValue, Me.RadComboBox3.SelectedValue, Session("Fecha")).Saldo
        Diferencia = SaldoProyecto - TotalCaja

        If SaldoProyecto >= TotalCaja Then
            'grabamos la linea de caja y bancos
            _Linea3.IdTransaccion = Session("IdTransaccion")
            _Linea3.FechaDocumento = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
            _Linea3.Glosa = Me.TextBox5.Text
            _Linea3.IdCCosto.Equals(DBNull.Value)
            _Linea3.IdPlan = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdPlan
            _Linea3.IdProveedorCliente.Equals(DBNull.Value)
            _Linea3.IdTipoDocumento.Equals(DBNull.Value)
            _Linea3.MontoAbono = TotalCaja
            _Linea3.MontoCargo = 0
            _Linea3.NroDocumento.Equals(DBNull.Value)
            _Linea3.SerieDocumento = ""
            _Linea3.TipoCambio = Me.RadNumericTextBox1.Text
            _Linea3.Flag = "B"
            _Linea3.Estado = "C"
            _Linea3.IdMoneda = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
            LineaBL.SaveLINEA(_Linea3)
            LineaBL.GenerarLINEACaja(Session("IdTransaccion"))
            Me.RadGrid1.Rebind()
        Else
            Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " alert('¡El Proyecto no cuenta con saldo suficiente para cubrir el monto del desembolso! \n \n Saldo disponible: " + SaldoProyecto.ToString + " \n Monto a desembolsar: " + TotalCaja.ToString + " \n Diferencia: " + Diferencia.ToString + "'); " & _
                                      Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
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
                    Me.RadComboBox9.Enabled = False
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
                    Me.RadComboBox9.Enabled = True
                    End If
                    'End If
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
    End Sub
    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs)
        e.Item.Text = PlanContableBL.GetPLANCONTABLEByCodigo((DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.CuentaEnlace)).CtaPagar.ToString()).Cuenta
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.CuentaEnlace)).CtaPagar.ToString()
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

    Protected Sub RadComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox3.SelectedIndexChanged
        Me.RadComboBox9.Text = ""
    End Sub
    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "ActualizarLista" Then
            Me.RadComboBox8.DataBind()
        ElseIf e.Argument = "ActualizarLineas" Then
            Me.RadGrid1.DataBind()
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

            End If
        ElseIf e.Argument = "Actualizar" Then
            Me.HiddenField1.Value = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
            ' MsgBox(Me.HiddenField1.Value)
        End If

    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
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
    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        Dim totalDebeMN As Decimal
        Dim totalhaberMN As Decimal
        Dim totalDebeME As Decimal
        Dim totalhaberME As Decimal
        Dim total As Decimal = 0
        Dim disponible As Decimal = 0
        Dim monedaXPagar As Int32 = 0
        Dim monedaCaja As Int32 = 0
        Dim idLinea As Int32
        Dim IdTransaccionEnlace As Int32
        Dim CrearTransaccionEnlace As String = "S"
        Dim origen As String
        Dim ctaEnlace As String
        Dim area As String
        Dim cuenta As Int32
        Dim plan As String = "N"
        Dim codigo As String = ""
        Dim enlace As String = ""
        Dim enlace1 As String
        Dim cheque As String

        area = ProyectoBL.GetFromProyectoByIdProyecto(Me.RadComboBox3.SelectedValue).Codigo
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
                'para verificar si la linea es de enlace
                For i = 0 To Me.RadGrid1.Items.Count - 1
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
                            _Transaccion.Flag = "E"
                            _Transaccion.Glosa = "ASIENTO AUTOMÁTICO 46-16"
                            _Transaccion.IdDetraccion.Equals(DBNull.Value)
                            _Transaccion.IdDocumentoCont.Equals(DBNull.Value)
                            _Transaccion.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text
                            _Transaccion.IdOpFinanciera = 2 'CUENTAS POR PAGAR
                            _Transaccion.IdOrdenCompra.Equals(DBNull.Value)
                            _Transaccion.IdPersonal.Equals(DBNull.Value)
                            _Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
                            _Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
                            _Transaccion.IdSubDiario = 58 'EGRESOS AUTOMATICO
                            _Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
                            _Transaccion.IdTipoDocRef.Equals(DBNull.Value)
                            _Transaccion.Mes = Session("Mes")
                            _Transaccion.MontoIgv = 0
                            _Transaccion.MontoRetencion = 0
                            ' _Transaccion.NroCheque = Me.TextBox4.Text
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
                            ' _Transaccion.IdTipoMedioPago = Me.RadComboBox12.SelectedValue

                            IdTransaccionEnlace = TransaccionBL.SaveTransaccion(_Transaccion)
                            TransaccionBL.UpdateEstadoTRANSACCION(IdTransaccionEnlace, "P")
                            codigo = TransaccionBL.GetTransaccionByIdTransaccion(IdTransaccionEnlace).IdSubDiario.ToString + "-" + TransaccionBL.GetTransaccionByIdTransaccion(IdTransaccionEnlace).Codigo
                            'para actualizar el campo enlace en la transaccion
                            enlace = enlace + "/" + Session("Anio").ToString + "-" + Session("Mes").ToString + "-" + codigo.ToString
                        End If


                        If Me.RadGrid1.Items(i)("Flag").Text = "E" Then
                            'para sacar la cuenta de enlace
                            ctaEnlace = PlanContableBL.GetPLANCONTABLEByIdPlan(Me.RadGrid1.Items(i)("IdPlan").Text).Codigo
                            cuenta = PlanContableBL.GetPLANCONTABLEByCodigo(CuentaEnlaceBL.GetCtaCobrarByCtaPagarAndDestino(ctaEnlace, area, "E")).IdPlan

                            'grabamos las lineas del abono
                            _Linea1.IdTransaccion = IdTransaccionEnlace
                            _Linea1.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea1.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea1.IdCCosto.Equals(DBNull.Value)
                            _Linea1.IdPlan = cuenta
                            _Linea1.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            If Not Me.RadGrid1.Items(i)("IdTipoDocumento").Text = "" Then
                                _Linea2.IdTipoDocumento = Int32.Parse(Me.RadGrid1.Items(i)("IdTipoDocumento").Text)
                            End If
                            _Linea1.MontoAbono = Me.RadGrid1.Items(i)("Cargo").Text
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

                            'grabamos las lineas del cargo
                            _Linea2.IdTransaccion = IdTransaccionEnlace
                            _Linea2.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea2.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea2.IdCCosto.Equals(DBNull.Value)
                            _Linea2.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            'para sacar la cuenta de enlace
                            Dim m As Int32

                            m = CtaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.RadComboBox9.SelectedValue).IdMoneda
                            If m = 1 And Me.RadComboBox10.SelectedValue = 1 Then
                                _Linea2.IdPlan = PlanContableBL.GetPLANCONTABLEByCodigo("141301").IdPlan
                            ElseIf m = 2 And Me.RadComboBox10.SelectedValue = 1 Then
                                _Linea2.IdPlan = PlanContableBL.GetPLANCONTABLEByCodigo("141302").IdPlan
                            ElseIf m = 1 And Me.RadComboBox10.SelectedValue = 54 Then
                                _Linea2.IdPlan = PlanContableBL.GetPLANCONTABLEByCodigo("422101").IdPlan
                            ElseIf m = 2 And Me.RadComboBox10.SelectedValue = 54 Then
                                _Linea2.IdPlan = PlanContableBL.GetPLANCONTABLEByCodigo("422102").IdPlan
                            Else
                                ctaEnlace = PlanContableBL.GetPLANCONTABLEByIdPlan(Me.RadGrid1.Items(i)("IdPlan").Text).Codigo
                                cuenta = PlanContableBL.GetPLANCONTABLEByCodigo(CuentaEnlaceBL.GetCtaOperacionByCtaPagarAndDestino(ctaEnlace, area, "E")).IdPlan
                                _Linea2.IdPlan = cuenta
                            End If
                            If (Me.RadComboBox10.SelectedValue = 1 Or Me.RadComboBox10.SelectedValue = 54) Then
                                _Linea2.IdTipoDocumento = 1
                            Else
                                If Not Me.RadGrid1.Items(i)("IdTipoDocumento").Text = "" Then
                                    _Linea2.IdTipoDocumento = Int32.Parse(Me.RadGrid1.Items(i)("IdTipoDocumento").Text)
                                End If
                            End If
                            _Linea2.MontoAbono = 0
                            _Linea2.MontoCargo = Me.RadGrid1.Items(i)("Cargo").Text
                            _Linea2.Flag = "E"
                            _Linea2.Estado = "P"
                            _Linea2.Enlace = "N"
                            _Linea2.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text.ToString
                            _Linea2.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            idLinea = LineaBL.SaveLINEA(_Linea2)

                            'CrearTransaccionEnlace = "N"
                            plan = Me.RadGrid1.Items(i)("IdPlan").Text

                        Else
                            'grabamos las lineas del cargo
                            _Linea1.IdTransaccion = IdTransaccionEnlace
                            _Linea1.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea1.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea1.IdCCosto.Equals(DBNull.Value)
                            _Linea1.IdPlan = LineaBL.GetLINEAByRegistro(Me.RadGrid1.Items(i)("Registro").Text, Me.RadGrid1.Items(i)("Coa").Text, Me.RadGrid1.Items(i)("CtaEnlace").Text).IdPlan
                            _Linea1.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            _Linea1.IdTipoDocumento = Me.RadGrid1.Items(i)("IdTipoDocumento").Text
                            _Linea1.MontoAbono = 0
                            _Linea1.MontoCargo = Me.RadGrid1.Items(i)("Cargo").Text
                            _Linea1.NroDocumento = Me.RadGrid1.Items(i)("NroDocumento").Text
                            _Linea1.SerieDocumento = Me.RadGrid1.Items(i)("SerieDocumento").Text
                            _Linea1.Flag = "E"
                            _Linea1.Estado = "C"
                            _Linea1.Enlace = "N"
                            _Linea1.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text.ToString
                            _Linea1.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            idLinea = LineaBL.SaveLINEA(_Linea1)

                            'grabamos las lineas del abono
                            _Linea2.IdTransaccion = IdTransaccionEnlace
                            _Linea2.FechaDocumento = Me.RadGrid1.Items(i)("FechaDocumento").Text
                            _Linea2.Glosa = Me.RadGrid1.Items(i)("Glosa").Text
                            _Linea2.IdCCosto.Equals(DBNull.Value)

                            'para sacar la cuenta de enlace
                            ctaEnlace = PlanContableBL.GetPLANCONTABLEByIdPlan(Me.RadGrid1.Items(i)("IdPlan").Text).Codigo
                            ' ctaEnlace1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_Linea1.IdPlan).Codigo
                            cuenta = PlanContableBL.GetPLANCONTABLEByCodigo(CuentaEnlaceBL.GetCUENTAENLACEByCtaOperacionAndCtaPagar(Me.RadGrid1.Items(i)("CtaEnlace").Text, area, ctaEnlace, "E").CtaCobrar).IdPlan
                            _Linea2.IdPlan = cuenta
                            _Linea2.IdProveedorCliente = Me.RadGrid1.Items(i)("IdProveedorCliente").Text
                            _Linea2.IdTipoDocumento = Me.RadGrid1.Items(i)("IdTipoDocumento").Text
                            _Linea2.MontoAbono = Me.RadGrid1.Items(i)("Cargo").Text
                            _Linea2.MontoCargo = 0
                            _Linea2.NroDocumento = Me.RadGrid1.Items(i)("NroDocumento").Text
                            _Linea2.SerieDocumento = Me.RadGrid1.Items(i)("SerieDocumento").Text
                            _Linea2.Flag = "E"
                            _Linea2.Estado = "C"
                            _Linea2.Enlace = "N"
                            _Linea2.IdMoneda = Me.RadGrid1.Items(i)("IdMoneda").Text.ToString
                            _Linea2.TipoCambio = Me.RadGrid1.Items(i)("TipoCambio").Text.ToString
                            idLinea = LineaBL.SaveLINEA(_Linea2)
                            plan = Me.RadGrid1.Items(i)("IdPlan").Text

                        End If
                        'para actualizar el proyecto en la transaccion de enlace
                        origen = CuentaEnlaceBL.GetOrigenCtaEnlace(Me.RadGrid1.Items(i)("IdPlan").Text, area)
                        TransaccionBL.UpdateProyectoTRANSACCION(IdTransaccionEnlace, origen)

                        'Para actualizar el enlace
                        enlace1 = Session("Anio").ToString + "-" + Session("Mes").ToString + "-" + Me.RadComboBox10.SelectedValue.ToString + "-" + Me.TextBox3.Text
                        TransaccionBL.UpdateEnlaceTRANSACCION(IdTransaccionEnlace, enlace1)
                    End If
                Next

                ' para sacar el codigo de la transaccion de enlace
                If IdTransaccionEnlace > 0 Then
                    TransaccionBL.UpdateEnlaceTRANSACCION(Session("IdTransaccion"), enlace)
                    TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "P")
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

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Me.RadGrid2.Visible = False
    End Sub
End Class
