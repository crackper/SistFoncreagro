Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmDocumentoConta
    Inherits System.Web.UI.Page
    Dim IdDocumentoCont As String
    Dim _DocumentoConta As DocumentoContabilizado
    Dim _DocumentoConta1 As New DocumentoContabilizado
    Dim DocumentoContaBL As New DocumentoContabilizadoBL
    Dim _PlanContable1 As PlanContable
    Dim PlanContableBL As New PlanContableBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdDocumentoCont = Request.QueryString("IdDocumentoCont")
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1
        Me.RadComboBox5.Filter = 1
        Me.RadComboBox6.Filter = 1

        'para agregarle un evento al TextBox2
        Me.TextBox2.Attributes.Add("OnBlur", "Validar();")

        If Page.IsPostBack = False Then
            'para recuperar datos
            If IdDocumentoCont > 0 Then
                _DocumentoConta = DocumentoContaBL.GetDOCUMENTOCONTABILIZADOByIdDocConta(IdDocumentoCont)

                'radcombobox1
                If _DocumentoConta.CtaIgv <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_DocumentoConta.CtaIgv)
                    Me.RadComboBox1.DataSourceID = "odsPlanContable1"
                    Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox1.DataBind()
                    Me.RadComboBox1.SelectedValue = _DocumentoConta.CtaIgv
                End If

                'radcombobox2
                If _DocumentoConta.CtaDebe <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_DocumentoConta.CtaDebe)
                    Me.RadComboBox2.DataSourceID = "odsPlanContable2"
                    Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox2.DataBind()
                    Me.RadComboBox2.SelectedValue = _DocumentoConta.CtaDebe
                End If

                'radcombobox3
                If _DocumentoConta.CtaHaber <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_DocumentoConta.CtaHaber)
                    Me.RadComboBox3.DataSourceID = "odsPlanContable3"
                    Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox3.DataBind()
                    Me.RadComboBox3.SelectedValue = _DocumentoConta.CtaHaber
                End If

                'radcombobox4
                If _DocumentoConta.CtaDetraccion <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_DocumentoConta.CtaDetraccion)
                    Me.RadComboBox4.DataSourceID = "odsPlanContable4"
                    Me.odsPlanContable4.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox4.DataBind()
                    Me.RadComboBox4.SelectedValue = _DocumentoConta.CtaDetraccion
                End If

                'radcombobox5
                If _DocumentoConta.CtaRetencion <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_DocumentoConta.CtaRetencion)
                    Me.RadComboBox5.DataSourceID = "odsPlanContable5"
                    Me.odsPlanContable5.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox5.DataBind()
                    Me.RadComboBox5.SelectedValue = _DocumentoConta.CtaRetencion
                End If

                'radcombobox7
                If _DocumentoConta.CtaIngresosIvap <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_DocumentoConta.CtaIngresosIvap)
                    Me.RadComboBox7.DataSourceID = "odsPlanContable7"
                    Me.odsPlanContable7.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox7.DataBind()
                    Me.RadComboBox7.SelectedValue = _DocumentoConta.CtaIngresosIvap
                End If

                'radcombobox8
                If _DocumentoConta.CtagastosIvap <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_DocumentoConta.CtagastosIvap)
                    Me.RadComboBox8.DataSourceID = "odsPlanContable8"
                    Me.odsPlanContable8.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox8.DataBind()
                    Me.RadComboBox8.SelectedValue = _DocumentoConta.CtagastosIvap
                End If

                Me.RadComboBox6.SelectedValue = _DocumentoConta.IdTipoDocumento
                Me.TextBox1.Text = _DocumentoConta.Descripcion
                Me.TextBox2.Text = _DocumentoConta.Codigo
                Me.DropDownList1.SelectedValue = _DocumentoConta.IdMoneda
                Me.DropDownList2.SelectedValue = _DocumentoConta.AfectoIvap

                'para q los datos sean de solo lectura
                Me.TextBox2.Enabled = False
                Me.DropDownList1.Enabled = False
                Me.RadComboBox6.Enabled = False
            End If
        End If
    End Sub
    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()

    End Sub

    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 2 Then
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
        If e.Text.Length > 2 Then
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
    Protected Sub RadComboBox7_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox7.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()

    End Sub

    Protected Sub RadComboBox7_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox7.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox7.DataSourceID = "odsPlanContable7"
            Me.odsPlanContable7.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox7.DataBind()
        End If
    End Sub
    Protected Sub RadComboBox8_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox8.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()

    End Sub

    Protected Sub RadComboBox8_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox8.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox8.DataSourceID = "odsPlanContable8"
            Me.odsPlanContable8.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox8.DataBind()
        End If
    End Sub
    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmDocumentoConta.aspx")
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        _DocumentoConta1.AfectoIvap = Me.DropDownList2.SelectedValue
        _DocumentoConta1.Codigo = Me.TextBox2.Text
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            _DocumentoConta1.CtaDebe = Me.RadComboBox2.SelectedValue
        End If
        If Me.RadComboBox4.SelectedValue.Length > 0 Then
            _DocumentoConta1.CtaDetraccion = Me.RadComboBox4.SelectedValue
        End If
        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            _DocumentoConta1.CtaHaber = Me.RadComboBox3.SelectedValue
        End If
        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            _DocumentoConta1.CtaIgv = Me.RadComboBox1.SelectedValue
        End If
        If Me.RadComboBox5.SelectedValue.Length > 0 Then
            _DocumentoConta1.CtaRetencion = Me.RadComboBox5.SelectedValue
        End If
        If Me.RadComboBox7.SelectedValue.Length > 0 Then
            _DocumentoConta1.CtaIngresosIvap = Me.RadComboBox7.SelectedValue
        End If
        If Me.RadComboBox8.SelectedValue.Length > 0 Then
            _DocumentoConta1.CtagastosIvap = Me.RadComboBox8.SelectedValue
        End If
       
        _DocumentoConta1.Descripcion = Me.TextBox1.Text
        _DocumentoConta1.IdDocumentoCont = IdDocumentoCont
        _DocumentoConta1.IdMoneda = Me.DropDownList1.SelectedValue
        _DocumentoConta1.IdTipoDocumento = Me.RadComboBox6.SelectedValue
        IdDocumentoCont = DocumentoContaBL.SaveDOCUMENTOCONTABILIZADO(_DocumentoConta1)
        Response.Redirect("FrmDocumentoConta.aspx?IdDocumentoCont=" + IdDocumentoCont.ToString)
    End Sub

  
    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        If Me.DropDownList2.SelectedValue = "S" Then
            Me.RadComboBox7.Enabled = True
            Me.RadComboBox8.Enabled = True
        Else
            Me.RadComboBox7.Enabled = False
            Me.RadComboBox8.Enabled = False
        End If
    End Sub
End Class