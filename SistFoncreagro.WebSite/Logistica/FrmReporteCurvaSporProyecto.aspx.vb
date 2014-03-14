Public Class FrmReporteCurvaSporProyecto
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.rcmbProyecto.Filter = 1
    End Sub
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idComponente As Integer = 0
        Dim idActividad As Integer = 0
        Dim idccosto As Integer = 0
        If rcmbProyecto.SelectedValue.Length > 0 Then
            If rcmbComponente.SelectedValue.Length > 0 Then
                idComponente = rcmbComponente.SelectedValue
            Else
                idComponente = 0
            End If
            If rcmbActividad.SelectedValue.Length > 0 Then
                idActividad = rcmbActividad.SelectedValue
                idComponente = 0
            Else
                idActividad = 0
            End If
            If rcmbCcosto.SelectedValue.Length > 0 Then
                idccosto = rcmbCcosto.SelectedValue
                idComponente = 0
                idActividad = 0
            Else
                idccosto = 0
            End If
        End If
        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                                     " window.open('VentanaReporteCurvaSporProyecto.aspx?proyecto=" + rcmbProyecto.SelectedValue.ToString + "&componente=" + idComponente.ToString + "&actividad=" + idActividad.ToString + "&ccosto=" + idccosto.ToString + "&moneda=" + rcmbMoneda.SelectedValue.ToString + "&fechaIni=" + Me.rdpFechaInicio.SelectedDate.ToString + "&fechaFin=" + Me.rdpFechaFin.SelectedDate.ToString + "','','width=1000, height=700'); " & _
                                     Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

    Protected Sub rcmbComponente_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcmbComponente.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProyComp))._Componente.Nombre.ToString
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.ProyComp)).IdComponente
    End Sub
End Class