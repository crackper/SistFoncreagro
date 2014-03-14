Partial Class RepConciliacionBancaria
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepConciliacionBancaria))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepConciliacionBancaria = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.fechaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.idProveedorClienteCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.glosaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.montoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.movimientoGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.movimientoDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.movimientoGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.movimientoGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.montoSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.bancoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.bancoDataTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionDataTextBox = New Telerik.Reporting.TextBox()
        Me.idMonedaDataTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaContableCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cuentaContableDataTextBox = New Telerik.Reporting.TextBox()
        Me.saldoBancarioCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.idSubdiarioCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.idSubdiarioDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fechaDataTextBox = New Telerik.Reporting.TextBox()
        Me.idProveedorClienteDataTextBox = New Telerik.Reporting.TextBox()
        Me.glosaDataTextBox = New Telerik.Reporting.TextBox()
        Me.montoDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepConciliacionBancaria
        '
        Me.SDSRepConciliacionBancaria.ConnectionString = "cnx"
        Me.SDSRepConciliacionBancaria.Name = "SDSRepConciliacionBancaria"
        Me.SDSRepConciliacionBancaria.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@idConciliacion", System.Data.DbType.Int32, "=Parameters.idConciliacion.Value")})
        Me.SDSRepConciliacionBancaria.SelectCommand = "dbo.RepConciliacionBancaria"
        Me.SDSRepConciliacionBancaria.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fechaCaptionTextBox, Me.idProveedorClienteCaptionTextBox, Me.glosaCaptionTextBox, Me.montoCaptionTextBox})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        Me.labelsGroupHeader.Style.Visible = False
        '
        'fechaCaptionTextBox
        '
        Me.fechaCaptionTextBox.CanGrow = True
        Me.fechaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaCaptionTextBox.Name = "fechaCaptionTextBox"
        Me.fechaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaCaptionTextBox.Style.Font.Bold = True
        Me.fechaCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaCaptionTextBox.StyleName = "Caption"
        Me.fechaCaptionTextBox.Value = "FECHA"
        '
        'idProveedorClienteCaptionTextBox
        '
        Me.idProveedorClienteCaptionTextBox.CanGrow = True
        Me.idProveedorClienteCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idProveedorClienteCaptionTextBox.Name = "idProveedorClienteCaptionTextBox"
        Me.idProveedorClienteCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idProveedorClienteCaptionTextBox.Style.Font.Bold = True
        Me.idProveedorClienteCaptionTextBox.Style.Font.Name = "Arial"
        Me.idProveedorClienteCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idProveedorClienteCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.idProveedorClienteCaptionTextBox.StyleName = "Caption"
        Me.idProveedorClienteCaptionTextBox.Value = "COA"
        '
        'glosaCaptionTextBox
        '
        Me.glosaCaptionTextBox.CanGrow = True
        Me.glosaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.glosaCaptionTextBox.Name = "glosaCaptionTextBox"
        Me.glosaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.glosaCaptionTextBox.Style.Font.Bold = True
        Me.glosaCaptionTextBox.Style.Font.Name = "Arial"
        Me.glosaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.glosaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.glosaCaptionTextBox.StyleName = "Caption"
        Me.glosaCaptionTextBox.Value = "GLOSA"
        '
        'montoCaptionTextBox
        '
        Me.montoCaptionTextBox.CanGrow = True
        Me.montoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoCaptionTextBox.Name = "montoCaptionTextBox"
        Me.montoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoCaptionTextBox.Style.Font.Bold = True
        Me.montoCaptionTextBox.Style.Font.Name = "Arial"
        Me.montoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.montoCaptionTextBox.StyleName = "Caption"
        Me.montoCaptionTextBox.Value = "MONTO"
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
        'movimientoGroupHeader
        '
        Me.movimientoGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.movimientoGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.movimientoDataTextBox, Me.TextBox10})
        Me.movimientoGroupHeader.Name = "movimientoGroupHeader"
        '
        'movimientoDataTextBox
        '
        Me.movimientoDataTextBox.CanGrow = True
        Me.movimientoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.movimientoDataTextBox.Name = "movimientoDataTextBox"
        Me.movimientoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.movimientoDataTextBox.Style.Font.Bold = True
        Me.movimientoDataTextBox.Style.Font.Name = "Arial"
        Me.movimientoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.movimientoDataTextBox.StyleName = "Data"
        Me.movimientoDataTextBox.Value = "=Fields.Movimiento"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:N2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "= Sum(Fields.Monto)"
        '
        'movimientoGroupFooter
        '
        Me.movimientoGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.movimientoGroupFooter.Name = "movimientoGroupFooter"
        Me.movimientoGroupFooter.Style.Visible = True
        '
        'movimientoGroup
        '
        Me.movimientoGroup.GroupFooter = Me.movimientoGroupFooter
        Me.movimientoGroup.GroupHeader = Me.movimientoGroupHeader
        Me.movimientoGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Movimiento")})
        Me.movimientoGroup.Name = "movimientoGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.montoSumFunctionTextBox1})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.000098356802482157946R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "SALDO SEGUN LIBROS:"
        '
        'montoSumFunctionTextBox1
        '
        Me.montoSumFunctionTextBox1.CanGrow = True
        Me.montoSumFunctionTextBox1.Format = "{0:N2}"
        Me.montoSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.000098356802482157946R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSumFunctionTextBox1.Name = "montoSumFunctionTextBox1"
        Me.montoSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSumFunctionTextBox1.Style.Font.Bold = True
        Me.montoSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.montoSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoSumFunctionTextBox1.StyleName = "Data"
        Me.montoSumFunctionTextBox1.Value = "= Fields.SaldoBancario+ Sum(Fields.Monto)"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox3, Me.TextBox4, Me.reportNameTextBox, Me.TextBox6})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Color = System.Drawing.Color.Black
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Title"
        Me.TextBox5.Value = resources.GetString("TextBox5.Value")
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.StyleName = "PageInfo"
        Me.TextBox3.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.StyleName = "PageInfo"
        Me.TextBox4.Value = "RUC: 20453262767"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Color = System.Drawing.Color.Black
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Title"
        Me.TextBox6.Value = "CONCILIACION BANCARIA"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(3.9998002052307129R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.bancoCaptionTextBox, Me.bancoDataTextBox, Me.descripcionCaptionTextBox, Me.descripcionDataTextBox, Me.idMonedaDataTextBox, Me.cuentaContableCaptionTextBox, Me.cuentaContableDataTextBox, Me.saldoBancarioCaptionTextBox, Me.idSubdiarioCaptionTextBox, Me.idSubdiarioDataTextBox, Me.TextBox7, Me.TextBox8, Me.TextBox9})
        Me.reportHeader.Name = "reportHeader"
        '
        'bancoCaptionTextBox
        '
        Me.bancoCaptionTextBox.CanGrow = True
        Me.bancoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.bancoCaptionTextBox.Name = "bancoCaptionTextBox"
        Me.bancoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.bancoCaptionTextBox.Style.Font.Name = "Arial"
        Me.bancoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.bancoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.bancoCaptionTextBox.StyleName = "Caption"
        Me.bancoCaptionTextBox.Value = "BANCO:"
        '
        'bancoDataTextBox
        '
        Me.bancoDataTextBox.CanGrow = True
        Me.bancoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.bancoDataTextBox.Name = "bancoDataTextBox"
        Me.bancoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.bancoDataTextBox.Style.Font.Name = "Arial"
        Me.bancoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.bancoDataTextBox.StyleName = "Data"
        Me.bancoDataTextBox.Value = "=Fields.Banco"
        '
        'descripcionCaptionTextBox
        '
        Me.descripcionCaptionTextBox.CanGrow = True
        Me.descripcionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Name = "descripcionCaptionTextBox"
        Me.descripcionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Style.Font.Name = "Arial"
        Me.descripcionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.descripcionCaptionTextBox.StyleName = "Caption"
        Me.descripcionCaptionTextBox.Value = "DESCRIPCION:"
        '
        'descripcionDataTextBox
        '
        Me.descripcionDataTextBox.CanGrow = True
        Me.descripcionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Name = "descripcionDataTextBox"
        Me.descripcionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Style.Font.Name = "Arial"
        Me.descripcionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionDataTextBox.StyleName = "Data"
        Me.descripcionDataTextBox.Value = "=Fields.Descripcion+' '+ Fields.NroCta"
        '
        'idMonedaDataTextBox
        '
        Me.idMonedaDataTextBox.CanGrow = True
        Me.idMonedaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idMonedaDataTextBox.Name = "idMonedaDataTextBox"
        Me.idMonedaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idMonedaDataTextBox.Style.Font.Name = "Arial"
        Me.idMonedaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idMonedaDataTextBox.StyleName = "Data"
        Me.idMonedaDataTextBox.Value = "= IIf(Fields.IdMoneda=1,'NUEVOS SOLES','DOLARES')"
        '
        'cuentaContableCaptionTextBox
        '
        Me.cuentaContableCaptionTextBox.CanGrow = True
        Me.cuentaContableCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaContableCaptionTextBox.Name = "cuentaContableCaptionTextBox"
        Me.cuentaContableCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaContableCaptionTextBox.Style.Font.Name = "Arial"
        Me.cuentaContableCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaContableCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.cuentaContableCaptionTextBox.StyleName = "Caption"
        Me.cuentaContableCaptionTextBox.Value = "CUENTA:"
        '
        'cuentaContableDataTextBox
        '
        Me.cuentaContableDataTextBox.CanGrow = True
        Me.cuentaContableDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaContableDataTextBox.Name = "cuentaContableDataTextBox"
        Me.cuentaContableDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaContableDataTextBox.Style.Font.Name = "Arial"
        Me.cuentaContableDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaContableDataTextBox.StyleName = "Data"
        Me.cuentaContableDataTextBox.Value = "=Fields.CuentaContable"
        '
        'saldoBancarioCaptionTextBox
        '
        Me.saldoBancarioCaptionTextBox.CanGrow = True
        Me.saldoBancarioCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoBancarioCaptionTextBox.Name = "saldoBancarioCaptionTextBox"
        Me.saldoBancarioCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.saldoBancarioCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.saldoBancarioCaptionTextBox.Style.Font.Bold = True
        Me.saldoBancarioCaptionTextBox.Style.Font.Name = "Arial"
        Me.saldoBancarioCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.saldoBancarioCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.saldoBancarioCaptionTextBox.StyleName = "Caption"
        Me.saldoBancarioCaptionTextBox.Value = "SALDO SEGÚN ESTADO DE CUENTA BANCARIO:"
        '
        'idSubdiarioCaptionTextBox
        '
        Me.idSubdiarioCaptionTextBox.CanGrow = True
        Me.idSubdiarioCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubdiarioCaptionTextBox.Name = "idSubdiarioCaptionTextBox"
        Me.idSubdiarioCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9998996257781982R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubdiarioCaptionTextBox.Style.Font.Name = "Arial"
        Me.idSubdiarioCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idSubdiarioCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.idSubdiarioCaptionTextBox.StyleName = "Caption"
        Me.idSubdiarioCaptionTextBox.Value = "SUBDIARIO:"
        '
        'idSubdiarioDataTextBox
        '
        Me.idSubdiarioDataTextBox.CanGrow = True
        Me.idSubdiarioDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubdiarioDataTextBox.Name = "idSubdiarioDataTextBox"
        Me.idSubdiarioDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubdiarioDataTextBox.Style.Font.Name = "Arial"
        Me.idSubdiarioDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idSubdiarioDataTextBox.StyleName = "Data"
        Me.idSubdiarioDataTextBox.Value = "=Fields.IdSubdiario"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "MONEDA:"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "= Fields.SaldoBancario"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = resources.GetString("TextBox9.Value")
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.50019937753677368R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fechaDataTextBox, Me.idProveedorClienteDataTextBox, Me.glosaDataTextBox, Me.montoDataTextBox})
        Me.detail.Name = "detail"
        '
        'fechaDataTextBox
        '
        Me.fechaDataTextBox.CanGrow = True
        Me.fechaDataTextBox.Format = "{0:d}"
        Me.fechaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDataTextBox.Name = "fechaDataTextBox"
        Me.fechaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDataTextBox.Style.Font.Name = "Arial"
        Me.fechaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaDataTextBox.StyleName = "Data"
        Me.fechaDataTextBox.Value = "= Fields.FechaMov"
        '
        'idProveedorClienteDataTextBox
        '
        Me.idProveedorClienteDataTextBox.CanGrow = True
        Me.idProveedorClienteDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.4999998807907104R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idProveedorClienteDataTextBox.Name = "idProveedorClienteDataTextBox"
        Me.idProveedorClienteDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idProveedorClienteDataTextBox.Style.Font.Name = "Arial"
        Me.idProveedorClienteDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idProveedorClienteDataTextBox.StyleName = "Data"
        Me.idProveedorClienteDataTextBox.Value = "= Fields.Coa"
        '
        'glosaDataTextBox
        '
        Me.glosaDataTextBox.CanGrow = True
        Me.glosaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.9999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.glosaDataTextBox.Name = "glosaDataTextBox"
        Me.glosaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.glosaDataTextBox.Style.Font.Name = "Arial"
        Me.glosaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.glosaDataTextBox.StyleName = "Data"
        Me.glosaDataTextBox.Value = "=Fields.Glosa"
        '
        'montoDataTextBox
        '
        Me.montoDataTextBox.CanGrow = True
        Me.montoDataTextBox.Format = "{0:N2}"
        Me.montoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDataTextBox.Name = "montoDataTextBox"
        Me.montoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDataTextBox.Style.Font.Name = "Arial"
        Me.montoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoDataTextBox.StyleName = "Data"
        Me.montoDataTextBox.Value = "=Fields.Monto"
        '
        'RepConciliacionBancaria
        '
        Me.DataSource = Me.SDSRepConciliacionBancaria
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.movimientoGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.movimientoGroupHeader, Me.movimientoGroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "idConciliacion"
        ReportParameter1.Text = "idConciliacion"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepConciliacionBancaria As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fechaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idProveedorClienteCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents glosaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents movimientoGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents movimientoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents movimientoGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents movimientoGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents montoSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents bancoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents bancoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idMonedaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaContableCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cuentaContableDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents saldoBancarioCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idSubdiarioCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idSubdiarioDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fechaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idProveedorClienteDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents glosaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
End Class