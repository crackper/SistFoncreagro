Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmAsignarHorario
    Inherits System.Web.UI.Page
    Dim IdPeriodoLaboral As Integer
    Dim Fecha As Date
    Dim fechaFin As Date
    Dim HorarioAsignadoBL As New HorarioAsignadoBL
    Dim horarioAsignado As HorarioAsignado
    Dim controlAsistenciaBL As New ControlAsistenciaBL
    Dim Ids() As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session("IdPeriodoLaboral") = 2
        IdPeriodoLaboral = Session("IdPeriodoLaboral")

        Me.lblNombre.Text = Session("nombre")
        Me.lblArea.Text = Session("area")
        Me.lblCargo.Text = Session("posicion")


        'If Request.QueryString("Fecha").ToString <> "0" Then
        '    Fecha = CDate(Request.QueryString("Fecha"))
        'Else
        Fecha = CDate("01/10/2011")
        'End If

        If Not Page.IsPostBack Then
            Me.rdpIniHorario.SelectedDate = Fecha
        End If

        Me.txtFechaIni.Text = DateValue(rdpIniHorario.SelectedDate)

        Dim inicioMes As Date
        inicioMes = DateSerial(Year(DateValue(rdpIniHorario.SelectedDate)), Month(DateValue(rdpIniHorario.SelectedDate)) + 1, 1)

        fechaFin = DateAdd(DateInterval.Day, -1, inicioMes)

        Me.txtFechaFin.Text = fechaFin
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        horarioAsignado = New HorarioAsignado
        Ids = Split(ddlHorario.SelectedValue, "/")

        horarioAsignado.IdAsignacionHorario = 0
        horarioAsignado.IdHorario = Ids(0)
        horarioAsignado.IdJornadaTrabajo = Ids(1)
        horarioAsignado.IdPeriodoLaboral = IdPeriodoLaboral
        horarioAsignado.FechaInicio = DateValue(Me.rdpIniHorario.SelectedDate)

        HorarioAsignadoBL.SaveHORARIOASIGNADO(horarioAsignado)

        controlAsistenciaBL.GenerarControlAsistenciaByIdPeriodoLaboral(IdPeriodoLaboral, CDate(Me.txtFechaIni.Text), CDate(Me.txtFechaFin.Text))

    End Sub

    Protected Sub rdpIniHorario_SelectedDateChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs) Handles rdpIniHorario.SelectedDateChanged
        Me.txtFechaIni.Text = DateValue(rdpIniHorario.SelectedDate)
    End Sub
End Class