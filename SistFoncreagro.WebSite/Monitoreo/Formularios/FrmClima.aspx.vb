Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmClima
    Inherits System.Web.UI.Page
    Dim ClimaBL As New ClimaSocialBL
    Private _ordersExpandedState As Hashtable
    Private _selectedState As Hashtable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'reset states
            Me._ordersExpandedState = Nothing
            Me.Session("_ordersExpandedState") = Nothing
            Me._selectedState = Nothing
            Me.Session("_selectedState") = Nothing
        End If
    End Sub
    Protected Sub RadGrid6_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid6.ItemCommand, RadGrid6.ItemCommand
        Dim IdClima As String
        Dim cadena_java As String
        Dim CUBIGEO As String

        If "Clima".Equals(e.Item.OwnerTableView.Name) Then
            If e.CommandName = "Edit" Then
                Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
                Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
                IdClima = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdClima")
                CUBIGEO = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("CUBIGEO").ToString
                e.Canceled = True
                cadena_java = "<script type='text/javascript'> " & _
                                                 " radopen('FrmClimaSocial.aspx?CUBIGEO=" + CUBIGEO.ToString + "&IdClima=" + IdClima + "&IdProyecto=" + Session("IdProyecto").ToString + "','Formulario1'); " & _
                                                 Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            ElseIf e.CommandName = "InitInsert" Then
                Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
                CUBIGEO = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("CUBIGEO").ToString
                e.Canceled = True
                cadena_java = "<script type='text/javascript'> " & _
                                                  " radopen('FrmClimaSocial.aspx?CUBIGEO=" + CUBIGEO.ToString + "&IdClima=0" + "&IdProyecto=" + Session("IdProyecto").ToString + " ','Formulario1'); " & _
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

    Protected Sub RadGrid6_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid6.DataBound
        If Me.RadGrid6.Visible = True Then
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
                    RadGrid6.Items(key).Expanded = True
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
                    RadGrid6.Items(key).Selected = True
                End If
            Next
        End If

    End Sub

    Protected Sub RadGrid6_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid6.DeleteCommand
        If "Clima".Equals(e.Item.OwnerTableView.Name) Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Try
                Dim ID As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdClima").ToString
                ClimaBL.DeleteCLIMASOCIAL(ID)
                ' Me.RadGrid1.Rebind()
            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try
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
    Protected Sub RadAjaxManager1_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            Me.RadGrid6.Rebind()
        End If
    End Sub
End Class