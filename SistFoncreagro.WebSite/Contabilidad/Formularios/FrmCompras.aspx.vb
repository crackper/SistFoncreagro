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
Public Class FrmCompras
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL
    Dim ParametroBL As New ParametrosBL
    Dim TransaccionBL As New TransaccionBL
    Dim Transaccion As New Transaccion
    Dim _Transaccion As Transaccion
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    Dim _Linea As New Linea
    Dim LineaBL As New LineaBL
    Dim _DocumentoContabilizado As DocumentoContabilizado
    Dim DocumentoContabilizadoBL As New DocumentoContabilizadoBL
    Dim IGV As Decimal
    Dim IdTransaccion As String
    Dim _PlanContable As New PlanContable
    Dim Edit As String
    Dim registros As Int32
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.ImageButton3.Visible = False
            Me.ImageButton4.Visible = False
            Me.ImageButton5.Visible = False
            Me.ImageButton6.Visible = False
            Me.ImageButton13.Visible = False
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If

        'para agregarle un evento al boton registrar clientes
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")

        'para agregar un evento 
        Me.txtDate.Attributes.Add("onChange", "ValidarFecha();")
        Me.TextBox5.Attributes.Add("onChange", "ponerCeros();")
        Me.TextBox6.Attributes.Add("onChange", "ponerCeros1();")
        Me.DropDownList3.Attributes.Add("onChange", "Calcular();")
        ' Me.TextBox3.Attributes.Add("onFocus", "ValidarDocumento();")

        'para obtener el valor del IGV
        IGV = ParametroBL.GetPARAMETROSByNombre("IGV").valor
        Me.RadNumericTextBox8.Text = IGV

        Me.RadComboBox3.Filter = 1
        Me.RadComboBox6.Filter = 1
        Me.RadComboBox8.Filter = 1
        Me.RadComboBox9.Filter = 1
        Me.RadComboBox11.Filter = 1

        If Page.IsPostBack = False Then
            Me.txtDate.Text = Session("Fecha").ToString
            Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Session("Fecha").ToString)
            Me.DropDownList1.SelectedValue = 2
            Me.DropDownList2.SelectedValue = 2
            Me.DropDownList3.SelectedValue = 3

            If Session("IdTransaccion") > 0 Then

                'para recuperar datos de transaccion
                _Transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
                Me.DropDownList1.SelectedValue = _Transaccion.IdOpFinanciera
                Me.DropDownList2.SelectedValue = _Transaccion.IdSubDiario
                Me.TextBox1.Text = _Transaccion.Codigo
                Me.RadComboBox3.SelectedValue = _Transaccion.IdProyecto
                Me.txtDate.Text = _Transaccion.FechaContable
                Me.RadComboBox6.SelectedValue = _Transaccion.IdDocumentoCont
                Me.TextBox5.Text = _Transaccion.SerieDocumento
                Me.TextBox2.Text = _Transaccion.NroDocumento
                Me.txtDate1.Text = _Transaccion.FechaDocumento
                Me.txtDate2.Text = _Transaccion.FechaVencimiento
                Me.RadNumericTextBox1.Text = _Transaccion.TipoCambio
                Me.txtDate2.Text = _Transaccion.FechaVencimiento

                _Proveedor = Proveedor.GetAllFromProveedorClienteById(_Transaccion.IdProveedorCliente)
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = _Transaccion.IdProveedorCliente

                Me.TextBox3.Text = _Transaccion.Glosa
                Me.DropDownList3.SelectedValue = _Transaccion.IdTipoBaseImp
                If Not (_Transaccion.IdTipoDocRef = 0) Then
                    Me.RadComboBox9.SelectedValue = _Transaccion.IdTipoDocRef
                End If
                Me.TextBox6.Text = _Transaccion.SerieDocRef
                Me.TextBox4.Text = _Transaccion.NroDocRef
                Me.txtDate3.Text = _Transaccion.FechaDocRef
                Me.RadNumericTextBox2.Text = _Transaccion.TipoCambioDocRef
                Me.RadNumericTextBox3.Text = _Transaccion.Total
                Me.RadNumericTextBox7.Text = _Transaccion.BaseImponible
                Me.RadNumericTextBox4.Text = _Transaccion.MontoIgv
                Me.RadNumericTextBox6.Text = _Transaccion.Otros
                If Not (_Transaccion.IdDetraccion = 0) Then
                    Me.RadComboBox11.SelectedValue = _Transaccion.IdDetraccion
                End If
                Me.RadNumericTextBox8.Text = _Transaccion.ValorIgv
            End If
        Else
            'para mostrar el boton deshacer

            registros = LineaBL.GetNumeroRegistrosFromLINEA(Session("IdTransaccion"))
            If registros > 0 Then
                Me.ImageButton6.Visible = True
            Else
                Me.ImageButton6.Visible = False
            End If
        End If
    End Sub
    Protected Sub txtDate1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDate1.TextChanged
        If Me.txtDate1.Text.Length > 0 Then
            If Me.txtDate.Text.Length > 0 Then
                If Date.Parse(Me.txtDate1.Text).Date > Date.Parse(Me.txtDate.Text).Date Then
                    Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡La Fecha del Documento debe ser menor o igual a la Fecha Contable!'); Foco(); " & _
                                      Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                Else
                    Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Me.txtDate1.Text)
                    'Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Me.txtDate1.Text)
                    Me.RadNumericTextBox1.Focus()
                    Me.txtDate2.Text = Date.Parse(Me.txtDate1.Text).AddDays(15)
                End If
            Else
                Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡Debe ingresar la Fecha Contable!'); Foco(); " & _
                                      Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            End If
        End If
    End Sub
    Protected Sub txtDate3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDate3.TextChanged
        If Me.txtDate3.Text.Length > 0 Then
            If Me.txtDate.Text.Length > 0 Then
                If Date.Parse(Me.txtDate3.Text).Date > Date.Parse(Me.txtDate.Text).Date Then
                    Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡La Fecha del Documento debe ser menor o igual a la Fecha Contable!'); Foco1(); " & _
                                      Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                Else
                    Me.RadNumericTextBox2.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Me.txtDate3.Text)
                    Me.RadNumericTextBox2.Focus()
                End If
            Else
                Dim cadena_java As String = _
                                     "<script type='text/javascript'> " & _
                                     " Alerta('¡Debe ingresar la Fecha Contable!'); Foco1(); " & _
                                     Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
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
        _Linea.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        _Linea.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
        'para sacar el tipo de documento
        _DocumentoContabilizado = DocumentoContabilizadoBL.GetDOCUMENTOCONTABILIZADOByIdDocConta(Int32.Parse(Me.RadComboBox6.SelectedValue))
        _Linea.IdTipoDocumento = _DocumentoContabilizado.IdTipoDocumento
        _Linea.IdTransaccion = Session("IdTransaccion")
        _Linea.MontoAbono = CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Text
        _Linea.MontoCargo = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Linea.NroDocumento = Me.TextBox2.Text
        _Linea.SerieDocumento = Me.TextBox5.Text
        'si hay nota de credito o debito se calcula con el tc del documento de referencia
        If Me.RadNumericTextBox2.Text > 0 Then
            _Linea.TipoCambio = Me.RadNumericTextBox2.Text
        Else
            _Linea.TipoCambio = Me.RadNumericTextBox1.Text
        End If

        _Linea.IdMoneda = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).IdMoneda
        _Linea.Flag = "U"
        idLinea = LineaBL.SaveLINEA(_Linea)
        ' LineaBL.UpdateMontosLINEA(idLinea)

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
        _Linea.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        _Linea.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
        'para sacar el tipo de documento
        _DocumentoContabilizado = DocumentoContabilizadoBL.GetDOCUMENTOCONTABILIZADOByIdDocConta(Int32.Parse(Me.RadComboBox6.SelectedValue))
        _Linea.IdTipoDocumento = _DocumentoContabilizado.IdTipoDocumento
        _Linea.IdTransaccion = Session("IdTransaccion")
        _Linea.MontoAbono = CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Text
        _Linea.MontoCargo = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Linea.NroDocumento = Me.TextBox2.Text
        _Linea.SerieDocumento = Me.TextBox5.Text
        'si hay nota de credito o debito se calcula con el tc del documento de referencia
        If Me.RadNumericTextBox2.Text > 0 Then
            _Linea.TipoCambio = Me.RadNumericTextBox2.Text
        Else
            _Linea.TipoCambio = Me.RadNumericTextBox1.Text
        End If
        _Linea.Flag = "U"
        _Linea.IdMoneda = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).IdMoneda
        If _Linea.IdMoneda = 1 Then
            _Linea.CargoMN = _Linea.MontoCargo
            _Linea.AbonoMN = _Linea.MontoAbono
            _Linea.CargoME = _Linea.MontoCargo / _Linea.TipoCambio
            _Linea.AbonoME = _Linea.MontoAbono / _Linea.TipoCambio
        Else
            _Linea.CargoMN = _Linea.MontoCargo * _Linea.TipoCambio
            _Linea.AbonoMN = _Linea.MontoAbono * _Linea.TipoCambio
            _Linea.CargoME = _Linea.MontoCargo
            _Linea.AbonoME = _Linea.MontoAbono
        End If

        idLinea = LineaBL.SaveLINEA(_Linea)
        ' LineaBL.UpdateMontosLINEA(idLinea)

    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdLinea")
        LineaBL.DeleteLINEA(id)
    End Sub
    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim valor As Int32

        valor = TransaccionBL.VerifyDocumentoDuplicado(Me.RadComboBox8.SelectedValue, Me.TextBox5.Text, Me.TextBox2.Text, Me.RadComboBox6.SelectedValue, Session("IdTransaccion"))
        If valor > 0 Then
            Dim cadena_java As String = _
                                  "<script type='text/javascript'> " & _
                                  " Alerta('¡EL Documento ingresado ya está registrado, no se puede grabar!'); " & _
                                  Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        Else
            'Grabar transaccion
            Transaccion.Anio = Session("Anio")
            Transaccion.BaseImponible = Me.RadNumericTextBox7.Text
            Transaccion.BaseInafecto = 0
            Transaccion.IdCtaBancaria.Equals(DBNull.Value)
            Transaccion.DiasVencimiento = 0
            Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
            If Me.txtDate3.Text.Length > 0 Then
                Transaccion.FechaDocRef = FormatDateTime(Me.txtDate3.Text, DateFormat.LongDate)
            Else
                Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
            End If
            Transaccion.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
            If Me.txtDate2.Text.Length > 0 Then
                Transaccion.FechaVencimiento = FormatDateTime(Me.txtDate2.Text, DateFormat.LongDate)
            Else
                Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
            End If
            Transaccion.Glosa = Me.TextBox3.Text
            If Me.RadComboBox11.SelectedValue.Length > 0 Then
                Transaccion.IdDetraccion = Me.RadComboBox11.SelectedValue
            End If
            Transaccion.IdDocumentoCont = Me.RadComboBox6.SelectedValue
            Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
            Transaccion.IdPersonal.Equals(DBNull.Value)
            Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
            Transaccion.IdSubDiario = Me.DropDownList2.SelectedValue
            Transaccion.IdTipoBaseImp = Me.DropDownList3.SelectedValue
            If Me.RadComboBox9.SelectedValue.Length > 0 Then
                Transaccion.IdTipoDocRef = Me.RadComboBox9.SelectedValue
            End If
            Transaccion.Idtransaccion = Session("IdTransaccion")
            Transaccion.Mes = Session("Mes")
            Transaccion.MontoIgv = Me.RadNumericTextBox4.Text
            Transaccion.NroCheque = ""
            If Me.TextBox4.Text.Length > 0 Then
                Transaccion.NroDocRef = Me.TextBox4.Text
            End If
            Transaccion.NroDocumento = Me.TextBox2.Text
            Transaccion.Otros = Me.RadNumericTextBox6.Text
            Transaccion.SerieDocRef = Me.TextBox6.Text
            Transaccion.SerieDocumento = Me.TextBox5.Text
            Transaccion.TipoCambio = RadNumericTextBox1.Text
            Transaccion.TipoCambioDocRef = Me.RadNumericTextBox2.Text
            Transaccion.Total = Me.RadNumericTextBox3.Text
            Transaccion.Usuario = Session("IdUser")
            Transaccion.ValorIgv = Me.RadNumericTextBox8.Text
            Transaccion.NroExoneracion = ""
            Transaccion.MontoRetencion = 0
            Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
            Transaccion.Flag = "O"
            If Session("IdTransaccion") > 0 Then
                TransaccionBL.SaveTransaccion(Transaccion)
            Else
                Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
            End If

            Me.TextBox1.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo
            Me.RadGrid1.DataBind()
        End If
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        Dim valor As Int32

        valor = TransaccionBL.VerifyDocumentoDuplicado(Me.RadComboBox8.SelectedValue, Me.TextBox5.Text, Me.TextBox2.Text, Me.RadComboBox6.SelectedValue, Session("IdTransaccion"))
        If valor > 0 Then
            Dim cadena_java As String = _
                                  "<script type='text/javascript'> " & _
                                  " Alerta('¡EL Documento ingresado ya está registrado, no se puede procesar!'); " & _
                                  Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)


        Else
            'Grabar transaccion
            Transaccion.Anio = Session("Anio")
            Transaccion.BaseImponible = Me.RadNumericTextBox7.Text
            Transaccion.BaseInafecto = 0
            Transaccion.IdCtaBancaria.Equals(DBNull.Value)
            Transaccion.DiasVencimiento = 0
            Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
            If Me.txtDate3.Text.Length > 0 Then
                Transaccion.FechaDocRef = FormatDateTime(Me.txtDate3.Text, DateFormat.LongDate)
            Else
                Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
            End If
            Transaccion.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
            If Me.txtDate2.Text.Length > 0 Then
                Transaccion.FechaVencimiento = FormatDateTime(Me.txtDate2.Text, DateFormat.LongDate)
            Else
                Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
            End If
            Transaccion.Glosa = Me.TextBox3.Text
            If Me.RadComboBox11.SelectedValue.Length > 0 Then
                Transaccion.IdDetraccion = Me.RadComboBox11.SelectedValue
            End If
            Transaccion.IdDocumentoCont = Me.RadComboBox6.SelectedValue
            Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
            Transaccion.IdPersonal.Equals(DBNull.Value)
            Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
            Transaccion.IdSubDiario = Me.DropDownList2.SelectedValue
            Transaccion.IdTipoBaseImp = Me.DropDownList3.SelectedValue
            If Me.RadComboBox9.SelectedValue.Length > 0 Then
                Transaccion.IdTipoDocRef = Me.RadComboBox9.SelectedValue
            End If
            Transaccion.Idtransaccion = Session("IdTransaccion")
            Transaccion.Mes = Session("Mes")
            Transaccion.MontoIgv = Me.RadNumericTextBox4.Text
            Transaccion.NroCheque = ""
            If Me.TextBox4.Text.Length > 0 Then
                Transaccion.NroDocRef = Me.TextBox4.Text
            End If
            Transaccion.NroDocumento = Me.TextBox2.Text
            Transaccion.Otros = Me.RadNumericTextBox6.Text
            Transaccion.SerieDocRef = Me.TextBox6.Text
            Transaccion.SerieDocumento = Me.TextBox5.Text
            Transaccion.TipoCambio = RadNumericTextBox1.Text
            Transaccion.TipoCambioDocRef = Me.RadNumericTextBox2.Text
            Transaccion.Total = Me.RadNumericTextBox3.Text
            Transaccion.Usuario = Session("IdUser")
            Transaccion.ValorIgv = Me.RadNumericTextBox8.Text
            Transaccion.NroExoneracion = ""
            Transaccion.MontoRetencion = 0
            Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
            Transaccion.Flag = "O"
            If Session("IdTransaccion") > 0 Then
                TransaccionBL.SaveTransaccion(Transaccion)
            Else
                Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
            End If

            Me.TextBox1.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo

            'generamos la linea
            LineaBL.GenerarLINEA(Session("IdTransaccion"))
            Me.RadGrid1.DataBind()
        End If
    End Sub
    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        If Session("IdTransaccion") > 0 Then
            If TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Then
                Dim cadena_java As String = _
                                          "<script type='text/javascript'> " & _
                                          " alert('¡Debe validar el Voucher!'); " & _
                                          Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Alerta", cadena_java.ToString, False)
            Else
                Session("IdTransaccion") = 0
                Response.Redirect("~\Contabilidad\Formularios\FrmCompras.aspx")
            End If
        Else
            Session("IdTransaccion") = 0
            Response.Redirect("~\Contabilidad\Formularios\FrmCompras.aspx")
        End If
    End Sub
    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        LineaBL.DeleteLINEAByFlag(Session("IdTransaccion"))
        ''para habilitar los botones de la grilla
        'For i = 0 To Me.RadGrid1.Items.Count - 1
        '    Me.RadGrid1.Items(i)("Editar").Enabled = True
        '    Me.RadGrid1.Items(i)("eliminar").Enabled = True
        'Next
        Me.RadGrid1.Rebind()
    End Sub
    Protected Sub RadGrid1_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.DataBound
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.MasterTableView.Items.Item(i)("editar").Text = ""
                Me.RadGrid1.MasterTableView.Items.Item(i)("eliminar").Text = ""
            Next

        Else
            'para mostrar el boton deshacer
            If Session("IdTransaccion") > 0 Then
                registros = LineaBL.GetNumeroRegistrosFromLINEA(Session("IdTransaccion"))
                If registros > 0 Then
                    Me.ImageButton6.Visible = True
                    Me.ImageButton13.Visible = True
                    Me.ImageButton5.Visible = False

                    ''para deshabilitar los botones de la grilla
                    'For i = 0 To Me.RadGrid1.Items.Count - 1
                    '    Me.RadGrid1.Items.Item(i)("editar").Enabled = False
                    '    Me.RadGrid1.Items.Item(i)("eliminar").Enabled = False
                    'Next
                    'Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
                Else
                    Me.ImageButton6.Visible = False
                    Me.ImageButton13.Visible = False
                    Me.ImageButton5.Visible = True
                    ''para habilitar los botones de la grilla
                    'For i = 0 To Me.RadGrid1.Items.Count - 1
                    '    Me.RadGrid1.Items.Item(i)("editar").Enabled = True
                    '    Me.RadGrid1.Items.Item(i)("eliminar").Enabled = True
                    'Next
                    'Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.Top
                End If
            Else
                Me.ImageButton6.Visible = False
                Me.ImageButton13.Visible = False
                Me.ImageButton5.Visible = False
                ''para habilitar los botones de la grilla
                'For i = 0 To Me.RadGrid1.Items.Count - 1
                '    Me.RadGrid1.Items.Item(i)("editar").Enabled = True
                '    Me.RadGrid1.Items.Item(i)("eliminar").Enabled = True
                'Next
                ' Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.Top
            End If
        End If

    End Sub
    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim valor As Int32
        valor = TransaccionBL.VerifyDocumentoDuplicado(Me.RadComboBox8.SelectedValue, Me.TextBox5.Text, Me.TextBox2.Text, Me.RadComboBox6.SelectedValue, Session("IdTransaccion"))
        If valor > 0 Then
            Dim cadena_java As String = _
                                  "<script type='text/javascript'> " & _
                                  " Alerta('¡EL Documento ingresado ya está registrado!'); " & _
                                  Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        Else
            'Grabar transaccion
            Transaccion.Anio = Session("Anio")
            Transaccion.BaseImponible = Me.RadNumericTextBox7.Text
            Transaccion.BaseInafecto = 0
            Transaccion.IdCtaBancaria.Equals(DBNull.Value)
            Transaccion.DiasVencimiento = 0
            Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
            If Me.txtDate3.Text.Length > 0 Then
                Transaccion.FechaDocRef = FormatDateTime(Me.txtDate3.Text, DateFormat.LongDate)
            Else
                Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
            End If
            Transaccion.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
            If Me.txtDate2.Text.Length > 0 Then
                Transaccion.FechaVencimiento = FormatDateTime(Me.txtDate2.Text, DateFormat.LongDate)
            Else
                Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
            End If
            Transaccion.Glosa = Me.TextBox3.Text
            If Me.RadComboBox11.SelectedValue.Length > 0 Then
                Transaccion.IdDetraccion = Me.RadComboBox11.SelectedValue
            End If
            Transaccion.IdDocumentoCont = Me.RadComboBox6.SelectedValue
            Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
            Transaccion.IdPersonal.Equals(DBNull.Value)
            Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
            Transaccion.IdSubDiario = Me.DropDownList2.SelectedValue
            Transaccion.IdTipoBaseImp = Me.DropDownList3.SelectedValue
            If Me.RadComboBox9.SelectedValue.Length > 0 Then
                Transaccion.IdTipoDocRef = Me.RadComboBox9.SelectedValue
            End If
            Transaccion.Idtransaccion = Session("IdTransaccion")
            Transaccion.Mes = Session("Mes")
            Transaccion.MontoIgv = Me.RadNumericTextBox4.Text
            Transaccion.NroCheque = ""
            If Me.TextBox4.Text.Length > 0 Then
                Transaccion.NroDocRef = Me.TextBox4.Text
            End If
            Transaccion.NroDocumento = Me.TextBox2.Text
            Transaccion.Otros = Me.RadNumericTextBox6.Text
            Transaccion.SerieDocRef = Me.TextBox6.Text
            Transaccion.SerieDocumento = Me.TextBox5.Text
            Transaccion.TipoCambio = RadNumericTextBox1.Text
            Transaccion.TipoCambioDocRef = Me.RadNumericTextBox2.Text
            Transaccion.Total = Me.RadNumericTextBox3.Text
            Transaccion.Usuario = Session("IdUser")
            Transaccion.ValorIgv = Me.RadNumericTextBox8.Text
            Transaccion.NroExoneracion = ""
            Transaccion.MontoRetencion = 0
            Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
            Transaccion.Flag = "O"

            If Session("IdTransaccion") > 0 Then
                TransaccionBL.SaveTransaccion(Transaccion)
            Else
                Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
            End If

            Me.TextBox1.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo

            Me.RadGrid1.MasterTableView.InsertItem()
        End If
    End Sub
    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "ActualizarLista" Then
            Me.RadComboBox8.DataBind()
        ElseIf e.Argument = "ValidarFecha" Then
            If Me.txtDate.Text.Length > 0 Then
                If (CDate(Me.txtDate.Text).Month <> Session("Mes") Or CDate(Me.txtDate.Text) > CDate(Session("Fecha"))) Then
                    Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡La Fecha Contable es incorrecta!'); Foco2(); " & _
                                       Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                End If
            End If
        ElseIf e.Argument = "ValidarDocumento" Then
            Dim valor As Int32
            valor = TransaccionBL.VerifyDocumentoDuplicado(Me.RadComboBox8.SelectedValue, Me.TextBox5.Text, Me.TextBox2.Text, Me.RadComboBox6.SelectedValue, Session("IdTransaccion"))
            If valor > 0 Then
                Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡EL Documento ingresado ya está registrado!'); " & _
                                      Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            End If
        ElseIf e.Argument = "ValidarTipoDocumento" Then
            If Me.RadComboBox6.SelectedValue = 8 Or Me.RadComboBox6.SelectedValue = 10 Then
                Me.DropDownList3.SelectedValue = 3
                Me.DropDownList3.Enabled = False
            Else
                Me.DropDownList3.Enabled = True
            End If
        End If
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('Voucher.aspx?Tipo=C'); " & _
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

        For i = 0 To Me.RadGrid1.Items.Count - 1
            'PARA CALCULAR EL TOTAL
            totalDebeMN = totalDebeMN + Decimal.Parse(Me.RadGrid1.Items(i)("Cargo").Text.ToString)
            totalhaberMN = totalhaberMN + Decimal.Parse(Me.RadGrid1.Items(i)("Abono").Text.ToString)

        Next
        If (totalDebeMN <> totalhaberMN) Then
            Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡No coinciden los Montos, Debe Cuadrar el Voucher!'); " & _
                                      Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "S")
        Else
            TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "P")
            TransaccionBL.CuadrarVoucher(Session("IdTransaccion"))

            Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡Voucher " + Me.DropDownList2.SelectedValue.ToString + "-" + Me.TextBox1.Text.ToString + "  creado correctamente!'); " & _
                                       Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
           
        End If
    End Sub
    Protected Sub RadComboBox6_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadComboBox6.DataBound
        If Session("IdTransaccion") > 0 Then
            If Me.RadComboBox6.SelectedValue = 8 Or Me.RadComboBox6.SelectedValue = 10 Then
                Me.DropDownList3.SelectedValue = 3
                Me.DropDownList3.Enabled = False
            Else
                Me.DropDownList3.Enabled = True
            End If
        End If

    End Sub
End Class
