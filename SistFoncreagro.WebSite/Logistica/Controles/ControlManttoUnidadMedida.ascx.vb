Imports Telerik.Web.UI
Public Class ControlManttoUnidadMedida
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

    Private Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then
            txtDescripcion.Text = ""
            txtAbreviacion.Text = ""
            ImageButton3.Visible = False
        Else
            txtDescripcion.Text = DataBinder.Eval(DataItem, "Descripcion").ToString
            txtAbreviacion.Text = DataBinder.Eval(DataItem, "Abreviacion").ToString
            ImageButton2.Visible = False
        End If
    End Sub
End Class