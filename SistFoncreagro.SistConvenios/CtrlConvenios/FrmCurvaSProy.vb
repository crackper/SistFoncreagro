Imports Microsoft.Reporting.WinForms
Public Class FrmCurvaSProy
    Dim vvar As Integer
    Private Sub btcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbuscar.Click
        Dim parametros(1) As ReportParameter
        Dim vproy As Integer
        Dim vfecini, vfecfin As Date

        vproy = Me.cbproyecto.SelectedValue
        If vproy = 0 Then
            MessageBox.Show("Seleccione el Proyecto que desea consultar", "Falta Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.cbproyecto.Select()
            Return
        End If
        vfecini = Me.dtfecini.Value.Date
        vfecfin = Me.dtfecfin.Value.Date
        If vfecini > vfecfin Then
            MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la Fecha de Termino", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dtfecfin.Select()
            Return
        End If
        If vfecini.Date > Now.Date Then
            MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la Fecha Actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dtfecini.Select()
            Return
        End If
        If vfecfin.Date > Now.Date Then
            MessageBox.Show("La Fecha de Término no puede ser Mayor a la Fecha Actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dtfecfin.Select()
            Return
        End If
        If (vfecini.Day) <> 1 Then
            vfecini = DateAdd(DateInterval.Day, -(vfecini.Day - 1), vfecini)
        End If
        If (vfecfin.Day) <> 1 Then
            vfecfin = DateAdd(DateInterval.Day, -(vfecfin.Day - 1), vfecfin)
        End If
        'TODO: esta línea de código carga datos en la tabla 'DSFonConvenio.PA_INFORME_MONIT_PROY' Puede moverla o quitarla según sea necesario.
        Me.PA_INFORME_MONIT_PROYTableAdapter.Fill(Me.DSFonConvenio.PA_INFORME_MONIT_PROY, vproy)
        'TODO: esta línea de código carga datos en la tabla 'DSFonConvenio.PA_REPORTE_EFECT_PROYECTO' Puede moverla o quitarla según sea necesario.
        Me.PA_REPORTE_EFECT_PROYECTOTableAdapter.Fill(Me.DSFonConvenio.PA_REPORTE_EFECT_PROYECTO, vproy, vfecini, vfecfin)
        'TODO: esta línea de código carga datos en la tabla 'DSFonConvenio.PA_CURVA_S_FISICO_X_PROYECTO' Puede moverla o quitarla según sea necesario.
        Me.PA_CURVA_S_FISICO_X_PROYECTOTableAdapter.Fill(Me.DSFonConvenio.PA_CURVA_S_FISICO_X_PROYECTO, vproy, vfecini, vfecfin)
        'TODO: esta línea de código carga datos en la tabla 'DSFonConvenio.PA_CURVA_S_PRESUPUESTO_X_PROYECTO' Puede moverla o quitarla según sea necesario.
        Me.PA_CURVA_S_PRESUPUESTO_X_PROYECTOTableAdapter.Fill(Me.DSFonConvenio.PA_CURVA_S_PRESUPUESTO_X_PROYECTO, vproy, vfecini, vfecfin)
        parametros(0) = New ReportParameter("FecInicial", vfecini)
        parametros(1) = New ReportParameter("FecFinal", vfecfin)
        Me.rptgeneral.LocalReport.SetParameters(parametros)
        Me.rptgeneral.RefreshReport()
    End Sub

    Private Sub FrmCurvaSProy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSFonConvenio.GetAllProyectos' Puede moverla o quitarla según sea necesario.
        Me.GetAllProyectosTableAdapter.Fill(Me.DSFonConvenio.GetAllProyectos)
        vvar = 0
        Me.dtfecini.Value = DevuelveFecha("IniProyReal", "dbo.PROYECTO", Me.cbproyecto.SelectedValue)
        Me.dtfecfin.Value = DevuelveFecha("FinProyProg", "dbo.PROYECTO", Me.cbproyecto.SelectedValue)
        If Me.dtfecfin.Value.Date > Now.Date Then
            Me.dtfecfin.Value = Now
        End If
    End Sub

    Private Sub cbproyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbproyecto.SelectedIndexChanged
        Me.contenedor.FooterText = Me.cbproyecto.Text
        If vvar = 1 Then
            Me.dtfecini.Value = DevuelveFecha("IniProyReal", "dbo.PROYECTO", Me.cbproyecto.SelectedValue)
            Me.dtfecfin.Value = DevuelveFecha("FinProyProg", "dbo.PROYECTO", Me.cbproyecto.SelectedValue)
            If Me.dtfecfin.Value.Date > Now.Date Then
                Me.dtfecfin.Value = Now
            End If
        End If
    End Sub

End Class