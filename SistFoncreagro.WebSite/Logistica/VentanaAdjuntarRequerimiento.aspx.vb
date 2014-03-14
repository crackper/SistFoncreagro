Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class VentanaAdjuntarRequerimiento
    Inherits System.Web.UI.Page
    Dim adjuntoReqBl As IAdjuntoRequerimientoBL
    Protected Sub ibSubirArchivo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibSubirArchivo.Click
        SaveFile(FileUploadControl.PostedFile)
    End Sub

    Sub SaveFile(ByVal file As HttpPostedFile)
        Dim IdReq As String = Request.QueryString("IdReq")
        Dim savePath As String = Server.MapPath("~\Archivos\Logistica\Requerimientos\" + IdReq)
        Dim fileName As String = FileUploadControl.FileName
        Dim pathToCheck As String = savePath + fileName
        Dim tempfileName As String
        Dim fileExt As String
        fileExt = System.IO.Path.GetExtension(FileUploadControl.FileName)
        tempfileName = ""
        If (fileExt = ".pdf") Then
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
            'Guarda archivo
            FileUploadControl.SaveAs(savePath)
            Dim adjuntoReq As New AdjuntoRequerimiento
            adjuntoReqBl = New AdjuntoRequerimientoBL
            adjuntoReq.IdRequerimiento = Request.QueryString("IdReq")
            adjuntoReq.Archivo = IdReq + fileName
            adjuntoReqBl.SaveAdjuntoRequerimiento(adjuntoReq)
            gvCotizacion.DataBind()
        End If
    End Sub

    Protected Sub gvCotizacion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvCotizacion.RowCommand
        Dim adjuntoReq As New AdjuntoRequerimiento
        adjuntoReqBl = New AdjuntoRequerimientoBL
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim txtNombreArchivo As TextBox = CType(gvCotizacion.Rows(index).FindControl("txtNombreArchivo"), TextBox)
            Dim txtAdjuntoIdCotizacion As TextBox = CType(gvCotizacion.Rows(index).FindControl("txtIdReq"), TextBox)

            Dim archivo As String = (Server.MapPath("~\Archivos\Logistica\Requerimientos\" + txtNombreArchivo.Text))
            My.Computer.FileSystem.DeleteFile(archivo, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            adjuntoReqBl.DeleteadjuntoRequerimiento(CInt(txtAdjuntoIdCotizacion.Text), Request.QueryString("IdReq"))
            gvCotizacion.DataBind()
            FileUploadControl.Dispose()
        End If
    End Sub

    Protected Sub gvCotizacion_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvCotizacion.DataBound
        For i = 0 To gvCotizacion.Rows.Count - 1
            Dim txtNombreArchivo As TextBox = CType(gvCotizacion.Rows(i).FindControl("txtNombreArchivo"), TextBox)
            Dim ibAbreArchivo As LinkButton = CType(Me.gvCotizacion.Rows(i).FindControl("lbAbrir"), LinkButton)
            ibAbreArchivo.Attributes.Add("onClick", "CargarVentana('" & txtNombreArchivo.Text & "'); return false;")
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Request.QueryString("elim") = "0" Then
            gvCotizacion.Columns(0).Visible = False
        End If
    End Sub
End Class