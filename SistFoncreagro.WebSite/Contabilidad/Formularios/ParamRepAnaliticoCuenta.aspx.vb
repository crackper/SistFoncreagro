Imports System.IO
Imports System.Data.SqlClient

Public Class ParamRepAnaliticoCuenta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox10.Filter = 1
        Me.RadComboBox11.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox9.Filter = 1
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse("01/" + Session("Mes").ToString + "/" + Session("Anio").ToString)
            Me.RadDatePicker2.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim ProyectoInicio As String = " "
        Dim CCostoInicio As String = " "
        Dim CuentaInicio As String = " "
        Dim ProyectoFin As String = " "
        Dim CCostoFin As String = " "
        Dim CuentaFin As String = " "

        If Me.RadComboBox9.SelectedValue.Length > 0 Then
            ProyectoInicio = Me.RadComboBox9.SelectedValue
        End If
        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            ProyectoFin = Me.RadComboBox3.SelectedValue
        End If
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            CCostoInicio = Me.RadComboBox2.SelectedValue
        End If
        If Me.RadComboBox10.SelectedValue.Length > 0 Then
            CCostoFin = Me.RadComboBox10.SelectedValue
        End If
        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            CuentaInicio = Me.RadComboBox1.SelectedValue
        End If
        If Me.RadComboBox11.SelectedValue.Length > 0 Then
            CuentaFin = Me.RadComboBox11.SelectedValue
        End If

        Me.SqlDatos.SelectParameters("ProyectoInicio").DefaultValue = ProyectoInicio
        Me.SqlDatos.SelectParameters("ProyectoFin").DefaultValue = ProyectoFin
        Me.SqlDatos.SelectParameters("CCostoInicio").DefaultValue = CCostoInicio
        Me.SqlDatos.SelectParameters("CCostoFin").DefaultValue = CCostoFin
        Me.SqlDatos.SelectParameters("CuentaInicio").DefaultValue = CuentaInicio
        Me.SqlDatos.SelectParameters("CuentaFin").DefaultValue = CuentaFin
        Me.SqlDatos.SelectParameters("FechaInicio").DefaultValue = Me.RadDatePicker1.SelectedDate
        Me.SqlDatos.SelectParameters("FechaFin").DefaultValue = Me.RadDatePicker2.SelectedDate
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
        Response.AddHeader("Content-Disposition", "attachment;filename=ReporteAnaliticoPorCuenta.xls")
        Response.Charset = "UTF-8"

        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()



        'ExportToExcel(SqlDatos, "StudentMarks")

    End Sub
    Public Sub ExportToExcel(ByVal dataSrc As SqlDataSource, ByVal fileName As String)
        Dim ProyectoInicio As String = " "
        Dim CCostoInicio As String = " "
        Dim CuentaInicio As String = " "
        Dim ProyectoFin As String = " "
        Dim CCostoFin As String = " "
        Dim CuentaFin As String = " "

        If Me.RadComboBox9.SelectedValue.Length > 0 Then
            ProyectoInicio = Me.RadComboBox9.SelectedValue
        End If
        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            ProyectoFin = Me.RadComboBox3.SelectedValue
        End If
        If Me.RadComboBox2.SelectedValue.Length > 0 Then
            CCostoInicio = Me.RadComboBox2.SelectedValue
        End If
        If Me.RadComboBox10.SelectedValue.Length > 0 Then
            CCostoFin = Me.RadComboBox10.SelectedValue
        End If
        If Me.RadComboBox1.SelectedValue.Length > 0 Then
            CuentaInicio = Me.RadComboBox1.SelectedValue
        End If
        If Me.RadComboBox11.SelectedValue.Length > 0 Then
            CuentaFin = Me.RadComboBox11.SelectedValue
        End If

        Me.SqlDatos.SelectParameters("ProyectoInicio").DefaultValue = ProyectoInicio
        Me.SqlDatos.SelectParameters("ProyectoFin").DefaultValue = ProyectoFin
        Me.SqlDatos.SelectParameters("CCostoInicio").DefaultValue = CCostoInicio
        Me.SqlDatos.SelectParameters("CCostoFin").DefaultValue = CCostoFin
        Me.SqlDatos.SelectParameters("CuentaInicio").DefaultValue = CuentaInicio
        Me.SqlDatos.SelectParameters("CuentaFin").DefaultValue = CuentaFin
        Me.SqlDatos.SelectParameters("FechaInicio").DefaultValue = Me.RadDatePicker1.SelectedDate
        Me.SqlDatos.SelectParameters("FechaFin").DefaultValue = Me.RadDatePicker2.SelectedDate
        Me.GridView1.DataSourceID = "SqlDatos"
        Me.GridView1.DataBind()

        'Add Response header 
        Response.Clear()
        Response.AddHeader("content-disposition", String.Format("attachment;filename={0}.csv", fileName))
        Response.Charset = ""
        Response.ContentType = "application/vnd.xls"
        'GET Data From Database                
        Dim cn As New SqlConnection(dataSrc.ConnectionString)


        dataSrc.SelectParameters("ProyectoInicio").DefaultValue = ProyectoInicio
        dataSrc.SelectParameters("ProyectoFin").DefaultValue = ProyectoFin
        dataSrc.SelectParameters("CCostoInicio").DefaultValue = CCostoInicio
        dataSrc.SelectParameters("CCostoFin").DefaultValue = CCostoFin
        dataSrc.SelectParameters("CuentaInicio").DefaultValue = CuentaInicio
        dataSrc.SelectParameters("CuentaFin").DefaultValue = CuentaFin
        dataSrc.SelectParameters("FechaInicio").DefaultValue = Me.RadDatePicker1.SelectedDate
        dataSrc.SelectParameters("FechaFin").DefaultValue = Me.RadDatePicker2.SelectedDate
       

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

    Protected Sub RadComboBox9_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox9.SelectedIndexChanged
        Me.RadComboBox3.Text = ""
        Me.RadComboBox3.SelectedValue = Me.RadComboBox9.SelectedValue
        Me.RadComboBox3.Text = Me.RadComboBox9.Text
    End Sub

    Protected Sub RadComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox2.SelectedIndexChanged
        Me.RadComboBox10.Text = ""
        Me.RadComboBox10.SelectedValue = Me.RadComboBox2.SelectedValue
        Me.RadComboBox10.Text = Me.RadComboBox2.Text
    End Sub

    Protected Sub RadComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        Me.RadComboBox11.Text = ""
        Me.RadComboBox11.SelectedValue = Me.RadComboBox1.SelectedValue
        Me.RadComboBox11.Text = Me.RadComboBox1.Text
    End Sub
End Class