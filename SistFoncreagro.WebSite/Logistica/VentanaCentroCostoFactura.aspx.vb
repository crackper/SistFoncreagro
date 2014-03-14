Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class VentanaCentroCostoFactura
    Inherits System.Web.UI.Page
    Dim facturaCCostoBl As IFacturaCentroCostoBL
    Dim ordenCCostoBl As IOrdenCentroCostoBL
    Dim facturaCCosto As New FacturaCentroCosto
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rcbTipoDocumento.Filter = 1
    End Sub

    Protected Sub gvFacturaCentroCosto_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvFacturaCentroCosto.RowCommand
        facturaCCostoBl = New FacturaCentroCostoBL
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim idCentroCostoFactura As Int32 = CInt(gvFacturaCentroCosto.DataKeys(index).Item(0).ToString)
            facturaCCostoBl.DeleteFacturaCentroCosto(idCentroCostoFactura)
            gvFacturaCentroCosto.DataBind()
        End If
    End Sub

    Protected Sub lbAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregar.Click
        facturaCCostoBl = New FacturaCentroCostoBL
        facturaCCosto.IdOrdenCentroCosto = rcbOrdenCentroCosto.SelectedValue
        facturaCCosto.IdTipoDocumento = rcbTipoDocumento.SelectedValue
        facturaCCosto.Serie = txtSerie.Text
        facturaCCosto.Numero = txtNumero.Text
        facturaCCosto.MontoFact = txtMonto.Text
        facturaCCostoBl.SaveFacturaCentroCosto(facturaCCosto)
        gvFacturaCentroCosto.DataBind()
        txtSerie.Text = ""
        txtNumero.Text = ""
        txtMonto.Text = ""
    End Sub

    Protected Sub lbFinalizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbFinalizar.Click
        ordenCCostoBl = New OrdenCentroCostoBL
        ordenCCostoBl.FinalizarRegOrdenCompraCentroCosto(rcbOrdenCentroCosto.SelectedValue)
        rcbOrdenCentroCosto.DataBind()
        gvFacturaCentroCosto.DataBind()
    End Sub

End Class