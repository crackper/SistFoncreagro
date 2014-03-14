Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmNuevoCargo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim cargoBL As New CargoBL
        Dim cargo As New Cargo
        Dim coleccion As New Collection

        cargo.IdCargo = 0
        cargo.NomCargo = Me.txtNombreCargo.Text

        Try
            'cargo.IdCargo = cargoBL.SaveCargo(cargo)
            coleccion = cargoBL.InsertCargoNomCargo(cargo)

            If Convert.ToString(coleccion.Item("condicion")) = "I" Then
                Dim cadena_java As String

                Me.txtIdCargo.Text = ""
                Me.TextBox1.Text = ""
                Me.txtNombreCargo.Text = ""

                cadena_java = "<script type='text/javascript'> " & _
                              " CerrarVentana(" & Convert.ToString(coleccion.Item("idCargo")) & "); " & _
                              Chr(60) & "/script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            ElseIf Convert.ToString(coleccion.Item("condicion")) = "E" Then
                Me.TextBox1.Text = Convert.ToString(coleccion.Item("mensaje"))
                Me.txtIdCargo.Text = coleccion.Item("idCargo")
            End If

        Catch ex As Exception
            Me.TextBox1.Text = "error"
            'Dim lblError As Label = New Label()
            'lblError.Text = "No se puede insertar el Cliente. Razón: " + ex.Message
            'lblError.ForeColor = System.Drawing.Color.Red
            'RadGrid1.Controls.Add(lblError)
            'e.Canceled = True
        End Try

    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton1.Click
        Dim idCargo As Integer
        If String.IsNullOrEmpty(Me.txtIdCargo.Text) Then
            idCargo = 0
        Else
            idCargo = Convert.ToInt32(Me.txtIdCargo.Text)
        End If

        Me.txtIdCargo.Text = ""
        Me.TextBox1.Text = ""
        Me.txtNombreCargo.Text = ""

        Dim cadena_java As String
        cadena_java = "<script type='text/javascript'> " & _
                      " CerrarVentana(" & idCargo & "); " & _
                      Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar2", cadena_java.ToString, False)

    End Sub


    'Dim cadena_java As String
    '        cadena_java = "<script type='text/javascript'> " & _
    '                      " CerrarVentana(" & Convert.ToString(cargo.IdCargo) & "); " & _
    '                      Chr(60) & "/script>"
    '        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)


End Class