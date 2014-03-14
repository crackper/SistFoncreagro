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
Public Class ControlEstado
    Inherits System.Web.UI.UserControl
    Private _dataItem As Object = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadComboBox1.Filter = 1
    End Sub
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then
            Me.txtDate1.Text = Now
        Else
            Me.ImageButton13.Attributes.Add("onClick", "CargarVentana('" & DataBinder.Eval(DataItem, "DocumentoBaja").ToString & "'); return false;")
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdTipo")
            If DataBinder.Eval(DataItem, "IdTipo") = 2 Then
                Me.CheckBox1.Enabled = True
                Me.CheckBox2.Enabled = True
                Me.RadComboBox2.Enabled = True
                Me.TextBox3.Enabled = True
                Me.ImageButton13.Enabled = True
                Me.FileUploadControl.Enabled = True
                Me.ibSubirArchivo.Enabled = True
            Else
                Me.CheckBox1.Enabled = False
                Me.CheckBox2.Enabled = False
                Me.RadComboBox2.Enabled = False
                Me.TextBox3.Enabled = False
                Me.ImageButton13.Enabled = False
                Me.FileUploadControl.Enabled = False
                Me.ibSubirArchivo.Enabled = False
            End If
            Me.txtDate1.Text = DataBinder.Eval(DataItem, "FechaInicio")
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Observacion")
            If DataBinder.Eval(DataItem, "BajaContable") = "S" Then
                Me.CheckBox1.Checked = True
            Else
                Me.CheckBox1.Checked = False
            End If
            If DataBinder.Eval(DataItem, "BajaPatrimonio") = "S" Then
                Me.CheckBox2.Checked = True
            Else
                Me.CheckBox2.Checked = False
            End If
            If Not DataBinder.Eval(DataItem, "IdMotivo").Equals(DBNull.Value) Then
                Me.RadComboBox2.SelectedValue = DataBinder.Eval(DataItem, "IdMotivo")
            End If
            If Not DataBinder.Eval(DataItem, "DocumentoBaja").Equals(DBNull.Value) Then
                Me.TextBox3.Text = DataBinder.Eval(DataItem, "DocumentoBaja")
            End If

        End If
    End Sub

    Protected Sub RadComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        If Me.RadComboBox1.SelectedValue = 2 Then
            Me.CheckBox1.Enabled = True
            Me.CheckBox2.Enabled = True
            Me.RadComboBox2.Enabled = True
            Me.TextBox3.Enabled = True
            Me.ImageButton13.Enabled = True
            Me.FileUploadControl.Enabled = True
            Me.ibSubirArchivo.Enabled = True
        Else
            Me.CheckBox1.Enabled = False
            Me.CheckBox2.Enabled = False
            Me.RadComboBox2.Enabled = False
            Me.TextBox3.Enabled = False
            Me.ImageButton13.Enabled = False
            Me.FileUploadControl.Enabled = False
            Me.ibSubirArchivo.Enabled = False
        End If
    End Sub
    Function SaveFile(ByVal file As HttpPostedFile, ByVal ruta As String, ByVal nombre As String, ByVal objetoLoad As FileUpload) As String

        Dim savePath As String = Server.MapPath(ruta)
        Dim fileName As String = FileUploadControl.FileName
        Dim pathToCheck As String = savePath + fileName
        Dim tempfileName As String
      
        tempfileName = ""

        nombre += Date.Parse(Me.txtDate1.Text).Day.ToString + "_" + Date.Parse(Me.txtDate1.Text).Month.ToString & "_" & Date.Parse(Me.txtDate1.Text).Year.ToString & System.IO.Path.GetExtension(objetoLoad.FileName)
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

        If (fileExt = ".doc" Or fileExt = ".pdf" Or fileExt = ".docx") Then
            archivo = SaveFile(FileUploadControl.PostedFile, "~\Patrimonio\Adjuntos\", "InformeBaja", FileUploadControl)
            Me.TextBox3.Text = archivo
            Me.ImageButton13.Attributes.Add("onClick", "CargarVentana('" & Me.TextBox3.Text.ToString & "'); return false;")
        Else
            Me.lblMsn.Visible = True
            Me.lblMsn.ForeColor = Drawing.Color.Red
            Me.lblMsn.Text = "Solo se permiten archivos de formato .doc, .docx o .pdf"
        End If
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click

    End Sub
End Class