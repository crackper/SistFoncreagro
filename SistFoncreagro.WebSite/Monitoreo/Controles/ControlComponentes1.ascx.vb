Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class ControlComponentes1
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
            Limpiar_Campos()
        Else
            TxtIdComponente.Text = DataBinder.Eval(DataItem, "IdComponente")
            TxtCodigo.Text = DataBinder.Eval(DataItem, "Codigo")
            TxtNombre.Text = DataBinder.Eval(DataItem, "Nombre")
            TxtDesc.Text = DataBinder.Eval(DataItem, "Descripcion")
        End If
    End Sub

    Private Sub Limpiar_Campos()
        TxtIdComponente.Text = ""
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtDesc.Text = ""
    End Sub

End Class