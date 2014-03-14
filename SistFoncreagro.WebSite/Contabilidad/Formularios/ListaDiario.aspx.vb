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
Public Class ListaDiario
    Inherits System.Web.UI.Page
    Dim TransaccionBL As New TransaccionBL
    Dim IdSubDiario As Integer
    Dim Flag As String
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Dim ProyectoBL As New ProyectoBL

    Private _ordersExpandedState As Hashtable
    Private _selectedState As Hashtable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If

        If Not IsPostBack Then
            'reset states
            Me._ordersExpandedState = Nothing
            Me.Session("_ordersExpandedState") = Nothing
            Me._selectedState = Nothing
            Me.Session("_selectedState") = Nothing
        End If

    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim estadoMes As String = ""
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))

        If e.CommandName = "InitInsert" Then
            e.Canceled = True
            '  Session("Ventana") = "ListaDiario.aspx"
            Session("IdTransaccion") = 0
            'Response.Redirect("~\Contabilidad\Formularios\FrmDiario.aspx?Flag=N")

            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                                         " radopen('FrmDiario.aspx?Flag=N','Formulario'); " & _
                                         Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
        If "Transacciones".Equals(e.Item.OwnerTableView.Name) Then
            If e.CommandName = "Anular" Then
                Dim IdTran As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTransaccion").ToString
                TransaccionBL.AnularTRANSACCIONCaja(IdTran)
                Me.odsTransaccion.DataBind()
                Me.RadGrid1.DataBind()
            ElseIf e.CommandName = "Ver" Then
                Dim IdTran As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTransaccion").ToString
                Session("IdTransaccion") = IdTran

                Dim IdSubDiario As Integer
                Dim Flag As String

                IdSubDiario = TransaccionBL.GetTransaccionByIdTransaccion(IdTran).IdSubDiario
                Flag = TransaccionBL.GetTransaccionByIdTransaccion(IdTran).Flag

                If IdSubDiario = 2 Then
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " window.open('Voucher.aspx?Tipo=C'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf IdSubDiario = 3 Then
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " window.open('Voucher.aspx?Tipo=V'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf IdSubDiario = 4 Then
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " window.open('Voucher.aspx?Tipo=H'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf Flag = "I" And IdSubDiario <> 5 Then
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " window.open('Voucher.aspx?Tipo=I'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf Flag = "E" And IdSubDiario <> 5 Then
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " window.open('Voucher.aspx?Tipo=E'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                Else
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " window.open('Voucher.aspx?Tipo=D'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                End If
            ElseIf e.CommandName = "Editar" Then
                Dim IdTran As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTransaccion").ToString
                Session("IdTransaccion") = IdTran

                IdSubDiario = TransaccionBL.GetTransaccionByIdTransaccion(IdTran).IdSubDiario
                Flag = TransaccionBL.GetTransaccionByIdTransaccion(IdTran).Flag

                If IdSubDiario = 2 Then
                    ' Response.Redirect("~\Contabilidad\Formularios\FrmCompras.aspx")

                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmCompras.aspx','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf IdSubDiario = 3 Then
                    ' Response.Redirect("~\Contabilidad\Formularios\FrmVentas.aspx")
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmVentas.aspx','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf IdSubDiario = 4 Then
                    ' Response.Redirect("~\Contabilidad\Formularios\FrmHonorarios.aspx")
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmHonorarios.aspx','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf Flag = "I" Then
                    ' Response.Redirect("~\Contabilidad\Formularios\FrmCajaIngresos.aspx?Flag=I")
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmCajaIngresos.aspx?Flag=I','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf Flag = "E" Then
                    '  Response.Redirect("~\Contabilidad\Formularios\FrmCajaEgresos.aspx?Flag=E")
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmCajaEgresos.aspx?Flag=E','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf Flag = "Y" Then
                    ' Response.Redirect("~\Contabilidad\Formularios\FrmTransitorioIngresos.aspx?Flag=Y")
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmTransitorioIngresos.aspx?Flag=Y','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                ElseIf Flag = "Z" Then
                    ' Response.Redirect("~\Contabilidad\Formularios\FrmTransitorioEgresos.aspx?Flag=Z")
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmTransitorioEgresos.aspx?Flag=Z','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                Else
                    ' Response.Redirect("~\Contabilidad\Formularios\FrmDiario.aspx?Flag=N")
                    Dim cadena_java As String
                    cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmDiario.aspx?Flag=N','Formulario'); " & _
                                                 Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
                End If
            End If
        End If

        'save the expanded/selected state in the session
        If e.CommandName = RadGrid.ExpandCollapseCommandName Then
            'Is the item about to be expanded or collapsed
            If Not e.Item.Expanded Then
                'Save its unique index among all the items in the hierarchy
                Me.ExpandedStates(e.Item.ItemIndexHierarchical) = True
            Else
                'collapsed
                Me.ExpandedStates.Remove(e.Item.ItemIndexHierarchical)
                Me.ClearSelectedChildren(e.Item.ItemIndexHierarchical)
                Me.ClearExpandedChildren(e.Item.ItemIndexHierarchical)
            End If
            'Is the item about to be selected 
        ElseIf e.CommandName = RadGrid.SelectCommandName Then
            'Save its unique index among all the items in the hierarchy
            Me.SelectedStates(e.Item.ItemIndexHierarchical) = True
            'Is the item about to be deselected 
        ElseIf e.CommandName = RadGrid.DeselectCommandName Then
            Me.SelectedStates.Remove(e.Item.ItemIndexHierarchical)
        End If
    End Sub
    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        If "Transacciones".Equals(e.Item.OwnerTableView.Name) Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Try
                Dim ID As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTransaccion").ToString
                TransaccionBL.DeleteTransaccion(ID)
                ' Me.RadGrid1.Rebind()
            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try
        End If
    End Sub
    Public Function DescEstado(ByVal Estado As String) As String
        Dim descripcion As String = ""
        Select Case Estado
            Case "S"
                descripcion = "Sin Procesar"
            Case "P"
                descripcion = "Procesado"
            Case "A"
                descripcion = "Actualizado"
            Case "N"
                descripcion = "Anulado"
            Case "C"
                descripcion = "Cancelado"
            Case "E"
                descripcion = "Errado"
            Case "V"
                descripcion = "Validado"
        End Select
        Return descripcion
    End Function
    Public Function Color(ByVal Estado As String) As Drawing.Color
        Dim col As Drawing.Color
        Select Case Estado
            Case "S"
                col = Drawing.Color.Red
            Case "P"
                col = Drawing.Color.Blue
            Case "A"
                col = Drawing.Color.Blue
            Case "N"
                col = Drawing.Color.Gray
            Case "C"
                col = Drawing.Color.Black
            Case "V"
                col = Drawing.Color.Blue
            Case "E"
                col = Drawing.Color.Red
        End Select

        Return col
    End Function
    Public Function Proyecto(ByVal id As Int32) As String
        Dim nombre As String
        nombre = ProyectoBL.GetFromProyectoByIdProyecto(id).Codigo
        Return nombre
    End Function

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        Dim estadoMes As String = ""
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))

        If "Transacciones".Equals(e.Item.OwnerTableView.Name) Then
            If estadoMes = "C" Then
                For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                    e.Item.OwnerTableView.Items.Item(i)("eliminar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("eliminar").BackColor = Drawing.Color.Gray
                    e.Item.OwnerTableView.Items.Item(i)("anular").BackColor = Drawing.Color.Gray
                Next
            Else
                For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                    If (CType(e.Item.OwnerTableView.Items(i).FindControl("Label2"), Label).Text = "Anulado") Then
                        'e.Item.OwnerTableView.Items.Item(i)("editar").Enabled = False
                        'e.Item.OwnerTableView.Items.Item(i)("eliminar").Enabled = False
                        'e.Item.OwnerTableView.Items.Item(i)("anular").Enabled = False
                        e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
                    End If
                    If (e.Item.OwnerTableView.Items(i)("IdSubdiario").Text <> "1") Then

                        For Each column As GridColumn In RadGrid1.Columns
                            If (column.UniqueName = "CtaCte") Then
                                CType(column, GridBoundColumn).HeaderStyle.Width = 0
                                CType(column, GridBoundColumn).ItemStyle.Width = 0
                                Exit For
                            End If
                        Next
                    End If
                Next
            End If
        End If

    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            If Session("IdTransaccion") > 0 Then

                IdSubDiario = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).IdSubDiario
                Flag = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Flag

                If (TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "S" Or TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Estado = "A") Then

                    If IdSubDiario = 2 Then
                        Dim cadena_java As String = _
                                              "<script type='text/javascript'> " & _
                                              " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmCompras.aspx','Formulario'); }  " & _
                                              Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()

                    ElseIf IdSubDiario = 3 Then
                        Dim cadena_java As String = _
                                              "<script type='text/javascript'> " & _
                                              " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmVentas.aspx','Formulario'); }  " & _
                                              Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    ElseIf IdSubDiario = 4 Then
                        ' Response.Redirect("~\Contabilidad\Formularios\FrmHonorarios.aspx")
                        Dim cadena_java As String = _
                                             "<script type='text/javascript'> " & _
                                             " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmHonorarios.aspx','Formulario'); }  " & _
                                             Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    ElseIf Flag = "I" Then
                        ' Response.Redirect("~\Contabilidad\Formularios\FrmCajaIngresos.aspx?Flag=I")
                        Dim cadena_java As String = _
                                              "<script type='text/javascript'> " & _
                                              " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmCajaIngresos.aspx?Flag=I','Formulario'); }  " & _
                                              Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    ElseIf Flag = "E" Then
                        Dim cadena_java As String = _
                                             "<script type='text/javascript'> " & _
                                             " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmCajaEgresos.aspx?Flag=E','Formulario'); }  " & _
                                             Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    ElseIf Flag = "Y" Then
                        ' Response.Redirect("~\Contabilidad\Formularios\FrmTransitorioIngresos.aspx?Flag=Y")
                        Dim cadena_java As String = _
                                             "<script type='text/javascript'> " & _
                                             " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmTransitorioIngresos.aspx?Flag=Y','Formulario'); }  " & _
                                             Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    ElseIf Flag = "Z" Then
                        ' Response.Redirect("~\Contabilidad\Formularios\FrmTransitorioEgresos.aspx?Flag=Z")
                        Dim cadena_java As String = _
                                              "<script type='text/javascript'> " & _
                                              " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmTransitorioEgresos.aspx?Flag=Z','Formulario'); }  " & _
                                              Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    Else
                        ' Response.Redirect("~\Contabilidad\Formularios\FrmDiario.aspx?Flag=N")
                        Dim cadena_java As String = _
                                              "<script type='text/javascript'> " & _
                                              " if (confirm('¡Debe validar el Voucher!')) { radopen('FrmDiario.aspx?Flag=N','Formulario'); }  " & _
                                              Chr(60) & "/script>"
                        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                        Me.RadGrid1.Rebind()
                    End If

                Else
                    Me.RadGrid1.Rebind()
                End If
            End If
        ElseIf e.Argument = "Actualizar" Then
            Me.RadGrid1.Rebind()
        End If
    End Sub

    Private ReadOnly Property ExpandedStates() As Hashtable
        Get
            If Me._ordersExpandedState Is Nothing Then
                _ordersExpandedState = TryCast(Me.Session("_ordersExpandedState"), Hashtable)
                If _ordersExpandedState Is Nothing Then
                    _ordersExpandedState = New Hashtable()
                    Me.Session("_ordersExpandedState") = _ordersExpandedState
                End If
            End If

            Return Me._ordersExpandedState
        End Get
    End Property

    'Clear the state for all expanded children if a parent item is collapsed
    Private Sub ClearExpandedChildren(ByVal parentHierarchicalIndex As String)
        Dim indexes As String() = New String(Me.ExpandedStates.Keys.Count - 1) {}
        Me.ExpandedStates.Keys.CopyTo(indexes, 0)
        For Each index As String In indexes
            'all indexes of child items
            If index.StartsWith(parentHierarchicalIndex + "_") OrElse index.StartsWith(parentHierarchicalIndex + ":") Then
                Me.ExpandedStates.Remove(index)
            End If
        Next
    End Sub

    Private Sub ClearSelectedChildren(ByVal parentHierarchicalIndex As String)
        Dim indexes As String() = New String(Me.SelectedStates.Keys.Count - 1) {}
        Me.SelectedStates.Keys.CopyTo(indexes, 0)
        For Each index As String In indexes
            'all indexes of child items
            If index.StartsWith(parentHierarchicalIndex + "_") OrElse index.StartsWith(parentHierarchicalIndex + ":") Then
                Me.SelectedStates.Remove(index)
            End If
        Next
    End Sub

    'Save/load selected states Hash from the session
    'this can also be implemented in the ViewState
    Private ReadOnly Property SelectedStates() As Hashtable
        Get
            If Me._selectedState Is Nothing Then
                _selectedState = TryCast(Me.Session("_selectedState"), Hashtable)
                If _selectedState Is Nothing Then
                    _selectedState = New Hashtable()
                    Me.Session("_selectedState") = _selectedState
                End If
            End If

            Return Me._selectedState
        End Get
    End Property

    Protected Sub RadGrid1_DataBound1(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.DataBound
        'Expand all items using our custom storage
        Dim indexes As String() = New String(Me.ExpandedStates.Keys.Count - 1) {}
        Me.ExpandedStates.Keys.CopyTo(indexes, 0)

        Dim arr As New ArrayList(indexes)
        'Sort so we can guarantee that a parent item is expanded before any of 
        'its children
        arr.Sort()

        For Each key As String In arr
            Dim value As Boolean = CBool(Me.ExpandedStates(key))
            If value Then
                RadGrid1.Items(key).Expanded = True
            End If
        Next

        'Select all items using our custom storage
        indexes = New String(Me.SelectedStates.Keys.Count - 1) {}
        Me.SelectedStates.Keys.CopyTo(indexes, 0)

        arr = New ArrayList(indexes)
        'Sort to ensure that a parent item is selected before any of its children
        arr.Sort()

        For Each key As String In arr
            Dim value As Boolean = CBool(Me.SelectedStates(key))
            If value Then
                RadGrid1.Items(key).Selected = True
            End If
        Next
    End Sub
End Class

