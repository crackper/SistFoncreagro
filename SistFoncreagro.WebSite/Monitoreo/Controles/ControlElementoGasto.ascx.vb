Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class ControlElementoGasto
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
            TxtIdElemGasto.Text = DataBinder.Eval(DataItem, "IdElemGasto")
            TxtCodigo.Text = DataBinder.Eval(DataItem, "CodElemGasto")
            TxtNombre.Text = DataBinder.Eval(DataItem, "NomElemGasto")
            TxtDesc.Text = DataBinder.Eval(DataItem, "DesElemGasto")
            CbClasificacion.SelectedValue = DataBinder.Eval(DataItem, "IdClasificacion")
        End If
    End Sub

    Private Sub Limpiar_Campos()
        TxtIdElemGasto.Text = ""
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtDesc.Text = ""
        CbClasificacion.SelectedValue = ""
    End Sub

End Class