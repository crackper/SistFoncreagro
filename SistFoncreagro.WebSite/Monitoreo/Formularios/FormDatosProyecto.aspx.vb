Imports System.IO
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Imports Telerik.Web.UI

Public Class FormDatosProyecto
    Inherits System.Web.UI.Page

    Dim _personalBL As PersonalBL

    Protected Overrides Sub OnInit(ByVal e As EventArgs)
        MyBase.OnInit(e)
        If Not Page.IsPostBack Then
            _personalBL = New PersonalBL()
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        radcbPersonal.Entries.Insert(0, New AutoCompleteBoxEntry("Guillermos", "1"))
    End Sub

    Protected Sub odsPersonal_ObjectCreating(sender As Object, e As System.Web.UI.WebControls.ObjectDataSourceEventArgs) Handles odsPersonal.ObjectCreating
        e.ObjectInstance = _personalBL
    End Sub
End Class