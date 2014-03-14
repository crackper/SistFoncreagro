Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlBonificacion
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
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdTipoBonificacion")
            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "Cantidad")
            Me.RadNumericTextBox3.Text = DataBinder.Eval(DataItem, "Importe")
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Glosa")
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class