Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class VentanaCatalogo
    Inherits System.Web.UI.Page
    Dim catalogoLogic As ICatalogoBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            rcbClasificacion.Filter = 1
            If Request.QueryString("tip") = "editar" Then
                catalogoLogic = New CatalogoBL
                Dim aCatalogo = catalogoLogic.GetAllFromCatalogoByIdCatalogo(CInt(Request.QueryString("id")))
                lblNumero.Text = aCatalogo.Codigo
                txtDescripcion.Text = aCatalogo.Descripcion
                rcbClasificacion.SelectedValue = aCatalogo.IdClasificacionGeneral
                cbIgv.Checked = aCatalogo.AfectoIgv
                rtxtPrecioReferencia.Text = aCatalogo.PrecioCompra
                ddlMonedaCompra.SelectedValue = aCatalogo.IdMonedaCompra
                ddlUnidadMedida.SelectedValue = aCatalogo.IdUnidadMedida
                ddlMarca.SelectedValue = aCatalogo.IdMarca
            Else
                lbTitulo.Text = "NUEVO PRODUCTO"
                lblTituloNumero.Visible = False
                lblNumero.Visible = False
            End If
        End If
    End Sub
    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        catalogoLogic = New CatalogoBL
        Dim catalogoEntity As New Catalogo
        catalogoEntity.Descripcion = txtDescripcion.Text
        catalogoEntity.IdMarca = ddlMarca.SelectedValue
        catalogoEntity.IdUnidadMedida = ddlUnidadMedida.SelectedValue
        catalogoEntity.IdClasificacionGeneral = rcbClasificacion.SelectedValue
        catalogoEntity.PrecioCompra = CDec(rtxtPrecioReferencia.Text)
        catalogoEntity.AfectoIgv = IIf(cbIgv.Checked = True, True, False)
        catalogoEntity.IdMonedaCompra = ddlMonedaCompra.SelectedValue
        If Request.QueryString("tip") = "editar" Then
            catalogoEntity.IdCatalogo = CInt(Request.QueryString("id"))
            catalogoLogic.UpdateCatalogo(catalogoEntity)
        Else
            catalogoEntity.Tipo = 0
            catalogoLogic.SaveCatalogo(catalogoEntity)
        End If
        Dim cadenaJava As String
        cadenaJava = "<script type='text/javascript'> " & _
                      " CerrarVentana(1); " & _
                      Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadenaJava.ToString, False)
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim cadenaJava As String
        cadenaJava = "<script type='text/javascript'> " & _
                      " CerrarVentana(0); " & _
                      Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadenaJava.ToString, False)

    End Sub
End Class