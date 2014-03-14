Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class Datos_Convenio
    Inherits System.Web.UI.UserControl

    Private _dataItem As Object = Nothing
    Dim ConvenioBL As New ConvenioBL
    Dim _Convenio As Convenio
    Dim Idconvenio As String

    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Idconvenio = Request.QueryString("Idconvenio")
        'Me..Filter = 1
        If TypeOf DataItem Is GridInsertionObject Then

        Else
            'If IsPostBack Then Exit Sub
            'If IsDBNull(Idconvenio) = True Then Exit Sub
            'If Idconvenio Is Nothing Then Exit Sub
            'If DataBinder.Eval(DataItem, "IdConvenio").ToString <> "" And DataBinder.Eval(DataItem, "IdConvenio").ToString <> "0" Then
            TxtNombre.Text = DataBinder.Eval(DataItem, "Nombre")
            TxtCodigo.Text = DataBinder.Eval(DataItem, "CodConv")
            TxtAlias.Text = DataBinder.Eval(DataItem, "AliasConv")
            TxtMontoIni.Text = DataBinder.Eval(DataItem, "MontoInicial")
            TxtTotal.Text = DataBinder.Eval(DataItem, "MontoTotal")
            CbFase.Text = DataBinder.Eval(DataItem, "FaseCont")
            CbEstado.Text = DataBinder.Eval(DataItem, "Estado")
            CbFase.Text = DataBinder.Eval(DataItem, "FaseCont")
            TxtFeFirma.Text = DataBinder.Eval(DataItem, "FechaFirma")
            TxtFeIni.Text = DataBinder.Eval(DataItem, "FecIni")
            TxtFeFin.Text = DataBinder.Eval(DataItem, "FecFin")
            TxtResponsable.Text = DataBinder.Eval(DataItem, "Responsable")
            'CbTipoConvenio.Text = DataBinder.Eval(DataItem, "")
            'CbFase.Text = DataBinder.Eval(DataItem, "FaseCont")
            'If Not IsDBNull(DataBinder.Eval(DataItem, "FechaFirma")) Then DtFeFirma.SelectedDate = DateValue(DataBinder.Eval(DataItem, "FechaFirma")) Else DtFeFirma.DbSelectedDate = vbNull
            'End If
        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click
        If TxtCodigo.Text = "" Then MsgBox("Ingrese el código", MsgBoxStyle.Critical, "Error") : Exit Sub
        If TxtNombre.Text = "" Then MsgBox("Ingrese el nombre", MsgBoxStyle.Critical, "Error") : Exit Sub
        If IsDBNull(CbFinanciador.DataValueField) Then MsgBox("Ingrese el financiador", MsgBoxStyle.Critical, "Error") : Exit Sub
    End Sub

End Class