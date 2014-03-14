Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlCuentaProyecto
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim PlanContableBl As New PlanContableBL
    Dim _PlanContable As PlanContable

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
            Me.RadComboBox1.Enabled = True
        Else
            Me.RadComboBox1.Enabled = False
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Descripcion")
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "Idproyecto")
        End If
    End Sub
End Class