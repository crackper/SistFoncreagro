Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmTipoCambio1
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL
    Dim TipoCambio As New TipoCambio
    Dim _TipoCambio As TipoCambio
    Dim IdTipoCambio As String
    Dim mes As Int32
    Dim dia As Int32
    Dim ventana As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        IdTipoCambio = Request.QueryString("IdTipoCambio")

        Dim valor As Int32
        Dim tc As Decimal
        Dim tc1 As Decimal
        Dim cadena As String = ""

            valor = TipoCambioBL.GetNumeroRegistrosFromTIPOCAMBIOByAnioMes(Session("Anio"), Session("Mes"))
            If valor > 0 Then
                _TipoCambio = TipoCambioBL.GetTIPOCAMBIOByAnioMes(Session("Anio"), Session("Mes"))
                IdTipoCambio = _TipoCambio.IdTipoCambio
                mes = Session("Mes")
            dia = Session("Dia")
        Else
            dia = Session("Dia")
        End If

        For i As Int32 = 1 To dia
            tc = TipoCambioBL.GetTIPOCAMBIOByAnioMesDia(Session("Anio"), mes, i)
            tc1 = TipoCambioBL.GetTIPOCAMBIO1ByAnioMesDia(Session("Anio"), mes, i)

            If tc = 0 Or tc1 = 0 Then
                cadena = cadena + "X"
            End If
          

            If tc = 0 Or tc1 = 0 Then
                Select Case i
                    Case 1
                        Me.TextBox1.BackColor = Drawing.Color.Red
                        Me.TextBox1.ForeColor = Drawing.Color.White
                        Me.TextBox2.BackColor = Drawing.Color.Red
                        Me.TextBox2.ForeColor = Drawing.Color.White
                    Case 2
                        Me.TextBox3.BackColor = Drawing.Color.Red
                        Me.TextBox4.BackColor = Drawing.Color.Red
                        Me.TextBox3.ForeColor = Drawing.Color.White
                        Me.TextBox4.ForeColor = Drawing.Color.White
                    Case 3
                        Me.TextBox5.BackColor = Drawing.Color.Red
                        Me.TextBox6.BackColor = Drawing.Color.Red
                        Me.TextBox5.ForeColor = Drawing.Color.White
                        Me.TextBox6.ForeColor = Drawing.Color.White
                    Case 4
                        Me.TextBox7.BackColor = Drawing.Color.Red
                        Me.TextBox8.BackColor = Drawing.Color.Red
                        Me.TextBox7.ForeColor = Drawing.Color.White
                        Me.TextBox8.ForeColor = Drawing.Color.White
                    Case 5
                        Me.TextBox9.BackColor = Drawing.Color.Red
                        Me.TextBox10.BackColor = Drawing.Color.Red
                        Me.TextBox9.ForeColor = Drawing.Color.White
                        Me.TextBox10.ForeColor = Drawing.Color.White
                    Case 6
                        Me.TextBox11.BackColor = Drawing.Color.Red
                        Me.TextBox12.BackColor = Drawing.Color.Red
                        Me.TextBox11.ForeColor = Drawing.Color.White
                        Me.TextBox12.ForeColor = Drawing.Color.White
                    Case 7
                        Me.TextBox13.BackColor = Drawing.Color.Red
                        Me.TextBox14.BackColor = Drawing.Color.Red
                        Me.TextBox13.ForeColor = Drawing.Color.White
                        Me.TextBox14.ForeColor = Drawing.Color.White
                    Case 8
                        Me.TextBox15.BackColor = Drawing.Color.Red
                        Me.TextBox16.BackColor = Drawing.Color.Red
                        Me.TextBox15.ForeColor = Drawing.Color.White
                        Me.TextBox16.ForeColor = Drawing.Color.White
                    Case 9
                        Me.TextBox17.BackColor = Drawing.Color.Red
                        Me.TextBox18.BackColor = Drawing.Color.Red
                        Me.TextBox17.ForeColor = Drawing.Color.White
                        Me.TextBox18.ForeColor = Drawing.Color.White
                    Case 10
                        Me.TextBox19.BackColor = Drawing.Color.Red
                        Me.TextBox20.BackColor = Drawing.Color.Red
                        Me.TextBox19.ForeColor = Drawing.Color.White
                        Me.TextBox20.ForeColor = Drawing.Color.White
                    Case 11
                        Me.TextBox21.BackColor = Drawing.Color.Red
                        Me.TextBox22.BackColor = Drawing.Color.Red
                        Me.TextBox21.ForeColor = Drawing.Color.White
                        Me.TextBox22.ForeColor = Drawing.Color.White
                    Case 12
                        Me.TextBox23.BackColor = Drawing.Color.Red
                        Me.TextBox24.BackColor = Drawing.Color.Red
                        Me.TextBox23.ForeColor = Drawing.Color.White
                        Me.TextBox24.ForeColor = Drawing.Color.White
                    Case 13
                        Me.TextBox25.BackColor = Drawing.Color.Red
                        Me.TextBox26.BackColor = Drawing.Color.Red
                        Me.TextBox25.ForeColor = Drawing.Color.White
                        Me.TextBox26.ForeColor = Drawing.Color.White
                    Case 14
                        Me.TextBox27.BackColor = Drawing.Color.Red
                        Me.TextBox28.BackColor = Drawing.Color.Red
                        Me.TextBox27.ForeColor = Drawing.Color.White
                        Me.TextBox28.ForeColor = Drawing.Color.White
                    Case 15
                        Me.TextBox29.BackColor = Drawing.Color.Red
                        Me.TextBox30.BackColor = Drawing.Color.Red
                        Me.TextBox29.ForeColor = Drawing.Color.White
                        Me.TextBox30.ForeColor = Drawing.Color.White
                    Case 16
                        Me.TextBox31.BackColor = Drawing.Color.Red
                        Me.TextBox32.BackColor = Drawing.Color.Red
                        Me.TextBox31.ForeColor = Drawing.Color.White
                        Me.TextBox32.ForeColor = Drawing.Color.White
                    Case 17
                        Me.TextBox33.BackColor = Drawing.Color.Red
                        Me.TextBox34.BackColor = Drawing.Color.Red
                        Me.TextBox33.ForeColor = Drawing.Color.White
                        Me.TextBox34.ForeColor = Drawing.Color.White
                    Case 18
                        Me.TextBox35.BackColor = Drawing.Color.Red
                        Me.TextBox36.BackColor = Drawing.Color.Red
                        Me.TextBox35.ForeColor = Drawing.Color.White
                        Me.TextBox36.ForeColor = Drawing.Color.White
                    Case 19
                        Me.TextBox37.BackColor = Drawing.Color.Red
                        Me.TextBox38.BackColor = Drawing.Color.Red
                        Me.TextBox37.ForeColor = Drawing.Color.White
                        Me.TextBox38.ForeColor = Drawing.Color.White
                    Case 20
                        Me.TextBox39.BackColor = Drawing.Color.Red
                        Me.TextBox40.BackColor = Drawing.Color.Red
                        Me.TextBox39.ForeColor = Drawing.Color.White
                        Me.TextBox40.ForeColor = Drawing.Color.White
                    Case 21
                        Me.TextBox41.BackColor = Drawing.Color.Red
                        Me.TextBox42.BackColor = Drawing.Color.Red
                        Me.TextBox41.ForeColor = Drawing.Color.White
                        Me.TextBox42.ForeColor = Drawing.Color.White
                    Case 22
                        Me.TextBox43.BackColor = Drawing.Color.Red
                        Me.TextBox44.BackColor = Drawing.Color.Red
                        Me.TextBox43.ForeColor = Drawing.Color.White
                        Me.TextBox44.ForeColor = Drawing.Color.White
                    Case 23
                        Me.TextBox45.BackColor = Drawing.Color.Red
                        Me.TextBox46.BackColor = Drawing.Color.Red
                        Me.TextBox45.ForeColor = Drawing.Color.White
                        Me.TextBox46.ForeColor = Drawing.Color.White
                    Case 24
                        Me.TextBox47.BackColor = Drawing.Color.Red
                        Me.TextBox48.BackColor = Drawing.Color.Red
                        Me.TextBox47.ForeColor = Drawing.Color.White
                        Me.TextBox48.ForeColor = Drawing.Color.White
                    Case 25
                        Me.TextBox49.BackColor = Drawing.Color.Red
                        Me.TextBox50.BackColor = Drawing.Color.Red
                        Me.TextBox49.ForeColor = Drawing.Color.White
                        Me.TextBox50.ForeColor = Drawing.Color.White
                    Case 26
                        Me.TextBox51.BackColor = Drawing.Color.Red
                        Me.TextBox52.BackColor = Drawing.Color.Red
                        Me.TextBox51.ForeColor = Drawing.Color.White
                        Me.TextBox52.ForeColor = Drawing.Color.White
                    Case 27
                        Me.TextBox53.BackColor = Drawing.Color.Red
                        Me.TextBox54.BackColor = Drawing.Color.Red
                        Me.TextBox53.ForeColor = Drawing.Color.White
                        Me.TextBox54.ForeColor = Drawing.Color.White
                    Case 28
                        Me.TextBox55.BackColor = Drawing.Color.Red
                        Me.TextBox56.BackColor = Drawing.Color.Red
                        Me.TextBox55.ForeColor = Drawing.Color.White
                        Me.TextBox56.ForeColor = Drawing.Color.White
                    Case 29
                        Me.TextBox57.BackColor = Drawing.Color.Red
                        Me.TextBox58.BackColor = Drawing.Color.Red
                        Me.TextBox57.ForeColor = Drawing.Color.White
                        Me.TextBox58.ForeColor = Drawing.Color.White
                    Case 30
                        Me.TextBox59.BackColor = Drawing.Color.Red
                        Me.TextBox60.BackColor = Drawing.Color.Red
                        Me.TextBox59.ForeColor = Drawing.Color.White
                        Me.TextBox60.ForeColor = Drawing.Color.White
                    Case 31
                        Me.TextBox61.BackColor = Drawing.Color.Red
                        Me.TextBox62.BackColor = Drawing.Color.Red
                        Me.TextBox61.ForeColor = Drawing.Color.White
                        Me.TextBox62.ForeColor = Drawing.Color.White
                End Select

            End If
        Next
        If (cadena.Length > 0 And cadena.Contains("X")) Then
            ventana = "FrmFechaProceso.aspx"
            'Me.ImageButton1.Visible = False
            Me.Image1.Visible = True
        Else
            'Me.ImageButton1.Visible = True
            ventana = "DefaultContabilidad.aspx"
            Me.Image1.Visible = False
        End If

        If Me.Page.IsPostBack = False Then
            Me.ComboBox1.SelectedValue = 2
            Me.ComboBox2.SelectedValue = 1

            valor = TipoCambioBL.GetNumeroRegistrosFromTIPOCAMBIOByAnioMes(Session("Anio"), Session("Mes"))
            If valor > 0 Then

                _TipoCambio = TipoCambioBL.GetTIPOCAMBIOByAnioMes(Session("Anio"), Session("Mes"))
                IdTipoCambio = _TipoCambio.IdTipoCambio
                Me.ComboBox1.SelectedValue = _TipoCambio.IdMoneda.ToString
                Me.ComboBox2.SelectedValue = _TipoCambio.Mes.ToString
                Me.TextBox63.Text = _TipoCambio.CompraCierre
                Me.TextBox64.Text = _TipoCambio.VentaCierre
                Me.TextBox1.Text = _TipoCambio.Compra1
                Me.TextBox3.Text = _TipoCambio.Compra2
                Me.TextBox5.Text = _TipoCambio.Compra3
                Me.TextBox7.Text = _TipoCambio.Compra4
                Me.TextBox9.Text = _TipoCambio.Compra5
                Me.TextBox11.Text = _TipoCambio.Compra6
                Me.TextBox13.Text = _TipoCambio.Compra7
                Me.TextBox15.Text = _TipoCambio.Compra8
                Me.TextBox17.Text = _TipoCambio.Compra9
                Me.TextBox19.Text = _TipoCambio.Compra10
                Me.TextBox21.Text = _TipoCambio.Compra11
                Me.TextBox23.Text = _TipoCambio.Compra12
                Me.TextBox25.Text = _TipoCambio.Compra13
                Me.TextBox27.Text = _TipoCambio.Compra14
                Me.TextBox29.Text = _TipoCambio.Compra15
                Me.TextBox31.Text = _TipoCambio.Compra16
                Me.TextBox33.Text = _TipoCambio.Compra17
                Me.TextBox35.Text = _TipoCambio.Compra18
                Me.TextBox37.Text = _TipoCambio.Compra19
                Me.TextBox39.Text = _TipoCambio.Compra20
                Me.TextBox41.Text = _TipoCambio.Compra21
                Me.TextBox43.Text = _TipoCambio.Compra22
                Me.TextBox45.Text = _TipoCambio.Compra23
                Me.TextBox47.Text = _TipoCambio.Compra24
                Me.TextBox49.Text = _TipoCambio.Compra25
                Me.TextBox51.Text = _TipoCambio.Compra26
                Me.TextBox53.Text = _TipoCambio.Compra27
                Me.TextBox55.Text = _TipoCambio.Compra28
                Me.TextBox57.Text = _TipoCambio.Compra29
                Me.TextBox59.Text = _TipoCambio.Compra30
                Me.TextBox61.Text = _TipoCambio.Compra31
                Me.TextBox2.Text = _TipoCambio.Venta1
                Me.TextBox4.Text = _TipoCambio.Venta2
                Me.TextBox6.Text = _TipoCambio.Venta3
                Me.TextBox8.Text = _TipoCambio.Venta4
                Me.TextBox10.Text = _TipoCambio.Venta5
                Me.TextBox12.Text = _TipoCambio.Venta6
                Me.TextBox14.Text = _TipoCambio.Venta7
                Me.TextBox16.Text = _TipoCambio.Venta8
                Me.TextBox18.Text = _TipoCambio.Venta9
                Me.TextBox20.Text = _TipoCambio.Venta10
                Me.TextBox22.Text = _TipoCambio.Venta11
                Me.TextBox24.Text = _TipoCambio.Venta12
                Me.TextBox26.Text = _TipoCambio.Venta13
                Me.TextBox28.Text = _TipoCambio.Venta14
                Me.TextBox30.Text = _TipoCambio.Venta15
                Me.TextBox32.Text = _TipoCambio.Venta16
                Me.TextBox34.Text = _TipoCambio.Venta17
                Me.TextBox36.Text = _TipoCambio.Venta18
                Me.TextBox38.Text = _TipoCambio.Venta19
                Me.TextBox40.Text = _TipoCambio.Venta20
                Me.TextBox42.Text = _TipoCambio.Venta21
                Me.TextBox44.Text = _TipoCambio.Venta22
                Me.TextBox46.Text = _TipoCambio.Venta23
                Me.TextBox48.Text = _TipoCambio.Venta24
                Me.TextBox50.Text = _TipoCambio.Venta25
                Me.TextBox52.Text = _TipoCambio.Venta26
                Me.TextBox54.Text = _TipoCambio.Venta27
                Me.TextBox56.Text = _TipoCambio.Venta28
                Me.TextBox58.Text = _TipoCambio.Venta29
                Me.TextBox60.Text = _TipoCambio.Venta30
                Me.TextBox62.Text = _TipoCambio.Venta31

            Else
                ventana = "FrmFechaProceso.aspx"
                Me.ComboBox1.SelectedValue = 2
                Me.ComboBox2.SelectedValue = Session("Mes")
                '  Me.ImageButton1.Visible = False
            End If



        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect(ventana)
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Dim id As Int32
        TipoCambio.Anio = Session("Anio")
        TipoCambio.IdTipoCambio = IdTipoCambio
        TipoCambio.Mes = Me.ComboBox2.SelectedValue
        TipoCambio.CompraCierre = Me.TextBox63.Text
        TipoCambio.VentaCierre = Me.TextBox64.Text
        TipoCambio.Compra1 = Me.TextBox1.Text
        TipoCambio.Compra2 = Me.TextBox3.Text
        TipoCambio.Compra3 = Me.TextBox5.Text
        TipoCambio.Compra4 = Me.TextBox7.Text
        TipoCambio.Compra5 = Me.TextBox9.Text
        TipoCambio.Compra6 = Me.TextBox11.Text
        TipoCambio.Compra7 = Me.TextBox13.Text
        TipoCambio.Compra8 = Me.TextBox15.Text
        TipoCambio.Compra9 = Me.TextBox17.Text
        TipoCambio.Compra10 = Me.TextBox19.Text
        TipoCambio.Compra11 = Me.TextBox21.Text
        TipoCambio.Compra12 = Me.TextBox23.Text
        TipoCambio.Compra13 = Me.TextBox25.Text
        TipoCambio.Compra14 = Me.TextBox27.Text
        TipoCambio.Compra15 = Me.TextBox29.Text
        TipoCambio.Compra16 = Me.TextBox31.Text
        TipoCambio.Compra17 = Me.TextBox33.Text
        TipoCambio.Compra18 = Me.TextBox35.Text
        TipoCambio.Compra19 = Me.TextBox37.Text
        TipoCambio.Compra20 = Me.TextBox39.Text
        TipoCambio.Compra21 = Me.TextBox41.Text
        TipoCambio.Compra22 = Me.TextBox43.Text
        TipoCambio.Compra23 = Me.TextBox45.Text
        TipoCambio.Compra24 = Me.TextBox47.Text
        TipoCambio.Compra25 = Me.TextBox49.Text
        TipoCambio.Compra26 = Me.TextBox51.Text
        TipoCambio.Compra27 = Me.TextBox53.Text
        TipoCambio.Compra28 = Me.TextBox55.Text
        TipoCambio.Compra29 = Me.TextBox57.Text
        TipoCambio.Compra30 = Me.TextBox59.Text
        TipoCambio.Compra31 = Me.TextBox61.Text
        TipoCambio.Venta1 = Me.TextBox2.Text
        TipoCambio.Venta2 = Me.TextBox4.Text
        TipoCambio.Venta3 = Me.TextBox6.Text
        TipoCambio.Venta4 = Me.TextBox8.Text
        TipoCambio.Venta5 = Me.TextBox10.Text
        TipoCambio.Venta6 = Me.TextBox12.Text
        TipoCambio.Venta7 = Me.TextBox14.Text
        TipoCambio.Venta8 = Me.TextBox16.Text
        TipoCambio.Venta9 = Me.TextBox18.Text
        TipoCambio.Venta10 = Me.TextBox20.Text
        TipoCambio.Venta11 = Me.TextBox22.Text
        TipoCambio.Venta12 = Me.TextBox24.Text
        TipoCambio.Venta13 = Me.TextBox26.Text
        TipoCambio.Venta14 = Me.TextBox28.Text
        TipoCambio.Venta15 = Me.TextBox30.Text
        TipoCambio.Venta16 = Me.TextBox32.Text
        TipoCambio.Venta17 = Me.TextBox34.Text
        TipoCambio.Venta18 = Me.TextBox36.Text
        TipoCambio.Venta19 = Me.TextBox38.Text
        TipoCambio.Venta20 = Me.TextBox40.Text
        TipoCambio.Venta21 = Me.TextBox42.Text
        TipoCambio.Venta22 = Me.TextBox44.Text
        TipoCambio.Venta23 = Me.TextBox46.Text
        TipoCambio.Venta24 = Me.TextBox48.Text
        TipoCambio.Venta25 = Me.TextBox50.Text
        TipoCambio.Venta26 = Me.TextBox52.Text
        TipoCambio.Venta27 = Me.TextBox54.Text
        TipoCambio.Venta28 = Me.TextBox56.Text
        TipoCambio.Venta29 = Me.TextBox58.Text
        TipoCambio.Venta30 = Me.TextBox60.Text
        TipoCambio.Venta31 = Me.TextBox62.Text
        TipoCambio.IdMoneda = Me.ComboBox1.SelectedValue

        id = TipoCambioBL.SaveTIPOCAMBIO(TipoCambio)

        Response.Redirect("FrmTipoCambio1.aspx?IdTipoCambio=" + id.ToString)
        
    End Sub
End Class