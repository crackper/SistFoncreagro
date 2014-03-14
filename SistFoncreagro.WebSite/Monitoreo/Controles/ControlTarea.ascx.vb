Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlTarea
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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then

        Else
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Codigo")
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Unidad")
            Me.TextBox3.Text = DataBinder.Eval(DataItem, "NomTarea")
            Me.RadNumericTextBox1.Text = DataBinder.Eval(DataItem, "Porcentaje")
            If DataBinder.Eval(DataItem, "FinalizaActividad") = "S" Then
                Me.CheckBox1.Checked = True
            Else
                Me.CheckBox1.Checked = False
            End If
        End If
    End Sub
End Class