Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class ControlObservacionConvenio
    Inherits System.Web.UI.UserControl

    Private _dataItem As Object = Nothing

    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property

    Private Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then
            TxtObs.Text = ""
        Else
            TxtObs.Text = DataBinder.Eval(DataItem, "Observacion")
        End If
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click

    End Sub
End Class