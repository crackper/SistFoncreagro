Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI
Public Class FrmProgramacionPoa
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Dim _programacion As New Programacion
    Dim Programacion As Programacion
    Dim ProgramacionBL As New ProgramacionBL
    Dim Anio As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Request.QueryString("IdProyecto")
        Anio = Request.QueryString("Anio")
        If Page.IsPostBack = False Then
            Me.TextBox1.Text = Date.Now.Year
            If Anio > 0 Then
                Me.TextBox1.Text = Anio
            End If
        End If
    End Sub

    'Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
    '    ProgramacionBL.GenerarProgramacionPoaTecnico(Me.TextBox1.Text, IdProyecto)
    '    Response.Redirect("FrmProgramacionPoa.aspx?Anio=" + Me.TextBox1.Text + "&IdProyecto=" + IdProyecto.ToString)
    'End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If e.Item.OwnerTableView.Items.Count = 0 Then
            Me.Button1.Visible = True
            Me.ImageButton2.Visible = False
        Else
            Me.Button1.Visible = False
            Me.ImageButton2.Visible = True
        End If

        For y = 0 To e.Item.OwnerTableView.Items.Count - 1
            If e.Item.OwnerTableView.Items.Item(y)("Tipo").Text = "S" Then
                e.Item.OwnerTableView.Items.Item(y).BackColor = Drawing.Color.SandyBrown
            Else
                e.Item.OwnerTableView.Items.Item(y).BackColor = Drawing.Color.White
            End If

        Next

        Dim f, c, i, j As Int32
        Dim NomCol As String
        f = RadGrid1.Items.Count
        c = RadGrid1.Columns.Count

        For i = 0 To f - 1
            Dim func, func1 As String
            Dim TxtTot As New TextBox

            For j = 4 To 16 '7+12-1
                NomCol = RadGrid1.Columns(j).UniqueName
                Select Case NomCol
                    Case "EneF1"
                        Dim textoEne As New TextBox
                        textoEne = CType(RadGrid1.Items(i).FindControl("TextBox3"), TextBox)
                        textoEne.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoEne.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoEne.ClientID & "','" & TxtTot.ClientID & "');"

                        textoEne.Attributes.Add("OnFocus", func)
                        textoEne.Attributes.Add("OnBlur", func1)

                    Case "FebF1"
                        Dim textoFeb As New TextBox
                        textoFeb = CType(RadGrid1.Items(i).FindControl("TextBox4"), TextBox)
                        textoFeb.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)

                        func = "CalcularTotalPresup1('" & textoFeb.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoFeb.ClientID & "','" & TxtTot.ClientID & "');"

                        textoFeb.Attributes.Add("OnFocus", func)
                        textoFeb.Attributes.Add("OnBlur", func1)

                    Case "MarF1"
                        Dim textoMar As New TextBox
                        textoMar = CType(RadGrid1.Items(i).FindControl("TextBox5"), TextBox)
                        textoMar.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoMar.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoMar.ClientID & "','" & TxtTot.ClientID & "');"

                        textoMar.Attributes.Add("OnFocus", func)
                        textoMar.Attributes.Add("OnBlur", func1)

                    Case "AbrF1"
                        Dim textoAbr As New TextBox
                        textoAbr = CType(RadGrid1.Items(i).FindControl("TextBox6"), TextBox)
                        textoAbr.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoAbr.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoAbr.ClientID & "','" & TxtTot.ClientID & "');"

                        textoAbr.Attributes.Add("OnFocus", func)
                        textoAbr.Attributes.Add("OnBlur", func1)

                    Case "MayF1"
                        Dim textoMayo As New TextBox
                        textoMayo = CType(RadGrid1.Items(i).FindControl("TextBox7"), TextBox)
                        textoMayo.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoMayo.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoMayo.ClientID & "','" & TxtTot.ClientID & "');"

                        textoMayo.Attributes.Add("OnFocus", func)
                        textoMayo.Attributes.Add("OnBlur", func1)

                    Case "JunF1"
                        Dim textoJun As New TextBox
                        textoJun = CType(RadGrid1.Items(i).FindControl("TextBox8"), TextBox)
                        textoJun.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoJun.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoJun.ClientID & "','" & TxtTot.ClientID & "');"

                        textoJun.Attributes.Add("OnFocus", func)
                        textoJun.Attributes.Add("OnBlur", func1)

                    Case "JulF1"
                        Dim textoJul As New TextBox
                        textoJul = CType(RadGrid1.Items(i).FindControl("TextBox9"), TextBox)
                        textoJul.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoJul.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoJul.ClientID & "','" & TxtTot.ClientID & "');"

                        textoJul.Attributes.Add("OnFocus", func)
                        textoJul.Attributes.Add("OnBlur", func1)

                    Case "AgoF1"
                        Dim textoAgo As New TextBox
                        textoAgo = CType(RadGrid1.Items(i).FindControl("TextBox10"), TextBox)
                        textoAgo.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoAgo.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoAgo.ClientID & "','" & TxtTot.ClientID & "');"

                        textoAgo.Attributes.Add("OnFocus", func)
                        textoAgo.Attributes.Add("OnBlur", func1)

                    Case "SepF1"
                        Dim textoSep As New TextBox
                        textoSep = CType(RadGrid1.Items(i).FindControl("TextBox11"), TextBox)
                        textoSep.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoSep.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoSep.ClientID & "','" & TxtTot.ClientID & "');"

                        textoSep.Attributes.Add("OnFocus", func)
                        textoSep.Attributes.Add("OnBlur", func1)

                    Case "OctF1"
                        Dim textoOct As New TextBox
                        textoOct = CType(RadGrid1.Items(i).FindControl("TextBox12"), TextBox)
                        textoOct.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoOct.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoOct.ClientID & "','" & TxtTot.ClientID & "');"

                        textoOct.Attributes.Add("OnFocus", func)
                        textoOct.Attributes.Add("OnBlur", func1)

                    Case "NovF1"
                        Dim textoNov As New TextBox
                        textoNov = CType(RadGrid1.Items(i).FindControl("TextBox13"), TextBox)
                        textoNov.Visible = True

                        TxtTot = CType(RadGrid1.Items(i).FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoNov.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoNov.ClientID & "','" & TxtTot.ClientID & "');"

                        textoNov.Attributes.Add("OnFocus", func)
                        textoNov.Attributes.Add("OnBlur", func1)

                    Case "DicF1"
                        Dim textoDic As New TextBox
                        textoDic = CType(RadGrid1.Items(i).FindControl("TextBox14"), TextBox)
                        textoDic.Visible = True

                        TxtTot = CType(RadGrid1.Items(i)("Total").FindControl("TextBox2"), TextBox)
                        func = "CalcularTotalPresup1('" & textoDic.ClientID & "','" & TxtTot.ClientID & "');"
                        func1 = "CalcularTotalPresup2('" & textoDic.ClientID & "','" & TxtTot.ClientID & "');"

                        textoDic.Attributes.Add("OnFocus", func)
                        textoDic.Attributes.Add("OnBlur", func1)
                End Select
            Next
        Next
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Dim listaProgramacion As New List(Of Programacion)
        For i = 0 To Me.RadGrid1.Items.Count - 1
            Dim _Programacion As New Programacion
            Dim txtEne As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox3"), TextBox)
            Dim txtFeb As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox4"), TextBox)
            Dim txtMar As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox5"), TextBox)
            Dim txtAbr As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox6"), TextBox)
            Dim txtMay As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox7"), TextBox)
            Dim txtJun As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox8"), TextBox)
            Dim txtJul As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox9"), TextBox)
            Dim txtAgo As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox10"), TextBox)
            Dim txtSep As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox11"), TextBox)
            Dim txtOct As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox12"), TextBox)
            Dim txtNov As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox13"), TextBox)
            Dim txtDic As TextBox = CType(Me.RadGrid1.Items(i).FindControl("TextBox14"), TextBox)

            _Programacion.EneF = txtEne.Text
            _Programacion.FebF = txtFeb.Text
            _Programacion.MarF = txtMar.Text
            _Programacion.AbrF = txtAbr.Text
            _Programacion.MayF = txtMay.Text
            _Programacion.JunF = txtJun.Text
            _Programacion.JulF = txtJul.Text
            _Programacion.AgoF = txtAgo.Text
            _Programacion.SepF = txtSep.Text
            _Programacion.OctF = txtOct.Text
            _Programacion.NovF = txtNov.Text
            _Programacion.DicF = txtDic.Text
            _Programacion.Anio = Me.TextBox1.Text
            _Programacion.IdProgramacion = Me.RadGrid1.Items(i)("IdProgramacion").Text

            listaProgramacion.Add(_Programacion)

        Next
        ProgramacionBL.SaveListaProgramacion(listaProgramacion)
        Response.Redirect("FrmProgramacionPoa.aspx?Anio=" + Me.TextBox1.Text + "&IdProyecto=" + IdProyecto.ToString)
    End Sub

   
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgramacionBL.GenerarProgramacionPoaTecnico(Me.TextBox1.Text, Session("IdProyecto"))
        Response.Redirect("FrmProgramacionPoa.aspx?Anio=" + Me.TextBox1.Text)
    End Sub
End Class