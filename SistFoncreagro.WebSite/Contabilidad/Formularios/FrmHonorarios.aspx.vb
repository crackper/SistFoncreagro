Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration
Public Class FrmHonorarios
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL
    Dim ParametroBL As New ParametrosBL
    Dim TransaccionBL As New TransaccionBL
    Dim Transaccion As New Transaccion
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    Dim _Transaccion As Transaccion
    Dim _Linea As New Linea
    Dim LineaBL As New LineaBL
    Dim _DocumentoContabilizado As DocumentoContabilizado
    Dim DocumentoContabilizadoBL As New DocumentoContabilizadoBL
    Dim Renta4ta As Decimal
    Dim SisPensiones As Decimal
    Dim MontoLimite As Decimal
    Dim IdTransaccion As String
    Dim registros As Int32
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String

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

        'para agregar un evento 
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")
        Me.txtDate.Attributes.Add("onChange", "ValidarFecha();")
        Me.TextBox2.Attributes.Add("onChange", "ponerCeros();")
        Me.TextBox5.Attributes.Add("onChange", "Calcular();")
        Me.CheckBox1.Attributes.Add("onChange", "Calcular();")
        'Me.TextBox4.Attributes.Add("onFocus", "ValidarDocumento();")

        'para obtener el valor de la renta de 4ta y el monto limite
        Renta4ta = ParametroBL.GetPARAMETROSByNombre("RENTA 4TA").valor
        Me.RadNumericTextBox8.Text = Renta4ta
        MontoLimite = ParametroBL.GetPARAMETROSByNombre("RENTA 4TA").MontoLimite
        Me.RadNumericTextBox2.Text = MontoLimite


        Me.RadComboBox3.Filter = 1
        Me.RadComboBox6.Filter = 1
        Me.RadComboBox8.Filter = 1

        If Page.IsPostBack = False Then
            ' Me.txtDate1.Text = Session("Fecha").ToString
            Me.txtDate.Text = Session("Fecha").ToString
            Me.RadNumericTextBox1.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Session("Fecha").ToString)
            Me.DropDownList1.SelectedValue = 2
            Me.DropDownList2.SelectedValue = 4
            Me.RadComboBox6.SelectedValue = 7

            If Session("IdTransaccion") > 0 Then
                'para recuperar datos de transaccion
                _Transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
                Me.DropDownList1.SelectedValue = _Transaccion.IdOpFinanciera
                Me.DropDownList2.SelectedValue = _Transaccion.IdSubDiario
                Me.TextBox1.Text = _Transaccion.Codigo
                Me.RadComboBox3.SelectedValue = _Transaccion.IdProyecto
                Me.txtDate.Text = _Transaccion.FechaContable
                Me.RadComboBox6.SelectedValue = _Transaccion.IdDocumentoCont
                Me.TextBox2.Text = _Transaccion.SerieDocumento
                Me.TextBox3.Text = _Transaccion.NroDocumento
                Me.txtDate1.Text = _Transaccion.FechaDocumento
                Me.RadNumericTextBox1.Text = _Transaccion.TipoCambio

                _Proveedor = Proveedor.GetAllFromProveedorClienteById(_Transaccion.IdProveedorCliente)
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = _Transaccion.IdProveedorCliente

                Me.TextBox4.Text = _Transaccion.Glosa
                Me.TextBox5.Text = _Transaccion.NroExoneracion
                Me.RadNumericTextBox3.Text = _Transaccion.BaseImponible 'es el importe total
                Me.RadNumericTextBox4.Text = _Transaccion.MontoRetencion
                Me.RadNumericTextBox8.Text = _Transaccion.ValorIgv 'es el valor de la tasa por renta de 4ta
                Me.RadNumericTextBox11.Text = _Transaccion.Total 'es el importe neto

                If _Transaccion.AfectoSistPen = "S" Then
                    Me.CheckBox1.Checked = True
                Else
                    Me.CheckBox1.Checked = False
                End If

                If _Transaccion.IdAfp.HasValue Then
                    Me.RadComboBox9.SelectedValue = _Transaccion.IdAfp
                End If

                Me.RadNumericTextBox13.Text = _Transaccion.Comision
                Me.RadNumericTextBox14.Text = _Transaccion.Seguro
                Me.RadNumericTextBox12.Text = _Transaccion.MontoSistPen
                Me.RadNumericTextBox15.Text = _Transaccion.AporteAfp
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
                    Me.RadNumericTextBox1.Focus()
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

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32

        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdLinea")
        LineaBL.DeleteLINEA(id)
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim valor As Int32
        valor = TransaccionBL.VerifyDocumentoDuplicado(Me.RadComboBox8.SelectedValue, Me.TextBox2.Text, Me.TextBox3.Text, Me.RadComboBox6.SelectedValue, Session("IdTransaccion"))
        If valor > 0 Then
            Dim cadena_java As String = _
                                  "<script type='text/javascript'> " & _
                                  " Alerta('¡EL Documento ingresado ya está registrado, no se puede grabar!'); " & _
                                  Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        Else

            'Grabar transaccion
            Transaccion.Anio = Session("Anio")
            Transaccion.BaseImponible = Me.RadNumericTextBox3.Text
            Transaccion.BaseInafecto = 0
            Transaccion.IdCtaBancaria.Equals(DBNull.Value)
            Transaccion.DiasVencimiento = 0
            Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
            Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
            Transaccion.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
            Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
            Transaccion.Glosa = Me.TextBox4.Text
            Transaccion.IdDetraccion.Equals(DBNull.Value)
            Transaccion.IdDocumentoCont = Me.RadComboBox6.SelectedValue
            Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
            ' Transaccion.IdOrdenCompra = Nothing
            Transaccion.IdPersonal.Equals(DBNull.Value)
            Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
            Transaccion.IdSubDiario = Me.DropDownList2.SelectedValue
            Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
            Transaccion.Idtransaccion = Session("IdTransaccion")
            Transaccion.Mes = Session("Mes")
            Transaccion.MontoIgv = 0
            Transaccion.NroCheque = ""
            Transaccion.NroDocumento = Me.TextBox3.Text
            Transaccion.Otros = 0
            Transaccion.SerieDocumento = Me.TextBox2.Text
            Transaccion.TipoCambio = RadNumericTextBox1.Text
            Transaccion.TipoCambioDocRef = 0
            Transaccion.Total = Me.RadNumericTextBox11.Text
            Transaccion.Usuario = Session("IdUser")
            Transaccion.ValorIgv = Me.RadNumericTextBox8.Text
            Transaccion.NroExoneracion = Me.TextBox5.Text
            Transaccion.MontoRetencion = Me.RadNumericTextBox4.Text
            Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
            Transaccion.Flag = "O"
            If Me.CheckBox1.Checked = True Then
                Transaccion.AfectoSistPen = "S"
            Else
                Transaccion.AfectoSistPen = "N"
            End If
            If Me.RadComboBox9.SelectedValue <> 0 Then
                Transaccion.IdAfp = Me.RadComboBox9.SelectedValue
            Else
                Transaccion.IdAfp.Equals(DBNull.Value)
            End If
            Transaccion.Comision = Me.RadNumericTextBox13.Value
            Transaccion.Seguro = Me.RadNumericTextBox14.Value
            Transaccion.AporteAfp = Me.RadNumericTextBox15.Value
            Transaccion.MontoSistPen = Me.RadNumericTextBox12.Value

            If Session("IdTransaccion") > 0 Then
                TransaccionBL.SaveTransaccion(Transaccion)
            Else
                Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
            End If
            Me.TextBox1.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo
        End If
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        If Session("IdTransaccion") > 0 Then
            If TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Then
                Dim cadena_java As String = _
                                          "<script type='text/javascript'> " & _
                                          " alert('¡Debe validar el Voucher!'); " & _
                                          Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            Else
                Session("IdTransaccion") = 0
                Response.Redirect("~\Contabilidad\Formularios\FrmHonorarios.aspx")
            End If
        Else
            Session("IdTransaccion") = 0
            Response.Redirect("~\Contabilidad\Formularios\FrmHonorarios.aspx")
        End If
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        'Grabar transaccion
        Transaccion.Anio = Session("Anio")
        Transaccion.BaseImponible = Me.RadNumericTextBox3.Text
        Transaccion.BaseInafecto = 0
        Transaccion.IdCtaBancaria.Equals(DBNull.Value)
        Transaccion.DiasVencimiento = 0
        Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
        Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
        Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
        Transaccion.Glosa = Me.TextBox4.Text
        Transaccion.IdDetraccion.Equals(DBNull.Value)
        Transaccion.IdDocumentoCont = Me.RadComboBox6.SelectedValue
        Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
        ' Transaccion.IdOrdenCompra = Nothing
        Transaccion.IdPersonal.Equals(DBNull.Value)
        Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
        Transaccion.IdSubDiario = Me.DropDownList2.SelectedValue
        Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
        Transaccion.Idtransaccion = Session("IdTransaccion")
        Transaccion.Mes = Session("Mes")
        Transaccion.MontoIgv = 0
        Transaccion.NroCheque = ""
        Transaccion.NroDocumento = Me.TextBox3.Text
        Transaccion.Otros = 0
        Transaccion.SerieDocumento = Me.TextBox2.Text
        Transaccion.TipoCambio = RadNumericTextBox1.Text
        Transaccion.TipoCambioDocRef = 0
        Transaccion.Total = Me.RadNumericTextBox11.Text
        Transaccion.Usuario = Session("IdUser")
        Transaccion.ValorIgv = Me.RadNumericTextBox8.Text
        Transaccion.NroExoneracion = Me.TextBox5.Text
        Transaccion.MontoRetencion = Me.RadNumericTextBox4.Text
        Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
        Transaccion.Flag = "O"
        If Me.CheckBox1.Checked = True Then
            Transaccion.AfectoSistPen = "S"
        Else
            Transaccion.AfectoSistPen = "N"
        End If
        If Me.RadComboBox9.SelectedValue <> 0 Then
            Transaccion.IdAfp = Me.RadComboBox9.SelectedValue
        Else
            Transaccion.IdAfp.Equals(DBNull.Value)
        End If
        Transaccion.Comision = Me.RadNumericTextBox13.Value
        Transaccion.Seguro = Me.RadNumericTextBox14.Value
        Transaccion.AporteAfp = Me.RadNumericTextBox15.Value
        Transaccion.MontoSistPen = Me.RadNumericTextBox12.Value

        If Session("IdTransaccion") > 0 Then
            TransaccionBL.SaveTransaccion(Transaccion)
        Else
            Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
        End If
        Me.TextBox1.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo

        'generar linea
        LineaBL.GenerarLINEA(Session("IdTransaccion"))
        Me.RadGrid1.Rebind()
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim idLinea As Int32

        _Linea.Glosa = CType(userControl.FindControl("TextBox2"), TextBox).Text
        If CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue.Length > 0 Then
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
        _Linea.NroDocumento = Me.TextBox3.Text
        _Linea.SerieDocumento = Me.TextBox2.Text
        _Linea.TipoCambio = Me.RadNumericTextBox1.Text
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
        If CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue.Length > 0 Then
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
        _Linea.NroDocumento = Me.TextBox3.Text
        _Linea.SerieDocumento = Me.TextBox2.Text
        _Linea.TipoCambio = Me.RadNumericTextBox1.Text
        _Linea.IdMoneda = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).IdMoneda
        _Linea.Flag = "U"
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
        '  LineaBL.UpdateMontosLINEA(idLinea)
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
                    'para deshabilitar los botones de la grilla
                    For i = 0 To Me.RadGrid1.Items.Count - 1
                        Me.RadGrid1.Items.Item(i)("editar").Enabled = False
                        Me.RadGrid1.Items.Item(i)("eliminar").Enabled = False
                    Next
                    Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
                Else
                    Me.ImageButton6.Visible = False
                    Me.ImageButton13.Visible = False
                    Me.ImageButton5.Visible = True
                    'para habilitar los botones de la grilla
                    For i = 0 To Me.RadGrid1.Items.Count - 1
                        Me.RadGrid1.Items.Item(i)("editar").Enabled = True
                        Me.RadGrid1.Items.Item(i)("eliminar").Enabled = True
                    Next
                    Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.Top
                End If
            Else
                Me.ImageButton6.Visible = False
                Me.ImageButton13.Visible = False
                Me.ImageButton5.Visible = False
                'para habilitar los botones de la grilla
                For i = 0 To Me.RadGrid1.Items.Count - 1
                    Me.RadGrid1.Items.Item(i)("editar").Enabled = True
                    Me.RadGrid1.Items.Item(i)("eliminar").Enabled = True
                Next
                Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.Top
            End If
        End If
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        LineaBL.DeleteLINEAByFlag(Session("IdTransaccion"))
        TransaccionBL.UpdateEstadoTRANSACCION(Session("IdTransaccion"), "S")
        Me.RadGrid1.Rebind()
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
            valor = TransaccionBL.VerifyDocumentoDuplicado(Me.RadComboBox8.SelectedValue, Me.TextBox2.Text, Me.TextBox3.Text, Me.RadComboBox6.SelectedValue, Session("IdTransaccion"))
            If valor > 0 Then
                Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Alerta('¡EL Documento ingresado ya está registrado!'); " & _
                                      Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            End If
        ElseIf e.Argument = "Afp" Then
            ' para obtener el valor de la renta sistema de pensiones
            SisPensiones = ParametroBL.GetPorcentajeSistemaPenciones(Me.RadComboBox9.SelectedValue, Me.RadNumericTextBox3.Text)
            Me.RadNumericTextBox15.Text = SisPensiones
            Dim cadena_java As String = _
                                      "<script type='text/javascript'> " & _
                                      " Calcular; " & _
                                      Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim valor As Int32
        valor = TransaccionBL.VerifyDocumentoDuplicado(Me.RadComboBox8.SelectedValue, Me.TextBox2.Text, Me.TextBox3.Text, Me.RadComboBox6.SelectedValue, Session("IdTransaccion"))
        If valor > 0 And Session("IdTransaccion") = 0 Then
            Dim cadena_java As String = _
                                  "<script type='text/javascript'> " & _
                                  " Alerta('¡EL Documento ingresado ya está registrado, no se puede grabar!'); " & _
                                  Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        Else
            'Grabar transaccion
            Transaccion.Anio = Session("Anio")
            Transaccion.BaseImponible = Me.RadNumericTextBox3.Text
            Transaccion.BaseInafecto = 0
            Transaccion.IdCtaBancaria.Equals(DBNull.Value)
            Transaccion.DiasVencimiento = 0
            Transaccion.FechaContable = FormatDateTime(Me.txtDate.Text, DateFormat.LongDate)
            Transaccion.FechaDocRef = FormatDateTime("01/01/1900", DateFormat.LongDate)
            Transaccion.FechaDocumento = FormatDateTime(Me.txtDate1.Text, DateFormat.LongDate)
            Transaccion.FechaVencimiento = FormatDateTime("01/01/1900", DateFormat.LongDate)
            Transaccion.Glosa = Me.TextBox4.Text
            Transaccion.IdDetraccion.Equals(DBNull.Value)
            Transaccion.IdDocumentoCont = Me.RadComboBox6.SelectedValue
            Transaccion.IdOpFinanciera = Me.DropDownList1.SelectedValue
            ' Transaccion.IdOrdenCompra = Nothing
            Transaccion.IdPersonal.Equals(DBNull.Value)
            Transaccion.IdProveedorCliente = Me.RadComboBox8.SelectedValue
            Transaccion.IdSubDiario = Me.DropDownList2.SelectedValue
            Transaccion.IdTipoBaseImp.Equals(DBNull.Value)
            Transaccion.Idtransaccion = Session("IdTransaccion")
            Transaccion.Mes = Session("Mes")
            Transaccion.MontoIgv = 0
            Transaccion.NroCheque = ""
            Transaccion.NroDocumento = Me.TextBox3.Text
            Transaccion.Otros = 0
            Transaccion.SerieDocumento = Me.TextBox2.Text
            Transaccion.TipoCambio = RadNumericTextBox1.Text
            Transaccion.TipoCambioDocRef = 0
            Transaccion.Total = Me.RadNumericTextBox11.Text
            Transaccion.Usuario = Session("IdUser")
            Transaccion.ValorIgv = Me.RadNumericTextBox8.Text
            Transaccion.NroExoneracion = Me.TextBox5.Text
            Transaccion.MontoRetencion = Me.RadNumericTextBox4.Text
            Transaccion.IdProyecto = Me.RadComboBox3.SelectedValue
            Transaccion.Flag = "O"
            If Me.CheckBox1.Checked = True Then
                Transaccion.AfectoSistPen = "S"
            Else
                Transaccion.AfectoSistPen = "N"
            End If
            If Me.RadComboBox9.SelectedValue <> 0 Then
                Transaccion.IdAfp = Me.RadComboBox9.SelectedValue
            Else
                Transaccion.IdAfp.Equals(DBNull.Value)
            End If
            Transaccion.Comision = Me.RadNumericTextBox13.Value
            Transaccion.Seguro = Me.RadNumericTextBox14.Value
            Transaccion.AporteAfp = Me.RadNumericTextBox15.Value
            Transaccion.MontoSistPen = Me.RadNumericTextBox12.Value

            If Session("IdTransaccion") > 0 Then
                TransaccionBL.SaveTransaccion(Transaccion)
            Else
                Session("IdTransaccion") = TransaccionBL.SaveTransaccion(Transaccion)
            End If
            Me.TextBox1.Text = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Codigo
            Me.RadGrid1.MasterTableView.InsertItem()
        End If
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
    '            Response.Redirect(Session("Ventana") + "?Idsubdiario=4")
    '        End If
    '    Else
    '        Response.Redirect(Session("Ventana") + "?Idsubdiario=4")
    '    End If

    'End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('Voucher.aspx?Tipo=H'); " & _
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

    
    'Protected Sub RadComboBox9_SelectedIndexChanged(sender As Object, e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox9.SelectedIndexChanged
    '    'para obtener el valor de la renta sistema de pensiones
    '    SisPensiones = ParametroBL.GetPorcentajeSistemaPenciones(Me.RadComboBox9.SelectedValue, Me.RadNumericTextBox3.Text)
    '    Me.RadNumericTextBox15.Text = SisPensiones
    'End Sub

    Protected Sub RadNumericTextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox3.TextChanged
        'para obtener el valor de la renta sistema de pensiones
        SisPensiones = ParametroBL.GetPorcentajeSistemaPenciones(Me.RadComboBox9.SelectedValue, Me.RadNumericTextBox3.Text)
        Me.RadNumericTextBox15.Text = SisPensiones

        If Me.TextBox5.Text.Length = 0 And Me.RadNumericTextBox3.Value > Me.RadNumericTextBox2.Value Then
            Me.RadNumericTextBox4.Text = Me.RadNumericTextBox3.Value * Me.RadNumericTextBox8.Value / 100.0
        End If
        If Me.CheckBox1.Checked Then
            Me.RadNumericTextBox12.Text = Me.RadNumericTextBox3.Text * (Me.RadNumericTextBox13.Value + Me.RadNumericTextBox14.Value + Me.RadNumericTextBox15.Value) / 100.0
        End If
        Me.RadNumericTextBox11.Text = Me.RadNumericTextBox3.Text - Me.RadNumericTextBox4.Text - Me.RadNumericTextBox12.Text

    End Sub

    Protected Sub RadComboBox9_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox9.SelectedIndexChanged
        'para obtener el valor de la renta sistema de pensiones
        SisPensiones = ParametroBL.GetPorcentajeSistemaPenciones(Me.RadComboBox9.SelectedValue, Me.RadNumericTextBox3.Text)
        Me.RadNumericTextBox15.Text = SisPensiones

        If Me.TextBox5.Text.Length = 0 And Me.RadNumericTextBox3.Value > Me.RadNumericTextBox2.Value Then
            Me.RadNumericTextBox4.Text = Me.RadNumericTextBox3.Value * Me.RadNumericTextBox8.Value / 100.0
        End If
        If Me.CheckBox1.Checked Then
            Me.RadNumericTextBox12.Text = Me.RadNumericTextBox3.Text * (Me.RadNumericTextBox13.Value + Me.RadNumericTextBox14.Value + Me.RadNumericTextBox15.Value) / 100.0
        End If
        Me.RadNumericTextBox11.Text = Me.RadNumericTextBox3.Text - Me.RadNumericTextBox4.Text - Me.RadNumericTextBox12.Text
    End Sub
End Class