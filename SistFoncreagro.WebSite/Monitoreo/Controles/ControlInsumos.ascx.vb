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
Imports System.IO
Public Class ControlInsumos
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim IdDetalleEje As String
    Dim DetalleEjeBL As New DetalleEjecucionBL
    Dim IdProyecto As Int32
    Dim Interesado As New InteresadosBL
    Dim _Interesado As Interesados
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdDetalleEje = Request.QueryString("IdDetalleEje")
        IdProyecto = DetalleEjeBL.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje).IdProyecto
        Me.HiddenField1.Value = IdProyecto
    End Sub
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox4.Filter = 1
        Me.RadComboBox8.Filter = 1
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(" + IdProyecto.ToString + "); return false;")

        If TypeOf DataItem Is GridInsertionObject Then
            ' Me.txtDate1.Text = Now
        Else
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "TipoAdquisicion")
            Me.RadComboBox5.SelectedValue = DataBinder.Eval(DataItem, "Tipo")
            Me.RadComboBox5.Enabled = False

            If DataBinder.Eval(DataItem, "IdInteresado") > 0 Then
                _Interesado = Interesado.GetINTERESADOSByIdInteresado(DataBinder.Eval(DataItem, "IdInteresado"))
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Interesado.Apellidos
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = DataBinder.Eval(DataItem, "IdInteresado")
            End If


            If Me.RadComboBox5.SelectedValue = "D" Then
                Me.RadComboBox1.Enabled = False
                Me.RadComboBox6.Visible = True
                Me.TextBox1.Visible = False
                Me.RadComboBox2.Visible = False
                Me.RadComboBox6.SelectedValue = DataBinder.Eval(DataItem, "Descripcion")
                Me.RadComboBox8.Enabled = True
                Me.RadComboBox8.SelectedValue = DataBinder.Eval(DataItem, "IdInteresado")
                Me.RadComboBox3.Enabled = True
                Me.RadNumericTextBox1.Enabled = True
            Else
                If Me.RadComboBox1.SelectedValue = "C" Then
                    Me.RadComboBox2.SelectedValue = DataBinder.Eval(DataItem, "IdCCosto").ToString + "-" + DataBinder.Eval(DataItem, "IdCatalogo").ToString + "-" + DataBinder.Eval(DataItem, "IdUnidad").ToString + "-" + DataBinder.Eval(DataItem, "PrecioUnitario").ToString + "-" + DataBinder.Eval(DataItem, "IdDetalleOrdenCompra").ToString
                    Me.RadComboBox2.Visible = True
                    Me.TextBox1.Visible = False
                    Me.RadComboBox3.Enabled = False
                    Me.RadNumericTextBox1.Enabled = False
                    Me.RadComboBox6.Visible = False
                Else
                    Me.RadComboBox2.Visible = False
                    Me.TextBox1.Visible = True
                    Me.RadComboBox3.Enabled = True
                    Me.RadNumericTextBox1.Enabled = True
                    Me.RadComboBox6.Visible = True
                End If
                Me.RadComboBox8.Enabled = False
            End If

           
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Descripcion")
            Me.RadComboBox3.SelectedValue = DataBinder.Eval(DataItem, "IdUnidad")
            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "Cantidad")
            Me.RadNumericTextBox1.Text = DataBinder.Eval(DataItem, "PrecioUnitario")
            Me.TextBox3.Text = DataBinder.Eval(DataItem, "Observaciones")
            Me.RadComboBox4.SelectedValue = DataBinder.Eval(DataItem, "IdCCosto")
        End If
    End Sub
    Protected Sub RadComboBox1_SelectedIndexChanged(sender As Object, e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        If Me.RadComboBox1.SelectedValue = "C" Then
            Me.RadComboBox2.Visible = True
            Me.TextBox1.Visible = False
            Me.RadComboBox3.Enabled = False
            Me.RadNumericTextBox1.Enabled = False
        Else
            Me.RadComboBox2.Visible = False
            Me.TextBox1.Visible = True
            Me.RadComboBox3.Enabled = True
            Me.RadNumericTextBox1.Enabled = True
        End If
    End Sub
    Protected Sub RadComboBox2_SelectedIndexChanged(sender As Object, e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox2.SelectedIndexChanged
        Dim j() As String
        Dim k() As String
        Dim Idunidad As Int32
        Dim IdProducto As Int32
        Dim IdCCosto As Int32
        'Dim IdOCxFactura As Int32
        Dim Precio As Decimal
        Dim IdDetalleOrdenCompra As Int32
        Dim Descripcion As String

        j = Split(Me.RadComboBox2.SelectedValue, "-")
        k = Split(Me.RadComboBox2.Text, "--")
        IdCCosto = j(0)
        IdProducto = j(1)
        'IdOCxFactura = j(2)
        Idunidad = j(2)
        Precio = j(3)
        IdDetalleOrdenCompra = j(4)
        If k.Length > 1 Then
            Descripcion = k(1)
        Else
            Descripcion = ""
        End If


        Me.RadComboBox3.SelectedValue = Idunidad
        Me.RadNumericTextBox1.Text = Precio
        Me.RadComboBox4.SelectedValue = IdCCosto
        Me.TextBox1.Text = Descripcion
    End Sub

   
    Protected Sub RadComboBox5_SelectedIndexChanged(sender As Object, e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox5.SelectedIndexChanged
        If Me.RadComboBox5.SelectedValue = "D" Then
            Me.RadComboBox1.SelectedValue = "S"
            Me.RadComboBox1.Enabled = False
            Me.RadComboBox2.Visible = False
            Me.TextBox1.Visible = False
            Me.RadComboBox3.Enabled = True
            Me.RadNumericTextBox1.Enabled = True
            Me.RadComboBox6.Visible = True
            Me.RadComboBox8.Enabled = True
        Else
            Me.RadComboBox1.SelectedValue = "C"
            Me.RadComboBox1.Enabled = True
            Me.RadComboBox2.Visible = True
            Me.TextBox1.Visible = False
            Me.RadComboBox3.Enabled = False
            Me.RadNumericTextBox1.Enabled = False
            Me.RadComboBox6.Visible = False
            Me.RadComboBox8.Enabled = False
        End If
    End Sub
    Protected Sub RadComboBox8_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox8.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).Apellidos.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).Nombres.ToString() + " - DNI: " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).Dni.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).IdInteresado.ToString()

    End Sub

    Protected Sub RadComboBox8_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox8.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox8.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString
            Me.RadComboBox8.DataBind()
        End If
    End Sub
    
End Class