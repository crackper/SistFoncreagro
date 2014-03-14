Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlDepreciacion
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
            Me.RadNumericTextBox1.Text = 0
        Else
            Me.RadNumericTextBox1.Text = DataBinder.Eval(DataItem, "MesesDepreciados")
            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "DepreciacionAcumulada")
            Me.HiddenField1.Value = DataBinder.Eval(DataItem, "Porcentaje")
            If Not DataBinder.Eval(DataItem, "IdBienMueble").Equals(DBNull.Value) Then
                Me.HiddenField2.Value = DataBinder.Eval(DataItem, "IdBienMueble")
            Else
                Me.HiddenField3.Value = DataBinder.Eval(DataItem, "IdBienInmueble")
            End If

        End If
    End Sub
End Class