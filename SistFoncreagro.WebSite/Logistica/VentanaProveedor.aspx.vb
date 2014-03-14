Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class VentanaProveedor
    Inherits System.Web.UI.Page
    Dim provedorBl As IProveedorClienteBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Request.QueryString("tip") = "editar" Then
                provedorBl = New ProveedorClienteBL
                Dim proveedor = provedorBl.GetAllFromProveedorClienteById(CInt(Request.QueryString("id")))
                RadNumeroRuc.Text = proveedor.Ruc
                txtDireccion.Text = proveedor.Direccion
                txtNombreComercial.Text = proveedor.NombreComercial
                txtRubro.Text = proveedor.Rubro
                txtCiudad.Text = proveedor.Ciudad
                txtTelefono.Text = proveedor.Telefono1
                txtContacto.Text = proveedor.Contacto
                txtWeb.Text = proveedor.Web
                txtMail.Text = proveedor.Mail
                txtTelefono2.Text = proveedor.Telefono2
                txtCelular1.Text = proveedor.Celular1
                txtCelular2.Text = proveedor.Celular2
                ddlTipoDoc.SelectedValue = proveedor.IdTipoDocumento
                ddlTipoCuenta.SelectedValue = proveedor.TipoCuenta
                txtCuentaAbono.Text = proveedor.CuentaAbono
                ddlMoneda.SelectedValue = proveedor.IdMoneda
                ddlTipoPersona.SelectedValue = proveedor.TipoPersona
                If (proveedor.InternoExterno = True) Then
                    cbInternoExterno.Checked = True
                End If
                If proveedor.TipoPersona = "02" Or proveedor.TipoPersona = "03" Then
                    txtRazonSocialApellidoPaterno.Text = proveedor.RazonSocial
                    If proveedor.TipoPersona = "03" Then
                        Label1.Visible = False
                        RadNumeroRuc.Visible = False
                    End If
                Else
                    txtRazonSocialApellidoPaterno.Text = proveedor.ApellidoPaterno
                    txtApellidoMaterno.Text = proveedor.ApellidoMaterno
                    txtPrimerNombre.Text = proveedor.PrimerNombre
                    txtSegundoNombre.Text = proveedor.SegundoNombre
                    lblNombre.Text = "Apellido Paterno :"
                    txtApellidoMaterno.Visible = True
                    txtPrimerNombre.Visible = True
                    txtSegundoNombre.Visible = True
                    lblApellidoMaterno.Visible = True
                    lblPrimerNombre.Visible = True
                    lblSegundoNombre.Visible = True
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Dim respuesta As Boolean
        provedorBl = New ProveedorClienteBL
        Dim proveedor = New ProveedorCliente
        proveedor.Tipo = 1
        If RadNumeroRuc.Text.Length = 8 Or RadNumeroRuc.Text.Length = 11 Then
            If ddlTipoPersona.SelectedIndex = 2 Then
                proveedor.Ruc = ""
            Else
                proveedor.Ruc = RadNumeroRuc.Text
            End If
            If cbInternoExterno.Checked Then
                proveedor.InternoExterno = True
            Else
                proveedor.InternoExterno = False
            End If
            proveedor.TipoPersona = ddlTipoPersona.SelectedValue
            proveedor.RazonSocial = txtRazonSocialApellidoPaterno.Text
            proveedor.ApellidoPaterno = txtRazonSocialApellidoPaterno.Text
            proveedor.ApellidoMaterno = txtApellidoMaterno.Text
            proveedor.PrimerNombre = txtPrimerNombre.Text
            proveedor.SegundoNombre = txtSegundoNombre.Text
            proveedor.NombreComercial = txtNombreComercial.Text
            proveedor.Direccion = txtDireccion.Text
            proveedor.Rubro = txtRubro.Text
            proveedor.Ciudad = txtCiudad.Text
            proveedor.Telefono1 = txtTelefono.Text
            proveedor.Contacto = txtContacto.Text
            proveedor.Web = txtWeb.Text
            proveedor.Mail = txtMail.Text
            proveedor.Telefono2 = txtTelefono2.Text
            proveedor.Celular1 = txtCelular1.Text
            proveedor.Celular2 = txtCelular2.Text
            proveedor.IdTipoDocumento = ddlTipoDoc.SelectedValue
            proveedor.TipoCuenta = ddlTipoCuenta.SelectedValue
            proveedor.CuentaAbono = txtCuentaAbono.Text
            proveedor.IdMoneda = ddlMoneda.SelectedValue
            proveedor.Idusuario = Session("IdUser")
            If Request.QueryString("tip") = "editar" Then
                proveedor.IdProveedorCliente = CInt(Request.QueryString("id"))
                respuesta = provedorBl.SaveProveedorCliente(proveedor)
            Else
                respuesta = provedorBl.SaveProveedorCliente(proveedor)
            End If
            If respuesta = True Then
                Dim cadenaJava As String
                cadenaJava = "<script type='text/javascript'> " & _
                              " CerrarVentana(1); " & _
                              Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadenaJava.ToString, False)
            Else
                lblMensaje.Text = "El N° de documento ingresado ya se encuentra registrado en el Sistema."
            End If
        Else
            lblMensaje.Text = "Verifique el N° de Documento."
        End If
        
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim cadenaJava As String
        cadenaJava = "<script type='text/javascript'> " & _
                      " CerrarVentana(0); " & _
                      Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadenaJava.ToString, False)
    End Sub

    Protected Sub ddlTipoPersona_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlTipoPersona.SelectedIndexChanged
        If ddlTipoPersona.SelectedIndex = 1 Then
            lblNombre.Text = "Apellido Paterno :"
            txtApellidoMaterno.Visible = True
            txtPrimerNombre.Visible = True
            txtSegundoNombre.Visible = True
            lblApellidoMaterno.Visible = True
            lblPrimerNombre.Visible = True
            lblSegundoNombre.Visible = True
            RadNumeroRuc.Visible = True
            Label1.Visible = True
        Else
            lblNombre.Text = "Razón Social :"
            txtApellidoMaterno.Visible = False
            txtPrimerNombre.Visible = False
            txtSegundoNombre.Visible = False
            lblApellidoMaterno.Visible = False
            lblPrimerNombre.Visible = False
            lblSegundoNombre.Visible = False
            If ddlTipoPersona.SelectedIndex = 2 Then
                RadNumeroRuc.Visible = False
                Label1.Visible = False
            End If
        End If
        ddlTipoDoc.DataBind()
    End Sub
End Class