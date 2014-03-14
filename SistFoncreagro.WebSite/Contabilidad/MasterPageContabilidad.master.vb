Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class MasterPageContabilidad
    Inherits System.Web.UI.MasterPage
    Dim TransaccionBL As New TransaccionBL
    Dim IdSubDiario As Integer
    Dim Flag As String
    Dim EjercicioBL As New EjercicioBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim estadoMes As String = ""
        Dim Mes As String = ""

        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))

        Select Case Session("Mes")
            Case 1
                Mes = "Enero"
            Case 2
                Mes = "Febrero"
            Case 3
                Mes = "Marzo"
            Case 4
                Mes = "Abril"
            Case 5
                Mes = "Mayo"
            Case 6
                Mes = "Junio"
            Case 7
                Mes = "Julio"
            Case 8
                Mes = "Agosto"
            Case 9
                Mes = "Setiembre"
            Case 10
                Mes = "Octubre"
            Case 11
                Mes = "Noviembre"
            Case 12
                Mes = "Diciembre"
        End Select

        If Not Page.IsPostBack Then
            Me.Label2.Text = "Ejercicio: " + Session("Anio").ToString + "    --   Mes de Trabajo: " + Mes.ToString + "    --   Fecha de Proceso: " + Session("Fecha").ToString

            If estadoMes = "C" Then
                Me.Label1.Text = "¡El Mes se encuentra Cerrado!"
            Else
                Me.Label1.Text = ""
            End If
        End If
    End Sub

  
End Class