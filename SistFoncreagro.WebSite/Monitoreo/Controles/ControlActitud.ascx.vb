Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlActitud
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim Interesado As New InteresadosBL
    Dim _Interesado As Interesados
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
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then
            Me.txtDate.Text = Date.Now
        Else
            Me.txtDate.Text = DataBinder.Eval(DataItem, "FechaInicio")
            Me.DropDownList4.SelectedValue = DataBinder.Eval(DataItem, "Actitud")
            Me.DropDownList5.SelectedValue = DataBinder.Eval(DataItem, "Poder")
            Me.DropDownList6.SelectedValue = DataBinder.Eval(DataItem, "Dialogo")
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Comentario")
            Me.TextBox3.Text = DataBinder.Eval(DataItem, "PlanAccion")
        End If
    End Sub
End Class