Partial Class RepBalanceComprobacion
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepBalanceComprobacion = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.codigoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.deudorInicialCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.acreedorInicialCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.debeCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.haberCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.deudorFinalCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.acreedorFinalCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.activoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pasivoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.perdidaFCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.gananciaFCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.codigoN2GroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.codigoN2DataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.codigoN2GroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.deudorInicialSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.acreedorInicialSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.debeSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.haberSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.deudorFinalSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.acreedorFinalSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.activoSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.pasivoSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.perdidaFSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.gananciaFSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.codigoN2Group = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.gananciaFSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.perdidaFSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.pasivoSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.activoSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoAcreedorSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoDeudorSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.haberMNSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.debeMNSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.codigoDataTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionDataTextBox = New Telerik.Reporting.TextBox()
        Me.deudorInicialDataTextBox = New Telerik.Reporting.TextBox()
        Me.acreedorInicialDataTextBox = New Telerik.Reporting.TextBox()
        Me.debeDataTextBox = New Telerik.Reporting.TextBox()
        Me.haberDataTextBox = New Telerik.Reporting.TextBox()
        Me.deudorFinalDataTextBox = New Telerik.Reporting.TextBox()
        Me.acreedorFinalDataTextBox = New Telerik.Reporting.TextBox()
        Me.activoDataTextBox = New Telerik.Reporting.TextBox()
        Me.pasivoDataTextBox = New Telerik.Reporting.TextBox()
        Me.perdidaFDataTextBox = New Telerik.Reporting.TextBox()
        Me.gananciaFDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepBalanceComprobacion
        '
        Me.SDSRepBalanceComprobacion.ConnectionString = "cnx"
        Me.SDSRepBalanceComprobacion.Name = "SDSRepBalanceComprobacion"
        Me.SDSRepBalanceComprobacion.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@Fecha", System.Data.DbType.DateTime, "=Parameters.Fecha.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idMoneda", System.Data.DbType.Int32, "=Parameters.idMoneda.Value"), New Telerik.Reporting.SqlDataSourceParameter("@tipo", System.Data.DbType.AnsiStringFixedLength, "=Parameters.tipo.Value")})
        Me.SDSRepBalanceComprobacion.SelectCommand = "dbo.RepBalanceComprobacion"
        Me.SDSRepBalanceComprobacion.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoCaptionTextBox, Me.descripcionCaptionTextBox, Me.deudorInicialCaptionTextBox, Me.acreedorInicialCaptionTextBox, Me.debeCaptionTextBox, Me.haberCaptionTextBox, Me.deudorFinalCaptionTextBox, Me.acreedorFinalCaptionTextBox, Me.activoCaptionTextBox, Me.pasivoCaptionTextBox, Me.perdidaFCaptionTextBox, Me.gananciaFCaptionTextBox, Me.TextBox15, Me.TextBox16, Me.TextBox19, Me.TextBox20, Me.TextBox25, Me.TextBox26})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'codigoCaptionTextBox
        '
        Me.codigoCaptionTextBox.CanGrow = True
        Me.codigoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Name = "codigoCaptionTextBox"
        Me.codigoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.codigoCaptionTextBox.Style.Font.Name = "Arial"
        Me.codigoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoCaptionTextBox.StyleName = "Caption"
        Me.codigoCaptionTextBox.Value = "CÓDIGO"
        '
        'descripcionCaptionTextBox
        '
        Me.descripcionCaptionTextBox.CanGrow = True
        Me.descripcionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5001999139785767R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Name = "descripcionCaptionTextBox"
        Me.descripcionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9980950355529785R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.descripcionCaptionTextBox.Style.Font.Name = "Arial"
        Me.descripcionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.descripcionCaptionTextBox.StyleName = "Caption"
        Me.descripcionCaptionTextBox.Value = "DENOMINACIÓN"
        '
        'deudorInicialCaptionTextBox
        '
        Me.deudorInicialCaptionTextBox.CanGrow = True
        Me.deudorInicialCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.4984951019287109R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorInicialCaptionTextBox.Name = "deudorInicialCaptionTextBox"
        Me.deudorInicialCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorInicialCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.deudorInicialCaptionTextBox.Style.Font.Name = "Arial"
        Me.deudorInicialCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.deudorInicialCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.deudorInicialCaptionTextBox.StyleName = "Caption"
        Me.deudorInicialCaptionTextBox.Value = "DEUDOR"
        '
        'acreedorInicialCaptionTextBox
        '
        Me.acreedorInicialCaptionTextBox.CanGrow = True
        Me.acreedorInicialCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.498695373535156R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorInicialCaptionTextBox.Name = "acreedorInicialCaptionTextBox"
        Me.acreedorInicialCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorInicialCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.acreedorInicialCaptionTextBox.Style.Font.Name = "Arial"
        Me.acreedorInicialCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.acreedorInicialCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.acreedorInicialCaptionTextBox.StyleName = "Caption"
        Me.acreedorInicialCaptionTextBox.Value = "ACREEDOR"
        '
        'debeCaptionTextBox
        '
        Me.debeCaptionTextBox.CanGrow = True
        Me.debeCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.498893737792969R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50009989738464355R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeCaptionTextBox.Name = "debeCaptionTextBox"
        Me.debeCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.debeCaptionTextBox.Style.Font.Name = "Arial"
        Me.debeCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.debeCaptionTextBox.StyleName = "Caption"
        Me.debeCaptionTextBox.Value = "DEBE"
        '
        'haberCaptionTextBox
        '
        Me.haberCaptionTextBox.CanGrow = True
        Me.haberCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.49909496307373R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberCaptionTextBox.Name = "haberCaptionTextBox"
        Me.haberCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.haberCaptionTextBox.Style.Font.Name = "Arial"
        Me.haberCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.haberCaptionTextBox.StyleName = "Caption"
        Me.haberCaptionTextBox.Value = "HABER"
        '
        'deudorFinalCaptionTextBox
        '
        Me.deudorFinalCaptionTextBox.CanGrow = True
        Me.deudorFinalCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499296188354492R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorFinalCaptionTextBox.Name = "deudorFinalCaptionTextBox"
        Me.deudorFinalCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorFinalCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.deudorFinalCaptionTextBox.Style.Font.Name = "Arial"
        Me.deudorFinalCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.deudorFinalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.deudorFinalCaptionTextBox.StyleName = "Caption"
        Me.deudorFinalCaptionTextBox.Value = "DEUDOR"
        '
        'acreedorFinalCaptionTextBox
        '
        Me.acreedorFinalCaptionTextBox.CanGrow = True
        Me.acreedorFinalCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.499496459960937R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorFinalCaptionTextBox.Name = "acreedorFinalCaptionTextBox"
        Me.acreedorFinalCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorFinalCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.acreedorFinalCaptionTextBox.Style.Font.Name = "Arial"
        Me.acreedorFinalCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.acreedorFinalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.acreedorFinalCaptionTextBox.StyleName = "Caption"
        Me.acreedorFinalCaptionTextBox.Value = "ACREEDOR"
        '
        'activoCaptionTextBox
        '
        Me.activoCaptionTextBox.CanGrow = True
        Me.activoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.499698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoCaptionTextBox.Name = "activoCaptionTextBox"
        Me.activoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.activoCaptionTextBox.Style.Font.Name = "Arial"
        Me.activoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.activoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.activoCaptionTextBox.StyleName = "Caption"
        Me.activoCaptionTextBox.Value = "ACTIVO"
        '
        'pasivoCaptionTextBox
        '
        Me.pasivoCaptionTextBox.CanGrow = True
        Me.pasivoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.499898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoCaptionTextBox.Name = "pasivoCaptionTextBox"
        Me.pasivoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.pasivoCaptionTextBox.Style.Font.Name = "Arial"
        Me.pasivoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.pasivoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pasivoCaptionTextBox.StyleName = "Caption"
        Me.pasivoCaptionTextBox.Value = "PASIVO Y PATRIMONIO"
        '
        'perdidaFCaptionTextBox
        '
        Me.perdidaFCaptionTextBox.CanGrow = True
        Me.perdidaFCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.499799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFCaptionTextBox.Name = "perdidaFCaptionTextBox"
        Me.perdidaFCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.perdidaFCaptionTextBox.Style.Font.Name = "Arial"
        Me.perdidaFCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.perdidaFCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.perdidaFCaptionTextBox.StyleName = "Caption"
        Me.perdidaFCaptionTextBox.Value = "PÉRDIDAS"
        '
        'gananciaFCaptionTextBox
        '
        Me.gananciaFCaptionTextBox.CanGrow = True
        Me.gananciaFCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFCaptionTextBox.Name = "gananciaFCaptionTextBox"
        Me.gananciaFCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.gananciaFCaptionTextBox.Style.Font.Name = "Arial"
        Me.gananciaFCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.gananciaFCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.gananciaFCaptionTextBox.StyleName = "Caption"
        Me.gananciaFCaptionTextBox.Value = "GANANCIAS"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.498295783996582R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Caption"
        Me.TextBox15.Value = "CUENTA Y SUB CUENTA CONTABLE"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.4984960556030273R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0001974105834961R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Caption"
        Me.TextBox16.Value = "SALDOS INICIALES"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.498894691467285R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0001974105834961R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "MOVIMIENTOS"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499300003051758R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0001974105834961R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.StyleName = "Caption"
        Me.TextBox20.Value = "SALDOS FINALES"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.499700546264648R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0001974105834961R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.Font.Name = "Arial"
        Me.TextBox25.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.StyleName = "Caption"
        Me.TextBox25.Value = "SALDOS FINALES DELBALANCE GENERAL"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0001974105834961R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox26.Style.Font.Name = "Arial"
        Me.TextBox26.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.StyleName = "Caption"
        Me.TextBox26.Value = "SALDOS FINALES DEL ESTADO DE PÉRDIDAS Y GANANCIAS POR FUNCIÓN"
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
        'codigoN2GroupHeader
        '
        Me.codigoN2GroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codigoN2GroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoN2DataTextBox, Me.TextBox3})
        Me.codigoN2GroupHeader.Name = "codigoN2GroupHeader"
        '
        'codigoN2DataTextBox
        '
        Me.codigoN2DataTextBox.CanGrow = True
        Me.codigoN2DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoN2DataTextBox.Name = "codigoN2DataTextBox"
        Me.codigoN2DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoN2DataTextBox.Style.Font.Name = "Arial"
        Me.codigoN2DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoN2DataTextBox.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.30000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codigoN2DataTextBox.StyleName = "Data"
        Me.codigoN2DataTextBox.Value = "=Fields.CodigoN2"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9980950355529785R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "= Fields.Descripcion2"
        '
        'codigoN2GroupFooter
        '
        Me.codigoN2GroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.699999988079071R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codigoN2GroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.deudorInicialSumFunctionTextBox, Me.acreedorInicialSumFunctionTextBox, Me.debeSumFunctionTextBox, Me.haberSumFunctionTextBox, Me.deudorFinalSumFunctionTextBox, Me.acreedorFinalSumFunctionTextBox, Me.activoSumFunctionTextBox, Me.pasivoSumFunctionTextBox, Me.perdidaFSumFunctionTextBox, Me.gananciaFSumFunctionTextBox, Me.TextBox4})
        Me.codigoN2GroupFooter.Name = "codigoN2GroupFooter"
        '
        'deudorInicialSumFunctionTextBox
        '
        Me.deudorInicialSumFunctionTextBox.CanGrow = True
        Me.deudorInicialSumFunctionTextBox.Format = "{0:N2}"
        Me.deudorInicialSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.4984951019287109R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorInicialSumFunctionTextBox.Name = "deudorInicialSumFunctionTextBox"
        Me.deudorInicialSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorInicialSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.deudorInicialSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.deudorInicialSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.deudorInicialSumFunctionTextBox.StyleName = "Data"
        Me.deudorInicialSumFunctionTextBox.Value = "=Sum(Fields.DeudorInicial)"
        '
        'acreedorInicialSumFunctionTextBox
        '
        Me.acreedorInicialSumFunctionTextBox.CanGrow = True
        Me.acreedorInicialSumFunctionTextBox.Format = "{0:N2}"
        Me.acreedorInicialSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.498695373535156R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorInicialSumFunctionTextBox.Name = "acreedorInicialSumFunctionTextBox"
        Me.acreedorInicialSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorInicialSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.acreedorInicialSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.acreedorInicialSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.acreedorInicialSumFunctionTextBox.StyleName = "Data"
        Me.acreedorInicialSumFunctionTextBox.Value = "=Sum(Fields.AcreedorInicial)"
        '
        'debeSumFunctionTextBox
        '
        Me.debeSumFunctionTextBox.CanGrow = True
        Me.debeSumFunctionTextBox.Format = "{0:N2}"
        Me.debeSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.498893737792969R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeSumFunctionTextBox.Name = "debeSumFunctionTextBox"
        Me.debeSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.debeSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeSumFunctionTextBox.StyleName = "Data"
        Me.debeSumFunctionTextBox.Value = "=Sum(Fields.Debe)"
        '
        'haberSumFunctionTextBox
        '
        Me.haberSumFunctionTextBox.CanGrow = True
        Me.haberSumFunctionTextBox.Format = "{0:N2}"
        Me.haberSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499095916748047R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberSumFunctionTextBox.Name = "haberSumFunctionTextBox"
        Me.haberSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.haberSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberSumFunctionTextBox.StyleName = "Data"
        Me.haberSumFunctionTextBox.Value = "=Sum(Fields.Haber)"
        '
        'deudorFinalSumFunctionTextBox
        '
        Me.deudorFinalSumFunctionTextBox.CanGrow = True
        Me.deudorFinalSumFunctionTextBox.Format = "{0:N2}"
        Me.deudorFinalSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499296188354492R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorFinalSumFunctionTextBox.Name = "deudorFinalSumFunctionTextBox"
        Me.deudorFinalSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorFinalSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.deudorFinalSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.deudorFinalSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.deudorFinalSumFunctionTextBox.StyleName = "Data"
        Me.deudorFinalSumFunctionTextBox.Value = "= IIf(Sum(Fields.DeudorFinal)-Sum(Fields.AcreedorFinal)<0,0,Sum(Fields.DeudorFina" & _
            "l)-Sum(Fields.AcreedorFinal))"
        '
        'acreedorFinalSumFunctionTextBox
        '
        Me.acreedorFinalSumFunctionTextBox.CanGrow = True
        Me.acreedorFinalSumFunctionTextBox.Format = "{0:N2}"
        Me.acreedorFinalSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.49949836730957R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorFinalSumFunctionTextBox.Name = "acreedorFinalSumFunctionTextBox"
        Me.acreedorFinalSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorFinalSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.acreedorFinalSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.acreedorFinalSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.acreedorFinalSumFunctionTextBox.StyleName = "Data"
        Me.acreedorFinalSumFunctionTextBox.Value = "= IIf(Sum(Fields.DeudorFinal)-Sum(Fields.AcreedorFinal)<0,(Sum(Fields.DeudorFinal" & _
            ")-Sum(Fields.AcreedorFinal))*-1,0)"
        '
        'activoSumFunctionTextBox
        '
        Me.activoSumFunctionTextBox.CanGrow = True
        Me.activoSumFunctionTextBox.Format = "{0:N2}"
        Me.activoSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.499698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoSumFunctionTextBox.Name = "activoSumFunctionTextBox"
        Me.activoSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.activoSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.activoSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.activoSumFunctionTextBox.StyleName = "Data"
        Me.activoSumFunctionTextBox.Value = "= IIf(Sum(Fields.Activo)-Sum(Fields.Pasivo)<0,0,Sum(Fields.Activo)-Sum(Fields.Pas" & _
            "ivo))"
        '
        'pasivoSumFunctionTextBox
        '
        Me.pasivoSumFunctionTextBox.CanGrow = True
        Me.pasivoSumFunctionTextBox.Format = "{0:N2}"
        Me.pasivoSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.499898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoSumFunctionTextBox.Name = "pasivoSumFunctionTextBox"
        Me.pasivoSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.pasivoSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.pasivoSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pasivoSumFunctionTextBox.StyleName = "Data"
        Me.pasivoSumFunctionTextBox.Value = "= IIf(Sum(Fields.Activo)-Sum(Fields.Pasivo)<0,(Sum(Fields.Activo)-Sum(Fields.Pasi" & _
            "vo))*-1,0)"
        '
        'perdidaFSumFunctionTextBox
        '
        Me.perdidaFSumFunctionTextBox.CanGrow = True
        Me.perdidaFSumFunctionTextBox.Format = "{0:N2}"
        Me.perdidaFSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.499799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFSumFunctionTextBox.Name = "perdidaFSumFunctionTextBox"
        Me.perdidaFSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.perdidaFSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.perdidaFSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.perdidaFSumFunctionTextBox.StyleName = "Data"
        Me.perdidaFSumFunctionTextBox.Value = "= IIf(Sum(Fields.PerdidaF)-Sum(Fields.GananciaF)<0,0,Sum(Fields.PerdidaF)-Sum(Fie" & _
            "lds.GananciaF))"
        '
        'gananciaFSumFunctionTextBox
        '
        Me.gananciaFSumFunctionTextBox.CanGrow = True
        Me.gananciaFSumFunctionTextBox.Format = "{0:N2}"
        Me.gananciaFSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFSumFunctionTextBox.Name = "gananciaFSumFunctionTextBox"
        Me.gananciaFSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.gananciaFSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.gananciaFSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.gananciaFSumFunctionTextBox.StyleName = "Data"
        Me.gananciaFSumFunctionTextBox.Value = "= IIf(Sum(Fields.PerdidaF)-Sum(Fields.GananciaF)<0,(Sum(Fields.PerdidaF)-Sum(Fiel" & _
            "ds.GananciaF))*-1,0)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5001999139785767R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9980955123901367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= 'TOTAL '+ Fields.Descripcion2"
        '
        'codigoN2Group
        '
        Me.codigoN2Group.GroupFooter = Me.codigoN2GroupFooter
        Me.codigoN2Group.GroupHeader = Me.codigoN2GroupHeader
        Me.codigoN2Group.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.CodigoN2")})
        Me.codigoN2Group.Name = "codigoN2Group"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(1.4999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox31, Me.TextBox30, Me.TextBox28, Me.TextBox27, Me.TextBox24, Me.TextBox23, Me.TextBox22, Me.TextBox21, Me.TextBox18, Me.TextBox17, Me.gananciaFSumFunctionTextBox1, Me.perdidaFSumFunctionTextBox1, Me.pasivoSumFunctionTextBox1, Me.activoSumFunctionTextBox1, Me.saldoAcreedorSumFunctionTextBox1, Me.saldoDeudorSumFunctionTextBox1, Me.haberMNSumFunctionTextBox1, Me.debeMNSumFunctionTextBox1, Me.TextBox1, Me.TextBox12, Me.TextBox14})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499296188354492R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999868869781494R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0002012252807617R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Style.Font.Name = "Arial"
        Me.TextBox31.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox31.StyleName = "Caption"
        Me.TextBox31.Value = "TOTALES:"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499296188354492R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.499998539686203R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0002012252807617R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Style.Font.Name = "Arial"
        Me.TextBox30.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox30.StyleName = "Caption"
        Me.TextBox30.Value = "RESULTADO DEL EJERCICIO :"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999868869781494R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Style.Font.Name = "Arial"
        Me.TextBox28.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "=Sum(Fields.GananciaF)+IIf(Sum(Fields.PerdidaF)-Sum(Fields.GananciaF)>0,Sum(Field" & _
            "s.PerdidaF)-Sum(Fields.GananciaF),0)"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Format = "{0:N2}"
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999868869781494R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Style.Font.Name = "Arial"
        Me.TextBox27.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.StyleName = "Data"
        Me.TextBox27.Value = "=Sum(Fields.PerdidaF)+IIf(Sum(Fields.PerdidaF)-Sum(Fields.GananciaF)<0,(Sum(Field" & _
            "s.PerdidaF)-Sum(Fields.GananciaF))*-1,0)"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Format = "{0:N2}"
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.499898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999868869781494R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Style.Font.Name = "Arial"
        Me.TextBox24.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "=Sum(Fields.Pasivo)+IIf(Sum(Fields.Activo)-Sum(Fields.Pasivo)>0,Sum(Fields.Activo" & _
            ")-Sum(Fields.Pasivo),0)"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Format = "{0:N2}"
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.499698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999868869781494R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Style.Font.Name = "Arial"
        Me.TextBox23.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox23.StyleName = "Data"
        Me.TextBox23.Value = "=Sum(Fields.Activo)+IIf(Sum(Fields.Activo)-Sum(Fields.Pasivo)<0,(Sum(Fields.Activ" & _
            "o)-Sum(Fields.Pasivo))*-1,0)"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Format = "{0:N2}"
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.499998539686203R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "= IIf(Sum(Fields.PerdidaF)-Sum(Fields.GananciaF)<0,0,Sum(Fields.PerdidaF)-Sum(Fie" & _
            "lds.GananciaF))"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Format = "{0:N2}"
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.499998539686203R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "= IIf(Sum(Fields.PerdidaF)-Sum(Fields.GananciaF)<0,(Sum(Fields.PerdidaF)-Sum(Fiel" & _
            "ds.GananciaF))*-1,0)"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Format = "{0:N2}"
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.499898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.499998539686203R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "=IIf(Sum(Fields.Activo)-Sum(Fields.Pasivo)<0,(Sum(Fields.Activo)-Sum(Fields.Pasiv" & _
            "o))*-1,0)"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.499698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.499998539686203R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "= IIf(Sum(Fields.Activo)-Sum(Fields.Pasivo)<0,0,Sum(Fields.Activo)-Sum(Fields.Pas" & _
            "ivo))"
        '
        'gananciaFSumFunctionTextBox1
        '
        Me.gananciaFSumFunctionTextBox1.CanGrow = True
        Me.gananciaFSumFunctionTextBox1.Format = "{0:N2}"
        Me.gananciaFSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFSumFunctionTextBox1.Name = "gananciaFSumFunctionTextBox1"
        Me.gananciaFSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.gananciaFSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.gananciaFSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.gananciaFSumFunctionTextBox1.StyleName = "Data"
        Me.gananciaFSumFunctionTextBox1.Value = "=Sum(Fields.GananciaF)"
        '
        'perdidaFSumFunctionTextBox1
        '
        Me.perdidaFSumFunctionTextBox1.CanGrow = True
        Me.perdidaFSumFunctionTextBox1.Format = "{0:N2}"
        Me.perdidaFSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFSumFunctionTextBox1.Name = "perdidaFSumFunctionTextBox1"
        Me.perdidaFSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.perdidaFSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.perdidaFSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.perdidaFSumFunctionTextBox1.StyleName = "Data"
        Me.perdidaFSumFunctionTextBox1.Value = "=Sum(Fields.PerdidaF)"
        '
        'pasivoSumFunctionTextBox1
        '
        Me.pasivoSumFunctionTextBox1.CanGrow = True
        Me.pasivoSumFunctionTextBox1.Format = "{0:N2}"
        Me.pasivoSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.499898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoSumFunctionTextBox1.Name = "pasivoSumFunctionTextBox1"
        Me.pasivoSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.pasivoSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.pasivoSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pasivoSumFunctionTextBox1.StyleName = "Data"
        Me.pasivoSumFunctionTextBox1.Value = "=Sum(Fields.Pasivo)"
        '
        'activoSumFunctionTextBox1
        '
        Me.activoSumFunctionTextBox1.CanGrow = True
        Me.activoSumFunctionTextBox1.Format = "{0:N2}"
        Me.activoSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.499698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoSumFunctionTextBox1.Name = "activoSumFunctionTextBox1"
        Me.activoSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.activoSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.activoSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.activoSumFunctionTextBox1.StyleName = "Data"
        Me.activoSumFunctionTextBox1.Value = "=Sum(Fields.Activo)"
        '
        'saldoAcreedorSumFunctionTextBox1
        '
        Me.saldoAcreedorSumFunctionTextBox1.CanGrow = True
        Me.saldoAcreedorSumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoAcreedorSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.49949836730957R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoAcreedorSumFunctionTextBox1.Name = "saldoAcreedorSumFunctionTextBox1"
        Me.saldoAcreedorSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoAcreedorSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoAcreedorSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoAcreedorSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoAcreedorSumFunctionTextBox1.StyleName = "Data"
        Me.saldoAcreedorSumFunctionTextBox1.Value = "=Sum(Fields.AcreedorFinal)"
        '
        'saldoDeudorSumFunctionTextBox1
        '
        Me.saldoDeudorSumFunctionTextBox1.CanGrow = True
        Me.saldoDeudorSumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoDeudorSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499296188354492R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoDeudorSumFunctionTextBox1.Name = "saldoDeudorSumFunctionTextBox1"
        Me.saldoDeudorSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoDeudorSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoDeudorSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoDeudorSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoDeudorSumFunctionTextBox1.StyleName = "Data"
        Me.saldoDeudorSumFunctionTextBox1.Value = "=Sum(Fields.DeudorFinal)"
        '
        'haberMNSumFunctionTextBox1
        '
        Me.haberMNSumFunctionTextBox1.CanGrow = True
        Me.haberMNSumFunctionTextBox1.Format = "{0:N2}"
        Me.haberMNSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499095916748047R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNSumFunctionTextBox1.Name = "haberMNSumFunctionTextBox1"
        Me.haberMNSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.haberMNSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMNSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberMNSumFunctionTextBox1.StyleName = "Data"
        Me.haberMNSumFunctionTextBox1.Value = "=Sum(Fields.Haber)"
        '
        'debeMNSumFunctionTextBox1
        '
        Me.debeMNSumFunctionTextBox1.CanGrow = True
        Me.debeMNSumFunctionTextBox1.Format = "{0:N2}"
        Me.debeMNSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.498893737792969R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNSumFunctionTextBox1.Name = "debeMNSumFunctionTextBox1"
        Me.debeMNSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.debeMNSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMNSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeMNSumFunctionTextBox1.StyleName = "Data"
        Me.debeMNSumFunctionTextBox1.Value = "=Sum(Fields.Debe)"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9955611228942871R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "TOTALES:"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Format = "{0:N2}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.498693466186523R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "=Sum(Fields.AcreedorInicial)"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Format = "{0:N2}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.49576187133789R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "=Sum(Fields.DeudorInicial)"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.5000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox39, Me.TextBox38, Me.TextBox10, Me.TextBox9, Me.TextBox8, Me.TextBox5, Me.reportNameTextBox, Me.TextBox6, Me.TextBox7, Me.titleTextBox, Me.TextBox11, Me.TextBox13})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox10
        '
        Me.TextBox10.Format = "{0:d}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "PageInfo"
        Me.TextBox10.Value = "= Now()"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "Fecha:"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Página:"
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:g}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.StyleName = "PageInfo"
        Me.TextBox5.Value = "=PageNumber"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(24.499799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(24.499799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "RUC: 20453262767"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(24.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.StyleName = "PageInfo"
        Me.TextBox7.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499795913696289R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "LIBRO DE INVENTARIOS Y BALANCES - BALANCE DE COMPROBACIÓN"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.Color = System.Drawing.Color.Black
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Title"
        Me.TextBox11.Value = "='EJERCICIO: '+ Format('{0:yyyy}', Now())+' EN '+ IIf(Parameters.idMoneda.Value=1" & _
            ",'SOLES','DOLARES')"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.Font.Bold = False
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.StyleName = "PageInfo"
        Me.TextBox13.Value = "=IIf(Parameters.tipo.Value='I','INSTITUCIONAL', IIf(Parameters.tipo.Value='P','PO" & _
            "R PROYECTOS', IIf(Parameters.tipo.Value='A', Fields.Proyecto,'')))"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
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
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoDataTextBox, Me.descripcionDataTextBox, Me.deudorInicialDataTextBox, Me.acreedorInicialDataTextBox, Me.debeDataTextBox, Me.haberDataTextBox, Me.deudorFinalDataTextBox, Me.acreedorFinalDataTextBox, Me.activoDataTextBox, Me.pasivoDataTextBox, Me.perdidaFDataTextBox, Me.gananciaFDataTextBox})
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
        Me.codigoDataTextBox.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.30000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codigoDataTextBox.StyleName = "Data"
        Me.codigoDataTextBox.Value = "=Fields.Codigo"
        '
        'descripcionDataTextBox
        '
        Me.descripcionDataTextBox.CanGrow = True
        Me.descripcionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Name = "descripcionDataTextBox"
        Me.descripcionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9980950355529785R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Style.Font.Name = "Arial"
        Me.descripcionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionDataTextBox.StyleName = "Data"
        Me.descripcionDataTextBox.Value = "=Fields.Descripcion"
        '
        'deudorInicialDataTextBox
        '
        Me.deudorInicialDataTextBox.CanGrow = True
        Me.deudorInicialDataTextBox.Format = "{0:N2}"
        Me.deudorInicialDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.4984951019287109R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorInicialDataTextBox.Name = "deudorInicialDataTextBox"
        Me.deudorInicialDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorInicialDataTextBox.Style.Font.Name = "Arial"
        Me.deudorInicialDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.deudorInicialDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.deudorInicialDataTextBox.StyleName = "Data"
        Me.deudorInicialDataTextBox.Value = "=Fields.DeudorInicial"
        '
        'acreedorInicialDataTextBox
        '
        Me.acreedorInicialDataTextBox.CanGrow = True
        Me.acreedorInicialDataTextBox.Format = "{0:N2}"
        Me.acreedorInicialDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.498695373535156R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorInicialDataTextBox.Name = "acreedorInicialDataTextBox"
        Me.acreedorInicialDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorInicialDataTextBox.Style.Font.Name = "Arial"
        Me.acreedorInicialDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.acreedorInicialDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.acreedorInicialDataTextBox.StyleName = "Data"
        Me.acreedorInicialDataTextBox.Value = "=Fields.AcreedorInicial"
        '
        'debeDataTextBox
        '
        Me.debeDataTextBox.CanGrow = True
        Me.debeDataTextBox.Format = "{0:N2}"
        Me.debeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.498893737792969R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeDataTextBox.Name = "debeDataTextBox"
        Me.debeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeDataTextBox.Style.Font.Name = "Arial"
        Me.debeDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeDataTextBox.StyleName = "Data"
        Me.debeDataTextBox.Value = "=Fields.Debe"
        '
        'haberDataTextBox
        '
        Me.haberDataTextBox.CanGrow = True
        Me.haberDataTextBox.Format = "{0:N2}"
        Me.haberDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499095916748047R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberDataTextBox.Name = "haberDataTextBox"
        Me.haberDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberDataTextBox.Style.Font.Name = "Arial"
        Me.haberDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberDataTextBox.StyleName = "Data"
        Me.haberDataTextBox.Value = "=Fields.Haber"
        '
        'deudorFinalDataTextBox
        '
        Me.deudorFinalDataTextBox.CanGrow = True
        Me.deudorFinalDataTextBox.Format = "{0:N2}"
        Me.deudorFinalDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499296188354492R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorFinalDataTextBox.Name = "deudorFinalDataTextBox"
        Me.deudorFinalDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.deudorFinalDataTextBox.Style.Font.Name = "Arial"
        Me.deudorFinalDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.deudorFinalDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.deudorFinalDataTextBox.StyleName = "Data"
        Me.deudorFinalDataTextBox.Value = "=Fields.DeudorFinal"
        '
        'acreedorFinalDataTextBox
        '
        Me.acreedorFinalDataTextBox.CanGrow = True
        Me.acreedorFinalDataTextBox.Format = "{0:N2}"
        Me.acreedorFinalDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.49949836730957R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorFinalDataTextBox.Name = "acreedorFinalDataTextBox"
        Me.acreedorFinalDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.acreedorFinalDataTextBox.Style.Font.Name = "Arial"
        Me.acreedorFinalDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.acreedorFinalDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.acreedorFinalDataTextBox.StyleName = "Data"
        Me.acreedorFinalDataTextBox.Value = "=Fields.AcreedorFinal"
        '
        'activoDataTextBox
        '
        Me.activoDataTextBox.CanGrow = True
        Me.activoDataTextBox.Format = "{0:N2}"
        Me.activoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.499698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoDataTextBox.Name = "activoDataTextBox"
        Me.activoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.activoDataTextBox.Style.Font.Name = "Arial"
        Me.activoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.activoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.activoDataTextBox.StyleName = "Data"
        Me.activoDataTextBox.Value = "=Fields.Activo"
        '
        'pasivoDataTextBox
        '
        Me.pasivoDataTextBox.CanGrow = True
        Me.pasivoDataTextBox.Format = "{0:N2}"
        Me.pasivoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.499898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoDataTextBox.Name = "pasivoDataTextBox"
        Me.pasivoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.pasivoDataTextBox.Style.Font.Name = "Arial"
        Me.pasivoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.pasivoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pasivoDataTextBox.StyleName = "Data"
        Me.pasivoDataTextBox.Value = "=Fields.Pasivo"
        '
        'perdidaFDataTextBox
        '
        Me.perdidaFDataTextBox.CanGrow = True
        Me.perdidaFDataTextBox.Format = "{0:N2}"
        Me.perdidaFDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.499799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFDataTextBox.Name = "perdidaFDataTextBox"
        Me.perdidaFDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.perdidaFDataTextBox.Style.Font.Name = "Arial"
        Me.perdidaFDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.perdidaFDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.perdidaFDataTextBox.StyleName = "Data"
        Me.perdidaFDataTextBox.Value = "=Fields.PerdidaF"
        '
        'gananciaFDataTextBox
        '
        Me.gananciaFDataTextBox.CanGrow = True
        Me.gananciaFDataTextBox.Format = "{0:N2}"
        Me.gananciaFDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFDataTextBox.Name = "gananciaFDataTextBox"
        Me.gananciaFDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.gananciaFDataTextBox.Style.Font.Name = "Arial"
        Me.gananciaFDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.gananciaFDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.gananciaFDataTextBox.StyleName = "Data"
        Me.gananciaFDataTextBox.Value = "=Fields.GananciaF"
        '
        'RepBalanceComprobacion
        '
        Me.DataSource = Me.SDSRepBalanceComprobacion
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.codigoN2Group})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.codigoN2GroupHeader, Me.codigoN2GroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "Fecha"
        ReportParameter1.Text = "Fecha"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        ReportParameter2.Name = "idProyecto"
        ReportParameter2.Text = "idProyecto"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter2.Visible = True
        ReportParameter3.Name = "idMoneda"
        ReportParameter3.Text = "idMoneda"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter3.Visible = True
        ReportParameter4.Name = "tipo"
        ReportParameter4.Text = "tipo"
        ReportParameter4.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(28.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepBalanceComprobacion As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents codigoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents deudorInicialCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents acreedorInicialCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents deudorFinalCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents acreedorFinalCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents activoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pasivoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents perdidaFCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents gananciaFCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents codigoN2GroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents codigoN2DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codigoN2GroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents deudorInicialSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents acreedorInicialSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents deudorFinalSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents acreedorFinalSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents activoSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pasivoSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents perdidaFSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents gananciaFSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codigoN2Group As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents codigoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents deudorInicialDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents acreedorInicialDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents deudorFinalDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents acreedorFinalDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents activoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pasivoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents perdidaFDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents gananciaFDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents gananciaFSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents perdidaFSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents pasivoSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents activoSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoAcreedorSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoDeudorSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents haberMNSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents debeMNSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
End Class