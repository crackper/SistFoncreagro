Imports SistFoncreagro.BussinesLogic
Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.IO
Public Class FrmGenerarDAOT
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'para obtener el valor de la UIT
        Dim UIT As Decimal
        Dim ParametroBL As New ParametrosBL

        UIT = ParametroBL.GetPARAMETROSByNombre("UIT").valor
        Me.RadNumericTextBox2.Text = UIT
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
            If Me.HiddenField1.Value = "C" Then
                nombre = "Costos.txt"
            Else
                nombre = "Ingresos.txt"
            End If

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
    Protected Sub RadButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton1.Click
        Me.RadGrid1.DataSourceID = "Costos"
        Me.Costos.SelectParameters("monto").DefaultValue = Me.RadNumericTextBox2.Text * Me.RadNumericTextBox3.Text
        Me.Costos.SelectParameters("anio").DefaultValue = Session("Anio")
        Me.HiddenField1.Value = "C"
        Me.RadGrid1.DataBind()
    End Sub
    Protected Sub RadButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton2.Click
        Me.RadGrid1.DataSourceID = "Ingresos"
        Me.Ingresos.SelectParameters("monto").DefaultValue = Me.RadNumericTextBox2.Text * Me.RadNumericTextBox3.Text
        Me.Ingresos.SelectParameters("anio").DefaultValue = Session("Anio")
        Me.HiddenField1.Value = "I"
        Me.RadGrid1.DataBind()
    End Sub
    '    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
    '        Dim str As New StringBuilder()
    '        Dim nombre As String
    '        If Me.HiddenField1.Value = "C" Then
    '            nombre = "Costos.txt"
    '        Else
    '            nombre = "Ingresos.txt"
    '        End If

    '        For i As Integer = 0 To Me.RadGrid1.Items.Count - 1

    '            For j As Integer = 0 To RadGrid1.Items(i).Cells.Count - 1

    '                str.Append(RadGrid1.Items(i).Cells(j).Text & "|")
    '                str.Replace("&nbsp;", "")

    '            Next
    '            ' final de linea
    '            str.Append("|")
    '            str.Append(vbCr & vbLf)

    '        Next
    '        ' Output the text file to the stream
    '        Response.ClearContent() 'Borra toda la salida de contenido de la secuencia del búfer. 
    '        Response.ClearHeaders() 'Borra todos los encabezados de la secuencia del búfer. 
    '        Response.ContentType = "text/plain" ' TXT
    '        Response.AddHeader("content-disposition", "attachment;filename=" + nombre)
    '        Response.Cache.SetCacheability(HttpCacheability.NoCache)
    '        Dim stringWrite As New System.IO.StringWriter()
    '        Dim htmlWrite As System.Web.UI.HtmlTextWriter = New HtmlTextWriter(stringWrite)
    '        Response.Write(str.ToString())
    '        Response.[End]()



    '        'Dim str As New StringBuilder()
    '        'Dim nombre As String
    '        'If Me.HiddenField1.Value = "C" Then
    '        '    nombre = "Costos.txt"
    '        'Else
    '        '    nombre = "Ingresos.txt"
    '        'End If

    '        'For i As Integer = 0 To Me.GridView1.Rows.Count - 1

    '        '    For j As Integer = 0 To GridView1.Rows(i).Cells.Count - 1

    '        '        str.Append(GridView1.Rows(i).Cells(j).Text & "|")
    '        '        str.Replace("&nbsp;", "")
    '        '        str.Replace("&#209;", "Ñ")
    '        '    Next
    '        '    ' final de linea
    '        '    str.Append("|")
    '        '    str.Append(vbCr & vbLf)

    '        'Next
    '        '' Output the text file to the stream
    '        'Response.ClearContent() 'Borra toda la salida de contenido de la secuencia del búfer. 
    '        'Response.ClearHeaders() 'Borra todos los encabezados de la secuencia del búfer. 
    '        'Response.ContentType = "text/plain" ' TXT
    '        'Response.AddHeader("content-disposition", "attachment;filename=" + nombre)
    '        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
    '        'Dim stringWrite As New System.IO.StringWriter()
    '        'Dim htmlWrite As System.Web.UI.HtmlTextWriter = New HtmlTextWriter(stringWrite)
    '        'Response.Write(str.ToString())
    '        'Response.[End]()

    '        'Dim nR As Random = New Random
    '        'Dim rutaDestino As String = "D:\Foncreagro\PDT\" 'Obtiene la ruta absoluta de la carpeta REM.
    '        'Dim archivoDestino As String = ""
    '        'archivoDestino = "T" & nR.Next(10000, 100000) & ".txt" 'Establece un Nombre Temporal del archivo de texto de destino. 

    '        'rutaDestino &= archivoDestino 'Se completa la ruta del archivo de destino con el nombre creado.

    '        'Dim errProc As String = ""

    '        'Try
    '        '    Dim archivo As New StreamWriter(rutaDestino)

    '        '    Dim Linea As String = ""

    '        '    For cR = 0 To Me.RadGrid1.Items.Count - 1
    '        '        Dim item As GridItem = Me.RadGrid1.MasterTableView.Items(cR)
    '        '        Linea = TryCast(item, GridDataItem)("RazonSocial").Text.ToString.Replace("&nbsp;", "")
    '        '        If Linea.Length > 0 Then
    '        '            Linea = "0" & Linea
    '        '            Linea += (CInt(CDec(TryCast(item, GridDataItem)("Monto").Text) * 100)).ToString.PadLeft(15, "0")
    '        '            archivo.WriteLine(Linea)
    '        '        End If
    '        '    Next
    '        '    archivo.Close()

    '        'Catch ex As Exception
    '        '    errProc = ex.Message

    '        'Finally

    '        '    If errProc.Length > 0 Then
    '        '        Session("EXPORTA_error") = errProc
    '        '    Else
    '        '        Response.ClearContent() 'Borra toda la salida de contenido de la secuencia del búfer. 
    '        '        Response.ClearHeaders() 'Borra todos los encabezados de la secuencia del búfer. 
    '        '        Response.ContentType = "text/plain" ' TXT
    '        '        Response.AppendHeader("Content-Disposition", "attachment; filename=" + archivoDestino)
    '        '        Response.WriteFile(rutaDestino) 'Escribe el archivo especificado directamente en la secuencia de salida de una respuesta HTTP.
    '        '        Response.Flush()
    '        '        Response.Close()
    '        '    End If

    '        '    File.Delete(rutaDestino) 'Borra físicamente el Archivo de TXT Generado.

    '        'End Try
    '    End Sub
