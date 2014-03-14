Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmGestion
    Inherits System.Web.UI.Page
    Private _ordersExpandedState As Hashtable
    Private _selectedState As Hashtable
    Dim IdProyecto As String
    Dim proyecto As String
    Dim EjecucionBL As New EjecucionBL
    Dim _Ejecucion As New Ejecucion
    Dim Ejecucion As Ejecucion
    Dim _Vehiculo As New Vehiculo
    Dim VehiculoBL As New VehiculoBL
    Dim _DetalleEjecucion As New DetalleEjecucion
    Dim DetalleEjecucionBL As New DetalleEjecucionBL
    Dim ControlBL As New ControlBL
    Dim _integrante As New Integrante
    Dim IntegranteBL As New IntegranteBL
    Dim InteressadosBL As New InteresadosBL
    Dim IdEjecucion As String
    Dim Cubigeo As String
    Dim ClimaBL As New ClimaSocialBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Request.QueryString("IdProyecto")
        If Not IsPostBack Then
            'reset states
            Me._ordersExpandedState = Nothing
            Me.Session("_ordersExpandedState") = Nothing
            Me._selectedState = Nothing
            Me.Session("_selectedState") = Nothing
        End If
    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand

        If e.CommandName = "control" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            Me.HiddenField1.Value = IdProyecto
            Me.RadGrid2.Visible = True
            Me.RadGrid3.Visible = False
            Me.RadGrid4.Visible = False
            Me.RadGrid6.Visible = False
            Me.RadGrid7.Visible = False
            RadGrid2.MasterTableView.FilterExpression = "(Estado LIKE '%EJECUTADO%' and Tipo LIKE '%SALIDA%') "
            Dim column As GridColumn = RadGrid2.MasterTableView.GetColumn("Estado")
            Dim column1 As GridColumn = RadGrid2.MasterTableView.GetColumn("Tipo")

            column.CurrentFilterFunction = GridKnownFunction.Contains
            column.CurrentFilterValue = "EJECUTADO"
            column1.CurrentFilterFunction = GridKnownFunction.Contains
            column1.CurrentFilterValue = "SALIDA A CAMPO"
            RadGrid2.MasterTableView.Rebind()

            Me.Label1.Text = "Control de Actividades"
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = False
        ElseIf e.CommandName = "poa" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            Me.HiddenField1.Value = IdProyecto
            Me.RadGrid2.Visible = False
            Me.RadGrid3.Visible = True
            Me.RadGrid4.Visible = False
            Me.RadGrid6.Visible = False
            Me.RadGrid7.Visible = False
            Me.Label1.Text = "POA"
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False
        ElseIf e.CommandName = "stakeholders" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            Me.HiddenField1.Value = IdProyecto
            Me.RadGrid2.Visible = False
            Me.RadGrid3.Visible = False
            Me.RadGrid4.Visible = True
            Me.RadGrid6.Visible = False
            Me.RadGrid7.Visible = False
            Me.Label1.Text = "StakeHolders"
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = True
        ElseIf e.CommandName = "clima" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            Cubigeo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("Cubigeo")
            Me.HiddenField1.Value = IdProyecto
            Me.RadGrid2.Visible = False
            Me.RadGrid3.Visible = False
            Me.RadGrid4.Visible = False
            Me.RadGrid6.Visible = True
            Me.RadGrid7.Visible = False
            Me.Label1.Text = "Clima Social"
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = True
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False
        ElseIf e.CommandName = "kardex" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            Me.HiddenField1.Value = IdProyecto
            Me.RadGrid2.Visible = False
            Me.RadGrid3.Visible = False
            Me.RadGrid4.Visible = False
            Me.RadGrid6.Visible = False
            Me.RadGrid7.Visible = True
            Me.Label1.Text = "Control de Productos"
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False
        ElseIf e.CommandName = "gastos" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            Dim cadena_java As String = "<script type='text/javascript'> " & _
                                             " window.open('ReporteGastosXCaserio.aspx?IdProyecto=" + IdProyecto.ToString + "','Formulario'); " & _
                                             Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

            'Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            'IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            'proyecto = editedItem.OwnerTableView.Items.Item(editedItem.ItemIndex)("Nombre").Text

            'Me.HiddenField1.Value = IdProyecto
            'Me.RadGrid2.Visible = False
            'Me.RadGrid3.Visible = False
            'Me.RadGrid4.Visible = False
            'Me.RadGrid6.Visible = False
            'Me.Label1.Text = ""
            'Me.Button2.Visible = False
            'Me.Button3.Visible = False
            'Me.Button4.Visible = False
            'Me.Button5.Visible = False


            'Dim cadena_java As String = "<script type='text/javascript'> " & _
            '                                 " window.open('ReporteKardex.aspx?IdProyecto=" + Me.HiddenField1.Value + "&proyecto=" + proyecto.ToString + "','Formulario'); " & _
            '                                 Chr(60) & "/script>"
            'ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

        End If
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        Dim IdDetalleEje As String
        Dim cadena_java As String

        'If "Control".Equals(e.Item.OwnerTableView.Name) Then
        '      If e.CommandName = "Edit" Then
        '        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        '        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        '        IdControl = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdControl")
        '        IdDetalleEje = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdDetalleEje").ToString
        '        e.Canceled = True

        '        cadena_java = "<script type='text/javascript'> " & _
        '                                       " radopen('FrmTarea.aspx?IdControl=" + IdControl.ToString + "&IdDetalleEje=" + IdDetalleEje.ToString + "','Formulario'); " & _
        '                                       Chr(60) & "/script>"
        '        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        '    ElseIf e.CommandName = "InitInsert" Then
        '        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
        '        IdDetalleEje = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdDetalleEje").ToString

        '        e.Canceled = True
        '        cadena_java = "<script type='text/javascript'> " & _
        '                                       " radopen('FrmTarea.aspx?IdControl=0&IdDetalleEje=" + IdDetalleEje.ToString + "','Formulario'); " & _
        '                                      Chr(60) & "/script>"
        '        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        '    End If

        'Else
        If e.CommandName = "Edit" Then
            e.Canceled = True
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdDetalleEje = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalleEje")
            cadena_java = "<script type='text/javascript'> " & _
                                             " radopen('FrmDetalleEje.aspx?IdProyecto=" + Me.HiddenField1.Value + "&IdDetalleEje=" + IdDetalleEje + "','Formulario'); " & _
                                             Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "InitInsert" Then
            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                              " radopen('FrmDetalleEje.aspx?IdProyecto=" + Me.HiddenField1.Value + "&IdDetalleEje=0','Formulario'); " & _
                                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "Delete" Then
            Try
                Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
                IdDetalleEje = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalleEje")
                DetalleEjecucionBL.DeletetDETALLEEJECUCION(IdDetalleEje)

            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try


        End If


        'End If
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
            ' Is the item about to be selected 
        ElseIf e.CommandName = RadGrid.SelectCommandName Then
            'Save its unique index among all the items in the hierarchy
            Me.SelectedStates(e.Item.ItemIndexHierarchical) = True
            'Is the item about to be deselected 
        ElseIf e.CommandName = RadGrid.DeselectCommandName Then
            Me.SelectedStates.Remove(e.Item.ItemIndexHierarchical)
        End If
        If e.CommandName = RadGrid.FilterCommandName Then
            Dim filterPair As Pair = DirectCast(e.CommandArgument, Pair)

            Select Case filterPair.Second.ToString()
                Case "Fecha"
                    Me.fromDate = (TryCast((TryCast(e.Item, GridFilteringItem))(filterPair.Second.ToString()).FindControl("dateFrom"), RadDatePicker)).SelectedDate
                    Me.toDate = (TryCast((TryCast(e.Item, GridFilteringItem))(filterPair.Second.ToString()).FindControl("dateTo"), RadDatePicker)).SelectedDate
                    Exit Select
                Case "Freight"
                    Me.startSlider = (TryCast((TryCast(e.Item, GridFilteringItem))(filterPair.Second.ToString()).FindControl("RadSlider1"), RadSlider)).SelectionStart
                    Me.endSlider = (TryCast((TryCast(e.Item, GridFilteringItem))(filterPair.Second.ToString()).FindControl("RadSlider1"), RadSlider)).SelectionEnd
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End If
    End Sub
    Protected Sub RadGrid2_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid2.DataBound
        If Me.RadGrid2.Visible = True Then
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
                                                 " radopen('FrmClimaSocial.aspx?CUBIGEO=" + CUBIGEO.ToString + "&IdClima=" + IdClima + "&IdProyecto=" + Me.HiddenField1.Value + "','Formulario1'); " & _
                                                 Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            ElseIf e.CommandName = "InitInsert" Then
                Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
                CUBIGEO = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("CUBIGEO").ToString
                e.Canceled = True
                cadena_java = "<script type='text/javascript'> " & _
                                                  " radopen('FrmClimaSocial.aspx?CUBIGEO=" + CUBIGEO.ToString + "&IdClima=0" + "&IdProyecto=" + Me.HiddenField1.Value + " ','Formulario1'); " & _
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
    Protected Function SetShippedDate(ByVal container As GridItem) As System.Nullable(Of DateTime)
        If container.OwnerTableView.GetColumn("ShippedDate").CurrentFilterValue = String.Empty Then
            Return New System.Nullable(Of DateTime)()
        Else
            Return DateTime.Parse(container.OwnerTableView.GetColumn("ShippedDate").CurrentFilterValue)
        End If
    End Function
    Protected Property fromDate() As System.Nullable(Of DateTime)
        Get
            If ViewState("strD") <> Nothing Then
                Return DirectCast(ViewState("strD"), DateTime)
            Else
                Return New DateTime(2012, 1, 1)
            End If
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            ViewState("strD") = value
        End Set
    End Property
    Protected Property toDate() As System.Nullable(Of DateTime)
        Get
            If ViewState("endD") <> Nothing Then
                Return DirectCast(ViewState("endD"), DateTime)
            Else
                Return Date.Now
            End If
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            ViewState("endD") = value
        End Set
    End Property
    Protected Property startSlider() As Decimal
        Get
            If ViewState("strSl") <> Nothing Then
                Return DirectCast(ViewState("strSl"), Decimal)
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Decimal)
            ViewState("strSl") = value
        End Set
    End Property
    Protected Property endSlider() As Decimal
        Get
            If ViewState("endSl") <> Nothing Then
                Return DirectCast(ViewState("endSl"), Decimal)
            Else
                Return 1010
            End If
        End Get
        Set(ByVal value As Decimal)
            ViewState("endSl") = value
        End Set
    End Property


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
    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            Me.RadGrid2.Rebind()
        ElseIf e.Argument = "Validar1" Then
            Me.RadGrid6.Rebind()
        ElseIf e.Argument = "Validar2" Then
            Me.RadGrid4.Rebind()
        ElseIf e.Argument.StartsWith("Generar") Then
            Dim j() As String
            Dim valor As String
            j = Split(e.Argument, "|")

            valor = j(1)
            If valor = "true" Then
                'agregar codigo
                ' TransaccionBl.GenerarAsientoCierre(Session("Fecha"), Session("Anio"), Session("Mes"), Session("IdUser"))
                Dim cadena_java As String = _
                               "<script language='javascript'>function f(){radalert('<b>Se ha generado la Programación Operativa de Actividades</b>', 330, 100,'Mensaje de Información',alertCallBackFn); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)

            End If
        End If
    End Sub
    Protected Sub RadGrid3_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid3.ItemDataBound
        If e.Item.OwnerTableView.Items.Count = 0 Then
            Me.Button1.Visible = True
        Else
            Me.Button1.Visible = False
        End If
        If "Tareas".Equals(e.Item.OwnerTableView.Name) Then
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.White
            Next
        Else
            For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.BurlyWood
            Next
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                                         " radopen('FrmProgramacionPoa.aspx?IdProyecto=" + Me.HiddenField1.Value.ToString + "','Formulario'); " & _
                                         Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If "Transacciones".Equals(e.Item.OwnerTableView.Name) Then

        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                                         " radopen('ReportePoaEjec.aspx?IdProyecto=" + Me.HiddenField1.Value.ToString + "','Formulario'); " & _
                                         Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
    Protected Sub RadGrid4_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.ItemCommand
        Dim IdInteresado As String
        Dim cadena_java As String

        If e.CommandName = "Edit" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdInteresado = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInteresado")
            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                             " radopen('FrmStakeholders.aspx?IdProyecto=" + Me.HiddenField1.Value.ToString + "&IdInteresado=" + IdInteresado + "','Formulario2'); " & _
                                             Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "InitInsert" Then
            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                              " radopen('FrmStakeholders.aspx?IdProyecto=" + Me.HiddenField1.Value.ToString + "&IdInteresado=0','Formulario2'); " & _
                                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "Delete" Then
            Try
                Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
                IdInteresado = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInteresado")
                InteressadosBL.DeleteINTERESADOS(IdInteresado)

            Catch ex As Exception
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
                e.Canceled = True
            End Try
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
    Protected Sub RadGrid4_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        Try
            Dim ID As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdInteresado").ToString
            DetalleEjecucionBL.DeletetDETALLEEJECUCION(ID)

        Catch ex As Exception
            Dim cadena_java As String = _
                                           "<script type='text/javascript'> " & _
                                           " alert('¡No se puede Eliminar el Registro, primero elimine los detalles!'); " & _
                                           Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            e.Canceled = True
        End Try
    End Sub
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Dim cadena_java As String = "<script type='text/javascript'> " & _
                                               " window.open('ReporteClimaSocial.aspx?IdProyecto=" + Me.HiddenField1.Value + "'); " & _
                                               Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Dim cadena_java As String = "<script type='text/javascript'> " & _
                                              " window.open('ReporteCompromisos.aspx?IdProyecto=" + Me.HiddenField1.Value + "'); " & _
                                              Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cadena_java As String = "<script type='text/javascript'> " & _
                                            " window.open('ReporteActividades.aspx?IdProyecto=" + Me.HiddenField1.Value + "'); " & _
                                            Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim cadena_java As String = "<script type='text/javascript'> " & _
                                           " window.open('ReporteStakeholders.aspx?IdProyecto=" + Me.HiddenField1.Value + "'); " & _
                                           Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class