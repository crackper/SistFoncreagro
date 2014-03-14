Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Collections
Imports System.Configuration
Imports System
Imports System.Web.UI
Public Class FrmConciliacion
    Inherits System.Web.UI.Page
    Dim Conciliacion As New ConciliacionBancaria
    Dim _Conciliacion As ConciliacionBancaria
    Dim ConciliacionBL As New ConciliacionBnacariaBL
    Dim DetalleBL As New DetalleConciliacionBL
    Dim Detalle As New DetalleConciliacion
    Dim _Detalle As DetalleConciliacion
    Dim CuentaBancariaBL As New CuentaBancariaBL
    Dim PlancontableBL As New PlanContableBL
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Me.txtDate.Text = Session("Fecha").ToString
           'para recuperar datos
            If Session("IdConciliacion") > 0 Then
                _Conciliacion = ConciliacionBL.GetCONCILIACIONBANCARIAByIdConciliacion(Session("IdConciliacion"))
                Me.DropDownList1.SelectedValue = _Conciliacion.IdCtaBancaria
                Me.DropDownList1.Enabled = False
                Me.RadNumericTextBox3.Text = _Conciliacion.SaldoBancario
                Me.txtDate.Text = _Conciliacion.Fecha
                Me.txtDate.Enabled = False
                Me.TextBox3.Text = _Conciliacion.Adjunto

                Me.ImageButton13.Attributes.Add("onClick", "CargarVentana('" & _Conciliacion.Adjunto.ToString & "'); return false;")
            Else
                Me.DropDownList1.Enabled = True
                Me.txtDate.Enabled = True
            End If

        End If

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Conciliacion.Anio = Session("Anio")
        Conciliacion.Fecha = Me.txtDate.Text
        Conciliacion.IdCtaBancaria = Me.DropDownList1.SelectedValue
        Conciliacion.IdUsuario = Session("IdUser")
        Conciliacion.SaldoBancario = Me.RadNumericTextBox3.Value
        Conciliacion.IdConciliacion = Session("IdConciliacion")
        Conciliacion.Adjunto = Me.TextBox3.Text

        Session("IdConciliacion") = ConciliacionBL.SaveCONCILIACIONBANCARIA(Conciliacion)
        Me.DropDownList1.Enabled = False
        Me.txtDate.Enabled = False
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Conciliacion.Anio = Session("Anio")
        Conciliacion.Fecha = Me.txtDate.Text
        Conciliacion.IdCtaBancaria = Me.DropDownList1.SelectedValue
        Conciliacion.IdUsuario = Session("IdUser")
        Conciliacion.SaldoBancario = Me.RadNumericTextBox3.Value
        Conciliacion.IdConciliacion = Session("IdConciliacion")
        Conciliacion.Adjunto = Me.TextBox3.Text
        Session("IdConciliacion") = ConciliacionBL.SaveCONCILIACIONBANCARIA(Conciliacion)
        Me.RadGrid1.MasterTableView.InsertItem()
        Me.DropDownList1.Enabled = False
        Me.txtDate.Enabled = False
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        Detalle.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        Detalle.Glosa = CType(userControl.FindControl("RadTextBox3"), RadTextBox).Text
        Detalle.IdConciliacion = Session("IdConciliacion")
        Detalle.IdProveedorCliente = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Detalle.IdTipoMovimiento = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        Detalle.Monto = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text

        DetalleBL.SaveDETALLECONCILIACION(Detalle)

    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        Detalle.IdDetalle = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalle")
        Detalle.Fecha = CType(userControl.FindControl("txtDate1"), TextBox).Text
        Detalle.Glosa = CType(userControl.FindControl("RadTextBox3"), RadTextBox).Text
        Detalle.IdConciliacion = Session("IdConciliacion")
        Detalle.IdProveedorCliente = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Detalle.IdTipoMovimiento = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        Detalle.Monto = CType(userControl.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text

        DetalleBL.SaveDETALLECONCILIACION(Detalle)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim idDet As Int32

        idDet = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalle")
        DetalleBL.DeleteDETALLECONCILIACION(idDet)
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Session("IdConciliacion") = 0
        Response.Redirect("~\Contabilidad\Formularios\FrmConciliacion.aspx")
    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        Dim cadena_java As String = "<script type='text/javascript'> " & _
                                 "window.open('ReporteConciliacionBancaria.aspx?'); " & _
                                 Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub

    Function SaveFile(ByVal file As HttpPostedFile, ByVal ruta As String, ByVal nombre As String, ByVal objetoLoad As FileUpload) As String

        Dim savePath As String = Server.MapPath(ruta)
        Dim fileName As String = FileUploadControl.FileName
        Dim pathToCheck As String = savePath + fileName
        Dim tempfileName As String
        Dim cuenta As String
        cuenta = PlancontableBL.GetPLANCONTABLEByIdPlan(CuentaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria(Me.DropDownList1.SelectedValue).IdPlan).Codigo
        tempfileName = ""

        nombre += cuenta & "_" & Date.Parse(Me.txtDate.Text).Month & "_" & Date.Parse(Me.txtDate.Text).Year.ToString & System.IO.Path.GetExtension(objetoLoad.FileName)
        savePath += "\" + nombre
        'Guarda archivo
        Try
            objetoLoad.SaveAs(savePath)
            Return nombre
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Protected Sub ibSubirArchivo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibSubirArchivo.Click
        Dim fileExt As String
        Dim archivo As String
        fileExt = System.IO.Path.GetExtension(FileUploadControl.FileName)

        If (fileExt = ".doc" Or fileExt = ".pdf") Then
            archivo = SaveFile(FileUploadControl.PostedFile, "~\Contabilidad\Adjuntos\", "EstadoCuenta", FileUploadControl)
            Me.TextBox3.Text = archivo
          
            'grabamos la conciliacion
            Conciliacion.Anio = Session("Anio")
            Conciliacion.Fecha = Me.txtDate.Text
            Conciliacion.IdCtaBancaria = Me.DropDownList1.SelectedValue
            Conciliacion.IdUsuario = Session("IdUser")
            Conciliacion.SaldoBancario = Me.RadNumericTextBox3.Text
            Conciliacion.IdConciliacion = Session("IdConciliacion")
            Conciliacion.Adjunto = Me.TextBox3.Text

            Session("IdConciliacion") = ConciliacionBL.SaveCONCILIACIONBANCARIA(Conciliacion)
            Me.DropDownList1.Enabled = False
            Me.txtDate.Enabled = False

            Me.ImageButton13.Attributes.Add("onClick", "CargarVentana('" & Me.TextBox3.Text.ToString & "'); return false;")
        Else
            Me.lblMsn.Visible = True
            Me.lblMsn.ForeColor = Drawing.Color.Red
            Me.lblMsn.Text = "Solo se permiten archivos de formato .doc, .docx, .pdf, .dot o .dotx"
        End If
    End Sub
End Class