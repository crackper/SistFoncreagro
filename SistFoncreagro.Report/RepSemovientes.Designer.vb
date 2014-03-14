Partial Class RepSemovientes
    
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
        Me.SDSRepSemovientes = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.areteMicrochipCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.areteEstabloCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.nombreCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fechaNacimientoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.edadMesesCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.razaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sexoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.colorCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pROYECTOGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.pROYECTODataTextBox = New Telerik.Reporting.TextBox()
        Me.pROYECTOGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.areteMicrochipCountFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.pROYECTOGroup = New Telerik.Reporting.Group()
        Me.cPDGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.cPDDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.cPDGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.areteMicrochipCountFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.cuentaCountFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.cPDGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.areteMicrochipCountFunctionTextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.areteMicrochipDataTextBox = New Telerik.Reporting.TextBox()
        Me.areteEstabloDataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreDataTextBox = New Telerik.Reporting.TextBox()
        Me.fechaNacimientoDataTextBox = New Telerik.Reporting.TextBox()
        Me.edadMesesDataTextBox = New Telerik.Reporting.TextBox()
        Me.razaDataTextBox = New Telerik.Reporting.TextBox()
        Me.fechaRegistroDataTextBox = New Telerik.Reporting.TextBox()
        Me.sexoDataTextBox = New Telerik.Reporting.TextBox()
        Me.colorDataTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.fechaRegistroCaptionTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepSemovientes
        '
        Me.SDSRepSemovientes.ConnectionString = "cnx"
        Me.SDSRepSemovientes.Name = "SDSRepSemovientes"
        Me.SDSRepSemovientes.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@IdProyecto", System.Data.DbType.Int32, "=Parameters.IdProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@IdProyectoCPD", System.Data.DbType.Int32, "=Parameters.IdProyectoCPD.Value"), New Telerik.Reporting.SqlDataSourceParameter("@IdEstadoSemoviente", System.Data.DbType.Int32, "=Parameters.IdEstadoSemoviente.Value")})
        Me.SDSRepSemovientes.SelectCommand = "dbo.RepSemovientes"
        Me.SDSRepSemovientes.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        Me.labelsGroupHeader.Style.Visible = False
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = True
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'areteMicrochipCaptionTextBox
        '
        Me.areteMicrochipCaptionTextBox.CanGrow = True
        Me.areteMicrochipCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCaptionTextBox.Name = "areteMicrochipCaptionTextBox"
        Me.areteMicrochipCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.areteMicrochipCaptionTextBox.Style.Font.Bold = True
        Me.areteMicrochipCaptionTextBox.Style.Font.Name = "Arial"
        Me.areteMicrochipCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areteMicrochipCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.areteMicrochipCaptionTextBox.StyleName = "Caption"
        Me.areteMicrochipCaptionTextBox.Value = "MICROCHIP"
        '
        'areteEstabloCaptionTextBox
        '
        Me.areteEstabloCaptionTextBox.CanGrow = True
        Me.areteEstabloCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteEstabloCaptionTextBox.Name = "areteEstabloCaptionTextBox"
        Me.areteEstabloCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteEstabloCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.areteEstabloCaptionTextBox.Style.Font.Bold = True
        Me.areteEstabloCaptionTextBox.Style.Font.Name = "Arial"
        Me.areteEstabloCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areteEstabloCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.areteEstabloCaptionTextBox.StyleName = "Caption"
        Me.areteEstabloCaptionTextBox.Value = "ARETE"
        '
        'nombreCaptionTextBox
        '
        Me.nombreCaptionTextBox.CanGrow = True
        Me.nombreCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0002002716064453R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002001523971558R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCaptionTextBox.Name = "nombreCaptionTextBox"
        Me.nombreCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.nombreCaptionTextBox.Style.Font.Bold = True
        Me.nombreCaptionTextBox.Style.Font.Name = "Arial"
        Me.nombreCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.nombreCaptionTextBox.StyleName = "Caption"
        Me.nombreCaptionTextBox.Value = "NOMBRE"
        '
        'fechaNacimientoCaptionTextBox
        '
        Me.fechaNacimientoCaptionTextBox.CanGrow = True
        Me.fechaNacimientoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002001523971558R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaNacimientoCaptionTextBox.Name = "fechaNacimientoCaptionTextBox"
        Me.fechaNacimientoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaNacimientoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaNacimientoCaptionTextBox.Style.Font.Bold = True
        Me.fechaNacimientoCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaNacimientoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaNacimientoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaNacimientoCaptionTextBox.StyleName = "Caption"
        Me.fechaNacimientoCaptionTextBox.Value = "FEC. NAC."
        '
        'edadMesesCaptionTextBox
        '
        Me.edadMesesCaptionTextBox.CanGrow = True
        Me.edadMesesCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.edadMesesCaptionTextBox.Name = "edadMesesCaptionTextBox"
        Me.edadMesesCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.edadMesesCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.edadMesesCaptionTextBox.Style.Font.Bold = True
        Me.edadMesesCaptionTextBox.Style.Font.Name = "Arial"
        Me.edadMesesCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.edadMesesCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.edadMesesCaptionTextBox.StyleName = "Caption"
        Me.edadMesesCaptionTextBox.Value = "EDAD (Mes)"
        '
        'razaCaptionTextBox
        '
        Me.razaCaptionTextBox.CanGrow = True
        Me.razaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razaCaptionTextBox.Name = "razaCaptionTextBox"
        Me.razaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.razaCaptionTextBox.Style.Font.Bold = True
        Me.razaCaptionTextBox.Style.Font.Name = "Arial"
        Me.razaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.razaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.razaCaptionTextBox.StyleName = "Caption"
        Me.razaCaptionTextBox.Value = "RAZA"
        '
        'sexoCaptionTextBox
        '
        Me.sexoCaptionTextBox.CanGrow = True
        Me.sexoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.501202583312988R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002001523971558R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.sexoCaptionTextBox.Name = "sexoCaptionTextBox"
        Me.sexoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.sexoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.sexoCaptionTextBox.Style.Font.Bold = True
        Me.sexoCaptionTextBox.Style.Font.Name = "Arial"
        Me.sexoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.sexoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sexoCaptionTextBox.StyleName = "Caption"
        Me.sexoCaptionTextBox.Value = "SEXO"
        '
        'colorCaptionTextBox
        '
        Me.colorCaptionTextBox.CanGrow = True
        Me.colorCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.001402854919434R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002001523971558R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.colorCaptionTextBox.Name = "colorCaptionTextBox"
        Me.colorCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.colorCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.colorCaptionTextBox.Style.Font.Bold = True
        Me.colorCaptionTextBox.Style.Font.Name = "Arial"
        Me.colorCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.colorCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.colorCaptionTextBox.StyleName = "Caption"
        Me.colorCaptionTextBox.Value = "ESTADO"
        '
        'cuentaCaptionTextBox
        '
        Me.cuentaCaptionTextBox.CanGrow = True
        Me.cuentaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.501604080200195R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaCaptionTextBox.Name = "cuentaCaptionTextBox"
        Me.cuentaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cuentaCaptionTextBox.Style.Font.Bold = True
        Me.cuentaCaptionTextBox.Style.Font.Name = "Arial"
        Me.cuentaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaCaptionTextBox.StyleName = "Caption"
        Me.cuentaCaptionTextBox.Value = "CUENTA"
        '
        'pROYECTOGroupHeader
        '
        Me.pROYECTOGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pROYECTOGroupHeader.Name = "pROYECTOGroupHeader"
        Me.pROYECTOGroupHeader.PageBreak = Telerik.Reporting.PageBreak.Before
        Me.pROYECTOGroupHeader.PrintOnEveryPage = True
        Me.pROYECTOGroupHeader.Style.Visible = False
        '
        'pROYECTODataTextBox
        '
        Me.pROYECTODataTextBox.CanGrow = True
        Me.pROYECTODataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pROYECTODataTextBox.Name = "pROYECTODataTextBox"
        Me.pROYECTODataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pROYECTODataTextBox.Style.Font.Bold = True
        Me.pROYECTODataTextBox.Style.Font.Name = "Arial"
        Me.pROYECTODataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.pROYECTODataTextBox.StyleName = "Data"
        Me.pROYECTODataTextBox.Value = "='PROYECTO: '+Fields.PROYECTO"
        '
        'pROYECTOGroupFooter
        '
        Me.pROYECTOGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.99979984760284424R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pROYECTOGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.areteMicrochipCountFunctionTextBox, Me.TextBox6})
        Me.pROYECTOGroupFooter.Name = "pROYECTOGroupFooter"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "TOTAL PROYECTO:"
        '
        'areteMicrochipCountFunctionTextBox
        '
        Me.areteMicrochipCountFunctionTextBox.CanGrow = True
        Me.areteMicrochipCountFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0002002716064453R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCountFunctionTextBox.Name = "areteMicrochipCountFunctionTextBox"
        Me.areteMicrochipCountFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9995999336242676R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCountFunctionTextBox.Style.Font.Bold = True
        Me.areteMicrochipCountFunctionTextBox.Style.Font.Name = "Arial"
        Me.areteMicrochipCountFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areteMicrochipCountFunctionTextBox.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.areteMicrochipCountFunctionTextBox.StyleName = "Data"
        Me.areteMicrochipCountFunctionTextBox.Value = "= CStr(Count(Fields.AreteEstablo))+' Activos'"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Format = "{0:C2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.001804351806641R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9980946779251099R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "=Sum(Fields.Valor)"
        '
        'pROYECTOGroup
        '
        Me.pROYECTOGroup.GroupFooter = Me.pROYECTOGroupFooter
        Me.pROYECTOGroup.GroupHeader = Me.pROYECTOGroupHeader
        Me.pROYECTOGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.PROYECTO")})
        Me.pROYECTOGroup.Name = "pROYECTOGroup"
        '
        'cPDGroupHeader
        '
        Me.cPDGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.5000007152557373R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.cPDGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.cPDDataTextBox, Me.areteMicrochipCaptionTextBox, Me.areteEstabloCaptionTextBox, Me.nombreCaptionTextBox, Me.fechaNacimientoCaptionTextBox, Me.edadMesesCaptionTextBox, Me.razaCaptionTextBox, Me.fechaRegistroCaptionTextBox, Me.sexoCaptionTextBox, Me.colorCaptionTextBox, Me.cuentaCaptionTextBox, Me.TextBox4, Me.pROYECTODataTextBox})
        Me.cPDGroupHeader.Name = "cPDGroupHeader"
        Me.cPDGroupHeader.PageBreak = Telerik.Reporting.PageBreak.Before
        Me.cPDGroupHeader.PrintOnEveryPage = True
        '
        'cPDDataTextBox
        '
        Me.cPDDataTextBox.CanGrow = True
        Me.cPDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999979138374329R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cPDDataTextBox.Name = "cPDDataTextBox"
        Me.cPDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cPDDataTextBox.Style.Font.Bold = True
        Me.cPDDataTextBox.Style.Font.Name = "Arial"
        Me.cPDDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cPDDataTextBox.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.cPDDataTextBox.StyleName = "Data"
        Me.cPDDataTextBox.Value = "='CPD: '+ Fields.CPD"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.001804351806641R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9980946779251099R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "VALOR (S/.)"
        '
        'cPDGroupFooter
        '
        Me.cPDGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.51833385229110718R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.cPDGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.areteMicrochipCountFunctionTextBox1, Me.cuentaCountFunctionTextBox1})
        Me.cPDGroupFooter.Name = "cPDGroupFooter"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "TOTAL CPD:"
        '
        'areteMicrochipCountFunctionTextBox1
        '
        Me.areteMicrochipCountFunctionTextBox1.CanGrow = True
        Me.areteMicrochipCountFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0002002716064453R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCountFunctionTextBox1.Name = "areteMicrochipCountFunctionTextBox1"
        Me.areteMicrochipCountFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9995999336242676R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCountFunctionTextBox1.Style.Font.Bold = True
        Me.areteMicrochipCountFunctionTextBox1.Style.Font.Name = "Arial"
        Me.areteMicrochipCountFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areteMicrochipCountFunctionTextBox1.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.areteMicrochipCountFunctionTextBox1.StyleName = "Data"
        Me.areteMicrochipCountFunctionTextBox1.Value = "= CStr(Count(Fields.AreteEstablo))+' Activos'"
        '
        'cuentaCountFunctionTextBox1
        '
        Me.cuentaCountFunctionTextBox1.CanGrow = True
        Me.cuentaCountFunctionTextBox1.Format = "{0:C2}"
        Me.cuentaCountFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.001804351806641R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaCountFunctionTextBox1.Name = "cuentaCountFunctionTextBox1"
        Me.cuentaCountFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9980946779251099R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaCountFunctionTextBox1.Style.Font.Bold = True
        Me.cuentaCountFunctionTextBox1.Style.Font.Name = "Arial"
        Me.cuentaCountFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaCountFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.cuentaCountFunctionTextBox1.StyleName = "Data"
        Me.cuentaCountFunctionTextBox1.Value = "=Sum(Fields.Valor)"
        '
        'cPDGroup
        '
        Me.cPDGroup.GroupFooter = Me.cPDGroupFooter
        Me.cPDGroup.GroupHeader = Me.cPDGroupHeader
        Me.cPDGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.CPD")})
        Me.cPDGroup.Name = "cPDGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.areteMicrochipCountFunctionTextBox2, Me.TextBox7})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "TOTAL GENERAL:"
        '
        'areteMicrochipCountFunctionTextBox2
        '
        Me.areteMicrochipCountFunctionTextBox2.CanGrow = True
        Me.areteMicrochipCountFunctionTextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCountFunctionTextBox2.Name = "areteMicrochipCountFunctionTextBox2"
        Me.areteMicrochipCountFunctionTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9995999336242676R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipCountFunctionTextBox2.Style.Font.Bold = True
        Me.areteMicrochipCountFunctionTextBox2.Style.Font.Name = "Arial"
        Me.areteMicrochipCountFunctionTextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areteMicrochipCountFunctionTextBox2.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.areteMicrochipCountFunctionTextBox2.StyleName = "Data"
        Me.areteMicrochipCountFunctionTextBox2.Value = "= CStr(Count(Fields.AreteEstablo))+' Activos'"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:C2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.001804351806641R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9980946779251099R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "=Sum(Fields.Valor)"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox38, Me.TextBox39, Me.TextBox12, Me.TextBox13, Me.reportNameTextBox, Me.titleTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:g}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999016523361206R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "=PageNumber+' de '+ PageCount"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "Página:"
        '
        'TextBox10
        '
        Me.TextBox10.Format = "{0:d}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "PageInfo"
        Me.TextBox10.Value = "Fecha:"
        '
        'TextBox11
        '
        Me.TextBox11.Format = "{0:d}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999016523361206R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.StyleName = "PageInfo"
        Me.TextBox11.Value = "= Now()"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999016523361206R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.501302719116211R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.StyleName = "PageInfo"
        Me.TextBox12.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.50140380859375R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.StyleName = "PageInfo"
        Me.TextBox13.Value = "RUC: 20453262767"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.50140380859375R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.9998996257781982R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Color = System.Drawing.Color.Black
        Me.titleTextBox.Style.Font.Bold = True
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "ACTIVO BIOLÓGICO"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Name = "reportHeader"
        Me.reportHeader.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.areteMicrochipDataTextBox, Me.areteEstabloDataTextBox, Me.nombreDataTextBox, Me.fechaNacimientoDataTextBox, Me.edadMesesDataTextBox, Me.razaDataTextBox, Me.fechaRegistroDataTextBox, Me.sexoDataTextBox, Me.colorDataTextBox, Me.cuentaDataTextBox, Me.TextBox5})
        Me.detail.Name = "detail"
        '
        'areteMicrochipDataTextBox
        '
        Me.areteMicrochipDataTextBox.CanGrow = True
        Me.areteMicrochipDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipDataTextBox.Name = "areteMicrochipDataTextBox"
        Me.areteMicrochipDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteMicrochipDataTextBox.Style.Font.Name = "Arial"
        Me.areteMicrochipDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areteMicrochipDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.areteMicrochipDataTextBox.StyleName = "Data"
        Me.areteMicrochipDataTextBox.Value = "=Fields.AreteMicrochip"
        '
        'areteEstabloDataTextBox
        '
        Me.areteEstabloDataTextBox.CanGrow = True
        Me.areteEstabloDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteEstabloDataTextBox.Name = "areteEstabloDataTextBox"
        Me.areteEstabloDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areteEstabloDataTextBox.Style.Font.Name = "Arial"
        Me.areteEstabloDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areteEstabloDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.areteEstabloDataTextBox.StyleName = "Data"
        Me.areteEstabloDataTextBox.Value = "=Fields.AreteEstablo"
        '
        'nombreDataTextBox
        '
        Me.nombreDataTextBox.CanGrow = True
        Me.nombreDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0002002716064453R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreDataTextBox.Name = "nombreDataTextBox"
        Me.nombreDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreDataTextBox.Style.Font.Name = "Arial"
        Me.nombreDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreDataTextBox.StyleName = "Data"
        Me.nombreDataTextBox.Value = "=Fields.Nombre"
        '
        'fechaNacimientoDataTextBox
        '
        Me.fechaNacimientoDataTextBox.CanGrow = True
        Me.fechaNacimientoDataTextBox.Format = "{0:d}"
        Me.fechaNacimientoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaNacimientoDataTextBox.Name = "fechaNacimientoDataTextBox"
        Me.fechaNacimientoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaNacimientoDataTextBox.Style.Font.Name = "Arial"
        Me.fechaNacimientoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaNacimientoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaNacimientoDataTextBox.StyleName = "Data"
        Me.fechaNacimientoDataTextBox.Value = "=Fields.FechaNacimiento"
        '
        'edadMesesDataTextBox
        '
        Me.edadMesesDataTextBox.CanGrow = True
        Me.edadMesesDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.edadMesesDataTextBox.Name = "edadMesesDataTextBox"
        Me.edadMesesDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.edadMesesDataTextBox.Style.Font.Name = "Arial"
        Me.edadMesesDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.edadMesesDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.edadMesesDataTextBox.StyleName = "Data"
        Me.edadMesesDataTextBox.Value = "=Fields.EdadMeses"
        '
        'razaDataTextBox
        '
        Me.razaDataTextBox.CanGrow = True
        Me.razaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razaDataTextBox.Name = "razaDataTextBox"
        Me.razaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razaDataTextBox.Style.Font.Name = "Arial"
        Me.razaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.razaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.razaDataTextBox.StyleName = "Data"
        Me.razaDataTextBox.Value = "=Fields.raza"
        '
        'fechaRegistroDataTextBox
        '
        Me.fechaRegistroDataTextBox.CanGrow = True
        Me.fechaRegistroDataTextBox.Format = "{0:d}"
        Me.fechaRegistroDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaRegistroDataTextBox.Name = "fechaRegistroDataTextBox"
        Me.fechaRegistroDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaRegistroDataTextBox.Style.Font.Name = "Arial"
        Me.fechaRegistroDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaRegistroDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaRegistroDataTextBox.StyleName = "Data"
        Me.fechaRegistroDataTextBox.Value = "=Fields.FechaRegistro"
        '
        'sexoDataTextBox
        '
        Me.sexoDataTextBox.CanGrow = True
        Me.sexoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.501202583312988R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.sexoDataTextBox.Name = "sexoDataTextBox"
        Me.sexoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.sexoDataTextBox.Style.Font.Name = "Arial"
        Me.sexoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.sexoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sexoDataTextBox.StyleName = "Data"
        Me.sexoDataTextBox.Value = "=Fields.Sexo"
        '
        'colorDataTextBox
        '
        Me.colorDataTextBox.CanGrow = True
        Me.colorDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.00140380859375R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.colorDataTextBox.Name = "colorDataTextBox"
        Me.colorDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.colorDataTextBox.Style.Font.Name = "Arial"
        Me.colorDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.colorDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.colorDataTextBox.StyleName = "Data"
        Me.colorDataTextBox.Value = "= Fields.NomEstadoSemoviente"
        '
        'cuentaDataTextBox
        '
        Me.cuentaDataTextBox.CanGrow = True
        Me.cuentaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.501604080200195R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaDataTextBox.Name = "cuentaDataTextBox"
        Me.cuentaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaDataTextBox.Style.Font.Name = "Arial"
        Me.cuentaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaDataTextBox.StyleName = "Data"
        Me.cuentaDataTextBox.Value = "=Fields.Cuenta"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Format = "{0:N2}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.001804351806641R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00020064989803358912R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9980946779251099R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "= Fields.Valor"
        '
        'fechaRegistroCaptionTextBox
        '
        Me.fechaRegistroCaptionTextBox.CanGrow = True
        Me.fechaRegistroCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002001523971558R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaRegistroCaptionTextBox.Name = "fechaRegistroCaptionTextBox"
        Me.fechaRegistroCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaRegistroCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaRegistroCaptionTextBox.Style.Font.Bold = True
        Me.fechaRegistroCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaRegistroCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaRegistroCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaRegistroCaptionTextBox.StyleName = "Caption"
        Me.fechaRegistroCaptionTextBox.Value = "FEC. REG."
        '
        'RepSemovientes
        '
        Me.DataSource = Me.SDSRepSemovientes
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.pROYECTOGroup, Me.cPDGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pROYECTOGroupHeader, Me.pROYECTOGroupFooter, Me.cPDGroupHeader, Me.cPDGroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "IdProyecto"
        ReportParameter1.Text = "IdProyecto"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Visible = True
        ReportParameter2.Name = "IdProyectoCPD"
        ReportParameter2.Text = "IdProyectoCPD"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter2.Visible = True
        ReportParameter3.Name = "IdEstadoSemoviente"
        ReportParameter3.Text = "IdEstadoSemoviente"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepSemovientes As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents areteMicrochipCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents areteEstabloCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaNacimientoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents edadMesesCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents razaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sexoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents colorCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pROYECTOGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents pROYECTODataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pROYECTOGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents areteMicrochipCountFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pROYECTOGroup As Telerik.Reporting.Group
    Friend WithEvents cPDGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents cPDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cPDGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents areteMicrochipCountFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents cuentaCountFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents cPDGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents areteMicrochipCountFunctionTextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents areteMicrochipDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents areteEstabloDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaNacimientoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents edadMesesDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents razaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaRegistroDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sexoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents colorDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaRegistroCaptionTextBox As Telerik.Reporting.TextBox
End Class