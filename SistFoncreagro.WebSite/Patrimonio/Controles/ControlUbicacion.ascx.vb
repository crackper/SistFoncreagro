Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlUbicacion
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
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
            Me.txtDate1.Text = Now
            Me.txtDate2.Enabled = False
        Else
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdProyecto")
            Me.txtDate1.Text = DataBinder.Eval(DataItem, "FechaInicio")
            If Not DataBinder.Eval(DataItem, "FechaFin").Equals(DBNull.Value) Then
                Me.txtDate1.Text = DataBinder.Eval(DataItem, "FechaFin")
            End If
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Observacion")
        End If
    End Sub

End Class