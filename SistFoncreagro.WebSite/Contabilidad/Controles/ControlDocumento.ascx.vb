Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlDocumento
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim RendicionBL As New RendicionBL
    Dim _Rendicion As Rendicion
    Dim IdRendicion As String
    Dim TipoCambioBL As New TipocambioBL
    Dim ReciboBL As New ReciboBL
    Dim ReciboRendicionBL As New RecibosRendicionBL
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    'Private _IdReciboRendicion As Int32
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    'Public Property IdreciboRendicion() As Int32
    '    Get
    '        Return _IdReciboRendicion
    '    End Get
    '    Set(ByVal value As Int32)
    '        Me._IdReciboRendicion = value
    '    End Set

    'End Property
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")


        IdRendicion = Request.QueryString("IdRendicion")

        Me.RadComboBox8.Filter = 1
        Me.RadComboBox6.Filter = 1
        Me.RadComboBox9.Filter = 1
        Me.RadComboBox2.Filter = 1

        'para sacar el ccosto
        Dim idCCosto As Nullable(Of Int32)
        If ReciboRendicionBL.GetRECIBOSRENDICIONByIdReciboRendicion(Session("IdReciboRendicion")).IdRecibo > 0 Then
            idCCosto = ReciboBL.GetRECIBOByIdReciboRendicion(Session("IdReciboRendicion")).IdCCosto
            If idCCosto.HasValue Then
                Me.RadComboBox2.SelectedValue = idCCosto
                Me.RadComboBox2.Enabled = False
            End If
        End If
       

        'PARA SACAR EL ID DE PROYECTO
        _Rendicion = RendicionBL.GetRENDICIONByIdRendicion(IdRendicion)
        Me.TextBox1.Text = _Rendicion.IdProyecto

        If TypeOf DataItem Is GridInsertionObject Then
            Me.RadNumericTextBox3.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Session("Fecha").ToString)
            Me.txtDate1.Text = Session("Fecha")
            Me.txtDate2.Text = Date.Parse(Me.txtDate1.Text).AddDays(15)
        Else
            Me.RadComboBox6.SelectedValue = DataBinder.Eval(DataItem, "IdDocumentoCont")
            Me.txtDate1.Text = DataBinder.Eval(DataItem, "FechaDocumento")
            Me.txtDate2.Text = DataBinder.Eval(DataItem, "FechaVencimiento")
            Me.txtDate3.Text = DataBinder.Eval(DataItem, "FechaPago")
            Me.RadNumericTextBox3.Text = DataBinder.Eval(DataItem, "TipoCambio")

            If Not (IsDBNull(DataBinder.Eval(DataItem, "IdProveedorCliente"))) Then
                _Proveedor = Proveedor.GetAllFromProveedorClienteById(DataBinder.Eval(DataItem, "IdProveedorCliente"))
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = DataBinder.Eval(DataItem, "IdProveedorCliente")

            End If
            Me.RadTextBox2.Text = DataBinder.Eval(DataItem, "Serie")
            Me.RadTextBox4.Text = DataBinder.Eval(DataItem, "NroDocumento")
            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "Monto")
            Me.RadTextBox3.Text = DataBinder.Eval(DataItem, "Glosa")
            Me.RadComboBox9.SelectedValue = DataBinder.Eval(DataItem, "IdTipoGasto")
            If Not (IsDBNull(DataBinder.Eval(DataItem, "IdCCosto"))) Then
                Me.RadComboBox2.SelectedValue = DataBinder.Eval(DataItem, "IdCCosto")

            End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Me.RadComboBox8.DataBind()

    End Sub

    Protected Sub txtDate1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDate1.TextChanged
        Me.RadNumericTextBox3.Text = TipoCambioBL.GetTIPOCAMBIOByFecha(Me.txtDate1.Text)
        Me.txtDate2.Text = Date.Parse(Me.txtDate1.Text).AddDays(15)
        Me.RadNumericTextBox3.Focus()
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
End Class