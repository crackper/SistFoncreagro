Imports System.Collections.Generic
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ListaVentasPendientes
    Inherits System.Web.UI.Page
    Dim TransaccionBL As New TransaccionBL
    Dim EjercicioBL As New EjercicioBL
    Dim ventaBL As New VentaBL
    Dim estadoMes As String = ""
    Dim Subdiario As Int32
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim cadena_java As String
        Dim IdVenta As Int32

        If e.CommandName = "Generar" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

            IdVenta = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdVenta")

            'generamos la transaccion de la venta
            Session("IdTransaccion") = TransaccionBL.GenerarTRANSACCIONByIdVenta(IdVenta, Session("IdUser"), Session("Fecha"))

            cadena_java = "<script type='text/javascript'> " & _
                                          " radopen('FrmVentas.aspx','Formulario'); " & _
                                          Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "Ver" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdVenta = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdVenta").ToString

            If editedItem.OwnerTableView.Items(editedItem.ItemIndex)("IdTipoDocumento").Text = "2" Then
                cadena_java = "<script type='text/javascript'> " & _
                                       " window.open('ReporteFacturaVenta.aspx?IdVenta=" + IdVenta.ToString + "'); " & _
                                       Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            Else
                cadena_java = "<script type='text/javascript'> " & _
                                       " window.open('ReporteBoletaVenta.aspx?IdVenta=" + IdVenta.ToString + "'); " & _
                                       Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            End If
        End If
    End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.Items.Item(i)("Generar").Text = ""
                Me.RadGrid1.Items.Item(i).FindControl("Observar").Visible = False
            Next
        End If
    End Sub

    Protected Sub RadGrid1_ItemCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemCreated
        If TypeOf e.Item Is GridDataItem Then
            Dim imageButon As ImageButton = DirectCast(e.Item.FindControl("Observar"), ImageButton)
            Dim IdVenta = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdVenta")

            imageButon.Attributes.Add("onClick", "openWin(" + IdVenta.ToString + "); return false;")
        End If
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument.StartsWith("Observar") Then
            Dim j() As String
            Dim observacion As String
            Dim id As String

            j = Split(e.Argument, "|")
            observacion = j(1)
            id = j(2)

            ventaBL.UpdateObservacionVENTA(id, observacion)
            ventaBL.UpdateEstadoVENTA(id, "O")
            Me.RadGrid1.Rebind()
        ElseIf e.Argument = "Validar" Then
            If Session("IdTransaccion") > 0 Then

                If TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Then
                    Dim cadena_java As String = _
                                             "<script type='text/javascript'> " & _
                                             " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmVentas.aspx','Formulario'); }  " & _
                                             Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                Else
                    Me.RadGrid1.Rebind()
                End If
            End If
        End If
    End Sub
End Class