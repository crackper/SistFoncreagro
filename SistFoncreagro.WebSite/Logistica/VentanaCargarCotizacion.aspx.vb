Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class VentanaCargarCotizacion
    Inherits System.Web.UI.Page
    Dim adjuntoCotizacionBl As IAdjuntoCotizacionBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Request.QueryString("Estado") = "1" Then
            'gvCotizacion.Columns(0).Visible = False
            ibSubirArchivo.Visible = False
            txtNombre.Visible = False
            FileUploadControl.Visible = False
        Else
            If Request.QueryString("Estado") = "3" Then
                'gvCotizacion.Columns(0).Visible = False
            End If
        End If
    End Sub

    Protected Sub ibSubirArchivo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibSubirArchivo.Click
        SaveFile(FileUploadControl.PostedFile)
    End Sub

    Sub SaveFile(ByVal file As HttpPostedFile)
        Dim IdCot As String = Request.QueryString("IdCotizacion")
        Dim savePath As String = Server.MapPath("~\Archivos\Logistica\" + IdCot)
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

            Dim adjuntoCotizacion As New AdjuntoCotizacion
            adjuntoCotizacionBl = New AdjuntoCotizacionBL
            adjuntoCotizacion.IdCotizacion = Request.QueryString("IdCotizacion")
            adjuntoCotizacion.Nombre = IdCot + fileName
            adjuntoCotizacion.NombreReport = txtNombre.Text
            If Request.QueryString("Estado") = "3" Then
                adjuntoCotizacion.Oc = True
            Else
                adjuntoCotizacion.Oc = False
            End If
            adjuntoCotizacionBl.SaveAdjuntoCotizacion(adjuntoCotizacion)
            gvCotizacion.DataBind()
        End If
    End Sub

    Protected Sub gvCotizacion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvCotizacion.RowCommand
        Dim AdjuntoCotizacion As New AdjuntoCotizacion
        adjuntoCotizacionBl = New AdjuntoCotizacionBL
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim label As Label = CType(gvCotizacion.Rows(index).FindControl("lblEstado"), Label)
            Dim txtNombreArchivo As TextBox = CType(gvCotizacion.Rows(index).FindControl("txtNombreArchivo"), TextBox)
            Dim txtAdjuntoIdCotizacion As TextBox = CType(gvCotizacion.Rows(index).FindControl("txtIdAdjuntoCotizacion"), TextBox)
            If label.Text = "True" Then
                Dim archivo As String = (Server.MapPath("~\Archivos\Logistica\" + txtNombreArchivo.Text))
                My.Computer.FileSystem.DeleteFile(archivo, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                adjuntoCotizacionBl.DeleteadjuntoCotizacion(CInt(txtAdjuntoIdCotizacion.Text))
                gvCotizacion.DataBind()
                FileUploadControl.Dispose()
            End If
        End If
    End Sub

    Protected Sub gvCotizacion_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvCotizacion.DataBound
        For i = 0 To gvCotizacion.Rows.Count - 1
            Dim txtNombreArchivo As TextBox = CType(gvCotizacion.Rows(i).FindControl("txtNombreArchivo"), TextBox)
            Dim ibAbri As LinkButton = CType(Me.gvCotizacion.Rows(i).FindControl("lbAbrir"), LinkButton)
            ibAbri.Attributes.Add("onClick", "CargarVentana('" & txtNombreArchivo.Text & "'); return false;")
        Next
    End Sub
End Class