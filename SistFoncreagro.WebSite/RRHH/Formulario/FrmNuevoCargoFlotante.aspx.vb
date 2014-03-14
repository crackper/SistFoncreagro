Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmNuevoCargoFlotante
    Inherits System.Web.UI.Page
    Dim cargoBL As New CargoBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub ControlNuevoCargo1_ClickEnBoton(ByVal sender As Object, ByVal e As String) Handles ControlNuevoCargo1.ClickEnBoton
        If e = "insertar" Then
            Dim coleccion As New Collection
            Dim cargo As New Cargo
            Try
                cargo.IdCargo = 0
                cargo.NomCargo = Me.ControlNuevoCargo1.NomCargo
                cargo.DescCargo = Me.ControlNuevoCargo1.DescCargo

                coleccion = cargoBL.InsertCargoNomCargo(cargo)

                If Convert.ToString(coleccion.Item("condicion")) = "I" Then
                    Dim cadena_java As String

                    CType(Me.ControlNuevoCargo1.FindControl("TxtIdCargo"), TextBox).Text = ""
                    CType(Me.ControlNuevoCargo1.FindControl("txtNomCargo"), TextBox).Text = ""
                    CType(Me.ControlNuevoCargo1.FindControl("txtDescCargo"), TextBox).Text = ""

                    cadena_java = "<script type='text/javascript'> " & _
                                  " CerrarVentana(" & Convert.ToString(coleccion.Item("idCargo")) & "); " & _
                                  Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)

                ElseIf Convert.ToString(coleccion.Item("condicion")) = "E" Then
                    CType(Me.ControlNuevoCargo1.FindControl("lblMensaje"), Label).Text = Convert.ToString(coleccion.Item("mensaje"))
                    'Me.txtIdCargo.Text = coleccion.Item("idCargo")
                End If

            Catch ex As Exception
                CType(Me.ControlNuevoCargo1.FindControl("lblMensaje"), Label).Text = "error"
                Me.ControlNuevoCargo1.IdCargo = coleccion.Item("idCargo")
            End Try
        Else
            Dim idCargo As Integer
            If Not Me.ControlNuevoCargo1.IdCargo.HasValue Then
                idCargo = 0
            Else
                idCargo = Me.ControlNuevoCargo1.IdCargo
            End If

            Me.ControlNuevoCargo1.IdCargo = 0
            Me.ControlNuevoCargo1.NomCargo = ""
            Me.ControlNuevoCargo1.DescCargo = ""

            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
                          " CerrarVentana(" & idCargo & "); " & _
                          Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar2", cadena_java.ToString, False)
        End If
    End Sub

End Class