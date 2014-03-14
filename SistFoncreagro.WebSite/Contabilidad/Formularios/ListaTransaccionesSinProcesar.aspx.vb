Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ListaTransaccionesSinProcesar
    Inherits System.Web.UI.Page
    Dim ProyectoBL As New ProyectoBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Function DescEstado(ByVal Estado As String) As String
        Dim descripcion As String = ""
        Select Case Estado
            Case "S"
                descripcion = "Sin Procesar"
            Case "P"
                descripcion = "Procesado"
            Case "A"
                descripcion = "Actualizado"
            Case "N"
                descripcion = "Anulado"
            Case "C"
                descripcion = "Cancelado"
            Case "E"
                descripcion = "Errado"
            Case "V"
                descripcion = "Validado"
        End Select
        Return descripcion
    End Function
    Public Function Color(ByVal Estado As String) As Drawing.Color
        Dim col As Drawing.Color
        Select Case Estado
            Case "S"
                col = Drawing.Color.Red
            Case "P"
                col = Drawing.Color.Blue
            Case "A"
                col = Drawing.Color.Blue
            Case "N"
                col = Drawing.Color.Gray
            Case "C"
                col = Drawing.Color.Black
            Case "V"
                col = Drawing.Color.Blue
            Case "E"
                col = Drawing.Color.Red
        End Select

        Return col
    End Function
    Public Function Proyecto(ByVal id As Int32) As String
        Dim nombre As String
        nombre = ProyectoBL.GetFromProyectoByIdProyecto(id).Codigo
        Return nombre
    End Function
End Class