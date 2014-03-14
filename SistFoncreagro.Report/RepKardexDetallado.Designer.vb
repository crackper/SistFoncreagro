Partial Class RepKardexDetallado
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepKardexDetallado))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepkardexDetallado = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.numeroOrdenCompraCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fechaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.unidadCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.cantidadCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.productoGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.productoDataTextBox = New Telerik.Reporting.TextBox()
        Me.productoGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.cantidadSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.productoGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.numeroOrdenCompraDataTextBox = New Telerik.Reporting.TextBox()
        Me.fechaDataTextBox = New Telerik.Reporting.TextBox()
        Me.unidadDataTextBox = New Telerik.Reporting.TextBox()
        Me.cantidadDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TipoGroup = New Telerik.Reporting.Group()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepkardexDetallado
        '
        Me.SDSRepkardexDetallado.ConnectionString = "cnx"
        Me.SDSRepkardexDetallado.Name = "SDSRepkardexDetallado"
        Me.SDSRepkardexDetallado.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@idProyecto", System.Data.DbType.Int32, "=Parameters.idProyecto.Value")})
        Me.SDSRepkardexDetallado.SelectCommand = "dbo.GetKardexProyectoDetallado"
        Me.SDSRepkardexDetallado.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.numeroOrdenCompraCaptionTextBox, Me.fechaCaptionTextBox, Me.unidadCaptionTextBox, Me.cantidadCaptionTextBox, Me.TextBox11, Me.TextBox10})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PageBreak = Telerik.Reporting.PageBreak.None
        Me.labelsGroupHeader.PrintOnEveryPage = True
        Me.labelsGroupHeader.Style.Visible = True
        '
        'numeroOrdenCompraCaptionTextBox
        '
        Me.numeroOrdenCompraCaptionTextBox.CanGrow = True
        Me.numeroOrdenCompraCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.numeroOrdenCompraCaptionTextBox.Name = "numeroOrdenCompraCaptionTextBox"
        Me.numeroOrdenCompraCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5002050399780273R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.numeroOrdenCompraCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.numeroOrdenCompraCaptionTextBox.Style.Font.Bold = True
        Me.numeroOrdenCompraCaptionTextBox.Style.Font.Name = "Arial"
        Me.numeroOrdenCompraCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.numeroOrdenCompraCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.numeroOrdenCompraCaptionTextBox.StyleName = "Caption"
        Me.numeroOrdenCompraCaptionTextBox.Value = "Nº DOCUMENTO"
        '
        'fechaCaptionTextBox
        '
        Me.fechaCaptionTextBox.CanGrow = True
        Me.fechaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.499991416931152R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaCaptionTextBox.Name = "fechaCaptionTextBox"
        Me.fechaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaCaptionTextBox.Style.Font.Bold = True
        Me.fechaCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaCaptionTextBox.StyleName = "Caption"
        Me.fechaCaptionTextBox.Value = "FECHA"
        '
        'unidadCaptionTextBox
        '
        Me.unidadCaptionTextBox.CanGrow = True
        Me.unidadCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.499990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.unidadCaptionTextBox.Name = "unidadCaptionTextBox"
        Me.unidadCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.unidadCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.unidadCaptionTextBox.Style.Font.Bold = True
        Me.unidadCaptionTextBox.Style.Font.Name = "Arial"
        Me.unidadCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.unidadCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.unidadCaptionTextBox.StyleName = "Caption"
        Me.unidadCaptionTextBox.Value = "UNID."
        '
        'cantidadCaptionTextBox
        '
        Me.cantidadCaptionTextBox.CanGrow = True
        Me.cantidadCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499991416931152R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cantidadCaptionTextBox.Name = "cantidadCaptionTextBox"
        Me.cantidadCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cantidadCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cantidadCaptionTextBox.Style.Font.Bold = True
        Me.cantidadCaptionTextBox.Style.Font.Name = "Arial"
        Me.cantidadCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cantidadCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cantidadCaptionTextBox.StyleName = "Caption"
        Me.cantidadCaptionTextBox.Value = "CANTIDAD"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.4996998310089111R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "PRODUCTO"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(5.0004053115844727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.4993910789489746R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "CASERIO"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.71437495946884155R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = False
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'productoGroupHeader
        '
        Me.productoGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.productoGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.productoDataTextBox})
        Me.productoGroupHeader.Name = "productoGroupHeader"
        Me.productoGroupHeader.PageBreak = Telerik.Reporting.PageBreak.None
        Me.productoGroupHeader.PrintOnEveryPage = True
        '
        'productoDataTextBox
        '
        Me.productoDataTextBox.CanGrow = True
        Me.productoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.productoDataTextBox.Name = "productoDataTextBox"
        Me.productoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(14.999899864196777R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.productoDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.productoDataTextBox.Style.Font.Bold = True
        Me.productoDataTextBox.Style.Font.Name = "Arial"
        Me.productoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.productoDataTextBox.Style.Font.Underline = True
        Me.productoDataTextBox.StyleName = "Data"
        Me.productoDataTextBox.Value = "=Fields.Producto"
        '
        'productoGroupFooter
        '
        Me.productoGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.699999988079071R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.productoGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.cantidadSumFunctionTextBox})
        Me.productoGroupFooter.Name = "productoGroupFooter"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(14.499689102172852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "SALDO ALMACEN"
        '
        'cantidadSumFunctionTextBox
        '
        Me.cantidadSumFunctionTextBox.CanGrow = True
        Me.cantidadSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cantidadSumFunctionTextBox.Name = "cantidadSumFunctionTextBox"
        Me.cantidadSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cantidadSumFunctionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cantidadSumFunctionTextBox.Style.Font.Bold = True
        Me.cantidadSumFunctionTextBox.Style.Font.Name = "Arial"
        Me.cantidadSumFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cantidadSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cantidadSumFunctionTextBox.StyleName = "Data"
        Me.cantidadSumFunctionTextBox.Value = "= Sum(Fields.Cantidad)"
        '
        'productoGroup
        '
        Me.productoGroup.GroupFooter = Me.productoGroupFooter
        Me.productoGroup.GroupHeader = Me.productoGroupHeader
        Me.productoGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Producto")})
        Me.productoGroup.Name = "productoGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.71437495946884155R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = False
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(1.6999999284744263R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.PictureBox1, Me.TextBox9, Me.TextBox6, Me.TextBox7, Me.TextBox8})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(14.999797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "INGRESOS Y SALIDAS DE PRODUCTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.MimeType = "image/jpeg"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0002050399780273R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.PictureBox1.Style.BackgroundImage.MimeType = ""
        Me.PictureBox1.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.RepeatY
        Me.PictureBox1.Style.LineWidth = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.PictureBox1.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PictureBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499991416931152R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9997979402542114R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "=Now()"
        '
        'TextBox6
        '
        Me.TextBox6.Format = "{0:g}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.499991416931152R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9997979402542114R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "= PageNumber + ' de ' + PageCount"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:g}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.503454208374023R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9967490434646606R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.StyleName = "PageInfo"
        Me.TextBox7.Value = "Pagina: "
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.503454208374023R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9967490434646606R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Fecha: "
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.71437495946884155R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        Me.pageFooter.Style.Visible = False
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Name = "reportHeader"
        Me.reportHeader.Style.Visible = True
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.numeroOrdenCompraDataTextBox, Me.fechaDataTextBox, Me.unidadDataTextBox, Me.cantidadDataTextBox, Me.TextBox12})
        Me.detail.Name = "detail"
        '
        'numeroOrdenCompraDataTextBox
        '
        Me.numeroOrdenCompraDataTextBox.CanGrow = True
        Me.numeroOrdenCompraDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.numeroOrdenCompraDataTextBox.Name = "numeroOrdenCompraDataTextBox"
        Me.numeroOrdenCompraDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5002050399780273R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.numeroOrdenCompraDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.numeroOrdenCompraDataTextBox.Style.Font.Name = "Arial"
        Me.numeroOrdenCompraDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.numeroOrdenCompraDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.numeroOrdenCompraDataTextBox.StyleName = "Data"
        Me.numeroOrdenCompraDataTextBox.Value = "=Fields.NumeroOrdenCompra"
        '
        'fechaDataTextBox
        '
        Me.fechaDataTextBox.CanGrow = True
        Me.fechaDataTextBox.Format = "{0:d}"
        Me.fechaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.499997138977051R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDataTextBox.Name = "fechaDataTextBox"
        Me.fechaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaDataTextBox.Style.Font.Name = "Arial"
        Me.fechaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaDataTextBox.StyleName = "Data"
        Me.fechaDataTextBox.Value = "=Fields.Fecha"
        '
        'unidadDataTextBox
        '
        Me.unidadDataTextBox.CanGrow = True
        Me.unidadDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.500202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.unidadDataTextBox.Name = "unidadDataTextBox"
        Me.unidadDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.unidadDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.unidadDataTextBox.Style.Font.Name = "Arial"
        Me.unidadDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.unidadDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.unidadDataTextBox.StyleName = "Data"
        Me.unidadDataTextBox.Value = "=Fields.Unidad"
        '
        'cantidadDataTextBox
        '
        Me.cantidadDataTextBox.CanGrow = True
        Me.cantidadDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cantidadDataTextBox.Name = "cantidadDataTextBox"
        Me.cantidadDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.cantidadDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.cantidadDataTextBox.Style.Font.Name = "Arial"
        Me.cantidadDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.cantidadDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.cantidadDataTextBox.StyleName = "Data"
        Me.cantidadDataTextBox.Value = "= IIf(Fields.Cantidad<0, Fields.Cantidad*-1, Fields.Cantidad)"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(5.0004053115844727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.4993910789489746R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.Font.Bold = False
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "= IsNull(Fields.Caserio,'-')"
        '
        'TipoGroup
        '
        Me.TipoGroup.GroupFooter = Me.GroupFooterSection1
        Me.TipoGroup.GroupHeader = Me.GroupHeaderSection1
        Me.TipoGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Tipo")})
        Me.TipoGroup.Name = "TipoGroup"
        '
        'GroupFooterSection1
        '
        Me.GroupFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0.699999988079071R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox5})
        Me.GroupFooterSection1.Name = "GroupFooterSection1"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= IIf(Sum(Fields.Cantidad)<0,Sum(Fields.Cantidad)*-1,Sum(Fields.Cantidad))"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(14.499689102172852R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "=""TOTAL ""+ Fields.Tipo"
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3})
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0002050399780273R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Italic = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.Font.Underline = False
        Me.TextBox3.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.30000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "= Fields.Tipo"
        '
        'RepKardexDetallado
        '
        Me.DataSource = Me.SDSRepkardexDetallado
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.productoGroup, Me.TipoGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.productoGroupHeader, Me.productoGroupFooter, Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "idProyecto"
        ReportParameter1.Text = "idProyecto"
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(16.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepkardexDetallado As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents numeroOrdenCompraCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents unidadCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cantidadCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents productoGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents productoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents productoGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents cantidadSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents productoGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents numeroOrdenCompraDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents unidadDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents cantidadDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TipoGroup As Telerik.Reporting.Group
    Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Public WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
End Class