Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlDiario
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim TransaccionBL As New TransaccionBL
    Dim _transaccion As Transaccion
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    Dim IdTransaccion As String
    Dim PlanContableBl As New PlanContableBL
    Dim _PlanContable As PlanContable
    Dim TipoCambioBL As New TipocambioBL
    Dim flag As String
    Dim CuentaEnlaceBL As New CuentaEnlaceBL
    Dim proyectoBL As New ProyectoBL

    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property

    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Dim subdiario As Int32

        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox8.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox6.Filter = 1
        'PARA SACAR EL ID DE PROYECTO
        _transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
        Me.TextBox1.Text = _transaccion.IdProyecto

        'para sacar el subdiario
        subdiario = _transaccion.IdSubDiario
        If (subdiario = 5 Or subdiario = 55 Or subdiario = 9) Then
            Me.CheckBox1.Visible = False
        Else
            Me.CheckBox1.Visible = True
        End If

        If TypeOf DataItem Is GridInsertionObject Then

            Me.TextBox2.Text = _transaccion.Glosa
            Me.txtDate1.Text = _transaccion.FechaContable
            Me.NHiddenField1.Value = _transaccion.TipoCambio

            If _transaccion.IdProveedorCliente > 0 Then
                _Proveedor = Proveedor.GetAllFromProveedorClienteById(_transaccion.IdProveedorCliente)
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = _transaccion.IdProveedorCliente
            End If

            Me.Label2.Visible = False
            Me.Label4.Visible = False
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.Label1.Visible = True
            Me.Label3.Visible = True
            Me.RadNumericTextBox2.Visible = True
            Me.NTextBox4.Visible = False
            Me.RadNumericTextBox4.Visible = True
            Me.NTextBox5.Visible = False
            Me.NTextBox6.Visible = False
            Me.NTextBox7.Visible = False
            
        Else
            Me.Label2.Visible = True
            Me.Label4.Visible = True
            Me.Label5.Visible = True
            Me.Label6.Visible = True
            Me.Label1.Visible = False
            Me.Label3.Visible = False
            Me.RadNumericTextBox2.Visible = False
            Me.NTextBox4.Visible = True
            Me.RadNumericTextBox4.Visible = False
            Me.NTextBox5.Visible = True
            Me.NTextBox6.Visible = True
            Me.NTextBox7.Visible = True

            _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlan"))

            Me.odsPlanContable.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
            Me.RadComboBox1.DataBind()


            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdPlan")
            If Not IsNothing(DataBinder.Eval(DataItem, "IdCCosto")) Then
                Me.RadComboBox2.SelectedValue = DataBinder.Eval(DataItem, "IdCCosto")

            End If

            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Glosa")
            If Not IsNothing(DataBinder.Eval(DataItem, "IdTipoDocumento")) Then
                Me.RadComboBox6.SelectedValue = DataBinder.Eval(DataItem, "IdTipoDocumento")
            End If
            If Not IsNothing(DataBinder.Eval(DataItem, "FechaDocumento")) Then
                Me.txtDate1.Text = DataBinder.Eval(DataItem, "FechaDocumento")
            End If
            If Not (DataBinder.Eval(DataItem, "SerieDocumento") = "") Then
                Me.TextBox3.Text = DataBinder.Eval(DataItem, "SerieDocumento")
            End If
            If Not IsNothing(DataBinder.Eval(DataItem, "NroDocumento")) Then
                Me.RadTextBox4.Text = DataBinder.Eval(DataItem, "NroDocumento")
            End If
            If Not IsNothing(DataBinder.Eval(DataItem, "IdProveedorCliente")) Then

                _Proveedor = Proveedor.GetAllFromProveedorClienteById(DataBinder.Eval(DataItem, "IdProveedorCliente"))
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = DataBinder.Eval(DataItem, "IdProveedorCliente")

            End If
            Me.NHiddenField1.Value = DataBinder.Eval(DataItem, "TipoCambio")
            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "MontoCargo")
            Me.RadNumericTextBox4.Text = DataBinder.Eval(DataItem, "MontoAbono")
            Me.NTextBox4.Text = DataBinder.Eval(DataItem, "CargoMN")
            Me.NTextBox5.Text = DataBinder.Eval(DataItem, "AbonoMN")
            Me.NTextBox6.Text = DataBinder.Eval(DataItem, "CargoME")
            Me.NTextBox7.Text = DataBinder.Eval(DataItem, "AbonoME")
            If DataBinder.Eval(DataItem, "Enlace").Equals("S") Then
                Me.CheckBox1.Checked = True
            Else
                Me.CheckBox1.Checked = False
            End If

            Me.NTextBox4.Text = DataBinder.Eval(DataItem, "CargoMN")
            Dim cadena_java As String = _
                                         "<script type='text/javascript'> " & _
                                         "Formatear(" + DataBinder.Eval(DataItem, "CargoMN").ToString + " ); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)

            Me.NTextBox5.Text = DataBinder.Eval(DataItem, "AbonoMN")
            Dim cadena_java1 As String = _
                                        "<script type='text/javascript'> " & _
                                        "Formatear1(" + DataBinder.Eval(DataItem, "AbonoMN").ToString + " ); " & _
                                        Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java1.ToString, False)

            Me.NTextBox6.Text = DataBinder.Eval(DataItem, "CargoME")
            Dim cadena_java2 As String = _
                                        "<script type='text/javascript'> " & _
                                        "Formatear2(" + DataBinder.Eval(DataItem, "CargoME").ToString + " ); " & _
                                        Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java2.ToString, False)

            Me.NTextBox7.Text = DataBinder.Eval(DataItem, "AbonoME")
            Dim cadena_java3 As String = _
                                        "<script type='text/javascript'> " & _
                                        "Formatear3(" + DataBinder.Eval(DataItem, "AbonoME").ToString + " ); " & _
                                        Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java3.ToString, False)
            
        End If
    End Sub

    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()

    End Sub

    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 1 Then

            Me.odsPlanContable.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox1.DataBind()
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Me.RadComboBox8.DataBind()
        flag = Request.QueryString("Flag")
        Me.TextBox3.Attributes.Add("onChange", "ponerCeros();")
        Me.NTextBox4.Attributes.Add("onChange", "CalcularDolares();")
        Me.NTextBox5.Attributes.Add("onChange", "CalcularDolares1();")
        Me.NTextBox6.Attributes.Add("onChange", "CalcularSoles();")
        Me.NTextBox7.Attributes.Add("onChange", "CalcularSoles1();")

    End Sub

    Protected Sub txtDate1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDate1.TextChanged
        Me.NHiddenField1.Value = TipoCambioBL.GetTIPOCAMBIOByFecha(Me.txtDate1.Text)
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

    Protected Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
        If flag = "E" Then
            If Me.CheckBox1.Checked Then
                Dim ctaEnlace As String
                Dim Area As String
                Dim cuenta As Int32

                ctaEnlace = PlanContableBl.GetPLANCONTABLEByIdPlan(Me.RadComboBox1.SelectedValue).Codigo
                Area = proyectoBL.GetCodigoFromPROYECTO(Me.TextBox1.Text).Codigo
                cuenta = CuentaEnlaceBL.GetCtaCobrarByCtaPagarAndDestino(ctaEnlace, Area, "E")

                If cuenta = 0 Then
                    Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡La cuenta seleccionada no contiene enlace!'); " & _
                                       Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                    Me.ImageButton1.Enabled = False
                    Me.ImageButton2.Enabled = False
                    Me.CheckBox1.Checked = False
                Else
                    Me.ImageButton1.Enabled = True
                    Me.ImageButton2.Enabled = True
                End If

            End If
        End If
        If flag = "I" Then
            If Me.CheckBox1.Checked = True Then
                Dim ctaEnlace As String
                Dim Area As String
                Dim cuenta As Int32

                ctaEnlace = PlanContableBl.GetPLANCONTABLEByIdPlan(Me.RadComboBox1.SelectedValue).Codigo
                Area = proyectoBL.GetCodigoFromPROYECTO(Me.TextBox1.Text).Codigo
                cuenta = CuentaEnlaceBL.GetCtaPagarByCtaCobrarAndDestino(ctaEnlace, Area, "I")

                If cuenta = 0 Then
                    Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡La cuenta seleccionada no contiene enlace!'); " & _
                                       Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                    Me.ImageButton1.Enabled = False
                    Me.ImageButton2.Enabled = False
                    Me.CheckBox1.Checked = False
                Else
                    Me.ImageButton1.Enabled = True
                    Me.ImageButton2.Enabled = True
                End If

            End If
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(Me.RadComboBox1.SelectedValue)
        If _PlanContable.RequiereCCosto = "S" Then
            RequiredFieldValidator3.Enabled = True
        Else
            RequiredFieldValidator3.Enabled = False
        End If
        If _PlanContable.RequiereCodAux = "S" Then
            RequiredFieldValidator2.Enabled = True
        Else
            RequiredFieldValidator2.Enabled = False
        End If
        If _PlanContable.RequiereRegistro = "S" Then
            RequiredFieldValidator5.Enabled = True
            RequiredFieldValidator6.Enabled = True
            RequiredFieldValidator7.Enabled = True
        Else
            RequiredFieldValidator5.Enabled = False
            RequiredFieldValidator6.Enabled = False
            RequiredFieldValidator7.Enabled = False
        End If

        Me.Label7.Text = ""
        Me.ImageButton1.CommandName = "PerformInsert"

        If (Me.RadNumericTextBox2.Value = 0 And Me.RadNumericTextBox4.Value = 0) Then
            Me.Label7.Text = "Debe ingresar el Monto"
            Me.ImageButton1.CommandName = ""
        Else
            'If flag = "E" Then
            '    If Me.RadNumericTextBox4.Value > 0 Then
            '        Me.Label7.Text = "Debe ingresar el monto en el Debe"
            '        Me.ImageButton1.CommandName = ""
            '    Else
            '        Me.Label7.Text = ""
            '        Me.ImageButton1.CommandName = "PerformInsert"
            '    End If
            If flag = "I" Then
                If Me.RadNumericTextBox2.Value > 0 Then
                    Me.Label7.Text = "Debe ingresar el monto en el Haber"
                    Me.ImageButton1.CommandName = ""
                Else
                    Me.Label7.Text = ""
                    Me.ImageButton1.CommandName = "PerformInsert"
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(Me.RadComboBox1.SelectedValue)
        If _PlanContable.RequiereCCosto = "S" Then
            RequiredFieldValidator3.Enabled = True
        Else
            RequiredFieldValidator3.Enabled = False
        End If
        If _PlanContable.RequiereCodAux = "S" Then
            RequiredFieldValidator2.Enabled = True
        Else
            RequiredFieldValidator2.Enabled = False
        End If
        If _PlanContable.RequiereRegistro = "S" Then
            RequiredFieldValidator5.Enabled = True
            RequiredFieldValidator6.Enabled = True
            RequiredFieldValidator7.Enabled = True
        Else
            RequiredFieldValidator5.Enabled = False
            RequiredFieldValidator6.Enabled = False
            RequiredFieldValidator7.Enabled = False
        End If

    End Sub
    'Protected Sub RadNumericTextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox3.TextChanged
    '    Me.RadNumericTextBox6.Text = Me.RadNumericTextBox3.Text * Me.HiddenField1.Value

    'End Sub

    'Protected Sub RadNumericTextBox5_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox5.TextChanged
    '    Me.RadNumericTextBox7.Text = Me.RadNumericTextBox5.Text * Me.HiddenField1.Value
    'End Sub

    'Protected Sub RadNumericTextBox6_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox6.TextChanged
    '    Me.RadNumericTextBox3.Text = Me.RadNumericTextBox6.Text / Me.HiddenField1.Value
    'End Sub

    'Protected Sub RadNumericTextBox7_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox7.TextChanged
    '    Me.RadNumericTextBox5.Text = Me.RadNumericTextBox7.Text / Me.HiddenField1.Value
    'End Sub

   
   
End Class
