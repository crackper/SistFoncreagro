Partial Class ReportOrdenCompraProducto
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportOrdenCompraProducto))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.DSOrdenCompraProducto = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
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
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.descripcionGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.descripcionGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.descripcionGroup = New Telerik.Reporting.Group()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.numeroOrdenCompraCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DSOrdenCompraProducto
        '
        Me.DSOrdenCompraProducto.ConnectionString = "cnx"
        Me.DSOrdenCompraProducto.Name = "DSOrdenCompraProducto"
        Me.DSOrdenCompraProducto.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@IdOrdenCompra", System.Data.DbType.Int32, "=Parameters.ParametroIdOrdenCompra.Value")})
        Me.DSOrdenCompraProducto.SelectCommand = "dbo.ReportOrdenCompraProducto"
        Me.DSOrdenCompraProducto.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox21, Me.TextBox33, Me.TextBox35, Me.TextBox34, Me.TextBox36, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(2.4002001285552979R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.100000381469727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Value = "= Fields.RazonSocial"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.4000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Value = "PROVEEDOR :"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.1000000238418579R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Value = "RUC :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.29813289642334R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.0999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Value = "FORMA DE PAGO :"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.1001999378204346R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(10.197732925415039R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Value = "= Fields.Ruc"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.398332595825195R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Value = "= Fields.TipoPago"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Value = "DIRECCIÓN :"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(2.2002003192901611R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.0977325439453125R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Value = "= Fields.Direccion"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5003000497817993R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.999699592590332R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Descripción"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999961256980896R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "Cantidad"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Precio Unit."
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.299999237060547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "Total"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.298131942749023R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox28.Style.Font.Bold = True
        Me.TextBox28.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox28.Value = "CONTACTO :"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.498332977294922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox29.Value = "= Fields.Contacto"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5002002716064453R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.7999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox30.Style.Font.Bold = True
        Me.TextBox30.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox30.Value = "MONEDA :"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.8002998828887939R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.4976310729980469R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox31.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox31.Value = "= Fields.NombreMoneda"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0004010200500488R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox21.Value = "E-MAIL :"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5003000497817993R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.79763126373291R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox33.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox33.Value = "= Fields.Mail"
        '
        'TextBox35
        '
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.498332977294922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0004010200500488R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox35.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox35.Value = "= Fields.Telefono1"
        '
        'TextBox34
        '
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.298131942749023R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox34.Style.Font.Bold = True
        Me.TextBox34.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox34.Value = "TELÉFONO :"
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999961256980896R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox36.Style.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TextBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox36.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox36.Style.Font.Bold = True
        Me.TextBox36.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox36.Value = "Unidad"
        '
        'TextBox39
        '
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5006015300750732R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Bold = True
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Value = "ÁREA :"
        '
        'TextBox40
        '
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.3001997470855713R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.199800491333008R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox40.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox40.Value = "= Fields.AreaProyecto"
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox41.Style.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.Font.Bold = True
        Me.TextBox41.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.Value = "C. Costo"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(11.298134803771973R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.7766647338867187R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox43.Style.Font.Bold = True
        Me.TextBox43.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox43.Value = "TIPO O/C :"
        '
        'TextBox44
        '
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.07499885559082R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49979948997497559R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.4292535781860352R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox44.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox44.Value = "PRODUCTO"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.9000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox45.Style.Font.Bold = True
        Me.TextBox45.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox45.Value = "APROBADO POR:"
        '
        'TextBox46
        '
        Me.TextBox46.Format = ""
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(2.9001998901367187R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0008018016815186R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(15.598133087158203R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox46.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox46.Value = "= Fields.AprobadoPor +' (Fecha: ' + format('{0:d}',Fields.FechaAprobacion) +')'"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = False
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'descripcionGroupHeader
        '
        Me.descripcionGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.descripcionGroupHeader.Name = "descripcionGroupHeader"
        '
        'descripcionGroupFooter
        '
        Me.descripcionGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.descripcionGroupFooter.Name = "descripcionGroupFooter"
        '
        'descripcionGroup
        '
        Me.descripcionGroup.GroupFooter = Me.descripcionGroupFooter
        Me.descripcionGroup.GroupHeader = Me.descripcionGroupHeader
        Me.descripcionGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Descripcion")})
        Me.descripcionGroup.Name = "descripcionGroup"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(0.10000000149011612R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Name = "pageFooter"
        '
        'numeroOrdenCompraCaptionTextBox
        '
        Me.numeroOrdenCompraCaptionTextBox.CanGrow = True
        Me.numeroOrdenCompraCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.numeroOrdenCompraCaptionTextBox.Name = "numeroOrdenCompraCaptionTextBox"
        Me.numeroOrdenCompraCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.60000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.numeroOrdenCompraCaptionTextBox.Style.Font.Bold = True
        Me.numeroOrdenCompraCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.numeroOrdenCompraCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.numeroOrdenCompraCaptionTextBox.StyleName = "Caption"
        Me.numeroOrdenCompraCaptionTextBox.Value = "ORDEN DE COMPRA N° {Fields.NumeroOrdenCompra}"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox20, Me.TextBox19, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox32})
        Me.reportFooter.Name = "reportFooter"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.004053115844727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "Sub Total {= Fields.Siglas}"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.004053115844727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50020039081573486R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "IGV ({= Fields.IgvPor}%)"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.004053115844727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0004007816314697R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "Total {= Fields.Siglas}"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.304252624511719R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00039887745515443385R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox23.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox23.Style.Font.Bold = False
        Me.TextBox23.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "= Fields.SubTotal"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.298332214355469R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50059926509857178R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox24.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox24.Style.Font.Bold = False
        Me.TextBox24.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "= Fields.Igv"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.298332214355469R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0007996559143066R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox25.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox25.Style.Font.Bold = False
        Me.TextBox25.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "= Fields.TotalGeneral"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "FACTURACIÓN Y ENTREGA DE BIENES"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.7999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.Font.Bold = False
        Me.TextBox27.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "= Fields.TextoOc"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(18.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.Font.Bold = True
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "= Fields.Nota"
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox17, Me.TextBox18, Me.TextBox1, Me.TextBox37, Me.TextBox42})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.003851890563965R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00019881072512362152R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999961256980896R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.Font.Bold = False
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "= Fields.CantidadSolicitada"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.298332214355469R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00019881072512362152R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox17.Style.Font.Bold = False
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "= Fields.Total"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.5003000497817993R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00019881072512362152R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(8.999699592590332R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.Font.Bold = False
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.Value = "= Fields.Descripcion"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.004053115844727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00019863128545694053R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.2999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.Font.Bold = False
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(9.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.PrecioCompra"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.500200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999961256980896R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox37.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox37.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox37.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox37.Style.Font.Bold = False
        Me.TextBox37.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.Value = "= Fields.Abreviacion"
        '
        'TextBox42
        '
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox42.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox42.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox42.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox42.Style.Font.Bold = False
        Me.TextBox42.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.5R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox42.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox42.Value = "= Fields.CentroCosto"
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(3.2000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.numeroOrdenCompraCaptionTextBox, Me.TextBox2, Me.TextBox3, Me.PictureBox1, Me.TextBox38, Me.TextBox47})
        Me.reportHeader.Name = "reportHeader"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.1000000238418579R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(18.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.40000000596046448R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "RUC: 20453262767"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.5300173759460449R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.40000000596046448R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.MimeType = "image/jpeg"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.PictureBox1.Style.BackgroundImage.MimeType = ""
        Me.PictureBox1.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.RepeatY
        Me.PictureBox1.Style.LineWidth = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.PictureBox1.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PictureBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Format = "{0:d}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.81312370300293R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.4999998807907104R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.7000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.40000000596046448R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox38.StyleName = "Caption"
        Me.TextBox38.Value = "= Fields.FechaProbableEntrega"
        '
        'TextBox47
        '
        Me.TextBox47.CanGrow = True
        Me.TextBox47.Format = ""
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(5.53021764755249R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5001999139785767R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(11.282705307006836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.40000000596046448R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox47.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox47.StyleName = "Caption"
        Me.TextBox47.Value = "Fecha probable de entrega:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ReportOrdenCompraProducto
        '
        Me.DataSource = Me.DSOrdenCompraProducto
        Me.Filters.AddRange(New Telerik.Reporting.Filter() {New Telerik.Reporting.Filter("=Fields.IdOrdenCompra", Telerik.Reporting.FilterOperator.Equal, "= Parameters.ParametroIdOrdenCompra.Value")})
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.descripcionGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.descripcionGroupHeader, Me.descripcionGroupFooter, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "ParametroIdOrdenCompra"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(18.51312255859375R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents DSOrdenCompraProducto As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents descripcionGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents descripcionGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents descripcionGroup As Telerik.Reporting.Group
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents numeroOrdenCompraCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
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
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
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
    Public WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
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
End Class