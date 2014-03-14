Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlVentas
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
            Me.TextBox2.Text = ""
        Else
            If DataBinder.Eval(DataItem, "IdCatVenta") > 0 Then
                Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdCatVenta")
            End If
            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "Cantidad")
            Me.RadNumericTextBox3.Text = DataBinder.Eval(DataItem, "PrecioUnitario")
            Me.RadNumericTextBox4.Text = DataBinder.Eval(DataItem, "Total")
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Glosa")
            Me.TextBox3.Text = DataBinder.Eval(DataItem, "IdSemoviente")
            Me.TextBox4.Text = DataBinder.Eval(DataItem, "IdMotivoVenta")

        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
    End Sub

    Protected Sub RadNumericTextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox2.TextChanged
        Me.RadNumericTextBox4.Value = Me.RadNumericTextBox2.Value * Me.RadNumericTextBox3.Value
        Me.RadNumericTextBox3.Focus()
    End Sub

    Protected Sub RadNumericTextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadNumericTextBox3.TextChanged
        Me.RadNumericTextBox4.Value = Me.RadNumericTextBox2.Value * Me.RadNumericTextBox3.Value
        Me.TextBox2.Focus()
    End Sub
End Class