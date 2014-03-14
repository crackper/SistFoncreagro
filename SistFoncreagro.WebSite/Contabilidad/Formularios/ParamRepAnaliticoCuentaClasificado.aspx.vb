Imports System.IO
Public Class ParamRepAnaliticoCuentaClasificado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
       
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.SqlDatos.SelectParameters("FechaInicio").DefaultValue = Me.RadDatePicker1.SelectedDate
        Me.SqlDatos.SelectParameters("FechaFin").DefaultValue = Me.RadDatePicker2.SelectedDate
        Me.SqlDatos.SelectParameters("tipo").DefaultValue = Me.RadComboBox1.SelectedValue
        Me.GridView1.DataSourceID = "SqlDatos"
        Me.GridView1.DataBind()

        Dim sb As StringBuilder = New StringBuilder()
        Dim sw As StringWriter = New StringWriter(sb)
        Dim htw As HtmlTextWriter = New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim nombreArchivo As String

        nombreArchivo = "ReporteAnalitico" + Me.RadComboBox1.SelectedValue.ToString + ".xls"
        GridView1.EnableViewState = False
        pagina.EnableEventValidation = False
        pagina.DesignerInitialize()
        pagina.Controls.Add(form)
        form.Controls.Add(GridView1)
        pagina.RenderControl(htw)
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=" + nombreArchivo)
        Response.Charset = "UTF-8"

        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()

    End Sub
End Class