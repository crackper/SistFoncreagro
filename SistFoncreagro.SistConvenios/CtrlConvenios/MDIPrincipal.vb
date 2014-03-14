Imports System.Windows.Forms

Public Class MDIPrincipal
    Private m_ChildFormNumber As Integer
    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles mnpersonal.Click, NewWindowToolStripMenuItem.Click
    '    ' Cree una nueva instancia del formulario secundario.
    '    Dim ChildForm As New FrmConvenios
    '    ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
    '    ChildForm.MdiParent = Me
    '    ChildForm.Show()
    'End Sub

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles mncargo.Click
    '    ' Cree una nueva instancia del formulario secundario.
    '    Dim ChildForm As New FrmConvenios
    '    ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
    '    ChildForm.MdiParent = Me
    '    ChildForm.Show()
    'End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnsalir.Click
        Application.Exit()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub mnrptSproy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnrptSproy.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New FrmCurvaSProy
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub CurvaSPresupuestoPorProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurvaSPresupuestoPorProyectoToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New FrmCurvaSPresProy
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    'Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mncofinanciador.Click
    '    ' Cree una nueva instancia del formulario secundario.
    '    Dim ChildForm As New FrmConvenios
    '    ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
    '    ChildForm.MdiParent = Me
    '    ChildForm.Show()
    'End Sub

    ''    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnempresa.Click
    ''        ' Cree una nueva instancia del formulario secundario.
    ''        Dim ChildForm As New FrmConvenios
    ''        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
    ''        ChildForm.MdiParent = Me
    ''        ChildForm.Show()
    ''    End Sub

    ''    Private Sub AdministraciónDeConveniosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnadminconvenios.Click
    ''        ' Cree una nueva instancia del formulario secundario.
    ''        Dim ChildForm As New FrmConvenios
    ''        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
    ''        ChildForm.MdiParent = Me
    ''        ChildForm.Show()
    ''    End Sub
End Class
