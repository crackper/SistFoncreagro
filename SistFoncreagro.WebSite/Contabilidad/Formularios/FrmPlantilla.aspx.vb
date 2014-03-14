Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.IO
Imports System.Data.SqlClient
Public Class FrmPlantilla
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
        Me.RadComboBox3.Filter = 1
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim idProyecto As Int32 = 0

        If Me.RadComboBox3.SelectedValue.Length > 0 Then
            idProyecto = Me.RadComboBox3.SelectedValue
        End If

        Me.RadGrid1.DataSourceID = "sqlNivelTitulo"
        Me.sqlNivelTitulo.SelectParameters("Fecha").DefaultValue = Me.RadDatePicker1.SelectedDate
        Me.sqlNivelTitulo.SelectParameters("IdProyecto").DefaultValue = idProyecto
        Me.sqlNivelTitulo.SelectParameters("IdMoneda").DefaultValue = Me.RadioButtonList2.SelectedValue
        Me.RadGrid1.DataBind()

        Me.RadGrid2.DataSourceID = "sqlDetalle"
        Me.sqlDetalle.SelectParameters("Fecha").DefaultValue = Me.RadDatePicker1.SelectedDate
        Me.sqlDetalle.SelectParameters("IdProyecto").DefaultValue = idProyecto
        Me.sqlDetalle.SelectParameters("IdMoneda").DefaultValue = Me.RadioButtonList2.SelectedValue
        Me.RadGrid2.DataBind()

        ExportarAbonoExcel()
    End Sub
    Private Function myconnectionstring(ByVal extension As String) As String  'Devuelve la cadena de conexión de la Hoja de Excel según la Extensión 
        Dim retorno As String = ""
        Select Case extension
            Case ".xls"
                retorno = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=Yes;"";"
            Case ".xlsx"
                retorno = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0 Xml"
            Case ".dbf"
                retorno = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE IV;user id=Admin"
        End Select
        Return retorno
    End Function

    Protected Sub ExportarAbonoExcel()
        Dim nR As Random = New Random
        Dim rutaOrigen As String = ""
        Dim rutaDestino As String = Server.MapPath("~\Plantillas") 'Obtiene la ruta absoluta de la carpeta. 
        Dim archivoDestino As String = ""
        Dim conOle As New OleDbConnection
        Dim adaole As New OleDbDataAdapter
        Dim adaole1 As New OleDbDataAdapter

        rutaOrigen = Server.MapPath("~\Plantillas\PlantillaEstadosFinancieros.xls") 'Obtiene la ruta absoluta de la Plantilla
        archivoDestino = "AN" & nR.Next(10000, 100000) & ".xls"  'Establece un Nombre Temporal del archivo de excel de destino. 


        rutaDestino &= "\" + archivoDestino 'Se completa la ruta del archivo de destino con el nombre creado.
        File.Copy(rutaOrigen, rutaDestino, True) 'Se copia el archivo plantilla a la carpeta de Destino con el nombre previamente establecido.

        conOle.ConnectionString = String.Format(myconnectionstring(IO.Path.GetExtension(rutaDestino)), rutaDestino)


        'PARA INSERTAR EN LA PRIMERA HOJA DE EXCEL
        adaole.InsertCommand = conOle.CreateCommand

        With adaole.InsertCommand.Parameters

            adaole.InsertCommand.CommandText = "Insert Into [BC$] (Cuenta,Descripcion,Debe,Haber,Deudor,Acreedor,Activo,Pasivo,PerdidaNat,GananciaNat,PerdidaFun,GananciaFun) values (@Cuenta,@Descripcion,@Debe,@Haber,@Deudor,@Acreedor,@Activo,@Pasivo,@PerdidaNat,@GananciaNat,@PerdidaFun,@GananciaFun)"
            adaole.InsertCommand.CommandType = CommandType.Text

            .Add("@Cuenta", OleDb.OleDbType.VarChar, 200, "Cuenta")
            .Add("@Descripcion", OleDb.OleDbType.VarChar, 200, "Descripcion")
            .Add("@Debe", OleDb.OleDbType.Decimal, 12.2, "Debe")
            .Add("@Haber", OleDb.OleDbType.Decimal, 12.2, "Haber")
            .Add("@Deudor", OleDb.OleDbType.Decimal, 12.2, "Deudor")
            .Add("@Acreedor", OleDb.OleDbType.Decimal, 12.2, "Acreedor")
            .Add("@Activo", OleDb.OleDbType.Decimal, 12.2, "Activo")
            .Add("@Pasivo", OleDb.OleDbType.Decimal, 12.2, "Pasivo")
            .Add("@PerdidaNat", OleDb.OleDbType.Decimal, 12.2, "PerdidaNat")
            .Add("@GananciaNat", OleDb.OleDbType.Decimal, 12.2, "GananciaNat")
            .Add("@PerdidaFun", OleDb.OleDbType.Decimal, 12.2, "PerdidaFun")
            .Add("@GananciaFun", OleDb.OleDbType.Decimal, 12.2, "GananciaFun")

        End With

        'PARA INSERTAR EN LA SEGUNDA HOJA DE EXCEL
        adaole1.InsertCommand = conOle.CreateCommand

        With adaole1.InsertCommand.Parameters

            adaole1.InsertCommand.CommandText = "Insert Into [BCANUAL$] (Cuenta,Descripcion,Debe,Haber,Deudor,Acreedor,Activo,Pasivo,PerdidaNat,GananciaNat,PerdidaFun,GananciaFun) values (@Cuenta1,@Descripcion1,@Debe1,@Haber1,@Deudor1,@Acreedor1,@Activo1,@Pasivo1,@PerdidaNat,@GananciaNat,@PerdidaFun1,@GananciaFun1)"
            adaole1.InsertCommand.CommandType = CommandType.Text

            .Add("@Cuenta1", OleDb.OleDbType.VarChar, 200, "Cuenta")
            .Add("@Descripcion1", OleDb.OleDbType.VarChar, 200, "Descripcion")
            .Add("@Debe1", OleDb.OleDbType.Decimal, 12.2, "Debe")
            .Add("@Haber1", OleDb.OleDbType.Decimal, 12.2, "Haber")
            .Add("@Deudor1", OleDb.OleDbType.Decimal, 12.2, "Deudor")
            .Add("@Acreedor1", OleDb.OleDbType.Decimal, 12.2, "Acreedor")
            .Add("@Activo1", OleDb.OleDbType.Decimal, 12.2, "Activo")
            .Add("@Pasivo1", OleDb.OleDbType.Decimal, 12.2, "Pasivo")
            .Add("@PerdidaNat1", OleDb.OleDbType.Decimal, 12.2, "PerdidaNat")
            .Add("@GananciaNat1", OleDb.OleDbType.Decimal, 12.2, "GananciaNat")
            .Add("@PerdidaFun1", OleDb.OleDbType.Decimal, 12.2, "PerdidaFun")
            .Add("@GananciaFun1", OleDb.OleDbType.Decimal, 12.2, "GananciaFun")

        End With

        Dim errProc As String = ""

        Try
            conOle.Open() 'Abre la conexión con el nuevo archivo de Excel copiado. 
            adaole.Update(GetAbono("Excel")) 'Se Actualiza los Datos que son almacenado en el DataTable, que son devueltos
            adaole1.Update(GetAbono1("Excel")) 'Se Actualiza los Datos que son almacenado en el DataTable, que son devueltos
        Catch ex As Exception
            errProc = ex.Message

        Finally
            conOle.Close() 'Cierra la conexión con el nuevo archivo de Excel procesado. 

            If errProc.Length > 0 Then
                Session("EXPORTA_error") = errProc
            Else
                Response.ClearContent() 'Borra toda la salida de contenido de la secuencia del búfer. 
                Response.ClearHeaders() 'Borra todos los encabezados de la secuencia del búfer. 
                Select Case Path.GetExtension(rutaDestino)
                    Case ".xls"
                        Response.ContentType = "application/vnd.ms-excel" 'Excel 2003
                    Case ".xlsx"
                        Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" 'Excel 2007 
                End Select
                Response.WriteFile(rutaDestino) 'Escribe el archivo especificado directamente en la secuencia de salida de una respuesta HTTP.
                Response.Flush() 'Envía al cliente toda la salida almacenada en el búfer 
                Response.Close() 'Cierra la conexión del socket con un cliente
            End If

            File.Delete(rutaDestino) 'Borra físicamente el Archivo de Excel Generado.

        End Try
        'Dim OExcel As Object
        'Dim Hoja As Object
        'Dim o_Rango As Object

        'OExcel.Workbooks.Open(FileName:=rutaDestino)
        '' Referencia a la hoja que se va a Exportar
        'Hoja = OExcel.ActiveWorkbook.Sheets(1)
        '' Referencia al rango de datos
        'o_Rango = Hoja.Range("A3:L200")

    End Sub

    Function GetAbono(ByVal Para As String) As DataTable ' Devuelve un DataTable Temporal con Datos de prueba. 
        Dim temp As New DataTable
        Dim OrdenInicio As Integer = 0

        temp.Columns.Add("Cuenta", System.Type.GetType("System.String"))
        temp.Columns("Cuenta").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        temp.Columns("Descripcion").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Debe", System.Type.GetType("System.Decimal"))
        temp.Columns("Debe").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Haber", System.Type.GetType("System.Decimal"))
        temp.Columns("Haber").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Deudor", System.Type.GetType("System.Decimal"))
        temp.Columns("Deudor").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Acreedor", System.Type.GetType("System.Decimal"))
        temp.Columns("Acreedor").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Activo", System.Type.GetType("System.Decimal"))
        temp.Columns("Activo").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Pasivo", System.Type.GetType("System.Decimal"))
        temp.Columns("Pasivo").SetOrdinal(OrdenInicio)
        temp.Columns.Add("PerdidaNat", System.Type.GetType("System.Decimal"))
        temp.Columns("PerdidaNat").SetOrdinal(OrdenInicio)
        temp.Columns.Add("GananciaNat", System.Type.GetType("System.Decimal"))
        temp.Columns("GananciaNat").SetOrdinal(OrdenInicio)
        temp.Columns.Add("PerdidaFun", System.Type.GetType("System.Decimal"))
        temp.Columns("PerdidaFun").SetOrdinal(OrdenInicio)
        temp.Columns.Add("GananciaFun", System.Type.GetType("System.Decimal"))
        temp.Columns("GananciaFun").SetOrdinal(OrdenInicio)

        For cR = 0 To Me.RadGrid2.Items.Count - 1
            Dim nuevo As DataRow = temp.NewRow()
            Dim item As GridItem = RadGrid2.MasterTableView.Items(cR)

            nuevo("Cuenta") = TryCast(item, GridDataItem)("Codigo").Text.ToString
            nuevo("Descripcion") = TryCast(item, GridDataItem)("Descripcion").Text.ToString
            nuevo("Debe") = TryCast(item, GridDataItem)("DebeMN").Text.ToString
            nuevo("Haber") = TryCast(item, GridDataItem)("HaberMN").Text.ToString
            nuevo("Deudor") = TryCast(item, GridDataItem)("SaldoDeudor").Text.ToString
            nuevo("Acreedor") = TryCast(item, GridDataItem)("SaldoAcreedor").Text.ToString
            nuevo("Activo") = TryCast(item, GridDataItem)("Activo").Text.ToString
            nuevo("Pasivo") = TryCast(item, GridDataItem)("Pasivo").Text.ToString
            nuevo("PerdidaNat") = TryCast(item, GridDataItem)("PerdidaN").Text.ToString
            nuevo("GananciaNat") = TryCast(item, GridDataItem)("GananciaN").Text.ToString
            nuevo("PerdidaFun") = TryCast(item, GridDataItem)("PerdidaF").Text.ToString
            nuevo("GananciaFun") = TryCast(item, GridDataItem)("GananciaF").Text.ToString
            temp.Rows.Add(nuevo)

        Next

        'temp.AcceptChanges()
        Return temp

    End Function
    Function GetAbono1(ByVal Para As String) As DataTable ' Devuelve un DataTable Temporal con Datos de prueba. 
        Dim temp As New DataTable
        Dim OrdenInicio As Integer = 0

        temp.Columns.Add("Cuenta", System.Type.GetType("System.String"))
        temp.Columns("Cuenta").SetOrdinal( OrdenInicio)
        temp.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        temp.Columns("Descripcion").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Debe", System.Type.GetType("System.Decimal"))
        temp.Columns("Debe").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Haber", System.Type.GetType("System.Decimal"))
        temp.Columns("Haber").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Deudor", System.Type.GetType("System.Decimal"))
        temp.Columns("Deudor").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Acreedor", System.Type.GetType("System.Decimal"))
        temp.Columns("Acreedor").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Activo", System.Type.GetType("System.Decimal"))
        temp.Columns("Activo").SetOrdinal(OrdenInicio)
        temp.Columns.Add("Pasivo", System.Type.GetType("System.Decimal"))
        temp.Columns("Pasivo").SetOrdinal(OrdenInicio)
        temp.Columns.Add("PerdidaNat", System.Type.GetType("System.Decimal"))
        temp.Columns("PerdidaNat").SetOrdinal(OrdenInicio)
        temp.Columns.Add("GananciaNat", System.Type.GetType("System.Decimal"))
        temp.Columns("GananciaNat").SetOrdinal(OrdenInicio)
        temp.Columns.Add("PerdidaFun", System.Type.GetType("System.Decimal"))
        temp.Columns("PerdidaFun").SetOrdinal(OrdenInicio)
        temp.Columns.Add("GananciaFun", System.Type.GetType("System.Decimal"))
        temp.Columns("GananciaFun").SetOrdinal(OrdenInicio)

        For cR1 = 0 To Me.RadGrid1.Items.Count - 1
            Dim nuevo As DataRow = temp.NewRow()
            Dim item As GridItem = RadGrid1.MasterTableView.Items(cR1)

            nuevo("Cuenta") = TryCast(item, GridDataItem)("Codigo").Text.ToString
            nuevo("Descripcion") = TryCast(item, GridDataItem)("Descripcion").Text.ToString
            nuevo("Debe") = TryCast(item, GridDataItem)("DebeMN").Text.ToString
            nuevo("Haber") = TryCast(item, GridDataItem)("HaberMN").Text.ToString
            nuevo("Deudor") = TryCast(item, GridDataItem)("SaldoDeudor").Text.ToString
            nuevo("Acreedor") = TryCast(item, GridDataItem)("SaldoAcreedor").Text.ToString
            nuevo("Activo") = TryCast(item, GridDataItem)("Activo").Text.ToString
            nuevo("Pasivo") = TryCast(item, GridDataItem)("Pasivo").Text.ToString
            nuevo("PerdidaNat") = TryCast(item, GridDataItem)("PerdidaN").Text.ToString
            nuevo("GananciaNat") = TryCast(item, GridDataItem)("GananciaN").Text.ToString
            nuevo("PerdidaFun") = TryCast(item, GridDataItem)("PerdidaF").Text.ToString
            nuevo("GananciaFun") = TryCast(item, GridDataItem)("GananciaF").Text.ToString
            temp.Rows.Add(nuevo)

        Next

        'temp.AcceptChanges()
        Return temp

    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim objExcel As Object
        Dim Columna As Integer

        ' crear la referencia a excel  
        objExcel = CreateObject("Excel.application")

        With objExcel

            ' Agregar un Nuevo libro  
            .Workbooks.Add()


            Dim i As Integer

            ' Agregar los nombres de los meses a la columna Meses  
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            Columna = 1
            For i = 1 To 12
                .cells(1, Columna).Formula = "Meses"
                .cells(i + 1, Columna).Formula = MonthName(i)

            Next

            ' agregar costos valores para la columna 2  ( Gastos Productos )  
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            Columna = 2
            For i = 1 To 12
                .cells(1, Columna).Formula = "Gastos Productos"
                .cells(i + 1, Columna).Formula = CInt(Rnd * 255)

            Next

            ' agregar valores a la columna 3 (Gastos impuestos)  
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            Columna = 3
            For i = 1 To 12
                .cells(1, Columna).Formula = "Gastos impuestos"
                .cells(i + 1, Columna).Formula = CInt(Rnd * 150)

            Next

            ' agregar valores a la columna 4 ( Otros gastos )  
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            Columna = 4
            For i = 1 To 12
                .cells(1, Columna).Formula = "Otros gastos"
                .cells(i + 1, Columna).Formula = CInt(Rnd * 50)
            Next


            ' Sacar el SubTotal para cada columna  
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            .cells(14, 1).Formula = "SubTotales"
            .cells(14, 2).Formula = "=SUM(B2:B13)"

            ' SubTotal para la columna 3  
            .cells(14, 3).Formula = "=SUM(C2:C13)"

            ' SubTotal para la columna 4  
            .cells(14, 4).Formula = "=SUM(D2:D13)"


            ' Total  
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            .cells(16, 1).Formula = "Total"
            .cells(16, 4).Formula = "=SUM(B14:D14)"


            'Formato de celdas ( fuente y color de fondo )  
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''  

            ' autoajustar las columnas  
            .Columns("A:A").EntireColumn.AutoFit()
            .Columns("B:B").EntireColumn.AutoFit()
            .Columns("C:C").EntireColumn.AutoFit()
            .Columns("D:D").EntireColumn.AutoFit()


            .Range("A1:D1").Select()
            With .Selection.Font
                .Name = "Arial"
                .FontStyle = "Negrita"
                .Size = 10
                .Strikethrough = False
                .Superscript = False
                .Subscript = False
                .OutlineFont = False
                .Shadow = False
            End With
            With .Selection.Interior
                .colorindex = 35

            End With
            .Range("A2:D13").Select()

            .Selection.Font.colorindex = 2
            With .Selection.Interior
                .colorindex = 11
            End With

            .Range("A14:D16").Select()

            .Selection.Interior.colorindex = 35

            .Range("A14:A16").Select()
            .Selection.Font.FontStyle = "Negrita"

        End With


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
        ' ahcer visible el Excel  
        objExcel.Visible = True

        ' eliminar la referencia  
        objExcel = Nothing
    End Sub

  
End Class