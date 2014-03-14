Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class BuscarConvenio
    Inherits System.Web.UI.Page
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "InitInsert" Then
            e.Canceled = True
            Response.Redirect("~\Monitoreo\Formularios\FrmDatosConvenio.aspx?IdConvenio=0")
        ElseIf e.CommandName = "Edit" Then
            Dim id As String
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdConvenio")
            e.Canceled = True
            Response.Redirect("~\Monitoreo\Formularios\FrmDatosConvenio.aspx?IdConvenio=" + id.ToString)
        End If
        
    End Sub

    Public Function ValidarFecha(ByVal Valor As Date) As String
        Dim MisFunciones As New Funciones
        Dim miFecha As String = MisFunciones.CampoFecha(Valor)
        Return miFecha
    End Function

    Public Sub ConfigureExport()
        RadGrid2.ExportSettings.ExportOnlyData = True
        RadGrid2.ExportSettings.IgnorePaging = True
        RadGrid2.ExportSettings.OpenInNewWindow = True
    End Sub

    Protected Sub RadGrid12ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim mIdconvenio As Int32
        mIdconvenio = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdConvenio")
        Dim miError As String
        Dim _convenioBL As New ConvenioBL


        miError = _convenioBL.DeleteConvenio(mIdconvenio)
        If miError <> "" Then
            RadWindowManager1.RadAlert(miError, 300, 120, "ERROR", "")
        End If
    End Sub
End Class