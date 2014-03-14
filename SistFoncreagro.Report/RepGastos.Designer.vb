Partial Class RepGastos
    
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
        Me.SDSRepGastos = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.cuentaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fechaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.idSubDiarioCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.comprobanteCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cCostoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.razonSocialCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.montoSolesCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.montoDolaresCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.codProyectoGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.codProyectoDataTextBox = New Telerik.Reporting.TextBox()
        Me.codProyectoGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.montoSolesSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.montoDolaresSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.codProyectoGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.montoSolesSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.montoDolaresSumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.cuentaDataTextBox = New Telerik.Reporting.TextBox()
        Me.fechaDataTextBox = New Telerik.Reporting.TextBox()
        Me.idSubDiarioDataTextBox = New Telerik.Reporting.TextBox()
        Me.comprobanteDataTextBox = New Telerik.Reporting.TextBox()
        Me.cCostoDataTextBox = New Telerik.Reporting.TextBox()
        Me.razonSocialDataTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionDataTextBox = New Telerik.Reporting.TextBox()
        Me.montoSolesDataTextBox = New Telerik.Reporting.TextBox()
        Me.montoDolaresDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepGastos
        '
        Me.SDSRepGastos.ConnectionString = "cnx"
        Me.SDSRepGastos.Name = "SDSRepGastos"
        Me.SDSRepGastos.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@FechaInicio", System.Data.DbType.DateTime, "=Parameters.FechaInicio.Value"), New Telerik.Reporting.SqlDataSourceParameter("@FechaFin", System.Data.DbType.DateTime, "=Parameters.FechaFin.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value")})
        Me.SDSRepGastos.SelectCommand = "dbo.RepGastos"
        Me.SDSRepGastos.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
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
        'cuentaCaptionTextBox
        '
        Me.cuentaCaptionTextBox.CanGrow = True
        Me.cuentaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaCaptionTextBox.Name = "cuentaCaptionTextBox"
        Me.cuentaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cuentaCaptionTextBox.Style.Font.Name = "Arial"
        Me.cuentaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaCaptionTextBox.StyleName = "Caption"
        Me.cuentaCaptionTextBox.Value = "CUENTA"
        '
        'fechaCaptionTextBox
        '
        Me.fechaCaptionTextBox.CanGrow = True
        Me.fechaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaCaptionTextBox.Name = "fechaCaptionTextBox"
        Me.fechaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaCaptionTextBox.StyleName = "Caption"
        Me.fechaCaptionTextBox.Value = "FECHA"
        '
        'idSubDiarioCaptionTextBox
        '
        Me.idSubDiarioCaptionTextBox.CanGrow = True
        Me.idSubDiarioCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioCaptionTextBox.Name = "idSubDiarioCaptionTextBox"
        Me.idSubDiarioCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.idSubDiarioCaptionTextBox.Style.Font.Name = "Arial"
        Me.idSubDiarioCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idSubDiarioCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.idSubDiarioCaptionTextBox.StyleName = "Caption"
        Me.idSubDiarioCaptionTextBox.Value = "S.D."
        '
        'comprobanteCaptionTextBox
        '
        Me.comprobanteCaptionTextBox.CanGrow = True
        Me.comprobanteCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.9998002052307129R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.comprobanteCaptionTextBox.Name = "comprobanteCaptionTextBox"
        Me.comprobanteCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.comprobanteCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.comprobanteCaptionTextBox.Style.Font.Name = "Arial"
        Me.comprobanteCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.comprobanteCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.comprobanteCaptionTextBox.StyleName = "Caption"
        Me.comprobanteCaptionTextBox.Value = "COMP."
        '
        'cCostoCaptionTextBox
        '
        Me.cCostoCaptionTextBox.CanGrow = True
        Me.cCostoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cCostoCaptionTextBox.Name = "cCostoCaptionTextBox"
        Me.cCostoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cCostoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cCostoCaptionTextBox.Style.Font.Name = "Arial"
        Me.cCostoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cCostoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cCostoCaptionTextBox.StyleName = "Caption"
        Me.cCostoCaptionTextBox.Value = "C. COSTO"
        '
        'razonSocialCaptionTextBox
        '
        Me.razonSocialCaptionTextBox.CanGrow = True
        Me.razonSocialCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialCaptionTextBox.Name = "razonSocialCaptionTextBox"
        Me.razonSocialCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.razonSocialCaptionTextBox.Style.Font.Name = "Arial"
        Me.razonSocialCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.razonSocialCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.razonSocialCaptionTextBox.StyleName = "Caption"
        Me.razonSocialCaptionTextBox.Value = "COA"
        '
        'descripcionCaptionTextBox
        '
        Me.descripcionCaptionTextBox.CanGrow = True
        Me.descripcionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Name = "descripcionCaptionTextBox"
        Me.descripcionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.descripcionCaptionTextBox.Style.Font.Name = "Arial"
        Me.descripcionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.descripcionCaptionTextBox.StyleName = "Caption"
        Me.descripcionCaptionTextBox.Value = "DESCRIPCIÓN"
        '
        'montoSolesCaptionTextBox
        '
        Me.montoSolesCaptionTextBox.CanGrow = True
        Me.montoSolesCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesCaptionTextBox.Name = "montoSolesCaptionTextBox"
        Me.montoSolesCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.montoSolesCaptionTextBox.Style.Font.Name = "Arial"
        Me.montoSolesCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoSolesCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.montoSolesCaptionTextBox.StyleName = "Caption"
        Me.montoSolesCaptionTextBox.Value = "Soles"
        '
        'montoDolaresCaptionTextBox
        '
        Me.montoDolaresCaptionTextBox.CanGrow = True
        Me.montoDolaresCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresCaptionTextBox.Name = "montoDolaresCaptionTextBox"
        Me.montoDolaresCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.montoDolaresCaptionTextBox.Style.Font.Name = "Arial"
        Me.montoDolaresCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoDolaresCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.montoDolaresCaptionTextBox.StyleName = "Caption"
        Me.montoDolaresCaptionTextBox.Value = "Dolares"
        '
        'codProyectoGroupHeader
        '
        Me.codProyectoGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codProyectoGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codProyectoDataTextBox, Me.cCostoCaptionTextBox, Me.fechaCaptionTextBox, Me.idSubDiarioCaptionTextBox, Me.comprobanteCaptionTextBox, Me.cuentaCaptionTextBox, Me.razonSocialCaptionTextBox, Me.descripcionCaptionTextBox, Me.montoSolesCaptionTextBox, Me.montoDolaresCaptionTextBox})
        Me.codProyectoGroupHeader.Name = "codProyectoGroupHeader"
        Me.codProyectoGroupHeader.PageBreak = Telerik.Reporting.PageBreak.Before
        Me.codProyectoGroupHeader.PrintOnEveryPage = True
        '
        'codProyectoDataTextBox
        '
        Me.codProyectoDataTextBox.CanGrow = True
        Me.codProyectoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codProyectoDataTextBox.Name = "codProyectoDataTextBox"
        Me.codProyectoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(19.999900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codProyectoDataTextBox.Style.Font.Name = "Arial"
        Me.codProyectoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codProyectoDataTextBox.StyleName = "Data"
        Me.codProyectoDataTextBox.Value = "=Fields.CodProyecto+' '+ Fields.NomProyecto"
        '
        'codProyectoGroupFooter
        '
        Me.codProyectoGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codProyectoGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.montoSolesSumFunctionTextBox, Me.montoDolaresSumFunctionTextBox})
        Me.codProyectoGroupFooter.Name = "codProyectoGroupFooter"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "='TOTAL PROYECTO '+ Fields.CodProyecto+' '+ Fields.NomProyecto+': '"
        '
        'montoSolesSumFunctionTextBox
        '
        Me.montoSolesSumFunctionTextBox.CanGrow = True
        Me.montoSolesSumFunctionTextBox.Format = "{0:N2}"
        Me.montoSolesSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesSumFunctionTextBox.Name = "montoSolesSumFunctionTextBox"
        Me.montoSolesSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.montoSolesSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoSolesSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoSolesSumFunctionTextBox.StyleName = "Data"
        Me.montoSolesSumFunctionTextBox.Value = "=Sum(Fields.MontoSoles)"
        '
        'montoDolaresSumFunctionTextBox
        '
        Me.montoDolaresSumFunctionTextBox.CanGrow = True
        Me.montoDolaresSumFunctionTextBox.Format = "{0:N2}"
        Me.montoDolaresSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresSumFunctionTextBox.Name = "montoDolaresSumFunctionTextBox"
        Me.montoDolaresSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.montoDolaresSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoDolaresSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoDolaresSumFunctionTextBox.StyleName = "Data"
        Me.montoDolaresSumFunctionTextBox.Value = "=Sum(Fields.MontoDolares)"
        '
        'codProyectoGroup
        '
        Me.codProyectoGroup.GroupFooter = Me.codProyectoGroupFooter
        Me.codProyectoGroup.GroupHeader = Me.codProyectoGroupHeader
        Me.codProyectoGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.CodProyecto")})
        Me.codProyectoGroup.Name = "codProyectoGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.montoSolesSumFunctionTextBox1, Me.montoDolaresSumFunctionTextBox1})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "TOTAL GENERAL: "
        '
        'montoSolesSumFunctionTextBox1
        '
        Me.montoSolesSumFunctionTextBox1.CanGrow = True
        Me.montoSolesSumFunctionTextBox1.Format = "{0:N2}"
        Me.montoSolesSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesSumFunctionTextBox1.Name = "montoSolesSumFunctionTextBox1"
        Me.montoSolesSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.montoSolesSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoSolesSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoSolesSumFunctionTextBox1.StyleName = "Data"
        Me.montoSolesSumFunctionTextBox1.Value = "=Sum(Fields.MontoSoles)"
        '
        'montoDolaresSumFunctionTextBox1
        '
        Me.montoDolaresSumFunctionTextBox1.CanGrow = True
        Me.montoDolaresSumFunctionTextBox1.Format = "{0:N2}"
        Me.montoDolaresSumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresSumFunctionTextBox1.Name = "montoDolaresSumFunctionTextBox1"
        Me.montoDolaresSumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresSumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.montoDolaresSumFunctionTextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoDolaresSumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoDolaresSumFunctionTextBox1.StyleName = "Data"
        Me.montoDolaresSumFunctionTextBox1.Value = "=Sum(Fields.MontoDolares)"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.4999001026153564R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.TextBox4, Me.TextBox5, Me.reportNameTextBox, Me.TextBox3, Me.TextBox39, Me.TextBox38, Me.TextBox9, Me.TextBox8, Me.TextBox7, Me.TextBox6})
        Me.pageHeader.Name = "pageHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Color = System.Drawing.Color.Black
        Me.titleTextBox.Style.Font.Bold = True
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "CONSOLIDADO DE GASTOS"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0027083158493042R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.StyleName = "PageInfo"
        Me.TextBox4.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.StyleName = "PageInfo"
        Me.TextBox5.Value = "RUC: 20453262767"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.4999003410339355R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Color = System.Drawing.Color.Black
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Title"
        Me.TextBox3.Value = "='DEL '+ Format('{0:dd/MM/yyyy}', Parameters.FechaInicio.Value)+' AL '+Format('{0" & _
            ":dd/MM/yyyy}', Parameters.FechaFin.Value)"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.000202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999982118606567R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4998983144760132R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999985098838806R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4998983144760132R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "= Now()"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.000202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999985098838806R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Fecha:"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:d}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.000202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4997981786727905R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.StyleName = "PageInfo"
        Me.TextBox7.Value = "Página:"
        '
        'TextBox6
        '
        Me.TextBox6.Format = "{0:g}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.4998983144760132R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "=PageNumber"
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
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.cuentaDataTextBox, Me.fechaDataTextBox, Me.idSubDiarioDataTextBox, Me.comprobanteDataTextBox, Me.cCostoDataTextBox, Me.razonSocialDataTextBox, Me.descripcionDataTextBox, Me.montoSolesDataTextBox, Me.montoDolaresDataTextBox})
        Me.detail.Name = "detail"
        '
        'cuentaDataTextBox
        '
        Me.cuentaDataTextBox.CanGrow = True
        Me.cuentaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaDataTextBox.Name = "cuentaDataTextBox"
        Me.cuentaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cuentaDataTextBox.Style.Font.Name = "Arial"
        Me.cuentaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cuentaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cuentaDataTextBox.StyleName = "Data"
        Me.cuentaDataTextBox.Value = "=Fields.Cuenta"
        '
        'fechaDataTextBox
        '
        Me.fechaDataTextBox.CanGrow = True
        Me.fechaDataTextBox.Format = "{0:d}"
        Me.fechaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDataTextBox.Name = "fechaDataTextBox"
        Me.fechaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDataTextBox.Style.Font.Name = "Arial"
        Me.fechaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaDataTextBox.StyleName = "Data"
        Me.fechaDataTextBox.Value = "=Fields.Fecha"
        '
        'idSubDiarioDataTextBox
        '
        Me.idSubDiarioDataTextBox.CanGrow = True
        Me.idSubDiarioDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioDataTextBox.Name = "idSubDiarioDataTextBox"
        Me.idSubDiarioDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.idSubDiarioDataTextBox.Style.Font.Name = "Arial"
        Me.idSubDiarioDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.idSubDiarioDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.idSubDiarioDataTextBox.StyleName = "Data"
        Me.idSubDiarioDataTextBox.Value = "=Fields.IdSubDiario"
        '
        'comprobanteDataTextBox
        '
        Me.comprobanteDataTextBox.CanGrow = True
        Me.comprobanteDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(3.9997999668121338R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.comprobanteDataTextBox.Name = "comprobanteDataTextBox"
        Me.comprobanteDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.comprobanteDataTextBox.Style.Font.Name = "Arial"
        Me.comprobanteDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.comprobanteDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.comprobanteDataTextBox.StyleName = "Data"
        Me.comprobanteDataTextBox.Value = "=Fields.Comprobante"
        '
        'cCostoDataTextBox
        '
        Me.cCostoDataTextBox.CanGrow = True
        Me.cCostoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(4.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cCostoDataTextBox.Name = "cCostoDataTextBox"
        Me.cCostoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cCostoDataTextBox.Style.Font.Name = "Arial"
        Me.cCostoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cCostoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cCostoDataTextBox.StyleName = "Data"
        Me.cCostoDataTextBox.Value = "=Fields.CCosto"
        '
        'razonSocialDataTextBox
        '
        Me.razonSocialDataTextBox.CanGrow = True
        Me.razonSocialDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialDataTextBox.Name = "razonSocialDataTextBox"
        Me.razonSocialDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.razonSocialDataTextBox.Style.Font.Name = "Arial"
        Me.razonSocialDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.razonSocialDataTextBox.StyleName = "Data"
        Me.razonSocialDataTextBox.Value = "=Fields.RazonSocial"
        '
        'descripcionDataTextBox
        '
        Me.descripcionDataTextBox.CanGrow = True
        Me.descripcionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Name = "descripcionDataTextBox"
        Me.descripcionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Style.Font.Name = "Arial"
        Me.descripcionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionDataTextBox.StyleName = "Data"
        Me.descripcionDataTextBox.Value = "=Fields.Descripcion"
        '
        'montoSolesDataTextBox
        '
        Me.montoSolesDataTextBox.CanGrow = True
        Me.montoSolesDataTextBox.Format = "{0:N2}"
        Me.montoSolesDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesDataTextBox.Name = "montoSolesDataTextBox"
        Me.montoSolesDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoSolesDataTextBox.Style.Font.Name = "Arial"
        Me.montoSolesDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoSolesDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoSolesDataTextBox.StyleName = "Data"
        Me.montoSolesDataTextBox.Value = "=Fields.MontoSoles"
        '
        'montoDolaresDataTextBox
        '
        Me.montoDolaresDataTextBox.CanGrow = True
        Me.montoDolaresDataTextBox.Format = "{0:N2}"
        Me.montoDolaresDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresDataTextBox.Name = "montoDolaresDataTextBox"
        Me.montoDolaresDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoDolaresDataTextBox.Style.Font.Name = "Arial"
        Me.montoDolaresDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoDolaresDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoDolaresDataTextBox.StyleName = "Data"
        Me.montoDolaresDataTextBox.Value = "=Fields.MontoDolares"
        '
        'RepGastos
        '
        Me.DataSource = Me.SDSRepGastos
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.codProyectoGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.codProyectoGroupHeader, Me.codProyectoGroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "FechaInicio"
        ReportParameter1.Text = "FechaInicio"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        ReportParameter2.Name = "FechaFin"
        ReportParameter2.Text = "FechaFin"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Visible = True
        ReportParameter3.Name = "idProyecto"
        ReportParameter3.Text = "idProyecto"
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(20.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepGastos As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents cuentaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idSubDiarioCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents comprobanteCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cCostoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents razonSocialCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoSolesCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoDolaresCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents codProyectoGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents codProyectoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codProyectoGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents montoSolesSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoDolaresSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codProyectoGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents montoSolesSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents montoDolaresSumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents cuentaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idSubDiarioDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents comprobanteDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cCostoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents razonSocialDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoSolesDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoDolaresDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
End Class