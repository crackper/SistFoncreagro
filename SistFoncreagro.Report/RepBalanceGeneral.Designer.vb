Partial Class RepBalanceGeneral
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepBalanceGeneral))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepBalanceGeneral = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.nombreNota3DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota3DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota3DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota4DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota4DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota4DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota5DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota5DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota5DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota6DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota6DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota6DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota7DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota7DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota7DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota8DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota8DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota8DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota9DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota9DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota9DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota10DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota10DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota10DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota11DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota11DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota11DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota12DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota12DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota12DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota13DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota13DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota13DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota14DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota14DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota14DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota15DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota15DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota15DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota16DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota16DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota16DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota17DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota17DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota17DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota18DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota18DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota18DataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreNota19DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioActualNota19DataTextBox = New Telerik.Reporting.TextBox()
        Me.anioAnteriorNota19DataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepBalanceGeneral
        '
        Me.SDSRepBalanceGeneral.ConnectionString = "cnx"
        Me.SDSRepBalanceGeneral.Name = "SDSRepBalanceGeneral"
        Me.SDSRepBalanceGeneral.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@fechaFin", System.Data.DbType.DateTime, "=Parameters.fechaFin.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value"), New Telerik.Reporting.SqlDataSourceParameter("@tipo", System.Data.DbType.AnsiStringFixedLength, "=Parameters.tipo.Value")})
        Me.SDSRepBalanceGeneral.SelectCommand = "dbo.RepBalanceGeneral"
        Me.SDSRepBalanceGeneral.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
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
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.TextBox5, Me.TextBox3, Me.TextBox2, Me.reportNameTextBox, Me.titleTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Color = System.Drawing.Color.Black
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Title"
        Me.TextBox6.Value = "(Expresado en Nuevos Soles)"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
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
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.StyleName = "PageInfo"
        Me.TextBox3.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.StyleName = "PageInfo"
        Me.TextBox2.Value = "RUC: 20453262767"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.499900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Color = System.Drawing.Color.Black
        Me.titleTextBox.Style.Font.Bold = True
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "='BALANCE GENERAL '+ IIf(Parameters.tipo.Value='I','INSTITUCIONAL', IIf(Parameter" & _
            "s.tipo.Value='P','POR PROYECTOS', IIf(Parameters.tipo.Value='A', Parameters.proy" & _
            "ecto.Value,'')))"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        Me.pageFooter.Style.Visible = True
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Name = "reportHeader"
        Me.reportHeader.Style.Visible = False
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(13.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.nombreNota3DataTextBox, Me.anioActualNota3DataTextBox, Me.anioAnteriorNota3DataTextBox, Me.nombreNota4DataTextBox, Me.anioActualNota4DataTextBox, Me.anioAnteriorNota4DataTextBox, Me.nombreNota5DataTextBox, Me.anioActualNota5DataTextBox, Me.anioAnteriorNota5DataTextBox, Me.nombreNota6DataTextBox, Me.anioActualNota6DataTextBox, Me.anioAnteriorNota6DataTextBox, Me.nombreNota7DataTextBox, Me.anioActualNota7DataTextBox, Me.anioAnteriorNota7DataTextBox, Me.nombreNota8DataTextBox, Me.anioActualNota8DataTextBox, Me.anioAnteriorNota8DataTextBox, Me.nombreNota9DataTextBox, Me.anioActualNota9DataTextBox, Me.anioAnteriorNota9DataTextBox, Me.nombreNota10DataTextBox, Me.anioActualNota10DataTextBox, Me.anioAnteriorNota10DataTextBox, Me.nombreNota11DataTextBox, Me.anioActualNota11DataTextBox, Me.anioAnteriorNota11DataTextBox, Me.nombreNota12DataTextBox, Me.anioActualNota12DataTextBox, Me.anioAnteriorNota12DataTextBox, Me.nombreNota13DataTextBox, Me.anioActualNota13DataTextBox, Me.anioAnteriorNota13DataTextBox, Me.nombreNota14DataTextBox, Me.anioActualNota14DataTextBox, Me.anioAnteriorNota14DataTextBox, Me.nombreNota15DataTextBox, Me.anioActualNota15DataTextBox, Me.anioAnteriorNota15DataTextBox, Me.nombreNota16DataTextBox, Me.anioActualNota16DataTextBox, Me.anioAnteriorNota16DataTextBox, Me.nombreNota17DataTextBox, Me.anioActualNota17DataTextBox, Me.anioAnteriorNota17DataTextBox, Me.nombreNota18DataTextBox, Me.anioActualNota18DataTextBox, Me.anioAnteriorNota18DataTextBox, Me.nombreNota19DataTextBox, Me.anioActualNota19DataTextBox, Me.anioAnteriorNota19DataTextBox, Me.TextBox48, Me.TextBox1, Me.TextBox4, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.TextBox47, Me.TextBox49, Me.TextBox50, Me.TextBox51, Me.TextBox52, Me.TextBox53})
        Me.detail.Name = "detail"
        '
        'nombreNota3DataTextBox
        '
        Me.nombreNota3DataTextBox.CanGrow = True
        Me.nombreNota3DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002005100250244R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota3DataTextBox.Name = "nombreNota3DataTextBox"
        Me.nombreNota3DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota3DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota3DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota3DataTextBox.StyleName = "Data"
        Me.nombreNota3DataTextBox.Value = "=Fields.NombreNota3"
        '
        'anioActualNota3DataTextBox
        '
        Me.anioActualNota3DataTextBox.CanGrow = True
        Me.anioActualNota3DataTextBox.Format = "{0:N2}"
        Me.anioActualNota3DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002005100250244R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota3DataTextBox.Name = "anioActualNota3DataTextBox"
        Me.anioActualNota3DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota3DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota3DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota3DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota3DataTextBox.StyleName = "Data"
        Me.anioActualNota3DataTextBox.Value = "=Fields.AnioActualNota3"
        '
        'anioAnteriorNota3DataTextBox
        '
        Me.anioAnteriorNota3DataTextBox.CanGrow = True
        Me.anioAnteriorNota3DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota3DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0002005100250244R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota3DataTextBox.Name = "anioAnteriorNota3DataTextBox"
        Me.anioAnteriorNota3DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota3DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota3DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota3DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota3DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota3DataTextBox.Value = "=Fields.AnioAnteriorNota3"
        '
        'nombreNota4DataTextBox
        '
        Me.nombreNota4DataTextBox.CanGrow = True
        Me.nombreNota4DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5004009008407593R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota4DataTextBox.Name = "nombreNota4DataTextBox"
        Me.nombreNota4DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota4DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota4DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota4DataTextBox.StyleName = "Data"
        Me.nombreNota4DataTextBox.Value = "=Fields.NombreNota4"
        '
        'anioActualNota4DataTextBox
        '
        Me.anioActualNota4DataTextBox.CanGrow = True
        Me.anioActualNota4DataTextBox.Format = "{0:N2}"
        Me.anioActualNota4DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5004009008407593R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota4DataTextBox.Name = "anioActualNota4DataTextBox"
        Me.anioActualNota4DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota4DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota4DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota4DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota4DataTextBox.StyleName = "Data"
        Me.anioActualNota4DataTextBox.Value = "=Fields.AnioActualNota4"
        '
        'anioAnteriorNota4DataTextBox
        '
        Me.anioAnteriorNota4DataTextBox.CanGrow = True
        Me.anioAnteriorNota4DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota4DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5004009008407593R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota4DataTextBox.Name = "anioAnteriorNota4DataTextBox"
        Me.anioAnteriorNota4DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota4DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota4DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota4DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota4DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota4DataTextBox.Value = "=Fields.AnioAnteriorNota4"
        '
        'nombreNota5DataTextBox
        '
        Me.nombreNota5DataTextBox.CanGrow = True
        Me.nombreNota5DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0006012916564941R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota5DataTextBox.Name = "nombreNota5DataTextBox"
        Me.nombreNota5DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota5DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota5DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota5DataTextBox.StyleName = "Data"
        Me.nombreNota5DataTextBox.Value = "=Fields.NombreNota5"
        '
        'anioActualNota5DataTextBox
        '
        Me.anioActualNota5DataTextBox.CanGrow = True
        Me.anioActualNota5DataTextBox.Format = "{0:N2}"
        Me.anioActualNota5DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0006012916564941R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota5DataTextBox.Name = "anioActualNota5DataTextBox"
        Me.anioActualNota5DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota5DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota5DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota5DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota5DataTextBox.StyleName = "Data"
        Me.anioActualNota5DataTextBox.Value = "=Fields.AnioActualNota5"
        '
        'anioAnteriorNota5DataTextBox
        '
        Me.anioAnteriorNota5DataTextBox.CanGrow = True
        Me.anioAnteriorNota5DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota5DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0006012916564941R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota5DataTextBox.Name = "anioAnteriorNota5DataTextBox"
        Me.anioAnteriorNota5DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota5DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota5DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota5DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota5DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota5DataTextBox.Value = "=Fields.AnioAnteriorNota5"
        '
        'nombreNota6DataTextBox
        '
        Me.nombreNota6DataTextBox.CanGrow = True
        Me.nombreNota6DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5008018016815186R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota6DataTextBox.Name = "nombreNota6DataTextBox"
        Me.nombreNota6DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota6DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota6DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota6DataTextBox.StyleName = "Data"
        Me.nombreNota6DataTextBox.Value = "=Fields.NombreNota6"
        '
        'anioActualNota6DataTextBox
        '
        Me.anioActualNota6DataTextBox.CanGrow = True
        Me.anioActualNota6DataTextBox.Format = "{0:N2}"
        Me.anioActualNota6DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5008018016815186R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota6DataTextBox.Name = "anioActualNota6DataTextBox"
        Me.anioActualNota6DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota6DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota6DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota6DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota6DataTextBox.StyleName = "Data"
        Me.anioActualNota6DataTextBox.Value = "=Fields.AnioActualNota6"
        '
        'anioAnteriorNota6DataTextBox
        '
        Me.anioAnteriorNota6DataTextBox.CanGrow = True
        Me.anioAnteriorNota6DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota6DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5008018016815186R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota6DataTextBox.Name = "anioAnteriorNota6DataTextBox"
        Me.anioAnteriorNota6DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota6DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota6DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota6DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota6DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota6DataTextBox.Value = "=Fields.AnioAnteriorNota6"
        '
        'nombreNota7DataTextBox
        '
        Me.nombreNota7DataTextBox.CanGrow = True
        Me.nombreNota7DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0010020732879639R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota7DataTextBox.Name = "nombreNota7DataTextBox"
        Me.nombreNota7DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9998998641967773R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota7DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota7DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota7DataTextBox.StyleName = "Data"
        Me.nombreNota7DataTextBox.Value = "=Fields.NombreNota7"
        '
        'anioActualNota7DataTextBox
        '
        Me.anioActualNota7DataTextBox.CanGrow = True
        Me.anioActualNota7DataTextBox.Format = "{0:N2}"
        Me.anioActualNota7DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0010020732879639R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota7DataTextBox.Name = "anioActualNota7DataTextBox"
        Me.anioActualNota7DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota7DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota7DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota7DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota7DataTextBox.StyleName = "Data"
        Me.anioActualNota7DataTextBox.Value = "=Fields.AnioActualNota7"
        '
        'anioAnteriorNota7DataTextBox
        '
        Me.anioAnteriorNota7DataTextBox.CanGrow = True
        Me.anioAnteriorNota7DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota7DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0010020732879639R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota7DataTextBox.Name = "anioAnteriorNota7DataTextBox"
        Me.anioAnteriorNota7DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota7DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota7DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota7DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota7DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota7DataTextBox.Value = "=Fields.AnioAnteriorNota7"
        '
        'nombreNota8DataTextBox
        '
        Me.nombreNota8DataTextBox.CanGrow = True
        Me.nombreNota8DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.5012025833129883R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota8DataTextBox.Name = "nombreNota8DataTextBox"
        Me.nombreNota8DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9998998641967773R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota8DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota8DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota8DataTextBox.StyleName = "Data"
        Me.nombreNota8DataTextBox.Value = "=Fields.NombreNota8"
        '
        'anioActualNota8DataTextBox
        '
        Me.anioActualNota8DataTextBox.CanGrow = True
        Me.anioActualNota8DataTextBox.Format = "{0:N2}"
        Me.anioActualNota8DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.5012025833129883R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota8DataTextBox.Name = "anioActualNota8DataTextBox"
        Me.anioActualNota8DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota8DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota8DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota8DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota8DataTextBox.StyleName = "Data"
        Me.anioActualNota8DataTextBox.Value = "=Fields.AnioActualNota8"
        '
        'anioAnteriorNota8DataTextBox
        '
        Me.anioAnteriorNota8DataTextBox.CanGrow = True
        Me.anioAnteriorNota8DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota8DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.5012025833129883R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota8DataTextBox.Name = "anioAnteriorNota8DataTextBox"
        Me.anioAnteriorNota8DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota8DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota8DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota8DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota8DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota8DataTextBox.Value = "=Fields.AnioAnteriorNota8"
        '
        'nombreNota9DataTextBox
        '
        Me.nombreNota9DataTextBox.CanGrow = True
        Me.nombreNota9DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.0014028549194336R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota9DataTextBox.Name = "nombreNota9DataTextBox"
        Me.nombreNota9DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9998998641967773R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota9DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota9DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota9DataTextBox.StyleName = "Data"
        Me.nombreNota9DataTextBox.Value = "=Fields.NombreNota9"
        '
        'anioActualNota9DataTextBox
        '
        Me.anioActualNota9DataTextBox.CanGrow = True
        Me.anioActualNota9DataTextBox.Format = "{0:N2}"
        Me.anioActualNota9DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.0014028549194336R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota9DataTextBox.Name = "anioActualNota9DataTextBox"
        Me.anioActualNota9DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota9DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota9DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota9DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota9DataTextBox.StyleName = "Data"
        Me.anioActualNota9DataTextBox.Value = "=Fields.AnioActualNota9"
        '
        'anioAnteriorNota9DataTextBox
        '
        Me.anioAnteriorNota9DataTextBox.CanGrow = True
        Me.anioAnteriorNota9DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota9DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.0014028549194336R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota9DataTextBox.Name = "anioAnteriorNota9DataTextBox"
        Me.anioAnteriorNota9DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota9DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota9DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota9DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota9DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota9DataTextBox.Value = "=Fields.AnioAnteriorNota9"
        '
        'nombreNota10DataTextBox
        '
        Me.nombreNota10DataTextBox.CanGrow = True
        Me.nombreNota10DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.5016031265258789R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota10DataTextBox.Name = "nombreNota10DataTextBox"
        Me.nombreNota10DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota10DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota10DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota10DataTextBox.StyleName = "Data"
        Me.nombreNota10DataTextBox.Value = "=Fields.NombreNota10"
        '
        'anioActualNota10DataTextBox
        '
        Me.anioActualNota10DataTextBox.CanGrow = True
        Me.anioActualNota10DataTextBox.Format = "{0:N2}"
        Me.anioActualNota10DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.5016031265258789R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota10DataTextBox.Name = "anioActualNota10DataTextBox"
        Me.anioActualNota10DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota10DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota10DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota10DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota10DataTextBox.StyleName = "Data"
        Me.anioActualNota10DataTextBox.Value = "=Fields.AnioActualNota10"
        '
        'anioAnteriorNota10DataTextBox
        '
        Me.anioAnteriorNota10DataTextBox.CanGrow = True
        Me.anioAnteriorNota10DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota10DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.5016031265258789R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota10DataTextBox.Name = "anioAnteriorNota10DataTextBox"
        Me.anioAnteriorNota10DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota10DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota10DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota10DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota10DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota10DataTextBox.Value = "=Fields.AnioAnteriorNota10"
        '
        'nombreNota11DataTextBox
        '
        Me.nombreNota11DataTextBox.CanGrow = True
        Me.nombreNota11DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota11DataTextBox.Name = "nombreNota11DataTextBox"
        Me.nombreNota11DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0001001358032227R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota11DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota11DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota11DataTextBox.StyleName = "Data"
        Me.nombreNota11DataTextBox.Value = "=Fields.NombreNota11"
        '
        'anioActualNota11DataTextBox
        '
        Me.anioActualNota11DataTextBox.CanGrow = True
        Me.anioActualNota11DataTextBox.Format = "{0:N2}"
        Me.anioActualNota11DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0045442581176758R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota11DataTextBox.Name = "anioActualNota11DataTextBox"
        Me.anioActualNota11DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota11DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota11DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota11DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota11DataTextBox.StyleName = "Data"
        Me.anioActualNota11DataTextBox.Value = "=Fields.AnioActualNota11"
        '
        'anioAnteriorNota11DataTextBox
        '
        Me.anioAnteriorNota11DataTextBox.CanGrow = True
        Me.anioAnteriorNota11DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota11DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.518758773803711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota11DataTextBox.Name = "anioAnteriorNota11DataTextBox"
        Me.anioAnteriorNota11DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota11DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota11DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota11DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota11DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota11DataTextBox.Value = "=Fields.AnioAnteriorNota11"
        '
        'nombreNota12DataTextBox
        '
        Me.nombreNota12DataTextBox.CanGrow = True
        Me.nombreNota12DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.9999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota12DataTextBox.Name = "nombreNota12DataTextBox"
        Me.nombreNota12DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9998998641967773R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota12DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota12DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota12DataTextBox.StyleName = "Data"
        Me.nombreNota12DataTextBox.Value = "=Fields.NombreNota12"
        '
        'anioActualNota12DataTextBox
        '
        Me.anioActualNota12DataTextBox.CanGrow = True
        Me.anioActualNota12DataTextBox.Format = "{0:N2}"
        Me.anioActualNota12DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0045442581176758R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.9999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota12DataTextBox.Name = "anioActualNota12DataTextBox"
        Me.anioActualNota12DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota12DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota12DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota12DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota12DataTextBox.StyleName = "Data"
        Me.anioActualNota12DataTextBox.Value = "=Fields.AnioActualNota12"
        '
        'anioAnteriorNota12DataTextBox
        '
        Me.anioAnteriorNota12DataTextBox.CanGrow = True
        Me.anioAnteriorNota12DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota12DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.518758773803711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.9999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota12DataTextBox.Name = "anioAnteriorNota12DataTextBox"
        Me.anioAnteriorNota12DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota12DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota12DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota12DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota12DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota12DataTextBox.Value = "=Fields.AnioAnteriorNota12"
        '
        'nombreNota13DataTextBox
        '
        Me.nombreNota13DataTextBox.CanGrow = True
        Me.nombreNota13DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.2000001668930054R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota13DataTextBox.Name = "nombreNota13DataTextBox"
        Me.nombreNota13DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota13DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota13DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota13DataTextBox.StyleName = "Data"
        Me.nombreNota13DataTextBox.Value = "=Fields.NombreNota13"
        '
        'anioActualNota13DataTextBox
        '
        Me.anioActualNota13DataTextBox.CanGrow = True
        Me.anioActualNota13DataTextBox.Format = "{0:N2}"
        Me.anioActualNota13DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.2000001668930054R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota13DataTextBox.Name = "anioActualNota13DataTextBox"
        Me.anioActualNota13DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota13DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota13DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota13DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota13DataTextBox.StyleName = "Data"
        Me.anioActualNota13DataTextBox.Value = "=Fields.AnioActualNota13"
        '
        'anioAnteriorNota13DataTextBox
        '
        Me.anioAnteriorNota13DataTextBox.CanGrow = True
        Me.anioAnteriorNota13DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota13DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.2000001668930054R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota13DataTextBox.Name = "anioAnteriorNota13DataTextBox"
        Me.anioAnteriorNota13DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota13DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota13DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota13DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota13DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota13DataTextBox.Value = "=Fields.AnioAnteriorNota13"
        '
        'nombreNota14DataTextBox
        '
        Me.nombreNota14DataTextBox.CanGrow = True
        Me.nombreNota14DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.7002005577087402R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota14DataTextBox.Name = "nombreNota14DataTextBox"
        Me.nombreNota14DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota14DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota14DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota14DataTextBox.StyleName = "Data"
        Me.nombreNota14DataTextBox.Value = "=Fields.NombreNota14"
        '
        'anioActualNota14DataTextBox
        '
        Me.anioActualNota14DataTextBox.CanGrow = True
        Me.anioActualNota14DataTextBox.Format = "{0:N2}"
        Me.anioActualNota14DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.7002005577087402R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota14DataTextBox.Name = "anioActualNota14DataTextBox"
        Me.anioActualNota14DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota14DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota14DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota14DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota14DataTextBox.StyleName = "Data"
        Me.anioActualNota14DataTextBox.Value = "=Fields.AnioActualNota14"
        '
        'anioAnteriorNota14DataTextBox
        '
        Me.anioAnteriorNota14DataTextBox.CanGrow = True
        Me.anioAnteriorNota14DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota14DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.7002005577087402R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota14DataTextBox.Name = "anioAnteriorNota14DataTextBox"
        Me.anioAnteriorNota14DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota14DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota14DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota14DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota14DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota14DataTextBox.Value = "=Fields.AnioAnteriorNota14"
        '
        'nombreNota15DataTextBox
        '
        Me.nombreNota15DataTextBox.CanGrow = True
        Me.nombreNota15DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.2004010677337646R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota15DataTextBox.Name = "nombreNota15DataTextBox"
        Me.nombreNota15DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota15DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota15DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota15DataTextBox.StyleName = "Data"
        Me.nombreNota15DataTextBox.Value = "=Fields.NombreNota15"
        '
        'anioActualNota15DataTextBox
        '
        Me.anioActualNota15DataTextBox.CanGrow = True
        Me.anioActualNota15DataTextBox.Format = "{0:N2}"
        Me.anioActualNota15DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.2004010677337646R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota15DataTextBox.Name = "anioActualNota15DataTextBox"
        Me.anioActualNota15DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota15DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota15DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota15DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota15DataTextBox.StyleName = "Data"
        Me.anioActualNota15DataTextBox.Value = "=Fields.AnioActualNota15"
        '
        'anioAnteriorNota15DataTextBox
        '
        Me.anioAnteriorNota15DataTextBox.CanGrow = True
        Me.anioAnteriorNota15DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota15DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.2004010677337646R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota15DataTextBox.Name = "anioAnteriorNota15DataTextBox"
        Me.anioAnteriorNota15DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota15DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota15DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota15DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota15DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota15DataTextBox.Value = "=Fields.AnioAnteriorNota15"
        '
        'nombreNota16DataTextBox
        '
        Me.nombreNota16DataTextBox.CanGrow = True
        Me.nombreNota16DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.70060133934021R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota16DataTextBox.Name = "nombreNota16DataTextBox"
        Me.nombreNota16DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota16DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota16DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota16DataTextBox.StyleName = "Data"
        Me.nombreNota16DataTextBox.Value = "=Fields.NombreNota16"
        '
        'anioActualNota16DataTextBox
        '
        Me.anioActualNota16DataTextBox.CanGrow = True
        Me.anioActualNota16DataTextBox.Format = "{0:N2}"
        Me.anioActualNota16DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.70060133934021R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota16DataTextBox.Name = "anioActualNota16DataTextBox"
        Me.anioActualNota16DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota16DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota16DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota16DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota16DataTextBox.StyleName = "Data"
        Me.anioActualNota16DataTextBox.Value = "=Fields.AnioActualNota16"
        '
        'anioAnteriorNota16DataTextBox
        '
        Me.anioAnteriorNota16DataTextBox.CanGrow = True
        Me.anioAnteriorNota16DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota16DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.70060133934021R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota16DataTextBox.Name = "anioAnteriorNota16DataTextBox"
        Me.anioAnteriorNota16DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota16DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota16DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota16DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota16DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota16DataTextBox.Value = "=Fields.AnioAnteriorNota16"
        '
        'nombreNota17DataTextBox
        '
        Me.nombreNota17DataTextBox.CanGrow = True
        Me.nombreNota17DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota17DataTextBox.Name = "nombreNota17DataTextBox"
        Me.nombreNota17DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota17DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota17DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota17DataTextBox.StyleName = "Data"
        Me.nombreNota17DataTextBox.Value = "=Fields.NombreNota17"
        '
        'anioActualNota17DataTextBox
        '
        Me.anioActualNota17DataTextBox.CanGrow = True
        Me.anioActualNota17DataTextBox.Format = "{0:N2}"
        Me.anioActualNota17DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota17DataTextBox.Name = "anioActualNota17DataTextBox"
        Me.anioActualNota17DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota17DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota17DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota17DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota17DataTextBox.StyleName = "Data"
        Me.anioActualNota17DataTextBox.Value = "=Fields.AnioActualNota17"
        '
        'anioAnteriorNota17DataTextBox
        '
        Me.anioAnteriorNota17DataTextBox.CanGrow = True
        Me.anioAnteriorNota17DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota17DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota17DataTextBox.Name = "anioAnteriorNota17DataTextBox"
        Me.anioAnteriorNota17DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota17DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota17DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota17DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota17DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota17DataTextBox.Value = "=Fields.AnioAnteriorNota17"
        '
        'nombreNota18DataTextBox
        '
        Me.nombreNota18DataTextBox.CanGrow = True
        Me.nombreNota18DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota18DataTextBox.Name = "nombreNota18DataTextBox"
        Me.nombreNota18DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota18DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota18DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota18DataTextBox.StyleName = "Data"
        Me.nombreNota18DataTextBox.Value = "=Fields.NombreNota18"
        '
        'anioActualNota18DataTextBox
        '
        Me.anioActualNota18DataTextBox.CanGrow = True
        Me.anioActualNota18DataTextBox.Format = "{0:N2}"
        Me.anioActualNota18DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota18DataTextBox.Name = "anioActualNota18DataTextBox"
        Me.anioActualNota18DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota18DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota18DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota18DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota18DataTextBox.StyleName = "Data"
        Me.anioActualNota18DataTextBox.Value = "=Fields.AnioActualNota18"
        '
        'anioAnteriorNota18DataTextBox
        '
        Me.anioAnteriorNota18DataTextBox.CanGrow = True
        Me.anioAnteriorNota18DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota18DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000204086303711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota18DataTextBox.Name = "anioAnteriorNota18DataTextBox"
        Me.anioAnteriorNota18DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota18DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota18DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota18DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota18DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota18DataTextBox.Value = "=Fields.AnioAnteriorNota18"
        '
        'nombreNota19DataTextBox
        '
        Me.nombreNota19DataTextBox.CanGrow = True
        Me.nombreNota19DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(11.500199317932129R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota19DataTextBox.Name = "nombreNota19DataTextBox"
        Me.nombreNota19DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9999980926513672R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.nombreNota19DataTextBox.Style.Font.Name = "Arial"
        Me.nombreNota19DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.nombreNota19DataTextBox.StyleName = "Data"
        Me.nombreNota19DataTextBox.Value = "=Fields.NombreNota19"
        '
        'anioActualNota19DataTextBox
        '
        Me.anioActualNota19DataTextBox.CanGrow = True
        Me.anioActualNota19DataTextBox.Format = "{0:N2}"
        Me.anioActualNota19DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(11.500199317932129R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota19DataTextBox.Name = "anioActualNota19DataTextBox"
        Me.anioActualNota19DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioActualNota19DataTextBox.Style.Font.Name = "Arial"
        Me.anioActualNota19DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioActualNota19DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioActualNota19DataTextBox.StyleName = "Data"
        Me.anioActualNota19DataTextBox.Value = "=Fields.AnioActualNota19"
        '
        'anioAnteriorNota19DataTextBox
        '
        Me.anioAnteriorNota19DataTextBox.CanGrow = True
        Me.anioAnteriorNota19DataTextBox.Format = "{0:N2}"
        Me.anioAnteriorNota19DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000204086303711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(11.500199317932129R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota19DataTextBox.Name = "anioAnteriorNota19DataTextBox"
        Me.anioAnteriorNota19DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.anioAnteriorNota19DataTextBox.Style.Font.Name = "Arial"
        Me.anioAnteriorNota19DataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.anioAnteriorNota19DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.anioAnteriorNota19DataTextBox.StyleName = "Data"
        Me.anioAnteriorNota19DataTextBox.Value = "=Fields.AnioAnteriorNota19"
        '
        'TextBox48
        '
        Me.TextBox48.CanGrow = True
        Me.TextBox48.Format = "{0:N2}"
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox48.Style.Font.Bold = True
        Me.TextBox48.Style.Font.Name = "Arial"
        Me.TextBox48.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox48.StyleName = "Caption"
        Me.TextBox48.Value = "ACTIVO"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "= 'Año '+Fields.AnioAnterior"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "='Año '+ Fields.Anio"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.499998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "='Año '+ Fields.Anio"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "= 'Año '+Fields.AnioAnterior"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Format = "{0:N2}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "PASIVO"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:N2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "ACTIVO CORRIENTE:"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Format = "{0:N2}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "PASIVO CORRIENTE:"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Format = "{0:N2}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "TOTAL ACTIVO CORRIENTE"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Format = "{0:N2}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.5000009536743164R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "TOTAL PASIVO CORRIENTE"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Format = "{0:N2}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.518758773803711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.5000014305114746R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = resources.GetString("TextBox14.Value")
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Format = "{0:N2}"
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0045442581176758R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.5000014305114746R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "=Fields.AnioActualNota3+ Fields.AnioActualNota4+ Fields.AnioActualNota5+ Fields.A" & _
            "nioActualNota6+ Fields.AnioActualNota7+ Fields.AnioActualNota8+ Fields.AnioActua" & _
            "lNota9+ Fields.AnioActualNota10"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Format = "{0:N2}"
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(6.5000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox16.StyleName = "Caption"
        Me.TextBox16.Value = "ACTIVO NO CORRIENTE:"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(8.9995975494384766R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.Font.Bold = True
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "=Fields.AnioActualNota11+ Fields.AnioActualNota12+ Fields.AnioActualNota20"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Format = "{0:N2}"
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.500000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(8.9995975494384766R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "=Fields.AnioAnteriorNota11+ Fields.AnioAnteriorNota12+ Fields.AnioAnteriorNota20"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Format = "{0:N2}"
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(8.9995975494384766R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "TOTAL ACTIVO NO CORRIENTE"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Format = "{0:N2}"
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.5000009536743164R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox20.StyleName = "Data"
        Me.TextBox20.Value = "=Fields.AnioAnteriorNota13+ Fields.AnioAnteriorNota14+ Fields.AnioAnteriorNota15+" & _
            " Fields.AnioAnteriorNota16"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Format = "{0:N2}"
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.5000009536743164R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "=Fields.AnioActualNota13+ Fields.AnioActualNota14+ Fields.AnioActualNota15+ Field" & _
            "s.AnioActualNota16"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Format = "{0:N2}"
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(9.9995975494384766R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.StyleName = "Caption"
        Me.TextBox22.Value = "PATRIMONIO NETO:"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Format = "{0:N2}"
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.000399589538574R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Style.Font.Bold = True
        Me.TextBox23.Style.Font.Name = "Arial"
        Me.TextBox23.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.StyleName = "Caption"
        Me.TextBox23.Value = "TOTAL PATRIMONIO"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Format = "{0:N2}"
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000204086303711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.000399589538574R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Style.Font.Bold = True
        Me.TextBox24.Style.Font.Name = "Arial"
        Me.TextBox24.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "=Fields.AnioAnteriorNota17+ Fields.AnioAnteriorNota18+ Fields.AnioAnteriorNota19"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Format = "{0:N2}"
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.50019645690918R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.000399589538574R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Style.Font.Bold = True
        Me.TextBox25.Style.Font.Name = "Arial"
        Me.TextBox25.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox25.StyleName = "Data"
        Me.TextBox25.Value = "=Fields.AnioActualNota17+ Fields.AnioActualNota18+ Fields.AnioActualNota19"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Format = "{0:N2}"
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.999598503112793R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Name = "Arial"
        Me.TextBox26.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.StyleName = "Caption"
        Me.TextBox26.Value = "TOTAL ACTIVO"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Format = "{0:N2}"
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.999598503112793R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Style.Font.Bold = True
        Me.TextBox27.Style.Font.Name = "Arial"
        Me.TextBox27.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.StyleName = "Caption"
        Me.TextBox27.Value = "TOTAL PASIVO Y PATRIMONIO"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0045442581176758R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.999598503112793R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Style.Font.Bold = True
        Me.TextBox28.Style.Font.Name = "Arial"
        Me.TextBox28.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = resources.GetString("TextBox28.Value")
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Format = "{0:N2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.518758773803711R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.999598503112793R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Style.Font.Bold = True
        Me.TextBox29.Style.Font.Name = "Arial"
        Me.TextBox29.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = resources.GetString("TextBox29.Value")
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Format = "{0:N2}"
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(23.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.999598503112793R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Style.Font.Bold = True
        Me.TextBox30.Style.Font.Name = "Arial"
        Me.TextBox30.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox30.StyleName = "Data"
        Me.TextBox30.Value = "=Fields.AnioActualNota13+ Fields.AnioActualNota14+ Fields.AnioActualNota15+ Field" & _
            "s.AnioActualNota16+ Fields.AnioActualNota17+ Fields.AnioActualNota18+ Fields.Ani" & _
            "oActualNota19"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Format = "{0:N2}"
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(26.000404357910156R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.999598503112793R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Style.Font.Bold = True
        Me.TextBox31.Style.Font.Name = "Arial"
        Me.TextBox31.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox31.StyleName = "Data"
        Me.TextBox31.Value = "=Fields.AnioAnteriorNota13+ Fields.AnioAnteriorNota14+ Fields.AnioAnteriorNota15+" & _
            " Fields.AnioAnteriorNota16+ Fields.AnioAnteriorNota17+ Fields.AnioAnteriorNota18" & _
            "+ Fields.AnioAnteriorNota19"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Format = "{0:N2}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0000003576278687R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox32.Style.Font.Name = "Arial"
        Me.TextBox32.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.StyleName = "Data"
        Me.TextBox32.Value = "(Nota 3)"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Format = "{0:N2}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox33.Style.Font.Name = "Arial"
        Me.TextBox33.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.StyleName = "Data"
        Me.TextBox33.Value = "(Nota 4)"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Format = "{0:N2}"
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0004010200500488R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox34.Style.Font.Name = "Arial"
        Me.TextBox34.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.StyleName = "Data"
        Me.TextBox34.Value = "(Nota 5)"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Format = "{0:N2}"
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.00029993057251R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5008025169372559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox35.Style.Font.Name = "Arial"
        Me.TextBox35.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.StyleName = "Data"
        Me.TextBox35.Value = "(Nota 6)"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Format = "{0:N2}"
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.00029993057251R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0010030269622803R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox36.Style.Font.Name = "Arial"
        Me.TextBox36.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.StyleName = "Data"
        Me.TextBox36.Value = "(Nota 7)"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = True
        Me.TextBox37.Format = "{0:N2}"
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.5012032985687256R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox37.Style.Font.Name = "Arial"
        Me.TextBox37.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.StyleName = "Data"
        Me.TextBox37.Value = "(Nota 8)"
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Format = "{0:N2}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.00029993057251R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.0014028549194336R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox38.StyleName = "Data"
        Me.TextBox38.Value = "(Nota 9)"
        '
        'TextBox39
        '
        Me.TextBox39.CanGrow = True
        Me.TextBox39.Format = "{0:N2}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.00029993057251R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.5016031265258789R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox39.StyleName = "Data"
        Me.TextBox39.Value = "(Nota 10)"
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = True
        Me.TextBox40.Format = "{0:N2}"
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.2000001668930054R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox40.Style.Font.Name = "Arial"
        Me.TextBox40.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox40.StyleName = "Data"
        Me.TextBox40.Value = "(Nota 14)"
        '
        'TextBox41
        '
        Me.TextBox41.CanGrow = True
        Me.TextBox41.Format = "{0:N2}"
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.7002005577087402R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox41.Style.Font.Name = "Arial"
        Me.TextBox41.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.StyleName = "Data"
        Me.TextBox41.Value = "(Nota 15)"
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = True
        Me.TextBox42.Format = "{0:N2}"
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.2004010677337646R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox42.Style.Font.Name = "Arial"
        Me.TextBox42.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox42.StyleName = "Data"
        Me.TextBox42.Value = "(Nota 16)"
        '
        'TextBox43
        '
        Me.TextBox43.CanGrow = True
        Me.TextBox43.Format = "{0:N2}"
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.70060133934021R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox43.Style.Font.Name = "Arial"
        Me.TextBox43.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox43.StyleName = "Data"
        Me.TextBox43.Value = "(Nota 17)"
        '
        'TextBox44
        '
        Me.TextBox44.CanGrow = True
        Me.TextBox44.Format = "{0:N2}"
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.0002007484436035R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox44.Style.Font.Name = "Arial"
        Me.TextBox44.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox44.StyleName = "Data"
        Me.TextBox44.Value = "(Nota 11)"
        '
        'TextBox45
        '
        Me.TextBox45.CanGrow = True
        Me.TextBox45.Format = "{0:N2}"
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.00029993057251R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.9999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox45.Style.Font.Name = "Arial"
        Me.TextBox45.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox45.StyleName = "Data"
        Me.TextBox45.Value = "(Nota 13)"
        '
        'TextBox46
        '
        Me.TextBox46.CanGrow = True
        Me.TextBox46.Format = "{0:N2}"
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.499797821044922R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox46.Style.Font.Name = "Arial"
        Me.TextBox46.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox46.StyleName = "Data"
        Me.TextBox46.Value = "(Nota 18)"
        '
        'TextBox47
        '
        Me.TextBox47.CanGrow = True
        Me.TextBox47.Format = "{0:N2}"
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(10.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox47.Style.Font.Name = "Arial"
        Me.TextBox47.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox47.StyleName = "Data"
        Me.TextBox47.Value = "(Nota 19)"
        '
        'TextBox49
        '
        Me.TextBox49.CanGrow = True
        Me.TextBox49.Format = "{0:N2}"
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(21.500198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(11.500199317932129R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox49.Style.Font.Name = "Arial"
        Me.TextBox49.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox49.StyleName = "Data"
        Me.TextBox49.Value = "(Nota 20)"
        '
        'TextBox50
        '
        Me.TextBox50.CanGrow = True
        Me.TextBox50.Format = "{0:N2}"
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.5000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0041437149047852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox50.Style.Font.Name = "Arial"
        Me.TextBox50.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox50.StyleName = "Data"
        Me.TextBox50.Value = "(Nota 12)"
        '
        'TextBox51
        '
        Me.TextBox51.CanGrow = True
        Me.TextBox51.Format = "{0:N2}"
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.524364471435547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.5000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox51.Style.Font.Name = "Arial"
        Me.TextBox51.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox51.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox51.StyleName = "Data"
        Me.TextBox51.Value = "=Fields.AnioAnteriorNota20"
        '
        'TextBox52
        '
        Me.TextBox52.CanGrow = True
        Me.TextBox52.Format = "{0:N2}"
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.0108318328857422R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.5000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox52.Style.Font.Name = "Arial"
        Me.TextBox52.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox52.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox52.StyleName = "Data"
        Me.TextBox52.Value = "=Fields.AnioActualNota20"
        '
        'TextBox53
        '
        Me.TextBox53.CanGrow = True
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(7.5000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6.9998998641967773R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox53.Style.Font.Name = "Arial"
        Me.TextBox53.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox53.StyleName = "Data"
        Me.TextBox53.Value = "= Fields.NombreNota20"
        '
        'RepBalanceGeneral
        '
        Me.DataSource = Me.SDSRepBalanceGeneral
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.60000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.60000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "fechaFin"
        ReportParameter1.Text = "fechaFin"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        ReportParameter2.Name = "idProyecto"
        ReportParameter2.Text = "idProyecto"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter2.Visible = True
        ReportParameter3.Name = "tipo"
        ReportParameter3.Text = "tipo"
        ReportParameter3.Visible = True
        ReportParameter4.Name = "proyecto"
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(28.500404357910156R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepBalanceGeneral As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents nombreNota3DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota3DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota3DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota4DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota4DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota4DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota5DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota5DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota5DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota6DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota6DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota6DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota7DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota7DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota7DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota8DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota8DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota8DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota9DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota9DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota9DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota10DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota10DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota10DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota11DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota11DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota11DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota12DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota12DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota12DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota13DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota13DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota13DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota14DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota14DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota14DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota15DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota15DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota15DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota16DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota16DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota16DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota17DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota17DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota17DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota18DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota18DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota18DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreNota19DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioActualNota19DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents anioAnteriorNota19DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
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
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox52 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
End Class