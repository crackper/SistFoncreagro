Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ElegirEmpresa
    Inherits System.Web.UI.Page
    Dim TipoCambioBL As New TipocambioBL
    Dim valor As Decimal
    Dim valor1 As Decimal
    Dim EjercicioBl As New EjercicioBL
    Dim _Ejercicio As New Ejercicio
    Dim cadena As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Now
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If Me.RadDatePicker1.SelectedDate > Date.Now Then
            Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡La Fecha de Proceso debe ser Menor o Igual a la Fecha Actual!</b> ', 330, 210,'¡Alerta!'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
            Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
        Else
            Session("Anio") = Date.Parse(Me.RadDatePicker1.SelectedDate).Year
            Session("Mes") = Date.Parse(Me.RadDatePicker1.SelectedDate).Month
            Session("Fecha") = Date.Parse(Me.RadDatePicker1.SelectedDate).ToShortDateString
            Session("Dia") = Date.Parse(Me.RadDatePicker1.SelectedDate).Day

            If EjercicioBl.VerifyExisteEJERCICIO(Session("Anio")) = 0 Then ''si no existe el ejercicio se crea uno nuevo
                _Ejercicio.Anio = Session("Anio")
                EjercicioBl.SaveEJERCICIO(_Ejercicio)
            End If

            For i As Int32 = 1 To Session("Dia")
                valor = TipoCambioBL.GetTIPOCAMBIOByAnioMesDia(Session("Anio"), Session("Mes"), i)
                valor1 = TipoCambioBL.GetTIPOCAMBIO1ByAnioMesDia(Session("Anio"), Session("Mes"), i)

                If valor = 0 Or valor1 = 0 Then
                    cadena = cadena + "X"
                End If

            Next
            If (cadena.Length > 0 And cadena.Contains("X")) Then
                Response.Redirect("FrmTipoCambio1.aspx")
            Else
                Response.Redirect("DefaultContabilidad.aspx")
            End If
            Response.Redirect(cadena)
        End If
    End Sub
End Class