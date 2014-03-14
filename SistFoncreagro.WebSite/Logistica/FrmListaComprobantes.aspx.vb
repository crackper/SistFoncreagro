Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmListaComprobantes
    Inherits System.Web.UI.Page
    Dim IOcxFacturaBl As New OcxFacturaBL

    Dim proveedorCliente As ProveedorCliente
    Dim proveedorBl As New ProveedorClienteBL
    Private _userControl As Object
    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "InitInsert" Then
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                 " NuevoComprobante(); " & _
                                 Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            e.Canceled = True
        End If
    End Sub
    Protected Sub RadGrid2_ItemCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid2.ItemCreated
        If TypeOf e.Item Is GridDataItem Then
            Dim imageButon As ImageButton = DirectCast(e.Item.FindControl("EditButton"), ImageButton)
            Dim fin = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Finalizado")
            Dim ocxFactura = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdOcxfactura")
            Dim area = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdArea")
            Dim idProv = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdProveedor")
            Dim nombreProv = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("NombreProveedor")
            Dim tipoDoc = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTipoDocumento")
            Dim moneda = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdMoneda")
            Dim seri = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Serie")
            Dim numer = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Numero")
            Dim mont = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Monto")
            Dim fech = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Fecha")
            Dim obs = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Observaciones")
            Dim nrovale = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("NroVales")
            Dim fechrec = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("FechaRecepcion")
            imageButon.Attributes.Add("onClick", "editarComprobante('" & fin & "'," & ocxFactura & "," & area & "," & idProv & ",'" & nombreProv & "'," & tipoDoc & "," & moneda & ",'" & seri & "', '" & numer & "'," & mont & ",'" & CStr(fech) & "', '" & obs & "'," & nrovale & ", '" & CStr(fechrec) & "'); return false;")
        End If
    End Sub
    Public Function ObtenerEstado(ByVal estado As Boolean) As String
        If estado = True Then
            Return "Finalizado"
        Else
            Return "Pendiente"
        End If
    End Function
  Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "UpdateRadGrid" Then
            Me.RadGrid2.DataBind()
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub
End Class