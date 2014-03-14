Imports Telerik.Web.UI
Public Class ControlManttoRuta
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
            txtNombre.Text = ""
            txtDescripcion.Text = ""
            ImageButton3.Visible = False
        Else
            lblCodigotitulo.Visible = True
            lblCodigo.Visible = True
            lblCodigo.Text = DataBinder.Eval(DataItem, "Codigo").ToString
            txtNombre.Text = DataBinder.Eval(DataItem, "Nombre").ToString
            txtDescripcion.Text = DataBinder.Eval(DataItem, "Descripcion").ToString
            ImageButton2.Visible = False
        End If
    End Sub
End Class