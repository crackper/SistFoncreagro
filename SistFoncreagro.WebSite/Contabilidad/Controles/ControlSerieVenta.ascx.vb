Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlSerieVenta
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim PlanContableBl As New PlanContableBL
    Dim _PlanContable As PlanContable
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
        Me.RadComboBox1.Filter = 1

        If TypeOf DataItem Is GridInsertionObject Then
            Me.TextBox2.Enabled = False
            Me.TextBox2.Text = 0
        Else
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Serie")
            Me.TextBox2.Enabled = True
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Actual")
            Me.DropDownList1.SelectedValue = DataBinder.Eval(DataItem, "IdTipoDoumento")
            If Not DataBinder.Eval(DataItem, "IdProyecto").Equals(DBNull.Value) Then
                Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdProyecto")
            End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub
End Class
