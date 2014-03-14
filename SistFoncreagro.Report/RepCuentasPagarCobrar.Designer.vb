Partial Class RepCuentasPagarCobrar
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.proyectoDestinoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaPorCobrarCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.nombreCuentaPorCobrarCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMNCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMECaptionTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoOrigenCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaPorPagarCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.nombreCuentaPorPagarCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMNCaptionTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoMECaptionTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoMNSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMESumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMNSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoMESumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.proyectoDestinoDataTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaPorCobrarDataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreCuentaPorCobrarDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMNDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMEDataTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoOrigenDataTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaPorPagarDataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreCuentaPorPagarDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoMNDataTextBox1 = New Telerik.Reporting.TextBox()
        Me.saldoMEDataTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "cnx"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@fechaInicio", System.Data.DbType.DateTime, "=Parameters.fechaInicio.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechaFin", System.Data.DbType.DateTime, "=Parameters.fechaFin.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.RepCtasPagarCobrar"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.proyectoDestinoCaptionTextBox, Me.cuentaPorCobrarCaptionTextBox, Me.nombreCuentaPorCobrarCaptionTextBox, Me.saldoMNCaptionTextBox, Me.saldoMECaptionTextBox, Me.proyectoOrigenCaptionTextBox, Me.cuentaPorPagarCaptionTextBox, Me.nombreCuentaPorPagarCaptionTextBox, Me.saldoMNCaptionTextBox1, Me.saldoMECaptionTextBox1, Me.TextBox2, Me.TextBox5, Me.TextBox18, Me.TextBox19, Me.TextBox20})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        Me.labelsGroupHeader.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.labelsGroupHeader.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.labelsGroupHeader.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'proyectoDestinoCaptionTextBox
        '
        Me.proyectoDestinoCaptionTextBox.CanGrow = True
        Me.proyectoDestinoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDestinoCaptionTextBox.Name = "proyectoDestinoCaptionTextBox"
        Me.proyectoDestinoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDestinoCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoDestinoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoDestinoCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.proyectoDestinoCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoDestinoCaptionTextBox.Style.Font.Bold = True
        Me.proyectoDestinoCaptionTextBox.Style.Font.Name = "Arial"
        Me.proyectoDestinoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoDestinoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.proyectoDestinoCaptionTextBox.StyleName = "Caption"
        Me.proyectoDestinoCaptionTextBox.Value = "PROYECTO"
        '
        'cuentaPorCobrarCaptionTextBox
        '
        Me.cuentaPorCobrarCaptionTextBox.CanGrow = True
        Me.cuentaPorCobrarCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5001999139785767R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorCobrarCaptionTextBox.Name = "cuentaPorCobrarCaptionTextBox"
        Me.cuentaPorCobrarCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorCobrarCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.cuentaPorCobrarCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.cuentaPorCobrarCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cuentaPorCobrarCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.cuentaPorCobrarCaptionTextBox.Style.Font.Bold = True
        Me.cuentaPorCobrarCaptionTextBox.Style.Font.Name = "Arial"
        Me.cuentaPorCobrarCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaPorCobrarCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaPorCobrarCaptionTextBox.StyleName = "Caption"
        Me.cuentaPorCobrarCaptionTextBox.Value = "CUENTA"
        '
        'nombreCuentaPorCobrarCaptionTextBox
        '
        Me.nombreCuentaPorCobrarCaptionTextBox.CanGrow = True
        Me.nombreCuentaPorCobrarCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorCobrarCaptionTextBox.Name = "nombreCuentaPorCobrarCaptionTextBox"
        Me.nombreCuentaPorCobrarCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.Font.Bold = True
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.Font.Name = "Arial"
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreCuentaPorCobrarCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.nombreCuentaPorCobrarCaptionTextBox.StyleName = "Caption"
        Me.nombreCuentaPorCobrarCaptionTextBox.Value = "DESCRIPCIÓN"
        '
        'saldoMNCaptionTextBox
        '
        Me.saldoMNCaptionTextBox.CanGrow = True
        Me.saldoMNCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNCaptionTextBox.Name = "saldoMNCaptionTextBox"
        Me.saldoMNCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMNCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMNCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.saldoMNCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMNCaptionTextBox.Style.Font.Bold = True
        Me.saldoMNCaptionTextBox.Style.Font.Name = "Arial"
        Me.saldoMNCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMNCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoMNCaptionTextBox.StyleName = "Caption"
        Me.saldoMNCaptionTextBox.Value = "MONTO MN"
        '
        'saldoMECaptionTextBox
        '
        Me.saldoMECaptionTextBox.CanGrow = True
        Me.saldoMECaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50009989738464355R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMECaptionTextBox.Name = "saldoMECaptionTextBox"
        Me.saldoMECaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9997999668121338R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMECaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMECaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMECaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.saldoMECaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMECaptionTextBox.Style.Font.Bold = True
        Me.saldoMECaptionTextBox.Style.Font.Name = "Arial"
        Me.saldoMECaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMECaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoMECaptionTextBox.StyleName = "Caption"
        Me.saldoMECaptionTextBox.Value = "MONTO ME"
        '
        'proyectoOrigenCaptionTextBox
        '
        Me.proyectoOrigenCaptionTextBox.CanGrow = True
        Me.proyectoOrigenCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoOrigenCaptionTextBox.Name = "proyectoOrigenCaptionTextBox"
        Me.proyectoOrigenCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoOrigenCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoOrigenCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoOrigenCaptionTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoOrigenCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.proyectoOrigenCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoOrigenCaptionTextBox.Style.Font.Bold = True
        Me.proyectoOrigenCaptionTextBox.Style.Font.Name = "Arial"
        Me.proyectoOrigenCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoOrigenCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.proyectoOrigenCaptionTextBox.StyleName = "Caption"
        Me.proyectoOrigenCaptionTextBox.Value = "PROYECTO"
        '
        'cuentaPorPagarCaptionTextBox
        '
        Me.cuentaPorPagarCaptionTextBox.CanGrow = True
        Me.cuentaPorPagarCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorPagarCaptionTextBox.Name = "cuentaPorPagarCaptionTextBox"
        Me.cuentaPorPagarCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorPagarCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.cuentaPorPagarCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.cuentaPorPagarCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cuentaPorPagarCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.cuentaPorPagarCaptionTextBox.Style.Font.Bold = True
        Me.cuentaPorPagarCaptionTextBox.Style.Font.Name = "Arial"
        Me.cuentaPorPagarCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaPorPagarCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaPorPagarCaptionTextBox.StyleName = "Caption"
        Me.cuentaPorPagarCaptionTextBox.Value = "CUENTA"
        '
        'nombreCuentaPorPagarCaptionTextBox
        '
        Me.nombreCuentaPorPagarCaptionTextBox.CanGrow = True
        Me.nombreCuentaPorPagarCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50009989738464355R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorPagarCaptionTextBox.Name = "nombreCuentaPorPagarCaptionTextBox"
        Me.nombreCuentaPorPagarCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorPagarCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.nombreCuentaPorPagarCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.nombreCuentaPorPagarCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.nombreCuentaPorPagarCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.nombreCuentaPorPagarCaptionTextBox.Style.Font.Bold = True
        Me.nombreCuentaPorPagarCaptionTextBox.Style.Font.Name = "Arial"
        Me.nombreCuentaPorPagarCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreCuentaPorPagarCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.nombreCuentaPorPagarCaptionTextBox.StyleName = "Caption"
        Me.nombreCuentaPorPagarCaptionTextBox.Value = "DESCRIPCIÓN"
        '
        'saldoMNCaptionTextBox1
        '
        Me.saldoMNCaptionTextBox1.CanGrow = True
        Me.saldoMNCaptionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNCaptionTextBox1.Name = "saldoMNCaptionTextBox1"
        Me.saldoMNCaptionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNCaptionTextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMNCaptionTextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMNCaptionTextBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.saldoMNCaptionTextBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMNCaptionTextBox1.Style.Font.Bold = True
        Me.saldoMNCaptionTextBox1.Style.Font.Name = "Arial"
        Me.saldoMNCaptionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMNCaptionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoMNCaptionTextBox1.StyleName = "Caption"
        Me.saldoMNCaptionTextBox1.Value = "MONTO MN"
        '
        'saldoMECaptionTextBox1
        '
        Me.saldoMECaptionTextBox1.CanGrow = True
        Me.saldoMECaptionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMECaptionTextBox1.Name = "saldoMECaptionTextBox1"
        Me.saldoMECaptionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMECaptionTextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMECaptionTextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMECaptionTextBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMECaptionTextBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMECaptionTextBox1.Style.Font.Bold = True
        Me.saldoMECaptionTextBox1.Style.Font.Name = "Arial"
        Me.saldoMECaptionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMECaptionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.saldoMECaptionTextBox1.StyleName = "Caption"
        Me.saldoMECaptionTextBox1.Value = "MONTO ME"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "SALDO MN"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(27.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "SALDO ME"
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
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.saldoMNSumFunctionTextBox, Me.saldoMESumFunctionTextBox, Me.saldoMNSumFunctionTextBox1, Me.saldoMESumFunctionTextBox1, Me.TextBox4, Me.TextBox7})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.reportFooter.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.reportFooter.Style.Visible = True
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.4997997283935547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "TOTALES: "
        '
        'saldoMNSumFunctionTextBox
        '
        Me.saldoMNSumFunctionTextBox.CanGrow = True
        Me.saldoMNSumFunctionTextBox.Format = "{0:N2}"
        Me.saldoMNSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNSumFunctionTextBox.Name = "saldoMNSumFunctionTextBox"
        Me.saldoMNSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNSumFunctionTextBox.Style.Font.Bold = True
        Me.saldoMNSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.saldoMNSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMNSumFunctionTextBox.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMNSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMNSumFunctionTextBox.StyleName = "Data"
        Me.saldoMNSumFunctionTextBox.Value = "=Sum(Fields.SaldoMNC)"
        '
        'saldoMESumFunctionTextBox
        '
        Me.saldoMESumFunctionTextBox.CanGrow = True
        Me.saldoMESumFunctionTextBox.Format = "{0:N2}"
        Me.saldoMESumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMESumFunctionTextBox.Name = "saldoMESumFunctionTextBox"
        Me.saldoMESumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMESumFunctionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMESumFunctionTextBox.Style.BorderWidth.Right = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMESumFunctionTextBox.Style.Font.Bold = True
        Me.saldoMESumFunctionTextBox.Style.Font.Name = "Arial"
        Me.saldoMESumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMESumFunctionTextBox.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMESumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMESumFunctionTextBox.StyleName = "Data"
        Me.saldoMESumFunctionTextBox.Value = "=Sum(Fields.SaldoMEC)"
        '
        'saldoMNSumFunctionTextBox1
        '
        Me.saldoMNSumFunctionTextBox1.CanGrow = True
        Me.saldoMNSumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoMNSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNSumFunctionTextBox1.Name = "saldoMNSumFunctionTextBox1"
        Me.saldoMNSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNSumFunctionTextBox1.Style.Font.Bold = True
        Me.saldoMNSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoMNSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMNSumFunctionTextBox1.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMNSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMNSumFunctionTextBox1.StyleName = "Data"
        Me.saldoMNSumFunctionTextBox1.Value = "=Sum(Fields.SaldoMNP)"
        '
        'saldoMESumFunctionTextBox1
        '
        Me.saldoMESumFunctionTextBox1.CanGrow = True
        Me.saldoMESumFunctionTextBox1.Format = "{0:N2}"
        Me.saldoMESumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMESumFunctionTextBox1.Name = "saldoMESumFunctionTextBox1"
        Me.saldoMESumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMESumFunctionTextBox1.Style.Font.Bold = True
        Me.saldoMESumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.saldoMESumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMESumFunctionTextBox1.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMESumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMESumFunctionTextBox1.StyleName = "Data"
        Me.saldoMESumFunctionTextBox1.Value = "=Sum(Fields.SaldoMEP)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "= SUM(Fields.SaldoMNC+ Fields.SaldoMNP)"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.999795913696289R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "= SUM(Fields.SaldoMEC+ Fields.SaldoMEP)"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.titleTextBox, Me.TextBox8, Me.TextBox9, Me.reportNameTextBox, Me.TextBox10, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox38, Me.TextBox39})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.Color = System.Drawing.Color.Black
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Title"
        Me.TextBox11.Value = "='DEL '+ Format('{0:dd/MM/yyyy}',Parameters.fechaInicio.Value)+' AL '+ Format('{0" & _
            ":dd/MM/yyyy}',Parameters.fechaFin.Value)"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.9972916841506958R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499593734741211R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "CONTROL ENTRE CUENTAS POR COBRAR Y PAGAR"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(22.499799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(22.499801635742187R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "RUC: 20453262767"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(22.499801635742187R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox10
        '
        Me.TextBox10.Format = "{0:g}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "PageInfo"
        Me.TextBox10.Value = "=PageNumber"
        '
        'TextBox12
        '
        Me.TextBox12.Format = "{0:d}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9997985363006592R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.StyleName = "PageInfo"
        Me.TextBox12.Value = "Página:"
        '
        'TextBox13
        '
        Me.TextBox13.Format = "{0:d}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9997985363006592R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.StyleName = "PageInfo"
        Me.TextBox13.Value = "Fecha:"
        '
        'TextBox14
        '
        Me.TextBox14.Format = "{0:d}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.StyleName = "PageInfo"
        Me.TextBox14.Value = "= Now()"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9997985363006592R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
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
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.proyectoDestinoDataTextBox, Me.cuentaPorCobrarDataTextBox, Me.nombreCuentaPorCobrarDataTextBox, Me.saldoMNDataTextBox, Me.saldoMEDataTextBox, Me.proyectoOrigenDataTextBox, Me.cuentaPorPagarDataTextBox, Me.nombreCuentaPorPagarDataTextBox, Me.saldoMNDataTextBox1, Me.saldoMEDataTextBox1, Me.TextBox3, Me.TextBox6, Me.TextBox16})
        Me.detail.Name = "detail"
        '
        'proyectoDestinoDataTextBox
        '
        Me.proyectoDestinoDataTextBox.CanGrow = True
        Me.proyectoDestinoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDestinoDataTextBox.Name = "proyectoDestinoDataTextBox"
        Me.proyectoDestinoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDestinoDataTextBox.Style.Font.Name = "Arial"
        Me.proyectoDestinoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoDestinoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.proyectoDestinoDataTextBox.StyleName = "Data"
        Me.proyectoDestinoDataTextBox.Value = "=Fields.ProyectoDestino"
        '
        'cuentaPorCobrarDataTextBox
        '
        Me.cuentaPorCobrarDataTextBox.CanGrow = True
        Me.cuentaPorCobrarDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5001999139785767R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorCobrarDataTextBox.Name = "cuentaPorCobrarDataTextBox"
        Me.cuentaPorCobrarDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorCobrarDataTextBox.Style.Font.Name = "Arial"
        Me.cuentaPorCobrarDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaPorCobrarDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaPorCobrarDataTextBox.StyleName = "Data"
        Me.cuentaPorCobrarDataTextBox.Value = "=Fields.CuentaPorCobrar"
        '
        'nombreCuentaPorCobrarDataTextBox
        '
        Me.nombreCuentaPorCobrarDataTextBox.CanGrow = True
        Me.nombreCuentaPorCobrarDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorCobrarDataTextBox.Name = "nombreCuentaPorCobrarDataTextBox"
        Me.nombreCuentaPorCobrarDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorCobrarDataTextBox.Style.Font.Name = "Arial"
        Me.nombreCuentaPorCobrarDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreCuentaPorCobrarDataTextBox.StyleName = "Data"
        Me.nombreCuentaPorCobrarDataTextBox.Value = "=Fields.NombreCuentaPorCobrar"
        '
        'saldoMNDataTextBox
        '
        Me.saldoMNDataTextBox.CanGrow = True
        Me.saldoMNDataTextBox.Format = "{0:N2}"
        Me.saldoMNDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNDataTextBox.Name = "saldoMNDataTextBox"
        Me.saldoMNDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNDataTextBox.Style.Font.Name = "Arial"
        Me.saldoMNDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMNDataTextBox.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMNDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMNDataTextBox.StyleName = "Data"
        Me.saldoMNDataTextBox.Value = "= Fields.SaldoMNC"
        '
        'saldoMEDataTextBox
        '
        Me.saldoMEDataTextBox.CanGrow = True
        Me.saldoMEDataTextBox.Format = "{0:N2}"
        Me.saldoMEDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMEDataTextBox.Name = "saldoMEDataTextBox"
        Me.saldoMEDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMEDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoMEDataTextBox.Style.Font.Name = "Arial"
        Me.saldoMEDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMEDataTextBox.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMEDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMEDataTextBox.StyleName = "Data"
        Me.saldoMEDataTextBox.Value = "= Fields.SaldoMEC"
        '
        'proyectoOrigenDataTextBox
        '
        Me.proyectoOrigenDataTextBox.CanGrow = True
        Me.proyectoOrigenDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoOrigenDataTextBox.Name = "proyectoOrigenDataTextBox"
        Me.proyectoOrigenDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoOrigenDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoOrigenDataTextBox.Style.Font.Name = "Arial"
        Me.proyectoOrigenDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoOrigenDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.proyectoOrigenDataTextBox.StyleName = "Data"
        Me.proyectoOrigenDataTextBox.Value = "=Fields.ProyectoOrigen"
        '
        'cuentaPorPagarDataTextBox
        '
        Me.cuentaPorPagarDataTextBox.CanGrow = True
        Me.cuentaPorPagarDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorPagarDataTextBox.Name = "cuentaPorPagarDataTextBox"
        Me.cuentaPorPagarDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaPorPagarDataTextBox.Style.Font.Name = "Arial"
        Me.cuentaPorPagarDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaPorPagarDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaPorPagarDataTextBox.StyleName = "Data"
        Me.cuentaPorPagarDataTextBox.Value = "=Fields.CuentaPorPagar"
        '
        'nombreCuentaPorPagarDataTextBox
        '
        Me.nombreCuentaPorPagarDataTextBox.CanGrow = True
        Me.nombreCuentaPorPagarDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorPagarDataTextBox.Name = "nombreCuentaPorPagarDataTextBox"
        Me.nombreCuentaPorPagarDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreCuentaPorPagarDataTextBox.Style.Font.Name = "Arial"
        Me.nombreCuentaPorPagarDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreCuentaPorPagarDataTextBox.StyleName = "Data"
        Me.nombreCuentaPorPagarDataTextBox.Value = "=Fields.NombreCuentaPorPagar"
        '
        'saldoMNDataTextBox1
        '
        Me.saldoMNDataTextBox1.CanGrow = True
        Me.saldoMNDataTextBox1.Format = "{0:N2}"
        Me.saldoMNDataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(22.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNDataTextBox1.Name = "saldoMNDataTextBox1"
        Me.saldoMNDataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMNDataTextBox1.Style.Font.Name = "Arial"
        Me.saldoMNDataTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMNDataTextBox1.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMNDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMNDataTextBox1.StyleName = "Data"
        Me.saldoMNDataTextBox1.Value = "= Fields.SaldoMNP"
        '
        'saldoMEDataTextBox1
        '
        Me.saldoMEDataTextBox1.CanGrow = True
        Me.saldoMEDataTextBox1.Format = "{0:N2}"
        Me.saldoMEDataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(24.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMEDataTextBox1.Name = "saldoMEDataTextBox1"
        Me.saldoMEDataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoMEDataTextBox1.Style.Font.Name = "Arial"
        Me.saldoMEDataTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoMEDataTextBox1.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.saldoMEDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.saldoMEDataTextBox1.StyleName = "Data"
        Me.saldoMEDataTextBox1.Value = "= Fields.SaldoMEP"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Format = "{0:N2}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "= Fields.SaldoMNC+ Fields.SaldoMNP"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(27.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "= Fields.SaldoMEC+ Fields.SaldoMEP"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500201225280762R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.49959924817085266R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.Color = System.Drawing.Color.Transparent
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Caption"
        Me.TextBox16.Value = "*"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(12.999800682067871R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.StyleName = "Caption"
        Me.TextBox18.Value = "CUENTAS POR COBRAR"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(12.499796867370605R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "CUENTAS POR PAGAR"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.500400543212891R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9991946220397949R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.StyleName = "Caption"
        Me.TextBox20.Value = "SALDOS"
        '
        'RepCuentasPagarCobrar
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
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
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(28.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents proyectoDestinoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaPorCobrarCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreCuentaPorCobrarCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMNCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMECaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoOrigenCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaPorPagarCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreCuentaPorPagarCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMNCaptionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoMECaptionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoMNSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMESumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMNSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoMESumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents proyectoDestinoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaPorCobrarDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreCuentaPorCobrarDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMNDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMEDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoOrigenDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaPorPagarDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreCuentaPorPagarDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoMNDataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents saldoMEDataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
End Class