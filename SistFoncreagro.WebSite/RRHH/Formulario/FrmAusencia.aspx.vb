Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class FrmAusencia
    Inherits System.Web.UI.Page
    Dim MotivoAusenciaBL As New MotivoAusenciaBL
    Dim AusenciaBL As New AusenciaBL
    Dim _Ausencia As New Ausencia
    Dim Ausencia As Ausencia
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("IdPeriodoLaboral") = 1

        If Page.IsPostBack = False Then
            If Session("IdAusencia") > 0 Then
                AusenciaBL.GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral(Session("IdAusencia"), Session("IdPeriodoLaboral"))
                Me.DropDownList1.SelectedValue = Ausencia.IdMotivoAusencia
                Me.RadDatePicker1.SelectedDate = Ausencia.FechaInicio
                Me.RadDatePicker2.SelectedDate = Ausencia.FechaFin
                Me.TextBox1.Text = Ausencia.Tiempo
                Me.TextBox2.Text = Ausencia.Comentario
                Me.TextBox3.Text = Ausencia.NroArchivo
                Me.lbl.Text = Ausencia.Archivo
            End If

        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim codSunat As String
        codSunat = MotivoAusenciaBL.GetMOTIVOAUSENCIAByIdMotivoAusencia(Me.DropDownList1.SelectedValue).codSunat

        If (codSunat = "21" Or codSunat = "22") Then
            Me.Label2.Visible = True
            Me.Panel1.Visible = True
            Me.TextBox2.Visible = False
            Me.Label1.Visible = False
        ElseIf codSunat = "01" Then
            Me.TextBox2.Visible = True
            Me.Label1.Visible = True
            Me.Label2.Visible = False
            Me.Panel1.Visible = False
        Else
            Me.TextBox2.Visible = False
            Me.Label1.Visible = False
            Me.Label2.Visible = False
            Me.Panel1.Visible = False
        End If
    End Sub

    Protected Sub btnAdjuntar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAdjuntar.Click
        Dim fileExt As String
        Dim archivo As String
        fileExt = System.IO.Path.GetExtension(FileUploadControl.FileName)

        If (fileExt = ".doc" Or fileExt = ".docx" Or fileExt = ".pdf" Or fileExt = ".dot" Or fileExt = ".dotx") Then
            archivo = SaveFile(FileUploadControl.PostedFile, "~\RRHH\Adjuntos\CertificadosMedicos", "cm", FileUploadControl)
            Me.lbl.Text = archivo
            'Try
            '    AusenciaBL.UpdateArchivoAUSENCIA(archivo, IdAusencia, IdPeriodoLaboral)
            '    Me.lblMsn.Visible = True
            '    Me.lblMsn.ForeColor = Drawing.Color.Red
            '    Me.lblMsn.Text = "Se reemplazó el archivo"
            'Catch ex As Exception
            '    Me.lblMsn.Visible = True
            '    Me.lblMsn.ForeColor = Drawing.Color.Red
            '    Me.lblMsn.Text = "No se pudo actualizar la BD, intentelo luego"
            'End Try
        Else
            Me.lblMsn.Visible = True
            Me.lblMsn.ForeColor = Drawing.Color.Red
            Me.lblMsn.Text = "Solo se permiten archivos de formato .doc, .docx, .pdf, .dot o .dotx"
        End If
    End Sub
    Function SaveFile(ByVal file As HttpPostedFile, ByVal ruta As String, ByVal nombre As String, ByVal objetoLoad As FileUpload) As String

        Dim savePath As String = Server.MapPath(ruta)
        Dim fileName As String = FileUploadControl.FileName
        Dim pathToCheck As String = savePath + fileName
        Dim tempfileName As String
        tempfileName = ""

        nombre += Today.Year.ToString & Today.Month.ToString & Today.Day.ToString & Session("IdPeriodoLaboral").ToString & System.IO.Path.GetExtension(objetoLoad.FileName)
        savePath += "\" + nombre
        'Guarda archivo
        Try
            objetoLoad.SaveAs(savePath)
            Return nombre
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        _Ausencia.Archivo = Me.lbl.Text
        _Ausencia.Comentario = Me.TextBox2.Text
        _Ausencia.FechaFin = Me.RadDatePicker2.SelectedDate
        _Ausencia.FechaInicio = Me.RadDatePicker1.SelectedDate
        _Ausencia.IdAusencia = Session("IdAusencia")
        _Ausencia.IdMotivoAusencia = Me.DropDownList1.SelectedValue
        _Ausencia.IdPeriodoLaboral = Session("IdPeriodoLaboral")
        _Ausencia.NroArchivo = Me.TextBox3.Text
        _Ausencia.Tiempo = Me.TextBox1.Text
        Session("IdAusencia") = AusenciaBL.SaveAUSENCIA(_Ausencia)

    End Sub

    Protected Sub RadDatePicker2_SelectedDateChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs) Handles RadDatePicker2.SelectedDateChanged
        Me.TextBox1.Text = DateDiff(DateInterval.Day, CDate(Me.RadDatePicker1.SelectedDate), CDate(Me.RadDatePicker2.SelectedDate))
    End Sub

    Protected Sub RadDatePicker1_SelectedDateChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs) Handles RadDatePicker1.SelectedDateChanged
        If Len(Me.RadDatePicker2.SelectedDate) <> 0 Then
            Me.TextBox1.Text = DateDiff(DateInterval.Day, CDate(Me.RadDatePicker1.SelectedDate), CDate(Me.RadDatePicker2.SelectedDate))
        End If

    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminar.Click
        Dim archivoElim As String = (Server.MapPath("~\RRHH\Adjuntos\CertificadosMedicos\" + Me.lbl.Text))

        'Dim archivo As String = (Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))
        Try
            My.Computer.FileSystem.DeleteFile(archivoElim, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Me.lblMsn.Visible = True
            Me.lblMsn.ForeColor = Drawing.Color.Red
            Me.lblMsn.Text = "Archivo eliminado"
            Me.lbl.Text = ""
            AusenciaBL.UpdateArchivoAUSENCIA("", Session("IdAusencia"), Session("IdPeriodoLaboral"))
        Catch ex As Exception
            Me.lblMsn.Visible = True
            Me.lblMsn.ForeColor = Drawing.Color.Red
            Me.lblMsn.Text = "No se pudo eliminar el archivo, intentelo luego"
        End Try
       
    End Sub

    Protected Sub btnAbrir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbrir.Click
        Dim myFile As ProcessStartInfo

        myFile = New ProcessStartInfo(Server.MapPath("~\RRHH\Adjuntos\CertificadosMedicos\" + lbl.Text))
        'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

        'Abre archivo
        Process.Start(myFile)
    End Sub
End Class