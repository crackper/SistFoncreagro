Imports SistFoncreagro.BussinesLogic
Public Class VentanaAdjuntarCertificadoTipoSangre
    Inherits System.Web.UI.Page
    Dim archivo As String
    Dim origen As String
    Dim IdContrato As Integer
    Dim IdPersonal As Integer
    Dim archivoG As String
    Dim BL As New PersonalBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdPersonal = Session("IdPersonal")

        archivoG = BL.GetCertificadoTipoSangrePERSONALByIdPersonal(IdPersonal)

        If Not Page.IsPostBack Then

            lblArchivo.Text = archivoG

            If String.IsNullOrEmpty(archivoG) Then
                Me.PanelFoto.Visible = False
            Else
                Me.PanelFoto.Visible = True
            End If
        End If

    End Sub

    Protected Sub btnAdjuntarArchivo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAdjuntarArchivo.Click
        If Not String.IsNullOrEmpty(origen) Then
            Dim fileExt As String
            'Dim archivoG As String
            'Dim arraySession1 As New Collection
            fileExt = System.IO.Path.GetExtension(FileUploadControl.FileName)

            Select Case (origen)
                Case "certificadoTS"
                    If (fileExt = ".pdf") Then
                        archivo = SaveFile(FileUploadControl.PostedFile, "~\RRHH\Adjuntos\CertificadosTS", "TS")
                        If Not String.IsNullOrEmpty(archivo) Then

                            Try
                                BL.UpdateArchivoCertificadoTipoSangre(IdPersonal, archivo)
                                'PersonalBL.UpdateArchivoCertificadoTipoSangre(archivo, )
                                ' que salga un mensaje flotante
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
                Case "adenda"

            End Select

        End If
    End Sub

    Function SaveFile(ByVal file As HttpPostedFile, ByVal ruta As String, ByVal nombre As String) As String

        Dim savePath As String = Server.MapPath(ruta)

        nombre += Today.Year.ToString & Today.Month.ToString & Today.Day.ToString & IdPersonal.ToString & System.IO.Path.GetExtension(FileUploadControl.FileName)
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
        Dim archivoElim As String = (Server.MapPath("~\RRHH\Adjuntos\Contratos\" + Me.lblArchivo.Text))
        'Dim archivo As String = (Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))
        Try
            BL.UpdateArchivoCertificadoTipoSangre(IdPersonal, "")
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
        Dim myFile As ProcessStartInfo

        myFile = New ProcessStartInfo(Server.MapPath("~\RRHH\Adjuntos\Contratos\" + lblArchivo.Text))
        'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

        'Abre archivo
        Process.Start(myFile)
    End Sub
End Class