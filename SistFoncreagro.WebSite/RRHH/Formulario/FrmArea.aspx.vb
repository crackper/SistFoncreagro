Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmArea
    Inherits System.Web.UI.Page
    Dim areaBL As New AreaBL
    Dim elemento As Telerik.Web.UI.TreeListDataItem

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.RadTreeList1.SelectedItems[0][""]
    End Sub

    Protected Sub RadTreeList1_NeedDataSource(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListNeedDataSourceEventArgs) Handles RadTreeList1.NeedDataSource
        '    Protected Sub RadTreeList1_NeedDataSource(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim argArea As ArgumentosArea
        argArea = New ArgumentosArea(True, False, 1000, False, 0)
        RadTreeList1.DataSource = areaBL.GetAllFromArea(argArea)
    End Sub

    Protected Sub RadTreeList1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListItemDataBoundEventArgs) Handles RadTreeList1.ItemDataBound
        Dim dataArea As Telerik.Web.UI.TreeListDataItem
        Dim funcion As String
        'Dim area As Area = CType(dataArea, SistFoncreagro.BussinessEntities.Area)
        'Me.TextBox1.Text = e.Item
        If e.Item.GetType.ToString = "Telerik.Web.UI.TreeListDataItem" Then
            dataArea = e.Item
            Dim obj As Object
            obj = dataArea.DataItem
            obj = CType(obj, SistFoncreagro.BussinessEntities.Area)
            'funcion = "ver(" & "'" & obj.IdArea & "')"
            funcion = "ver(" & "'" & e.Item.ClientID & "')"
            'e.Item.Attributes.Add("OnClick", funcion)
        End If
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btnSeleccionar As New ImageButton
        btnSeleccionar = CType(sender, ImageButton)
        If btnSeleccionar.CommandName = "Select" Then
            If Me.RadTreeList1.SelectedItems.Count > 0 Then
                elemento = Me.RadTreeList1.SelectedItems(0)
                CType(elemento.FindControl("ImageButton7"), ImageButton).ImageUrl = "~/img/Update2.gif"
            End If
        End If
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btn As New ImageButton
        btn = CType(sender, ImageButton)
        If btn.CommandName = "Nuevo" Then
            Response.Redirect("~\RRHH\Formulario\FrmEditarArea.aspx?Dependencia=" & btn.CommandArgument & "&IdArea=0")
        End If
    End Sub
    'ImageButton6_Click

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btn As New ImageButton
        btn = CType(sender, ImageButton)
        If btn.CommandName = "Editar" Then
            Dim ids() As String = Split(btn.CommandArgument, "/")
            If ids(0) = "" Then
                ids(0) = "0"
            End If
            If ids(1) = "" Then
                ids(1) = "0"
            End If
            Response.Redirect("~\RRHH\Formulario\FrmEditarArea.aspx?Dependencia=" & ids(0) & "&IdArea=" & ids(1))
        End If
    End Sub


    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        Dim btnSeleccionar As New ImageButton

        If Me.RadTreeList1.SelectedItems.Count > 0 Then
            btnSeleccionar = CType(Me.RadTreeList1.SelectedItems(0).FindControl("ImageButton7"), ImageButton)
            If Not elemento Is Nothing Then
                If elemento.GetDataKeyValue("IdArea") = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea") Then
                    RadTreeList1.ClearSelectedItems()
                    btnSeleccionar.ImageUrl = "~/img/Update2.gif"
                Else
                    btnSeleccionar.ImageUrl = "~/img/Update.gif"
                End If
            Else
                btnSeleccionar.ImageUrl = "~/img/Update.gif"
            End If
        End If

        If Me.RadTreeList1.SelectedItems.Count > 0 Then
            If Me.txtNomArea1.Text = "" Or (Me.txtNomArea1.Text <> "" And Me.txtOperacion.Text = "") Then
                Me.txtNomArea1.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text
                Me.txtIdArea1.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
                ' Me.txtIdArea2.Text = Me.RadTreeList1.SelectedItems(0).DataItemIndex
                If Me.RadTreeList1.SelectedItems(0).DataItemIndex > 0 Then
                    Me.txtIdArea2.Text = Me.RadTreeList1.Items(Me.RadTreeList1.SelectedItems(0).DataItemIndex - 1).GetDataKeyValue("IdArea")
                End If
                Me.imgBtnCancelar.Visible = True
            Else
                If Not Me.txtIdArea1.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea") Then
                    Me.txtNomArea2.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text
                    Me.txtIdArea2.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
                    Me.imgBtnCambiar.Visible = True
                End If
            End If
        Else
            Me.txtNomArea2.Text = ""    'Me.RadTreeList1.SelectedItems(0)("Nombre").Text
            Me.txtOperacion.Text = ""   'Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
            Me.txtNomArea1.Text = ""
            Me.txtIdArea1.Text = ""
            Me.txtIdArea2.Text = ""
            Me.imgBtnCambiar.Visible = False
            Me.imgBtnCancelar.Visible = False
        End If

    End Sub

    Protected Sub imgBtnMover_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgBtnMover.Click
        If Not String.IsNullOrEmpty(Me.txtNomArea1.Text) Then
            Me.txtOperacion.Text = "Mover"
            Me.lblMensaje.Text = ""
            Me.lblMensaje.Visible = False
            Me.imgBtnSubirNivel.Visible = False
            Me.imgBtnBajarNivel.Visible = False
        Else
            Me.lblMensaje.Text = "Seleccione antes un Area, luego Mover y luego el Area que dependerá de ésta."
            Me.lblMensaje.Visible = True
        End If
    End Sub

    Protected Sub imgBtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgBtnCancelar.Click
        'RadTreeList1.ClearSelectedItems()
        Me.txtNomArea1.Text = ""
        Me.txtNomArea2.Text = ""
        Me.txtOperacion.Text = ""
        Me.imgBtnSubirNivel.Enabled = True
        Me.imgBtnBajarNivel.Enabled = True
    End Sub



    ''Protected Sub RadTreeList1_ItemCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListItemCreatedEventArgs) Handles RadTreeList1.ItemCreated
    ''    Dim btnSeleccionar As New ImageButton
    ''    If Me.RadTreeList1.SelectedItems.Count <= 0 Then

    ''        btnSeleccionar = CType(e.Item.FindControl("ImageButton7"), ImageButton)
    ''        If Not btnSeleccionar Is Nothing Then
    ''            btnSeleccionar.ImageUrl = "~/img/Update2.gif"
    ''        End If
    ''    End If
    ''End Sub


    ''Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    ''    Dim btnSeleccionar As New ImageButton
    ''    btnSeleccionar = CType(sender, ImageButton)
    ''    If btnSeleccionar.CommandName = "Select" Then
    ''        If Me.RadTreeList1.SelectedItems.Count > 0 Then
    ''            elemento = Me.RadTreeList1.SelectedItems(0)
    ''        End If
    ''        'RadTreeList1.ClearSelectedItems()
    ''        'btnSeleccionar.CommandName = "Select"
    ''        'ElseIf btnSeleccionar.CommandName = "Select" Then
    ''        '    btnSeleccionar.CommandName = "Deselect"
    ''    End If
    ''    'If btnSeleccionar.CommandName = "Seleccionar" Or btnSeleccionar.CommandName = "Deselect" Then
    ''    'btnSeleccionar.CommandName = "Select"
    ''    'Me.txtNomArea1.Text = btnSeleccionar.CommandArgument

    ''    'Else
    ''    '    If btnSeleccionar.CommandName = "Select" Then
    ''    '        btnSeleccionar.CommandName = "Deselect"
    ''    '    End If
    ''    '    'If Me.RadTreeList1.SelectedItems.Count > 0 Then
    ''    '    '    Me.TextBox3.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text
    ''    '    '    Me.TextBox2.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
    ''    '    'End If
    ''    'End If
    ''End Sub
    '' ''Ver en que orden se ejecutan los eventos.
    ' ''Protected Sub RadTreeList1_AutoGeneratedColumnCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListAutoGeneratedColumnCreatedEventArgs) Handles RadTreeList1.AutoGeneratedColumnCreated
    ' ''    Me.TextBox4.Text = "AutoGeneratedColumnCreated"
    ' ''End Sub

    ''Protected Sub RadTreeList1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListCommandEventArgs) Handles RadTreeList1.ItemCommand
    ''    'Me.TextBox4.Text = e.CommandName
    ''    'Dim btnSeleccionar As New ImageButton

    ''    'btnSeleccionar = CType(e.Item.FindControl("ImageButton7"), ImageButton)

    ''    'If e.CommandName = "Select" Then
    ''    '    If Not elemento Is Nothing Then
    ''    '        If elemento.GetDataKeyValue("IdArea") = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea") Then
    ''    '            btnSeleccionar.CommandName = "Deselect"
    ''    '        Else
    ''    '            btnSeleccionar.CommandName = "Seleccionar"
    ''    '        End If
    ''    '    Else
    ''    '        btnSeleccionar.CommandName = "Seleccionar"
    ''    '    End If
    ''    '    'btnSeleccionar.CommandName = "Deseleccionar"
    ''    'ElseIf e.CommandName = "Deselect" Then
    ''    '    btnSeleccionar.CommandName = "Seleccionar"
    ''    'End If
    ''    ''If Me.RadTreeList1.SelectedItems.Count > 0 Then
    ''    ''    Me.TextBox3.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text
    ''    ''    Me.TextBox2.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
    ''    ''End If
    ''End Sub


    ' '' ''If Me.RadTreeList1.SelectedItems.Count > 0 Then
    ' '' ''        If Me.txtNomArea1.Text = "" Then
    ' '' ''            Me.txtNomArea1.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text
    ' '' ''            Me.txtIdArea1.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
    '' '' '' Me.txtIdArea2.Text = Me.RadTreeList1.SelectedItems(0).DataItemIndex
    ' '' ''            Me.txtIdArea2.Text = Me.RadTreeList1.Items(Me.RadTreeList1.SelectedItems(0).DataItemIndex - 1).GetDataKeyValue("IdArea")
    ' '' ''            Me.imgBtnCancelar.Visible = True
    ' '' ''        Else
    ' '' ''            If Me.txtOperacion.Text = "" Then
    ' '' ''                Me.txtNomArea1.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text
    ' '' ''                Me.txtIdArea1.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
    '' '' ''Me.txtIdArea2.Text = Me.RadTreeList1.SelectedItems(0).DataItemIndex
    ' '' ''                Me.txtIdArea2.Text = Me.RadTreeList1.Items(Me.RadTreeList1.SelectedItems(0).DataItemIndex - 1).GetDataKeyValue("IdArea")
    ' '' ''            Else
    ' '' ''                If Not Me.txtNomArea1.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text Then
    ' '' ''                    Me.txtNomArea2.Text = Me.RadTreeList1.SelectedItems(0)("Nombre").Text
    ' '' ''                    Me.txtIdArea2.Text = Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
    ' '' ''                    Me.imgBtnCambiar.Visible = True
    ' '' ''                End If
    ' '' ''            End If
    ' '' ''        End If
    ' '' ''    Else
    ' '' ''        Me.txtNomArea2.Text = ""    'Me.RadTreeList1.SelectedItems(0)("Nombre").Text
    ' '' ''        Me.txtOperacion.Text = ""   'Me.RadTreeList1.SelectedItems(0).GetDataKeyValue("IdArea")
    ' '' ''        Me.txtNomArea1.Text = ""
    ' '' ''        Me.imgBtnCambiar.Visible = False
    ' '' ''        Me.imgBtnCancelar.Visible = False
    ' '' ''    End If


    Protected Sub RadTreeList1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.TreeListCommandEventArgs) Handles RadTreeList1.DeleteCommand
        Dim fila As Telerik.Web.UI.TreeListDataItem
        fila = e.Item
        Me.areaBL.DeleteAreaAndSubAreas(fila.GetDataKeyValue("IdArea"))

    End Sub

End Class
