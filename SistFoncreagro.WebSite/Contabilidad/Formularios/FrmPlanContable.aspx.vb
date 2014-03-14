Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmPlanContable
    Inherits System.Web.UI.Page
    Dim IdPlan As String
    Dim PlanContableBL As New PlanContableBL
    Dim _PlanContable As PlanContable
    Dim _PlanContable1 As PlanContable
    Dim PlanContable As New PlanContable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdPlan = Request.QueryString("IdPlan")
        If Page.IsPostBack = False Then
            Me.DropDownList9.SelectedValue = 1
            'para recuperar datos
            If IdPlan > 0 Then
                Me.TextBox1.Enabled = False
                _PlanContable = PlanContableBL.GetPLANCONTABLEByIdPlan(IdPlan)
                Me.TextBox1.Text = _PlanContable.Codigo
                Me.TextBox2.Text = _PlanContable.Nombre
                If _PlanContable.IdTipoCtaCont <> 0 Then
                    Me.DropDownList1.SelectedValue = _PlanContable.IdTipoCtaCont
                End If

                Me.RadioButtonList1.SelectedValue = _PlanContable.Nivel
                If _PlanContable.IdEstFinanciero <> 0 Then
                    Me.DropDownList6.SelectedValue = _PlanContable.IdEstFinanciero
                End If

                'radcombobox1
                If _PlanContable.CtaPrincipal <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_PlanContable.CtaPrincipal)
                    Me.RadComboBox1.DataSourceID = "odsPlanContable1"
                    Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox1.DataBind()
                    Me.RadComboBox1.SelectedValue = _PlanContable.CtaPrincipal
                End If

                'radcombobox2
                If _PlanContable.CtaOpcional <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_PlanContable.CtaOpcional)
                    Me.RadComboBox2.DataSourceID = "odsPlanContable2"
                    Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox2.DataBind()
                    Me.RadComboBox2.SelectedValue = _PlanContable.CtaOpcional
                End If

                If _PlanContable.IdTipoCancelacion <> 0 Then
                    Me.DropDownList2.SelectedValue = _PlanContable.IdTipoCancelacion
                End If

                If _PlanContable.RequiereCodAux <> "" Then
                    Me.DropDownList3.SelectedValue = _PlanContable.RequiereCodAux
                End If

                If _PlanContable.RequiereRegistro <> "" Then
                    Me.DropDownList4.SelectedValue = _PlanContable.RequiereRegistro
                End If

                If _PlanContable.RequiereCCosto <> "" Then
                    Me.DropDownList5.SelectedValue = _PlanContable.RequiereCCosto
                End If

                If _PlanContable.IdTipoAjuste <> 0 Then
                    Me.DropDownList7.SelectedValue = _PlanContable.IdTipoAjuste
                End If

                If _PlanContable.IdAplTipoCambio <> 0 Then
                    Me.DropDownList8.SelectedValue = _PlanContable.IdAplTipoCambio
                End If

                'radcombobox3
                If _PlanContable.CtaGanancia <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_PlanContable.CtaGanancia)
                    Me.RadComboBox3.DataSourceID = "odsPlanContable3"
                    Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox3.DataBind()
                    Me.RadComboBox3.SelectedValue = _PlanContable.CtaGanancia
                End If

                'radcombobox4
                If _PlanContable.CtaPerdida <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_PlanContable.CtaPerdida)
                    Me.RadComboBox4.DataSourceID = "odsPlanContable4"
                    Me.odsPlanContable4.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox4.DataBind()
                    Me.RadComboBox4.SelectedValue = _PlanContable.CtaPerdida
                End If

                If _PlanContable.GenerarDestino = "S" Then
                    Me.CheckBox1.Checked = True
                    Me.RadComboBox5.Enabled = True
                    Me.RadComboBox6.Enabled = True
                Else
                    Me.CheckBox1.Checked = False
                    Me.RadComboBox5.Enabled = False
                    Me.RadComboBox6.Enabled = False
                End If

                'radcombobox5
                If _PlanContable.CtaCargo <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_PlanContable.CtaCargo)
                    Me.RadComboBox5.DataSourceID = "odsPlanContable5"
                    Me.odsPlanContable5.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox5.DataBind()
                    Me.RadComboBox5.SelectedValue = _PlanContable.CtaCargo
                End If

                'radcombobox6
                If _PlanContable.CtaAbono <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_PlanContable.CtaAbono)
                    Me.RadComboBox6.DataSourceID = "odsPlanContable6"
                    Me.odsPlanContable6.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox6.DataBind()
                    Me.RadComboBox6.SelectedValue = _PlanContable.CtaAbono
                End If

                If _PlanContable.IdMoneda.HasValue Then
                    Me.DropDownList9.SelectedValue = _PlanContable.IdMoneda
                Else
                    Me.DropDownList9.SelectedValue = 0
                End If
            End If


        End If

    End Sub

    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox1.DataSourceID = "odsPlanContable1"
            Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox1.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox2_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox2.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox2_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox2.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox2.DataSourceID = "odsPlanContable2"
            Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox2.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox3_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox3.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox3_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox3.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox3.DataSourceID = "odsPlanContable3"
            Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox3.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox4_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox4.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox4_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox4.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox4.DataSourceID = "odsPlanContable4"
            Me.odsPlanContable4.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox4.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox5_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox5.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox5_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox5.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox5.DataSourceID = "odsPlanContable5"
            Me.odsPlanContable5.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox5.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox6_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox6.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox6_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox6.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox6.DataSourceID = "odsPlanContable6"
            Me.odsPlanContable6.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox6.DataBind()
        End If
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmPlanContable.aspx")
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        If IdPlan > 0 Then
            'grabamos la cuenta contable
            PlanContable.Codigo = Me.TextBox1.Text
            If Me.RadComboBox6.SelectedValue.Length > 0 Then
                PlanContable.CtaAbono = Me.RadComboBox6.SelectedValue
            End If
            If Me.RadComboBox5.SelectedValue.Length > 0 Then
                PlanContable.CtaCargo = Me.RadComboBox5.SelectedValue
            End If
            If Me.RadComboBox3.SelectedValue.Length > 0 Then
                PlanContable.CtaGanancia = Me.RadComboBox3.SelectedValue
            End If
            If Me.RadComboBox2.SelectedValue.Length > 0 Then
                PlanContable.CtaOpcional = Me.RadComboBox2.SelectedValue
            End If
            If Me.RadComboBox4.SelectedValue.Length > 0 Then
                PlanContable.CtaPerdida = Me.RadComboBox4.SelectedValue
            End If
            If Me.RadComboBox1.SelectedValue.Length > 0 Then
                PlanContable.CtaPrincipal = Me.RadComboBox1.SelectedValue
            End If
            If Me.DropDownList8.SelectedValue.Length > 0 Then
                PlanContable.IdAplTipoCambio = Me.DropDownList8.SelectedValue
            End If
            If Me.DropDownList6.SelectedValue.Length > 0 Then
                PlanContable.IdEstFinanciero = Me.DropDownList6.SelectedValue
            End If
            If Me.DropDownList7.SelectedValue.Length > 0 Then
                PlanContable.IdTipoAjuste = Me.DropDownList7.SelectedValue
            End If
            If Me.DropDownList2.SelectedValue.Length > 0 Then
                PlanContable.IdTipoCancelacion = Me.DropDownList2.SelectedValue
            End If
            If Me.DropDownList1.SelectedValue.Length > 0 Then
                PlanContable.IdTipoCtaCont = Me.DropDownList1.SelectedValue
            End If

            If Me.CheckBox1.Checked Then
                PlanContable.GenerarDestino = "S"
            Else
                PlanContable.GenerarDestino = "N"
            End If
            If Me.DropDownList9.SelectedValue = 0 Then
                PlanContable.IdMoneda.Equals(DBNull.Value)
            Else
                PlanContable.IdMoneda = Me.DropDownList9.SelectedValue
            End If
            PlanContable.IdPlan = IdPlan
            PlanContable.Nivel = Me.RadioButtonList1.SelectedValue
            PlanContable.Nombre = Me.TextBox2.Text
            PlanContable.RequiereCCosto = Me.DropDownList5.SelectedValue
            PlanContable.RequiereCodAux = Me.DropDownList3.SelectedValue
            PlanContable.RequiereRegistro = Me.DropDownList4.SelectedValue
            IdPlan = PlanContableBL.SavePLANCONTABLE(PlanContable)

            Response.Redirect("FrmPlanContable.aspx?IdPlan=" + IdPlan)
        Else
            'para verificar si ya existe la cuenta contable
            Dim cod As Int32
            cod = PlanContableBL.VerifyExistePLANCONTABLE(Me.TextBox1.Text)
            If cod > 0 Then
                Dim cadena_java As String = _
                                 "<script language='javascript'>function f(){radalert('<b>¡La Cuenta Contable ya existe, No se puede Grabar!</b> ', 330, 210,'¡Alerta!'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            Else
                'grabamos la cuenta contable
                PlanContable.Codigo = Me.TextBox1.Text
                If Me.RadComboBox6.SelectedValue.Length > 0 Then
                    PlanContable.CtaAbono = Me.RadComboBox6.SelectedValue
                End If
                If Me.RadComboBox5.SelectedValue.Length > 0 Then
                    PlanContable.CtaCargo = Me.RadComboBox5.SelectedValue
                End If
                If Me.RadComboBox3.SelectedValue.Length > 0 Then
                    PlanContable.CtaGanancia = Me.RadComboBox3.SelectedValue
                End If
                If Me.RadComboBox2.SelectedValue.Length > 0 Then
                    PlanContable.CtaOpcional = Me.RadComboBox2.SelectedValue
                End If
                If Me.RadComboBox4.SelectedValue.Length > 0 Then
                    PlanContable.CtaPerdida = Me.RadComboBox4.SelectedValue
                End If
                If Me.RadComboBox1.SelectedValue.Length > 0 Then
                    PlanContable.CtaPrincipal = Me.RadComboBox1.SelectedValue
                End If
                If Me.DropDownList8.SelectedValue.Length > 0 Then
                    PlanContable.IdAplTipoCambio = Me.DropDownList8.SelectedValue
                End If
                If Me.DropDownList6.SelectedValue.Length > 0 Then
                    PlanContable.IdEstFinanciero = Me.DropDownList6.SelectedValue
                End If
                If Me.DropDownList7.SelectedValue.Length > 0 Then
                    PlanContable.IdTipoAjuste = Me.DropDownList7.SelectedValue
                End If
                If Me.DropDownList2.SelectedValue.Length > 0 Then
                    PlanContable.IdTipoCancelacion = Me.DropDownList2.SelectedValue
                End If
                If Me.DropDownList1.SelectedValue.Length > 0 Then
                    PlanContable.IdTipoCtaCont = Me.DropDownList1.SelectedValue
                End If

                If Me.CheckBox1.Checked Then
                    PlanContable.GenerarDestino = "S"
                Else
                    PlanContable.GenerarDestino = "N"
                End If
                If Me.DropDownList9.SelectedValue = 0 Then
                    PlanContable.IdMoneda.Equals(DBNull.Value)
                Else
                    PlanContable.IdMoneda = Me.DropDownList9.SelectedValue
                End If
                PlanContable.IdPlan = IdPlan
                PlanContable.Nivel = Me.RadioButtonList1.SelectedValue
                PlanContable.Nombre = Me.TextBox2.Text
                PlanContable.RequiereCCosto = Me.DropDownList5.SelectedValue
                PlanContable.RequiereCodAux = Me.DropDownList3.SelectedValue
                PlanContable.RequiereRegistro = Me.DropDownList4.SelectedValue
                IdPlan = PlanContableBL.SavePLANCONTABLE(PlanContable)

                Response.Redirect("FrmPlanContable.aspx?IdPlan=" + IdPlan)
            End If
        End If
        

       
    End Sub

    Protected Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Me.RadComboBox5.Enabled = True
            Me.RadComboBox6.Enabled = True
        Else
            Me.RadComboBox5.Enabled = False
            Me.RadComboBox6.Enabled = False
        End If
    End Sub

End Class