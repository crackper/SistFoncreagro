Imports Telerik.Web.UI
Public Class FrmListaRequerimientosAprobados
    Inherits System.Web.UI.Page

    Public Function ObtenerColor(ByVal estado As String) As Drawing.Color
        Dim vista = New Disenio
        Return vista.ObtenerColorRequerimiento(estado)
    End Function

    Protected Sub RadGrid1_ItemCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemCreated
        If TypeOf e.Item Is GridDataItem Then
            Dim imageButonImprimir As ImageButton = DirectCast(e.Item.FindControl("ibImprimir"), ImageButton)
            Dim IdReq = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdRequerimiento")
            imageButonImprimir.Attributes.Add("onClick", "CargarBandejaReporte(" & IdReq & "); return false;")
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class