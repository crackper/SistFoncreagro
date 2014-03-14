Partial Class RepRetencionesCuarta
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepRetencionesCuarta))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDSRepRetencionesCuarta = New Telerik.Reporting.SqlDataSource()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Group2 = New Telerik.Reporting.Group()
        Me.GroupFooterSection2 = New Telerik.Reporting.GroupFooterSection()
        Me.GroupHeaderSection2 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDSRepRetencionesCuarta
        '
        Me.SqlDSRepRetencionesCuarta.ConnectionString = "cnx"
        Me.SqlDSRepRetencionesCuarta.Name = "SqlDSRepRetencionesCuarta"
        Me.SqlDSRepRetencionesCuarta.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@fechaInicio", System.Data.DbType.DateTime, "=Parameters.FechaInicio.Value"), New Telerik.Reporting.SqlDataSourceParameter("@fechaFin", System.Data.DbType.DateTime, "=Parameters.FechaFin.Value"), New Telerik.Reporting.SqlDataSourceParameter("@moneda", System.Data.DbType.Int32, "=Parameters.moneda.Value"), New Telerik.Reporting.SqlDataSourceParameter("@idProveedorCliente", System.Data.DbType.Int32, "=Parameters.idProveedorCliente.Value")})
        Me.SqlDSRepRetencionesCuarta.SelectCommand = "dbo.RepRetencionesCuarta"
        Me.SqlDSRepRetencionesCuarta.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(17.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(13.000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm))
        '
        'TextBox1
        '
        Me.TextBox1.CanShrink = False
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.599999725818634R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Value = resources.GetString("TextBox1.Value")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.60000008344650269R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Value = "=""EJERCICIO GRAVABLE ""+ Format('{0:yyyy}',Parameters.FechaInicio.Value)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.599999725818634R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Value = "CERTIFICA:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.599999725818634R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.TextWrap = True
        Me.TextBox4.Value = resources.GetString("TextBox4.Value")
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox5.Value = "=""Total Periodo ""+ Format('{0:yyyy}', Parameters.FechaInicio.Value)+"": S/. """
        '
        'TextBox6
        '
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.Value = "=Sum(Fields.BaseImponible)"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Value = "=Sum(Fields.MontoRetencion)"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Value = "IMPUESTO RETENIDO"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox9.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Value = "IMPORTE BRUTO"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox10.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Value = "RENTAS"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(6.2000002861022949R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999897003173828R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.60000050067901611R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Value = "=""Cajamarca,""+ CStr(Format('{0:dd}',now()))+"" de ""+CStr(Format('{0:MMMM}',now()))" & _
            "+"" de ""+CStr(Format('{0:yyyy}',now()))"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(11.799798965454102R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.9999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.60000050067901611R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "CARLOS ENRIQUE MERCADO LEZAMA"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(12.399999618530273R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999797821044922R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.599999725818634R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Value = "Director Ejecutivo"
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Name = "detail"
        '
        'Group2
        '
        Me.Group2.GroupFooter = Me.GroupFooterSection2
        Me.Group2.GroupHeader = Me.GroupHeaderSection2
        Me.Group2.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Ruc")})
        Me.Group2.Name = "Group2"
        '
        'GroupFooterSection2
        '
        Me.GroupFooterSection2.Height = New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupFooterSection2.Name = "GroupFooterSection2"
        Me.GroupFooterSection2.Style.Visible = False
        '
        'GroupHeaderSection2
        '
        Me.GroupHeaderSection2.Height = New Telerik.Reporting.Drawing.Unit(19.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.GroupHeaderSection2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1, Me.TextBox14, Me.TextBox15, Me.PictureBox1, Me.TextBox17, Me.TextBox16})
        Me.GroupHeaderSection2.Name = "GroupHeaderSection2"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.60000008344650269R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Value = "CERTIFICADO DE RENTAS Y RETENCIONES POR RENTAS DE CUARTA CATEGORÍA"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.0002009868621826R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(4.6002001762390137R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.60000008344650269R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Value = "(Art. 45 D.S. N° 192.94-EF DEL 21/09/1994) (R.S. N° 010-2006/SUNAT DEL 13/01/2006" & _
            ")"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
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
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.0002009868621826R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0001999139785767R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.40000000596046448R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.StyleName = "Caption"
        Me.TextBox17.Value = "RUC: 20453262767"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(1.0002009868621826R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.4000000953674316R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.40000000596046448R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox16.StyleName = "Caption"
        Me.TextBox16.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'RepRetencionesCuarta
        '
        Me.DataSource = Me.SqlDSRepRetencionesCuarta
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection2, Me.GroupFooterSection2, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "FechaInicio"
        ReportParameter1.Text = "FechaInicio"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        ReportParameter2.Name = "FechaFin"
        ReportParameter2.Text = "FechaFin"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Visible = True
        ReportParameter3.Name = "idProveedorCliente"
        ReportParameter3.Text = "idProveedorCliente"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter3.Visible = True
        ReportParameter4.Name = "moneda"
        ReportParameter4.Text = "moneda"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter4.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Outset
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(19.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDSRepRetencionesCuarta As Telerik.Reporting.SqlDataSource
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents Group2 As Telerik.Reporting.Group
    Friend WithEvents GroupFooterSection2 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents GroupHeaderSection2 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
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
    Public WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
End Class