Imports System.IO
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FormDatosProyecto
    Inherits System.Web.UI.Page

    Dim _personalBL As PersonalBL

    Protected Friend Overrides Sub OnInit(ByVal e As EventArgs)
        MyBase.OnInit(e)

        _personalBL = New PersonalBL()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class