Imports SistFoncreagro.BussinesLogic
Public Class FrmConvenios
    Dim convenioBL As New ConvenioBL
    Dim proyectoBL As New ProyectoBL
    Private Sub FrmConvenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ConvenioBindingSource.DataSource = convenioBL.GetAllFromConvenio
        BotonesPrinc(3)
    End Sub

    Private Sub BotonesPrinc(ByVal valor As Integer)
        Select Case valor
            Case 1 'Nuevo
                Me.mnnuevo.Enabled = False
                Me.mnmostrar.Enabled = False
                Me.mnbuscar.Enabled = False
                Me.mneditar.Enabled = False
                Me.mngrabar.Enabled = True
                Me.mncancelar.Enabled = True
                Me.mneliminar.Enabled = False
                Me.mncerrar.Enabled = True
                Me.tpdetalle.Enabled = True
                Me.tplista.Enabled = False
                Me.tabprincipal.SelectedTab = Me.tpdetalle
            Case 2 'Mostrar
                Me.mnnuevo.Enabled = False
                Me.mnmostrar.Enabled = False
                Me.mnbuscar.Enabled = True
                Me.mneditar.Enabled = Me.dgvlista.RowCount > 0
                Me.mngrabar.Enabled = False
                Me.mncancelar.Enabled = False
                Me.mneliminar.Enabled = False
                Me.mncerrar.Enabled = True
                Me.tpdetalle.Enabled = Me.dgvlista.RowCount > 0
                Me.tplista.Enabled = False
                Me.tabprincipal.SelectedTab = Me.tpdetalle
            Case 3 'buscar
                Me.mnnuevo.Enabled = True
                Me.mnmostrar.Enabled = Me.dgvlista.RowCount > 0
                Me.mnbuscar.Enabled = False
                Me.mneditar.Enabled = False
                Me.mngrabar.Enabled = False
                Me.mncancelar.Enabled = False
                Me.mneliminar.Enabled = Me.dgvlista.RowCount > 0
                Me.mncerrar.Enabled = True
                Me.tpdetalle.Enabled = False
                Me.tplista.Enabled = True
                Me.tabprincipal.SelectedTab = Me.tplista
            Case 4 'editar
                Me.mnnuevo.Enabled = False
                Me.mnmostrar.Enabled = False
                Me.mnbuscar.Enabled = False
                Me.mneditar.Enabled = False
                Me.mngrabar.Enabled = True
                Me.mncancelar.Enabled = True
                Me.mneliminar.Enabled = False
                Me.mncerrar.Enabled = True
                Me.tpdetalle.Enabled = True
                Me.tplista.Enabled = False
                Me.tabprincipal.SelectedTab = Me.tpdetalle
            Case 5 'grabar
                Me.mnnuevo.Enabled = True
                Me.mnmostrar.Enabled = False
                Me.mnbuscar.Enabled = True
                Me.mneditar.Enabled = Me.dgvlista.RowCount > 0
                Me.mngrabar.Enabled = False
                Me.mncancelar.Enabled = False
                Me.mneliminar.Enabled = Me.dgvlista.RowCount > 0
                Me.mncerrar.Enabled = True
                Me.tpdetalle.Enabled = True
                Me.tplista.Enabled = False
                Me.tabprincipal.SelectedTab = Me.tpdetalle
            Case 6 'cancelar
                Me.mnnuevo.Enabled = True
                Me.mnmostrar.Enabled = False
                Me.mnbuscar.Enabled = True
                Me.mneditar.Enabled = Me.dgvlista.RowCount > 0
                Me.mngrabar.Enabled = False
                Me.mncancelar.Enabled = False
                Me.mneliminar.Enabled = Me.dgvlista.RowCount > 0
                Me.mncerrar.Enabled = True
                Me.tpdetalle.Enabled = True
                Me.tplista.Enabled = False
                Me.tabprincipal.SelectedTab = Me.tpdetalle
            Case 7 'eliminar
                Me.mnnuevo.Enabled = True
                Me.mnmostrar.Enabled = True
                Me.mnbuscar.Enabled = False
                Me.mneditar.Enabled = Me.dgvlista.RowCount > 0
                Me.mngrabar.Enabled = False
                Me.mncancelar.Enabled = False
                Me.mneliminar.Enabled = Me.dgvlista.RowCount > 0
                Me.mncerrar.Enabled = True
                Me.tpdetalle.Enabled = False
                Me.tplista.Enabled = True
                Me.tabprincipal.SelectedTab = Me.tplista
                If Me.dgvlista.Rows.Count > 0 Then
                    Me.dgvlista.Rows(0).Selected = True
                End If
        End Select
    End Sub

    Private Sub HabilitarCajas(ByVal cond As Boolean, ByVal limpiar As String)
        'Desactivar controles para que no sean editables automaticamente
        Me.txtidconvenio.Enabled = False
        Me.txtcodigo.Enabled = cond
        Me.txtalias.Enabled = cond
        Me.txtnombre.Enabled = cond
        Me.dtfecini.Enabled = cond
        Me.cbmoneda.Enabled = cond
        Me.txtmonto.Enabled = cond
        Me.cbtipo.Enabled = cond
        Me.cbfase.Enabled = cond
        Me.cbstatus.Enabled = cond
        Me.txtarea.Enabled = cond
        Me.dtfecfin.Enabled = cond
        Me.dgvlisproy.ReadOnly = True
        If limpiar = "SI" Then
            Me.txtidconvenio.Text = ""
            Me.txtcodigo.Text = ""
            Me.txtalias.Text = ""
            Me.txtnombre.Text = ""
            Me.txtnombre.Text = ""
            Me.dtfecini.Text = Now
            Me.cbmoneda.Text = ""
            Me.txtmonto.Text = ""
            Me.cbtipo.Text = ""
            Me.cbfase.Text = ""
            Me.cbstatus.Text = ""
            Me.txtarea.Text = ""
            Me.dtfecfin.Value = Now
        End If
    End Sub

    Private Sub mncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mncerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvlista_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlista.SelectionChanged
        If dgvlista.RowCount > 0 Then
            Me.panellista.FooterText = Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("CodConv").Value.ToString '+ " - " + Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("NomConv").Value.ToString + IIf(Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("AliasConv").Value Is System.DBNull.Value, "", " - " + Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("AliasConv").Value.ToString)
            Me.paneldetalle.HeaderText = Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("CodConv").Value.ToString '+ " - " + Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("NomConv").Value.ToString + IIf(Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("AliasConv").Value Is System.DBNull.Value, "", " - " + Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("AliasConv").Value.ToString)
        End If
    End Sub

    Private Sub cbbuscar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbuscar.SelectedIndexChanged
        Me.txtbuscar.Select()
    End Sub

    Private Sub mnmostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnmostrar.Click, dgvlista.CellDoubleClick
        BotonesPrinc(2)
        swnuevo = False
        swmodificar = False
        HabilitarCajas(False, "NO")
        Me.DetConvenioBindingSource.DataSource = Me.convenioBL.GetFromConvenioById(Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("IdConvenio").Value)
        Me.ProyectoBindingSource.DataSource = Me.proyectoBL.GetFromProyectoByIdConvenio(Me.dgvlista.Rows(Me.dgvlista.CurrentRow.Index).Cells("IdConvenio").Value)
    End Sub

    Private Sub mngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mngrabar.Click

    End Sub
End Class
