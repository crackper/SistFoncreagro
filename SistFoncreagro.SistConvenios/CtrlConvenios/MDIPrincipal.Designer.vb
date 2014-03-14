<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnarchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnpersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncargo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncofinanciador = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnempresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnsalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnconvenios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnadminconvenios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnreportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrptSproy = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurvaSPresupuestoPorProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnventanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnayuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncontenido = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnacerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnarchivo, Me.mnconvenios, Me.mnreportes, Me.mnventanas, Me.mnayuda})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.mnventanas
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnarchivo
        '
        Me.mnarchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnpersonal, Me.mncargo, Me.mncofinanciador, Me.mnempresa, Me.ToolStripSeparator5, Me.mnsalir})
        Me.mnarchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnarchivo.Name = "mnarchivo"
        Me.mnarchivo.Size = New System.Drawing.Size(60, 20)
        Me.mnarchivo.Text = "&Archivo"
        '
        'mnpersonal
        '
        Me.mnpersonal.Image = CType(resources.GetObject("mnpersonal.Image"), System.Drawing.Image)
        Me.mnpersonal.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnpersonal.Name = "mnpersonal"
        Me.mnpersonal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnpersonal.Size = New System.Drawing.Size(189, 22)
        Me.mnpersonal.Text = "&Personal"
        '
        'mncargo
        '
        Me.mncargo.Image = CType(resources.GetObject("mncargo.Image"), System.Drawing.Image)
        Me.mncargo.ImageTransparentColor = System.Drawing.Color.Black
        Me.mncargo.Name = "mncargo"
        Me.mncargo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mncargo.Size = New System.Drawing.Size(189, 22)
        Me.mncargo.Text = "&Cargo"
        '
        'mncofinanciador
        '
        Me.mncofinanciador.Image = CType(resources.GetObject("mncofinanciador.Image"), System.Drawing.Image)
        Me.mncofinanciador.ImageTransparentColor = System.Drawing.Color.Black
        Me.mncofinanciador.Name = "mncofinanciador"
        Me.mncofinanciador.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mncofinanciador.Size = New System.Drawing.Size(189, 22)
        Me.mncofinanciador.Text = "Co&financiador"
        '
        'mnempresa
        '
        Me.mnempresa.Image = CType(resources.GetObject("mnempresa.Image"), System.Drawing.Image)
        Me.mnempresa.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnempresa.Name = "mnempresa"
        Me.mnempresa.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnempresa.Size = New System.Drawing.Size(189, 22)
        Me.mnempresa.Text = "&Empresa"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(186, 6)
        '
        'mnsalir
        '
        Me.mnsalir.Name = "mnsalir"
        Me.mnsalir.Size = New System.Drawing.Size(189, 22)
        Me.mnsalir.Text = "&Salir"
        '
        'mnconvenios
        '
        Me.mnconvenios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnadminconvenios})
        Me.mnconvenios.Name = "mnconvenios"
        Me.mnconvenios.Size = New System.Drawing.Size(75, 20)
        Me.mnconvenios.Text = "&Convenios"
        '
        'mnadminconvenios
        '
        Me.mnadminconvenios.Name = "mnadminconvenios"
        Me.mnadminconvenios.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnadminconvenios.Size = New System.Drawing.Size(272, 22)
        Me.mnadminconvenios.Text = "&Administración de Convenios"
        '
        'mnreportes
        '
        Me.mnreportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnrptSproy, Me.CurvaSPresupuestoPorProyectoToolStripMenuItem})
        Me.mnreportes.Name = "mnreportes"
        Me.mnreportes.Size = New System.Drawing.Size(65, 20)
        Me.mnreportes.Text = "&Reportes"
        '
        'mnrptSproy
        '
        Me.mnrptSproy.Name = "mnrptSproy"
        Me.mnrptSproy.Size = New System.Drawing.Size(261, 22)
        Me.mnrptSproy.Text = "Infome de Proyecto"
        '
        'CurvaSPresupuestoPorProyectoToolStripMenuItem
        '
        Me.CurvaSPresupuestoPorProyectoToolStripMenuItem.Name = "CurvaSPresupuestoPorProyectoToolStripMenuItem"
        Me.CurvaSPresupuestoPorProyectoToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.CurvaSPresupuestoPorProyectoToolStripMenuItem.Text = "Curva S - Presupuesto por Proyecto"
        '
        'mnventanas
        '
        Me.mnventanas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.mnventanas.Name = "mnventanas"
        Me.mnventanas.Size = New System.Drawing.Size(67, 20)
        Me.mnventanas.Text = "&Ventanas"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.NewWindowToolStripMenuItem.Text = "&Nueva ventana"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'mnayuda
        '
        Me.mnayuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncontenido, Me.ToolStripSeparator8, Me.mnacerca})
        Me.mnayuda.Name = "mnayuda"
        Me.mnayuda.Size = New System.Drawing.Size(53, 20)
        Me.mnayuda.Text = "Ay&uda"
        '
        'mncontenido
        '
        Me.mncontenido.Name = "mncontenido"
        Me.mncontenido.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mncontenido.Size = New System.Drawing.Size(176, 22)
        Me.mncontenido.Text = "&Contenido"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(173, 6)
        '
        'mnacerca
        '
        Me.mnacerca.Name = "mnacerca"
        Me.mnacerca.Size = New System.Drawing.Size(176, 22)
        Me.mnacerca.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIPrincipal"
        Me.Text = "Sistema de Monitoreo y Control de Convenios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mncontenido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnayuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnacerca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnventanas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnrptSproy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnempresa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnpersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnarchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mncargo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mncofinanciador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnconvenios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnreportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurvaSPresupuestoPorProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnadminconvenios As System.Windows.Forms.ToolStripMenuItem

End Class
