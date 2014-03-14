Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class ControlConveMarco
    Inherits System.Web.UI.UserControl

    Private _dataItem As Object = Nothing
    Dim ConveMarcoBL As New ConveMarcoBL
    Dim _ConveMarco As ConveMarco
    Dim mConveMarco As New ConveMarco
    Dim IdConveMarco As String

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

        Else
            Me.TxtIdTabla.Text = DataBinder.Eval(DataItem, "IdConveMarco")
            Me.TxtCodigo.Text = DataBinder.Eval(DataItem, "Codigo")
            Me.TxtNombre.Text = DataBinder.Eval(DataItem, "Nombre")
        End If
    End Sub

    Sub SaveFile(ByVal file As HttpPostedFile, ByVal mTabla As String, ByVal CarpetaDestino As String)

        Dim savePath As String = Server.MapPath("~\Monitoreo\Archivos\" + CarpetaDestino + "\")

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

        Adjunto_BD(fileName, 0, mTabla)
    End Sub

    Private Sub Adjunto_BD(ByVal mRuta As String, ByVal mIdAjunto As Int32, ByVal mTabla As String)
        Dim AdjuntoBL As New AdjMonitBL
        Dim mAdjunto As New AdjMonit
        Dim IdAdj As Integer
        If mIdAjunto <> 0 Then mAdjunto.IdAdjMonit = mIdAjunto

        mAdjunto.Id = CInt(TxtIdTabla.Text)
        mAdjunto.Tabla = mTabla
        mAdjunto.Ruta = mRuta
        mAdjunto.Descripcion = UCase(TxtDescAdj.Text)
        mAdjunto.Fecha = DateValue(Date.Now)
        IdAdj = AdjuntoBL.SaveAdjMonit(mAdjunto)
    End Sub

    Protected Sub BtnNuevoAdj_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnNuevoAdj.Click
        If TxtIdTabla.Text <> "" Then
            TxtIdAdj.Text = "0"
            TxtDescAdj.Text = ""
            StatusLabel.Text = ""
            StatusLabel.Visible = True
        Else
            Grabar_ConveMarco()
        End If
        Panel1.Visible = True
        BtnActualizarAdj.Visible = False
        UploadButton.Visible = True
        FileUploadControl.Enabled = True
        BtnAbrirArchivo.Visible = False
    End Sub

    Private Sub Grabar_ConveMarco()
        Dim ConveMarcoBL As New ConveMarcoBL
        Dim nConveMarco As New ConveMarco

        Dim cadena_java As String
        Dim idConvenioMarco As Int32

        nConveMarco.Codigo = UCase(TxtCodigo.Text)
        nConveMarco.Nombre = UCase(TxtNombre.Text)

        idConvenioMarco = ConveMarcoBL.SaveConveMarco(nConveMarco)
        TxtIdTabla.Text = idConvenioMarco

        cadena_java = "<script type='text/javascript'> " & _
                          " CerrarControl(" & Convert.ToString(idConvenioMarco) & "); " & _
                          Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

    Protected Sub CtnCancelarAdj_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles CtnCancelarAdj.Click
        Panel1.Visible = False
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.SelectedIndexChanged
        TxtIdAdj.Text = GridView1.SelectedValue
        Panel1.Visible = True

        Dim AdjuntoBL As New AdjMonitBL
        Dim mAdjunto As New AdjMonit
        mAdjunto = AdjuntoBL.GetADJMONITByIdAdjMonit(CInt(TxtIdAdj.Text))
        TxtDescAdj.Text = mAdjunto.Descripcion
        StatusLabel.Text = mAdjunto.Ruta
        StatusLabel.Font.Bold = True
        FileUploadControl.Visible = False
        BtnActualizarAdj.Visible = True
        UploadButton.Visible = False
        BtnAbrirArchivo.Visible = True
    End Sub

    Protected Sub BtnActualizarAdj_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnActualizarAdj.Click
        Adjunto_BD(StatusLabel.Text, CInt(TxtIdAdj.Text), "CONVEMARCO")
        GridView1.DataBind()
        Panel1.Visible = False
    End Sub

    Protected Sub BtnAbrirArchivo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnAbrirArchivo.Click
        If StatusLabel.Text = "" Then Exit Sub
        Dim myFile As ProcessStartInfo
        myFile = New ProcessStartInfo(Server.MapPath("~\Monitoreo\Archivos\ConvenioMarco\" + StatusLabel.Text))
        Process.Start(myFile)

    End Sub

    Protected Sub BtnEliminarAdj_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnEliminarAdj.Click

        Dim archivo As String = (Server.MapPath("~\Monitoreo\Archivos\ConvenioMarco\" + StatusLabel.Text))

        Try
            My.Computer.FileSystem.DeleteFile(archivo, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Dim AdjuntoBL As New AdjMonitBL
            AdjuntoBL.DeleteAdjMonit(CInt(TxtIdAdj.Text))
            GridView1.DataBind()
            Panel1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Protected Sub UploadButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles UploadButton.Click
        SaveFile(FileUploadControl.PostedFile, "CONVEMARCO", "ConvenioMarco")
        GridView1.DataBind()
        Panel1.Visible = False
    End Sub

End Class