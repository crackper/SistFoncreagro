Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class VentanaSubirFotoyCV
    Inherits System.Web.UI.Page
    Dim arraySession As New Collection
    Dim archivoFoto As String
    Dim archivoCV As String
    Dim IdPersonal As Int32
    Dim personalBL As New PersonalBL
    Dim archivo
    Dim archivoContrato As String
    Dim archivoTS As String
    Dim archivoAdenda As String
    'Enum ExtencionesImagenes
    '    jpg
    '    gif
    '    jpeg
    '    png
    '    bmp
    'End Enum

    'Enum ExtencionesCV
    '    doc
    '    docx
    '    pdf
    '    dot
    '    dotx
    'End Enum

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim arraySession As New Collection
        arraySession = Session("persona")
        'IdPersonal = arraySession("IdPersonal")

        IdPersonal = Session("IdPersonal")

        If Not arraySession Is Nothing Then
            'If arraySession.Count > 0 Then
            '    If Not String.IsNullOrEmpty(arraySession("IdPersonal").ToString) Then
            '        IdPersonal = arraySession("IdPersonal")
            '    End If
            'End If
            archivoFoto = arraySession("archivoFoto")
            archivoCV = arraySession("archivoCV")
            archivoContrato = arraySession("archivoContrato")
            archivoTS = arraySession("ArchivoTS")
            'archivoAdenda = arraySession("ArchivoAdenda")
        End If

        If Not Page.IsPostBack Then

            If Not String.IsNullOrEmpty(archivoFoto) Then
                Me.PanelFoto.Visible = True
                Me.lblFoto.Text = archivoFoto
                Me.lblMsnFoto.Visible = False
            Else
                Me.PanelFoto.Visible = False
                Me.lblFoto.Text = ""
                Me.lblMsnFoto.Text = "No existe ninguna foto cargada"
                Me.lblMsnFoto.Visible = True
            End If

            If Not String.IsNullOrEmpty(archivoCV) Then
                Me.PanelArchivo.Visible = True
                Me.lblCV.Text = archivoCV
                Me.lblMsnCV.Visible = False
            Else
                Me.PanelArchivo.Visible = False
                Me.lblCV.Text = ""
                Me.lblMsnCV.Text = "No existe ningún archivo de Curriculum cargado"
                Me.lblMsnCV.Visible = True
            End If
        End If
        btnAbriCv.Attributes.Add("onClick", "CargarVentana('" & lblCV.Text & "'); return false;")
        btnAbrirFoto.Attributes.Add("onClick", "CargarVentanaFoto('" & lblFoto.Text & "'); return false;")
    End Sub

    Protected Sub btnAdjuntarFoto_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAdjuntarFoto.Click
        Dim fileExt As String
        Dim archivo As String
        'Dim extencionesImagenes As New ExtencionesImagenes
        Dim arraySession1 As New Collection
        fileExt = System.IO.Path.GetExtension(FileUploadControl.FileName)

        ''If Not String.IsNullOrEmpty(fileExt) Then
        ''    If Not System.Enum.Parse(extencionesImagenes.GetType, Mid(fileExt, 2, fileExt.Length - 1)) Is Nothing Then
        ''        archivo = SaveFile(FileUploadControl.PostedFile, "~\RRHH\Adjuntos\Fotos", "foto", FileUploadControl)

        If (fileExt = ".gif" Or fileExt = ".jpg" Or fileExt = ".jpeg" Or fileExt = ".png" Or fileExt = ".bmp") Then
            archivo = SaveFile(FileUploadControl.PostedFile, "~\Archivos\RRHH\Fotos\", "foto", FileUploadControl)
            If Not String.IsNullOrEmpty(archivo) Then
                Me.PanelFoto.Visible = True
                Me.lblFoto.Text = archivo

                'arraySession1.Add(IdPersonal, "IdPersonal")
                arraySession1.Add(archivo, "archivoFoto")
                arraySession1.Add(archivoCV, "archivoCV")
                arraySession1.Add(archivoContrato, "archivoContrato")
                arraySession1.Add(archivoTS, "ArchivoTS")
                Session("persona") = arraySession1

                Try
                    personalBL.UpdateFotoPERSONAL(IdPersonal, archivo)
                    Me.lblMsnFoto.Visible = True
                    Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                    Me.lblMsnFoto.Text = "Se reemplazó la imagen"
                Catch ex As Exception
                    Me.lblMsnFoto.Visible = True
                    Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                    Me.lblMsnFoto.Text = "No se pudo actualizar la BD, intentelo luego"
                End Try
            Else
                Me.lblMsnFoto.Visible = True
                Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                Me.lblMsnFoto.Text = "No se pudo adjuntar foto, Inténtelo luego si el problema persiste comuníquese con el administrador de sus Sistema"
            End If
        Else
            Me.lblMsnFoto.Visible = True
            Me.lblMsnFoto.ForeColor = Drawing.Color.Red
            Me.lblMsnFoto.Text = "Solo se permiten archivos de formato .gif, .jpg, .bmp o .png"
        End If
    End Sub

    Protected Sub btnAdjuntarCV_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAdjuntarCV.Click
        Dim fileExt As String
        Dim archivo As String
        Dim arraySession1 As New Collection
        fileExt = System.IO.Path.GetExtension(FileUploadControl2.FileName)

        If (fileExt = ".doc" Or fileExt = ".docx" Or fileExt = ".pdf" Or fileExt = ".dot" Or fileExt = ".dotx") Then
            archivo = SaveFile(FileUploadControl2.PostedFile, "~\Archivos\RRHH\CV\", "cv", FileUploadControl2)
            'archivo = SaveFile(FileUploadControl2.PostedFile, "\RRHH\Adjuntos\CV", "cv", FileUploadControl2)
            Me.PanelArchivo.Visible = True
            Me.lblCV.Text = archivo

            'arraySession1.Add(IdPersonal, "IdPersonal")
            arraySession1.Add(archivoFoto, "archivoFoto")
            arraySession1.Add(archivo, "archivoCV")
            arraySession1.Add(archivoContrato, "archivoContrato")
            arraySession1.Add(archivoTS, "ArchivoTS")
            Session("persona") = arraySession1

            Try
                personalBL.UpdateCVPERSONAL(IdPersonal, archivo)
                Me.lblMsnCV.Visible = True
                Me.lblMsnCV.ForeColor = Drawing.Color.Red
                Me.lblMsnCV.Text = "Se reemplazó el archivo"
            Catch ex As Exception
                Me.lblMsnCV.Visible = True
                Me.lblMsnCV.ForeColor = Drawing.Color.Red
                Me.lblMsnCV.Text = "No se pudo actualizar la BD, intentelo luego"
            End Try
        Else
            Me.lblMsnCV.Visible = True
            Me.lblMsnCV.ForeColor = Drawing.Color.Red
            Me.lblMsnCV.Text = "Solo se permiten archivos de formato .doc, .docx, .pdf, .dot o .dotx"
        End If
    End Sub

    Function SaveFile(ByVal file As HttpPostedFile, ByVal ruta As String, ByVal nombre As String, ByVal objetoLoad As FileUpload) As String

        Dim savePath As String = Server.MapPath(ruta)
        'Dim savePath As String = Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\")
        'Dim fileName As String = FileUploadControl.FileName
        'Dim pathToCheck As String = savePath + fileName
        'Dim tempfileName As String
        Dim cad() As String
        Dim cad2() As String
        Dim l As Integer = 0
        'tempfileName = ""

        'If (System.IO.File.Exists(pathToCheck)) Then
        '    Dim counter As Integer = 2
        '    While (System.IO.File.Exists(pathToCheck))
        '        tempfileName = counter.ToString() + fileName
        '        pathToCheck = savePath + tempfileName
        '        counter = counter + 1
        '    End While

        '    fileName = tempfileName
        'End If
        If nombre = "foto" Then
            If Not String.IsNullOrEmpty(lblFoto.Text) Then
                'personalBL.UpdateFotoPERSONAL(IdPersonal, Nothing)

                If (System.IO.File.Exists(savePath + Me.lblFoto.Text)) Then
                    My.Computer.FileSystem.DeleteFile(savePath + Me.lblFoto.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                End If

                cad = Split(lblFoto.Text, ".")
                cad2 = Split(cad(0), "_")

                l = Right(cad(0), 1)

                If cad2.Length > 1 Then
                    If Not String.IsNullOrEmpty(cad2(1)) Then
                        l = CInt(cad2(1)) + 1
                    End If
                End If

                If l > 999 Then
                    l = 0
                End If
            End If
        Else
            If nombre = "cv" Then
                If Not String.IsNullOrEmpty(lblCV.Text) Then
                    My.Computer.FileSystem.DeleteFile(savePath + Me.lblCV.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                    cad = Split(lblCV.Text, ".")
                    cad2 = Split(cad(0), "_")

                    l = Right(cad(0), 1)

                    If Not String.IsNullOrEmpty(cad2(1)) Then
                        l = CInt(cad2(1)) + 1
                    End If

                    If l > 999 Then
                        l = 0
                    End If
                End If
            End If
        End If
        nombre += Today.Year.ToString & Today.Month.ToString & Today.Day.ToString & "-" & IdPersonal.ToString & "_" & l & System.IO.Path.GetExtension(objetoLoad.FileName)
        savePath += "\" + nombre

        'Guarda archivo
        Try
            'objetoLoad.SaveAs(savePath)
            objetoLoad.PostedFile.SaveAs(savePath)
            Return nombre
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Protected Sub btnEliminarFoto_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminarFoto.Click
        Dim archivoElim As String = (Server.MapPath("~\Archivos\RRHH\Fotos\" + Me.lblFoto.Text))
        Dim arraySession1 As New Collection
        'Dim archivo As String = (Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))
        Try
            personalBL.UpdateFotoPERSONAL(IdPersonal, Nothing)
            Try
                My.Computer.FileSystem.DeleteFile(archivoElim, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                Me.lblMsnFoto.Visible = True
                Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                Me.lblMsnFoto.Text = "Foto eliminada"

                Me.PanelFoto.Visible = False
                Me.lblFoto.Text = ""

                'arraySession1.Add(IdPersonal, "IdPersonal")
                arraySession1.Add("", "archivoFoto")
                arraySession1.Add(archivoCV, "archivoCV")
                arraySession1.Add(archivoContrato, "archivoContrato")
                arraySession1.Add(archivoTS, "ArchivoTS")

                Session("persona") = arraySession1

            Catch ex As Exception
                Me.lblMsnFoto.Visible = True
                Me.lblMsnFoto.ForeColor = Drawing.Color.Red
                Me.lblMsnFoto.Text = "No se pudo eliminar la foto, intentelo luego"
            End Try
        Catch ex As Exception
            Me.lblMsnFoto.Visible = True
            Me.lblMsnFoto.ForeColor = Drawing.Color.Red
            Me.lblMsnFoto.Text = "No se pudo actualizar la BD, intentelo luego"
        End Try
    End Sub

    Protected Sub btnEliminarCV_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminarCV.Click
        Dim archivoElim As String = (Server.MapPath("~\Archivos\RRHH\CV\" + Me.lblCV.Text))
        Dim arraySession1 As New Collection
        'Dim archivo As String = (Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))
        Try
            personalBL.UpdateFotoPERSONAL(IdPersonal, Nothing)
            Try
                My.Computer.FileSystem.DeleteFile(archivoElim, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                Me.lblMsnCV.Visible = True
                Me.lblMsnCV.ForeColor = Drawing.Color.Red
                Me.lblMsnCV.Text = "Archivo eliminada"

                Me.PanelArchivo.Visible = False
                Me.lblCV.Text = ""

                'arraySession1.Add(IdPersonal, "IdPersonal")
                arraySession1.Add(archivoFoto, "archivoFoto")
                arraySession1.Add("", "archivoCV")
                arraySession1.Add(archivoContrato, "archivoContrato")
                arraySession1.Add(archivoTS, "ArchivoTS")

                Session("persona") = arraySession1

            Catch ex As Exception
                Me.lblMsnCV.Visible = True
                Me.lblMsnCV.ForeColor = Drawing.Color.Red
                Me.lblMsnCV.Text = "No se pudo eliminar el archivo, intentelo luego"
            End Try
        Catch ex As Exception
            Me.lblMsnCV.Visible = True
            Me.lblMsnCV.ForeColor = Drawing.Color.Red
            Me.lblMsnCV.Text = "No se pudo actualizar la BD, intentelo luego"
        End Try
    End Sub

    'Protected Sub btnAbrirFoto_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbrirFoto.Click
    '    Dim myFile As ProcessStartInfo

    '    myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\Fotos\" + lblFoto.Text))
    '    'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

    '    'Abre archivo
    '    Process.Start(myFile)
    'End Sub

    'Protected Sub btnAbriCv_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbriCv.Click
    '    Dim myFile As ProcessStartInfo

    '    myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\CV\" + lblCV.Text))
    '    'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

    '    'Abre archivo
    '    Process.Start(myFile)
    'End Sub
End Class