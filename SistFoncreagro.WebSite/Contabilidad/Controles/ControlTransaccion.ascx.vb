Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class LineaCompras_Control
    Inherits System.Web.UI.UserControl

    Private _dataItem As Object = Nothing
    Dim TransaccionBL As New TransaccionBL
    Dim _transaccion As Transaccion
    Dim IdTransaccion As String
    Dim PlanContableBl As New PlanContableBL
    Dim _PlanContable As PlanContable

    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property

    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding

        ' IdTransaccion = Request.QueryString("Idtransaccion")
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1

        'PARA SACAR EL ID DE PROYECTO
        _transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
        Me.TextBox1.Text = _transaccion.IdProyecto
        'If _transaccion.IdSubDiario = 3 Then 'ventas
        '    Me.RequiredFieldValidator2.Enabled = False
        'Else
        '    Me.RequiredFieldValidator2.Enabled = True

        'End If

        If TypeOf DataItem Is GridInsertionObject Then

            Me.TextBox2.Text = _transaccion.Glosa

            If _transaccion.IdSubDiario = 2 Then
                If _transaccion.IdTipoDocRef > 0 Then
                    Me.RadNumericTextBox3.Text = TransaccionBL.GetSaldoTotalTransaccion(Session("IdTransaccion"))
                    'If _transaccion.IdTipoBaseImp = 1 Then
                    '    Me.RadNumericTextBox3.Text = _transaccion.BaseImponible
                    'Else
                    '    Me.RadNumericTextBox3.Text = _transaccion.Total
                    'End If
                Else
                    Me.RadNumericTextBox2.Text = TransaccionBL.GetSaldoTotalTransaccion(Session("IdTransaccion"))
                    'If _transaccion.IdTipoBaseImp = 1 Then
                    '    Me.RadNumericTextBox2.Text = _transaccion.BaseImponible
                    'Else
                    '    Me.RadNumericTextBox2.Text = _transaccion.Total
                    'End If
                End If
                
            ElseIf _transaccion.IdSubDiario = 3 Then
                If _transaccion.AfectoIgv = "S" Then
                    Me.RadNumericTextBox3.Text = _transaccion.BaseImponible
                Else
                    Me.RadNumericTextBox3.Text = _transaccion.BaseInafecto
                End If
            ElseIf _transaccion.IdSubDiario = 4 Then
                Me.RadNumericTextBox2.Text = _transaccion.BaseImponible

            End If

        Else
            _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlan"))
            Me.RadComboBox1.DataSourceID = "odsPlanContable"
            Me.odsPlanContable.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
            Me.RadComboBox1.DataBind()
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdPlan")

            If Not (IsDBNull(DataBinder.Eval(DataItem, "IdCCosto"))) Then
                Me.RadComboBox2.SelectedValue = DataBinder.Eval(DataItem, "IdCCosto")

            End If

            Me.RadNumericTextBox2.Text = DataBinder.Eval(DataItem, "MontoCargo")
            Me.RadNumericTextBox3.Text = DataBinder.Eval(DataItem, "MontoAbono")
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Glosa")

        End If
    End Sub

    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()

    End Sub

    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        _transaccion = TransaccionBL.GetTransaccionByIdTransaccion(Session("IdTransaccion"))
        If e.Text.Length > 1 Then
            If _transaccion.IdSubDiario = 2 Then
                Me.RadComboBox1.DataSourceID = "odsPlanContableCompras"
                Me.odsPlanContableCompras.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Else
                Me.RadComboBox1.DataSourceID = "odsPlanContable"
                Me.odsPlanContable.SelectParameters("Texto").DefaultValue = e.Text.ToString
            End If


            Me.RadComboBox1.DataBind()
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(Me.RadComboBox1.SelectedValue)
        If _PlanContable.RequiereCCosto = "S" Then
            RequiredFieldValidator2.Enabled = True
        Else
            RequiredFieldValidator2.Enabled = False
        End If
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(Me.RadComboBox1.SelectedValue)
        If _PlanContable.RequiereCCosto = "S" Then
            RequiredFieldValidator2.Enabled = True
        Else
            RequiredFieldValidator2.Enabled = False
        End If
    End Sub
End Class
