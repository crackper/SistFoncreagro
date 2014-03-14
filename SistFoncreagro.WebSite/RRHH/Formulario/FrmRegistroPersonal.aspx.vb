Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmRegistroPersonal
    Inherits System.Web.UI.Page

    Dim nacionalidadBL As NacionalidadBL
    Dim listaNacionalidad As List(Of Nacionalidad)
    Dim personal As New Personal
    Dim personalBl As New PersonalBL
    Dim idPersonal As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim personalBL As IPersonalBL
        Dim personal As Personal
        Dim listaTelefonosAsignados As List(Of TelefonoAsignado)
        Dim telefonoAsignado As TelefonoAsignado

        idPersonal = Request.QueryString("IdPersonal")

        'If idPersonal = 0 Then
        '    idPersonal = 1f
        'End If

        personalBL = New PersonalBL
        personal = personalBL.GetPersonalById(idPersonal)

        If Not Page.IsPostBack Then

            If Not personal Is Nothing Then

                Me.lblNombre.Text = personal.Nombres & " " & personal.ApePaterno & " " & personal.ApeMaterno

                Me.txtNombre.Text = personal.Nombres
                Me.txtApelPaterno.Text = personal.ApePaterno
                Me.txtApelMaterno.Text = personal.ApeMaterno

                If personal.IdNacionalidad.HasValue Then
                    Me.RCBNacionalidad.SelectedValue = personal.IdNacionalidad
                End If

                'If Not personal.nacionalidad1 Is Nothing Then
                '    Me.RCBNacionalidad.SelectedIndex = personal.nacionalidad1.IdNacionalidad
                'End If

                If personal.IdTipoDI.HasValue Then
                    Me.RCBTipoDI.SelectedValue = personal.IdTipoDI
                End If

                'If Not personal.tipoDI Is Nothing Then
                '    Me.RCBTipoDI.SelectedIndex = personal.tipoDI.IdTipoDI
                '    Me.txtNroDI.Text = personal.NroDI
                'End If


                Me.RtxtDireccion.Text = personal.Direccion

                If personal.FechaNacimiento.HasValue Then
                    Me.txtFechaNacimiento.Text = personal.FechaNacimiento
                End If

                Me.txtLugarNacimiento.Text = personal.LugarNacimiento

                If Not String.IsNullOrEmpty(personal.Sexo) Then
                    Me.RCBGenero.SelectedValue = personal.Sexo
                End If

                If Not String.IsNullOrEmpty(personal.EstadoCivil) Then
                    Me.RCBEstadoCivil.SelectedValue = personal.EstadoCivil
                End If

                Me.txtLicConducir.Text = personal.LicenciaConducir
                Me.txtTelPersonal.Text = personal.Telefono
                Me.txtCelPersonal.Text = personal.Celular
                Me.RtxtEmailPersonal.Text = personal.Email


                If Not personal.periodoLaboralActualEntity Is Nothing Then
                    'If Not personal.periodoLaboralActual.ListaTelefonosAsignados Is Nothing Then
                    '    listaTelefonosAsignados = personal.periodoLaboralActual.ListaTelefonosAsignados

                    '    For Each telefonoAsignado In listaTelefonosAsignados
                    '        Dim lineaLista As String
                    '        lineaLista = telefonoAsignado.TelefonoCoorporativo.Descripcion & " : " _
                    '            & telefonoAsignado.TelefonoCoorporativo.NroTelefono & " : " _
                    '            & telefonoAsignado.TelefonoCoorporativo.NroRP
                    '        Me.lbxTelfCoorporativo.Items.Add(lineaLista)
                    '    Next
                    'End If

                    Me.RtxtEmailCoorporativo.Text = personal.periodoLaboralActualEntity.EmailCoorporativo
                End If

                Me.txtTipoSangre.Text = personal.TipoSangre
                Me.txtNombreContacto.Text = personal.ContactoEmergencia
                Me.txtTelContacto.Text = personal.TelefonoContacto
            End If
        End If
    End Sub


    'Protected Sub DropDownList4_Init(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList4.Init
    '    listaNacionalidad = New List(Of Nacionalidad)
    '    nacionalidadBL = New NacionalidadBL
    '    listaNacionalidad = Me.nacionalidadBL.GetAllFromNacionalidad
    '    Me.DropDownList4.DataSource = listaNacionalidad
    '    Me.DropDownList4.DataBind()
    '    'Me.DropDownList4.DataTextField= DropDownList4.DataSource.
    '    'Me.DropDownList4.DataTextField = listaNacionalidad(
    'End Sub

    'Protected Sub DropDownList5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList5.SelectedIndexChanged
    '    Me.DropDownList6.DataSource = Me.DropDownList5.SelectedValue
    '    Me.DropDownList6.DataBind()
    'End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        personal.IdPersonal = idPersonal

        If Not String.IsNullOrEmpty(Me.txtApelMaterno.Text) Then
            personal.ApeMaterno = Me.txtApelMaterno.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtApelPaterno.Text) Then
            personal.ApePaterno = Me.txtApelPaterno.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtCelPersonal.Text) Then
            personal.Celular = Me.txtCelPersonal.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtNombreContacto.Text) Then
            personal.ContactoEmergencia = Me.txtNombreContacto.Text
        End If
        If Not String.IsNullOrEmpty(Me.RtxtDireccion.Text) Then
            personal.Direccion = Me.RtxtDireccion.Text
        End If
        If Not String.IsNullOrEmpty(Me.RtxtEmailPersonal.Text) Then
            personal.Email = Me.RtxtEmailPersonal.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtFechaNacimiento.Text) Then
            personal.FechaNacimiento = Me.txtFechaNacimiento.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtLicConducir.Text) Then
            personal.LicenciaConducir = Me.txtLicConducir.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtLugarNacimiento.Text) Then
            personal.LugarNacimiento = Me.txtLugarNacimiento.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtNombre.Text) Then
            personal.Nombres = Me.txtNombre.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtNroDI.Text) Then
            personal.NroDI = Me.txtNroDI.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtTelPersonal.Text) Then
            personal.Telefono = Me.txtTelPersonal.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtTelContacto.Text) Then
            personal.TelefonoContacto = Me.txtTelContacto.Text
        End If
        If Not String.IsNullOrEmpty(Me.txtTipoSangre.Text) Then
            personal.TipoSangre = Me.txtTipoSangre.Text
        End If
        If Me.RCBEstadoCivil.SelectedIndex > -1 Then
            personal.EstadoCivil = Me.RCBEstadoCivil.SelectedValue
        End If
        If Me.RCBNacionalidad.SelectedIndex > -1 Then
            personal.IdNacionalidad = Me.RCBNacionalidad.SelectedValue
            personal.Nacionalidad = Me.RCBNacionalidad.Text
        End If

        If Me.RCBTipoDI.SelectedIndex > -1 Then
            personal.IdTipoDI = Me.RCBTipoDI.SelectedValue
        End If

        If Me.RCBGenero.SelectedIndex > -1 Then
            personal.Sexo = Me.RCBGenero.SelectedValue
        End If

        'personal.Discapacidad = Me.
        'personal.IdNivelEducativopersonal.IdPersonal = 0

        Dim IdPer As Int32
        IdPer = personalBl.SavePersonal(personal)
        Response.Redirect("~\RRHH\Formulario\FrmRegistroPersonal.aspx?IdPersonal=" & IdPer)

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("~\RRHH\Formulario\FrmPersonal.aspx")
    End Sub
End Class