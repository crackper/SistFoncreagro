Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlNuevoCargo
    Inherits System.Web.UI.UserControl

    Dim cargoBl As New CargoBL

    Private _dataItem As Object = Nothing
    Dim TransaccionBL As New TransaccionBL
    Dim _transaccion As Transaccion
    Dim IdTransaccion As String

    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property

    Public Property IdCargo As System.Nullable(Of Int32)
        Get
            If String.IsNullOrEmpty(Me.TxtIdCargo.Text) Then
                Return 0
            Else
                Return CInt(Me.TxtIdCargo.Text)
            End If
        End Get
        Set(ByVal value As System.Nullable(Of Int32))
            If value Is Nothing Then
                Me.TxtIdCargo.Text = ""
            Else
                Me.TxtIdCargo.Text = value
            End If

        End Set
    End Property

    Public Property NomCargo As String
        Get
            Return Me.txtNomCargo.Text
        End Get
        Set(ByVal value As String)
            Me.txtNomCargo.Text = value
        End Set
    End Property

    Public Property DescCargo As String
        Get
            Return Me.txtDescCargo.Text
        End Get
        Set(ByVal value As String)
            Me.txtDescCargo.Text = value
        End Set
    End Property


    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then
            Me.TxtIdCargo.Text = 0
            Me.txtNomCargo.Text = ""
            Me.txtDescCargo.Text = ""
            Me.ImgBtnGuardar.CommandName = "PerformInsert"
            Me.lblMensaje.Visible = False
            ' Me.LblTitulo.Text = "Nuevo Registro"

        Else
            Me.TxtIdCargo.Text = DataBinder.Eval(DataItem, "IdCargo")
            Me.txtNomCargo.Text = DataBinder.Eval(DataItem, "NomCargo")
            Me.txtDescCargo.Text = DataBinder.Eval(DataItem, "DescCargo")
            Me.ImgBtnGuardar.CommandName = "Update"
            Me.lblMensaje.Visible = False
            'Me.LblTitulo.Text = "Editar Registro"
        End If
    End Sub


    Public Event RegistrarCargo(ByVal sender As Object, ByVal e As Cargo)
    Public Event ClickEnBoton(ByVal sender As Object, ByVal e As String)

    'Protected Sub ImgBtnGuardar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtnGuardar.Click
    '    ' If TypeOf DataItem Is GridInsertionObject Then
    '    Dim cargo As New Cargo
    '    Dim coleccion As New Collection

    '    cargo.IdCargo = Convert.ToInt32(Me.TxtIdCargo.Text)
    '    cargo.NomCargo = Me.txtNomCargo.Text
    '    cargo.DescCargo = Me.txtDescCargo.Text
    '    Try
    '        coleccion = cargoBl.InsertCargoNomCargo(cargo)

    '        If Convert.ToString(coleccion.Item("condicion")) = "E" Then
    '            Me.lblMensaje.Visible = True
    '            Me.lblMensaje.Text = Convert.ToString(coleccion.Item("mensaje"))
    '        Else
    '            Me.ImgBtnGuardar.CommandName = "PerformInsert"
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Protected Sub ImgBtnGuardar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtnGuardar.Click
        Dim cargo As New Cargo

        'cargo.IdCargo = Me.TxtIdCargo.Text
        'cargo.DescCargo = Me.txtDescCargo.Text
        'cargo.NomCargo = Me.txtNomCargo.Text

        RaiseEvent ClickEnBoton(Me, "Insertar")

        'RaiseEvent RegistrarCargo(Me, cargo)

    End Sub

    Protected Sub ImgBtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtnCancelar.Click
        RaiseEvent ClickEnBoton(Me, "Cancelar")
    End Sub
End Class