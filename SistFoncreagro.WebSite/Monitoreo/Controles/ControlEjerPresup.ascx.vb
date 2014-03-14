Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class ControlEjerPresup
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
            Call Limpiar_Campos()
        Else
            CbTipo.Text = DataBinder.Eval(DataItem, "Tipo")
            TxtCodigo.Text = DataBinder.Eval(DataItem, "Codigo")
            If (DataBinder.Eval(DataItem, "FechaInicio")) = Nothing Then RDIni.Clear() Else RDIni.SelectedDate = DateValue(DataBinder.Eval(DataItem, "FechaInicio"))
            If (DataBinder.Eval(DataItem, "FechaFin")) = Nothing Then RDFin.Clear() Else RDFin.SelectedDate = DateValue(DataBinder.Eval(DataItem, "FechaFin"))
            CbEstado.Text = DataBinder.Eval(DataItem, "Estado")
            TxtAnio.Text = DataBinder.Eval(DataItem, "Anio")
        End If
    End Sub

    Private Sub Limpiar_Campos()
        CbTipo.Text = "BUDGET"
        TxtCodigo.Text = ""
        RDIni.Clear()
        RDFin.Clear()
        TxtAnio.Text = ""
    End Sub

End Class