Partial Class RepBienesMuebles
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepBienesMuebles = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.catalogoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.codigoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fechaIngresoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.costoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.codigoReferenciaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.conservacionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.estadoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.responsableCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.codClasificacionGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.codClasificacionDataTextBox = New Telerik.Reporting.TextBox()
        Me.codClasificacionGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.codigoCountFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.codClasificacionGroup = New Telerik.Reporting.Group()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.codigoDataTextBox = New Telerik.Reporting.TextBox()
        Me.catalogoDataTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fechaIngresoDataTextBox = New Telerik.Reporting.TextBox()
        Me.costoDataTextBox = New Telerik.Reporting.TextBox()
        Me.descripcionDataTextBox = New Telerik.Reporting.TextBox()
        Me.codigoReferenciaDataTextBox = New Telerik.Reporting.TextBox()
        Me.conservacionDataTextBox = New Telerik.Reporting.TextBox()
        Me.estadoDataTextBox = New Telerik.Reporting.TextBox()
        Me.responsableDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepBienesMuebles
        '
        Me.SDSRepBienesMuebles.ConnectionString = "cnx"
        Me.SDSRepBienesMuebles.Name = "SDSRepBienesMuebles"
        Me.SDSRepBienesMuebles.SelectCommand = "dbo.RepBienesMuebles"
        Me.SDSRepBienesMuebles.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.catalogoCaptionTextBox, Me.codigoCaptionTextBox, Me.proyectoCaptionTextBox, Me.fechaIngresoCaptionTextBox, Me.costoCaptionTextBox, Me.descripcionCaptionTextBox, Me.codigoReferenciaCaptionTextBox, Me.conservacionCaptionTextBox, Me.estadoCaptionTextBox, Me.responsableCaptionTextBox, Me.TextBox1})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        Me.labelsGroupHeader.Style.Visible = True
        '
        'catalogoCaptionTextBox
        '
        Me.catalogoCaptionTextBox.CanGrow = True
        Me.catalogoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.catalogoCaptionTextBox.Name = "catalogoCaptionTextBox"
        Me.catalogoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.9995999336242676R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.catalogoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.catalogoCaptionTextBox.Style.Font.Name = "Arial"
        Me.catalogoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.catalogoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.catalogoCaptionTextBox.StyleName = "Caption"
        Me.catalogoCaptionTextBox.Value = "CATÁLOGO"
        '
        'codigoCaptionTextBox
        '
        Me.codigoCaptionTextBox.CanGrow = True
        Me.codigoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Name = "codigoCaptionTextBox"
        Me.codigoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.codigoCaptionTextBox.Style.Font.Name = "Arial"
        Me.codigoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoCaptionTextBox.StyleName = "Caption"
        Me.codigoCaptionTextBox.Value = "CÓDIGO"
        '
        'proyectoCaptionTextBox
        '
        Me.proyectoCaptionTextBox.CanGrow = True
        Me.proyectoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0000004768371582R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoCaptionTextBox.Name = "proyectoCaptionTextBox"
        Me.proyectoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.proyectoCaptionTextBox.Style.Font.Name = "Arial"
        Me.proyectoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.proyectoCaptionTextBox.StyleName = "Caption"
        Me.proyectoCaptionTextBox.Value = "ÁREA"
        '
        'fechaIngresoCaptionTextBox
        '
        Me.fechaIngresoCaptionTextBox.CanGrow = True
        Me.fechaIngresoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoCaptionTextBox.Name = "fechaIngresoCaptionTextBox"
        Me.fechaIngresoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fechaIngresoCaptionTextBox.Style.Font.Name = "Arial"
        Me.fechaIngresoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaIngresoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaIngresoCaptionTextBox.StyleName = "Caption"
        Me.fechaIngresoCaptionTextBox.Value = "FEC.COMPRA"
        '
        'costoCaptionTextBox
        '
        Me.costoCaptionTextBox.CanGrow = True
        Me.costoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoCaptionTextBox.Name = "costoCaptionTextBox"
        Me.costoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.costoCaptionTextBox.Style.Font.Name = "Arial"
        Me.costoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.costoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.costoCaptionTextBox.StyleName = "Caption"
        Me.costoCaptionTextBox.Value = "VALOR"
        '
        'descripcionCaptionTextBox
        '
        Me.descripcionCaptionTextBox.CanGrow = True
        Me.descripcionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Name = "descripcionCaptionTextBox"
        Me.descripcionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.descripcionCaptionTextBox.Style.Font.Name = "Arial"
        Me.descripcionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.descripcionCaptionTextBox.StyleName = "Caption"
        Me.descripcionCaptionTextBox.Value = "DESCRIPCIÓN"
        '
        'codigoReferenciaCaptionTextBox
        '
        Me.codigoReferenciaCaptionTextBox.CanGrow = True
        Me.codigoReferenciaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(15.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoReferenciaCaptionTextBox.Name = "codigoReferenciaCaptionTextBox"
        Me.codigoReferenciaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoReferenciaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.codigoReferenciaCaptionTextBox.Style.Font.Name = "Arial"
        Me.codigoReferenciaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoReferenciaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoReferenciaCaptionTextBox.StyleName = "Caption"
        Me.codigoReferenciaCaptionTextBox.Value = "COD. REF."
        '
        'conservacionCaptionTextBox
        '
        Me.conservacionCaptionTextBox.CanGrow = True
        Me.conservacionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.conservacionCaptionTextBox.Name = "conservacionCaptionTextBox"
        Me.conservacionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.500003457069397R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.conservacionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.conservacionCaptionTextBox.Style.Font.Name = "Arial"
        Me.conservacionCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.conservacionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.conservacionCaptionTextBox.StyleName = "Caption"
        Me.conservacionCaptionTextBox.Value = "CONSERVAC."
        '
        'estadoCaptionTextBox
        '
        Me.estadoCaptionTextBox.CanGrow = True
        Me.estadoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.estadoCaptionTextBox.Name = "estadoCaptionTextBox"
        Me.estadoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.estadoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.estadoCaptionTextBox.Style.Font.Name = "Arial"
        Me.estadoCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.estadoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.estadoCaptionTextBox.StyleName = "Caption"
        Me.estadoCaptionTextBox.Value = "ESTADO"
        '
        'responsableCaptionTextBox
        '
        Me.responsableCaptionTextBox.CanGrow = True
        Me.responsableCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.responsableCaptionTextBox.Name = "responsableCaptionTextBox"
        Me.responsableCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.responsableCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.responsableCaptionTextBox.Style.Font.Name = "Arial"
        Me.responsableCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.responsableCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.responsableCaptionTextBox.StyleName = "Caption"
        Me.responsableCaptionTextBox.Value = "RESPONSABLE"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.9997000694274902R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "UBICACIÓN"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = False
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'codClasificacionGroupHeader
        '
        Me.codClasificacionGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.50000035762786865R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codClasificacionGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codClasificacionDataTextBox})
        Me.codClasificacionGroupHeader.Name = "codClasificacionGroupHeader"
        '
        'codClasificacionDataTextBox
        '
        Me.codClasificacionDataTextBox.CanGrow = True
        Me.codClasificacionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codClasificacionDataTextBox.Name = "codClasificacionDataTextBox"
        Me.codClasificacionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(29.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codClasificacionDataTextBox.Style.Font.Bold = True
        Me.codClasificacionDataTextBox.Style.Font.Name = "Arial"
        Me.codClasificacionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codClasificacionDataTextBox.StyleName = "Data"
        Me.codClasificacionDataTextBox.Value = "=Fields.CodClasificacion+' '+ Fields.Clasificacion"
        '
        'codClasificacionGroupFooter
        '
        Me.codClasificacionGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codClasificacionGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.codigoCountFunctionTextBox})
        Me.codClasificacionGroupFooter.Name = "codClasificacionGroupFooter"
        Me.codClasificacionGroupFooter.Style.Visible = True
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.99970006942749R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.60000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "SUB TOTAL:"
        '
        'codigoCountFunctionTextBox
        '
        Me.codigoCountFunctionTextBox.CanGrow = True
        Me.codigoCountFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCountFunctionTextBox.Name = "codigoCountFunctionTextBox"
        Me.codigoCountFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.4999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoCountFunctionTextBox.Style.Font.Bold = True
        Me.codigoCountFunctionTextBox.Style.Font.Name = "Arial"
        Me.codigoCountFunctionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoCountFunctionTextBox.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.codigoCountFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.codigoCountFunctionTextBox.StyleName = "Data"
        Me.codigoCountFunctionTextBox.Value = "= CStr(Count(Fields.Codigo))+' Bien(es)'"
        '
        'codClasificacionGroup
        '
        Me.codClasificacionGroup.GroupFooter = Me.codClasificacionGroupFooter
        Me.codClasificacionGroup.GroupHeader = Me.codClasificacionGroupHeader
        Me.codClasificacionGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.CodClasificacion")})
        Me.codClasificacionGroup.Name = "codClasificacionGroup"
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.TextBox7, Me.TextBox6, Me.reportNameTextBox, Me.TextBox39, Me.TextBox38, Me.TextBox9, Me.TextBox8, Me.TextBox5, Me.TextBox10})
        Me.pageHeader.Name = "pageHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(28.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "RELACIÓN DE BIENES MUEBLES"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.StyleName = "PageInfo"
        Me.TextBox7.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
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
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(20.500001907348633R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.reportNameTextBox.Style.Font.Bold = True
        Me.reportNameTextBox.Style.Font.Name = "Arial"
        Me.reportNameTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "FONCREAGRO"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.500202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.49959659576416R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(3.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0122824907302856R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox9
        '
        Me.TextBox9.Format = "{0:d}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "PageInfo"
        Me.TextBox9.Value = "= Now()"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.500202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.49959659576416R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(3.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "PageInfo"
        Me.TextBox8.Value = "Fecha:"
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:d}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.500202178955078R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.49959659576416R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(3.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.StyleName = "PageInfo"
        Me.TextBox5.Value = "Página:"
        '
        'TextBox10
        '
        Me.TextBox10.Format = "{0:g}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "PageInfo"
        Me.TextBox10.Value = "=PageNumber+ ' de '+ PageCount"
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
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox11})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.4999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= CStr(Count(Fields.Codigo))+' Bien(es)'"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.99970006942749R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.60000002384185791R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "TOTAL:"
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.codigoDataTextBox, Me.catalogoDataTextBox, Me.proyectoDataTextBox, Me.fechaIngresoDataTextBox, Me.costoDataTextBox, Me.descripcionDataTextBox, Me.codigoReferenciaDataTextBox, Me.conservacionDataTextBox, Me.estadoDataTextBox, Me.responsableDataTextBox, Me.TextBox2})
        Me.detail.Name = "detail"
        '
        'codigoDataTextBox
        '
        Me.codigoDataTextBox.CanGrow = True
        Me.codigoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Name = "codigoDataTextBox"
        Me.codigoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoDataTextBox.Style.Font.Name = "Arial"
        Me.codigoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoDataTextBox.StyleName = "Data"
        Me.codigoDataTextBox.Value = "=Fields.Codigo"
        '
        'catalogoDataTextBox
        '
        Me.catalogoDataTextBox.CanGrow = True
        Me.catalogoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.catalogoDataTextBox.Name = "catalogoDataTextBox"
        Me.catalogoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.9995999336242676R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.catalogoDataTextBox.Style.Font.Name = "Arial"
        Me.catalogoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.catalogoDataTextBox.StyleName = "Data"
        Me.catalogoDataTextBox.Value = "=Fields.Catalogo"
        '
        'proyectoDataTextBox
        '
        Me.proyectoDataTextBox.CanGrow = True
        Me.proyectoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(5.9997992515563965R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Name = "proyectoDataTextBox"
        Me.proyectoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Style.Font.Name = "Arial"
        Me.proyectoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.proyectoDataTextBox.StyleName = "Data"
        Me.proyectoDataTextBox.Value = "=Fields.Proyecto"
        '
        'fechaIngresoDataTextBox
        '
        Me.fechaIngresoDataTextBox.CanGrow = True
        Me.fechaIngresoDataTextBox.Format = "{0:d}"
        Me.fechaIngresoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.9999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoDataTextBox.Name = "fechaIngresoDataTextBox"
        Me.fechaIngresoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.fechaIngresoDataTextBox.Style.Font.Name = "Arial"
        Me.fechaIngresoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.fechaIngresoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fechaIngresoDataTextBox.StyleName = "Data"
        Me.fechaIngresoDataTextBox.Value = "=Fields.FechaIngreso"
        '
        'costoDataTextBox
        '
        Me.costoDataTextBox.CanGrow = True
        Me.costoDataTextBox.Format = "{0:N2}"
        Me.costoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(8.4997997283935547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoDataTextBox.Name = "costoDataTextBox"
        Me.costoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.costoDataTextBox.Style.Font.Name = "Arial"
        Me.costoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.costoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.costoDataTextBox.StyleName = "Data"
        Me.costoDataTextBox.Value = "=Fields.Costo"
        '
        'descripcionDataTextBox
        '
        Me.descripcionDataTextBox.CanGrow = True
        Me.descripcionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(9.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Name = "descripcionDataTextBox"
        Me.descripcionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.4999990463256836R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.descripcionDataTextBox.Style.Font.Name = "Arial"
        Me.descripcionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.descripcionDataTextBox.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.descripcionDataTextBox.StyleName = "Data"
        Me.descripcionDataTextBox.Value = "=Fields.Descripcion"
        '
        'codigoReferenciaDataTextBox
        '
        Me.codigoReferenciaDataTextBox.CanGrow = True
        Me.codigoReferenciaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.999998092651367R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoReferenciaDataTextBox.Name = "codigoReferenciaDataTextBox"
        Me.codigoReferenciaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.codigoReferenciaDataTextBox.Style.Font.Name = "Arial"
        Me.codigoReferenciaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.codigoReferenciaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.codigoReferenciaDataTextBox.StyleName = "Data"
        Me.codigoReferenciaDataTextBox.Value = "=Fields.CodigoReferencia"
        '
        'conservacionDataTextBox
        '
        Me.conservacionDataTextBox.CanGrow = True
        Me.conservacionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(16.499996185302734R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.conservacionDataTextBox.Name = "conservacionDataTextBox"
        Me.conservacionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.500003457069397R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.conservacionDataTextBox.Style.Font.Name = "Arial"
        Me.conservacionDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.conservacionDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.conservacionDataTextBox.StyleName = "Data"
        Me.conservacionDataTextBox.Value = "=Fields.Conservacion"
        '
        'estadoDataTextBox
        '
        Me.estadoDataTextBox.CanGrow = True
        Me.estadoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(18.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.estadoDataTextBox.Name = "estadoDataTextBox"
        Me.estadoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.estadoDataTextBox.Style.Font.Name = "Arial"
        Me.estadoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.estadoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.estadoDataTextBox.StyleName = "Data"
        Me.estadoDataTextBox.Value = "=Fields.Estado"
        '
        'responsableDataTextBox
        '
        Me.responsableDataTextBox.CanGrow = True
        Me.responsableDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(20.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.responsableDataTextBox.Name = "responsableDataTextBox"
        Me.responsableDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.5R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.responsableDataTextBox.Style.Font.Name = "Arial"
        Me.responsableDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.responsableDataTextBox.StyleName = "Data"
        Me.responsableDataTextBox.Value = "=Fields.Responsable"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(25.000200271606445R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.9997007846832275R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(5.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.Oficina"
        '
        'RepBienesMuebles
        '
        Me.DataSource = Me.SDSRepBienesMuebles
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.codClasificacionGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.codClasificacionGroupHeader, Me.codClasificacionGroupFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(0.30000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(0.30000001192092896R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(29.100002288818359R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepBienesMuebles As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents codigoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents catalogoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaIngresoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents costoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codigoReferenciaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents conservacionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents estadoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents responsableCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents codClasificacionGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents codClasificacionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codClasificacionGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents codClasificacionGroup As Telerik.Reporting.Group
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents codigoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents catalogoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fechaIngresoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents costoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents descripcionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents codigoReferenciaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents conservacionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents estadoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents responsableDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents codigoCountFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
End Class