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
Public Class FrmTarea
    Inherits System.Web.UI.Page
    Dim IdDetalleEje As String
    Dim IdProyecto As String
    Dim IdControl As String
    Dim _Control As New Control
    Dim ControlBL As New ControlBL
    Dim Control As Control
    Dim AsistentesBL As New AsistenteBL
    Dim _Asistente As New Asistente
    Dim ActitudInteresadoBL As New ActitudInteresadoBL
    Dim _ActitudInteresado As New ActitudInteresado
    Dim ActitudInteresado As ActitudInteresado
    Dim ResponsableBL As New ResponsableBL
    Dim _Responsable As New Responsable
    Dim DetalleejeBL As New DetalleEjecucionBL
    Dim DetalleEje As DetalleEjecucion
    Dim _Sustento As New Sustento
    Dim SustentoBL As New SustentoBL
    Dim _Insumo As New Insumos
    Dim InsumoBL As New InsumosBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdControl = Request.QueryString("IdControl")
        IdDetalleEje = Request.QueryString("IdDetalleEje")
        Me.Label1.Text = ""

        Me.ImageButton6.Attributes.Add("onClick", "openWin(" + IdControl.ToString + "); return false;")
        Me.ImageButton5.Attributes.Add("onClick", "openWin1(" + IdControl.ToString + "); return false;")

        If Page.IsPostBack = False Then
            If IdControl > 0 Then
                'para recuperar datos 
                Control = ControlBL.GetCONTROLByIdControl(IdControl)

                Dim valor As String

                If Control.IdTarea > 0 Then
                    valor = "T" + Control.IdTarea.ToString + "-" + Control.IdSubActividad.ToString
                    Me.RadComboBox6.SelectedValue = valor
                ElseIf Control.IdSubActividad > 0 Then
                    valor = "S" + Control.IdSubActividad.ToString
                    Me.RadComboBox6.SelectedValue = valor
                End If

                If Control.IdTaller > 0 Then
                    Me.DropDownList1.SelectedValue = Control.IdTaller
                End If
                Me.TextBox11.Text = Control.Descripcion
                Me.RadNumericTextBox2.Text = Control.Cantidad
                Me.TextBox12.Text = Control.Documento
                Me.Label1.Text = Control.Estado
                ''para visualizar los botones de reprogramar y cancelar
                If Control.Estado = "REPROGRAMADO" Or Control.Estado = "CANCELADO" Then
                    Me.ImageButton3.Visible = False
                    Me.ImageButton4.Visible = False
                    Me.ImageButton5.Visible = False
                    Me.ImageButton6.Visible = False
                    Me.RadTabStrip1.Tabs.Item(1).Visible = False
                    Me.RadTabStrip1.Tabs.Item(2).Visible = False
                    Me.RadTabStrip1.Tabs.Item(3).Visible = False
                ElseIf Control.Estado = "EJECUTADO" Then
                    Me.ImageButton5.Visible = False
                    Me.ImageButton6.Visible = False
                End If
               
            End If
        End If
    End Sub
    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim Tipo As String
        Dim tamanio As Int32
        Dim subactividad As Int32
        Dim tarea As String

        _Control.Cantidad = Me.RadNumericTextBox2.Text
        _Control.Descripcion = Me.TextBox11.Text
        _Control.IdControl = IdControl
        _Control.Documento = Me.TextBox12.Text
        If Me.DropDownList1.SelectedValue > 0 Then
            _Control.IdTaller = Me.DropDownList1.SelectedValue
        Else
            _Control.IdTaller.Equals(DBNull.Value)
        End If

        Tipo = Me.RadComboBox6.SelectedValue.Substring(0, 1)
        If Tipo = "T" Then
            Dim j() As String
            j = Split(Me.RadComboBox6.SelectedValue, "-")

            subactividad = j(1)
            tarea = j(0)
            tamanio = Len(tarea)
            tarea = tarea.ToString.Substring(1, tamanio - 1)
            _Control.IdTarea = tarea
            _Control.IdSubActividad = subactividad
        ElseIf Tipo = "N" Then
            _Control.IdTarea.Equals(DBNull.Value)
            _Control.IdSubActividad.Equals(DBNull.Value)
        Else
            tamanio = Len(Me.RadComboBox6.SelectedValue)
            subactividad = Me.RadComboBox6.SelectedValue.Substring(1, tamanio - 1)
            _Control.IdTarea.Equals(DBNull.Value)
            _Control.IdSubActividad = subactividad
        End If

        _Control.IdUser = Session("IdUser")
        _Control.IdDetalleEje = IdDetalleEje

        If IdControl > 0 Then
            ControlBL.SaveCONTROL(_Control)
        Else
            IdControl = ControlBL.SaveCONTROL(_Control)
        End If
        Response.Redirect("FrmTarea.aspx?IdControl=" + IdControl.ToString + "&IdDetalleEje=" + IdDetalleEje.ToString)
    End Sub
    Protected Sub RadGrid5_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid5.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim fecha As String

        _Asistente.IdControl = IdControl
        _Asistente.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _Asistente.Observaciones = ""
        AsistentesBL.SaveASISTENTE(_Asistente)

        'para grabar la actitud
        'para sacar la fecha
        DetalleEje = DetalleejeBL.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje)
        fecha = DetalleEje.Fecha

        ActitudInteresado = ActitudInteresadoBL.GetACTITUDINTERESADOByFecha(CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue, fecha)
        If ActitudInteresado Is Nothing Then
            _ActitudInteresado.Actitud = CType(userControl.FindControl("DropDownList4"), DropDownList).SelectedValue
            _ActitudInteresado.Comentario = CType(userControl.FindControl("TextBox2"), TextBox).Text
            _ActitudInteresado.Dialogo = CType(userControl.FindControl("DropDownList6"), DropDownList).SelectedValue
            _ActitudInteresado.FechaInicio = DetalleEje.Fecha
            _ActitudInteresado.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
            _ActitudInteresado.IdUsuario = Session("IdUser")
            _ActitudInteresado.PlanAccion = CType(userControl.FindControl("TextBox3"), TextBox).Text
            _ActitudInteresado.Poder = CType(userControl.FindControl("DropDownList5"), DropDownList).SelectedValue
            ActitudInteresadoBL.SaveACTITUDINTERESADO(_ActitudInteresado)
        End If
    End Sub

    Protected Sub RadGrid5_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid5.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
       
        _Asistente.IdAsistente = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAsistente")
        _Asistente.IdControl = IdControl
        _Asistente.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _Asistente.Observaciones = ""
        AsistentesBL.SaveASISTENTE(_Asistente)

        DetalleEje = DetalleejeBL.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje)
        _ActitudInteresado.IdActitud = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdActitud")
        _ActitudInteresado.Actitud = CType(userControl.FindControl("DropDownList4"), DropDownList).SelectedValue
        _ActitudInteresado.Comentario = CType(userControl.FindControl("TextBox2"), TextBox).Text
        _ActitudInteresado.Dialogo = CType(userControl.FindControl("DropDownList6"), DropDownList).SelectedValue
        _ActitudInteresado.FechaInicio = DetalleEje.Fecha
        _ActitudInteresado.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _ActitudInteresado.IdUsuario = Session("IdUser")
        _ActitudInteresado.PlanAccion = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _ActitudInteresado.Poder = CType(userControl.FindControl("DropDownList5"), DropDownList).SelectedValue
        ActitudInteresadoBL.SaveACTITUDINTERESADO(_ActitudInteresado)
        

    End Sub
    Protected Sub RadGrid5_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid5.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id1 As Int32
        Dim id2 As Int32

        id1 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAsistente")
        id2 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdActitud")

        ActitudInteresadoBL.DeleteACTITUDINTERESADO(id2)
        AsistentesBL.DeleteASISTENTE(id1)
    End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Insumo.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Insumo.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Insumo.TipoAdquisicion = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Insumo.Tipo = CType(userControl.FindControl("RadComboBox5"), RadComboBox).SelectedValue

        If _Insumo.Tipo = "D" Then
            _Insumo.IdCatalogo.Equals(DBNull.Value)
            _Insumo.IdCCosto = CType(userControl.FindControl("RadComboBox4"), RadComboBox).SelectedValue
            _Insumo.IdOcxFactura.Equals(DBNull.Value)
            _Insumo.Descripcion = CType(userControl.FindControl("RadComboBox6"), RadComboBox).Text
            _Insumo.IdDetalleOrdenCompra.Equals(DBNull.Value)
            _Insumo.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Else
            If _Insumo.TipoAdquisicion = "C" Then
                Dim j() As String
                Dim k() As String
                Dim Idunidad As Int32
                Dim IdProducto As Int32
                Dim IdCCosto As Int32
                'Dim IdOCxFactura As Int32
                Dim Precio As Decimal
                Dim IdDetalleOrden As Int32
                Dim Descripcion As String

                j = Split(CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue, "-")
                k = Split(CType(userControl.FindControl("RadComboBox2"), RadComboBox).Text, "--")
                IdCCosto = j(0)
                IdProducto = j(1)
                'IdOCxFactura = j(2)
                Idunidad = j(2)
                Precio = j(3)
                IdDetalleOrden = j(4)

                If k.Length > 1 Then
                    Descripcion = k(1)
                Else
                    Descripcion = ""
                End If


                _Insumo.IdCatalogo = IdProducto
                _Insumo.IdCCosto = IdCCosto
                _Insumo.IdOcxFactura.Equals(DBNull.Value)
                _Insumo.Descripcion = Descripcion
                _Insumo.IdDetalleOrdenCompra = IdDetalleOrden
                _Insumo.IdInteresado.Equals(DBNull.Value)
            Else
                _Insumo.IdCatalogo.Equals(DBNull.Value)
                _Insumo.IdCCosto = CType(userControl.FindControl("RadComboBox4"), RadComboBox).SelectedValue
                _Insumo.IdOcxFactura.Equals(DBNull.Value)
                _Insumo.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
                _Insumo.IdDetalleOrdenCompra.Equals(DBNull.Value)
                _Insumo.IdInteresado.Equals(DBNull.Value)
            End If
        End If
        _Insumo.IdControl = IdControl
        _Insumo.IdUnidad = CType(userControl.FindControl("RadComboBox3"), RadComboBox).SelectedValue
        _Insumo.PrecioUnitario = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text

        InsumoBL.SaveINSUMOS(_Insumo)
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInsumo")
        InsumoBL.DeleteINSUMOS(id)
    End Sub
    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Insumo.IdInsumo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdInsumo")
        _Insumo.Cantidad = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _Insumo.Observaciones = CType(userControl.FindControl("TextBox3"), TextBox).Text
        _Insumo.TipoAdquisicion = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Insumo.Tipo = CType(userControl.FindControl("RadComboBox5"), RadComboBox).SelectedValue

        If _Insumo.Tipo = "D" Then
            _Insumo.IdCatalogo.Equals(DBNull.Value)
            _Insumo.IdCCosto = CType(userControl.FindControl("RadComboBox4"), RadComboBox).SelectedValue
            _Insumo.IdOcxFactura.Equals(DBNull.Value)
            _Insumo.Descripcion = CType(userControl.FindControl("RadComboBox6"), RadComboBox).Text
            _Insumo.IdDetalleOrdenCompra.Equals(DBNull.Value)
            _Insumo.IdInteresado = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Else
            If _Insumo.TipoAdquisicion = "C" Then
                Dim j() As String
                Dim k() As String
                Dim Idunidad As Int32
                Dim IdProducto As Int32
                Dim IdCCosto As Int32
                'Dim IdOCxFactura As Int32
                Dim Precio As Decimal
                Dim IdDetalleOrden As Int32
                Dim Descripcion As String

                j = Split(CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue, "-")
                k = Split(CType(userControl.FindControl("RadComboBox2"), RadComboBox).Text, "--")
                IdCCosto = j(0)
                IdProducto = j(1)
                'IdOCxFactura = j(2)
                Idunidad = j(2)
                Precio = j(3)
                IdDetalleOrden = j(4)

                If k.Length > 1 Then
                    Descripcion = k(1)
                Else
                    Descripcion = ""
                End If


                _Insumo.IdCatalogo = IdProducto
                _Insumo.IdCCosto = IdCCosto
                _Insumo.IdOcxFactura.Equals(DBNull.Value)
                _Insumo.Descripcion = Descripcion
                _Insumo.IdDetalleOrdenCompra = IdDetalleOrden
                _Insumo.IdInteresado.Equals(DBNull.Value)
            Else
                _Insumo.IdCatalogo.Equals(DBNull.Value)
                _Insumo.IdCCosto = CType(userControl.FindControl("RadComboBox4"), RadComboBox).SelectedValue
                _Insumo.IdOcxFactura.Equals(DBNull.Value)
                _Insumo.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
                _Insumo.IdDetalleOrdenCompra.Equals(DBNull.Value)
                _Insumo.IdInteresado.Equals(DBNull.Value)
            End If
        End If
        _Insumo.IdControl = IdControl
        _Insumo.IdUnidad = CType(userControl.FindControl("RadComboBox3"), RadComboBox).SelectedValue
        _Insumo.PrecioUnitario = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text

        InsumoBL.SaveINSUMOS(_Insumo)
    End Sub
    Protected Sub RadGrid4_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _Responsable.IdControl = IdControl
        _Responsable.IdPersonal = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Responsable.Observaciones = CType(userControl.FindControl("TextBox5"), TextBox).Text

        ResponsableBL.SaveRESPONSABLE(_Responsable)
    End Sub
    Protected Sub RadGrid4_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdResponsable")
        ResponsableBL.DeleteRESPONSABLE(id)
    End Sub
    Protected Sub RadGrid4_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid4.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Responsable.IdResponsable = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdResponsable")
        _Responsable.IdControl = IdControl
        _Responsable.IdPersonal = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        _Responsable.Observaciones = CType(userControl.FindControl("TextBox5"), TextBox).Text

        ResponsableBL.SaveRESPONSABLE(_Responsable)
    End Sub
    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmTarea.aspx?IdControl=0&IdDetalleEje=" + IdDetalleEje.ToString)
    End Sub
    Protected Sub RadAjaxManager1_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument.StartsWith("Reprogramar") Then
            Dim j() As String
            Dim fecha As Date
            Dim idControl As String
            Dim observacion As String

            j = Split(e.Argument, "|")
            fecha = Date.Parse(j(1))
            idControl = j(2)
            observacion = j(3)

            ControlBL.ReprogramarActividad(idControl, fecha, Session("IdUser"), observacion)
            Response.Redirect("FrmTarea.aspx?IdControl=" + idControl.ToString + "&IdDetalleEje=" + IdDetalleEje.ToString)
        ElseIf e.Argument.StartsWith("Cancelar") Then
            Dim j() As String

            Dim IdControl As String
            Dim observacion As String

            j = Split(e.Argument, "|")
            IdControl = j(1)
            observacion = j(2)

            ControlBL.CancelarActividad(IdControl, Session("IdUser"), observacion)
            Response.Redirect("FrmTarea.aspx?IdControl=" + IdControl.ToString + "&IdDetalleEje=" + IdDetalleEje.ToString)
        End If

    End Sub
End Class