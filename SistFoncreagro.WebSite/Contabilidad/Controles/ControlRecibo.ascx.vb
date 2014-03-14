Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlRecibo
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim TransaccionBL As New TransaccionBL
    Dim _transaccion As Transaccion
    Dim IdTransaccion As String
    Dim PlanContableBl As New PlanContableBL
    Dim _PlanContable As PlanContable
    Dim TipoCambioBL As New TipocambioBL
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
     
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1

        If TypeOf DataItem Is GridInsertionObject Then
            Me.txtDate.Text = Session("Fecha")
            Me.RadNumericTextBox1.Focus()
        Else
            Me.RadNumericTextBox1.Text = DataBinder.Eval(DataItem, "Monto")
            Me.txtDate.Text = DataBinder.Eval(DataItem, "Fecha")
            Me.RadComboBox3.SelectedValue = DataBinder.Eval(DataItem, "IdProyecto")
            Me.RadComboBox4.SelectedValue = DataBinder.Eval(DataItem, "Beneficiario")
            Me.RadTextBox4.Text = DataBinder.Eval(DataItem, "Glosa")
            Me.RadComboBox5.SelectedValue = DataBinder.Eval(DataItem, "IdCCosto")

        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class