End Class

'Protected Sub btnExportaTxt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportaTxt.Click
'    Dim nR As Random = New Random
'    Dim rutaDestino As String = Server.MapPath(SIGA_DocsRem) 'Obtiene la ruta absoluta de la carpeta REM.
'    Dim archivoDestino As String = ""
'    archivoDestino = "T" & nR.Next(10000, 100000) & ".txt" 'Establece un Nombre Temporal del archivo de texto de destino. 

'    rutaDestino &= archivoDestino 'Se completa la ruta del archivo de destino con el nombre creado.

'    Dim errProc As String = ""

'    Try
'        Dim archivo As New StreamWriter(rutaDestino)

'        Dim Linea As String = ""

'        For cR = 0 To ListaAbonos.Items.Count - 1
'            Dim item As GridItem = ListaAbonos.MasterTableView.Items(cR)
'            Linea = TryCast(item, GridDataItem)("cuenta").Text.ToString.Replace("&nbsp;", "")
'            If Linea.Length > 0 Then
'                Linea = "0" & Linea
'                Linea += (CInt(CDec(TryCast(item, GridDataItem)("importe").Text) * 100)).ToString.PadLeft(15, "0")
'                archivo.WriteLine(Linea)
'            End If
'        Next
'        archivo.Close()

'    Catch ex As Exception
'        errProc = ex.Message

'    Finally

'        If errProc.Length > 0 Then
'            Session("EXPORTA_error") = errProc
'        Else
'            Response.ClearContent() 'Borra toda la salida de contenido de la secuencia del búfer. 
'            Response.ClearHeaders() 'Borra todos los encabezados de la secuencia del búfer. 
'            Response.ContentType = "text/plain" ' TXT
'            Response.AppendHeader("Content-Disposition", "attachment; filename=" + archivoDestino)
'            Response.WriteFile(rutaDestino) 'Escribe el archivo especificado directamente en la secuencia de salida de una respuesta HTTP.
'            Response.Flush()
'            Response.Close()
'        End If

'        File.Delete(rutaDestino) 'Borra físicamente el Archivo de TXT Generado.

'    End Try
'End Sub