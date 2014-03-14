Imports Telerik.Web.UI
Public Class ControlManttoProveedor
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
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding

        If TypeOf DataItem Is GridInsertionObject Then
            txtRuc.Text = ""
            txtRazonSocial.Text = ""
            txtDireccion.Text = ""
            txtRubro.Text = ""
            txtCiudad.Text = ""
            txtTelefono.Text = ""
            txtContacto.Text = ""
            txtWeb.Text = ""
            txtMail.Text = ""
            txtTelefono2.Text = ""
            txtCelular1.Text = ""
            txtCelular2.Text = ""
            ImageButton3.Visible = False
        Else
            txtRuc.Text = DataBinder.Eval(DataItem, "Ruc").ToString
            txtRazonSocial.Text = DataBinder.Eval(DataItem, "RazonSocial").ToString
            txtDireccion.Text = DataBinder.Eval(DataItem, "Direccion").ToString
            If DataBinder.Eval(DataItem, "Rubro") = Nothing Then
                txtRubro.Text = ""
            Else
                txtRubro.Text = DataBinder.Eval(DataItem, "Rubro").ToString
            End If
            If DataBinder.Eval(DataItem, "Ciudad") = Nothing Then
                txtCiudad.Text = ""
            Else
                txtCiudad.Text = DataBinder.Eval(DataItem, "Ciudad").ToString
            End If
            If DataBinder.Eval(DataItem, "Telefono1") = Nothing Then
                txtTelefono.Text = ""
            Else
                txtTelefono.Text = DataBinder.Eval(DataItem, "Telefono1").ToString
            End If
            If DataBinder.Eval(DataItem, "Contacto") = Nothing Then
                txtContacto.Text = ""
            Else
                txtContacto.Text = DataBinder.Eval(DataItem, "Contacto").ToString
            End If

            If DataBinder.Eval(DataItem, "Web") = Nothing Then
                txtWeb.Text = ""
            Else
                txtWeb.Text = DataBinder.Eval(DataItem, "Web").ToString
            End If
            If DataBinder.Eval(DataItem, "Mail") = Nothing Then
                txtMail.Text = ""
            Else
                txtMail.Text = DataBinder.Eval(DataItem, "Mail").ToString
            End If
            If DataBinder.Eval(DataItem, "Telefono2") = Nothing Then
                txtTelefono2.Text = ""
            Else
                txtTelefono2.Text = DataBinder.Eval(DataItem, "Telefono2").ToString
            End If
            If DataBinder.Eval(DataItem, "Celular1") = Nothing Then
                txtCelular1.Text = ""
            Else
                txtCelular1.Text = DataBinder.Eval(DataItem, "Celular1").ToString
            End If
            If DataBinder.Eval(DataItem, "Celular2") = Nothing Then
                txtCelular2.Text = ""
            Else
                txtCelular2.Text = DataBinder.Eval(DataItem, "Celular2").ToString
            End If
            ImageButton2.Visible = False
        End If
    End Sub
End Class