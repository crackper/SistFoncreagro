Public Class ParamRepComprasSunat
    Inherits System.Web.UI.Page
    Dim MesCompleto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
        Select Case Session("Mes")
            Case 1
                MesCompleto = "01"
            Case 2
                MesCompleto = "02"
            Case 3
                MesCompleto = "03"
            Case 4
                MesCompleto = "04"
            Case 5
                MesCompleto = "05"
            Case 6
                MesCompleto = "06"
            Case 7
                MesCompleto = "07"
            Case 8
                MesCompleto = "08"
            Case 9
                MesCompleto = "09"
            Case 10
                MesCompleto = "10"
            Case 11
                MesCompleto = "11"
            Case 12
                MesCompleto = "12"
        End Select
    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName Then
            ConfigureExport()
        ElseIf e.CommandName = Telerik.Web.UI.RadGrid.ExportToCsvCommandName Then
            Dim str As New StringBuilder()
            Dim nombre As String
            nombre = "LE20453262767" + Session("Anio").ToString + MesCompleto + "00080100001111.TXT"

            For i As Integer = 0 To Me.RadGrid1.Items.Count - 1

                For j As Integer = 2 To RadGrid1.Items(i).Cells.Count - 1

                    str.Append(RadGrid1.Items(i).Cells(j).Text & "|")
                    str.Replace("&nbsp;", "")

                Next
                ' final de linea
                ' str.Append("|")
                str.Append(vbCr & vbLf)

            Next
            ' Output the text file to the stream
            Response.ClearContent() 'Borra toda la salida de contenido de la secuencia del búfer. 
            Response.ClearHeaders() 'Borra todos los encabezados de la secuencia del búfer. 
            Response.ContentType = "text/plain" ' TXT
            Response.AddHeader("content-disposition", "attachment;filename=" + nombre)
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            Dim stringWrite As New System.IO.StringWriter()
            Dim htmlWrite As System.Web.UI.HtmlTextWriter = New HtmlTextWriter(stringWrite)
            Response.Write(str.ToString())
            Response.[End]()
        End If
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim str As New StringBuilder()
        Dim nombre As String
        nombre = "LE20453262767" + Session("Anio").ToString + MesCompleto + "00080100001111.TXT"

        For i As Integer = 0 To Me.RadGrid1.Items.Count - 1

            For j As Integer = 2 To RadGrid1.Items(i).Cells.Count - 1

                str.Append(RadGrid1.Items(i).Cells(j).Text & "|")
                str.Replace("&nbsp;", "")

            Next
            ' final de linea
            ' str.Append("|")
            str.Append(vbCr & vbLf)

        Next
        ' Output the text file to the stream
        Response.ClearContent() 'Borra toda la salida de contenido de la secuencia del búfer. 
        Response.ClearHeaders() 'Borra todos los encabezados de la secuencia del búfer. 
        Response.ContentType = "text/plain" ' TXT
        Response.AddHeader("content-disposition", "attachment;filename=" + nombre)
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Dim stringWrite As New System.IO.StringWriter()
        Dim htmlWrite As System.Web.UI.HtmlTextWriter = New HtmlTextWriter(stringWrite)
        Response.Write(str.ToString())
        Response.[End]()
    End Sub

    Protected Sub RadGrid1_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.DataBound
        For i = 0 To Me.RadGrid1.Items.Count - 1
            Me.RadGrid1.Items.Item(i)("codigo").Text = Me.RadGrid1.Items.Item(i)("codigo").Text & "-" & (i + 1).ToString
        Next
    End Sub
End Class