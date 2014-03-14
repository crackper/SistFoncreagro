Partial Class RepEstadoCompromisos
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepEstadoCompromisos))
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule6 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule8 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector3 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule9 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule10 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector4 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule11 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector5 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule12 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector6 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule13 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector7 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule14 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector8 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.SDSRepEstadoCompromisos = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.Crosstab1 = New Telerik.Reporting.Crosstab()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5556344985961914R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.Navy
        Me.TextBox1.Style.Color = System.Drawing.Color.White
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Normal.TableGroup"
        Me.TextBox1.Value = "=Fields.Actividad"
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5027072429656982R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.StyleName = "Normal.TableGroup"
        Me.TextBox2.Value = "=Fields.Caserio"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.StyleName = "Normal.TableGroup"
        Me.TextBox9.Value = "= Fields.CentroPoblado"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999998807907104R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.StyleName = "Normal.TableGroup"
        Me.TextBox7.Value = "= Fields.Distrito"
        '
        'TextBox17
        '
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5027072429656982R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.StyleName = "Normal.TableGroup"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.StyleName = "Normal.TableGroup"
        '
        'TextBox15
        '
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.StyleName = "Normal.TableGroup"
        '
        'SDSRepEstadoCompromisos
        '
        Me.SDSRepEstadoCompromisos.ConnectionString = "cnx"
        Me.SDSRepEstadoCompromisos.Name = "SDSRepEstadoCompromisos"
        Me.SDSRepEstadoCompromisos.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@IdProyecto", System.Data.DbType.Int32, "=Parameters.IdProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@FechaInicio", System.Data.DbType.DateTime, "=Parameters.FechaInicio.Value"), New Telerik.Reporting.SqlDataSourceParameter("@FechaFin", System.Data.DbType.DateTime, "=Parameters.FechaFin.Value")})
        Me.SDSRepEstadoCompromisos.SelectCommand = "dbo.RepEstadoCompromisosCaserios"
        Me.SDSRepEstadoCompromisos.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(2.2000002861022949R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox19, Me.PictureBox1})
        Me.pageHeader.Name = "pageHeader"
        Me.pageHeader.Style.Visible = True
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(29.999902725219727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "PageInfo"
        Me.TextBox19.Value = "=""RESUMEN DE TAREAS REALIZADAS POR CASERIO ""+""DEL ""+ Format('{0:dd/MM/yyyy}',Para" & _
    "meters.FechaInicio.Value)+"" AL ""+ Format('{0:dd/MM/yyyy}',Parameters.FechaFin.Va" & _
    "lue)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.MimeType = "image/jpeg"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.PictureBox1.Style.BackgroundImage.ImageData = Global.SistFoncreagro.Report.My.Resources.Resources.logotipo_foncreagro
        Me.PictureBox1.Style.BackgroundImage.MimeType = "image/jpeg"
        Me.PictureBox1.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.71437495946884155R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        Me.pageFooter.Style.Visible = True
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(2.0001001358032227R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Crosstab1})
        Me.reportHeader.Name = "reportHeader"
        '
        'Crosstab1
        '
        Me.Crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(2.5556342601776123R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Crosstab1.Body.SetCellContent(0, 0, Me.TextBox4)
        Me.Crosstab1.Body.SetCellContent(1, 0, Me.TextBox18)
        TableGroup1.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Actividad")})
        TableGroup1.Name = "Actividad"
        TableGroup1.ReportItem = Me.TextBox1
        TableGroup1.Sortings.AddRange(New Telerik.Reporting.Sorting() {New Telerik.Reporting.Sorting("=Fields.Actividad", Telerik.Reporting.SortDirection.Asc)})
        Me.Crosstab1.ColumnGroups.Add(TableGroup1)
        Me.Crosstab1.Corner.SetCellContent(0, 2, Me.TextBox3)
        Me.Crosstab1.Corner.SetCellContent(0, 0, Me.TextBox8)
        Me.Crosstab1.Corner.SetCellContent(0, 1, Me.TextBox11)
        Me.Crosstab1.DataSource = Me.SDSRepEstadoCompromisos
        Me.Crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox18, Me.TextBox1, Me.TextBox3, Me.TextBox8, Me.TextBox11, Me.TextBox7, Me.TextBox9, Me.TextBox2, Me.TextBox15, Me.TextBox10, Me.TextBox17})
        Me.Crosstab1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.Crosstab1.Name = "Crosstab1"
        TableGroup4.Name = "Group6"
        TableGroup4.ReportItem = Me.TextBox2
        TableGroup3.ChildGroups.Add(TableGroup4)
        TableGroup3.Name = "Group8"
        TableGroup3.ReportItem = Me.TextBox9
        TableGroup2.ChildGroups.Add(TableGroup3)
        TableGroup2.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Caserio")})
        TableGroup2.Name = "Caserio"
        TableGroup2.ReportItem = Me.TextBox7
        TableGroup7.Name = "Group7"
        TableGroup7.ReportItem = Me.TextBox17
        TableGroup6.ChildGroups.Add(TableGroup7)
        TableGroup6.Name = "Group9"
        TableGroup6.ReportItem = Me.TextBox10
        TableGroup5.ChildGroups.Add(TableGroup6)
        TableGroup5.Name = "Group3"
        TableGroup5.ReportItem = Me.TextBox15
        Me.Crosstab1.RowGroups.Add(TableGroup2)
        Me.Crosstab1.RowGroups.Add(TableGroup5)
        Me.Crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.0583419799804687R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.Crosstab1.Sortings.AddRange(New Telerik.Reporting.Sorting() {New Telerik.Reporting.Sorting("=Fields.Distrito", Telerik.Reporting.SortDirection.Asc), New Telerik.Reporting.Sorting("=Fields.CentroPoblado", Telerik.Reporting.SortDirection.Asc), New Telerik.Reporting.Sorting("=Fields.Caserio", Telerik.Reporting.SortDirection.Asc)})
        Me.Crosstab1.StyleName = "Normal.TableNormal"
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5556344985961914R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Normal.TableBody"
        Me.TextBox4.Value = "=Sum(Fields.CANTIDAD)"
        '
        'TextBox18
        '
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5556340217590332R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.StyleName = "Normal.TableBody"
        Me.TextBox18.Value = "=Sum(Fields.CANTIDAD)"
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5027072429656982R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.TextBox3.Style.Color = System.Drawing.Color.Black
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Normal.TableHeader"
        Me.TextBox3.Value = "CASERIO"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.TextBox8.Style.Color = System.Drawing.Color.Black
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Normal.TableHeader"
        Me.TextBox8.Value = "DISTRITO"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Normal.TableHeader"
        Me.TextBox11.Value = "CENTRO POBLADO"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.71437495946884155R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.49990004301071167R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = False
        '
        'RepEstadoCompromisos
        '
        Me.DataSource = Me.SDSRepEstadoCompromisos
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(21.005800247192383R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(55.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        ReportParameter1.Name = "IdProyecto"
        ReportParameter1.Text = "IdProyecto"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Visible = True
        ReportParameter2.Name = "FechaInicio"
        ReportParameter2.Text = "FechaInicio"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Visible = True
        ReportParameter3.Name = "FechaFin"
        ReportParameter3.Text = "FechaFin"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.Sortings.AddRange(New Telerik.Reporting.Sorting() {New Telerik.Reporting.Sorting("=Fields.Distrito", Telerik.Reporting.SortDirection.Asc), New Telerik.Reporting.Sorting("=Fields.CentroPoblado", Telerik.Reporting.SortDirection.Asc), New Telerik.Reporting.Sorting("=Fields.Caserio", Telerik.Reporting.SortDirection.Asc)})
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.Black
        StyleRule1.Style.Font.Bold = True
        StyleRule1.Style.Font.Italic = False
        StyleRule1.Style.Font.Name = "Tahoma"
        StyleRule1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Point)
        StyleRule1.Style.Font.Strikeout = False
        StyleRule1.Style.Font.Underline = False
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(11.0R, Telerik.Reporting.Drawing.UnitType.Point)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(11.0R, Telerik.Reporting.Drawing.UnitType.Point)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(11.0R, Telerik.Reporting.Drawing.UnitType.Point)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Normal.TableNormal")})
        StyleRule5.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        StyleRule5.Style.Color = System.Drawing.Color.Black
        StyleRule5.Style.Font.Name = "Tahoma"
        StyleRule5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableGroup")})
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableHeader")})
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        StyleRule7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableBody")})
        StyleRule8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule8.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule8.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        StyleRule9.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Corporate.TableNormal")})
        StyleRule9.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule9.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule9.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        StyleRule9.Style.Color = System.Drawing.Color.Black
        StyleRule9.Style.Font.Name = "Tahoma"
        StyleRule9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        DescendantSelector4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableGroup")})
        StyleRule10.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector4})
        StyleRule10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        StyleRule10.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule10.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        DescendantSelector5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableHeader")})
        StyleRule11.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector5})
        StyleRule11.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule11.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule11.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        StyleRule11.Style.Color = System.Drawing.Color.White
        StyleRule11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableBody")})
        StyleRule12.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector6})
        StyleRule12.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule12.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        DescendantSelector7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.GrandTotal")})
        StyleRule13.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector7})
        StyleRule13.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule13.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        DescendantSelector8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.SubTotal")})
        StyleRule14.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector8})
        StyleRule14.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule14.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7, StyleRule8, StyleRule9, StyleRule10, StyleRule11, StyleRule12, StyleRule13, StyleRule14})
        Me.Width = New Telerik.Reporting.Drawing.Unit(30.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepEstadoCompromisos As Telerik.Reporting.SqlDataSource
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents Crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Public WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
End Class