Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmProyectoPresupuesto
    Inherits System.Web.UI.Page
    ''Dim table As New DataTable("FillSN")
    Dim dis As New Disenio
    Public Function ValidarNumero(ByVal Valor As System.Nullable(Of Decimal)) As Decimal
        Dim MisFunciones As New Funciones
        Dim miNumero As Decimal = MisFunciones.ValorNumero(Valor)
        Return miNumero
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Dim miId As String
            miId = Request.QueryString("IdProyecto")
            HIdProyecto.Value = miId

            Dim _EjerPresup As New EjerPresup
            Dim _EjerPresupBl As New EjerPresupBL
            _EjerPresup = _EjerPresupBl.GetEjerPresupByEstado("PROCESO")
            If _EjerPresup Is Nothing Then
                LblPresup.Visible = True
                Panel2.Visible = False
                RGDatos.Visible = False
            Else
                Dim _ActPresupBL As New ActivarPresupuestoBL
                Dim _ActPresup As New ActivarPresupuesto
                _ActPresup = _ActPresupBL.GetACTIVARPRESUPByIdProyAndIdEjerPresup(_EjerPresup.IdEjerPresup, HIdProyecto.Value)
                If _ActPresup Is Nothing Then
                    'Mensaje
                    dis.Alerta("Este proyecto no tiene asignado un ejercicio presupuestal", Me.Page)
                Else
                    If _ActPresup.Activar = False Then
                        LblPresup.Text = "No tiene permiso para modificar su presupuesto"
                        LblPresup.Visible = True
                        Panel2.Visible = False
                        Panel3.Visible = False
                        Panel4.Visible = False
                    Else
                        LblPresup.Visible = False
                        Panel2.Visible = True
                        Panel3.Visible = True
                        Panel4.Visible = True
                        TxtAnio.Text = _EjerPresup.Anio
                        HFIdEjerPresup.Value = _EjerPresup.IdEjerPresup
                        TxtEjerPresup.Text = _EjerPresup.Codigo
                        TxtMesIni.Text = _EjerPresup.MesIni
                        RGDatos.DataBind()
                    End If
                End If
                
            End If
        End If
    End Sub

    Public Function Numero_Mes(ByVal nomMes As String) As Int32
        Dim NumMes As Int32

        Select Case nomMes
            Case "Ene" : NumMes = 1
            Case "Feb" : NumMes = 2
            Case "Mar" : NumMes = 3
            Case "Abr" : NumMes = 4
            Case "Mayo" : NumMes = 5
            Case "Jun" : NumMes = 6
            Case "Jul" : NumMes = 7
            Case "Ago" : NumMes = 8
            Case "Sep" : NumMes = 9
            Case "Oct" : NumMes = 10
            Case "Nov" : NumMes = 11
            Case "Dic" : NumMes = 12
        End Select
        Return NumMes
    End Function

    Public Function Nombre_Mes(ByVal numMes As Int32) As String
        Dim NomMes As String
        NomMes = ""
        Select Case numMes
            Case 1 : NomMes = "Ene"
            Case 2 : NomMes = "Feb"
            Case 3 : NomMes = "Mar"
            Case 4 : NomMes = "Abr"
            Case 5 : NomMes = "Mayo"
            Case 6 : NomMes = "Jun"
            Case 7 : NomMes = "Jul"
            Case 8 : NomMes = "Ago"
            Case 9 : NomMes = "Sep"
            Case 10 : NomMes = "Oct"
            Case 11 : NomMes = "Nov"
            Case 12 : NomMes = "Dic"
        End Select
        Return NomMes
    End Function

    Private Sub Meses_Grid(ByVal miGrid As GridView)
        Dim i As Integer
        Dim dt As New DataTable

        dt.Columns.Add("Mes")

        For i = 1 To 12
            'Dim dRow As DataRow = dt.NewRow()
            'dRow("Mes") = i.ToString
            'dt.Rows.Add(dRow)
        Next
        miGrid.DataSource = dt
        miGrid.DataBind()

    End Sub

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
    '    Dim table As DataTable

    '    table = Session("FillSN")

    '    table.Columns.Add(New DataColumn("MES", GetType(String)))
    '    table.Columns.Add(New DataColumn("BUDGET", GetType(String)))
    '    table.Columns.Add(New DataColumn("F00", GetType(String)))
    '    table.Columns.Add(New DataColumn("ACTUAL", GetType(String)))
    '    table.Columns.Add(New DataColumn("F01", GetType(String)))
    '    table.Columns.Add(New DataColumn("AVANCE FIS.", GetType(String)))
    '    table.Columns.Add(New DataColumn("PRESUP FIS", GetType(String)))

    '    'Dim nRec As DataRow
    '    'nRec = table.NewRow

    '    For i = 1 To 12
    '        Dim row As DataRow = table.NewRow()
    '        'Dim i As Int32
    '        'i = table.Rows.Count
    '        row.Item(0) = UCase(MonthName(i, False))
    '        table.Rows.Add(row)

    '        table.AcceptChanges()
    '    Next

    '    GVPresupuesto.DataSource = table
    '    Session("FillSN") = table
    '    GVPresupuesto.DataBind()

    'End Sub

    Protected Sub RGDatos_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RGDatos.ItemDataBound
        Dim f, c, NumMes, i, j As Int32
        Dim NomCol As String
        f = RGDatos.Items.Count
        c = RGDatos.Columns.Count
        NumMes = Integer.Parse(TxtMesIni.Text)
        For i = 0 To f - 1
            For j = 6 To 6 + NumMes - 2
                NomCol = RGDatos.Columns(j).UniqueName
                Select Case NomCol
                    Case "Ene"
                        CType(RGDatos.Items(i).FindControl("LblEne"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtEne"), TextBox).Visible = False
                    Case "Feb"
                        CType(RGDatos.Items(i).FindControl("LblFeb"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtFeb"), TextBox).Visible = False
                    Case "Mar"
                        CType(RGDatos.Items(i).FindControl("LblMar"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtMar"), TextBox).Visible = False
                    Case "Abr"
                        CType(RGDatos.Items(i).FindControl("LblAbr"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtAbr"), TextBox).Visible = False
                    Case "Mayo"
                        CType(RGDatos.Items(i).FindControl("LblMayo"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtMayo"), TextBox).Visible = False
                    Case "Jun"
                        CType(RGDatos.Items(i).FindControl("LblJun"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtJun"), TextBox).Visible = False
                    Case "Jul"
                        CType(RGDatos.Items(i).FindControl("LblJul"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtJul"), TextBox).Visible = False
                    Case "Ago"
                        CType(RGDatos.Items(i).FindControl("LblAgo"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtAgo"), TextBox).Visible = False
                    Case "Sep"
                        CType(RGDatos.Items(i).FindControl("LblSep"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtSep"), TextBox).Visible = False
                    Case "Oct"
                        CType(RGDatos.Items(i).FindControl("LblOct"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtOct"), TextBox).Visible = False
                    Case "Nov"
                        CType(RGDatos.Items(i).FindControl("LblNov"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtNov"), TextBox).Visible = False
                    Case "Dic"
                        CType(RGDatos.Items(i).FindControl("LblDic"), Label).Visible = True
                        CType(RGDatos.Items(i).FindControl("txtDic"), TextBox).Visible = False
                End Select
            Next

            Dim func, func1 As String
            Dim TxtTot As New TextBox

            For j = 6 + NumMes - 1 To 18 '7+12-1
                NomCol = RGDatos.Columns(j).UniqueName
                Select Case NomCol
                    Case "Ene"
                        Dim textoEne As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblEne"), Label).Visible = False
                        textoEne = CType(RGDatos.Items(i).FindControl("TxtEne"), TextBox)
                        textoEne.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoEne.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoEne.ClientID & "','" & TxtTot.ClientID & "');"

                        textoEne.Attributes.Add("OnFocus", func)
                        textoEne.Attributes.Add("OnBlur", func1)

                    Case "Feb"
                        Dim textoFeb As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblFeb"), Label).Visible = False
                        textoFeb = CType(RGDatos.Items(i).FindControl("TxtFeb"), TextBox)
                        textoFeb.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)

                        func = "CalcularTotalPresup1('" & textoFeb.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoFeb.ClientID & "','" & TxtTot.ClientID & "');"

                        textoFeb.Attributes.Add("OnFocus", func)
                        textoFeb.Attributes.Add("OnBlur", func1)

                    Case "Mar"
                        Dim textoMar As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblMar"), Label).Visible = False
                        textoMar = CType(RGDatos.Items(i).FindControl("TxtMar"), TextBox)
                        textoMar.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoMar.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoMar.ClientID & "','" & TxtTot.ClientID & "');"

                        textoMar.Attributes.Add("OnFocus", func)
                        textoMar.Attributes.Add("OnBlur", func1)

                    Case "Abr"
                        Dim textoAbr As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblAbr"), Label).Visible = False
                        textoAbr = CType(RGDatos.Items(i).FindControl("txtAbr"), TextBox)
                        textoAbr.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoAbr.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoAbr.ClientID & "','" & TxtTot.ClientID & "');"

                        textoAbr.Attributes.Add("OnFocus", func)
                        textoAbr.Attributes.Add("OnBlur", func1)

                    Case "Mayo"
                        Dim textoMayo As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblMayo"), Label).Visible = False
                        textoMayo = CType(RGDatos.Items(i).FindControl("txtMayo"), TextBox)
                        textoMayo.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoMayo.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoMayo.ClientID & "','" & TxtTot.ClientID & "');"

                        textoMayo.Attributes.Add("OnFocus", func)
                        textoMayo.Attributes.Add("OnBlur", func1)

                    Case "Jun"
                        Dim textoJun As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblJun"), Label).Visible = False
                        textoJun = CType(RGDatos.Items(i).FindControl("txtJun"), TextBox)
                        textoJun.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoJun.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoJun.ClientID & "','" & TxtTot.ClientID & "');"

                        textoJun.Attributes.Add("OnFocus", func)
                        textoJun.Attributes.Add("OnBlur", func1)

                    Case "Jul"
                        Dim textoJul As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblJul"), Label).Visible = False
                        textoJul = CType(RGDatos.Items(i).FindControl("TxtJul"), TextBox)
                        textoJul.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoJul.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoJul.ClientID & "','" & TxtTot.ClientID & "');"

                        textoJul.Attributes.Add("OnFocus", func)
                        textoJul.Attributes.Add("OnBlur", func1)

                    Case "Ago"
                        Dim textoAgo As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblAgo"), Label).Visible = False
                        textoAgo = CType(RGDatos.Items(i).FindControl("txtAgo"), TextBox)
                        textoAgo.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoAgo.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoAgo.ClientID & "','" & TxtTot.ClientID & "');"

                        textoAgo.Attributes.Add("OnFocus", func)
                        textoAgo.Attributes.Add("OnBlur", func1)

                    Case "Sep"
                        Dim textoSep As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblSep"), Label).Visible = False
                        textoSep = CType(RGDatos.Items(i).FindControl("txtSep"), TextBox)
                        textoSep.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoSep.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoSep.ClientID & "','" & TxtTot.ClientID & "');"

                        textoSep.Attributes.Add("OnFocus", func)
                        textoSep.Attributes.Add("OnBlur", func1)

                    Case "Oct"
                        Dim textoOct As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblOct"), Label).Visible = False
                        textoOct = CType(RGDatos.Items(i).FindControl("txtOct"), TextBox)
                        textoOct.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoOct.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoOct.ClientID & "','" & TxtTot.ClientID & "');"

                        textoOct.Attributes.Add("OnFocus", func)
                        textoOct.Attributes.Add("OnBlur", func1)

                    Case "Nov"
                        Dim textoNov As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblNov"), Label).Visible = False
                        textoNov = CType(RGDatos.Items(i).FindControl("txtNov"), TextBox)
                        textoNov.Visible = True

                        TxtTot = CType(RGDatos.Items(i).FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoNov.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoNov.ClientID & "','" & TxtTot.ClientID & "');"

                        textoNov.Attributes.Add("OnFocus", func)
                        textoNov.Attributes.Add("OnBlur", func1)

                    Case "Dic"
                        Dim textoDic As New TextBox
                        CType(RGDatos.Items(i).FindControl("LblDic"), Label).Visible = False
                        textoDic = CType(RGDatos.Items(i).FindControl("txtDic"), TextBox)
                        textoDic.Visible = True

                        TxtTot = CType(RGDatos.Items(i)("Total").FindControl("TxtTotal"), TextBox)
                        func = "CalcularTotalPresup1('" & textoDic.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoDic.ClientID & "','" & TxtTot.ClientID & "');"

                        textoDic.Attributes.Add("OnFocus", func)
                        textoDic.Attributes.Add("OnBlur", func1)

                End Select
            Next
        Next
    End Sub

    Private Function Total_Financiero() As Decimal
        Dim f, NumF As Int32
        Dim mSuma As Decimal
        Dim Cad As String
        NumF = RGDatos.Items.Count - 1
        For f = 0 To NumF Step 2
            Cad = CType(RGDatos.Items(f).FindControl("TxtTotal"), TextBox).Text
            If Cad = "" Then Cad = "0"
            mSuma = mSuma + Decimal.Parse(Cad)
        Next
        Return mSuma
    End Function

    Protected Sub RGDatos_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGDatos.ItemCommand
        If e.CommandName = "Grabar" Then
            Dim mIdCCosto, nMes, f, mIdEjerPresup As Int32
            Dim _LsDetEjerPresup As New List(Of DetEjerPresup)
            Dim _DetEjerPresup As DetEjerPresup
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            mIdCCosto = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdCCosto")
            mIdEjerPresup = Integer.Parse(HFIdEjerPresup.Value)
            f = editeditem.ItemIndex
            For i = 6 To 17
                _DetEjerPresup = New DetEjerPresup
                _DetEjerPresup.IdCCosto = mIdCCosto
                _DetEjerPresup.IdEjerPresup = mIdEjerPresup
                _DetEjerPresup.Anio = Integer.Parse(TxtAnio.Text)
                nMes = Numero_Mes(RGDatos.Columns(i).UniqueName)
                _DetEjerPresup.Mes = nMes

                _DetEjerPresup.ProgramadoPresup = Valor_Mes(f, nMes)
                
        _LsDetEjerPresup.Add(_DetEjerPresup)
            Next
           
            Dim _DetEjerPresupBL As New DetEjerPresupBL
            _DetEjerPresupBL.SaveDetEjerPresup1(_LsDetEjerPresup)
            RGDatos.DataBind()
        End If
    End Sub

    Private Function Valor_Mes(ByVal nFila As Int32, ByVal numMes As Int32)
        Dim Valor As Decimal
        Dim Etiqueta As New Label
        Dim Caja As New TextBox

        Select Case numMes
            Case 1
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblEne"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtEne"), TextBox)
            Case 2
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblFeb"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtFeb"), TextBox)
            Case 3
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblMar"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtMar"), TextBox)
            Case 4
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblAbr"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtAbr"), TextBox)
            Case 5
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblMayo"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtMayo"), TextBox)
            Case 6
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblJun"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtJun"), TextBox)
            Case 7
                Etiqueta = CType(RGDatos.Items(nFila)("Jul").FindControl("LblJul"), Label)
                Caja = CType(RGDatos.Items(nFila)("Jul").FindControl("TxtJul"), TextBox)
            Case 8
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblAgo"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtAgo"), TextBox)
            Case 9
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblSep"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtSep"), TextBox)
            Case 10
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblOct"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtOct"), TextBox)
            Case 11
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblNov"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtNov"), TextBox)
            Case 12
                Etiqueta = CType(RGDatos.Items(nFila).FindControl("LblDic"), Label)
                Caja = CType(RGDatos.Items(nFila).FindControl("TxtDic"), TextBox)
        End Select

        ' Valor = 0
        If Caja.Visible = True Then
            If Caja.Text <> "" Then Valor = CDec(Caja.Text)
        Else
            If Etiqueta.Text <> "" Then Valor = CDec(Etiqueta.Text)
        End If
        Return Valor

    End Function

    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevo.Click, RGDatos.Disposed
        Dim _DatosPresup As New DatosPresupBL
        Dim _IdProy, _IdEjerPresup As Int32
        _IdEjerPresup = Integer.Parse(HFIdEjerPresup.Value)
        _IdProy = Integer.Parse(Request.QueryString("IdProyecto"))
        _DatosPresup.CrearPresup(_IdProy, _IdEjerPresup)
        RGDatos.DataBind()
    End Sub

    Private Sub FrmProyectoPresupuesto_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        If RGDatos.Items.Count = 0 And LblPresup.Visible = False Then
            BtnNuevo.Visible = True
        Else
            BtnNuevo.Visible = False
        End If
    End Sub

    Private Sub RGDatos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles RGDatos.Load
        If Panel3.Visible = True Then
            TxtTotalFin.Text = Total_Financiero()
        End If
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        If HIdProyecto.Value = "" Then RWMensajes.RadAlert("No hay un proyecto seleccionado", 230, 100, "Error", "") : Exit Sub
        Select Case e.Item.Value
            Case "Datos"
                Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Convenio"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoConvenio.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Componentes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoComponentes.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Actividades"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoActividad.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "CCostos"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoCCosto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Ambito"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAmbito.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Informes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoInformes.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "ForFin"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuesto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "ForAnual"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuestoAnual.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "AvanFis"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAvanceFisico.aspx?IdProyecto=" + HIdProyecto.Value)
        End Select
    End Sub
End Class