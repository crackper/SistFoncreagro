Partial Class RepNotasFlujoEfectivo
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.RepNota4FlujoEfectivo1 = New SistFoncreagro.Report.RepNota4FlujoEfectivo()
        Me.SubReport23 = New Telerik.Reporting.SubReport()
        Me.RepNota3FlujoEfectivo1 = New SistFoncreagro.Report.RepNota3FlujoEfectivo()
        Me.SubReport2 = New Telerik.Reporting.SubReport()
        Me.RepNota5FlujoEfectivo1 = New SistFoncreagro.Report.RepNota5FlujoEfectivo()
        Me.SubReport3 = New Telerik.Reporting.SubReport()
        Me.RepNota6FlujoEfectivo1 = New SistFoncreagro.Report.RepNota6FlujoEfectivo()
        Me.SubReport4 = New Telerik.Reporting.SubReport()
        Me.RepNota7FlujoEfectivo1 = New SistFoncreagro.Report.RepNota7FlujoEfectivo()
        Me.SubReport5 = New Telerik.Reporting.SubReport()
        Me.RepNota8FlujoEfectivo1 = New SistFoncreagro.Report.RepNota8FlujoEfectivo()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me.RepNota4FlujoEfectivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepNota3FlujoEfectivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepNota5FlujoEfectivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepNota6FlujoEfectivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepNota7FlujoEfectivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepNota8FlujoEfectivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox1, Me.TextBox4})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "(En Nuevos Soles)"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.49999994039535522R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "='AL '+ Format('{0:dd/MM/yyyy}',Parameters.fechaFin.Value)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(16.999900817871094R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8.0R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "NOTAS A LOS ESTADOS FINANCIEROS"
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(3.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.SubReport1, Me.SubReport23, Me.SubReport2, Me.SubReport3, Me.SubReport4, Me.SubReport5})
        Me.detail.Name = "detail"
        '
        'SubReport1
        '
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.4999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Parameters.Add(New Telerik.Reporting.Parameter("fechaFin", "=Parameters.fechaFin.Value"))
        Me.SubReport1.ReportSource = Me.RepNota4FlujoEfectivo1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        '
        'RepNota4FlujoEfectivo1
        '
        Me.RepNota4FlujoEfectivo1.Name = "RepNota4FlujoEfectivo1"
        '
        'SubReport23
        '
        Me.SubReport23.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.SubReport23.Name = "SubReport23"
        Me.SubReport23.Parameters.Add(New Telerik.Reporting.Parameter("fechaFin", "=Parameters.fechaFin.Value"))
        Me.SubReport23.ReportSource = Me.RepNota3FlujoEfectivo1
        Me.SubReport23.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        '
        'RepNota3FlujoEfectivo1
        '
        Me.RepNota3FlujoEfectivo1.Name = "RepNota3FlujoEfectivo1"
        '
        'SubReport2
        '
        Me.SubReport2.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.99999988079071045R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.SubReport2.Name = "SubReport2"
        Me.SubReport2.Parameters.Add(New Telerik.Reporting.Parameter("fechaFin", "=Parameters.fechaFin.Value"))
        Me.SubReport2.ReportSource = Me.RepNota5FlujoEfectivo1
        Me.SubReport2.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        '
        'RepNota5FlujoEfectivo1
        '
        Me.RepNota5FlujoEfectivo1.Name = "RepNota5FlujoEfectivo1"
        '
        'SubReport3
        '
        Me.SubReport3.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.SubReport3.Name = "SubReport3"
        Me.SubReport3.Parameters.Add(New Telerik.Reporting.Parameter("fechaFin", "=Parameters.fechaFin.Value"))
        Me.SubReport3.ReportSource = Me.RepNota6FlujoEfectivo1
        Me.SubReport3.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        '
        'RepNota6FlujoEfectivo1
        '
        Me.RepNota6FlujoEfectivo1.Name = "RepNota6FlujoEfectivo1"
        '
        'SubReport4
        '
        Me.SubReport4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.SubReport4.Name = "SubReport4"
        Me.SubReport4.Parameters.Add(New Telerik.Reporting.Parameter("fechaFin", "=Parameters.fechaFin.Value"))
        Me.SubReport4.ReportSource = Me.RepNota7FlujoEfectivo1
        Me.SubReport4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        '
        'RepNota7FlujoEfectivo1
        '
        Me.RepNota7FlujoEfectivo1.Name = "RepNota7FlujoEfectivo1"
        '
        'SubReport5
        '
        Me.SubReport5.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.SubReport5.Name = "SubReport5"
        Me.SubReport5.Parameters.Add(New Telerik.Reporting.Parameter("fechaFin", "=Parameters.fechaFin.Value"))
        Me.SubReport5.ReportSource = Me.RepNota8FlujoEfectivo1
        Me.SubReport5.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(1.9999997615814209R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm))
        '
        'RepNota8FlujoEfectivo1
        '
        Me.RepNota8FlujoEfectivo1.Name = "RepNota8FlujoEfectivo1"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0.5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = True
        '
        'RepNotasFlujoEfectivo
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(2.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(1.0R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "fechaFin"
        ReportParameter1.Text = "fechaFin"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Width = New Telerik.Reporting.Drawing.Unit(16.999900817871094R, Telerik.Reporting.Drawing.UnitType.Cm)
        CType(Me.RepNota4FlujoEfectivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepNota3FlujoEfectivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepNota5FlujoEfectivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepNota6FlujoEfectivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepNota7FlujoEfectivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepNota8FlujoEfectivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    Friend WithEvents RepNota5FlujoEfectivo1 As SistFoncreagro.Report.RepNota5FlujoEfectivo
    Friend WithEvents SubReport23 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport2 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport3 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport4 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport5 As Telerik.Reporting.SubReport
    Friend WithEvents RepNota4FlujoEfectivo1 As SistFoncreagro.Report.RepNota4FlujoEfectivo
    Friend WithEvents RepNota6FlujoEfectivo1 As SistFoncreagro.Report.RepNota6FlujoEfectivo
    Friend WithEvents RepNota7FlujoEfectivo1 As SistFoncreagro.Report.RepNota7FlujoEfectivo
    Friend WithEvents RepNota8FlujoEfectivo1 As SistFoncreagro.Report.RepNota8FlujoEfectivo
    Friend WithEvents RepNota3FlujoEfectivo1 As SistFoncreagro.Report.RepNota3FlujoEfectivo
End Class