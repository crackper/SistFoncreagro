Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI

Public Class ControlProyectoInformes
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
            FileUploadControl.Visible = True
            HFIdArchivo.Value = ""
        Else
            HFIdInforme.Value = DataBinder.Eval(DataItem, "IdInfProy")
            CbTipo.Text = DataBinder.Eval(DataItem, "Tipo")
            CbEstado.Text = DataBinder.Eval(DataItem, "Estado")
            RDFeProg.SelectedDate = DataBinder.Eval(DataItem, "FechaProg")
            RDFePres.SelectedDate = DataBinder.Eval(DataItem, "FechaPresen")
            If DataBinder.Eval(DataItem, "IdAdjMonit") = 0 Then HFIdArchivo.Value = "" Else HFIdArchivo.Value = DataBinder.Eval(DataItem, "IdAdjMonit")
            RGArchivo.DataBind()
            'Dim _Adjunto As AdjMonit
            'Dim _AdjuntoBL As AdjMonitBL
            '_Adjunto = _AdjuntoBL.GetADJMONITByIdAdjMonit(_e)
            If RGArchivo.Items.Count = 0 Then
                FileUploadControl.Visible = True
                RGArchivo.Visible = False
            Else
                FileUploadControl.Visible = False
                RGArchivo.Visible = True
            End If
        End If
    End Sub

    Private Sub Limpiar_Campos()
        CbTipo.Text = "MENSUAL"
        CbEstado.Text = "PENDIENTE"
        RDFeProg.Clear()
        RDFePres.Clear()
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click
        Call Grabar_Informe()
    End Sub

    Private Sub Grabar_Informe()
        Dim _InformeBL As New InformeProyectoBL
        Dim _Informe As New InformeProyecto
        Dim miId As String
        miId = Request.QueryString("IdProyecto")
        If HFIdInforme.Value <> "" Then _Informe.IdInfProy = Integer.Parse(HFIdInforme.Value)
        _Informe.IdProyecto = Integer.Parse(miId)
        _Informe.Tipo = CbTipo.Text
        If Len(RDFeProg.SelectedDate) = 0 Then _Informe.FechaProg = Nothing Else _Informe.FechaProg = DateValue(RDFeProg.SelectedDate)
        If Len(RDFePres.SelectedDate) = 0 Then _Informe.FechaPresen = Nothing Else _Informe.FechaPresen = DateValue(RDFePres.SelectedDate)
        _Informe.Estado = CbEstado.Text
        If FileUploadControl.FileName <> "" And HFIdArchivo.Value = "" Then
            HFIdInforme.Value = _InformeBL.SaveInformeProyecto(_Informe)
            _Informe.IdInfProy = Integer.Parse(HFIdInforme.Value)
            Call SaveFile(FileUploadControl.PostedFile, "INFORMEPROYECTO", "InformesProyecto", Integer.Parse(HFIdInforme.Value), "")
            FileUploadControl.Visible = False
            RGArchivo.DataBind()
            RGArchivo.Visible = True
        End If
        _Informe.IdAdjMonit = Integer.Parse(HFIdArchivo.Value)
        HFIdInforme.Value = _InformeBL.SaveInformeProyecto(_Informe)
        
        Response.Redirect("~\Monitoreo\Formularios\FrmProyectoInformes.aspx?IdProyecto=" + miId)
    End Sub

    Private Sub SaveFile(ByVal file As HttpPostedFile, ByVal mTabla As String, ByVal CarpetaDestino As String, ByVal mIdTabla As Int32, ByVal mDesArchivo As String)

        Dim savePath As String = Server.MapPath("~\Archivos\Monitoreo\" + CarpetaDestino + "\")

        Dim fileName As String = FileUploadControl.FileName

        Dim pathToCheck As String = savePath + fileName

        Dim tempfileName As String
        tempfileName = ""

        If (System.IO.File.Exists(pathToCheck)) Then
            Dim counter As Integer = 2
            While (System.IO.File.Exists(pathToCheck))
                tempfileName = counter.ToString() + fileName
                pathToCheck = savePath + tempfileName
                counter = counter + 1
            End While

            fileName = tempfileName
        End If

        savePath += fileName
        FileUploadControl.SaveAs(savePath)

        Adjunto_BD(fileName, 0, mTabla, mIdTabla, mDesArchivo)
    End Sub

    Private Sub Adjunto_BD(ByVal mRuta As String, ByVal mIdAjunto As Int32, ByVal mTabla As String, ByVal mIdTabla As Int32, ByVal mDesArchivo As String)
        Dim AdjuntoBL As New AdjMonitBL
        Dim mAdjunto As New AdjMonit
        Dim IdAdj As Integer
        If mIdAjunto <> 0 Then mAdjunto.IdAdjMonit = mIdAjunto

        mAdjunto.Id = mIdTabla
        mAdjunto.Tabla = mTabla
        mAdjunto.Ruta = mRuta
        mAdjunto.Descripcion = mDesArchivo
        mAdjunto.Fecha = DateValue(Date.Now)
        IdAdj = AdjuntoBL.SaveAdjMonit(mAdjunto)
        HFIdArchivo.Value = IdAdj
    End Sub

    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelar.Click
        Dim miId As String
        miId = Request.QueryString("IdProyecto")
        Response.Redirect("~\Monitoreo\Formularios\FrmProyectoInformes.aspx?IdProyecto=" + miId)
    End Sub

    Protected Sub RGArchivo_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGArchivo.ItemCommand
        If e.CommandName = "Borrar" Then
            Dim _Archivo As String
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            _Archivo = RGArchivo.Items(editeditem.ItemIndex)("Archivo").Text
            Dim archivo As String = (Server.MapPath("~\Monitoreo\Archivos\InformesProyecto\" + _Archivo))
            Try
                My.Computer.FileSystem.DeleteFile(archivo)
                Dim _ArchivoBL As New AdjMonitBL
                _ArchivoBL.DeleteAdjMonit(Integer.Parse(HFIdArchivo.Value))
                RGArchivo.DataBind()
                RGArchivo.Visible = False
                FileUploadControl.Visible = True
                FileUploadControl.Dispose()
                HFIdArchivo.Value = "0"
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            End Try
            Call Grabar_Informe()
        End If
    End Sub
End Class