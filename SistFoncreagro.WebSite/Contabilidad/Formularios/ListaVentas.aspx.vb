Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Data.OleDb
Public Class ListaVentas
    Inherits System.Web.UI.Page
    Dim IdVenta As Int32
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Dim ventaBL As New VentaBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If

    End Sub
    Public Function DescEstado(ByVal Estado As String) As String
        Dim descripcion As String = ""
        Select Case Estado
            Case "E"
                descripcion = "En Espera"
            Case "P"
                descripcion = "Pendiente"
            Case "G"
                descripcion = "Facturado"
            Case "A"
                descripcion = "Anulado"
            Case "V"
                descripcion = "Por Aprobar"
            Case "C"
                descripcion = "Contabilizado"
            Case "O"
                descripcion = "Observado"
        End Select
        Return descripcion
    End Function
    Public Function Color(ByVal Estado As String) As Drawing.Color
        Dim col As Drawing.Color
        Select Case Estado
            Case "E"
                col = Drawing.Color.Red
            Case "P"
                col = Drawing.Color.Green
            Case "G"
                col = Drawing.Color.Blue
            Case "A"
                col = Drawing.Color.Gray
            Case "V"
                col = Drawing.Color.YellowGreen
            Case "C"
                col = Drawing.Color.Black
            Case "O"
                col = Drawing.Color.OrangeRed
        End Select

        Return col
    End Function
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim cadena_java As String

       If e.CommandName = "InitInsert" Then
            e.Canceled = True
            IdVenta = 0
          
            cadena_java = "<script type='text/javascript'> " & _
                        " radopen('FrmFacturar.aspx?IdVenta=" + IdVenta.ToString + "','Formulario'); " & _
                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

        ElseIf e.CommandName = "Edit" Then
            e.Canceled = True
            IdVenta = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdVenta").ToString

            cadena_java = "<script type='text/javascript'> " & _
                           " radopen('FrmFacturar.aspx?IdVenta=" + IdVenta.ToString + "','Formulario'); " & _
                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

        ElseIf e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdVenta = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdVenta").ToString

            If editedItem.OwnerTableView.Items(editedItem.ItemIndex)("NroSerie").Text = "" Then
                ventaBL.DeleteVENTA(IdVenta)
            Else
                ventaBL.UpdateEstadoVENTA(IdVenta, "Anulado")
            End If
            Me.RadGrid1.DataBind()
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
   
    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        Dim result As Int32
        result = Integer.Parse(e.Argument)
        If e.Argument = 1 Then
            Me.RadGrid1.Rebind()
        End If
       
    End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If estadoMes = "C" Then
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                e.Item.OwnerTableView.Items.Item(i)("Anular").Enabled = False
                e.Item.OwnerTableView.Items.Item(i)("Anular").BackColor = Drawing.Color.Gray
            Next
        Else
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                If (CType(e.Item.OwnerTableView.Items(i).FindControl("Label2"), Label).Text = "Anulado") Then
                    e.Item.OwnerTableView.Items.Item(i)("editar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
                ElseIf (CType(e.Item.OwnerTableView.Items(i).FindControl("Label2"), Label).Text = "Por Aprobar") Then
                    e.Item.OwnerTableView.Items.Item(i)("editar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("anular").Enabled = False
                End If
            Next
        End If
    End Sub
End Class