Public Class FrmReporte
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rdFechas.Attributes.Add("onClick", "habilitar();")
        rbTodo.Attributes.Add("onClick", "habilitar();")
    End Sub

    Protected Sub btnReporte_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReporte.Click
        Dim adapter As New Data.SqlClient.SqlDataAdapter
        Dim connection As New Data.SqlClient.SqlConnection
        Dim command As New Data.SqlClient.SqlCommand
        adapter.SelectCommand = command
        Dim dtset As New Data.DataSet
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        connection.ConnectionString = CType(configurationAppSettings.GetValue("cnxRep", GetType(System.String)), String)
        command.Connection = connection
        adapter.SelectCommand = command

        command.CommandText = "rReporteRequerimientosRechazados"
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FechaInicial", CDate(txtFechaInicio.Text))
        command.Parameters.AddWithValue("@FechaFinal", CDate(txtFechaFin.Text))
        dtset.Tables.Clear()
        adapter.Fill(dtset)

        Dim sBuilder As New System.Text.StringBuilder()
        Dim i, ii As Integer
        sBuilder.Append("<table border='1'> <tr> <th scope='col' colspan='8'>REQUERIMIENTOS RECHAZADOS<br /></th></tr><tr><th scope='col'>AREA</th><th scope='col'>NUMERO</th><th scope='col'>ESTADO</th><th scope='col'>REQUERIDO POR</th><th scope='col'>RECHAZADO POR</th><th scope='col'>FECHA</th><th scope='col'>MOTIVO</th><th scope='col'>DETALLE APROBACION</th></tr>")
        For i = 0 To dtset.Tables(0).Rows.Count - 1
            sBuilder.Append("<tr>")
            For ii = 0 To dtset.Tables(0).Columns.Count - 1
                sBuilder.Append("<td>")
                sBuilder.Append(dtset.Tables(0).Rows(i).Item(ii).ToString)
                sBuilder.Append("</td>")
            Next
            sBuilder.Append("</tr>")
        Next
        sBuilder.Append("</table>")

        Response.ClearContent()
        Response.AddHeader("content-disposition", "attachment; filename=ReqRechazados.xls")
        Response.ContentType = "application/ms-excel"
        Response.Write(sBuilder.ToString())
        Response.End()
        Response.Close()
    End Sub
End Class