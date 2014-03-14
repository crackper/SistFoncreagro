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
Public Class ListaConciliacion
    Inherits System.Web.UI.Page
    Private _ordersExpandedState As Hashtable
    Private _selectedState As Hashtable
    Dim TransaccionBL As New TransaccionBL
    Dim Flag As String
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Dim ProyectoBL As New ProyectoBL
    Dim ConciliacionBL As New ConciliacionBnacariaBL
    Dim Conciliacion As ConciliacionBancaria
    Dim _Conciliacion As New ConciliacionBancaria
    Dim CuentaBancariaBL As New CuentaBancariaBL
    Dim PlancontableBL As New PlanContableBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.RadGrid2.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If

        If Not IsPostBack Then
            'reset states
            Me._ordersExpandedState = Nothing
            Me.Session("_ordersExpandedState") = Nothing
            Me._selectedState = Nothing
            Me.Session("_selectedState") = Nothing
        End If
    End Sub
    Protected Sub RadGrid2_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid2.ItemDataBound
        Dim estadoMes As String = ""

        If "Conciliaciones".Equals(e.Item.OwnerTableView.Name) Then
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                If (e.Item.OwnerTableView.Items(i).Item("Estado").Text = "A") Then
                    e.Item.OwnerTableView.Items.Item(i)("editar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("eliminar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
                End If

                'si el mes esta cerrado no permite editar ni anular ni eliminar
                estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Integer.Parse(e.Item.OwnerTableView.Items.Item(i)("Mes1").Text))
                If estadoMes = "C" Then
                    e.Item.OwnerTableView.Items.Item(i)("editar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("eliminar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("editar").BackColor = Drawing.Color.Gray
                    e.Item.OwnerTableView.Items.Item(i)("eliminar").BackColor = Drawing.Color.Gray
                    e.Item.OwnerTableView.Items.Item(i)("anular").BackColor = Drawing.Color.Gray
                End If
            Next

        End If

    End Sub
    Public Function NomMes(ByVal id As Int32) As String
        Dim Nombre As String = ""
        Select Case id
            Case 1
                Nombre = "Enero"
            Case 2
                Nombre = "Febrero"
            Case 3
                Nombre = "Marzo"
            Case 4
                Nombre = "Abril"
            Case 5
                Nombre = "Mayo"
            Case 6
                Nombre = "Junio"
            Case 7
                Nombre = "Julio"
            Case 8
                Nombre = "Agosto"
            Case 9
                Nombre = "Setiembre"
            Case 10
                Nombre = "Octubre"
            Case 11
                Nombre = "Noviembre"
            Case 12
                Nombre = "Diciembre"
        End Select
        Return Nombre
    End Function

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        Dim cadena_java As String
        If e.CommandName = "InitInsert" Then
            e.Canceled = True
            Session("IdConciliacion") = 0

            cadena_java = "<script type='text/javascript'> " & _
                                    " radopen('FrmConciliacion.aspx','Formulario'); " & _
                                    Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

        End If

        If "Conciliaciones".Equals(e.Item.OwnerTableView.Name) Then
            If e.CommandName = "Anular" Then
                Dim IdCon As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdConciliacion").ToString
                ConciliacionBL.UpdateEstadoCONCILIACIONBANCARIA(IdCon)
                Me.RadGrid2.DataBind()
            ElseIf e.CommandName = "Ver" Then
                Dim IdCon As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdConciliacion").ToString
                Dim idPlan As Int32
                Dim Fecha As Date
                Dim Cuenta As String
                Dim archivo As String

                Session("IdConciliacion") = IdCon
                idPlan = CuentaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(ConciliacionBL.GetCONCILIACIONBANCARIAByIdConciliacion(Session("IdConciliacion")).IdCtaBancaria).IdPlan
                Cuenta = PlancontableBL.GetPLANCONTABLEByIdPlan(CuentaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(ConciliacionBL.GetCONCILIACIONBANCARIAByIdConciliacion(Session("IdConciliacion")).IdCtaBancaria).IdPlan).Codigo
                Fecha = ConciliacionBL.GetCONCILIACIONBANCARIAByIdConciliacion(Session("IdConciliacion")).Fecha
                archivo = ConciliacionBL.GetCONCILIACIONBANCARIAByIdConciliacion(Session("IdConciliacion")).Adjunto

                'abrimos el formato de conciliacion bancaria, el reporte de saldos de la cuenta segun la conciliacion y el reporte de caja y bancos para conciliacion
                cadena_java = "<script type='text/javascript'> " & _
                                 "window.open('ReporteConciliacionBancaria.aspx?'); " & _
                                 " window.open('ReporteSaldosCuentaBancaria.aspx?idPlan=" + idPlan.ToString + "&Fecha=" + Fecha.ToString + "' ); " & _
                                 " window.open('ReporteCajaBancosConciliacion.aspx?Fecha=" + Fecha.ToString + "&idProyecto=0" + "&CuentaInicio=" + Cuenta.ToString + "&CuentaFin=" + Cuenta.ToString + "' ); " & _
                                 " window.open('/SistIntegral/Contabilidad/Adjuntos/" + archivo.ToString + "');" & _
                                 Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

            ElseIf e.CommandName = "Editar" Then
                Dim IdCon As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdConciliacion").ToString
                Session("IdConciliacion") = IdCon

              cadena_java = "<script type='text/javascript'> " & _
                                      " radopen('FrmConciliacion.aspx','Formulario'); " & _
                                      Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
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

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            Me.RadGrid2.Rebind()
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

    Protected Sub RadGrid2_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid2.DataBound
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
                RadGrid2.Items(key).Expanded = True
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
                RadGrid2.Items(key).Selected = True
            End If
        Next
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        If "Conciliaciones".Equals(e.Item.OwnerTableView.Name) Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Try
                Dim IdCon As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdConciliacion").ToString
                ConciliacionBL.DeleteCONCILIACIONBANCARIA(IdCon)
                'Me.RadGrid1.Rebind()
            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try
        End If
    End Sub
End Class