Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmListaTareas
    Inherits System.Web.UI.Page
    Dim _DetalleEjecucion As New DetalleEjecucion
    Dim DetalleEjecucionBL As New DetalleEjecucionBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
                                             " radopen('FrmDetalleEje.aspx?IdProyecto=" + Session("IdProyecto").ToString + "&IdDetalleEje=" + IdDetalleEje + "','Formulario'); " & _
                                             Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "InitInsert" Then
            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                              " radopen('FrmDetalleEje.aspx?IdProyecto=" + Session("IdProyecto").ToString + "&IdDetalleEje=0','Formulario'); " & _
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
    Protected Sub RadAjaxManager1_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Validar" Then
            Me.RadGrid2.Rebind()
        End If
    End Sub
End Class