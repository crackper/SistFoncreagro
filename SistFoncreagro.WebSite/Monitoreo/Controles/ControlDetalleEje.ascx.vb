Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Collections
Imports System.Configuration
Imports System
Imports System.Web.UI
Imports System.IO
Public Class ControlDetalleEje
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Dim _ubigeo As UbigeoDatos
    Dim ubigeoBL As New UbigeoDatosBL
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
    End Sub
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then
            'Me.txtDate1.Text = Now
        Else
            _ubigeo = ubigeoBL.GetUbigeoDatosByIdUbigeoDatos(DataBinder.Eval(DataItem, "IdUbigeo"))
            Me.RadComboBox1.DataSourceID = "OdsUbigeo"
            Me.OdsUbigeo.SelectParameters("texto").DefaultValue = _ubigeo.Nombre
            Me.RadComboBox1.DataBind()
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdUbigeo")

            Me.TextBox8.Text = DataBinder.Eval(DataItem, "ClimaSocial")
            Me.DropDownList4.SelectedValue = DataBinder.Eval(DataItem, "ClimaSocial")
            Me.TextBox9.Text = DataBinder.Eval(DataItem, "NivelApoyo")
            Me.TextBox10.Text = DataBinder.Eval(DataItem, "Quejas")
            Me.TextBox11.Text = DataBinder.Eval(DataItem, "AccionesTomadas")
        End If
    End Sub
    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 2 Then
            Me.RadComboBox1.DataSourceID = "OdsUbigeo"
            Me.OdsUbigeo.SelectParameters("texto").DefaultValue = e.Text.ToString
            Me.RadComboBox1.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        'Dim Departamento As String
        Dim Provincia As String
        Dim Distrito As String
        Dim CPoblado As String
        Dim Caserio As String
        Dim Nivel As String

        'Departamento = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Departamento.ToString()
        Provincia = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Provincia.ToString()
        Distrito = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Distrito.ToString()
        CPoblado = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CentroPoblado.ToString()
        Caserio = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Caserio.ToString()
        Nivel = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).Nivel.ToString()

        e.Item.Text = Provincia + "-" + Distrito + "-" + CPoblado + "-" + Caserio + " (" + Nivel + ")"
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.UbigeoDatos)).CUBIGEO.ToString()
    End Sub
End Class