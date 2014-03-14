Public Class FrmCurvaSPresProy

    Private Sub btcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FrmCurvaSPresProy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSFonConvenio.GetAllProyectos' Puede moverla o quitarla según sea necesario.
        Me.GetAllProyectosTableAdapter.Fill(Me.DSFonConvenio.GetAllProyectos)
    End Sub

    Private Sub btbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbuscar.Click
        Dim vproy As Integer
        vproy = Me.cbproyecto.SelectedValue
        If vproy = 0 Then
            MessageBox.Show("Seleccione el Proyecto que desea consultar", "Falta Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.cbproyecto.Select()
        End If
        'TODO: esta línea de código carga datos en la tabla 'DSFonConvenio.PA_CURVA_S_PRESUPUESTO_X_PROYECTO' Puede moverla o quitarla según sea necesario.
        Me.PA_CURVA_S_PRESUPUESTO_X_PROYECTOTableAdapter.Fill(Me.DSFonConvenio.PA_CURVA_S_PRESUPUESTO_X_PROYECTO, vproy, Me.dtfecini.Value.Date, Me.dtfecfin.Value.Date)
        Me.rptgeneral.RefreshReport()
    End Sub
End Class