Imports SistFoncreagro.BussinesLogic
Public Class VentanaAdjuntarArchivo
    Inherits System.Web.UI.Page
    Dim archivo As String
    Dim origen As String
    Dim IdContrato As Integer
    Dim IdPeriodoLaboral As Integer
    Dim contratoBL As New ContratoConvenioBL
    Dim IdPersonal As Integer
    Dim BL As New PersonalBL
    Dim archivoFoto As String
    Dim archivoCV As String
    Dim archivoContrato As String
    Dim archivoTS As String
    Dim archivoAdenda As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim arraySession2 As New Collection
        arraySession2 = Session("persona")

        If Not arraySession2 Is Nothing Then
            archivoFoto = arraySession2("archivoFoto")
            archivoCV = arraySession2("archivoCV")
            archivoContrato = arraySession2("archivoContrato")
            archivoTS = arraySession2("ArchivoTS")
        End If

        origen = Request.QueryString("origen")
        IdContrato = Session("IdContrato")
        IdPeriodoLaboral = Session("IdPeriodoLaboral")
        IdPersonal = Session("IdPersonal")

        Select Case (origen)
            Case "contrato"
                Me.lblAdjuntar.Text = "Adjuntar contrato"
                archivoContrato = contratoBL.GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato(IdPeriodoLaboral, IdContrato)
            Case "certificadoTS"
                Me.lblAdjuntar.Text = "Adjuntar certificado de tipo de sangre"
                archivoContrato = BL.GetCertificadoTipoSangrePERSONALByIdPersonal(IdPersonal)
            Case "adenda"
        End Select

        If Not Page.IsPostBack Then

            lblArchivo.Text = archivoContrato

            If String.IsNullOrEmpty(archivoContrato) Then
                Me.PanelFoto.Visible = False
            Else
                Me.PanelFoto.Visible = True
            End If
        End If
    End Sub

    Protected Sub btnAdjuntarArchivo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAdjuntarArchivo.Click
        If Not String.IsNullOrEmpty(origen) Then
            Dim fileExt As String
            Dim arraySession As New Collection
            'Dim archivoG As String
            'Dim arraySession1 As New Collection
            fileExt = System.IO.Path.GetExtension(FileUploadControl.FileName)

            Select Case (origen)
                Case "contrato"
                    If (fileExt = ".doc" Or fileExt = ".docx" Or fileExt = ".pdf") Then
                        archivo = SaveFile(FileUploadControl.PostedFile, "~\Archivos\RRHH\Contratos\", "C")
                        If Not String.IsNullOrEmpty(archivo) Then
                            Try
                                contratoBL.UpdateArchivoContratos(IdPeriodoLaboral, IdContrato, archivo)
                                'PersonalBL.UpdateArchivoCertificadoTipoSangre(archivo, )
                                ' que salga un mensaje flotante

                                'arraySession.Add(IdPersonal, "IdPersonal")

                                arraySession.Add(archivo, "archivoContrato")
                                arraySession.Add(archivoTS, "ArchivoTS")
                                'arraySession.Add(archivoAdenda, "ArchivoAdenda")
                                arraySession.Add(archivoFoto, "archivoFoto")
                                arraySession.Add(archivoCV, "archivoCV")

                                Session("persona") = arraySession

                                Me.lblMsnFoto.Text = "Se reemplazó el archivo"
                                Me.lblArchivo.Text = archivo
                                Me.PanelFoto.Visible = True
                            Catch ex As Exception
                                Me.lblMsnFoto.Visible = True
                                Me.lblMsnFoto.Text = "No se pudo actualizar la BD, intentelo luego"
                            End Try
                        Else
                            Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                            Me.lblMsnFoto.Text = "No se pudo adjuntar el archivo, Inténtelo luego si el problema persiste comuníquese con el administrador de sus Sistema"
                        End If
                    Else
                        Me.lblMsnFoto.Visible = True
                        Me.lblMsnFoto.Text = "Solo se permiten archivos de formato .doc, .docx o .pdf"
                    End If
                Case "adenda"

                    'arraySession.Add(IdPersonal, "IdPersonal")
                    'arraySession.Add(archivoContrato, "ArchivoAdenda")
                    'arraySession.Add("", "archivoContrato")
                    'arraySession.Add("", "ArchivoTS")
                    'Session("persona") = arraySession

                Case "certificadoTS"
                    If (fileExt = ".pdf") Then
                        archivo = SaveFile(FileUploadControl.PostedFile, "~\Archivos\RRHH\CertificadosTS\", "TS")
                        If Not String.IsNullOrEmpty(archivo) Then

                            Try
                                BL.UpdateArchivoCertificadoTipoSangre(archivo, IdPersonal)
                                'PersonalBL.UpdateArchivoCertificadoTipoSangre(archivo, )
                                ' que salga un mensaje flotante
                                'arraySession.Add(IdPersonal, "IdPersonal")
                                arraySession.Add(archivoContrato, "ArchivoTS")
                                arraySession.Add(archivoContrato, "archivoContrato")
                                arraySession.Add(archivoFoto, "archivoFoto")
                                arraySession.Add(archivoCV, "archivoCV")
                                'arraySession.Add(archivoAdenda, "ArchivoAdenda")
                                Session("persona") = arraySession

                                Me.lblMsnFoto.Text = "Se reemplazó el archivo"
                                Me.lblArchivo.Text = archivo
                                Me.PanelFoto.Visible = True
                            Catch ex As Exception
                                Me.lblMsnFoto.Visible = True
                                Me.lblMsnFoto.Text = "No se pudo actualizar la BD, intentelo luego"
                            End Try
                        Else
                            Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                            Me.lblMsnFoto.Text = "No se pudo adjuntar el archivo, Inténtelo luego si el problema persiste comuníquese con el administrador de sus Sistema"
                        End If
                    Else
                        Me.lblMsnFoto.Visible = True
                        Me.lblMsnFoto.Text = "Solo se permiten archivos de formato pdf"
                    End If

            End Select

        End If
    End Sub

    Function SaveFile(ByVal file As HttpPostedFile, ByVal ruta As String, ByVal nombre As String) As String

        Dim savePath As String = Server.MapPath(ruta)
        Dim cad() As String
        Dim cad2() As String
        Dim l As Integer = 0


        If nombre = "C" Then
            If Not String.IsNullOrEmpty(lblArchivo.Text) Then
                'personalBL.UpdateFotoPERSONAL(IdPersonal, Nothing)
                My.Computer.FileSystem.DeleteFile(savePath + Me.lblArchivo.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                cad = Split(lblArchivo.Text, ".")
                cad2 = Split(cad(0), "_")

                l = Right(cad(0), 1)

                If Not String.IsNullOrEmpty(cad2(1)) Then
                    l = CInt(cad2(1)) + 1
                End If

                If l > 999 Then
                    l = 0
                End If
            End If
        Else
            'If nombre = "TS" Then
            '    If Not String.IsNullOrEmpty(lblArchivo.Text) Then
            '        My.Computer.FileSystem.DeleteFile(savePath + Me.lblArchivo.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            '        cad = Split(lblArchivo.Text, ".")
            '        cad2 = Split(cad(0), "_")

            '        l = Right(cad(0), 1)

            '        If Not String.IsNullOrEmpty(cad2(1)) Then
            '            l = CInt(cad2(1)) + 1
            '        End If

            '        If l > 999 Then
            '            l = 0
            '        End If
            '    End If
            'End If
        End If
        nombre += Today.Year.ToString & Today.Month.ToString & Today.Day.ToString & "-" & IdPersonal.ToString & "_" & l & System.IO.Path.GetExtension(FileUploadControl.FileName)
        'nombre += Today.Year.ToString & Today.Month.ToString & Today.Day.ToString & IdPeriodoLaboral & IdContrato.ToString & System.IO.Path.GetExtension(FileUploadControl.FileName)
        savePath += "\" + nombre
        'Guarda archivo
        Try
            FileUploadControl.SaveAs(savePath)
            Return nombre
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Protected Sub btnEliminarFoto_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminarFoto.Click
        Dim archivoElim As String = ""
        Dim arraySession1 As New Collection
        'Dim archivo As String = (Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))
        Try
            Select Case (origen)
                Case "contrato"
                    archivoElim = (Server.MapPath("~\Archivos\RRHH\Contratos\" + Me.lblArchivo.Text))
                    contratoBL.UpdateArchivoContratos(IdPeriodoLaboral, IdContrato, "")

                    'arraySession.Add(IdPersonal, "IdPersonal")
                    arraySession1.Add("", "archivoContrato")
                    arraySession1.Add(archivoTS, "ArchivoTS")
                    arraySession1.Add(archivoFoto, "archivoFoto")
                    arraySession1.Add(archivoCV, "archivoCV")
                    'arraySession1.Add("", "ArchivoAdenda")
                    Session("persona") = arraySession1

                Case "certificadoTS"
                    archivoElim = (Server.MapPath("~\Archivos\RRHH\CertificadosTS\" + Me.lblArchivo.Text))
                    BL.UpdateArchivoCertificadoTipoSangre("", IdPersonal)

                    'arraySession.Add(IdPersonal, "IdPersonal")
                    arraySession1.Add("", "archivoTS")
                    arraySession1.Add(archivoTS, "archivoContrato")
                    arraySession1.Add(archivoFoto, "archivoFoto")
                    arraySession1.Add(archivoCV, "archivoCV")
                    'arraySession1.Add("", "ArchivoAdenda")
                    Session("persona") = arraySession1

                Case "adenda"
            End Select


            Try
                My.Computer.FileSystem.DeleteFile(archivoElim, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                Me.lblMsnFoto.Visible = True
                Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                Me.lblMsnFoto.Text = "Archivo Eliminado"

                Me.PanelFoto.Visible = False
                Me.lblArchivo.Text = ""

            Catch ex As Exception
                Me.lblMsnFoto.Visible = True
                Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                Me.lblMsnFoto.Text = "No se pudo eliminar el archivo, intentelo luego"
            End Try
        Catch ex As Exception
            Me.lblMsnFoto.Visible = True
            Me.lblMsnFoto.ForeColor = Drawing.Color.Red
            Me.lblMsnFoto.Text = "No se pudo actualizar la BD, intentelo luego"
        End Try
    End Sub

    Protected Sub btnAbrirFoto_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbrirFoto.Click
        Dim myFile As ProcessStartInfo = New ProcessStartInfo()

        Select (origen)
            Case "contrato"
                myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\Contratos\" + lblArchivo.Text))
            Case "certificadoTS"
                myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\CertificadosTS\" + lblArchivo.Text))
            Case "adenda"

                'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

        End Select
        'Abre archivo
        Process.Start(myFile)
    End Sub
End Class

