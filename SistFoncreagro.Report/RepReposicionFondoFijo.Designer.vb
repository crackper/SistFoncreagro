Partial Class RepReposicionFondoFijo

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SDSRepFondoFijoPendiente = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.dinerofondotxt = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.totalrendicionestxt = New Telerik.Reporting.TextBox()
        Me.recibosPendientesDataTextBox = New Telerik.Reporting.TextBox()
        Me.recibosPendientesCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.montoCajaGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.montoCajaDataTextBox = New Telerik.Reporting.TextBox()
        Me.montoCajaCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.montoCajaGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.montoRendidoDataTextBox = New Telerik.Reporting.TextBox()
        Me.proyectoDataTextBox = New Telerik.Reporting.TextBox()
        Me.montoCajaGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SDSRepFondoFijoPendiente
        '
        Me.SDSRepFondoFijoPendiente.ConnectionString = "cnx"
        Me.SDSRepFondoFijoPendiente.Name = "SDSRepFondoFijoPendiente"
        Me.SDSRepFondoFijoPendiente.SelectCommand = "dbo.RepRendicionFondoFijoPendientes"
        Me.SDSRepFondoFijoPendiente.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm)
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
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:C2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000199317932129R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9952082633972168R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000007152557373R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "= Sum(Fields.MontoRendido)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00030036925454623997R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(3.9952082633972168R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "FONDO A REPONER:"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00030036925454623997R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.9633333683013916R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "TOTAL FONDO FIJO:"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Format = "{0:C2}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000199317932129R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.9633333683013916R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000007152557373R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "= Sum(Fields.MontoRendido)+ Fields.RecibosPendientes + (Fields.MontoCaja - (Sum(F" & _
            "ields.MontoRendido)+ Fields.RecibosPendientes))"
        '
        'dinerofondotxt
        '
        Me.dinerofondotxt.CanGrow = True
        Me.dinerofondotxt.Format = "{0:C2}"
        Me.dinerofondotxt.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.984375R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.dinerofondotxt.Name = "dinerofondotxt"
        Me.dinerofondotxt.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000030994415283R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.dinerofondotxt.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.dinerofondotxt.Style.Font.Bold = True
        Me.dinerofondotxt.Style.Font.Name = "Arial"
        Me.dinerofondotxt.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.dinerofondotxt.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.dinerofondotxt.StyleName = "Data"
        Me.dinerofondotxt.Value = "= Fields.MontoCaja - (Sum(Fields.MontoRendido)+ Fields.RecibosPendientes)"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00030036925454623997R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.984375R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "DINERO EN EFECTIVO:"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00030036925454623997R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.97895830869674683R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "TOTAL RECIBOS PROVISIONALES PENDIENTE POR RENDIR:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'totalrendicionestxt
        '
        Me.totalrendicionestxt.Format = "{0:C2}"
        Me.totalrendicionestxt.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalrendicionestxt.Name = "totalrendicionestxt"
        Me.totalrendicionestxt.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000021457672119R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50000017881393433R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.totalrendicionestxt.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.totalrendicionestxt.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.totalrendicionestxt.Style.Font.Bold = True
        Me.totalrendicionestxt.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.totalrendicionestxt.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.totalrendicionestxt.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.totalrendicionestxt.Value = "= Sum(Fields.MontoRendido)"
        '
        'recibosPendientesDataTextBox
        '
        Me.recibosPendientesDataTextBox.CanGrow = True
        Me.recibosPendientesDataTextBox.Format = "{0:C2}"
        Me.recibosPendientesDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.000198364257813R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.97895830869674683R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.recibosPendientesDataTextBox.Name = "recibosPendientesDataTextBox"
        Me.recibosPendientesDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000030994415283R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.recibosPendientesDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.recibosPendientesDataTextBox.Style.Font.Bold = True
        Me.recibosPendientesDataTextBox.Style.Font.Name = "Arial"
        Me.recibosPendientesDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.recibosPendientesDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.recibosPendientesDataTextBox.StyleName = "Data"
        Me.recibosPendientesDataTextBox.Value = "=Fields.RecibosPendientes"
        '
        'recibosPendientesCaptionTextBox
        '
        Me.recibosPendientesCaptionTextBox.CanGrow = True
        Me.recibosPendientesCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00030036925454623997R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.recibosPendientesCaptionTextBox.Name = "recibosPendientesCaptionTextBox"
        Me.recibosPendientesCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.recibosPendientesCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.recibosPendientesCaptionTextBox.Style.Font.Bold = True
        Me.recibosPendientesCaptionTextBox.Style.Font.Name = "Arial"
        Me.recibosPendientesCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.recibosPendientesCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.recibosPendientesCaptionTextBox.StyleName = "Caption"
        Me.recibosPendientesCaptionTextBox.Value = "TOTAL RENDICIONES:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'montoCajaGroupHeader
        '
        Me.montoCajaGroupHeader.Height = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.montoCajaGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.montoCajaDataTextBox, Me.montoCajaCaptionTextBox})
        Me.montoCajaGroupHeader.Name = "montoCajaGroupHeader"
        '
        'montoCajaDataTextBox
        '
        Me.montoCajaDataTextBox.CanGrow = True
        Me.montoCajaDataTextBox.Format = "{0:C2}"
        Me.montoCajaDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(14.026658058166504R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoCajaDataTextBox.Name = "montoCajaDataTextBox"
        Me.montoCajaDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9733427762985229R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoCajaDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.montoCajaDataTextBox.Style.Font.Bold = True
        Me.montoCajaDataTextBox.Style.Font.Name = "Arial"
        Me.montoCajaDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoCajaDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoCajaDataTextBox.StyleName = "Data"
        Me.montoCajaDataTextBox.Value = "=Fields.MontoCaja"
        '
        'montoCajaCaptionTextBox
        '
        Me.montoCajaCaptionTextBox.CanGrow = True
        Me.montoCajaCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00030036925454623997R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoCajaCaptionTextBox.Name = "montoCajaCaptionTextBox"
        Me.montoCajaCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(13.999698638916016R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoCajaCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.montoCajaCaptionTextBox.Style.Font.Bold = True
        Me.montoCajaCaptionTextBox.Style.Font.Name = "Arial"
        Me.montoCajaCaptionTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoCajaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.montoCajaCaptionTextBox.StyleName = "Caption"
        Me.montoCajaCaptionTextBox.Value = "MONTO CAJA CHICA:"
        '
        'montoCajaGroupFooter
        '
        Me.montoCajaGroupFooter.Height = New Telerik.Reporting.Drawing.Unit(4.9998989105224609R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.montoCajaGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.recibosPendientesCaptionTextBox, Me.totalrendicionestxt, Me.recibosPendientesDataTextBox, Me.TextBox8, Me.TextBox2, Me.dinerofondotxt, Me.TextBox5, Me.TextBox6, Me.TextBox4, Me.TextBox7})
        Me.montoCajaGroupFooter.Name = "montoCajaGroupFooter"
        '
        'montoRendidoDataTextBox
        '
        Me.montoRendidoDataTextBox.CanGrow = True
        Me.montoRendidoDataTextBox.Format = "{0:C2}"
        Me.montoRendidoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoRendidoDataTextBox.Name = "montoRendidoDataTextBox"
        Me.montoRendidoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0000007152557373R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.montoRendidoDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.montoRendidoDataTextBox.Style.Font.Bold = False
        Me.montoRendidoDataTextBox.Style.Font.Name = "Arial"
        Me.montoRendidoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.montoRendidoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.montoRendidoDataTextBox.StyleName = "Data"
        Me.montoRendidoDataTextBox.Value = "=Fields.MontoRendido"
        '
        'proyectoDataTextBox
        '
        Me.proyectoDataTextBox.CanGrow = True
        Me.proyectoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Name = "proyectoDataTextBox"
        Me.proyectoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(14.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.proyectoDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.proyectoDataTextBox.Style.Font.Name = "Arial"
        Me.proyectoDataTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.proyectoDataTextBox.StyleName = "Data"
        Me.proyectoDataTextBox.Value = "=""RENDICIÓN DE FONDO DE CAJA CHICA "" + Fields.Proyecto"
        '
        'montoCajaGroup
        '
        Me.montoCajaGroup.GroupFooter = Me.montoCajaGroupFooter
        Me.montoCajaGroup.GroupHeader = Me.montoCajaGroupHeader
        Me.montoCajaGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.MontoCaja")})
        Me.montoCajaGroup.Name = "montoCajaGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = False
        '
        'pageHeader
        '
        Me.pageHeader.Height = New Telerik.Reporting.Drawing.Unit(3.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox14, Me.TextBox13, Me.TextBox12, Me.TextBox3, Me.TextBox38, Me.TextBox39, Me.TextBox15, Me.TextBox16, Me.TextBox29, Me.titleTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox14
        '
        Me.TextBox14.Format = "{0:g}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.000099921220680698752R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.StyleName = "PageInfo"
        Me.TextBox14.Value = "=PageNumber"
        '
        'TextBox13
        '
        Me.TextBox13.Format = "{0:d}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox13.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.StyleName = "PageInfo"
        Me.TextBox13.Value = "Página:"
        '
        'TextBox12
        '
        Me.TextBox12.Format = "{0:d}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox12.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.StyleName = "PageInfo"
        Me.TextBox12.Value = "Fecha:"
        '
        'TextBox3
        '
        Me.TextBox3.Format = "{0:d}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.StyleName = "PageInfo"
        Me.TextBox3.Value = "= Now()"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:t}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.999999046325684R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "PageInfo"
        Me.TextBox38.Value = "= Now()"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0:d}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(4.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox39.Style.Font.Name = "Arial"
        Me.TextBox39.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(6.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox39.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "PageInfo"
        Me.TextBox39.Value = "Hora:"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.9997997283935547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox15.StyleName = "PageInfo"
        Me.TextBox15.Value = "Jr. Ciro Alegría N° 296 - Cajamarca"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.9997997283935547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox16.StyleName = "PageInfo"
        Me.TextBox16.Value = "RUC: 20453262767"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(9.9997997283935547R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox29.Style.Font.Bold = True
        Me.TextBox29.Style.Font.Name = "Arial"
        Me.TextBox29.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox29.StyleName = "PageInfo"
        Me.TextBox29.Value = "FONCREAGRO"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.50000017881393433R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.titleTextBox.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(10.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "=""REPOSICION DE FONDO FIJO AL "" + Format(""{0:d}"", Now())"
        '
        'pageFooter
        '
        Me.pageFooter.Height = New Telerik.Reporting.Drawing.Unit(2.5000019073486328R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox17, Me.TextBox18})
        Me.pageFooter.Name = "pageFooter"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.30000004172325134R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5000020265579224R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.7000000476837158R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox11.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Solicitado Por Responsable de Fondo Fijo"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.1262507438659668R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5000020265579224R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.69928240776062R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "Autorizado Por Jefe de Administración"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(12.100000381469727R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5000020265579224R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(3.4999995231628418R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.Value = "Recibido Por Contabilidad"
        '
        'reportHeader
        '
        Me.reportHeader.Height = New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.reportHeader.Name = "reportHeader"
        Me.reportHeader.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0.50010013580322266R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.proyectoDataTextBox, Me.montoRendidoDataTextBox})
        Me.detail.Name = "detail"
        '
        'Report1
        '
        Me.DataSource = Me.SDSRepFondoFijoPendiente
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup, Me.montoCajaGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.montoCajaGroupHeader, Me.montoCajaGroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(2.5399999618530273R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(2.5399999618530273R, Telerik.Reporting.Drawing.UnitType.Cm)
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
        Me.Width = New Telerik.Reporting.Drawing.Unit(16.000001907348633R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SDSRepFondoFijoPendiente As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents montoCajaGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents montoCajaGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents montoCajaGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoCajaDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoCajaCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents montoRendidoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents proyectoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents dinerofondotxt As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents totalrendicionestxt As Telerik.Reporting.TextBox
    Friend WithEvents recibosPendientesDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents recibosPendientesCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
End Class