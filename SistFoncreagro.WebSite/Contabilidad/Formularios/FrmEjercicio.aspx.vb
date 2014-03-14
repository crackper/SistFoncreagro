Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmEjercicio
    Inherits System.Web.UI.Page
    Dim EjercicioBL As New EjercicioBL
    Dim _Ejercicio As Ejercicio
    Dim _Ejercicio1 As New Ejercicio
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            'para recuperar datos 
            _Ejercicio = EjercicioBL.GetEJERCICIOByAnio(Int32.Parse(Session("Anio")))
            Me.Label1.Text = Session("Anio")
            Me.TextBox1.Text = _Ejercicio.Apertura
            Me.TextBox2.Text = _Ejercicio.Enero
            Me.TextBox3.Text = _Ejercicio.Febrero
            Me.TextBox4.Text = _Ejercicio.Marzo
            Me.TextBox5.Text = _Ejercicio.Abril
            Me.TextBox6.Text = _Ejercicio.Mayo
            Me.TextBox7.Text = _Ejercicio.Junio
            Me.TextBox8.Text = _Ejercicio.Julio
            Me.TextBox9.Text = _Ejercicio.Agosto
            Me.TextBox10.Text = _Ejercicio.Setiembre
            Me.TextBox11.Text = _Ejercicio.Octubre
            Me.TextBox12.Text = _Ejercicio.Noviembre
            Me.TextBox13.Text = _Ejercicio.Diciembre
            Me.TextBox14.Text = _Ejercicio.Cierre
            Me.TextBox15.Text = _Ejercicio.IdEjercicio
        End If
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        _Ejercicio1.Abril = Me.TextBox5.Text
        _Ejercicio1.Agosto = Me.TextBox9.Text
        _Ejercicio1.Anio = Session("Anio")
        _Ejercicio1.Apertura = Me.TextBox1.Text
        _Ejercicio1.Cierre = Me.TextBox14.Text
        _Ejercicio1.Diciembre = Me.TextBox13.Text
        _Ejercicio1.Enero = Me.TextBox2.Text
        _Ejercicio1.Febrero = Me.TextBox3.Text
        _Ejercicio1.IdEjercicio = Me.TextBox15.Text
        _Ejercicio1.Julio = Me.TextBox8.Text
        _Ejercicio1.Junio = Me.TextBox7.Text
        _Ejercicio1.Marzo = Me.TextBox4.Text
        _Ejercicio1.Mayo = Me.TextBox6.Text
        _Ejercicio1.Noviembre = Me.TextBox12.Text
        _Ejercicio1.Octubre = Me.TextBox11.Text
        _Ejercicio1.Setiembre = Me.TextBox10.Text
        EjercicioBL.SaveEJERCICIO(_Ejercicio1)

    End Sub
End Class