Imports SistFoncreagro.BussinesLogic
Imports Telerik.Web.UI
Public Class FrmConfiguracion
    Inherits System.Web.UI.Page

    Dim requerimientoBl As RequerimientoBL
    Dim vista As Disenio
    Public Function ObtenerColor(ByVal estado As String) As Drawing.Color
        vista = New Disenio
        Return vista.ObtenerColorRequerimiento(estado)
    End Function

    'Protected Sub CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim chkBox As CheckBox = CType(sender, CheckBox)
    '    Dim myPanel As Panel = CType(chkBox.Parent, Panel)
    '    Dim dataItem As GridDataItem = CType(myPanel.NamingContainer, GridDataItem)
    '    Dim dis As New Disenio
    '    If chkBox.Checked Then
    '        dis.Alerta("Paso", Page)
    '        MsgBox("a")
    '        'dataItem("ShipName").Style("color") = "orange"
    '    Else
    '        dis.Alerta("Paso", Page)
    '        MsgBox("a")
    '        'dataItem("ShipName").Style("color") = "black"
    '    End If
    'End Sub
    Function nombre(ByVal parametro As Boolean) As String
        If parametro = True Then
            Return "Deshabilitar"
        Else
            Return "Habilitar"
        End If
    End Function
    Sub Resultado(ByVal idRequerimieto As Int32, ByVal valor As Boolean)
        requerimientoBl = New RequerimientoBL
        Dim resultado As Integer
        resultado = requerimientoBl.HabilitarCentroCosto(idRequerimieto, valor)
        If resultado = 0 Then
            lblMensaje.Visible = True
        Else
            lblMensaje.Visible = False
            '    RadGrid1.DataBind()
            '    lblMensaje.Visible = False
        End If
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)

        Dim id As Int32 = CInt(item.GetDataKeyValue("IdReq").ToString())
        Dim estado As Boolean = CBool(item.GetDataKeyValue("ActivarCentroCosto").ToString())
        If e.CommandName = "Habilitar" Then
            If estado = False Then
                Resultado(id, True)
                RadGrid1.DataBind()
            Else
                lblMensaje.Visible = False
            End If
        ElseIf e.CommandName = "Deshabilitar" Then
            If estado = True Then
                Resultado(id, False)
                RadGrid1.DataBind()
            Else
                lblMensaje.Visible = False
            End If
        End If
    End Sub
    Public Sub Alerta1(ByVal Mensaje As String)
        Dim cj As String
        cj = "<script type='text/javascript'> " & _
             " radalert('" & Mensaje & "',400,100); " & _
             Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Me.Page, GetType(Page), "xalerta", cj.ToString, False)
    End Sub
    'Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
    '    'If e.Item.ItemType = GridItemType.Item OrElse e.Item.ItemType = GridItemType.AlternatingItem Then
    '    '    Dim boton As LinkButton = e.Item.FindControl("lbHabilitar")

    '    '    If Not [Object].Equals(boton, Nothing) Then
    '    '        Dim currentRow As DataRowView = DirectCast(e.Item.DataItem, DataRowView)
    '    '        Dim IdRequerimiento As TextBox = currentRow.Row("txtIdRequerimiento")
    '    '        Dim checBox As CheckBox = e.Item.FindControl("cbEstado")
    '    '        Dim pregunta As Integer
    '    '        If checBox.Checked Then
    '    '            pregunta = 1
    '    '        Else
    '    '            pregunta = 0
    '    '        End If
    '    '        boton.Attributes.Add("onClick", "pregunta('" & IdRequerimiento.Text & "', '" & pregunta.ToString & "'); return false;")
    '    '    End If
    '    'End If
    '    ''''''''''''''''''''''


    '    For i = 0 To e.Item.OwnerTableView.Items.Count - 1
    '        Dim boton As LinkButton = CType(e.Item.OwnerTableView.Items(i).FindControl("lbHabilitar"), LinkButton)
    '        Dim txtIdDetalleRequerimiento As TextBox = CType(e.Item.OwnerTableView.Items(i).FindControl("txtIdRequerimiento"), TextBox)
    '        Dim checBox As CheckBox = CType(e.Item.OwnerTableView.Items(i).FindControl("cbEstado"), CheckBox)
    '        Dim IdRequerimiento As TextBox = e.Item.FindControl("txtIdRequerimiento")
    '        'Dim checBox As CheckBox = e.Item.FindControl("cbEstado")
    '        Dim pregunta As String
    '        If checBox.Checked = True Then
    '            pregunta = "1"
    '        Else
    '            pregunta = "0"
    '        End If


    '        'If (CType(e.Item.OwnerTableView.Items(i).FindControl("Label2"), Label).Text = "Anulado") Then
    '        '    e.Item.OwnerTableView.Items.Item(i)("editar").Enabled = False
    '        '    e.Item.OwnerTableView.Items.Item(i)("eliminar").Enabled = False
    '        '    e.Item.OwnerTableView.Items.Item(i)("anular").Enabled = False
    '        '    e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
    '        'End If
    '    Next
    '    boton.Attributes.Add("onClick", "pregunta('" & IdRequerimiento.Text & "', '" & pregunta.ToString & "'); return false;")
    'End Sub
End Class