Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlAsistente
    Inherits System.Web.UI.UserControl
    Dim IdProyecto As Int32
    Private _dataItem As Object = Nothing
    Dim Interesado As New InteresadosBL
    Dim _Interesado As Interesados
    Dim ActitudInteresadoBL As New ActitudInteresadoBL
    Dim _ActitudInteresado As ActitudInteresado
    Dim DetalleejeBL As New DetalleEjecucionBL
    Dim DetalleEje As DetalleEjecucion
    Dim IdDetalleEje As String
    Public Property DataItem() As Object

        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdDetalleEje = Request.QueryString("IdDetalleEje")
        IdProyecto = DetalleejeBL.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje).IdProyecto
    End Sub
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(); return false;")
        Me.RadComboBox8.Filter = 1
        Me.ImageButton7.Attributes.Add("onClick", "Abrir(" + IdProyecto.ToString + "); return false;")


        If TypeOf DataItem Is GridInsertionObject Then

        Else
            _Interesado = Interesado.GetINTERESADOSByIdInteresado(DataBinder.Eval(DataItem, "IdInteresado"))
            Me.RadComboBox8.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = _Interesado.Apellidos
            Me.RadComboBox8.DataBind()
            Me.RadComboBox8.SelectedValue = DataBinder.Eval(DataItem, "IdInteresado")

            Me.DropDownList4.SelectedValue = DataBinder.Eval(DataItem, "Actitud")
            Me.DropDownList5.SelectedValue = DataBinder.Eval(DataItem, "Poder")
            Me.DropDownList6.SelectedValue = DataBinder.Eval(DataItem, "Dialogo")
            Me.TextBox2.Text = DataBinder.Eval(DataItem, "Comentario")
            Me.TextBox3.Text = DataBinder.Eval(DataItem, "PlanAccion")
        End If
    End Sub
    Protected Sub RadComboBox8_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox8.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).Apellidos.ToString() + " " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).Nombres.ToString() + " - DNI: " + (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).Dni.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.Interesados)).IdInteresado.ToString()

    End Sub

    Protected Sub RadComboBox8_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox8.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox8.DataSourceID = "odsProveedor"
            Me.odsProveedor.SelectParameters("Parametro").DefaultValue = e.Text.ToString

            Me.RadComboBox8.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox8_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox8.SelectedIndexChanged
        Dim fecha As String
        'Dim Fecha1 As Date

        DetalleEje = DetalleejeBL.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje)
        If DetalleEje.Fecha Is Nothing Then
            Dim cadena_java = "<script type='text/javascript'> " & _
                                            " alert('Ingrese la fecha de ejecucion de la actividad'); " & _
                                            Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        Else
            fecha = DetalleEje.Fecha
            'Fecha1 = Date.ToString("MM/dd/yy", yyyymmddFormat)
            _ActitudInteresado = ActitudInteresadoBL.GetACTITUDINTERESADOByFecha(Me.RadComboBox8.SelectedValue, fecha)
            If Not _ActitudInteresado Is Nothing Then
                Me.DropDownList4.SelectedValue = _ActitudInteresado.Actitud
                Me.DropDownList5.SelectedValue = _ActitudInteresado.Poder
                Me.DropDownList6.SelectedValue = _ActitudInteresado.Dialogo
                Me.TextBox2.Text = _ActitudInteresado.Comentario
                Me.TextBox3.Text = _ActitudInteresado.PlanAccion
            End If
        End If

    End Sub
    'Public Function FormatoFecha(ByVal Fecha As String)
    '    Dim yyyymmddFormat As IFormatProvider = New System.Globalization.CultureInfo(String.Empty, False)
    '    Return Date.ToString("dd/MM/yyyy", yyyymmddFormat)
    'End Function
End Class