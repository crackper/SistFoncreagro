﻿Imports System.IO
Imports System.Data.SqlClient
Imports System
Imports System.Configuration
Imports System.Data
Imports Telerik.Web.UI
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Data.OleDb
Public Class ExcelStakeholder
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       Me.SqlDatos.SelectParameters("IdProyecto").DefaultValue = Session("IdProyecto")

        Me.GridView1.DataSourceID = "SqlDatos"
        Me.GridView1.DataBind()

        Dim sb As StringBuilder = New StringBuilder()
        Dim sw As StringWriter = New StringWriter(sb)
        Dim htw As HtmlTextWriter = New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        GridView1.EnableViewState = False
        pagina.EnableEventValidation = False
        pagina.DesignerInitialize()
        pagina.Controls.Add(form)
        form.Controls.Add(GridView1)
        pagina.RenderControl(htw)
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=ReporteStakeholders.xls")
        Response.Charset = "UTF-8"

        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()

    End Sub

    Public Sub ExportToExcel(ByVal dataSrc As SqlDataSource, ByVal fileName As String)
        Me.SqlDatos.SelectParameters("IdProyecto").DefaultValue = Session("IdProyecto")
      
        Me.GridView1.DataSourceID = "SqlDatos"
        Me.GridView1.DataBind()

        'Add Response header 
        Response.Clear()
        Response.AddHeader("content-disposition", String.Format("attachment;filename={0}.csv", fileName))
        Response.Charset = ""
        Response.ContentType = "application/vnd.xls"
        'GET Data From Database                
        Dim cn As New SqlConnection(dataSrc.ConnectionString)


        dataSrc.SelectParameters("IdProyecto").DefaultValue = Session("IdProyecto")

        Dim query As String = dataSrc.SelectCommand.Replace(vbCr & vbLf, " ").Replace(vbTab, " ")
        Dim cmd As New SqlCommand(query, cn)



        cmd.CommandTimeout = 999999
        cmd.CommandType = CommandType.Text
        Try
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim sb As New StringBuilder()
            'Add Header          
            For count As Integer = 0 To dr.FieldCount - 1
                If dr.GetName(count) IsNot Nothing Then
                    sb.Append(dr.GetName(count))
                End If
                If count < dr.FieldCount - 1 Then
                    sb.Append(",")
                End If
            Next
            Response.Write(sb.ToString() & vbLf)
            Response.Flush()
            'Append Data
            While dr.Read()
                sb = New StringBuilder()

                For col As Integer = 0 To dr.FieldCount - 2
                    If Not dr.IsDBNull(col) Then
                        sb.Append(dr.GetValue(col).ToString().Replace(",", " "))
                    End If
                    sb.Append(",")
                Next
                If Not dr.IsDBNull(dr.FieldCount - 1) Then
                    sb.Append(dr.GetValue(dr.FieldCount - 1).ToString().Replace(",", " "))
                End If
                Response.Write(sb.ToString() & vbLf)
                Response.Flush()
            End While
            dr.Dispose()
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            cmd.Connection.Close()
            cn.Close()
        End Try
        Response.[End]()
    End Sub

    Protected Sub GridView1_DataBound(sender As Object, e As EventArgs) Handles GridView1.DataBound
        For i = 0 To Me.GridView1.Rows.Count - 1
            If (Me.GridView1.Rows(i).Cells(6).Text = "APOYO TOTAL") Then
                Me.GridView1.Rows(i).Cells(6).BackColor = Drawing.Color.Green
                Me.GridView1.Rows(i).Cells(6).Text = "AT"
            ElseIf (Me.GridView1.Rows(i).Cells(6).Text = "APOYO MODERADO") Then
                Me.GridView1.Rows(i).Cells(6).BackColor = Drawing.Color.Blue
                Me.GridView1.Rows(i).Cells(6).Text = "AM"
            ElseIf (Me.GridView1.Rows(i).Cells(6).Text = "NEUTRAL") Then
                Me.GridView1.Rows(i).Cells(6).BackColor = Drawing.Color.Yellow
                Me.GridView1.Rows(i).Cells(6).Text = "N"
            ElseIf (Me.GridView1.Rows(i).Cells(6).Text = "OPOSICION MODERADA") Then
                Me.GridView1.Rows(i).Cells(6).BackColor = Drawing.Color.Orange
                Me.GridView1.Rows(i).Cells(6).Text = "OM"
            ElseIf (Me.GridView1.Rows(i).Cells(6).Text = "OPOSICION RADICAL") Then
                Me.GridView1.Rows(i).Cells(6).BackColor = Drawing.Color.Red
                Me.GridView1.Rows(i).Cells(6).Text = "OR"
            ElseIf (Me.GridView1.Rows(i).Cells(6).Text = "SIN DETERMINAR") Then
                Me.GridView1.Rows(i).Cells(6).Text = ""
            End If
        Next
    End Sub
End Class