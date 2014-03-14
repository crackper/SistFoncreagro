Partial Class RepBajaBienes
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepBajaBienes = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.fechaBajaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.motivoBajaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tipoBajaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.observacionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.costoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fechaIngresoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.codigoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.catalogoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.proyectoGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.proyectoDataTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.proyectoGroup = New Telerik.Reporting.Group()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.codigoDataTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionDataTextBox = New Telerik.Reporting.TextBox()
        Me.fechaIngresoDataTextBox = New Telerik.Reporting.TextBox()
        Me.costoDataTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionBienDataTextBox = New Telerik.Reporting.TextBox()
        Me.fechaBajaDataTextBox = New Telerik.Reporting.TextBox()
        Me.motivoBajaDataTextBox = New Telerik.Reporting.TextBox()
        Me.tipoBajaDataTextBox = New Telerik.Reporting.TextBox()
        Me.observacionDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepBajaBienes
        '
        Me.SDSRepBajaBienes.ConnectionString = "cnx"
        Me.SDSRepBajaBienes.Name = "SDSRepBajaBienes"
        Me.SDSRepBajaBienes.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@fechaInicio", System.Data.DbType.DateTime, "=Parameters.fechaInicio.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechaFin", System.Data.DbType.DateTime, "=Parameters.fechaFin.Value"), New Telerik.Reporting.SqlDataSourceParameter("@tipo", System.Data.DbType.AnsiStringFixedLength, "=Parameters.tipo.Value")})
        Me.SDSRepBajaBienes.SelectCommand = "dbo.RepBajaBienes"
        Me.SDSRepBajaBienes.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.52707564830780029R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fechaBajaCaptionTextBox, Me.motivoBajaCaptionTextBox, Me.tipoBajaCaptionTextBox, Me.observacionCaptionTextBox, Me.descripcionCaptionTextBox, Me.costoCaptionTextBox, Me.fechaIngresoCaptionTextBox, Me.codigoCaptionTextBox, Me.catalogoCaptionTextBox})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'fechaBajaCaptionTextBox
        '
        Me.fechaBajaCaptionTextBox.CanGrow = True
        Me.fechaBajaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaBajaCaptionTextBox.Name = "fechaBajaCaptionTextBox"
        Me.fechaBajaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaBajaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaBajaCaptionTextBox.Style.Font.Bold = True
        Me.fechaBajaCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaBajaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaBajaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaBajaCaptionTextBox.StyleName = "Caption"
        Me.fechaBajaCaptionTextBox.Value = "FEC. BAJA"
        '
        'motivoBajaCaptionTextBox
        '
        Me.motivoBajaCaptionTextBox.CanGrow = True
        Me.motivoBajaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.motivoBajaCaptionTextBox.Name = "motivoBajaCaptionTextBox"
        Me.motivoBajaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.motivoBajaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.motivoBajaCaptionTextBox.Style.Font.Bold = True
        Me.motivoBajaCaptionTextBox.Style.Font.Name = "Arial"
        Me.motivoBajaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.motivoBajaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.motivoBajaCaptionTextBox.StyleName = "Caption"
        Me.motivoBajaCaptionTextBox.Value = "MOTIVO DE LA BAJA"
        '
        'tipoBajaCaptionTextBox
        '
        Me.tipoBajaCaptionTextBox.CanGrow = True
        Me.tipoBajaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(19.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoBajaCaptionTextBox.Name = "tipoBajaCaptionTextBox"
        Me.tipoBajaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.5000014305114746R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoBajaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.tipoBajaCaptionTextBox.Style.Font.Bold = True
        Me.tipoBajaCaptionTextBox.Style.Font.Name = "Arial"
        Me.tipoBajaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoBajaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoBajaCaptionTextBox.StyleName = "Caption"
        Me.tipoBajaCaptionTextBox.Value = "TIPO DE BAJA"
        '
        'observacionCaptionTextBox
        '
        Me.observacionCaptionTextBox.CanGrow = True
        Me.observacionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.observacionCaptionTextBox.Name = "observacionCaptionTextBox"
        Me.observacionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.4996986389160156R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.observacionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.observacionCaptionTextBox.Style.Font.Bold = True
        Me.observacionCaptionTextBox.Style.Font.Name = "Arial"
        Me.observacionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.observacionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.observacionCaptionTextBox.StyleName = "Caption"
        Me.observacionCaptionTextBox.Value = "OBSERVACIONES"
        '
        'descripcionCaptionTextBox
        '
        Me.descripcionCaptionTextBox.CanGrow = True
        Me.descripcionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Name = "descripcionCaptionTextBox"
        Me.descripcionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.499199390411377R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.descripcionCaptionTextBox.Style.Font.Name = "Arial"
        Me.descripcionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.descripcionCaptionTextBox.StyleName = "Caption"
        Me.descripcionCaptionTextBox.Value = "DESCRIPCIÓN"
        '
        'costoCaptionTextBox
        '
        Me.costoCaptionTextBox.CanGrow = True
        Me.costoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoCaptionTextBox.Name = "costoCaptionTextBox"
        Me.costoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.costoCaptionTextBox.Style.Font.Name = "Arial"
        Me.costoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.costoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.costoCaptionTextBox.StyleName = "Caption"
        Me.costoCaptionTextBox.Value = "VALOR"
        '
        'fechaIngresoCaptionTextBox
        '
        Me.fechaIngresoCaptionTextBox.CanGrow = True
        Me.fechaIngresoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoCaptionTextBox.Name = "fechaIngresoCaptionTextBox"
        Me.fechaIngresoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaIngresoCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaIngresoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaIngresoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaIngresoCaptionTextBox.StyleName = "Caption"
        Me.fechaIngresoCaptionTextBox.Value = "FEC.COMPRA"
        '
        'codigoCaptionTextBox
        '
        Me.codigoCaptionTextBox.CanGrow = True
        Me.codigoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Name = "codigoCaptionTextBox"
        Me.codigoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.codigoCaptionTextBox.Style.Font.Name = "Arial"
        Me.codigoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoCaptionTextBox.StyleName = "Caption"
        Me.codigoCaptionTextBox.Value = "CÓDIGO"
        '
        'catalogoCaptionTextBox
        '
        Me.catalogoCaptionTextBox.CanGrow = True
        Me.catalogoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.catalogoCaptionTextBox.Name = "catalogoCaptionTextBox"
        Me.catalogoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.catalogoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.catalogoCaptionTextBox.Style.Font.Name = "Arial"
        Me.catalogoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.catalogoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.catalogoCaptionTextBox.StyleName = "Caption"
        Me.catalogoCaptionTextBox.Value = "CATÁLOGO"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox4, Me.TextBox1})
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = True
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "TOTAL BAJAS:"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:d}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5001997947692871R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= CStr(Count(Fields.Codigo))+' Bien(es)'"
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'proyectoGroupHeader
        '
        Me.proyectoGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.proyectoGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.proyectoDataTextBox})
        Me.proyectoGroupHeader.Name = "proyectoGroupHeader"
        '
        'proyectoDataTextBox
        '
        Me.proyectoDataTextBox.CanGrow = True
        Me.proyectoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Name = "proyectoDataTextBox"
        Me.proyectoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Style.Font.Bold = True
        Me.proyectoDataTextBox.Style.Font.Name = "Arial"
        Me.proyectoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoDataTextBox.StyleName = "Data"
        Me.proyectoDataTextBox.Value = "= Fields.Proyecto"
        '
        'proyectoGroupFooter
        '
        Me.proyectoGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.proyectoGroupFooter.Name = "proyectoGroupFooter"
        Me.proyectoGroupFooter.Style.Visible = True
        '
        'proyectoGroup
        '
        Me.proyectoGroup.GroupFooter = Me.proyectoGroupFooter
        Me.proyectoGroup.GroupHeader = Me.proyectoGroupHeader
        Me.proyectoGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Proyecto")})
        Me.proyectoGroup.Name = "proyectoGroup"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.TextBox7, Me.TextBox6, Me.reportNameTextBox, Me.TextBox39, Me.TextBox38, Me.TextBox9, Me.TextBox8, Me.TextBox5, Me.TextBox10, Me.TextBox17})
        Me.pageHeader.Name = "pageHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "= IIf(Parameters.tipo.Value=""A"",""BAJAS DE ACTIVOS"", IIf(Parameters.tipo.Value=""C""" & _
            ",""BAJAS DE BIENES QUE NO FORMAN PARTE DEL ACTIVO"",""BAJAS DE BIENES ACTIVOS Y NO " & _
            "ACTIVOS""))"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(23.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.StyleName = "PageInfo"
        Me.TextBox7.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(23.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "RUC: 20453262767"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(23.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0176990032196045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9996011257171631R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5239677429199219R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5239677429199219R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "= Now()"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.51769900321960449R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9996011257171631R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Fecha:"
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:d}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9996011257171631R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.StyleName = "PageInfo"
        Me.TextBox5.Value = "Página:"
        '
        'TextBox10
        '
        Me.TextBox10.Format = "{0:g}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5239677429199219R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "PageInfo"
        Me.TextBox10.Value = "=PageNumber+ ' de '+ PageCount"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50000017881393433R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.StyleName = "Title"
        Me.TextBox17.Value = "=""DEL "" + Format(""{0:d}"", Parameters.fechaInicio.Value)+' AL '+ Format(""{0:d}"", P" & _
            "arameters.fechaFin.Value)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Name = "reportHeader"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoDataTextBox, Me.descripcionDataTextBox, Me.fechaIngresoDataTextBox, Me.costoDataTextBox, Me.descripcionBienDataTextBox, Me.fechaBajaDataTextBox, Me.motivoBajaDataTextBox, Me.tipoBajaDataTextBox, Me.observacionDataTextBox})
        Me.detail.Name = "detail"
        '
        'codigoDataTextBox
        '
        Me.codigoDataTextBox.CanGrow = True
        Me.codigoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Name = "codigoDataTextBox"
        Me.codigoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Style.Font.Name = "Arial"
        Me.codigoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoDataTextBox.StyleName = "Data"
        Me.codigoDataTextBox.Value = "=Fields.Codigo"
        '
        'descripcionDataTextBox
        '
        Me.descripcionDataTextBox.CanGrow = True
        Me.descripcionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Name = "descripcionDataTextBox"
        Me.descripcionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Style.Font.Name = "Arial"
        Me.descripcionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionDataTextBox.StyleName = "Data"
        Me.descripcionDataTextBox.Value = "=Fields.Descripcion"
        '
        'fechaIngresoDataTextBox
        '
        Me.fechaIngresoDataTextBox.CanGrow = True
        Me.fechaIngresoDataTextBox.Format = "{0:d}"
        Me.fechaIngresoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoDataTextBox.Name = "fechaIngresoDataTextBox"
        Me.fechaIngresoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoDataTextBox.Style.Font.Name = "Arial"
        Me.fechaIngresoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaIngresoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaIngresoDataTextBox.StyleName = "Data"
        Me.fechaIngresoDataTextBox.Value = "=Fields.FechaIngreso"
        '
        'costoDataTextBox
        '
        Me.costoDataTextBox.CanGrow = True
        Me.costoDataTextBox.Format = "{0:N2}"
        Me.costoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoDataTextBox.Name = "costoDataTextBox"
        Me.costoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoDataTextBox.Style.Font.Name = "Arial"
        Me.costoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.costoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.costoDataTextBox.StyleName = "Data"
        Me.costoDataTextBox.Value = "=Fields.Costo"
        '
        'descripcionBienDataTextBox
        '
        Me.descripcionBienDataTextBox.CanGrow = True
        Me.descripcionBienDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.5000009536743164R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionBienDataTextBox.Name = "descripcionBienDataTextBox"
        Me.descripcionBienDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.499199390411377R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionBienDataTextBox.Style.Font.Name = "Arial"
        Me.descripcionBienDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionBienDataTextBox.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.descripcionBienDataTextBox.StyleName = "Data"
        Me.descripcionBienDataTextBox.Value = "=Fields.DescripcionBien"
        '
        'fechaBajaDataTextBox
        '
        Me.fechaBajaDataTextBox.CanGrow = True
        Me.fechaBajaDataTextBox.Format = "{0:d}"
        Me.fechaBajaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaBajaDataTextBox.Name = "fechaBajaDataTextBox"
        Me.fechaBajaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaBajaDataTextBox.Style.Font.Name = "Arial"
        Me.fechaBajaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaBajaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaBajaDataTextBox.StyleName = "Data"
        Me.fechaBajaDataTextBox.Value = "=Fields.FechaBaja"
        '
        'motivoBajaDataTextBox
        '
        Me.motivoBajaDataTextBox.CanGrow = True
        Me.motivoBajaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.motivoBajaDataTextBox.Name = "motivoBajaDataTextBox"
        Me.motivoBajaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.motivoBajaDataTextBox.Style.Font.Name = "Arial"
        Me.motivoBajaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.motivoBajaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.motivoBajaDataTextBox.StyleName = "Data"
        Me.motivoBajaDataTextBox.Value = "=Fields.MotivoBaja"
        '
        'tipoBajaDataTextBox
        '
        Me.tipoBajaDataTextBox.CanGrow = True
        Me.tipoBajaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(19.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoBajaDataTextBox.Name = "tipoBajaDataTextBox"
        Me.tipoBajaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.5000014305114746R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoBajaDataTextBox.Style.Font.Name = "Arial"
        Me.tipoBajaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoBajaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoBajaDataTextBox.StyleName = "Data"
        Me.tipoBajaDataTextBox.Value = "=Fields.TipoBaja"
        '
        'observacionDataTextBox
        '
        Me.observacionDataTextBox.CanGrow = True
        Me.observacionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.observacionDataTextBox.Name = "observacionDataTextBox"
        Me.observacionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.4996986389160156R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.observacionDataTextBox.Style.Font.Name = "Arial"
        Me.observacionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.observacionDataTextBox.StyleName = "Data"
        Me.observacionDataTextBox.Value = "=Fields.Observacion"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Format = "{0:C2}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "=Sum(Fields.Costo)"
        '
        'RepBajaBienes
        '
        Me.DataSource = Me.SDSRepBajaBienes
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.proyectoGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.proyectoGroupHeader, Me.proyectoGroupFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "fechaInicio"
        ReportParameter1.Text = "fechaInicio"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        ReportParameter2.Name = "fechaFin"
        ReportParameter2.Text = "fechaFin"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Visible = True
        ReportParameter3.Name = "tipo"
        ReportParameter3.Text = "tipo"
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
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = New Telerik.Reporting.Drawing.Unit(28.523969650268555R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepBajaBienes As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fechaBajaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents motivoBajaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoBajaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents observacionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents proyectoGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents proyectoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents proyectoGroup As Telerik.Reporting.Group
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents codigoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaIngresoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents costoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionBienDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaBajaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents motivoBajaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoBajaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents observacionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents descripcionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents costoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaIngresoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codigoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents catalogoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class