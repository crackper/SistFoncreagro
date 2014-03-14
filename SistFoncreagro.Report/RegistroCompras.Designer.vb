Partial Class RegistroCompras
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroCompras))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter5 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.DSRegistroCompras = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.codigoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tipoDocCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.serieDocumentoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.nroDocumentoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tipoProveedorCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.rucCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.razonSocialCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible1CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.igv1CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible2CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.igv2CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible3CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.igv3CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.otrosCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.valorNoGravadasCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.totalCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.tipoCambioCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.fechaDocumentoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.igv1SumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible2SumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.igv2SumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible3SumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.igv3SumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.otrosSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.valorNoGravadasSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.totalSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.codigoDataTextBox = New Telerik.Reporting.TextBox()
        Me.tipoDocDataTextBox = New Telerik.Reporting.TextBox()
        Me.serieDocumentoDataTextBox = New Telerik.Reporting.TextBox()
        Me.nroDocumentoDataTextBox = New Telerik.Reporting.TextBox()
        Me.tipoProveedorDataTextBox = New Telerik.Reporting.TextBox()
        Me.rucDataTextBox = New Telerik.Reporting.TextBox()
        Me.razonSocialDataTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible1DataTextBox = New Telerik.Reporting.TextBox()
        Me.igv1DataTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible2DataTextBox = New Telerik.Reporting.TextBox()
        Me.igv2DataTextBox = New Telerik.Reporting.TextBox()
        Me.baseImponible3DataTextBox = New Telerik.Reporting.TextBox()
        Me.igv3DataTextBox = New Telerik.Reporting.TextBox()
        Me.otrosDataTextBox = New Telerik.Reporting.TextBox()
        Me.valorNoGravadasDataTextBox = New Telerik.Reporting.TextBox()
        Me.totalDataTextBox = New Telerik.Reporting.TextBox()
        Me.tipoCambioDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.fechaDocumentoDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TipoDoc = New Telerik.Reporting.Group()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DSRegistroCompras
        '
        Me.DSRegistroCompras.ConnectionString = "cnx"
        Me.DSRegistroCompras.Name = "DSRegistroCompras"
        Me.DSRegistroCompras.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@fechaIni", System.Data.DbType.DateTime, "=Parameters.fechaIni.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechaFin", System.Data.DbType.DateTime, "=Parameters.fechaFin.Value"), New Telerik.Reporting.SqlDataSourceParameter("@moneda", System.Data.DbType.Int32, "=Parameters.moneda.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProveedorCliente", System.Data.DbType.Int32, "=Parameters.idProveedorCliente.Value")})
        Me.DSRegistroCompras.SelectCommand = "dbo.RegCompras"
        Me.DSRegistroCompras.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.5045250654220581R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoCaptionTextBox, Me.tipoDocCaptionTextBox, Me.serieDocumentoCaptionTextBox, Me.nroDocumentoCaptionTextBox, Me.tipoProveedorCaptionTextBox, Me.rucCaptionTextBox, Me.razonSocialCaptionTextBox, Me.baseImponible1CaptionTextBox, Me.igv1CaptionTextBox, Me.baseImponible2CaptionTextBox, Me.igv2CaptionTextBox, Me.baseImponible3CaptionTextBox, Me.igv3CaptionTextBox, Me.otrosCaptionTextBox, Me.valorNoGravadasCaptionTextBox, Me.totalCaptionTextBox, Me.tipoCambioCaptionTextBox, Me.TextBox5, Me.TextBox6, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox28, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.fechaDocumentoCaptionTextBox, Me.TextBox29})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'codigoCaptionTextBox
        '
        Me.codigoCaptionTextBox.CanGrow = True
        Me.codigoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Name = "codigoCaptionTextBox"
        Me.codigoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.codigoCaptionTextBox.Style.Font.Name = "Arial"
        Me.codigoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoCaptionTextBox.StyleName = "Caption"
        Me.codigoCaptionTextBox.Value = "CÓDIGO UNICO DE LA OPERACIÓN"
        '
        'tipoDocCaptionTextBox
        '
        Me.tipoDocCaptionTextBox.CanGrow = True
        Me.tipoDocCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoDocCaptionTextBox.Name = "tipoDocCaptionTextBox"
        Me.tipoDocCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.49999985098838806R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoDocCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.tipoDocCaptionTextBox.Style.Font.Name = "Arial"
        Me.tipoDocCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoDocCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoDocCaptionTextBox.StyleName = "Caption"
        Me.tipoDocCaptionTextBox.Value = "TIPO"
        '
        'serieDocumentoCaptionTextBox
        '
        Me.serieDocumentoCaptionTextBox.CanGrow = True
        Me.serieDocumentoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.serieDocumentoCaptionTextBox.Name = "serieDocumentoCaptionTextBox"
        Me.serieDocumentoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.serieDocumentoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.serieDocumentoCaptionTextBox.Style.Font.Name = "Arial"
        Me.serieDocumentoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.serieDocumentoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.serieDocumentoCaptionTextBox.StyleName = "Caption"
        Me.serieDocumentoCaptionTextBox.Value = "SERIE"
        '
        'nroDocumentoCaptionTextBox
        '
        Me.nroDocumentoCaptionTextBox.CanGrow = True
        Me.nroDocumentoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.000099971686722710729R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nroDocumentoCaptionTextBox.Name = "nroDocumentoCaptionTextBox"
        Me.nroDocumentoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997998476028442R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.4998999834060669R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nroDocumentoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.nroDocumentoCaptionTextBox.Style.Font.Name = "Arial"
        Me.nroDocumentoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nroDocumentoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.nroDocumentoCaptionTextBox.StyleName = "Caption"
        Me.nroDocumentoCaptionTextBox.Value = "NÚMERO DEL COMPROBANTE DE PAGO"
        '
        'tipoProveedorCaptionTextBox
        '
        Me.tipoProveedorCaptionTextBox.CanGrow = True
        Me.tipoProveedorCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoProveedorCaptionTextBox.Name = "tipoProveedorCaptionTextBox"
        Me.tipoProveedorCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.49999904632568359R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoProveedorCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.tipoProveedorCaptionTextBox.Style.Font.Name = "Arial"
        Me.tipoProveedorCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoProveedorCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoProveedorCaptionTextBox.StyleName = "Caption"
        Me.tipoProveedorCaptionTextBox.Value = "TIPO"
        '
        'rucCaptionTextBox
        '
        Me.rucCaptionTextBox.CanGrow = True
        Me.rucCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.5000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.rucCaptionTextBox.Name = "rucCaptionTextBox"
        Me.rucCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.rucCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.rucCaptionTextBox.Style.Font.Name = "Arial"
        Me.rucCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.rucCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.rucCaptionTextBox.StyleName = "Caption"
        Me.rucCaptionTextBox.Value = "NÚMERO"
        '
        'razonSocialCaptionTextBox
        '
        Me.razonSocialCaptionTextBox.CanGrow = True
        Me.razonSocialCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialCaptionTextBox.Name = "razonSocialCaptionTextBox"
        Me.razonSocialCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.razonSocialCaptionTextBox.Style.Font.Name = "Arial"
        Me.razonSocialCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.razonSocialCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.razonSocialCaptionTextBox.StyleName = "Caption"
        Me.razonSocialCaptionTextBox.Value = "APELLIDOS Y NOMBRE, DENOMINACIÓN O RAZÓN SOCIAL"
        '
        'baseImponible1CaptionTextBox
        '
        Me.baseImponible1CaptionTextBox.CanGrow = True
        Me.baseImponible1CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible1CaptionTextBox.Name = "baseImponible1CaptionTextBox"
        Me.baseImponible1CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible1CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.baseImponible1CaptionTextBox.Style.Font.Name = "Arial"
        Me.baseImponible1CaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible1CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.baseImponible1CaptionTextBox.StyleName = "Caption"
        Me.baseImponible1CaptionTextBox.Value = "BASE IMPONIBLE"
        '
        'igv1CaptionTextBox
        '
        Me.igv1CaptionTextBox.CanGrow = True
        Me.igv1CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv1CaptionTextBox.Name = "igv1CaptionTextBox"
        Me.igv1CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv1CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.igv1CaptionTextBox.Style.Font.Name = "Arial"
        Me.igv1CaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv1CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.igv1CaptionTextBox.StyleName = "Caption"
        Me.igv1CaptionTextBox.Value = "IGV"
        '
        'baseImponible2CaptionTextBox
        '
        Me.baseImponible2CaptionTextBox.CanGrow = True
        Me.baseImponible2CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible2CaptionTextBox.Name = "baseImponible2CaptionTextBox"
        Me.baseImponible2CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible2CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.baseImponible2CaptionTextBox.Style.Font.Name = "Arial"
        Me.baseImponible2CaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible2CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.baseImponible2CaptionTextBox.StyleName = "Caption"
        Me.baseImponible2CaptionTextBox.Value = "BASE IMPONIBLE"
        '
        'igv2CaptionTextBox
        '
        Me.igv2CaptionTextBox.CanGrow = True
        Me.igv2CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv2CaptionTextBox.Name = "igv2CaptionTextBox"
        Me.igv2CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv2CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.igv2CaptionTextBox.Style.Font.Name = "Arial"
        Me.igv2CaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv2CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.igv2CaptionTextBox.StyleName = "Caption"
        Me.igv2CaptionTextBox.Value = "IGV"
        '
        'baseImponible3CaptionTextBox
        '
        Me.baseImponible3CaptionTextBox.CanGrow = True
        Me.baseImponible3CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible3CaptionTextBox.Name = "baseImponible3CaptionTextBox"
        Me.baseImponible3CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible3CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.baseImponible3CaptionTextBox.Style.Font.Name = "Arial"
        Me.baseImponible3CaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible3CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.baseImponible3CaptionTextBox.StyleName = "Caption"
        Me.baseImponible3CaptionTextBox.Value = "BASE IMPONIBLE"
        '
        'igv3CaptionTextBox
        '
        Me.igv3CaptionTextBox.CanGrow = True
        Me.igv3CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv3CaptionTextBox.Name = "igv3CaptionTextBox"
        Me.igv3CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv3CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.igv3CaptionTextBox.Style.Font.Name = "Arial"
        Me.igv3CaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv3CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.igv3CaptionTextBox.StyleName = "Caption"
        Me.igv3CaptionTextBox.Value = "IGV"
        '
        'otrosCaptionTextBox
        '
        Me.otrosCaptionTextBox.CanGrow = True
        Me.otrosCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.otrosCaptionTextBox.Name = "otrosCaptionTextBox"
        Me.otrosCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.49979829788208R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.otrosCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.otrosCaptionTextBox.Style.Font.Name = "Arial"
        Me.otrosCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.otrosCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.otrosCaptionTextBox.StyleName = "Caption"
        Me.otrosCaptionTextBox.Value = "OPERACIONES SUJETOS NO DOMICILIADOS"
        '
        'valorNoGravadasCaptionTextBox
        '
        Me.valorNoGravadasCaptionTextBox.CanGrow = True
        Me.valorNoGravadasCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.valorNoGravadasCaptionTextBox.Name = "valorNoGravadasCaptionTextBox"
        Me.valorNoGravadasCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.valorNoGravadasCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.valorNoGravadasCaptionTextBox.Style.Font.Name = "Arial"
        Me.valorNoGravadasCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.valorNoGravadasCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.valorNoGravadasCaptionTextBox.StyleName = "Caption"
        Me.valorNoGravadasCaptionTextBox.Value = "VALOR DE LAS ADQUISICIONES NO GRAVADAS"
        '
        'totalCaptionTextBox
        '
        Me.totalCaptionTextBox.CanGrow = True
        Me.totalCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalCaptionTextBox.Name = "totalCaptionTextBox"
        Me.totalCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.totalCaptionTextBox.Style.Font.Name = "Arial"
        Me.totalCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.totalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.totalCaptionTextBox.StyleName = "Caption"
        Me.totalCaptionTextBox.Value = "IMPORTE TOTAL"
        '
        'tipoCambioCaptionTextBox
        '
        Me.tipoCambioCaptionTextBox.CanGrow = True
        Me.tipoCambioCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoCambioCaptionTextBox.Name = "tipoCambioCaptionTextBox"
        Me.tipoCambioCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoCambioCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.tipoCambioCaptionTextBox.Style.Font.Name = "Arial"
        Me.tipoCambioCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoCambioCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoCambioCaptionTextBox.StyleName = "Caption"
        Me.tipoCambioCaptionTextBox.Value = "TIPO DE CAMBIO"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4999996423721313R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "COMPROBANTE DE PAGO"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.4999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "INFORMACIÓN DEL PROVEEDOR"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "DOCUMENTO DE IDENTIDAD"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.9952741265296936R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = " ADQUISICIONES GRAVADAS DESTINADAS A OPERACIONES GRAVADAS "
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.9952741265296936R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "ADQUISICIONES GRAVADAS DESTINADAS A OPERACIONES GRAVADAS  Y A OPERACIONES NO GRAV" & _
            "ADAS"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.9952741265296936R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = " ADQUISICIONES GRAVADAS DESTINADAS A OPERACIONES NO GRAVADAS"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.9999942779541R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.4998006820678711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.9952741265296936R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.Font.Name = "Arial"
        Me.TextBox28.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Caption"
        Me.TextBox28.Value = "REFERENCIA DEL COMPROBANTE DE PAGO O DOCUMENTO ORIGINAL QUE SE MODIFICA"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(29.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997998476028442R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox30.Style.Font.Name = "Arial"
        Me.TextBox30.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.StyleName = "Caption"
        Me.TextBox30.Value = "NÚMERO"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(28.9999942779541R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox31.Style.Font.Name = "Arial"
        Me.TextBox31.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.StyleName = "Caption"
        Me.TextBox31.Value = "SERIE"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(28.499992370605469R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.50000149011611938R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox32.Style.Font.Name = "Arial"
        Me.TextBox32.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.StyleName = "Caption"
        Me.TextBox32.Value = "TIPO"
        '
        'fechaDocumentoCaptionTextBox
        '
        Me.fechaDocumentoCaptionTextBox.CanGrow = True
        Me.fechaDocumentoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5006011724472046R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDocumentoCaptionTextBox.Name = "fechaDocumentoCaptionTextBox"
        Me.fechaDocumentoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.499198317527771R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDocumentoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaDocumentoCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaDocumentoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaDocumentoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaDocumentoCaptionTextBox.StyleName = "Caption"
        Me.fechaDocumentoCaptionTextBox.Value = "FECHA DE EMISIÓN DEL COMPROBANTE DE PAGO"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(27.000194549560547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99547439813613892R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.Font.Name = "Arial"
        Me.TextBox29.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Caption"
        Me.TextBox29.Value = "FECHA"
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
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.igv1SumFunctionTextBox, Me.baseImponible2SumFunctionTextBox, Me.igv2SumFunctionTextBox, Me.baseImponible3SumFunctionTextBox, Me.igv3SumFunctionTextBox, Me.otrosSumFunctionTextBox, Me.valorNoGravadasSumFunctionTextBox, Me.totalSumFunctionTextBox, Me.TextBox1, Me.TextBox14})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.reportFooter.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.reportFooter.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.reportFooter.Style.Visible = True
        '
        'igv1SumFunctionTextBox
        '
        Me.igv1SumFunctionTextBox.CanGrow = True
        Me.igv1SumFunctionTextBox.Format = "{0:N2}"
        Me.igv1SumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv1SumFunctionTextBox.Name = "igv1SumFunctionTextBox"
        Me.igv1SumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv1SumFunctionTextBox.Style.Font.Name = "Arial"
        Me.igv1SumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv1SumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.igv1SumFunctionTextBox.StyleName = "Data"
        Me.igv1SumFunctionTextBox.Value = "=Sum(Fields.Igv1)"
        '
        'baseImponible2SumFunctionTextBox
        '
        Me.baseImponible2SumFunctionTextBox.CanGrow = True
        Me.baseImponible2SumFunctionTextBox.Format = "{0:N2}"
        Me.baseImponible2SumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible2SumFunctionTextBox.Name = "baseImponible2SumFunctionTextBox"
        Me.baseImponible2SumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible2SumFunctionTextBox.Style.Font.Name = "Arial"
        Me.baseImponible2SumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible2SumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.baseImponible2SumFunctionTextBox.StyleName = "Data"
        Me.baseImponible2SumFunctionTextBox.Value = "=Sum(Fields.BaseImponible2)"
        '
        'igv2SumFunctionTextBox
        '
        Me.igv2SumFunctionTextBox.CanGrow = True
        Me.igv2SumFunctionTextBox.Format = "{0:N2}"
        Me.igv2SumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv2SumFunctionTextBox.Name = "igv2SumFunctionTextBox"
        Me.igv2SumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv2SumFunctionTextBox.Style.Font.Name = "Arial"
        Me.igv2SumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv2SumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.igv2SumFunctionTextBox.StyleName = "Data"
        Me.igv2SumFunctionTextBox.Value = "=Sum(Fields.Igv2)"
        '
        'baseImponible3SumFunctionTextBox
        '
        Me.baseImponible3SumFunctionTextBox.CanGrow = True
        Me.baseImponible3SumFunctionTextBox.Format = "{0:N2}"
        Me.baseImponible3SumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible3SumFunctionTextBox.Name = "baseImponible3SumFunctionTextBox"
        Me.baseImponible3SumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible3SumFunctionTextBox.Style.Font.Name = "Arial"
        Me.baseImponible3SumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible3SumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.baseImponible3SumFunctionTextBox.StyleName = "Data"
        Me.baseImponible3SumFunctionTextBox.Value = "=Sum(Fields.BaseImponible3)"
        '
        'igv3SumFunctionTextBox
        '
        Me.igv3SumFunctionTextBox.CanGrow = True
        Me.igv3SumFunctionTextBox.Format = "{0:N2}"
        Me.igv3SumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv3SumFunctionTextBox.Name = "igv3SumFunctionTextBox"
        Me.igv3SumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv3SumFunctionTextBox.Style.Font.Name = "Arial"
        Me.igv3SumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv3SumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.igv3SumFunctionTextBox.StyleName = "Data"
        Me.igv3SumFunctionTextBox.Value = "=Sum(Fields.Igv3)"
        '
        'otrosSumFunctionTextBox
        '
        Me.otrosSumFunctionTextBox.CanGrow = True
        Me.otrosSumFunctionTextBox.Format = "{0:N2}"
        Me.otrosSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.otrosSumFunctionTextBox.Name = "otrosSumFunctionTextBox"
        Me.otrosSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.49979829788208R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.otrosSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.otrosSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.otrosSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.otrosSumFunctionTextBox.StyleName = "Data"
        Me.otrosSumFunctionTextBox.Value = "=Sum(Fields.Otros)"
        '
        'valorNoGravadasSumFunctionTextBox
        '
        Me.valorNoGravadasSumFunctionTextBox.CanGrow = True
        Me.valorNoGravadasSumFunctionTextBox.Format = "{0:N2}"
        Me.valorNoGravadasSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500003814697266R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.valorNoGravadasSumFunctionTextBox.Name = "valorNoGravadasSumFunctionTextBox"
        Me.valorNoGravadasSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.valorNoGravadasSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.valorNoGravadasSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.valorNoGravadasSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.valorNoGravadasSumFunctionTextBox.StyleName = "Data"
        Me.valorNoGravadasSumFunctionTextBox.Value = "=Sum(Fields.ValorNoGravadas)"
        '
        'totalSumFunctionTextBox
        '
        Me.totalSumFunctionTextBox.CanGrow = True
        Me.totalSumFunctionTextBox.Format = "{0:N2}"
        Me.totalSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalSumFunctionTextBox.Name = "totalSumFunctionTextBox"
        Me.totalSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.totalSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.totalSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.totalSumFunctionTextBox.StyleName = "Data"
        Me.totalSumFunctionTextBox.Value = "=Sum(Fields.Total)"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Format = "{0:N2}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "=Sum(Fields.BaseImponible1)"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "TOTAL GENERAL: "
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.5000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox4, Me.TextBox2, Me.TextBox3, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.titleTextBox, Me.TextBox15, Me.TextBox37, Me.TextBox38, Me.TextBox39})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010007261880673468R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499090194702148R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox4
        '
        Me.TextBox4.Format = "{0:g}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(30.000106811523438R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.499793529510498R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "PageInfo"
        Me.TextBox4.Value = "=PageNumber"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010017355089075863R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499090194702148R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.StyleName = "PageInfo"
        Me.TextBox2.Value = "RUC: 20453262767"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010017355089075863R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499090194702148R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.StyleName = "PageInfo"
        Me.TextBox3.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:d}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(28.499990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5000033378601074R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.StyleName = "PageInfo"
        Me.TextBox7.Value = "Página:"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(28.499990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5000033378601074R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Fecha:"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(30.000106811523438R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.499793529510498R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "= Now()"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010022401693277061R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(31.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Color = System.Drawing.Color.Black
        Me.titleTextBox.Style.Font.Bold = True
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "REGISTRO DE COMPRAS"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(31.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.Color = System.Drawing.Color.Black
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Title"
        Me.TextBox15.Value = "= Fields.Proyecto"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(31.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox37.Style.Color = System.Drawing.Color.Black
        Me.TextBox37.Style.Font.Bold = True
        Me.TextBox37.Style.Font.Name = "Arial"
        Me.TextBox37.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.StyleName = "Title"
        Me.TextBox37.Value = resources.GetString("TextBox37.Value")
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(30.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.499793529510498R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(28.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999970197677612R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5000033378601074R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
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
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoDataTextBox, Me.tipoDocDataTextBox, Me.serieDocumentoDataTextBox, Me.nroDocumentoDataTextBox, Me.tipoProveedorDataTextBox, Me.rucDataTextBox, Me.razonSocialDataTextBox, Me.baseImponible1DataTextBox, Me.igv1DataTextBox, Me.baseImponible2DataTextBox, Me.igv2DataTextBox, Me.baseImponible3DataTextBox, Me.igv3DataTextBox, Me.otrosDataTextBox, Me.valorNoGravadasDataTextBox, Me.totalDataTextBox, Me.tipoCambioDataTextBox, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.fechaDocumentoDataTextBox, Me.TextBox33})
        Me.detail.Name = "detail"
        '
        'codigoDataTextBox
        '
        Me.codigoDataTextBox.CanGrow = True
        Me.codigoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Name = "codigoDataTextBox"
        Me.codigoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Style.Font.Name = "Arial"
        Me.codigoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoDataTextBox.StyleName = "Data"
        Me.codigoDataTextBox.Value = "=Fields.codigo"
        '
        'tipoDocDataTextBox
        '
        Me.tipoDocDataTextBox.CanGrow = True
        Me.tipoDocDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoDocDataTextBox.Name = "tipoDocDataTextBox"
        Me.tipoDocDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.49999985098838806R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoDocDataTextBox.Style.Font.Name = "Arial"
        Me.tipoDocDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoDocDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoDocDataTextBox.StyleName = "Data"
        Me.tipoDocDataTextBox.Value = "=Fields.TipoDoc"
        '
        'serieDocumentoDataTextBox
        '
        Me.serieDocumentoDataTextBox.CanGrow = True
        Me.serieDocumentoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.serieDocumentoDataTextBox.Name = "serieDocumentoDataTextBox"
        Me.serieDocumentoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.serieDocumentoDataTextBox.Style.Font.Name = "Arial"
        Me.serieDocumentoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.serieDocumentoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.serieDocumentoDataTextBox.StyleName = "Data"
        Me.serieDocumentoDataTextBox.Value = "=Fields.SerieDocumento"
        '
        'nroDocumentoDataTextBox
        '
        Me.nroDocumentoDataTextBox.CanGrow = True
        Me.nroDocumentoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nroDocumentoDataTextBox.Name = "nroDocumentoDataTextBox"
        Me.nroDocumentoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997998476028442R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nroDocumentoDataTextBox.Style.Font.Name = "Arial"
        Me.nroDocumentoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nroDocumentoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.nroDocumentoDataTextBox.StyleName = "Data"
        Me.nroDocumentoDataTextBox.Value = "=Fields.NroDocumento"
        '
        'tipoProveedorDataTextBox
        '
        Me.tipoProveedorDataTextBox.CanGrow = True
        Me.tipoProveedorDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoProveedorDataTextBox.Name = "tipoProveedorDataTextBox"
        Me.tipoProveedorDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.49999904632568359R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoProveedorDataTextBox.Style.Font.Name = "Arial"
        Me.tipoProveedorDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoProveedorDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoProveedorDataTextBox.StyleName = "Data"
        Me.tipoProveedorDataTextBox.Value = "=Fields.TipoProveedor"
        '
        'rucDataTextBox
        '
        Me.rucDataTextBox.CanGrow = True
        Me.rucDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.5000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.rucDataTextBox.Name = "rucDataTextBox"
        Me.rucDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.rucDataTextBox.Style.Font.Name = "Arial"
        Me.rucDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.rucDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.rucDataTextBox.StyleName = "Data"
        Me.rucDataTextBox.Value = "=Fields.Ruc"
        '
        'razonSocialDataTextBox
        '
        Me.razonSocialDataTextBox.CanGrow = True
        Me.razonSocialDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialDataTextBox.Name = "razonSocialDataTextBox"
        Me.razonSocialDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialDataTextBox.Style.Font.Name = "Arial"
        Me.razonSocialDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.razonSocialDataTextBox.StyleName = "Data"
        Me.razonSocialDataTextBox.Value = "=Fields.RazonSocial"
        '
        'baseImponible1DataTextBox
        '
        Me.baseImponible1DataTextBox.CanGrow = True
        Me.baseImponible1DataTextBox.Format = "{0:N2}"
        Me.baseImponible1DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible1DataTextBox.Name = "baseImponible1DataTextBox"
        Me.baseImponible1DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible1DataTextBox.Style.Font.Name = "Arial"
        Me.baseImponible1DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible1DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.baseImponible1DataTextBox.StyleName = "Data"
        Me.baseImponible1DataTextBox.Value = "=Fields.BaseImponible1"
        '
        'igv1DataTextBox
        '
        Me.igv1DataTextBox.CanGrow = True
        Me.igv1DataTextBox.Format = "{0:N2}"
        Me.igv1DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv1DataTextBox.Name = "igv1DataTextBox"
        Me.igv1DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv1DataTextBox.Style.Font.Name = "Arial"
        Me.igv1DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv1DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.igv1DataTextBox.StyleName = "Data"
        Me.igv1DataTextBox.Value = "=Fields.Igv1"
        '
        'baseImponible2DataTextBox
        '
        Me.baseImponible2DataTextBox.CanGrow = True
        Me.baseImponible2DataTextBox.Format = "{0:N2}"
        Me.baseImponible2DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible2DataTextBox.Name = "baseImponible2DataTextBox"
        Me.baseImponible2DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible2DataTextBox.Style.Font.Name = "Arial"
        Me.baseImponible2DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible2DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.baseImponible2DataTextBox.StyleName = "Data"
        Me.baseImponible2DataTextBox.Value = "=Fields.BaseImponible2"
        '
        'igv2DataTextBox
        '
        Me.igv2DataTextBox.CanGrow = True
        Me.igv2DataTextBox.Format = "{0:N2}"
        Me.igv2DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv2DataTextBox.Name = "igv2DataTextBox"
        Me.igv2DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv2DataTextBox.Style.Font.Name = "Arial"
        Me.igv2DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv2DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.igv2DataTextBox.StyleName = "Data"
        Me.igv2DataTextBox.Value = "=Fields.Igv2"
        '
        'baseImponible3DataTextBox
        '
        Me.baseImponible3DataTextBox.CanGrow = True
        Me.baseImponible3DataTextBox.Format = "{0:N2}"
        Me.baseImponible3DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible3DataTextBox.Name = "baseImponible3DataTextBox"
        Me.baseImponible3DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.baseImponible3DataTextBox.Style.Font.Name = "Arial"
        Me.baseImponible3DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.baseImponible3DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.baseImponible3DataTextBox.StyleName = "Data"
        Me.baseImponible3DataTextBox.Value = "=Fields.BaseImponible3"
        '
        'igv3DataTextBox
        '
        Me.igv3DataTextBox.CanGrow = True
        Me.igv3DataTextBox.Format = "{0:N2}"
        Me.igv3DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv3DataTextBox.Name = "igv3DataTextBox"
        Me.igv3DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.igv3DataTextBox.Style.Font.Name = "Arial"
        Me.igv3DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.igv3DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.igv3DataTextBox.StyleName = "Data"
        Me.igv3DataTextBox.Value = "=Fields.Igv3"
        '
        'otrosDataTextBox
        '
        Me.otrosDataTextBox.CanGrow = True
        Me.otrosDataTextBox.Format = "{0:N2}"
        Me.otrosDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.otrosDataTextBox.Name = "otrosDataTextBox"
        Me.otrosDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.49979829788208R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.otrosDataTextBox.Style.Font.Name = "Arial"
        Me.otrosDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.otrosDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.otrosDataTextBox.StyleName = "Data"
        Me.otrosDataTextBox.Value = "=Fields.Otros"
        '
        'valorNoGravadasDataTextBox
        '
        Me.valorNoGravadasDataTextBox.CanGrow = True
        Me.valorNoGravadasDataTextBox.Format = "{0:N2}"
        Me.valorNoGravadasDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500003814697266R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.valorNoGravadasDataTextBox.Name = "valorNoGravadasDataTextBox"
        Me.valorNoGravadasDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.valorNoGravadasDataTextBox.Style.Font.Name = "Arial"
        Me.valorNoGravadasDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.valorNoGravadasDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.valorNoGravadasDataTextBox.StyleName = "Data"
        Me.valorNoGravadasDataTextBox.Value = "=Fields.ValorNoGravadas"
        '
        'totalDataTextBox
        '
        Me.totalDataTextBox.CanGrow = True
        Me.totalDataTextBox.Format = "{0:N2}"
        Me.totalDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalDataTextBox.Name = "totalDataTextBox"
        Me.totalDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalDataTextBox.Style.Font.Name = "Arial"
        Me.totalDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.totalDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.totalDataTextBox.StyleName = "Data"
        Me.totalDataTextBox.Value = "=Fields.Total"
        '
        'tipoCambioDataTextBox
        '
        Me.tipoCambioDataTextBox.CanGrow = True
        Me.tipoCambioDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoCambioDataTextBox.Name = "tipoCambioDataTextBox"
        Me.tipoCambioDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.tipoCambioDataTextBox.Style.Font.Name = "Arial"
        Me.tipoCambioDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.tipoCambioDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.tipoCambioDataTextBox.StyleName = "Data"
        Me.tipoCambioDataTextBox.Value = "=Fields.TipoCambio"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(29.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997998476028442R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox34.Style.Font.Name = "Arial"
        Me.TextBox34.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.StyleName = "Data"
        Me.TextBox34.Value = "= Fields.NroDocRef"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(28.9999942779541R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox35.Style.Font.Name = "Arial"
        Me.TextBox35.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.StyleName = "Data"
        Me.TextBox35.Value = "= Fields.SerieDocRef"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(28.499992370605469R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.50000149011611938R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox36.Style.Font.Name = "Arial"
        Me.TextBox36.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.StyleName = "Data"
        Me.TextBox36.Value = "= Fields.TipoDocRef"
        '
        'fechaDocumentoDataTextBox
        '
        Me.fechaDocumentoDataTextBox.CanGrow = True
        Me.fechaDocumentoDataTextBox.Format = "{0:d}"
        Me.fechaDocumentoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5006011724472046R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00020014523761346936R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDocumentoDataTextBox.Name = "fechaDocumentoDataTextBox"
        Me.fechaDocumentoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.499198317527771R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDocumentoDataTextBox.Style.Font.Name = "Arial"
        Me.fechaDocumentoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaDocumentoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaDocumentoDataTextBox.StyleName = "Data"
        Me.fechaDocumentoDataTextBox.Value = "=Fields.FechaDocumento"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Format = "{0:d}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.9999942779541R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.499198317527771R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox33.Style.Font.Name = "Arial"
        Me.TextBox33.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.StyleName = "Data"
        Me.TextBox33.Value = "= Fields.FechaDocRef"
        '
        'TipoDoc
        '
        Me.TipoDoc.GroupFooter = Me.GroupFooterSection1
        Me.TipoDoc.GroupHeader = Me.GroupHeaderSection1
        Me.TipoDoc.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.TipoDoc")})
        Me.TipoDoc.Name = "TipoDoc"
        '
        'GroupFooterSection1
        '
        Me.GroupFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27})
        Me.GroupFooterSection1.Name = "GroupFooterSection1"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "TOTAL DOCUMENTO: "
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.503338813781738R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "=Sum(Fields.BaseImponible1)"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Format = "{0:N2}"
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "=Sum(Fields.Total)"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Format = "{0:N2}"
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.499176025390625R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "=Sum(Fields.ValorNoGravadas)"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Format = "{0:N2}"
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.49979829788208R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "=Sum(Fields.Otros)"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Format = "{0:N2}"
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Style.Font.Name = "Arial"
        Me.TextBox23.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox23.StyleName = "Data"
        Me.TextBox23.Value = "=Sum(Fields.Igv3)"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Format = "{0:N2}"
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Style.Font.Name = "Arial"
        Me.TextBox24.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "=Sum(Fields.BaseImponible3)"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Format = "{0:N2}"
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.001260757446289R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Style.Font.Name = "Arial"
        Me.TextBox25.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox25.StyleName = "Data"
        Me.TextBox25.Value = "=Sum(Fields.Igv2)"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Format = "{0:N2}"
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Style.Font.Name = "Arial"
        Me.TextBox26.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox26.StyleName = "Data"
        Me.TextBox26.Value = "=Sum(Fields.BaseImponible2)"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Format = "{0:N2}"
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Style.Font.Name = "Arial"
        Me.TextBox27.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.StyleName = "Data"
        Me.TextBox27.Value = "=Sum(Fields.Igv1)"
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox20, Me.TextBox19})
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(11.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox20.StyleName = "Data"
        Me.TextBox20.Value = "= Fields.NombreDoc"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Data"
        Me.TextBox19.Value = "=Fields.TipoDoc"
        '
        'RegistroCompras
        '
        Me.DataSource = Me.DSRegistroCompras
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.TipoDoc})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(21.590000152587891R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(32.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        ReportParameter1.Name = "fechaIni"
        ReportParameter1.Text = "fechaIni"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        ReportParameter2.Name = "fechaFin"
        ReportParameter2.Text = "fechaFin"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Visible = True
        ReportParameter3.Name = "moneda"
        ReportParameter3.Text = "moneda"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter3.Visible = True
        ReportParameter4.Name = "idProyecto"
        ReportParameter4.Text = "idProyecto"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter4.Visible = True
        ReportParameter5.Name = "idProveedorCliente"
        ReportParameter5.Text = "idProveedorCliente"
        ReportParameter5.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter5.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.ReportParameters.Add(ReportParameter5)
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(31.500099182128906R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents DSRegistroCompras As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents codigoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoDocCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents serieDocumentoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nroDocumentoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaDocumentoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoProveedorCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents rucCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents razonSocialCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible1CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv1CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible2CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv2CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible3CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv3CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents otrosCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents valorNoGravadasCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents totalCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoCambioCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents igv1SumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible2SumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv2SumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible3SumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv3SumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents otrosSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents valorNoGravadasSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents totalSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents codigoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoDocDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents serieDocumentoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nroDocumentoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaDocumentoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoProveedorDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents rucDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents razonSocialDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible1DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv1DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible2DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv2DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents baseImponible3DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents igv3DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents otrosDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents valorNoGravadasDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents totalDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents tipoCambioDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TipoDoc As Telerik.Reporting.Group
    Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
End Class