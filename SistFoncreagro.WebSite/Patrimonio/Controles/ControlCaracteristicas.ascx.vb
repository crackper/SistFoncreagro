Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlCaracteristicas
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim IdSemoviente As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdSemoviente = Request.QueryString("IdSemoviente")
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

            Me.txtDate1.Text = DataBinder.Eval(DataItem, "FechaInicio")
            If Not DataBinder.Eval(DataItem, "FechaFin").Equals(DBNull.Value) Then
                Me.txtDate1.Text = DataBinder.Eval(DataItem, "FechaFin")
            End If
            Me.DropDownList1.SelectedValue = DataBinder.Eval(DataItem, "IdCategoriaAnimal")
            Me.DropDownList2.SelectedValue = DataBinder.Eval(DataItem, "IdEstadoSemoviente")
            Me.RadNumericTextBox1.Text = DataBinder.Eval(DataItem, "Peso")
            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "Valor")
        End If
    End Sub

End Class