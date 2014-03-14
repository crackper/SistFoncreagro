Partial Class RepBalanceComprobacionXareaMayor
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepBalanceComprobacionXareaMayor))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.DSRepBalanceComprobacionXareaMayor = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.codigoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoInicialMNCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.debeMNCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.haberMNCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoActualMNCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoInicialMECaptionTextBox = New Telerik.Reporting.TextBox()
        Me.debeMECaptionTextBox = New Telerik.Reporting.TextBox()
        Me.haberMECaptionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoActualMECaptionTextBox = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.proyectoGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.proyectoDataTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.saldoInicialMNSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.debeMNSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.haberMNSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoActualMNSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoInicialMESumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.debeMESumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.haberMESumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoActualMESumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoInicialMNSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.debeMNSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.haberMNSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoActualMNSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoInicialMESumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.debeMESumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.haberMESumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoActualMESumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.codigoDataTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoInicialMNDataTextBox = New Telerik.Reporting.TextBox()
        Me.debeMNDataTextBox = New Telerik.Reporting.TextBox()
        Me.haberMNDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoActualMNDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoInicialMEDataTextBox = New Telerik.Reporting.TextBox()
        Me.debeMEDataTextBox = New Telerik.Reporting.TextBox()
        Me.haberMEDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoActualMEDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DSRepBalanceComprobacionXareaMayor
        '
        Me.DSRepBalanceComprobacionXareaMayor.ConnectionString = "cnx"
        Me.DSRepBalanceComprobacionXareaMayor.Name = "DSRepBalanceComprobacionXareaMayor"
        Me.DSRepBalanceComprobacionXareaMayor.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@Fecha", System.Data.DbType.DateTime, "=Parameters.Fecha.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@Tipo", System.Data.DbType.AnsiStringFixedLength, "=Parameters.Tipo.Value")})
        Me.DSRepBalanceComprobacionXareaMayor.SelectCommand = "dbo.RepBalanceComprobacionNivelMayor"
        Me.DSRepBalanceComprobacionXareaMayor.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        Me.labelsGroupHeader.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.labelsGroupHeader.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.labelsGroupHeader.Style.Visible = False
        '
        'codigoCaptionTextBox
        '
        Me.codigoCaptionTextBox.CanGrow = True
        Me.codigoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Name = "codigoCaptionTextBox"
        Me.codigoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.codigoCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.codigoCaptionTextBox.Style.Font.Name = "Arial"
        Me.codigoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoCaptionTextBox.StyleName = "Caption"
        Me.codigoCaptionTextBox.Value = "CODIGO"
        '
        'descripcionCaptionTextBox
        '
        Me.descripcionCaptionTextBox.CanGrow = True
        Me.descripcionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Name = "descripcionCaptionTextBox"
        Me.descripcionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.descripcionCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.descripcionCaptionTextBox.Style.Font.Name = "Arial"
        Me.descripcionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.descripcionCaptionTextBox.StyleName = "Caption"
        Me.descripcionCaptionTextBox.Value = "DESCRIPCIÓN"
        '
        'saldoInicialMNCaptionTextBox
        '
        Me.saldoInicialMNCaptionTextBox.CanGrow = True
        Me.saldoInicialMNCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNCaptionTextBox.Name = "saldoInicialMNCaptionTextBox"
        Me.saldoInicialMNCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoInicialMNCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoInicialMNCaptionTextBox.Style.Font.Name = "Arial"
        Me.saldoInicialMNCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMNCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoInicialMNCaptionTextBox.StyleName = "Caption"
        Me.saldoInicialMNCaptionTextBox.Value = "SALDO INICIAL MN"
        '
        'debeMNCaptionTextBox
        '
        Me.debeMNCaptionTextBox.CanGrow = True
        Me.debeMNCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNCaptionTextBox.Name = "debeMNCaptionTextBox"
        Me.debeMNCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.debeMNCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.debeMNCaptionTextBox.Style.Font.Name = "Arial"
        Me.debeMNCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMNCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.debeMNCaptionTextBox.StyleName = "Caption"
        Me.debeMNCaptionTextBox.Value = "DEBE MN"
        '
        'haberMNCaptionTextBox
        '
        Me.haberMNCaptionTextBox.CanGrow = True
        Me.haberMNCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNCaptionTextBox.Name = "haberMNCaptionTextBox"
        Me.haberMNCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.haberMNCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.haberMNCaptionTextBox.Style.Font.Name = "Arial"
        Me.haberMNCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMNCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.haberMNCaptionTextBox.StyleName = "Caption"
        Me.haberMNCaptionTextBox.Value = "HABER MN"
        '
        'saldoActualMNCaptionTextBox
        '
        Me.saldoActualMNCaptionTextBox.CanGrow = True
        Me.saldoActualMNCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNCaptionTextBox.Name = "saldoActualMNCaptionTextBox"
        Me.saldoActualMNCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoActualMNCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoActualMNCaptionTextBox.Style.Font.Name = "Arial"
        Me.saldoActualMNCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMNCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoActualMNCaptionTextBox.StyleName = "Caption"
        Me.saldoActualMNCaptionTextBox.Value = "SALDO ACTUAL MN"
        '
        'saldoInicialMECaptionTextBox
        '
        Me.saldoInicialMECaptionTextBox.CanGrow = True
        Me.saldoInicialMECaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMECaptionTextBox.Name = "saldoInicialMECaptionTextBox"
        Me.saldoInicialMECaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMECaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoInicialMECaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoInicialMECaptionTextBox.Style.Font.Name = "Arial"
        Me.saldoInicialMECaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMECaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoInicialMECaptionTextBox.StyleName = "Caption"
        Me.saldoInicialMECaptionTextBox.Value = "SALDO INICIAL ME"
        '
        'debeMECaptionTextBox
        '
        Me.debeMECaptionTextBox.CanGrow = True
        Me.debeMECaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMECaptionTextBox.Name = "debeMECaptionTextBox"
        Me.debeMECaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMECaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.debeMECaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.debeMECaptionTextBox.Style.Font.Name = "Arial"
        Me.debeMECaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMECaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.debeMECaptionTextBox.StyleName = "Caption"
        Me.debeMECaptionTextBox.Value = "DEBE ME"
        '
        'haberMECaptionTextBox
        '
        Me.haberMECaptionTextBox.CanGrow = True
        Me.haberMECaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMECaptionTextBox.Name = "haberMECaptionTextBox"
        Me.haberMECaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMECaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.haberMECaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.haberMECaptionTextBox.Style.Font.Name = "Arial"
        Me.haberMECaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMECaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.haberMECaptionTextBox.StyleName = "Caption"
        Me.haberMECaptionTextBox.Value = "HABER ME"
        '
        'saldoActualMECaptionTextBox
        '
        Me.saldoActualMECaptionTextBox.CanGrow = True
        Me.saldoActualMECaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMECaptionTextBox.Name = "saldoActualMECaptionTextBox"
        Me.saldoActualMECaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMECaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoActualMECaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.saldoActualMECaptionTextBox.Style.Font.Name = "Arial"
        Me.saldoActualMECaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMECaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoActualMECaptionTextBox.StyleName = "Caption"
        Me.saldoActualMECaptionTextBox.Value = "SALDO ACTUAL ME"
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
        'proyectoGroupHeader
        '
        Me.proyectoGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.proyectoGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.proyectoDataTextBox, Me.descripcionCaptionTextBox, Me.codigoCaptionTextBox, Me.saldoInicialMNCaptionTextBox, Me.debeMNCaptionTextBox, Me.haberMNCaptionTextBox, Me.saldoActualMNCaptionTextBox, Me.saldoInicialMECaptionTextBox, Me.debeMECaptionTextBox, Me.haberMECaptionTextBox, Me.saldoActualMECaptionTextBox})
        Me.proyectoGroupHeader.Name = "proyectoGroupHeader"
        Me.proyectoGroupHeader.PageBreak = Telerik.Reporting.PageBreak.Before
        Me.proyectoGroupHeader.PrintOnEveryPage = True
        '
        'proyectoDataTextBox
        '
        Me.proyectoDataTextBox.CanGrow = True
        Me.proyectoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Name = "proyectoDataTextBox"
        Me.proyectoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Style.Font.Bold = True
        Me.proyectoDataTextBox.Style.Font.Name = "Arial"
        Me.proyectoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoDataTextBox.StyleName = "Data"
        Me.proyectoDataTextBox.Value = "=Fields.Proyecto"
        '
        'proyectoGroupFooter
        '
        Me.proyectoGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.proyectoGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.saldoInicialMNSumFunctionTextBox, Me.debeMNSumFunctionTextBox, Me.haberMNSumFunctionTextBox, Me.saldoActualMNSumFunctionTextBox, Me.saldoInicialMESumFunctionTextBox, Me.debeMESumFunctionTextBox, Me.haberMESumFunctionTextBox, Me.saldoActualMESumFunctionTextBox})
        Me.proyectoGroupFooter.Name = "proyectoGroupFooter"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "TOTAL ÁREA:"
        '
        'saldoInicialMNSumFunctionTextBox
        '
        Me.saldoInicialMNSumFunctionTextBox.CanGrow = True
        Me.saldoInicialMNSumFunctionTextBox.Format = "{0:N2}"
        Me.saldoInicialMNSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNSumFunctionTextBox.Name = "saldoInicialMNSumFunctionTextBox"
        Me.saldoInicialMNSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.saldoInicialMNSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMNSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoInicialMNSumFunctionTextBox.StyleName = "Data"
        Me.saldoInicialMNSumFunctionTextBox.Value = "= Sum(Fields.SaldoInicialMN)"
        '
        'debeMNSumFunctionTextBox
        '
        Me.debeMNSumFunctionTextBox.CanGrow = True
        Me.debeMNSumFunctionTextBox.Format = "{0:N2}"
        Me.debeMNSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNSumFunctionTextBox.Name = "debeMNSumFunctionTextBox"
        Me.debeMNSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.debeMNSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMNSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeMNSumFunctionTextBox.StyleName = "Data"
        Me.debeMNSumFunctionTextBox.Value = "= Sum(Fields.DebeMN)"
        '
        'haberMNSumFunctionTextBox
        '
        Me.haberMNSumFunctionTextBox.CanGrow = True
        Me.haberMNSumFunctionTextBox.Format = "{0:N2}"
        Me.haberMNSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNSumFunctionTextBox.Name = "haberMNSumFunctionTextBox"
        Me.haberMNSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.haberMNSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMNSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberMNSumFunctionTextBox.StyleName = "Data"
        Me.haberMNSumFunctionTextBox.Value = "= Sum(Fields.HaberMN)"
        '
        'saldoActualMNSumFunctionTextBox
        '
        Me.saldoActualMNSumFunctionTextBox.CanGrow = True
        Me.saldoActualMNSumFunctionTextBox.Format = "{0:N2}"
        Me.saldoActualMNSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNSumFunctionTextBox.Name = "saldoActualMNSumFunctionTextBox"
        Me.saldoActualMNSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.saldoActualMNSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMNSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoActualMNSumFunctionTextBox.StyleName = "Data"
        Me.saldoActualMNSumFunctionTextBox.Value = "= Sum(Fields.SaldoActualMN)"
        '
        'saldoInicialMESumFunctionTextBox
        '
        Me.saldoInicialMESumFunctionTextBox.CanGrow = True
        Me.saldoInicialMESumFunctionTextBox.Format = "{0:N2}"
        Me.saldoInicialMESumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMESumFunctionTextBox.Name = "saldoInicialMESumFunctionTextBox"
        Me.saldoInicialMESumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMESumFunctionTextBox.Style.Font.Name = "Arial"
        Me.saldoInicialMESumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMESumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoInicialMESumFunctionTextBox.StyleName = "Data"
        Me.saldoInicialMESumFunctionTextBox.Value = "= Sum(Fields.SaldoInicialME)"
        '
        'debeMESumFunctionTextBox
        '
        Me.debeMESumFunctionTextBox.CanGrow = True
        Me.debeMESumFunctionTextBox.Format = "{0:N2}"
        Me.debeMESumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMESumFunctionTextBox.Name = "debeMESumFunctionTextBox"
        Me.debeMESumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMESumFunctionTextBox.Style.Font.Name = "Arial"
        Me.debeMESumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMESumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeMESumFunctionTextBox.StyleName = "Data"
        Me.debeMESumFunctionTextBox.Value = "= Sum(Fields.DebeME)"
        '
        'haberMESumFunctionTextBox
        '
        Me.haberMESumFunctionTextBox.CanGrow = True
        Me.haberMESumFunctionTextBox.Format = "{0:N2}"
        Me.haberMESumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMESumFunctionTextBox.Name = "haberMESumFunctionTextBox"
        Me.haberMESumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMESumFunctionTextBox.Style.Font.Name = "Arial"
        Me.haberMESumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMESumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberMESumFunctionTextBox.StyleName = "Data"
        Me.haberMESumFunctionTextBox.Value = "= Sum(Fields.HaberME)"
        '
        'saldoActualMESumFunctionTextBox
        '
        Me.saldoActualMESumFunctionTextBox.CanGrow = True
        Me.saldoActualMESumFunctionTextBox.Format = "{0:N2}"
        Me.saldoActualMESumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMESumFunctionTextBox.Name = "saldoActualMESumFunctionTextBox"
        Me.saldoActualMESumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMESumFunctionTextBox.Style.Font.Name = "Arial"
        Me.saldoActualMESumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMESumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoActualMESumFunctionTextBox.StyleName = "Data"
        Me.saldoActualMESumFunctionTextBox.Value = "= Sum(Fields.SaldoActualME)"
        '
        'proyectoGroup
        '
        Me.proyectoGroup.GroupFooter = Me.proyectoGroupFooter
        Me.proyectoGroup.GroupHeader = Me.proyectoGroupHeader
        Me.proyectoGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Proyecto")})
        Me.proyectoGroup.Name = "proyectoGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.saldoInicialMNSumFunctionTextBox1, Me.debeMNSumFunctionTextBox1, Me.haberMNSumFunctionTextBox1, Me.saldoActualMNSumFunctionTextBox1, Me.saldoInicialMESumFunctionTextBox1, Me.debeMESumFunctionTextBox1, Me.haberMESumFunctionTextBox1, Me.saldoActualMESumFunctionTextBox1})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "TOTAL GENERAL:"
        '
        'saldoInicialMNSumFunctionTextBox1
        '
        Me.saldoInicialMNSumFunctionTextBox1.CanGrow = True
        Me.saldoInicialMNSumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoInicialMNSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNSumFunctionTextBox1.Name = "saldoInicialMNSumFunctionTextBox1"
        Me.saldoInicialMNSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoInicialMNSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMNSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoInicialMNSumFunctionTextBox1.StyleName = "Data"
        Me.saldoInicialMNSumFunctionTextBox1.Value = "=Sum(Fields.SaldoInicialMN)"
        '
        'debeMNSumFunctionTextBox1
        '
        Me.debeMNSumFunctionTextBox1.CanGrow = True
        Me.debeMNSumFunctionTextBox1.Format = "{0:N2}"
        Me.debeMNSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNSumFunctionTextBox1.Name = "debeMNSumFunctionTextBox1"
        Me.debeMNSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.debeMNSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMNSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeMNSumFunctionTextBox1.StyleName = "Data"
        Me.debeMNSumFunctionTextBox1.Value = "= Sum(Fields.DebeMN)"
        '
        'haberMNSumFunctionTextBox1
        '
        Me.haberMNSumFunctionTextBox1.CanGrow = True
        Me.haberMNSumFunctionTextBox1.Format = "{0:N2}"
        Me.haberMNSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNSumFunctionTextBox1.Name = "haberMNSumFunctionTextBox1"
        Me.haberMNSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.haberMNSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMNSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberMNSumFunctionTextBox1.StyleName = "Data"
        Me.haberMNSumFunctionTextBox1.Value = "= Sum(Fields.HaberMN)"
        '
        'saldoActualMNSumFunctionTextBox1
        '
        Me.saldoActualMNSumFunctionTextBox1.CanGrow = True
        Me.saldoActualMNSumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoActualMNSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNSumFunctionTextBox1.Name = "saldoActualMNSumFunctionTextBox1"
        Me.saldoActualMNSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoActualMNSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMNSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoActualMNSumFunctionTextBox1.StyleName = "Data"
        Me.saldoActualMNSumFunctionTextBox1.Value = "= Sum(Fields.SaldoActualMN)"
        '
        'saldoInicialMESumFunctionTextBox1
        '
        Me.saldoInicialMESumFunctionTextBox1.CanGrow = True
        Me.saldoInicialMESumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoInicialMESumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMESumFunctionTextBox1.Name = "saldoInicialMESumFunctionTextBox1"
        Me.saldoInicialMESumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMESumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoInicialMESumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMESumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoInicialMESumFunctionTextBox1.StyleName = "Data"
        Me.saldoInicialMESumFunctionTextBox1.Value = "= Sum(Fields.SaldoInicialME)"
        '
        'debeMESumFunctionTextBox1
        '
        Me.debeMESumFunctionTextBox1.CanGrow = True
        Me.debeMESumFunctionTextBox1.Format = "{0:N2}"
        Me.debeMESumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMESumFunctionTextBox1.Name = "debeMESumFunctionTextBox1"
        Me.debeMESumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMESumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.debeMESumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMESumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeMESumFunctionTextBox1.StyleName = "Data"
        Me.debeMESumFunctionTextBox1.Value = "= Sum(Fields.DebeME)"
        '
        'haberMESumFunctionTextBox1
        '
        Me.haberMESumFunctionTextBox1.CanGrow = True
        Me.haberMESumFunctionTextBox1.Format = "{0:N2}"
        Me.haberMESumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMESumFunctionTextBox1.Name = "haberMESumFunctionTextBox1"
        Me.haberMESumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMESumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.haberMESumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMESumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberMESumFunctionTextBox1.StyleName = "Data"
        Me.haberMESumFunctionTextBox1.Value = "= Sum(Fields.HaberME)"
        '
        'saldoActualMESumFunctionTextBox1
        '
        Me.saldoActualMESumFunctionTextBox1.CanGrow = True
        Me.saldoActualMESumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoActualMESumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMESumFunctionTextBox1.Name = "saldoActualMESumFunctionTextBox1"
        Me.saldoActualMESumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMESumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoActualMESumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMESumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoActualMESumFunctionTextBox1.StyleName = "Data"
        Me.saldoActualMESumFunctionTextBox1.Value = "= Sum(Fields.SaldoActualME)"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox7, Me.TextBox6, Me.reportNameTextBox, Me.TextBox3, Me.titleTextBox, Me.TextBox39, Me.TextBox38, Me.TextBox9, Me.TextBox8, Me.TextBox4, Me.TextBox5})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
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
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(15.999801635742188R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
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
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(15.999801635742188R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Title"
        Me.TextBox3.Value = resources.GetString("TextBox3.Value")
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.9972916841506958R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = resources.GetString("titleTextBox.Value")
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9997967481613159R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
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
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0076272487640381R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0076272487640381R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "= Now()"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9997967481613159R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Fecha:"
        '
        'TextBox4
        '
        Me.TextBox4.Format = "{0:d}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9997967481613159R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "PageInfo"
        Me.TextBox4.Value = "Página:"
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:g}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0076272487640381R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.StyleName = "PageInfo"
        Me.TextBox5.Value = "=PageNumber"
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
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoDataTextBox, Me.descripcionDataTextBox, Me.saldoInicialMNDataTextBox, Me.debeMNDataTextBox, Me.haberMNDataTextBox, Me.saldoActualMNDataTextBox, Me.saldoInicialMEDataTextBox, Me.debeMEDataTextBox, Me.haberMEDataTextBox, Me.saldoActualMEDataTextBox})
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
        Me.codigoDataTextBox.Value = "=Fields.Codigo"
        '
        'descripcionDataTextBox
        '
        Me.descripcionDataTextBox.CanGrow = True
        Me.descripcionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Name = "descripcionDataTextBox"
        Me.descripcionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Style.Font.Name = "Arial"
        Me.descripcionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.descripcionDataTextBox.StyleName = "Data"
        Me.descripcionDataTextBox.Value = "=Fields.Descripcion"
        '
        'saldoInicialMNDataTextBox
        '
        Me.saldoInicialMNDataTextBox.CanGrow = True
        Me.saldoInicialMNDataTextBox.Format = "{0:N2}"
        Me.saldoInicialMNDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNDataTextBox.Name = "saldoInicialMNDataTextBox"
        Me.saldoInicialMNDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMNDataTextBox.Style.Font.Name = "Arial"
        Me.saldoInicialMNDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMNDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoInicialMNDataTextBox.StyleName = "Data"
        Me.saldoInicialMNDataTextBox.Value = "= Fields.SaldoInicialMN"
        '
        'debeMNDataTextBox
        '
        Me.debeMNDataTextBox.CanGrow = True
        Me.debeMNDataTextBox.Format = "{0:N2}"
        Me.debeMNDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNDataTextBox.Name = "debeMNDataTextBox"
        Me.debeMNDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMNDataTextBox.Style.Font.Name = "Arial"
        Me.debeMNDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMNDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeMNDataTextBox.StyleName = "Data"
        Me.debeMNDataTextBox.Value = "= Fields.DebeMN"
        '
        'haberMNDataTextBox
        '
        Me.haberMNDataTextBox.CanGrow = True
        Me.haberMNDataTextBox.Format = "{0:N2}"
        Me.haberMNDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNDataTextBox.Name = "haberMNDataTextBox"
        Me.haberMNDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMNDataTextBox.Style.Font.Name = "Arial"
        Me.haberMNDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMNDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberMNDataTextBox.StyleName = "Data"
        Me.haberMNDataTextBox.Value = "= Fields.HaberMN"
        '
        'saldoActualMNDataTextBox
        '
        Me.saldoActualMNDataTextBox.CanGrow = True
        Me.saldoActualMNDataTextBox.Format = "{0:N2}"
        Me.saldoActualMNDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNDataTextBox.Name = "saldoActualMNDataTextBox"
        Me.saldoActualMNDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMNDataTextBox.Style.Font.Name = "Arial"
        Me.saldoActualMNDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMNDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoActualMNDataTextBox.StyleName = "Data"
        Me.saldoActualMNDataTextBox.Value = "= Fields.SaldoActualMN"
        '
        'saldoInicialMEDataTextBox
        '
        Me.saldoInicialMEDataTextBox.CanGrow = True
        Me.saldoInicialMEDataTextBox.Format = "{0:N2}"
        Me.saldoInicialMEDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMEDataTextBox.Name = "saldoInicialMEDataTextBox"
        Me.saldoInicialMEDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoInicialMEDataTextBox.Style.Font.Name = "Arial"
        Me.saldoInicialMEDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoInicialMEDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoInicialMEDataTextBox.StyleName = "Data"
        Me.saldoInicialMEDataTextBox.Value = "= Fields.SaldoInicialME"
        '
        'debeMEDataTextBox
        '
        Me.debeMEDataTextBox.CanGrow = True
        Me.debeMEDataTextBox.Format = "{0:N2}"
        Me.debeMEDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMEDataTextBox.Name = "debeMEDataTextBox"
        Me.debeMEDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.debeMEDataTextBox.Style.Font.Name = "Arial"
        Me.debeMEDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.debeMEDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.debeMEDataTextBox.StyleName = "Data"
        Me.debeMEDataTextBox.Value = "= Fields.DebeME"
        '
        'haberMEDataTextBox
        '
        Me.haberMEDataTextBox.CanGrow = True
        Me.haberMEDataTextBox.Format = "{0:N2}"
        Me.haberMEDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMEDataTextBox.Name = "haberMEDataTextBox"
        Me.haberMEDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.haberMEDataTextBox.Style.Font.Name = "Arial"
        Me.haberMEDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.haberMEDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.haberMEDataTextBox.StyleName = "Data"
        Me.haberMEDataTextBox.Value = "=Fields.HaberME"
        '
        'saldoActualMEDataTextBox
        '
        Me.saldoActualMEDataTextBox.CanGrow = True
        Me.saldoActualMEDataTextBox.Format = "{0:N2}"
        Me.saldoActualMEDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMEDataTextBox.Name = "saldoActualMEDataTextBox"
        Me.saldoActualMEDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoActualMEDataTextBox.Style.Font.Name = "Arial"
        Me.saldoActualMEDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoActualMEDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoActualMEDataTextBox.StyleName = "Data"
        Me.saldoActualMEDataTextBox.Value = "= Fields.SaldoActualME"
        '
        'RepBalanceComprobacionXareaMayor
        '
        Me.DataSource = Me.DSRepBalanceComprobacionXareaMayor
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.proyectoGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.proyectoGroupHeader, Me.proyectoGroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "Fecha"
        ReportParameter1.Text = "Fecha"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        ReportParameter2.Name = "idProyecto"
        ReportParameter2.Text = "idProyecto"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter2.Visible = True
        ReportParameter3.Name = "Tipo"
        ReportParameter3.Text = "Tipo"
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
    Friend WithEvents DSRepBalanceComprobacionXareaMayor As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents codigoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMNCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeMNCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberMNCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMNCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMECaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeMECaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberMECaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMECaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents proyectoGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents proyectoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMNSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeMNSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberMNSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMNSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMESumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeMESumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberMESumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMESumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMNSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents debeMNSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents haberMNSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMNSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMESumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents debeMESumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents haberMESumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMESumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents codigoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMNDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeMNDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberMNDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMNDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoInicialMEDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents debeMEDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents haberMEDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoActualMEDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
End Class