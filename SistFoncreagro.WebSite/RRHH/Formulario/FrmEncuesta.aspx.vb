Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmEncuesta
    Inherits System.Web.UI.Page
    Dim IdEncuestallena As String
    Dim EncuestaLLenaBl As New EncuestaLlenaBL
    Dim _EncuestaLlena As New EncuestaLlena
    Dim RespuestaBl As New RespuestaBL
    Dim _Respuesta As New Respuesta
    Dim EncuestaLlena As EncuestaLlena
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        IdEncuestallena = Request.QueryString("IdEncuestallena")

        If Page.IsPostBack = False Then
            If IdEncuestallena > 0 Then
                'para recuperar datos de transaccion
                EncuestaLlena = EncuestaLLenaBl.GetENCUESTALLENAByIdEncuesta(IdEncuestallena)
                If EncuestaLlena.IdProyecto > 0 Then
                    Me.RadComboBox1.SelectedValue = EncuestaLlena.IdProyecto
                End If
                If EncuestaLlena.Candidato > 0 Then
                    Me.RadComboBox2.SelectedValue = EncuestaLlena.Candidato
                End If
            End If
        End If

    End Sub

    Protected Sub RadComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            _EncuestaLlena.Candidato = Me.RadComboBox2.SelectedValue
        Else
            _EncuestaLlena.Candidato.Equals(DBNull.Value)
        End If
        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            _EncuestaLlena.IdProyecto = Me.RadComboBox1.SelectedValue
        Else
            _EncuestaLlena.IdProyecto.Equals(DBNull.Value)
        End If

        _EncuestaLlena.Fecha = Date.Now
        _EncuestaLlena.IdEncuestaLlena = IdEncuestallena
        EncuestaLLenaBl.SaveENCUESTALLENA(_EncuestaLlena)
        Me.RadComboBox2.DataBind()
    End Sub
    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        For i = 0 To Me.RadGrid1.Items.Count - 1
            If Me.RadGrid1.Items.Item(i)("HabilitarComentario").Text = "True" Then
                CType(e.Item.OwnerTableView.Items(i).FindControl("TextBox2"), TextBox).Visible = True
            Else
                CType(e.Item.OwnerTableView.Items(i).FindControl("TextBox2"), TextBox).Visible = False
            End If
        Next
    End Sub

    Protected Sub RadComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox2.SelectedIndexChanged
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            _EncuestaLlena.Candidato = Me.RadComboBox2.SelectedValue
        Else
            _EncuestaLlena.Candidato.Equals(DBNull.Value)
        End If
        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            _EncuestaLlena.IdProyecto = Me.RadComboBox1.SelectedValue
        Else
            _EncuestaLlena.IdProyecto.Equals(DBNull.Value)
        End If

        _EncuestaLlena.Fecha = Date.Now
        _EncuestaLlena.IdEncuestaLlena = IdEncuestallena
        EncuestaLLenaBl.SaveENCUESTALLENA(_EncuestaLlena)
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "Grabar" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                If CType(Me.RadGrid1.Items.Item(i).FindControl("RadNumericTextBox1"), RadNumericTextBox).Text = "" Then
                    _Respuesta.Respuesta.Equals(DBNull.Value)
                Else
                    _Respuesta.Respuesta = Integer.Parse(CType(Me.RadGrid1.Items.Item(i).FindControl("RadNumericTextBox1"), RadNumericTextBox).Text)
                End If
                _Respuesta.Comentario = CType(Me.RadGrid1.Items.Item(i).FindControl("TextBox2"), TextBox).Text
                _Respuesta.IdRespuesta = Me.RadGrid1.Items.Item(i)("IdRespuesta").Text
                _Respuesta.IdEncuestaLlena = IdEncuestallena
                RespuestaBl.UpdateRESPUESTA(_Respuesta)
            Next
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        EncuestaLLenaBl.UpdateENCUESTALLENA(IdEncuestallena)
        Dim cadena_java As String = _
                       "<script language='javascript'>function f(){radalert('<b>¡Gracias por su Apoyo!</b>', 330, 100,'Mensaje de Información',alertCallBackFn); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
    End Sub

End Class