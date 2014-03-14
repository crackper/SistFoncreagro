Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlCatalogoVenta
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Me.RadComboBox1.Filter = 1

        If TypeOf DataItem Is GridInsertionObject Then
            Me.TextBox1.Text = ""
        Else
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdClasificacion")
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Descripcion")
            Me.DropDownList1.SelectedValue = DataBinder.Eval(DataItem, "IdUnidadMedida")
            Me.DropDownList2.SelectedValue = DataBinder.Eval(DataItem, "IdTipoventa")
            Me.RadNumericTextBox1.Text = DataBinder.Eval(DataItem, "PrecioReferencia")
            If DataBinder.Eval(DataItem, "AfectoIGV").ToString = "S" Then
                Me.CheckBox1.Checked = True
            Else
                Me.CheckBox1.Checked = False
            End If
            If DataBinder.Eval(DataItem, "AfectoDetraccion").ToString = "S" Then
                Me.CheckBox2.Checked = True
            Else
                Me.CheckBox2.Checked = False
            End If

        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class