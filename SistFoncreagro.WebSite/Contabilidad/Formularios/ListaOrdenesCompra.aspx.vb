Imports System.Collections.Generic
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ListaOrdenesCompra
    Inherits System.Web.UI.Page
    Dim TransaccionBL As New TransaccionBL
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Dim Subdiario As Int32
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim cadena_java As String

        If e.CommandName = "Generar" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdOcxFactura As Int32
            '  Session("Ventana") = "~\Contabilidad\Formularios\ListaOrdenesCompra.aspx"
            IdOcxFactura = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdOcxFactura")
            Session("IdTransaccion") = TransaccionBL.GenerarTRANSACCIONordenCompra(IdOcxFactura, Session("Fecha"), Session("IdUser"))
            Subdiario = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).IdSubDiario

            If (Subdiario = 4) Then
                'Response.Redirect("~\Contabilidad\Formularios\FrmHonorarios.aspx")
                cadena_java = "<script type='text/javascript'> " & _
                                          " radopen('FrmHonorarios.aspx','Formulario'); " & _
                                          Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            Else
                ' Response.Redirect("~\Contabilidad\Formularios\FrmCompras.aspx")
                cadena_java = "<script type='text/javascript'> " & _
                                          " radopen('FrmCompras.aspx','Formulario'); " & _
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
            Dim idOCxFactura = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdOcxFactura")

            imageButon.Attributes.Add("onClick", "openWin(" + idOCxFactura.ToString + "); return false;")
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

            TransaccionBL.UpdateMotivoOCxFactura(id, observacion)
            Me.RadGrid1.Rebind()
        ElseIf e.Argument = "Validar" Then
            If Session("IdTransaccion") > 0 Then

                If TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Then
                    Subdiario = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).IdSubDiario

                    If (Subdiario = 4) Then
                        Dim cadena_java As String = _
                                            "<script type='text/javascript'> " & _
                                            " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmHonorarios.aspx','Formulario'); }  " & _
                                            Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    Else
                        Dim cadena_java As String = _
                                             "<script type='text/javascript'> " & _
                                             " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmCompras.aspx','Formulario'); }  " & _
                                             Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    End If

                Else
                    Me.RadGrid1.Rebind()
                End If
            End If
        End If
    End Sub
End Class