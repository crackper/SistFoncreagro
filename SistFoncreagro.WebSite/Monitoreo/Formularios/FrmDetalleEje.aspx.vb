Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Collections
Imports System.Configuration
Imports System
Public Class FrmDetalleEje
    Inherits System.Web.UI.Page
    Private _ordersExpandedState As Hashtable
    Private _selectedState As Hashtable
    Dim _DetalleEje As New DetalleEjecucion
    Dim DetalleEjeBL As New DetalleEjecucionBL
    Dim DetalleEje As DetalleEjecucion
    Dim IdDetalleEje As String
    Dim _ubigeo As UbigeoDatos
    Dim ubigeoBL As New UbigeoDatosBL
    Dim IdProyecto As String
    Dim _Vehiculo As New Vehiculo
    Dim VehiculoBL As New VehiculoBL
    Dim _Sustento As New Sustento
    Dim SustentoBL As New SustentoBL
    Dim _integrante As New Integrante
    Dim IntegranteBL As New IntegranteBL
    Dim _Insumos As New Insumos
    Dim AsistentesBL As New AsistenteBL
    Dim _Asistente As New Asistente
    Dim ActitudInteresadoBL As New ActitudInteresadoBL
    Dim _ActitudInteresado As New ActitudInteresado
    Dim InsumosBL As New InsumosBL
    Dim Total As Decimal
    Dim ControlBL As New ControlBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdDetalleEje = Request.QueryString("IdDetalleEje")
        IdProyecto = Request.QueryString("IdProyecto")
        Me.RadComboBox1.Filter = 1
        Me.Label1.Text = ""
        'para agregar un evento 
        Me.txtDate1.Attributes.Add("onChange", "ValidarFecha();")
        Me.ImageButton6.Attributes.Add("onClick", "openWin(" + IdDetalleEje.ToString + "); return false;")
        Me.ImageButton5.Attributes.Add("onClick", "openWin1(" + IdDetalleEje.ToString + "); return false;")

        If Page.IsPostBack = False Then
            Me.txtDate1.Text = Date.Now
            Me.txtDate2.Text = Date.Now
            If IdDetalleEje > 0 Then
                'para recuperar datos 
                DetalleEje = DetalleEjeBL.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje)

                _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(DetalleEje.IdUbigeo)
                Me.RadComboBox1.DataSourceID = "OdsUbigeo"
                Me.OdsUbigeo.SelectParameters("texto").DefaultValue = _ubigeo.Nombre
                Me.RadComboBox1.DataBind()
                Me.RadComboBox1.SelectedValue = DetalleEje.IdUbigeo

                If DetalleEje.IdFamilia > 0 Then
                    Me.RadComboBox7.SelectedValue = DetalleEje.IdFamilia
                End If
                If DetalleEje.Fecha.HasValue Then
                    Me.txtDate.Text = DetalleEje.Fecha
                End If
                If DetalleEje.FechaReprogramada.HasValue Then
                    Me.txtDate2.Text = DetalleEje.FechaReprogramada
                End If
                Me.Label1.Text = DetalleEje.Estado
                Me.txtDate1.Text = DetalleEje.FechaProgramada
                Me.TextBox8.Text = DetalleEje.ClimaSocial
                Me.TextBox9.Text = DetalleEje.Quejas
                Me.TextBox10.Text = DetalleEje.AccionesTomadas
                Me.TextBox11.Text = DetalleEje.Observaciones
                Me.RadioButtonList1.SelectedValue = DetalleEje.Tipo
                Me.TextBox12.Text = DetalleEje.Hora

                If DetalleEje.Estado = "REPROGRAMADO" Or DetalleEje.Estado = "CANCELADO" Then
                    Me.ImageButton3.Visible = False
                    Me.ImageButton4.Visible = False
                    Me.ImageButton5.Visible = False
                    Me.ImageButton6.Visible = False
                    Me.RadTabStrip1.Tabs.Item(1).Visible = False
                    Me.RadTabStrip1.Tabs.Item(2).Visible = False
                    Me.RadTabStrip1.Tabs.Item(3).Visible = False
                ElseIf DetalleEje.Estado = "EJECUTADO" Then
                    Me.ImageButton5.Visible = False
                    Me.ImageButton6.Visible = False
                End If
            End If
        End If
        If Not IsPostBack Then
            'reset states
            Me._ordersExpandedState = Nothing
            Me.Session("_ordersExpandedState") = Nothing
            Me._selectedState = Nothing
            Me.Session("_selectedState") = Nothing
        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        _DetalleEje.AccionesTomadas = Me.TextBox10.Text
        _DetalleEje.ClimaSocial = Me.TextBox8.Text
        If Me.txtDate.Text.Length > 0 Then
            _DetalleEje.Fecha = Me.txtDate.Text
        End If

        _DetalleEje.FechaProgramada = Me.txtDate1.Text
        If Me.txtDate2.Text.Length > 0 Then
            _DetalleEje.FechaReprogramada = Me.txtDate2.Text
        End If

        _DetalleEje.IdDetalleEje = IdDetalleEje
        If Me.RadComboBox7.Text.Length > 0 Then
            _DetalleEje.IdFamilia = Me.RadComboBox7.SelectedValue
        Else

            _DetalleEje.IdFamilia.Equals(DBNull.Value)
        End If

        _DetalleEje.IdUbigeo = Me.RadComboBox1.SelectedValue
        _DetalleEje.IdUsuario = Session("IdUser")
        _DetalleEje.Observaciones = Me.TextBox11.Text
        _DetalleEje.Quejas = Me.TextBox9.Text
        _DetalleEje.IdProyecto = IdProyecto
        _DetalleEje.Tipo = Me.RadioButtonList1.SelectedValue
        _DetalleEje.Hora = Me.TextBox12.Text
        If Me.txtDate.Text.Length <> 0 Then
            _DetalleEje.Estado = "EJECUTADO"
        Else
            _DetalleEje.Estado = "PROGRAMADO"
        End If
        If IdDetalleEje > 0 Then
            DetalleEjeBL.SaveDETALLEEJECUCION(_DetalleEje)
        Else
            IdDetalleEje = DetalleEjeBL.SaveDETALLEEJECUCION(_DetalleEje)
        End If
        Response.Redirect("FrmDetalleEje.aspx?IdDetalleEje=" + IdDetalleEje.ToString + "&IdProyecto=" + IdProyecto.ToString)
    End Sub
    Protected Sub RadGrid4_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Vehiculo.IdVehiculo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdVehiculo")

        _Vehiculo.IdDetalleEje = IdDetalleEje
        _Vehiculo.Marca = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Vehiculo.Modelo = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Vehiculo.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Vehiculo.Placa = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Vehiculo.Tipo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Vehiculo.Implementacion = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Mantenimiento = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Incidente = CType(userControl.FindControl("TextBox5"), TextBox).Text
        VehiculoBL.SaveVEHICULO(_Vehiculo)
    End Sub

    Protected Sub RadGrid4_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
       

        Try
           id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdVehiculo")
            VehiculoBL.DeleteVEHICULO(id)
        Catch ex As Exception
            Dim cadena_java As String = _
                                           "<script type='text/javascript'> " & _
                                           " alert('¡No se puede Eliminar porque está siendo utilizado en Equipo!'); " & _
                                           Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            e.Canceled = True
        End Try

    End Sub

    Protected Sub RadGrid4_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Vehiculo.IdDetalleEje = IdDetalleEje
        _Vehiculo.Marca = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Vehiculo.Modelo = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _Vehiculo.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Vehiculo.Placa = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Vehiculo.Tipo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _Vehiculo.Implementacion = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Mantenimiento = CType(userControl.FindControl("RadioButtonList1"), RadioButtonList).SelectedValue
        _Vehiculo.Incidente = CType(userControl.FindControl("TextBox5"), TextBox).Text
        VehiculoBL.SaveVEHICULO(_Vehiculo)
    End Sub
    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Sustento.IdControl.Equals(DBNull.Value)
        _Sustento.IdDetalleEje = IdDetalleEje
        _Sustento.Archivo = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Sustento.Descripcion = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Sustento.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Sustento.Nombre = CType(userControl.FindControl("TextBox1"), TextBox).Text


        SustentoBL.SaveSUSTENTO(_Sustento)
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdSustento")
        SustentoBL.DeleteSUSTENTO(id)
    End Sub

    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Sustento.IdSustento = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdSustento")

        _Sustento.IdControl.Equals(DBNull.Value)
        _Sustento.IdDetalleEje = IdDetalleEje
        _Sustento.Archivo = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Sustento.Descripcion = CType(userControl.FindControl("TextBox4"), TextBox).Text
        _Sustento.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _Sustento.Nombre = CType(userControl.FindControl("TextBox1"), TextBox).Text

        SustentoBL.SaveSUSTENTO(_Sustento)
    End Sub
    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        'Dim Departamento As String
        Dim Provincia As String
        Dim Distrito As String
        Dim CPoblado As String
        Dim Caserio As String
        Dim Nivel As String

        'Departamento = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Departamento.ToString()
        Provincia = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Provincia.ToString()
        Distrito = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Distrito.ToString()
        CPoblado = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CentroPoblado.ToString()
        Caserio = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Caserio.ToString()
        Nivel = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Nivel.ToString()

        e.Item.Text = Provincia + "-" + Distrito + "-" + CPoblado + "-" + Caserio + " (" + Nivel + ")"
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CUBIGEO.ToString()
    End Sub

    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox1.DataSourceID = "OdsUbigeo"
            Me.OdsUbigeo.SelectParameters("texto").DefaultValue = e.Text.ToString
            Me.RadComboBox1.DataBind()
        End If
    End Sub
    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _integrante.IdDetalleEje = IdDetalleEje
        If CType(userControl.FindControl("CheckBox2"), CheckBox).Checked Then
            _integrante.Conduce = "S"
        Else
            _integrante.Conduce = "N"
        End If
        _integrante.Documento = ""
        _integrante.IdPersonal = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue.Length > 0 Then
            _integrante.IdVehiculo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        End If

        _integrante.Observacion = CType(userControl.FindControl("TextBox5"), TextBox).Text

        IntegranteBL.SaveINTEGRANTE(_integrante)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _integrante.IdIntegrante = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdIntegrante")

        _integrante.IdDetalleEje = IdDetalleEje
        If CType(userControl.FindControl("CheckBox2"), CheckBox).Checked Then
            _integrante.Conduce = "S"
        Else
            _integrante.Conduce = "N"
        End If
        _integrante.Documento = ""
       
        _integrante.IdPersonal = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue.Length > 0 Then
            _integrante.IdVehiculo = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        End If
        _integrante.Observacion = CType(userControl.FindControl("TextBox5"), TextBox).Text

        IntegranteBL.SaveINTEGRANTE(_integrante)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdIntegrante")
        IntegranteBL.DeleteINTEGRANTE(id)
    End Sub

    'Protected Sub RadGrid3_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid3.ItemCommand
    '    Dim cadena_java As String
    '    Dim IdControl As String

    '    If e.CommandName = "Edit" Then
    '        e.Canceled = True
    '        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
    '        IdControl = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdControl")
    '        cadena_java = "<script type='text/javascript'> " & _
    '                                         " radopen('FrmTarea.aspx?IdControl=" + IdControl.ToString + "&IdDetalleEje=" + IdDetalleEje.ToString + "','Formulario1'); " & _
    '                                         Chr(60) & "/script>"
    '        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    '    ElseIf e.CommandName = "InitInsert" Then
    '        e.Canceled = True
    '        cadena_java = "<script type='text/javascript'> " & _
    '                                           " radopen('FrmTarea.aspx?IdControl=0&IdDetalleEje=" + IdDetalleEje.ToString + "','Formulario1'); " & _
    '                                          Chr(60) & "/script>"
    '        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    '    End If

    '    'save the expanded/selected state in the session
    '    If e.CommandName = RadGrid.ExpandCollapseCommandName Then
    '        'Is the item about to be expanded or collapsed
    '        If Not e.Item.Expanded Then
    '            'Save its unique index among all the items in the hierarchy
    '            Me.ExpandedStates(e.Item.ItemIndexHierarchical) = True
    '        Else
    '            'collapsed
    '            Me.ExpandedStates.Remove(e.Item.ItemIndexHierarchical)
    '            Me.ClearSelectedChildren(e.Item.ItemIndexHierarchical)
    '            Me.ClearExpandedChildren(e.Item.ItemIndexHierarchical)
    '        End If
    '        'Is the item about to be selected 
    '    ElseIf e.CommandName = RadGrid.SelectCommandName Then
    '        'Save its unique index among all the items in the hierarchy
    '        Me.SelectedStates(e.Item.ItemIndexHierarchical) = True
    '        'Is the item about to be deselected 
    '    ElseIf e.CommandName = RadGrid.DeselectCommandName Then
    '        Me.SelectedStates.Remove(e.Item.ItemIndexHierarchical)
    '    End If
    'End Sub
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
            Me.RadGrid5.Rebind()
        ElseIf e.Argument = "ValidarFecha" Then
            If Me.txtDate1.Text.Length > 0 Then
                If (CDate(Me.txtDate1.Text) < CDate(Me.txtDate2.Text)) Then
                    Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡La Fecha Programada debe ser mayor o igual que la fecha de Registro!'); Foco(); " & _
                                       Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                End If
            End If
        ElseIf e.Argument.StartsWith("Reprogramar") Then
            Dim j() As String
            Dim fecha As Date
            Dim IdDetalleEje As String
            Dim observacion As String

            j = Split(e.Argument, "|")
            fecha = Date.Parse(j(1))
            IdDetalleEje = j(2)
            observacion = j(3)

            ControlBL.ReprogramarActividadGeneral(IdDetalleEje, fecha, Session("IdUser"), observacion)

            Response.Redirect("FrmDetalleEje.aspx?IdDetalleEje=" + IdDetalleEje.ToString + "&IdProyecto=" + IdProyecto.ToString)
        ElseIf e.Argument.StartsWith("Cancelar") Then
            Dim j() As String

            Dim IdDetalleEje As String
            Dim observacion As String

            j = Split(e.Argument, "|")
            IdDetalleEje = j(1)
            observacion = j(2)

            ControlBL.CancelarActividadGeneral(IdDetalleEje, Session("IdUser"), observacion)

            Response.Redirect("FrmDetalleEje.aspx?IdDetalleEje=" + IdDetalleEje.ToString + "&IdProyecto=" + IdProyecto.ToString)
           
        End If
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmDetalleEje.aspx?IdDetalleEje=0&IdProyecto=" + IdProyecto.ToString)
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        Dim cadena_java As String
        If e.CommandName = "Descargar" Then
            Dim archivo As String = e.Item.OwnerTableView.Items.Item(e.Item.ItemIndex)("Archivo").Text
            cadena_java = "<script type='text/javascript'> " & _
                             " window.open('/SistIntegral/Monitoreo/Adjuntos/" + archivo.ToString + "');" & _
                             Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub RadGrid5_ItemCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid5.ItemCommand
        Dim cadena_java As String
        Dim IdControl As Int32
        If e.CommandName = "Edit" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdControl = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdControl")

            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                             " radopen('FrmTarea.aspx?IdControl=" + IdControl.ToString + "&IdDetalleEje=" + IdDetalleEje.ToString + "','Formulario1'); " & _
                                             Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "InitInsert" Then
            Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
            e.Canceled = True
            cadena_java = "<script type='text/javascript'> " & _
                                               " radopen('FrmTarea.aspx?IdControl=0&IdDetalleEje=" + IdDetalleEje.ToString + "','Formulario1'); " & _
                                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        ElseIf e.CommandName = "Delete" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            IdControl = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdControl")
            ControlBL.DeleteCONTROL(IdControl)
        End If
    End Sub
End Class