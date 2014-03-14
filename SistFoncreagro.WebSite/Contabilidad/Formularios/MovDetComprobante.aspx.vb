Imports SistFoncreagro.BussinesLogic
Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.IO

Public Class MovDetComprobante
    Inherits System.Web.UI.Page
    Dim Fecha As String
    Dim Proyecto As String
    Dim Cuenta As String
    Dim Codigo As String
    Dim SubDiario As String
    Dim Total1 As Decimal
    Dim Total2 As Decimal
    Dim Total3 As Decimal
    Dim Total4 As Decimal
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Fecha = Request.QueryString("Fecha")
        Proyecto = Request.QueryString("Proyecto")
        Cuenta = Request.QueryString("Cuenta")
        Codigo = Request.QueryString("Codigo")
        SubDiario = Request.QueryString("SubDiario")

        Me.Page.Title = "Movimiento detallado del Comprobante " + Codigo.ToString
    End Sub

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Total1 += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "CargoMN"))
            Total2 += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "AbonoMN"))
            Total3 += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "CargoME"))
            Total4 += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "AbonoME"))
        End If

        If e.Row.RowType = DataControlRowType.Footer Then
            e.Row.Cells(6).Text = "Total:"
            e.Row.Cells(7).Text = "S/. " + String.Format("{0:0,0.00}", Total1)
            e.Row.Cells(7).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(8).Text = "S/. " + String.Format("{0:0,0.00}", Total2)
            e.Row.Cells(8).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(9).Text = "$. " + String.Format("{0:0,0.00}", Total3)
            e.Row.Cells(9).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(10).Text = "$. " + String.Format("{0:0,0.00}", Total4)
            e.Row.Cells(10).HorizontalAlign = HorizontalAlign.Right
            e.Row.Font.Bold = True
        End If
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
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
        Response.AddHeader("Content-Disposition", "attachment;filename=data.xls")
        Response.Charset = "UTF-8"

        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()
    End Sub
End Class