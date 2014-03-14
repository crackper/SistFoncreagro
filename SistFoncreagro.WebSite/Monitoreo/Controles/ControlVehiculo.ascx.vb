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
Public Class ControlVehiculo
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
        If TypeOf DataItem Is GridInsertionObject Then
            ' Me.txtDate1.Text = Now
        Else
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Marca")
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Modelo")
            Me.TextBox4.Text = DataBinder.Eval(DataItem, "Placa")
            Me.TextBox3.Text = DataBinder.Eval(DataItem, "Observaciones")
            Me.DropDownList1.SelectedValue = DataBinder.Eval(DataItem, "Tipo")
            If DataBinder.Eval(DataItem, "Implementacion") = "S" Then
                Me.RadioButtonList1.SelectedValue = "S"
            Else
                Me.RadioButtonList1.SelectedValue = "N"
            End If
            If DataBinder.Eval(DataItem, "Mantenimiento") = "S" Then
                Me.RadioButtonList2.SelectedValue = "S"
            Else
                Me.RadioButtonList2.SelectedValue = "N"
            End If
            Me.TextBox5.Text = DataBinder.Eval(DataItem, "Incidentes")
        End If
    End Sub

End Class