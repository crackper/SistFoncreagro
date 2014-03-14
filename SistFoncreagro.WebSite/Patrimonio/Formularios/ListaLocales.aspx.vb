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
Public Class ListaLocales
    Inherits System.Web.UI.Page
    Private _ordersExpandedState As Hashtable
    Private _selectedState As Hashtable
    Dim _Local As New Local
    Dim LocalBL As New LocalBL
    Dim _oficina As New Oficina
    Dim OficinaBL As New OficinaBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'reset states
            Me._ordersExpandedState = Nothing
            Me.Session("_ordersExpandedState") = Nothing
            Me._selectedState = Nothing
            Me.Session("_selectedState") = Nothing
        End If
    End Sub
    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If "Oficinas".Equals(e.Item.OwnerTableView.Name) Then
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                If e.Item.OwnerTableView.Items.Item(i)("Estado").Text = "I" Then
                    e.Item.OwnerTableView.Items.Item(i)("Editar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("Anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("Eliminar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
                End If
            Next
        Else
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                If e.Item.OwnerTableView.Items.Item(i)("Estado").Text = "I" Then
                    e.Item.OwnerTableView.Items.Item(i)("Editar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("Anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i)("Eliminar").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
                End If
            Next
        End If

    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "Oficinas".Equals(e.Item.OwnerTableView.Name) Then
            _oficina.Descripcion = CType(e.Item.FindControl("TextBox9"), TextBox).Text
            _oficina.IdLocal = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdLocal").ToString
            _oficina.Nombre = CType(e.Item.FindControl("TextBox8"), TextBox).Text
            OficinaBL.SaveOFICINA(_oficina)
        Else
            _Local.Descripcion = CType(e.Item.FindControl("TextBox4"), TextBox).Text
            _Local.Direccion = CType(e.Item.FindControl("TextBox6"), TextBox).Text
            _Local.Nombre = CType(e.Item.FindControl("TextBox2"), TextBox).Text
           LocalBL.SaveLOCAL(_Local)
        End If
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "Oficinas".Equals(e.Item.OwnerTableView.Name) Then
            _oficina.Descripcion = CType(e.Item.FindControl("TextBox9"), TextBox).Text
            _oficina.IdOficina = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdOficina")
            _oficina.Nombre = CType(e.Item.FindControl("TextBox7"), TextBox).Text
            OficinaBL.SaveOFICINA(_oficina)
        Else
            _Local.Descripcion = CType(e.Item.FindControl("TextBox3"), TextBox).Text
            _Local.Direccion = CType(e.Item.FindControl("TextBox5"), TextBox).Text
            _Local.Nombre = CType(e.Item.FindControl("TextBox1"), TextBox).Text
            _Local.IdLocal = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdLocal")
            LocalBL.SaveLOCAL(_Local)
        End If
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        If "Oficinas".Equals(e.Item.OwnerTableView.Name) Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdOficina As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdOficina").ToString
            OficinaBL.DeleteOFICINA(IdOficina)
        Else
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdLocal As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdLocal").ToString
            LocalBL.DeleteLOCAL(IdLocal)
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
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            If "Oficinas".Equals(e.Item.OwnerTableView.Name) Then
                Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
                Dim IdOficina As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdOficina").ToString
                OficinaBL.UpdateEstadoOFICINA(IdOficina)
                Me.RadGrid1.Rebind()
            Else
                Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
                Dim IdLocal As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdLocal").ToString
                LocalBL.UpdateEstadoLOCAL(IdLocal)
                Me.RadGrid1.Rebind()
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

    Protected Sub RadGrid1_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.DataBound
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