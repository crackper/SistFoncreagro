Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI

Public Class FrmDatosProyecto
    Inherits System.Web.UI.Page
    Private _dataItem As Object = Nothing
    Dim ProyectoBL As New proyectoBL
    Dim _Proyecto As Proyecto
    Dim nProyecto As New Proyecto
    Dim DesemBL As New DesembolsoBL
    Dim nDesem As New Desembolso
    Dim _Desem As Desembolso
    Dim IdProyecto As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim miId As String
        miId = Request.QueryString("IdProyecto")
        HFIdProyecto.Value = miId

        If Not Me.Page.IsPostBack Then
            If miId = "0" Then
                'campos vacios
                TxtNombre.Text = ""
                TxtCodigo.Text = ""
                CbAlineamiento.Text = "<vacio>"
                CbPrograma.Text = "<vacio>"
                cbEstado.Text = "IMPLEMENTACION"
                DtIniProg.SelectedDate = DateValue("01/01/1985")
                DtIniReal.SelectedDate = DateValue("01/01/1985")
                DtFinProg.SelectedDate = DateValue("01/01/1985")
                DtFinReal.SelectedDate = DateValue("01/01/1985")
            Else
                Call Llenar_Datos_Proyecto(miId)
            End If
        End If
    End Sub

    Private Sub Llenar_Datos_Proyecto(ByVal mIdProyecto As Int32)
        nProyecto = ProyectoBL.GetFromProyectoByIdProyecto(mIdProyecto)

        TxtCodigo.Text = nProyecto.Codigo
        TxtNombre.Text = nProyecto.Nombre
        If IsDBNull(nProyecto.Alineamiento) Then CbAlineamiento.Text = "VACIO" Else CbAlineamiento.Text = nProyecto.Alineamiento
        If IsDBNull(nProyecto.Programa) Then CbPrograma.Text = "VACIO" Else CbPrograma.Text = nProyecto.Programa
        cbEstado.Text = nProyecto.Estado
        TxtCodAdic.Text = nProyecto.CodigoAdicional
        TxtAlias.Text = nProyecto.AliasProy
        CbResponsable.SelectedValue = nProyecto.IdResponsable
        If nProyecto.IniProyProg.HasValue = False Then DtIniProg.Clear() Else DtIniProg.SelectedDate = DateValue(nProyecto.IniProyProg)
        If nProyecto.IniProyReal.HasValue = False Then DtIniReal.Clear() Else DtIniReal.SelectedDate = DateValue(nProyecto.IniProyReal)
        If nProyecto.FinProyProg.HasValue = False Then DtFinProg.Clear() Else DtFinProg.SelectedDate = DateValue(nProyecto.FinProyProg)
        If nProyecto.FinProyReal.HasValue = False Then DtFinReal.Clear() Else DtFinReal.SelectedDate = DateValue(nProyecto.FinProyReal)
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click
        Call Grabar_Proyecto()
        Response.Redirect("~\Monitoreo\Formularios\FrmBuscarProyecto.aspx")
    End Sub

    Private Sub Grabar_Proyecto()
        'If TxtCodigo.Text = "" Then MsgBox("Ingrese el código del Proyecto", vbCritical, "Error") : Exit Sub
        If TxtNombre.Text = "" Then RWMensajes.RadAlert("Ingrese el nombre del proyecto", 200, 150, "Error", "") : Exit Sub
        If TxtAlias.Text = "" Then RWMensajes.RadAlert("Ingrese el alias del proyecto", 200, 150, "Error", "") : Exit Sub

        Dim miId As String
        miId = Request.QueryString("IdProyecto")
        If miId <> "0" Then
            nProyecto.IdProyecto = CInt(miId)
        End If

        'nProyecto.Codigo = UCase(TxtCodigo.Text)
        nProyecto.Nombre = UCase(TxtNombre.Text)
        If CbAlineamiento.Text = "VACIO" Then nProyecto.Alineamiento = "" Else nProyecto.Alineamiento = CbAlineamiento.Text
        If CbPrograma.Text = "VACIO" Then nProyecto.Programa = "" Else nProyecto.Programa = CbPrograma.Text
        nProyecto.Estado = cbEstado.Text
        nProyecto.IdResponsable = CbResponsable.SelectedValue
        If Len(DtIniProg.SelectedDate) = 0 Then nProyecto.IniProyProg = Nothing Else nProyecto.IniProyProg = DateValue(DtIniProg.SelectedDate)
        'If Len(DtIniReal.SelectedDate) = 0 Then nProyecto.IniProyReal = Nothing Else nProyecto.IniProyReal = DateValue(DtIniReal.SelectedDate)
        If Len(DtFinProg.SelectedDate) = 0 Then nProyecto.FinProyProg = Nothing Else nProyecto.FinProyProg = DateValue(DtFinProg.SelectedDate)
        'If Len(DtFinReal.SelectedDate) = 0 Then nProyecto.FinProyReal = Nothing Else nProyecto.FinProyReal = DateValue(DtFinReal.SelectedDate)
        nProyecto.CodigoAdicional = Trim(TxtCodAdic.Text)
        nProyecto.AliasProy = Trim(TxtAlias.Text)
        miId = ProyectoBL.SaveProyecto(nProyecto)
        HFIdProyecto.Value = miId
    End Sub

    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelar.Click
        Response.Redirect("~\Monitoreo\Formularios\FrmBuscarProyecto.aspx")
    End Sub

    Private Sub GVAdjuntos_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVAdjuntos.RowCommand
        If e.CommandName = "Ver" Then
            Dim id As String
            id = Convert.ToString(GVAdjuntos.DataKeys(Convert.ToUInt32(e.CommandArgument)).Value)
            Dim _Archivo As String
            Dim _Adj As New AdjMonit
            Dim _adjBL As New AdjMonitBL
            _Adj = _adjBL.GetADJMONITByIdAdjMonit(Integer.Parse(id))
            _Archivo = _Adj.Ruta
            Dim myFile As ProcessStartInfo
            myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\Monitoreo\Proyecto\" + _Archivo))
            Process.Start(myFile)
        End If
    End Sub

    Private Sub GVAdjuntos_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles GVAdjuntos.RowEditing
        Dim miId As Int32
        miId = Integer.Parse(GVAdjuntos.DataKeys(e.NewEditIndex).Values("IdAdjMonit"))
        e.Cancel = True
        Dim _AdjBL As New AdjMonitBL
        Dim _Adj As New AdjMonit
        _Adj = _AdjBL.GetADJMONITByIdAdjMonit(miId)
        Dim NomArch As String = _Adj.Ruta
        Dim archivo As String = (Server.MapPath("~\Archivos\Monitoreo\Proyecto\" + NomArch))
        
        Try
            My.Computer.FileSystem.DeleteFile(archivo)
            _AdjBL.DeleteAdjMonit(miId)
            GVAdjuntos.DataBind()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GVAdjuntos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVAdjuntos.SelectedIndexChanged
        HFIdArchivo.Value = GVAdjuntos.SelectedDataKey.Value.ToString()
        TxtDescAdj.Text = GVAdjuntos.SelectedRow.Cells(4).Text
        FileUploadControl.Visible = False
        Panel1.Visible = True
        BtnActualArch.Visible = True
        BtnAdjuntar.Visible = False
    End Sub

    Protected Sub BtnNuevoAdj_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnNuevoAdj.Click
        Panel1.Visible = True
        BtnActualArch.Visible = False
        BtnAdjuntar.Visible = True
        HFIdArchivo.Value = "0"
    End Sub

    Protected Sub BtnGrabarAdj_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnAdjuntar.Click
        If HFIdProyecto.Value = "0" Then Call Grabar_Proyecto()
        If FileUploadControl.FileName = "" Then RWMMensajes.RadAlert("Ingrese el archivo", 150, 100, "Archivos", "") : Exit Sub
        If HFIdArchivo.Value = "0" Then

        End If
        If FileUploadControl.FileName <> "" And HFIdArchivo.Value = "0" Then
            Call SaveFile(FileUploadControl.PostedFile, "PROYECTO", "Proyecto", Integer.Parse(HFIdProyecto.Value), TxtDescAdj.Text)
            BtnAdjuntar.Visible = True
            GVAdjuntos.DataBind()
            Panel1.Visible = False
        End If
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
        mAdjunto.Descripcion = UCase(mDesArchivo)
        mAdjunto.Fecha = DateValue(Date.Now)
        IdAdj = AdjuntoBL.SaveAdjMonit(mAdjunto)
        HFIdArchivo.Value = IdAdj
    End Sub

    Protected Sub BtnCancelAdj_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelAdj.Click
        Dim miId As String
        miId = Request.QueryString("IdProyecto")
        Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=" + miId)
    End Sub

    Protected Sub BtnActualArch_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnActualArch.Click
        Dim AdjuntoBL As New AdjMonitBL
        Dim mAdjunto As New AdjMonit
        mAdjunto.IdAdjMonit = Integer.Parse(HFIdArchivo.Value)
        mAdjunto.Descripcion = UCase(TxtDescAdj.Text)
        AdjuntoBL.SaveAdjMonit(mAdjunto)
        GVAdjuntos.DataBind()
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        If HFIdProyecto.Value = "" Then RWMensajes.RadAlert("Grabe el proyecto un proyecto", 230, 100, "Error", "") : Exit Sub
        Select Case e.Item.Value
            Case "Datos"
                Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Convenio"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoConvenio.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Componentes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoComponentes.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Actividades"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoActividad.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "CCostos"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoCCosto.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Ambito"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAmbito.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "Informes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoInformes.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "ForFin"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuesto.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "ForAnual"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuestoAnual.aspx?IdProyecto=" + HFIdProyecto.Value)

            Case "AvanFis"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAvanceFisico.aspx?IdProyecto=" + HFIdProyecto.Value)
        End Select
    End Sub
End Class