Partial Class RepMovCtaProveedores
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter5 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter6 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepMovCtasProveedores = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.fechaContableCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.areaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.idSubDiarioCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.codigoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.tipoCambioCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.cuentaDataTextBox = New Telerik.Reporting.TextBox()
        Me.proveedorCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.cuentaGroup = New Telerik.Reporting.Group()
        Me.proveedorGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.proveedorDataTextBox = New Telerik.Reporting.TextBox()
        Me.proveedorGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.proveedorGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fechaContableDataTextBox = New Telerik.Reporting.TextBox()
        Me.areaDataTextBox = New Telerik.Reporting.TextBox()
        Me.idSubDiarioDataTextBox = New Telerik.Reporting.TextBox()
        Me.codigoDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.RegistroGroup = New Telerik.Reporting.Group()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepMovCtasProveedores
        '
        Me.SDSRepMovCtasProveedores.ConnectionString = "cnx"
        Me.SDSRepMovCtasProveedores.Name = "SDSRepMovCtasProveedores"
        Me.SDSRepMovCtasProveedores.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@fechaInicio", System.Data.DbType.DateTime, "=Parameters.fechaInicio.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechaFin", System.Data.DbType.DateTime, "=Parameters.fechaFin.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProvedor", System.Data.DbType.Int32, "=Parameters.idProvedor.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idMoneda", System.Data.DbType.Int32, "=Parameters.idMoneda.Value"), New Telerik.Reporting.SqlDataSourceParameter("@estado", System.Data.DbType.AnsiStringFixedLength, "=Parameters.estado.Value")})
        Me.SDSRepMovCtasProveedores.SelectCommand = "dbo.RepMovCtaProveedores"
        Me.SDSRepMovCtasProveedores.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
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
        Me.labelsGroupFooter.Style.Visible = False
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'fechaContableCaptionTextBox
        '
        Me.fechaContableCaptionTextBox.CanGrow = True
        Me.fechaContableCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaContableCaptionTextBox.Name = "fechaContableCaptionTextBox"
        Me.fechaContableCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaContableCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaContableCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaContableCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaContableCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaContableCaptionTextBox.StyleName = "Caption"
        Me.fechaContableCaptionTextBox.Value = "AREA"
        '
        'areaCaptionTextBox
        '
        Me.areaCaptionTextBox.CanGrow = True
        Me.areaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00019964059174526483R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areaCaptionTextBox.Name = "areaCaptionTextBox"
        Me.areaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.areaCaptionTextBox.Style.Font.Name = "Arial"
        Me.areaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.areaCaptionTextBox.StyleName = "Caption"
        Me.areaCaptionTextBox.Value = "FECHA"
        '
        'idSubDiarioCaptionTextBox
        '
        Me.idSubDiarioCaptionTextBox.CanGrow = True
        Me.idSubDiarioCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.000201225280762R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49989962577819824R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioCaptionTextBox.Name = "idSubDiarioCaptionTextBox"
        Me.idSubDiarioCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.idSubDiarioCaptionTextBox.Style.Font.Name = "Arial"
        Me.idSubDiarioCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idSubDiarioCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.idSubDiarioCaptionTextBox.StyleName = "Caption"
        Me.idSubDiarioCaptionTextBox.Value = "S.D."
        '
        'codigoCaptionTextBox
        '
        Me.codigoCaptionTextBox.CanGrow = True
        Me.codigoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.500401496887207R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Name = "codigoCaptionTextBox"
        Me.codigoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.codigoCaptionTextBox.Style.Font.Name = "Arial"
        Me.codigoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoCaptionTextBox.StyleName = "Caption"
        Me.codigoCaptionTextBox.Value = "COMP."
        '
        'cuentaGroupHeader
        '
        Me.cuentaGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.cuentaGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fechaContableCaptionTextBox, Me.codigoCaptionTextBox, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.tipoCambioCaptionTextBox, Me.TextBox14, Me.idSubDiarioCaptionTextBox, Me.areaCaptionTextBox, Me.cuentaDataTextBox, Me.proveedorCaptionTextBox})
        Me.cuentaGroupHeader.Name = "cuentaGroupHeader"
        Me.cuentaGroupHeader.PageBreak = Telerik.Reporting.PageBreak.Before
        Me.cuentaGroupHeader.PrintOnEveryPage = True
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.49919876456260681R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "M"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49989962577819824R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "CARGO"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49989962577819824R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "ABONO"
        '
        'tipoCambioCaptionTextBox
        '
        Me.tipoCambioCaptionTextBox.CanGrow = True
        Me.tipoCambioCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49989962577819824R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoCambioCaptionTextBox.Name = "tipoCambioCaptionTextBox"
        Me.tipoCambioCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoCambioCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.tipoCambioCaptionTextBox.Style.Font.Name = "Arial"
        Me.tipoCambioCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoCambioCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoCambioCaptionTextBox.StyleName = "Caption"
        Me.tipoCambioCaptionTextBox.Value = "T.C."
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5003995895385742R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9994001388549805R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.StyleName = "Caption"
        Me.TextBox14.Value = "N° DOCUMENTO"
        '
        'cuentaDataTextBox
        '
        Me.cuentaDataTextBox.CanGrow = True
        Me.cuentaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaDataTextBox.Name = "cuentaDataTextBox"
        Me.cuentaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(24.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaDataTextBox.Style.Font.Bold = True
        Me.cuentaDataTextBox.Style.Font.Name = "Arial"
        Me.cuentaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaDataTextBox.StyleName = "Data"
        Me.cuentaDataTextBox.Value = "=Fields.Cuenta"
        '
        'proveedorCaptionTextBox
        '
        Me.proveedorCaptionTextBox.CanGrow = True
        Me.proveedorCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.000600814819336R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.499799907207489R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proveedorCaptionTextBox.Name = "proveedorCaptionTextBox"
        Me.proveedorCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9992003440856934R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proveedorCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.proveedorCaptionTextBox.Style.Font.Name = "Arial"
        Me.proveedorCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proveedorCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.proveedorCaptionTextBox.StyleName = "Caption"
        Me.proveedorCaptionTextBox.Value = "GLOSA"
        '
        'cuentaGroupFooter
        '
        Me.cuentaGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.cuentaGroupFooter.Name = "cuentaGroupFooter"
        Me.cuentaGroupFooter.Style.Visible = False
        '
        'cuentaGroup
        '
        Me.cuentaGroup.GroupFooter = Me.cuentaGroupFooter
        Me.cuentaGroup.GroupHeader = Me.cuentaGroupHeader
        Me.cuentaGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Cuenta")})
        Me.cuentaGroup.Name = "cuentaGroup"
        '
        'proveedorGroupHeader
        '
        Me.proveedorGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.proveedorGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.proveedorDataTextBox})
        Me.proveedorGroupHeader.Name = "proveedorGroupHeader"
        '
        'proveedorDataTextBox
        '
        Me.proveedorDataTextBox.CanGrow = True
        Me.proveedorDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proveedorDataTextBox.Name = "proveedorDataTextBox"
        Me.proveedorDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proveedorDataTextBox.Style.Font.Bold = True
        Me.proveedorDataTextBox.Style.Font.Name = "Arial"
        Me.proveedorDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proveedorDataTextBox.StyleName = "Data"
        Me.proveedorDataTextBox.Value = "=Fields.Proveedor"
        '
        'proveedorGroupFooter
        '
        Me.proveedorGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(1.4998999834060669R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.proveedorGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25})
        Me.proveedorGroupFooter.Name = "proveedorGroupFooter"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999934434890747R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "TOTAL COA:"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Format = "{0:N2}"
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99989938735961914R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "=IIf(Sum(Fields.Cargo)-Sum(Fields.Abono)<0,(Sum(Fields.Cargo)-Sum(Fields.Abono))*" & _
            "-1,0)"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Format = "{0:N2}"
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "= IIf(Sum(Fields.Cargo)-Sum(Fields.Abono)<0,0,Sum(Fields.Cargo)-Sum(Fields.Abono)" & _
            ")"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Style.Font.Bold = True
        Me.TextBox23.Style.Font.Name = "Arial"
        Me.TextBox23.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox23.StyleName = "Caption"
        Me.TextBox23.Value = "SALDO COA:"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Format = "{0:N2}"
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999934434890747R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Style.Font.Bold = True
        Me.TextBox24.Style.Font.Name = "Arial"
        Me.TextBox24.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "=Sum(Fields.Cargo)"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Format = "{0:N2}"
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999934434890747R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Style.Font.Bold = True
        Me.TextBox25.Style.Font.Name = "Arial"
        Me.TextBox25.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox25.StyleName = "Data"
        Me.TextBox25.Value = "=Sum(Fields.Abono)"
        '
        'proveedorGroup
        '
        Me.proveedorGroup.GroupFooter = Me.proveedorGroupFooter
        Me.proveedorGroup.GroupHeader = Me.proveedorGroupHeader
        Me.proveedorGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Proveedor")})
        Me.proveedorGroup.Name = "proveedorGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = False
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        Me.pageFooter.Style.Visible = True
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Name = "reportHeader"
        Me.reportHeader.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fechaContableDataTextBox, Me.areaDataTextBox, Me.idSubDiarioDataTextBox, Me.codigoDataTextBox, Me.TextBox1, Me.TextBox15, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20})
        Me.detail.Name = "detail"
        '
        'fechaContableDataTextBox
        '
        Me.fechaContableDataTextBox.CanGrow = True
        Me.fechaContableDataTextBox.Format = "{0:d}"
        Me.fechaContableDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00019964059174526483R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaContableDataTextBox.Name = "fechaContableDataTextBox"
        Me.fechaContableDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaContableDataTextBox.Style.Font.Name = "Arial"
        Me.fechaContableDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaContableDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaContableDataTextBox.StyleName = "Data"
        Me.fechaContableDataTextBox.Value = "=Fields.FechaContable"
        '
        'areaDataTextBox
        '
        Me.areaDataTextBox.CanGrow = True
        Me.areaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5003995895385742R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areaDataTextBox.Name = "areaDataTextBox"
        Me.areaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9994001388549805R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.areaDataTextBox.Style.Font.Name = "Arial"
        Me.areaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.areaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.areaDataTextBox.StyleName = "Data"
        Me.areaDataTextBox.Value = "= Fields.Registro"
        '
        'idSubDiarioDataTextBox
        '
        Me.idSubDiarioDataTextBox.CanGrow = True
        Me.idSubDiarioDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.500402450561523R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioDataTextBox.Name = "idSubDiarioDataTextBox"
        Me.idSubDiarioDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioDataTextBox.Style.Font.Name = "Arial"
        Me.idSubDiarioDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idSubDiarioDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.idSubDiarioDataTextBox.StyleName = "Data"
        Me.idSubDiarioDataTextBox.Value = "= Fields.codigo"
        '
        'codigoDataTextBox
        '
        Me.codigoDataTextBox.CanGrow = True
        Me.codigoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.000602722167969R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Name = "codigoDataTextBox"
        Me.codigoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9992003440856934R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Style.Font.Name = "Arial"
        Me.codigoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.codigoDataTextBox.StyleName = "Data"
        Me.codigoDataTextBox.Value = "= Fields.Glosa"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.Area"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.000202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "= Fields.IdSubDiario"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "= Fields.Cargo"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Format = "{0:N2}"
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "= Fields.Abono"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000003814697266R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.49919876456260681R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Data"
        Me.TextBox19.Value = "= Fields.IdMoneda"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00020024616969749331R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.StyleName = "Data"
        Me.TextBox20.Value = "= Fields.TipoCambio"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox38, Me.TextBox39, Me.TextBox4, Me.reportNameTextBox, Me.TextBox5, Me.TextBox10, Me.titleTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox6
        '
        Me.TextBox6.Format = "{0:g}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4998983144760132R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "=PageNumber"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:d}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.StyleName = "PageInfo"
        Me.TextBox7.Value = "Página:"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Fecha:"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000003814697266R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4998983144760132R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "= Now()"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.000003814697266R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4998983144760132R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(24.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Color = System.Drawing.Color.Black
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Title"
        Me.TextBox4.Value = "='DEL '+ Format('{0:dd/MM/yyyy}', Parameters.fechaInicio.Value)+' AL '+Format('{0" & _
            ":dd/MM/yyyy}', Parameters.fechaFin.Value)"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(21.499801635742187R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(21.499801635742187R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.StyleName = "PageInfo"
        Me.TextBox5.Value = "RUC: 20453262767"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(21.499801635742187R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.StyleName = "PageInfo"
        Me.TextBox10.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(24.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Color = System.Drawing.Color.Black
        Me.titleTextBox.Style.Font.Bold = True
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "='CUENTAS DE PROVEEDORES Y CLIENTES '+ IIf(Parameters.estado.Value='C','CANCELADA" & _
            "S', IIf(Parameters.estado.Value='P','PENDIENTES',''))"
        '
        'RegistroGroup
        '
        Me.RegistroGroup.GroupFooter = Me.GroupFooterSection1
        Me.RegistroGroup.GroupHeader = Me.GroupHeaderSection1
        Me.RegistroGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Registro")})
        Me.RegistroGroup.Name = "RegistroGroup"
        '
        'GroupFooterSection1
        '
        Me.GroupFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox16, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29})
        Me.GroupFooterSection1.Name = "GroupFooterSection1"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Sum(Fields.Abono)"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Format = "{0:N2}"
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "=Sum(Fields.Cargo)"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Name = "Arial"
        Me.TextBox26.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox26.StyleName = "Caption"
        Me.TextBox26.Value = "TOTAL DOCUMENTO:"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999934434890747R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Style.Font.Bold = True
        Me.TextBox27.Style.Font.Name = "Arial"
        Me.TextBox27.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.StyleName = "Caption"
        Me.TextBox27.Value = "SALDO DOCUMENTO:"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999934434890747R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Style.Font.Bold = True
        Me.TextBox28.Style.Font.Name = "Arial"
        Me.TextBox28.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "= IIf(Sum(Fields.Cargo)-Sum(Fields.Abono)<0,0,Sum(Fields.Cargo)-Sum(Fields.Abono)" & _
            ")"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Format = "{0:N2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999934434890747R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Style.Font.Bold = True
        Me.TextBox29.Style.Font.Name = "Arial"
        Me.TextBox29.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = "=IIf(Sum(Fields.Cargo)-Sum(Fields.Abono)<0,'('+Format('{0:N2}',(Sum(Fields.Cargo)" & _
            "-Sum(Fields.Abono))*-1)+')',0)"
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        Me.GroupHeaderSection1.Style.Visible = False
        '
        'RepMovCtaProveedores
        '
        Me.DataSource = Me.SDSRepMovCtasProveedores
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.cuentaGroup, Me.proveedorGroup, Me.RegistroGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.cuentaGroupHeader, Me.cuentaGroupFooter, Me.proveedorGroupHeader, Me.proveedorGroupFooter, Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm)
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
        ReportParameter3.Name = "idProvedor"
        ReportParameter3.Text = "idProvedor"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter3.Visible = True
        ReportParameter4.Name = "idProyecto"
        ReportParameter4.Text = "idProyecto"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter4.Visible = True
        ReportParameter5.Name = "idMoneda"
        ReportParameter5.Text = "idMoneda"
        ReportParameter5.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter5.Visible = True
        ReportParameter6.Name = "estado"
        ReportParameter6.Text = "estado"
        ReportParameter6.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.ReportParameters.Add(ReportParameter5)
        Me.ReportParameters.Add(ReportParameter6)
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(24.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepMovCtasProveedores As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fechaContableCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents areaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idSubDiarioCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codigoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents cuentaGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents cuentaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents cuentaGroup As Telerik.Reporting.Group
    Friend WithEvents proveedorGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents proveedorDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proveedorGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents proveedorGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fechaContableDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents areaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idSubDiarioDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codigoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents tipoCambioCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents proveedorCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents RegistroGroup As Telerik.Reporting.Group
    Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
End Class