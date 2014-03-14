Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmCambioCondicionesContrato
    Inherits System.Web.UI.Page
    Dim condicionesBL As New CondicionesContratoBL
    Dim IdPeriodoLaboral As Int32
    Dim IdContrato As Int32

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdPeriodoLaboral = Session("IdPeriodoLaboral")
        IdContrato = Session("IdContrato")
    End Sub

    Protected Sub cbxAdenda_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAdenda.CheckedChanged
        If cbxAdenda.Checked = True Then
            Me.txtNroAdemda.Enabled = True
        Else
            Me.txtNroAdemda.Enabled = False
        End If

    End Sub

    Protected Sub cbxFecha_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxFecha.CheckedChanged
        If cbxFecha.Checked = True Then
            Me.rpFechaFinContrato.Enabled = True
        Else
            Me.rpFechaFinContrato.Enabled = False
        End If
    End Sub

    Protected Sub cbxSueldo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxSueldo.CheckedChanged
        If cbxSueldo.Checked = True Then
            Me.txtSueldo.Enabled = True
        Else
            Me.txtSueldo.Enabled = False
        End If
    End Sub

    Protected Sub cbxPosicion_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxPosicion.CheckedChanged
        If cbxPosicion.Checked = True Then
            Me.RadComboBox1.Enabled = True
            Me.ddlPosicion.Enabled = True
        Else
            Me.RadComboBox1.Enabled = False
            Me.ddlPosicion.Enabled = False
        End If
    End Sub

    Protected Sub RadComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        Me.txtIdArea.Text = RadComboBox1.SelectedValue
    End Sub

    Protected Sub RadTreeView1_NodeClick1(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadTreeNodeEventArgs)
        Dim nodo As New Telerik.Web.UI.RadTreeNode
        nodo = e.Node
        ''RadComboBox2.ClearSelection()
        ' ''RadComboBox2.Text = ""
        ''RadComboBox2.DataBind()
    End Sub


    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAceptar.Click
        Dim condiciones As New CondicionesContrato
        Dim condicionesActuales As New CondicionesContrato
        Dim argArea As New ArgumentosArea(0, 0, 0, 0, 0)
        Dim argPosicion As New ArgumentosPosicion(argArea, 0, 0, 0, 0, 0, 0)
        Dim argCondiciones As New ArgumentosCondicionesContrato(0, 0, argPosicion)
        condicionesActuales = condicionesBL.GetCondicionesContratoActualByIdContratoByIdPeriodo(IdContrato, IdPeriodoLaboral, argCondiciones)
        condiciones.IdPeriodoLaboral = IdPeriodoLaboral
        condiciones.IdContrato = IdContrato
        condiciones.IdCondicion = 0

        If cbxAdenda.Checked = True Then
            condiciones.NroAdemda = Me.txtNroAdemda.Text
        End If

        If cbxFecha.Checked = True Then
            condiciones.AmpliacionContrato = True
            condiciones.FechaAmpliacionContrato = DateValue(Me.rpFechaFinContrato.SelectedDate)
        Else
            condiciones.AmpliacionContrato = False
            condiciones.FechaAmpliacionContrato = condicionesActuales.FechaAmpliacionContrato
        End If

        If cbxSueldo.Checked = True Then
            condiciones.cambioSueldo = True
            condiciones.Sueldo = CDbl(Me.txtSueldo.Text)
        Else
            condiciones.cambioSueldo = False
            condiciones.Sueldo = condicionesActuales.Sueldo
        End If

        If cbxPosicion.Checked = True Then
            condiciones.cambioCargo = True
            condiciones.IdPosicion = Me.ddlPosicion.SelectedValue
        Else
            condiciones.cambioCargo = False
            condiciones.IdPosicion = condicionesActuales.IdPosicion
        End If

        If Not String.IsNullOrEmpty(Me.rpFechaAplica.SelectedDate) Then
            condiciones.FechaCambio = DateValue(Me.rpFechaAplica.SelectedDate)
        End If

        If (cbxFecha.Checked = True Or cbxSueldo.Checked = True Or cbxPosicion.Checked) = True And Not String.IsNullOrEmpty(Me.rpFechaAplica.SelectedDate) Then
            condicionesBL.SaveCondicionesContrato(condiciones)
            Dim cadena_java As String
            cadena_java = "<script type='text/javascript'> " & _
            " CerrarVentana(1); " & _
            Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            'Me.Page.ClientScript.RegisterStartupScript(GetType(Page), "Cerrar", cadena_java.ToString, False)
            ''ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            'Me.Page.ClientScript.RegisterStartupScript(Me.GetType(), "MyScriptFolder", "alert('No se pudo crear la carpeta');", True)
        End If

    End Sub
End Class