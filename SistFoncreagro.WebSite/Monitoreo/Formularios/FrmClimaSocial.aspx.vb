Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Collections
Imports System.Configuration
Imports System
Public Class FrmClimaSocial
    Inherits System.Web.UI.Page
    Dim _Clima As New ClimaSocial
    Dim ClimaBL As New ClimaSocialBL
    Dim Clima As ClimaSocial
    Dim IdClima As String
    Dim _ubigeo As UbigeoDatos
    Dim ubigeoBL As New UbigeoDatosBL
    Dim CUBIGEO As String
    Dim Total As Decimal
    Dim IdProyecto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdClima = Request.QueryString("IdClima")
        CUBIGEO = Request.QueryString("CUBIGEO")
        IdProyecto = Request.QueryString("IdProyecto")

        _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(CUBIGEO)
        Me.Label1.Text = _ubigeo.Caserio
        If Page.IsPostBack = False Then
            Me.txtDate2.Text = Date.Now
            If IdClima > 0 Then
                'para recuperar datos 
                Clima = ClimaBL.GetCLIMASOCIALByIdClima(IdClima)

                _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(Clima.CUBIGEO)
                Me.Label1.Text = _ubigeo.Caserio
                Me.txtDate2.Text = Clima.Fecha
                Me.RadioButtonList1.SelectedValue = Clima.Tipo
                Me.DropDownList5.SelectedValue = Clima.Acceso
                Me.DropDownList6.SelectedValue = Clima.Agresividad
                Me.DropDownList7.SelectedValue = Clima.Movilizaciones
                Me.DropDownList8.SelectedValue = Clima.Quejas
                Me.DropDownList15.SelectedValue = Clima.ActExterna
                Me.DropDownList9.SelectedValue = Clima.Cobertura
                Me.DropDownList10.SelectedValue = Clima.Confrontacion
                Me.DropDownList11.SelectedValue = Clima.Dimension
                Me.DropDownList12.SelectedValue = Clima.Autoridades
                Me.DropDownList16.SelectedValue = Clima.Docentes
                Me.DropDownList17.SelectedValue = Clima.Rondas
                Me.TextBox8.Text = Clima.Razon
                Me.TextBox9.Text = Clima.DescQuejas
                Me.TextBox10.Text = Clima.AccionesTomadas
                Me.TextBox11.Text = Clima.Observaciones
                Me.DropDownList18.SelectedValue = Clima.Actitud1

                If Clima.Actitud = "APOYO TOTAL" Then
                    Me.Image1.Visible = True
                    Me.Image2.Visible = False
                    Me.Image3.Visible = False
                    Me.Image4.Visible = False
                    Me.Image5.Visible = False
                ElseIf Clima.Actitud = "APOYO MODERADO" Then
                    Me.Image1.Visible = False
                    Me.Image2.Visible = True
                    Me.Image3.Visible = False
                    Me.Image4.Visible = False
                    Me.Image5.Visible = False
                ElseIf Clima.Actitud = "NEUTRAL" Then
                    Me.Image1.Visible = False
                    Me.Image2.Visible = False
                    Me.Image3.Visible = True
                    Me.Image4.Visible = False
                    Me.Image5.Visible = False
                ElseIf Clima.Actitud = "OPOSICION MODERADA" Then
                    Me.Image1.Visible = False
                    Me.Image2.Visible = False
                    Me.Image3.Visible = False
                    Me.Image4.Visible = True
                    Me.Image5.Visible = False
                ElseIf Clima.Actitud = "OPOSICION RADICAL" Then
                    Me.Image1.Visible = False
                    Me.Image2.Visible = False
                    Me.Image3.Visible = False
                    Me.Image4.Visible = False
                    Me.Image5.Visible = True
                ElseIf Clima.Actitud = "SIN DETERMINAR" Then
                    Me.Image1.Visible = False
                    Me.Image2.Visible = False
                    Me.Image3.Visible = False
                    Me.Image4.Visible = False
                    Me.Image5.Visible = False
                    Me.Image6.Visible = True
                End If
                If Clima.Tipo = "INDIRECTA" Then
                    Me.DropDownList5.Enabled = False
                    Me.DropDownList6.Enabled = False
                    Me.DropDownList7.Enabled = False
                    Me.DropDownList8.Enabled = False
                    Me.DropDownList9.Enabled = False
                    Me.DropDownList10.Enabled = False
                    Me.DropDownList11.Enabled = False
                    Me.DropDownList12.Enabled = False
                    Me.DropDownList15.Enabled = False
                    Me.DropDownList16.Enabled = False
                    Me.DropDownList17.Enabled = False
                    Me.DropDownList18.Enabled = True
                    Me.TextBox8.Enabled = True
                Else
                    Me.DropDownList5.Enabled = True
                    Me.DropDownList6.Enabled = True
                    Me.DropDownList7.Enabled = True
                    Me.DropDownList8.Enabled = True
                    Me.DropDownList9.Enabled = True
                    Me.DropDownList10.Enabled = True
                    Me.DropDownList11.Enabled = True
                    Me.DropDownList12.Enabled = True
                    Me.DropDownList15.Enabled = True
                    Me.DropDownList16.Enabled = True
                    Me.DropDownList17.Enabled = True
                    Me.DropDownList18.Enabled = False
                    Me.TextBox8.Enabled = False
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        If Me.RadioButtonList1.SelectedValue = "DIRECTA" Then
            _Clima.AccionesTomadas = Me.TextBox10.Text
            _Clima.Razon = Me.TextBox8.Text
            _Clima.Fecha = Me.txtDate2.Text
            _Clima.IdClima = IdClima
            _Clima.CUBIGEO = CUBIGEO
            _Clima.IdUsuario = Session("IdUser")
            _Clima.Observaciones = Me.TextBox11.Text
            _Clima.DescQuejas = Me.TextBox9.Text
            _Clima.IdProyecto = IdProyecto
            _Clima.Tipo = Me.RadioButtonList1.SelectedValue
            _Clima.Acceso = Me.DropDownList5.SelectedValue
            _Clima.Agresividad = Me.DropDownList6.SelectedValue
            _Clima.Movilizaciones = Me.DropDownList7.SelectedValue
            _Clima.Quejas = Me.DropDownList8.SelectedValue
            _Clima.ActExterna = Me.DropDownList15.SelectedValue
            _Clima.Cobertura = Me.DropDownList9.SelectedValue
            _Clima.Confrontacion = Me.DropDownList10.SelectedValue
            _Clima.Dimension = Me.DropDownList11.SelectedValue
            _Clima.Autoridades = Me.DropDownList12.SelectedValue
            _Clima.Docentes = Me.DropDownList16.SelectedValue
            _Clima.Rondas = Me.DropDownList17.SelectedValue
            _Clima.Actitud1 = "SIN DETERMINAR"
        Else
            _Clima.AccionesTomadas = Me.TextBox10.Text
            _Clima.Razon = Me.TextBox8.Text
            _Clima.Fecha = Me.txtDate2.Text
            _Clima.IdClima = IdClima
            _Clima.CUBIGEO = CUBIGEO
            _Clima.IdUsuario = Session("IdUser")
            _Clima.Observaciones = Me.TextBox11.Text
            _Clima.DescQuejas = Me.TextBox9.Text
            _Clima.IdProyecto = IdProyecto
            _Clima.Tipo = Me.RadioButtonList1.SelectedValue
            _Clima.Acceso = 0
            _Clima.Agresividad = 0
            _Clima.Movilizaciones = 0
            _Clima.Quejas = 0
            _Clima.ActExterna = 0
            _Clima.Cobertura = 0
            _Clima.Confrontacion = 0
            _Clima.Dimension = 0
            _Clima.Autoridades = 0
            _Clima.Docentes = 0
            _Clima.Rondas = 0
            _Clima.Actitud1 = Me.DropDownList18.SelectedValue
        End If
        

        If IdClima > 0 Then
            ClimaBL.SaveCLIMASOCIAL(_Clima)
        Else
            IdClima = ClimaBL.SaveCLIMASOCIAL(_Clima)
        End If
        Response.Redirect("FrmClimaSocial.aspx?IdClima=" + IdClima.ToString + "&IdProyecto=" + IdProyecto.ToString + "&CUBIGEO=" + CUBIGEO.ToString)
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Response.Redirect("FrmClimaSocial.aspx?IdClima=0&IdProyecto=" + IdProyecto.ToString + "&CUBIGEO=" + CUBIGEO.ToString)
    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If Me.RadioButtonList1.SelectedValue = "INDIRECTA" Then
            Me.DropDownList5.Enabled = False
            Me.DropDownList6.Enabled = False
            Me.DropDownList7.Enabled = False
            Me.DropDownList8.Enabled = False
            Me.DropDownList9.Enabled = False
            Me.DropDownList10.Enabled = False
            Me.DropDownList11.Enabled = False
            Me.DropDownList12.Enabled = False
            Me.DropDownList15.Enabled = False
            Me.DropDownList16.Enabled = False
            Me.DropDownList17.Enabled = False
            Me.DropDownList18.Enabled = True
            Me.TextBox8.Enabled = True
        Else
            Me.DropDownList5.Enabled = True
            Me.DropDownList6.Enabled = True
            Me.DropDownList7.Enabled = True
            Me.DropDownList8.Enabled = True
            Me.DropDownList9.Enabled = True
            Me.DropDownList10.Enabled = True
            Me.DropDownList11.Enabled = True
            Me.DropDownList12.Enabled = True
            Me.DropDownList15.Enabled = True
            Me.DropDownList16.Enabled = True
            Me.DropDownList17.Enabled = True
            Me.DropDownList18.Enabled = False
            Me.TextBox8.Enabled = False
        End If
    End Sub
End Class