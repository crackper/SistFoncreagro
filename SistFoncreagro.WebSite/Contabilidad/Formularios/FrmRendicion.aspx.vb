Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI
Public Class FrmRecibo
    Inherits System.Web.UI.Page
    Dim ReciboRendicionBL As New RecibosRendicionBL
    Dim _ReciboRendicion As New RecibosRendicion
    Dim RendicionBL As New RendicionBL
    Dim _Rendicion As New Rendicion
    Dim Rendicion As Rendicion
    Dim IdRendicion As String
    Dim _DocumentoRendido As New DocumentoRendido
    Dim DocumentoRendidoBL As New DocumentoRendidoBL
    Dim ReciboBL As New ReciboBL
    Dim TransaccionBl As New TransaccionBL
    Dim _Proveedor As ProveedorCliente
    Dim Proveedor As New ProveedorClienteBL
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdRendicion = Request.QueryString("IdRendicion")
        Me.RadTextBox2.Text = IdRendicion

        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.ImageButton3.Visible = False
            Me.ImageButton4.Visible = False
            Me.ImageButton6.Visible = False
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        Else
            If IdRendicion > 0 Then
                Me.ImageButton6.Visible = True
            Else
                Me.ImageButton6.Visible = False
            End If
        End If

        'para agregar un evento 
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")
        Me.txtDate.Attributes.Add("onChange", "ValidarFecha();")
        Me.ImageButton6.Attributes.Add("onClick", "radconfirm('¿Está seguro de enviar la Rendición para su Aprobación?', confirmCallBackFn, 330, 100, null,'Mensaje de Confirmación'); return false;")

        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1
        Me.RadComboBox5.Filter = 1
        Me.RadComboBox8.Filter = 1
       
        Me.RadGrid2.MasterTableView.HierarchyDefaultExpanded = True

        If Page.IsPostBack = False Then

            Me.txtDate.Text = Session("Fecha").ToString
            Me.RadComboBox5.SelectedValue = 2
            Me.RadComboBox4.SelectedValue = 6

            Me.RadComboBox8.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = "43675232"
            Me.RadComboBox8.DataBind()
            Me.RadComboBox8.SelectedValue = 10088


            If Me.RadTextBox2.Text > 0 Then

                'para recuperar datos de rendicion
                Rendicion = RendicionBL.GetRENDICIONByIdRendicion(IdRendicion)
                Me.RadTextBox2.Text = Rendicion.IdRendicion
                Me.RadComboBox5.SelectedValue = Rendicion.IdOpFinanciera
                Me.RadComboBox4.SelectedValue = Rendicion.IdSubDiario
                Me.RadTextBox1.Text = Rendicion.Codigo
                Me.RadComboBox3.SelectedValue = Rendicion.IdProyecto
                Me.txtDate.Text = Rendicion.Fecha

                _Proveedor = Proveedor.GetAllFromProveedorClienteById(Rendicion.Responsable)
                Me.RadComboBox8.DataSourceID = "odsProveedor"
                Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Proveedor.Ruc
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = Rendicion.Responsable

                If Rendicion.Estado = "4" Then
                    Me.Label1.Visible = True
                    Me.Label2.Visible = True
                    Me.Label2.Text = Rendicion.Observacion
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim IdRecibo As Nullable(Of Int32)
        Dim IdRendicion As Int32

        'Grabamos la rendicion
        _Rendicion.Fecha = Me.txtDate.Text
        _Rendicion.IdOpFinanciera = Me.RadComboBox5.SelectedValue
        _Rendicion.IdProyecto = Me.RadComboBox3.SelectedValue
        _Rendicion.IdSubDiario = Me.RadComboBox4.SelectedValue
        _Rendicion.Responsable = Me.RadComboBox8.SelectedValue
        _Rendicion.IdRendicion = Me.RadTextBox2.Text
        _Rendicion.Observacion = ""

        IdRendicion = RendicionBL.SaveRENDICION(_Rendicion)
        Me.RadTextBox2.Text = IdRendicion

        For i = 0 To Me.RadGrid1.Items.Count - 1
            Dim ch As CheckBox = CType(Me.RadGrid1.Items(i).FindControl("CheckBox1"), CheckBox)

            If ch.Checked = True Then
                IdRecibo = Int32.Parse(Me.RadGrid1.Items(i)("IdRecibo").Text.ToString)

                If IdRecibo = 0 Then
                    _ReciboRendicion.IdRecibo.Equals(DBNull.Value)
                Else
                    _ReciboRendicion.IdRecibo = IdRecibo
                End If
                _ReciboRendicion.IdRendicion = Me.RadTextBox2.Text
                ReciboRendicionBL.SaveRECIBOSRENDICION(_ReciboRendicion)
                ReciboBL.UpdateEstadoRECIBO(IdRecibo, "R")

            End If
        Next
        Me.RadGrid2.Rebind()
        Me.RadGrid1.Rebind()
        Me.RadGrid1.Visible = False
        Response.Redirect("FrmRendicion.aspx?IdRendicion=" + IdRendicion.ToString)
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmRendicion.aspx?IdRendicion=0")
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32
        If "Documentos".Equals(e.Item.OwnerTableView.Name) Then
            id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDocRendido")
            DocumentoRendidoBL.DeleteDOCUMENTORENDIDO(id)
        Else
            id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdReciboRendicion")
            ReciboRendicionBL.DeleteRECIBOSRENDICION(id)
        End If
        Me.RadGrid2.DataBind()
        Me.RadGrid1.DataBind()
    End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
        Dim valor As Int32

        _DocumentoRendido.FechaDocumento = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _DocumentoRendido.FechaVencimiento = CType(userControl.FindControl("txtDate2"), TextBox).Text
        _DocumentoRendido.FechaPago = CType(userControl.FindControl("txtDate3"), TextBox).Text
        _DocumentoRendido.Glosa = CType(userControl.FindControl("RadTextBox3"), RadTextBox).Text
        _DocumentoRendido.IdCCosto = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
        _DocumentoRendido.IdDocumentoCont = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        _DocumentoRendido.IdProveedorCliente = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _DocumentoRendido.IdReciboRendicion = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdReciboRendicion").ToString
        _DocumentoRendido.Monto = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _DocumentoRendido.NroDocumento = CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text
        _DocumentoRendido.Serie = CType(userControl.FindControl("RadTextBox2"), RadTextBox).Text
        _DocumentoRendido.TipoCambio = CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Text
        _DocumentoRendido.IdTipoGasto = CType(userControl.FindControl("RadComboBox9"), RadComboBox).SelectedValue


        'validamos si el documento que se esta registrando ya se encuentrra registrado
        valor = TransaccionBl.VerifyDocumentoDuplicadoRendicion(_DocumentoRendido.IdProveedorCliente, _DocumentoRendido.Serie, _DocumentoRendido.NroDocumento, _DocumentoRendido.IdDocumentoCont, 0)
        If valor > 0 Then
            Dim cadena_java As String = _
                                  "<script type='text/javascript'> " & _
                                  " Alerta('¡EL Documento ingresado ya está registrado, no se puede grabar!'); " & _
                                  Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            e.Canceled = True
        Else
            DocumentoRendidoBL.SaveDOCUMENTORENDIDO(_DocumentoRendido)
            Me.RadGrid2.DataBind()
        End If
    End Sub

    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim valor As Int32

        _DocumentoRendido.IdDocRendido = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDocRendido")
        _DocumentoRendido.FechaDocumento = CType(userControl.FindControl("txtDate1"), TextBox).Text
        _DocumentoRendido.FechaVencimiento = CType(userControl.FindControl("txtDate2"), TextBox).Text
        _DocumentoRendido.FechaPago = CType(userControl.FindControl("txtDate3"), TextBox).Text
        _DocumentoRendido.Glosa = CType(userControl.FindControl("RadTextBox3"), RadTextBox).Text
        _DocumentoRendido.IdCCosto = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
        _DocumentoRendido.IdDocumentoCont = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        _DocumentoRendido.IdProveedorCliente = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        _DocumentoRendido.IdReciboRendicion = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdReciboRendicion").ToString
        _DocumentoRendido.Monto = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text
        _DocumentoRendido.NroDocumento = CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text
        _DocumentoRendido.Serie = CType(userControl.FindControl("RadTextBox2"), RadTextBox).Text
        _DocumentoRendido.TipoCambio = CType(userControl.FindControl("RadNumericTextBox3"), RadNumericTextBox).Text
        _DocumentoRendido.IdTipoGasto = CType(userControl.FindControl("RadComboBox9"), RadComboBox).SelectedValue

        'validamos si el documento que se esta registrando ya se encuentrra registrado
        valor = TransaccionBl.VerifyDocumentoDuplicadoRendicion(_DocumentoRendido.IdProveedorCliente, _DocumentoRendido.Serie, _DocumentoRendido.NroDocumento, _DocumentoRendido.IdDocumentoCont, _DocumentoRendido.IdDocRendido)
        If valor > 0 Then
            Dim cadena_java As String = _
                                  "<script type='text/javascript'> " & _
                                  " Alerta('¡EL Documento ingresado ya está registrado, no se puede grabar!'); " & _
                                  Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            e.Canceled = True
        Else
            DocumentoRendidoBL.SaveDOCUMENTORENDIDO(_DocumentoRendido)
            Response.Redirect("FrmRendicion.aspx?Idrendicion=" + Me.RadTextBox2.Text)
        End If

       
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand

        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)
        Dim id As Int32
        If "Documentos".Equals(e.Item.OwnerTableView.Name) Then
            id = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdReciboRendicion").ToString
            Session("IdReciboRendicion") = id
        End If

        'If e.CommandName = "InitInsert" Then
        '    'Dim control As SistFoncreagro.WebSite.ControlDocumento
        '    'control = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), SistFoncreagro .WebSite .ControlDocumento )
        '    'control.IdreciboRendicion = id

        'End If
    End Sub

    Protected Sub RadGrid2_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid2.ItemDataBound
        If "Documentos".Equals(e.Item.OwnerTableView.Name) Then
            If estadoMes = "C" Then
                For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                    e.Item.OwnerTableView.Items.Item(i)("eliminar").Text = ""
                    e.Item.OwnerTableView.Items.Item(i)("editar").Text = ""
                Next
                e.Item.OwnerTableView.CommandItemDisplay = GridCommandItemDisplay.None
            End If
        End If
        If "Recibos".Equals(e.Item.OwnerTableView.Name) Then
            If estadoMes = "C" Then
                For i = 0 To e.Item.OwnerTableView.Items.Count - 1
                    e.Item.OwnerTableView.Items.Item(i)("eliminar").Text = ""
                Next
                e.Item.OwnerTableView.CommandItemDisplay = GridCommandItemDisplay.None
            End If
        End If
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "ActualizarLista" Then
            Me.RadComboBox8.DataBind()
        ElseIf e.Argument = "ValidarFecha" Then
            If Me.txtDate.Text.Length > 0 Then
                If (CDate(Me.txtDate.Text).Month <> Session("Mes") Or CDate(Me.txtDate.Text) > CDate(Session("Fecha"))) Then
                    Dim cadena_java As String = _
                                       "<script type='text/javascript'> " & _
                                       " Alerta('¡La Fecha Contable es incorrecta!'); Foco(); " & _
                                       Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                End If
            End If
        ElseIf e.Argument.StartsWith("Enviar") Then
            Dim j() As String
            Dim valor As String
            j = Split(e.Argument, "|")

            valor = j(1)
            If valor = "true" Then
                RendicionBL.UpdateEstadoRENDICION(IdRendicion, "2")
                Response.Redirect("ListaRendiciones.aspx")
            End If
        End If
    End Sub


    Protected Sub RadComboBox8_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox8.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).Ruc.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).RazonSocial.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProveedorCliente)).IdProveedorCliente.ToString()
    End Sub

    Protected Sub RadComboBox8_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox8.ItemsRequested
        If e.Text.Length > 2 Then

            Me.RadComboBox8.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString

            Me.RadComboBox8.DataBind()
        End If
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('ReporteDocFondoFijo.aspx?IdRendicion=" + Me.RadTextBox2.Text + "'); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class