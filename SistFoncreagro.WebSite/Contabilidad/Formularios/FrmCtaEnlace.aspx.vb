Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmCtaEnlace
    Inherits System.Web.UI.Page
    Dim IdCtaEnlace As String
    Dim CtaEnlaceBL As New CuentaEnlaceBL
    Dim _CtaEnlace As CuentaEnlace
    Dim CtaEnlace As New CuentaEnlace
    Dim _PlanContable1 As PlanContable
    Dim PlanContableBL As New PlanContableBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdCtaEnlace = Request.QueryString("IdCtaEnlace")
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1
        Me.RadComboBox5.Filter = 1

        If Page.IsPostBack = False Then
            'para recuperar datos
            If IdCtaEnlace > 0 Then
                _CtaEnlace = CtaEnlaceBL.GetCUENTAENLACEByIdCtaEnlace(IdCtaEnlace)

                'radcombobox1
                If _CtaEnlace.CtaOperacion <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByCodigo(_CtaEnlace.CtaOperacion)
                    Me.RadComboBox1.DataSourceID = "odsPlanContable1"
                    Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox1.DataBind()
                    Me.RadComboBox1.SelectedValue = _CtaEnlace.CtaOperacion
                End If

                'radcombobox2
                If _CtaEnlace.CtaPagar <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByCodigo(_CtaEnlace.CtaPagar)
                    Me.RadComboBox2.DataSourceID = "odsPlanContable2"
                    Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox2.DataBind()
                    Me.RadComboBox2.SelectedValue = _CtaEnlace.CtaPagar
                End If

                'radcombobox3
                If _CtaEnlace.CtaCobrar <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByCodigo(_CtaEnlace.CtaCobrar)
                    Me.RadComboBox3.DataSourceID = "odsPlanContable3"
                    Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox3.DataBind()
                    Me.RadComboBox3.SelectedValue = _CtaEnlace.CtaCobrar
                End If

                'radcombobox 4
                Me.RadComboBox4.SelectedValue = _CtaEnlace.Origen

                'radcombobox 5
                Me.RadComboBox5.SelectedValue = _CtaEnlace.Destino

                Me.DropDownList1.SelectedValue = _CtaEnlace.Tipo
                'para q los datos sean de solo lectura
                Me.RadComboBox1.Enabled = False
                Me.RadComboBox2.Enabled = False
                Me.RadComboBox3.Enabled = False
                Me.RadComboBox4.Enabled = False
                Me.RadComboBox5.Enabled = False
                Me.DropDownList1.Enabled = False
            End If
        End If
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmCtaEnlace.aspx")
    End Sub

    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Codigo.ToString()
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
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Codigo.ToString()
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
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Codigo.ToString()
    End Sub

    Protected Sub RadComboBox3_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox3.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox3.DataSourceID = "odsPlanContable3"
            Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox3.DataBind()
        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        'para verificar si ya existe la cuenta 
        Dim cod As Int32
        cod = CtaEnlaceBL.VerifyExisteCUENTAENLACE(Me.RadComboBox4.SelectedValue, Me.RadComboBox5.SelectedValue, Me.RadComboBox1.SelectedValue, Me.RadComboBox2.SelectedValue, Me.RadComboBox3.SelectedValue, Me.DropDownList1.SelectedValue)
        If cod > 0 Then
            Dim cadena_java As String = _
                             "<script language='javascript'>function f(){radalert('<b>¡La Cuenta de Enlace ya existe, No se puede Grabar!</b> ', 330, 210,'¡Alerta!'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
        Else
            'grabamos
            CtaEnlace.CtaCobrar = Me.RadComboBox3.SelectedValue
            CtaEnlace.CtaOperacion = Me.RadComboBox1.SelectedValue
            CtaEnlace.CtaPagar = Me.RadComboBox2.SelectedValue
            CtaEnlace.Destino = Me.RadComboBox5.SelectedValue
            CtaEnlace.IdCtaEnlace = IdCtaEnlace
            CtaEnlace.Origen = Me.RadComboBox4.SelectedValue
            CtaEnlace.Tipo = Me.DropDownList1.SelectedValue
            IdCtaEnlace = CtaEnlaceBL.SaveCUENTAENLACE(CtaEnlace)
            Response.Redirect("FrmCtaEnlace.aspx?IdCtaEnlace=" + IdCtaEnlace)
        End If
    End Sub
End Class