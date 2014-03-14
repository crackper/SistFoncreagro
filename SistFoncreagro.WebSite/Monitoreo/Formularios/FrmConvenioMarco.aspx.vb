Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration

Public Class FrmConvenioMarco
    Inherits System.Web.UI.Page
    Dim ConveMarcoBL As New ConveMarcoBL
    Dim _ConveMarco As ConveMarco
    Dim nConveMarco As New ConveMarco
    Dim IdConveMarco As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtIdConvenio.Text = Request.QueryString("IdConvenio")

        If Not Page.IsPostBack Then
            If Request.QueryString("IdConvenio") > 0 Then
                Me.RadGrid1.MasterTableView.InsertItem()
            End If
        End If
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim mUserControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim Cod As String
        Cod = UCase(CType(mUserControl.FindControl("TxtCodigo"), TextBox).Text)

        If Cod Then RadWindowManager1.RadAlert("Es necesario ingresar el código", 200, 100, "Error", "") : Exit Sub

        Dim Cad As String = CType(mUserControl.FindControl("TxtIdTabla"), TextBox).Text
        Dim idConvenioMarco As Int32
        If Cad <> "" Then nConveMarco.IdConveMarco = CInt(Cad)

        nConveMarco.Codigo = Cod
        nConveMarco.Nombre = UCase(CType(mUserControl.FindControl("txtNombre"), TextBox).Text)
        idConvenioMarco = ConveMarcoBL.SaveConveMarco(nConveMarco)

        'Dim txtId As TextBox = CType(mUserControl.FindControl("TxtIdTabla"), TextBox)
        'txtId.Text = idConvenioMarco

        'idConvenioMarco = CInt(Cad)
        TxtConveMarco.Text = idConvenioMarco

        Dim cadena_java As String
        If Request.QueryString("IdConvenio") > 0 Then
            cadena_java = "<script type='text/javascript'> " & _
                              " CerrarVentana(" & Convert.ToString(idConvenioMarco) & "); " & _
                              Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
        End If
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)


        nConveMarco.IdConveMarco = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdConveMarco")

        nConveMarco.Codigo = UCase(CType(userControl.FindControl("Txtcodigo"), TextBox).Text)
        nConveMarco.Nombre = UCase(CType(userControl.FindControl("TxtNombre"), TextBox).Text)

        ConveMarcoBL.SaveConveMarco(nConveMarco)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim EditedItem As GridEditableItem
        EditedItem = CType(e.Item, GridEditableItem)
        Try
            ConveMarcoBL.DeleteConveMarco(EditedItem.OwnerTableView.DataKeyValues(EditedItem.ItemIndex)("IdConveMarco"))
            RadGrid1.DataBind()
        Catch ex As Exception
            RadWindowManager1.RadAlert("Error al Eliminar Registro <br /><br /><b>Tiene tablas relacionadas<br />", 300, 100, "ERROR", "") 
        End Try
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("~\Monitoreo\Formularios\Defecto.aspx")
    End Sub
End Class