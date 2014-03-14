Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmCuentasCierre
    Inherits System.Web.UI.Page
    Dim IdCierre As String
    Dim CierreContableBL As New CierreContableBL
    Dim _CierreContable As CierreContable
    Dim CierreContable As New CierreContable
    Dim _PlanContable1 As PlanContable
    Dim PlanContableBL As New PlanContableBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdCierre = Request.QueryString("IdCierre")
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1
        Me.RadComboBox5.Filter = 1
        Me.RadComboBox6.Filter = 1
        Me.RadComboBox7.Filter = 1
        Me.RadComboBox8.Filter = 1
        Me.RadComboBox9.Filter = 1
        Me.RadComboBox10.Filter = 1
        Me.RadComboBox11.Filter = 1

        If Page.IsPostBack = False Then
            'para recuperar datos
            If IdCierre > 0 Then
                _CierreContable = CierreContableBL.GetCIERRECONTABLEByIdCierre(IdCierre)

                Me.TextBox1.Text = _CierreContable.Descripcion

                'radcombobox1
                If _CierreContable.Cuenta1 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta1)
                    Me.RadComboBox1.DataSourceID = "odsPlanContable1"
                    Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox1.DataBind()
                    Me.RadComboBox1.SelectedValue = _CierreContable.Cuenta1
                End If

                'radcombobox2
                If _CierreContable.Cuenta2 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta2)
                    Me.RadComboBox2.DataSourceID = "odsPlanContable2"
                    Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox2.DataBind()
                    Me.RadComboBox2.SelectedValue = _CierreContable.Cuenta2
                End If

                'radcombobox3
                If _CierreContable.Cuenta3 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta3)
                    Me.RadComboBox3.DataSourceID = "odsPlanContable3"
                    Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox3.DataBind()
                    Me.RadComboBox3.SelectedValue = _CierreContable.Cuenta3
                End If

                'radcombobox4
                If _CierreContable.Cuenta4 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta4)
                    Me.RadComboBox4.DataSourceID = "odsPlanContable4"
                    Me.odsPlanContable4.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox4.DataBind()
                    Me.RadComboBox4.SelectedValue = _CierreContable.Cuenta4
                End If

                'radcombobox5
                If _CierreContable.Cuenta5 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta5)
                    Me.RadComboBox5.DataSourceID = "odsPlanContable5"
                    Me.odsPlanContable5.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox5.DataBind()
                    Me.RadComboBox5.SelectedValue = _CierreContable.Cuenta5
                End If

                'radcombobox6
                If _CierreContable.Cuenta6 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta6)
                    Me.RadComboBox6.DataSourceID = "odsPlanContable6"
                    Me.odsPlanContable6.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox6.DataBind()
                    Me.RadComboBox6.SelectedValue = _CierreContable.Cuenta6
                End If

                'radcombobox7
                If _CierreContable.Cuenta7 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta7)
                    Me.RadComboBox7.DataSourceID = "odsPlanContable7"
                    Me.odsPlanContable7.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox7.DataBind()
                    Me.RadComboBox7.SelectedValue = _CierreContable.Cuenta7
                End If

                'radcombobox8
                If _CierreContable.Cuenta8 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta8)
                    Me.RadComboBox8.DataSourceID = "odsPlanContable8"
                    Me.odsPlanContable8.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox8.DataBind()
                    Me.RadComboBox8.SelectedValue = _CierreContable.Cuenta8
                End If

                'radcombobox9
                If _CierreContable.Cuenta9 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta9)
                    Me.RadComboBox9.DataSourceID = "odsPlanContable9"
                    Me.odsPlanContable9.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox9.DataBind()
                    Me.RadComboBox9.SelectedValue = _CierreContable.Cuenta9
                End If

                'radcombobox10
                If _CierreContable.Cuenta10 <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.Cuenta10)
                    Me.RadComboBox10.DataSourceID = "odsPlanContable10"
                    Me.odsPlanContable10.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox10.DataBind()
                    Me.RadComboBox10.SelectedValue = _CierreContable.Cuenta10
                End If

                'radcombobox 11
                If _CierreContable.CuentaReceptora <> 0 Then
                    _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(_CierreContable.CuentaReceptora)
                    Me.RadComboBox11.DataSourceID = "odsPlanContable11"
                    Me.odsPlanContable11.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                    Me.RadComboBox11.DataBind()
                    Me.RadComboBox11.SelectedValue = _CierreContable.CuentaReceptora
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmCuentasCierre.aspx")
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        'grabamos
        CierreContable.Cuenta1 = Me.RadComboBox1.SelectedValue
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            CierreContable.Cuenta2 = Me.RadComboBox2.SelectedValue
        Else
            CierreContable.Cuenta2.Equals(DBNull.Value)
        End If
        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            CierreContable.Cuenta3 = Me.RadComboBox3.SelectedValue
        Else
            CierreContable.Cuenta3.Equals(DBNull.Value)
        End If
        If Me.RadComboBox4.SelectedValue.Length > 0 Then
            CierreContable.Cuenta4 = Me.RadComboBox4.SelectedValue
        Else
            CierreContable.Cuenta4.Equals(DBNull.Value)
        End If
        If Me.RadComboBox5.SelectedValue.Length > 0 Then
            CierreContable.Cuenta5 = Me.RadComboBox5.SelectedValue
        Else
            CierreContable.Cuenta5.Equals(DBNull.Value)
        End If
        If Me.RadComboBox6.SelectedValue.Length > 0 Then
            CierreContable.Cuenta6 = Me.RadComboBox6.SelectedValue
        Else
            CierreContable.Cuenta6.Equals(DBNull.Value)
        End If
        If Me.RadComboBox7.SelectedValue.Length > 0 Then
            CierreContable.Cuenta7 = Me.RadComboBox7.SelectedValue
        Else
            CierreContable.Cuenta7.Equals(DBNull.Value)
        End If
        If Me.RadComboBox8.SelectedValue.Length > 0 Then
            CierreContable.Cuenta8 = Me.RadComboBox8.SelectedValue
        Else
            CierreContable.Cuenta8.Equals(DBNull.Value)
        End If
        If Me.RadComboBox9.SelectedValue.Length > 0 Then
            CierreContable.Cuenta9 = Me.RadComboBox9.SelectedValue
        Else
            CierreContable.Cuenta9.Equals(DBNull.Value)
        End If
        If Me.RadComboBox10.SelectedValue.Length > 0 Then
            CierreContable.Cuenta10 = Me.RadComboBox10.SelectedValue
        Else
            CierreContable.Cuenta10.Equals(DBNull.Value)
        End If
        CierreContable.IdCierre = IdCierre
        CierreContable.CuentaReceptora = Me.RadComboBox11.SelectedValue
        CierreContable.Descripcion = Me.TextBox1.Text
        IdCierre = CierreContableBL.SaveCIERRECONTABLE(CierreContable)
        Response.Redirect("FrmCuentasCierre.aspx?IdCierre=" + IdCierre)
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
        If e.Text.Length > 1 Then
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
        If e.Text.Length > 1 Then
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
        If e.Text.Length > 1 Then
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
        If e.Text.Length > 1 Then
            Me.RadComboBox6.DataSourceID = "odsPlanContable6"
            Me.odsPlanContable6.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox6.DataBind()
        End If
    End Sub
    Protected Sub RadComboBox7_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox7.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox7_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox7.ItemsRequested
        If e.Text.Length > 1 Then
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
        If e.Text.Length > 1 Then
            Me.RadComboBox8.DataSourceID = "odsPlanContable8"
            Me.odsPlanContable8.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox8.DataBind()
        End If
    End Sub
    Protected Sub RadComboBox9_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox9.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox9_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox9.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox9.DataSourceID = "odsPlanContable9"
            Me.odsPlanContable9.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox9.DataBind()
        End If
    End Sub
    Protected Sub RadComboBox10_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox10.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox10_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox10.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox10.DataSourceID = "odsPlanContable10"
            Me.odsPlanContable10.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox10.DataBind()
        End If
    End Sub
    Protected Sub RadComboBox11_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox11.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox11_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox11.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox11.DataSourceID = "odsPlanContable11"
            Me.odsPlanContable11.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox11.DataBind()
        End If
    End Sub
End Class