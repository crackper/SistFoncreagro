Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmAsignarCentroCostoPorPersona
    Inherits System.Web.UI.Page

    Dim dccBL As New DistribucionCCostosPersonalBL
    Dim IdPeriodoLaboral As Int32
    Dim montoPagado As Decimal
    Dim distribuido As Decimal = 0
    Dim MontoCalculado As Decimal
    Dim RowCalculado As Int32
    Dim arraySession As New Collection
    Dim nombre As String
    Dim area As String
    Dim posicion As String
    Dim Remuneracion As Decimal
    Dim IdArea As Int32
    Dim distribucionCCP As New DistribucionCCP
    Dim distribucionCCPBL As New DistribucionCCPBL
    Dim DBL As New DistribucionCCPBL


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idClienteTxtDist As String
        ' Session("IdPeriodoLaboral") = 2
        IdPeriodoLaboral = Session("IdPeriodoLaboral")
        IdArea = Session("IdArea") 'consultar a la bd
        Remuneracion = Session("Remuneracion") 'consultar a la bd
        nombre = Session("Nombre") ' consultar a la bd
        area = Session("Area") 'consultar a la bd
        posicion = Session("Posicion") 'consultar a la bd

        Me.txtAdministracion.Text = Session("Administrativa") 'consultar a la bd

        Me.lblNombre.Text = Session("nombre")
        Me.lblArea.Text = Session("area")
        Me.lblCargo.Text = Session("posicion")

        'Me.lblNombre.Text = nombre
        'Me.lblArea.Text = area
        'Me.lblCargo.Text = posicion

        Me.txtAdministracion.Text = 1
        'IdPeriodoLaboral = Session("IdPeriodoLaboral")
        'IdPeriodoLaboral = 2
        montoPagado = 3000

        'If Me.GridView1.Rows.Count > 0 Then
        '    If Not String.IsNullOrEmpty(CType(GridView1.FooterRow.FindControl("txtTotalDistribuido"), TextBox).Text) Then
        '        distribuido = CDbl(CType(GridView1.FooterRow.FindControl("txtTotalDistribuido"), TextBox).Text)
        '    Else
        '        distribuido = 0
        '    End If
        'End If

        If Me.GridView1.Rows.Count > 0 Then
            If Not GridView1.FooterRow.FindControl("txtTotalDistribuido") Is Nothing Then
                idClienteTxtDist = GridView1.FooterRow.FindControl("txtTotalDistribuido").ClientID
            Else
                idClienteTxtDist = ""
            End If
            Me.lbtnNuevoPartir.Visible = True
        Else
            idClienteTxtDist = ""
            Me.lbtnNuevoPartir.Visible = False
        End If
        Me.txtValor.Attributes.Add("onblur", "CalcularValor('" + txtValor.ClientID + "','" + CStr(montoPagado) + "','" + idClienteTxtDist + "','" + ddlCondicion.SelectedValue + "','" + Me.txtNuevoDisponible.ClientID + "');")

        'If Not rcbPresupuesto.SelectedItem Is Nothing Then
        '    Me.txtAdministracion.Text = rcbPresupuesto.SelectedItem.Value
        'End If

        If Not Page.IsPostBack Then
            If Me.txtAdministracion.Text = 1 Then
                Me.ODSAreaPresupuestal.TypeName = "SistFoncreagro.BussinesLogic.ProyectoBL"
                Me.ODSAreaPresupuestal.SelectMethod = "GetAllFromProyecto"

                Me.rcbPresupuesto.DataSourceID = "ODSAreaPresupuestal"
                Me.rcbPresupuesto.DataBind()
                Me.rcbCC.DataBind()

            Else
                Me.ODSAreaPresupuestal.TypeName = "SistFoncreagro.BussinesLogic.ProyectoAreaBL"
                Me.ODSAreaPresupuestal.SelectMethod = "GetProyectoAreaByIdAreaByProyectoVigentes"
                'Me.ODSAreaPresupuestal.SelectMethod = "GetCargoByIdCargo"
                Dim parametro1 As New System.Web.UI.WebControls.Parameter
                parametro1.Name = "IdArea"
                parametro1.Type = TypeCode.Int32
                parametro1.DefaultValue = 2
                Me.ODSAreaPresupuestal.SelectParameters.Add(parametro1)

                Me.rcbPresupuesto.DataSourceID = "ODSAreaPresupuestal"
                'Me.ODSAreaPresupuestal.SelectParameters("IdArea").DefaultValue = 1
                Me.rcbPresupuesto.DataBind()
                Me.rcbCC.DataBind()

            End If

            Me.txtSeleccionado.Text = Me.ddlCondicion.SelectedValue

            ''Me.distribucionCCP = Me.distribucionCCPBL.GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha(IdPeriodoLaboral, fechaIni)
            'If Me.GridView1.Rows.Count > 0 Then
            '    Me.Panel1.Visible = False
            'Else
            '    Me.Panel1.Visible = True
            'End If
        End If
    End Sub

    'Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
    '    If Me.GridView1.Rows.Count > 0 Then
    '        Me.txtClickPeriodo.Text = "-1"
    '    Else
    '        If Me.txtClickPeriodo.Text = "1" Then
    '            Me.Panel1.Visible = True
    '            Me.txtClickPeriodo.Text = "-1"
    '        End If
    '    End If
    'End Sub

    Protected Sub rcbPresupuesto_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbPresupuesto.ItemDataBound
        If txtAdministracion.Text = 1 Then
            e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Proyecto)).AreaProyecto.ToString()
            e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Proyecto)).IdProyecto.ToString()
        Else
            e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProyectoArea)).proyectoEntity.AreaProyecto.ToString()
            e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProyectoArea)).IdProyecto.ToString()
            'e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Cargo)).DescCargo.ToString()
            'e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Cargo)).IdCargo.ToString()
        End If

    End Sub


    'Protected Sub rcbPresupuesto_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles rcbPresupuesto.SelectedIndexChanged
    '    'Me.rcbCC.Items.Clear()
    '    Me.ODSCCostos.SelectParameters("_IdProyecto").DefaultValue = rcbPresupuesto.SelectedItem.Value
    '    Me.rcbCC.DataBind()
    '    'MsgBox("hhh")
    '    'Me.UpdatePanel2.DataBind()
    'End Sub

    Protected Sub ddlCondicion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlCondicion.SelectedIndexChanged
        Dim disponible As Decimal

        If GridView1.Rows.Count > 0 Then
            disponible = CStr(CType(GridView1.FooterRow.FindControl("txtDisponible"), TextBox).Text)
        Else
            disponible = montoPagado
        End If

        If Me.ddlCondicion.SelectedValue = "0" Then
            Me.lblValor.Text = " En %"
            Me.txtValor.Visible = True
            If Not String.IsNullOrEmpty(txtValor.Text) Then
                Me.txtValorEstimado.Text = CStr((CDbl(txtValor.Text) / 100) * montoPagado)
                If Not String.IsNullOrEmpty(Me.txtValorEstimado.Text) Then
                    Me.txtNuevoDisponible.Text = disponible - CDbl(Me.txtValorEstimado.Text)
                Else
                    Me.txtNuevoDisponible.Text = disponible
                End If
            End If
        ElseIf Me.ddlCondicion.SelectedValue = "1" Then
            Me.lblValor.Text = "Fijo en S/."
            Me.txtValor.Visible = True
            If Not String.IsNullOrEmpty(txtValor.Text) Then
                Me.txtValorEstimado.Text = txtValor.Text
            End If
            If Not String.IsNullOrEmpty(Me.txtValorEstimado.Text) Then
                Me.txtNuevoDisponible.Text = disponible - CDbl(Me.txtValorEstimado.Text)
            Else
                Me.txtNuevoDisponible.Text = disponible
            End If
        ElseIf Me.ddlCondicion.SelectedValue = "2" Then
            If Me.txtRestante.Text <> "-1" Then
                'Mensaje con javascript
                Dim cadena_java As String
                cadena_java = "<script type='text/javascript'> " & _
                              " alert('Solo puede existir un campo restante'); " & _
                              Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "MensajeRestante", cadena_java.ToString, False)

                'y luego
                Me.ddlCondicion.SelectedValue = "-1"
            Else
                Me.lblValor.Text = ""
                Me.txtValor.Visible = False
                Me.txtValor.Text = ""
                Me.txtValorEstimado.Text = CStr(disponible)
                '
                Me.txtNuevoDisponible.Text = disponible
            End If

        End If
    End Sub

    Protected Sub btnGrabarCC_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnGrabarCC.Click
        Dim listaDccEntity As New List(Of DistribucionCCostosPersonal)
        ''listaDccEntity = dccBL.GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(IdPeriodoLaboral, Me.txtAnio.Text, Me.txtMes.Text)

        'If listaDccEntity.Count > 0 Then
        Dim dccEntity As New DistribucionCCostosPersonal
        dccEntity.IdDistribucionCCP = CInt(Me.txtIdDistribucion.Text)
        dccEntity.IdCCosto = Me.rcbCC.SelectedValue
        dccEntity.IdPeriodoLaboral = IdPeriodoLaboral
        dccEntity.CondicionMonto = Me.ddlCondicion.SelectedValue
        If Not String.IsNullOrEmpty(txtValor.Text) Then
            dccEntity.Valor = Me.txtValor.Text
        End If


        dccBL.SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP(dccEntity)

        ''''dccBL.SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral(dccEntity)
        'Else
        'RECORREMOS LA GRILLA Y LA PASAMOS A UNA LISTA DE DISTRIBUCIONES DE COSTO
        ''If GridView1.Rows.Count > 0 Then
        ''    Dim listaDccEntity2 As New List(Of DistribucionCCostosPersonal)
        ''    For Each row As System.Web.UI.WebControls.GridViewRow In GridView1.Rows
        ''        Dim dccEntity As New DistribucionCCostosPersonal
        ''        dccEntity.IdDistribucionCCP = 0
        ''        dccEntity.IdPeriodoLaboral = IdPeriodoLaboral
        ''        dccEntity.IdCCosto = CInt(CType(row.FindControl("lblCosto"), Label).Text)
        ''        dccEntity.CondicionMonto = CInt(CType(row.FindControl("lblCondicionMonto"), Label).Text)
        ''        dccEntity.Valor = CDec(CType(row.FindControl("lblValor"), Label).Text)
        ''        listaDccEntity2.Add(dccEntity)
        ''    Next
        ''    ' LUEGO INSERTAMOS CADA UNA EN EL MES, AÑO Y PARA EL PERIODO LABORAL
        ''    dccBL.SaveListaDistribucionCCostosPersonal(listaDccEntity2)

        ''    Dim dccEntity2 As New DistribucionCCostosPersonal
        ''    dccEntity2.IdDistribucionCCP = 0
        ''    dccEntity2.IdCCosto = Me.rcbCC.SelectedValue
        ''    dccEntity2.IdPeriodoLaboral = IdPeriodoLaboral
        ''    dccEntity2.CondicionMonto = Me.ddlCondicion.SelectedValue
        ''    dccEntity2.Valor = Me.txtValor.Text
        ''    '''dccBL.SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral(dccEntity2)
        ''Else
        ''    Dim dccEntity As New DistribucionCCostosPersonal
        ''    dccEntity.IdDistribucionCCP = 0
        ''    dccEntity.IdCCosto = Me.rcbCC.SelectedValue
        ''    dccEntity.IdPeriodoLaboral = IdPeriodoLaboral
        ''    If ddlCondicion.SelectedValue <> "-1" Then
        ''        dccEntity.CondicionMonto = Me.ddlCondicion.SelectedValue
        ''    End If
        ''    dccEntity.Valor = Me.txtValor.Text
        ''    '''dccBL.SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral(dccEntity)
        ''End If
        ' ''End If
        borrarDatosFormulario()
        Me.Panel1.Visible = False
        Me.btnAgregar.Enabled = True
        GridView1.DataBind()

    End Sub

    Protected Sub rcbCC_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles rcbCC.SelectedIndexChanged
        'RECORREMOS LA GRILLA Y LA PASAMOS A UNA LISTA DE DISTRIBUCIONES DE COSTO
        Dim existe As Boolean = False
        Dim rowE As System.Web.UI.WebControls.GridViewRow

        'implementarlo luego con do while
        If GridView1.Rows.Count > 0 Then
            For Each row As System.Web.UI.WebControls.GridViewRow In GridView1.Rows
                If CType(row.FindControl("lblIdProyecto"), Label).Text = Me.rcbPresupuesto.SelectedValue And _
                    CType(row.FindControl("lblCCosto"), Label).Text = Me.rcbCC.SelectedValue Then
                    existe = True
                    rowE = row
                End If
            Next
        End If

        If existe Then
            Me.txtValor.Text = CType(rowE.FindControl("lblValor"), Label).Text
            If CType(rowE.FindControl("lblNombreCond"), Label).Text = "restante" Then
                lblValor.Text = "fijo en S/."
                Me.txtValor.Visible = False
            Else
                Me.txtValor.Visible = True
            End If
            Me.ddlCondicion.SelectedValue = CInt(CType(rowE.FindControl("lblCondicionMonto"), Label).Text)
            Me.ddlCondicion.DataBind()
            Me.txtValorEstimado.Text = CType(rowE.FindControl("lblMonto"), Label).Text
            Me.txtNuevoDisponible.Text = CType(GridView1.FooterRow.FindControl("TxtDisponible"), TextBox).Text
        End If
    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        Dim montoCC As Decimal
        Dim dccEntity As SistFoncreagro.BussinessEntities.DistribucionCCostosPersonal = e.Row.DataItem

        If Not dccEntity Is Nothing Then
            montoCC = 0
            Select Case dccEntity.CondicionMonto
                Case 0
                    montoCC = montoPagado * (dccEntity.Valor) / 100
                    'distribuido = distribuido + montoCC
                Case 1
                    montoCC = dccEntity.Valor
                    'distribuido = distribuido + montoCC
                Case 2
                    'MontoCalculado = montoPagado - distribuido ' ver en que se usa
                    RowCalculado = e.Row.RowIndex 'para validar que solo exista un campo calculado
            End Select

            'e.Row.Cells(10).Text = CStr(montoCC)
            CType(e.Row.FindControl("lblMonto"), Label).Text = CStr(montoCC)
        End If

        Dim btn As ImageButton = CType(e.Row.FindControl("btnEliminar"), ImageButton)
        Dim btn2 As ImageButton = CType(e.Row.FindControl("btnEditar"), ImageButton)
        If Not btn Is Nothing Then
            btn.CommandArgument = e.Row.RowIndex
            btn2.CommandArgument = e.Row.RowIndex
        End If
    End Sub

    Protected Sub GridView1_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.PreRender

        For Each row As System.Web.UI.WebControls.GridViewRow In GridView1.Rows
            Dim con As String
            'If Not row.FindControl("LblCondicion") Is Nothing Then
            con = CType(row.FindControl("lblCondicionMonto"), Label).Text
            Select Case con
                Case "0"
                    distribuido = distribuido + CDbl(CType(row.FindControl("lblMonto"), Label).Text)
                Case "1"
                    distribuido = distribuido + CDbl(CType(row.FindControl("lblMonto"), Label).Text)
                Case "2"
                    MontoCalculado = montoPagado - distribuido ' ver en que se usa
                    RowCalculado = row.RowIndex ' para validar que solo exista un campo calculado
                    Me.txtRestante.Text = RowCalculado
            End Select
            'End If
        Next

        If GridView1.Rows.Count > 0 Then
            If Not GridView1.FooterRow.FindControl("txtTotalDistribuido") Is Nothing Then
                CType(GridView1.FooterRow.FindControl("txtTotalDistribuido"), TextBox).Text = CStr(distribuido)
            End If
            If Not GridView1.FooterRow.FindControl("txtDisponible") Is Nothing Then
                CType(GridView1.FooterRow.FindControl("txtDisponible"), TextBox).Text = CStr(montoPagado - distribuido)
            End If
            If Not CType(GridView1.Rows(RowCalculado).FindControl("lblMonto"), Label) Is Nothing Then
                CType(GridView1.Rows(RowCalculado).FindControl("lblMonto"), Label).Text = CStr(montoPagado - distribuido)
            End If
        End If
    End Sub

    Protected Sub GridView2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView2.SelectedIndexChanged
        GridView2.SelectedRow.BackColor = Drawing.Color.AntiqueWhite
        Me.txtIdDistribucion.Text = GridView2.SelectedDataKey.Value
        borrarDatosFormulario()
        Me.Panel1.Visible = True
        Me.btnAgregar.Enabled = True
        Me.Panel4.Visible = True
    End Sub


    Protected Sub GridView2_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView2.SelectedIndexChanging
        If Not GridView2.SelectedRow Is Nothing Then
            GridView2.SelectedRow.BackColor = Drawing.Color.White
        End If
    End Sub

    Protected Sub rcbPresupuesto_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles rcbPresupuesto.SelectedIndexChanged
        Me.rcbCC.ClearSelection()
        Me.rcbCC.Text = ""
        Me.rcbCC.DataBind()
    End Sub


    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        Dim IdDCCP As Int32
        Dim IdCC As Int32

        IdDCCP = CInt(Me.GridView1.DataKeys(e.CommandArgument).Values(1))
        IdCC = CInt(Me.GridView1.DataKeys(e.CommandArgument).Values(0))

        If e.CommandName = "Eliminar" Then
            Me.dccBL.DeleteDISTRIBUCIONCCOSTOSPERSONAL(IdDCCP, IdCC)
            Me.GridView1.DataBind()
        End If

        If e.CommandName = "Editar" Then
            Me.Panel1.Visible = True
            Me.ddlCondicion.SelectedValue = CInt(CType(Me.GridView1.Rows(e.CommandArgument).FindControl("lblCondicionMonto"), Label).Text)
            Me.ddlCondicion.DataBind()
            'Me.rcbPresupuesto.Enabled = False
            'Me.rcbPresupuesto.Text = CType(Me.GridView1.Rows(e.CommandArgument).FindControl("lblCodigoElemento"), Label).Text

            Me.rcbPresupuesto.ClearSelection()
            Me.rcbPresupuesto.SelectedValue = CType(Me.GridView1.Rows(e.CommandArgument).FindControl("lblIdProyecto"), Label).Text
            Me.rcbCC.DataBind()
            Me.rcbCC.SelectedValue = IdCC
            Me.rcbCC.Enabled = False
            Me.rcbPresupuesto.Enabled = False

            Me.txtValor.Text = CType(Me.GridView1.Rows(e.CommandArgument).FindControl("lblValor"), Label).Text
            Me.lblValor.Text = CType(Me.GridView1.Rows(e.CommandArgument).FindControl("lblNombreCond"), Label).Text
            Me.txtValorEstimado.Text = CType(Me.GridView1.Rows(e.CommandArgument).FindControl("lblMonto"), Label).Text
            Me.txtNuevoDisponible.Text = CType(GridView1.FooterRow.FindControl("TxtDisponible"), TextBox).Text
        End If
    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCancelar.Click
        borrarDatosFormulario()
        Me.Panel1.Visible = False
        Me.btnAgregar.Enabled = True
    End Sub

    Sub borrarDatosFormulario()
        Me.rcbPresupuesto.Enabled = True
        Me.rcbPresupuesto.ClearSelection()
        Me.rcbPresupuesto.Text = ""
        Me.rcbCC.ClearSelection()
        Me.rcbCC.Enabled = True
        Me.rcbCC.Text = ""
        Me.ddlCondicion.SelectedValue = "-1"
        Me.txtValor.Text = ""
        Me.lblValor.Text = ""
        Me.txtValorEstimado.Text = ""
        Me.txtNuevoDisponible.Text = ""
    End Sub

    Protected Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAgregar.Click
        Me.Panel1.Visible = True
        Me.btnAgregar.Enabled = False
    End Sub

    Protected Sub btnOKFecha_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnOKFecha.Click
        Dim distribucionEntity As New DistribucionCCP

        distribucionEntity.IdDistribucionCCP = 0
        distribucionEntity.IdPeriodoLaboral = IdPeriodoLaboral
        distribucionEntity.FechaIni = DateValue(Me.rdpFechaConsulta.SelectedDate)
        Me.DBL.SaveDISTRIBUCIONCCP(distribucionEntity)
        Me.GridView2.DataBind()

        btnNuevaDistrib_ModalPopupExtender.Hide()
    End Sub


    Protected Sub GridView2_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView2.RowDataBound
        Dim btn As ImageButton = CType(e.Row.FindControl("btnEliminarD"), ImageButton)
        If Not btn Is Nothing Then
            btn.CommandArgument = e.Row.RowIndex
        End If
    End Sub

    Protected Sub GridView2_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView2.RowCommand
        If e.CommandName = "Actualizar" Then
            Dim distribucioneEntity As New DistribucionCCP
            distribucioneEntity.IdDistribucionCCP = Me.GridView2.DataKeys(GridView2.EditIndex).Value
            distribucioneEntity.IdPeriodoLaboral = IdPeriodoLaboral
            distribucioneEntity.FechaIni = DateValue(CType(Me.GridView2.Rows(GridView2.EditIndex).FindControl("rdpFechaD"), Telerik.Web.UI.RadDatePicker).SelectedDate)

            Me.DBL.SaveDISTRIBUCIONCCP(distribucioneEntity)
            Me.GridView2.DataBind()
            Me.GridView2.EditIndex = -1
        ElseIf e.CommandName = "Eliminar" Then
            Me.DBL.DeleteDISTRIBUCIONCCP(Me.GridView2.DataKeys(e.CommandArgument).Value)
        End If
    End Sub

    Protected Sub GridView2_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles GridView2.RowEditing
        Me.GridView2.EditIndex = e.NewEditIndex
    End Sub

    Protected Sub btnCancelarD_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        GridView2.EditIndex = -1
    End Sub

End Class