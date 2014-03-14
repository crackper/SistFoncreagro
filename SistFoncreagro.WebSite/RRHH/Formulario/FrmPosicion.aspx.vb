Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmPosicion
    Inherits System.Web.UI.Page
    Dim posicionBL As New PosicionBL
    Dim cargoBl As New CargoBL
    Dim areaBl As New AreaBL
    Dim IdArea As Int32
    Dim posicion As Posicion
    Dim nuevo As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdArea = CInt(Request.QueryString("IdArea"))
        'IdArea = 1

    End Sub

    Protected Sub RadTreeList1_NeedDataSource(ByVal sender As Object, ByVal e As System.EventArgs)
        RadTreeList1.DataSource = posicionBL.GetListaPosicionesDeUnaAreaySubAreasByIdArea(IdArea)
    End Sub

    Protected Sub RadTreeList1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListItemDataBoundEventArgs) Handles RadTreeList1.ItemDataBound
        Dim dataPosicion As Telerik.Web.UI.TreeListDataItem
       
        If e.Item.GetType.ToString = "Telerik.Web.UI.TreeListDataItem" Then
            dataPosicion = e.Item
            Dim obj As Object
            obj = dataPosicion.DataItem
            obj = CType(obj, SistFoncreagro.BussinessEntities.Posicion)

            If Not obj Is Nothing Then
                If obj.EsJefeArea Then
                    CType(dataPosicion.FindControl("Empleado"), Image).ImageUrl = "~/img/jefe.gif"
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btnSeleccionar As New ImageButton
        btnSeleccionar = CType(sender, ImageButton)
        If btnSeleccionar.CommandName = "Nuevo" Then
            Me.RadTreeList1.ClearSelectedItems()
            Me.txtPosicionJefe.Text = ""
            'Me.txtAreaJefe.Text = ""
            Me.txtDescripcion.Text = ""

            Me.txtIdArea.Text = ""
            Me.txtPosicionJefe.Text = ""
            Me.rcbPosicion.Text = ""
            panelPosicion.Visible = True
            Me.nuevo = True
            Me.txtIdPosicionPadre.Text = btnSeleccionar.CommandArgument
        End If
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        If RadTreeList1.Items.Count > 0 Then

        'Me.txtPosicionJefe.Text = ""
        'Me.txtAreaJefe.Text = ""
        'Me.txtDescripcion.Text = ""
        'Me.txtExperiencia.Text = ""
        Me.txtIdArea.Text = ""
        'Me.txtIdPosicionPadre.Text = ""
        'Me.txtPosicionJefe.Text = ""
        Me.rcbPosicion.Text = ""

        If RadTreeList1.SelectedItems.Count > 0 Then
            Me.panelPosicion.Visible = True
            ' Me.PanelDetalle.Visible = True
            txtIdPosicion.Text = RadTreeList1.SelectedItems(0).GetDataKeyValue("IdPosicion")
        Else
            If Me.nuevo Then
                Me.txtIdPosicion.Text = ""
                Dim argArea As New ArgumentosArea(0, 0, 10000, 0, 0)
                Dim argPosicion As New ArgumentosPosicion(argArea, 1, 1, 0, 0, 0, 0)
                posicion = posicionBL.GetPosicionByIdPosicion(CInt(Me.txtIdPosicionPadre.Text), argPosicion)

                Me.txtIdPosicion.Text = 0
                Me.txtIdArea.Text = posicion.Area.IdArea
                Me.txtArea.Text = posicion.Area.Nombre
                Me.txtPosicionJefe.Text = posicion.NomCargo

            Else
                Me.txtIdPosicion.Text = ""
                Me.txtPosicionJefe.Text = ""
                'Me.txtAreaJefe.Text = ""
                Me.txtDescripcion.Text = ""
                Me.txtIdArea.Text = ""
                Me.txtIdPosicionPadre.Text = ""
                Me.txtPosicionJefe.Text = ""
                Me.rcbPosicion.Text = ""
                Me.panelPosicion.Visible = False
            End If
            'Me.panelPosicion.Visible = False
        End If

        If Not String.IsNullOrEmpty(Me.txtIdPosicion.Text) Then
            If Me.txtIdPosicion.Text > 0 Then

                Me.nuevo = False
                Dim argArea As New ArgumentosArea(0, 0, 10000, 0, 0)
                Dim argPosicion As New ArgumentosPosicion(argArea, 1, 1, 0, 0, 0, 0)
                posicion = posicionBL.GetPosicionByIdPosicion(CInt(Me.txtIdPosicion.Text), argPosicion)

                Me.txtIdArea.Text = posicion.IdArea

                ''If posicion.Dependencia.HasValue Then
                    If Not posicion.jefeInmediato Is Nothing Then
                        If posicion.Dependencia.HasValue Then
                            Me.txtIdPosicionPadre.Text = posicion.Dependencia
                            Me.txtPosicionJefe.Text = posicion.jefeInmediato.NomCargo
                        Else
                            Me.txtPosicionJefe.Text = "---"
                        End If

                        'Me.txtAreaJefe
                    Else
                        If Not posicion.Area.AreaSuperior Is Nothing Then
                            Me.txtPosicionJefe.Text = "No determinado"
                        Else
                            Me.txtPosicionJefe.Text = "No tiene"
                        End If
                    End If
                ''Else
                ''Me.txtPosicionJefe.Text = "No Figura"
                ''End If
               

                If Not posicion.Area Is Nothing Then
                    Me.txtArea.Text = posicion.Area.Nombre
                    Me.txtIdArea.Text = posicion.Area.IdArea

                    If Not posicion.Area.AreaSuperior Is Nothing Then
                        Me.txtPosicionJefe.Text = Me.txtPosicionJefe.Text & " _ " & posicion.Area.AreaSuperior.Nombre
                    End If
                End If

                Me.txtDescripcion.Text = posicion.DescCargo

                    Me.cbJefeArea.Checked = posicion.EsJefeArea

                If posicion.IdCargo.HasValue Then

                    Me.rcbPosicion.SelectedValue = posicion.IdCargo
                    Me.rcbPosicion.Text = posicion.NomCargo
                    'Me.rcbPosicion.EnableTextSelection = True
                    Me.rcbPosicion.DataBind()
                End If
            End If
        Else
            'Me.PanelDetalle.Visible = False
        End If
        Else
        Dim argAreaO As New ArgumentosArea(0, 0, 11000, 0, 0)
        Dim areaO As New Area
        areaO = areaBl.GetAREAByIdArea(IdArea, argAreaO)
        Me.panelPosicion.Visible = True
        Me.txtIdPosicion.Text = 0
        Me.txtIdArea.Text = IdArea
        Me.txtArea.Text = areaO.Nombre
        If Not areaO.AreaSuperior Is Nothing Then
            If Not areaO.AreaSuperior.Jefatura Is Nothing Then
                Me.txtPosicionJefe.Text = areaO.AreaSuperior.Jefatura.NomCargo & "/" & areaO.AreaSuperior.Nombre
            Else
                Me.txtPosicionJefe.Text = "---"
            End If
        Else
            Me.txtPosicionJefe.Text = "---"
        End If

        Me.cbJefeArea.Checked = True
        Me.cbJefeArea.Enabled = False
        End If
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Dim posicion As New Posicion
        Dim jefe As New Posicion
        posicion.IdPosicion = txtIdPosicion.Text
        posicion.Area.IdArea = txtIdArea.Text
        posicion.IdCargo = Me.rcbPosicion.SelectedValue

        If Not String.IsNullOrEmpty(txtIdPosicionPadre.Text) Then
            If txtIdPosicionPadre.Text > 0 Then
                jefe.IdPosicion = txtIdPosicionPadre.Text
            Else
                jefe.IdPosicion = Nothing
            End If
        Else
            jefe.IdPosicion = Nothing
        End If

        posicion.jefeInmediato = jefe
        posicion.EsJefeArea = Me.cbJefeArea.Checked

        Me.txtIdPosicion.Text = posicionBL.SavePosicion(posicion)

        Me.Response.Redirect("FrmPosicion.aspx?IdArea=" & IdArea)
    End Sub

    Protected Sub rcbPosicion_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles rcbPosicion.SelectedIndexChanged
        'If rcbPosicion.SelectedValue > 0 Then
        '    Dim cargo As New Cargo
        '    cargo = cargoBl.GetCargoByIdCargo(rcbPosicion.SelectedValue)
        '    If Not cargo Is Nothing Then
        '        Me.txtDescripcion.Text = cargo.DescCargo
        '    End If
        'End If
    End Sub

    ''Protected Sub gvFuncion_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvFuncion.RowCreated
    ''    If Not e.Row.DataItem Is Nothing Then
    ''        e.Row.Cells(0).Text = e.Row.RowIndex + 1 & "."
    ''    End If
    ''End Sub


    Protected Sub AJAX_MANAGER_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles AJAX_MANAGER.AjaxRequest
        If e.Argument.StartsWith("ActualizarCombo") Then
            Dim j() As String
            Dim idCargo As Int32
            j = Split(e.Argument, "|")

            idCargo = Convert.ToInt32(j(1))

            'Me.RadComboBox1.DataBind()
            Me.rcbPosicion.SelectedValue = idCargo
        End If
    End Sub

 
    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Me.panelPosicion.Visible = False
    End Sub

    Protected Sub RadTreeList1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListCommandEventArgs) Handles RadTreeList1.DeleteCommand
        Dim fila As Telerik.Web.UI.TreeListDataItem
        fila = e.Item
        Me.posicionBL.DeletePosicion(fila.GetDataKeyValue("IdPosicion"))
    End Sub
End Class

