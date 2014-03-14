Partial Class RepProgramacionActividades
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepProgramacionActividades))
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
        Me.SDSProgramacionActividades = New Telerik.Reporting.SqlDataSource()
        Me.personalCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.caserioCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSProgramacionActividades
        '
        Me.SDSProgramacionActividades.ConnectionString = "cnx"
        Me.SDSProgramacionActividades.Name = "SDSProgramacionActividades"
        Me.SDSProgramacionActividades.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechaInicio", System.Data.DbType.DateTime, "=Parameters.fechaInicio.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechaFin", System.Data.DbType.DateTime, "=Parameters.fechaFin.Value")})
        Me.SDSProgramacionActividades.SelectCommand = "dbo.GetProgramacionSalidas"
        Me.SDSProgramacionActividades.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'personalCaptionTextBox
        '
        Me.personalCaptionTextBox.CanGrow = True
        Me.personalCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50000077486038208R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.personalCaptionTextBox.Name = "personalCaptionTextBox"
        Me.personalCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.9995999336242676R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49989902973175049R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.personalCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Navy
        Me.personalCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.personalCaptionTextBox.Style.Color = System.Drawing.Color.White
        Me.personalCaptionTextBox.Style.Font.Bold = True
        Me.personalCaptionTextBox.Style.Font.Name = "Arial"
        Me.personalCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.personalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.personalCaptionTextBox.StyleName = "Caption"
        Me.personalCaptionTextBox.Value = "PERSONAL"
        '
        'caserioCaptionTextBox
        '
        Me.caserioCaptionTextBox.CanGrow = True
        Me.caserioCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(5.4998002052307129R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.caserioCaptionTextBox.Name = "caserioCaptionTextBox"
        Me.caserioCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.caserioCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Navy
        Me.caserioCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.caserioCaptionTextBox.Style.Color = System.Drawing.Color.White
        Me.caserioCaptionTextBox.Style.Font.Bold = True
        Me.caserioCaptionTextBox.Style.Font.Name = "Arial"
        Me.caserioCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.caserioCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.caserioCaptionTextBox.StyleName = "Caption"
        Me.caserioCaptionTextBox.Value = "CASERIO"
        '
        'descripcionCaptionTextBox
        '
        Me.descripcionCaptionTextBox.CanGrow = True
        Me.descripcionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.4997997283935547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Name = "descripcionCaptionTextBox"
        Me.descripcionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Navy
        Me.descripcionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.descripcionCaptionTextBox.Style.Color = System.Drawing.Color.White
        Me.descripcionCaptionTextBox.Style.Font.Bold = True
        Me.descripcionCaptionTextBox.Style.Font.Name = "Arial"
        Me.descripcionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.descripcionCaptionTextBox.StyleName = "Caption"
        Me.descripcionCaptionTextBox.Value = "ACTIVIDAD"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.Navy
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.Color = System.Drawing.Color.White
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "COMENTARIOS"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox14})
        Me.pageHeader.Name = "pageHeader"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.MimeType = "image/jpeg"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.PictureBox1.Style.BackgroundImage.ImageData = Global.SistFoncreagro.Report.My.Resources.Resources.logotipo_foncreagro
        Me.PictureBox1.Style.BackgroundImage.MimeType = "image/jpeg"
        Me.PictureBox1.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(27.700000762939453R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Value = "=""PROGRAMACION DE ACTIVIDADES ""+""DEL ""+ Format('{0:dd/MM/yyyy}',Parameters.fechaI" & _
    "nicio.Value)+"" AL ""+ Format('{0:dd/MM/yyyy}',Parameters.fechaFin.Value)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.71437495946884155R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        Me.pageFooter.Style.Visible = False
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.personalCaptionTextBox, Me.caserioCaptionTextBox, Me.descripcionCaptionTextBox, Me.TextBox6, Me.Table1, Me.TextBox15, Me.TextBox1})
        Me.reportHeader.Name = "reportHeader"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(1.4999998807907104R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(4.0000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(3.0000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)))
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox8)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox7)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox9)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox11)
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox16)
        Me.Table1.Body.SetCellContent(0, 5, Me.TextBox2)
        TableGroup1.Name = "Group7"
        TableGroup3.Name = "Group1"
        TableGroup4.Name = "Group2"
        TableGroup5.Name = "Group4"
        TableGroup6.Name = "Group3"
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.ColumnGroups.Add(TableGroup6)
        Me.Table1.DataSource = Me.SDSProgramacionActividades
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox7, Me.TextBox9, Me.TextBox11, Me.TextBox16, Me.TextBox2})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.000099778175354R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.Table1.Name = "Table1"
        TableGroup7.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("")})
        TableGroup7.Name = "Detail"
        Me.Table1.RowGroups.Add(TableGroup7)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(27.500003814697266R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.Table1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.Table1.StyleName = "Normal.TableNormal"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.StyleName = "Normal.TableBody"
        Me.TextBox8.Value = "=Fields.Personal"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.StyleName = "Normal.TableBody"
        Me.TextBox7.Value = "= Fields.Caserio"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.StyleName = "Normal.TableBody"
        Me.TextBox9.Value = "= Fields.Descripcion"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.StyleName = "Normal.TableBody"
        Me.TextBox11.Value = "= Fields.Observacion"
        '
        'TextBox16
        '
        Me.TextBox16.Format = "{0:d}"
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.StyleName = "Normal.TableBody"
        Me.TextBox16.Value = "= Fields.FechaProgramada"
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.StyleName = "Normal.TableBody"
        Me.TextBox2.Value = "= Fields.Estado"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50000035762786865R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4998002052307129R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.Navy
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.Color = System.Drawing.Color.White
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Caption"
        Me.TextBox15.Value = "FECHA"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.500200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50000077486038208R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.Navy
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.Color = System.Drawing.Color.White
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "ESTADO"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.71437495946884155R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(1.3999998569488525R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = False
        '
        'RepProgramacionActividades
        '
        Me.DataSource = Me.SDSProgramacionActividades
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "idProyecto"
        ReportParameter1.Text = "idProyecto"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Visible = True
        ReportParameter2.Name = "fechaInicio"
        ReportParameter2.Text = "fechaInicio"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Visible = True
        ReportParameter3.Name = "fechaFin"
        ReportParameter3.Text = "fechaFin"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
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
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableHeader")})
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        StyleRule6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableBody")})
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableGroup")})
        StyleRule8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule8.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule8.Style.BorderWidth.Default = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Pixel)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7, StyleRule8})
        Me.Width = New Telerik.Reporting.Drawing.Unit(27.700000762939453R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSProgramacionActividades As Telerik.Reporting.SqlDataSource
    Friend WithEvents personalCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents caserioCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Public WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class