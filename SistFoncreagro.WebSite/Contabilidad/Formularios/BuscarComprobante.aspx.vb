Imports SistFoncreagro.BussinesLogic

Public Class BuscarComprobante
    Inherits System.Web.UI.Page
    Dim TransaccionBL As New TransaccionBL
    Dim EjercicioBL As New EjercicioBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1

        If Me.Page.IsPostBack = False Then
            Me.RadNumericTextBox1.Text = Date.Now.Year
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim anio As Int32
        Dim mes As Int32
        Dim subdiario As Int32
        Dim comprobante As String

        anio = Int32.Parse(Me.RadNumericTextBox1.Text)
        mes = Me.RadComboBox1.SelectedValue
        subdiario = Me.RadComboBox2.SelectedValue
        comprobante = Me.RadTextBox2.Text

        
            If Not (TransaccionBL.GetTRANSACCIONByAnioMesIdSubdiarioCodigo(anio, mes, subdiario, comprobante) Is Nothing) Then
                Dim radconfirmscript As String = "<script language='javascript'>function f(){radconfirm('¡Se Generará un Nuevo Comprobante!', confirmCallBackFn, 330, 100, null, 'Mensaje de Confirmación'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f); ;</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radconfirm", radconfirmscript)

            Else
                Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se encontró el Comprobante!</b> ', 330, 210,'Mensaje de Información'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)

            End If

    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        Dim anio As Int32
        Dim mes As Int32
        Dim subdiario As Int32
        Dim comprobante As String
        Dim IdTrans As Int32
        Dim IdTransa As Int32

        anio = Int32.Parse(Me.RadNumericTextBox1.Text)
        mes = Me.RadComboBox1.SelectedValue
        subdiario = Me.RadComboBox2.SelectedValue
        comprobante = Me.RadTextBox2.Text

        If e.Argument.StartsWith("Generar") Then
            Dim j() As String
            Dim valor As String
            j = Split(e.Argument, "|")

            valor = j(1)
            If valor = "true" Then
                IdTrans = TransaccionBL.GetTRANSACCIONByAnioMesIdSubdiarioCodigo(anio, mes, subdiario, comprobante).Idtransaccion
                If Me.RadioButtonList1.SelectedValue = "D" Then
                    IdTransa = TransaccionBL.GenerarTRANSACCIONDuplicada(IdTrans, Session("Fecha"), Session("IdUser"), Me.RadComboBox3.SelectedValue)
                Else
                    IdTransa = TransaccionBL.GenerarTRANSACCIONRevertida(IdTrans, Session("Fecha"), Session("IdUser"), Me.RadComboBox3.SelectedValue)
                End If
                Session("IdTransaccion") = IdTransa
                Session("Ventana") = "~\Contabilidad\Formularios\ListaDiario.aspx"

                Dim codigo As String
                codigo = TransaccionBL.GetTransaccionByIdTransaccion(IdTransa).IdSubDiario.ToString + "-" + TransaccionBL.GetTransaccionByIdTransaccion(IdTransa).Codigo

                'Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>Se ha generado el Comprobante: " + codigo.ToString + "</b> ', 330, 210,'Mensaje de Información',alertCallBackFn); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                'Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)

                Dim cadena_java As String = _
                               "<script language='javascript'>function f(){radalert('<b>Se ha generado el Comprobante: " + codigo.ToString + "</b> ', 330, 210,'Mensaje de Información',alertCallBackFn); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            End If
        ElseIf e.Argument.StartsWith("Abrir") Then
            Response.Redirect("~\Contabilidad\Formularios\ListaDiario.aspx")
            'Dim IdSubDiario As Int32
            'Dim Flag As String

            'IdSubDiario = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).IdSubDiario
            'Flag = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion")).Flag

            'If IdSubDiario = 2 Then
            '    Response.Redirect("~\Contabilidad\Formularios\FrmCompras.aspx")
            'ElseIf IdSubDiario = 3 Then
            '    Response.Redirect("~\Contabilidad\Formularios\FrmVentas.aspx")
            'ElseIf IdSubDiario = 4 Then
            '    Response.Redirect("~\Contabilidad\Formularios\FrmHonorarios.aspx")
            'ElseIf Flag = "I" Then
            '    Response.Redirect("~\Contabilidad\Formularios\FrmCajaIngresos.aspx?Flag=I")
            'ElseIf Flag = "E" Then
            '    Response.Redirect("~\Contabilidad\Formularios\FrmCajaEgresos.aspx?Flag=E")
            'Else
            '    Response.Redirect("~\Contabilidad\Formularios\FrmDiario.aspx?Flag=N")
            'End If
        End If
    End Sub
End Class