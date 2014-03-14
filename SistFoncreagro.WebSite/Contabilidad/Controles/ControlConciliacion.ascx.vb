Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlConciliacion
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim Proveedor As New ProveedorClienteBL
    Dim _Proveedor As ProveedorCliente
    Dim IdConciliacion As String
    'Private _IdReciboRendicion As Int32
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")
        IdConciliacion = Request.QueryString("IdConciliacion")

        Me.RadComboBox8.Filter = 1
        Me.RadComboBox6.Filter = 1

        If TypeOf DataItem Is GridInsertionObject Then
            Me.txtDate1.Text = Session("Fecha")

        Else
            Me.txtDate1.Text = DataBinder.Eval(DataItem, "Fecha")

            If Not (IsDBNull(DataBinder.Eval(DataItem, "IdProveedorCliente"))) Then
                _Proveedor = Proveedor.GetAllFromProveedorClienteById(DataBinder.Eval(DataItem, "IdProveedorCliente"))
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = DataBinder.Eval(DataItem, "IdProveedorCliente")

            End If

            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "Monto")
            Me.RadTextBox3.Text = DataBinder.Eval(DataItem, "Glosa")

        End If
    End Sub

    'Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
    '    MsgBox("Hola")
    '    ' Response.Redirect("FrmConciliacion.aspx?IdConciliacion=" + ID.ToString)
    'End Sub
End Class