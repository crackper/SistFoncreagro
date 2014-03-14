<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaProveedor.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaProveedor" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }

            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
        </script>
    </telerik:RadCodeBlock>
    <style type="text/css">
        #form1
        {
            width: 739px;
        }
        .style1
        {
            height: 24px;
        }
        .style2
        {
            width: 30%;
            height: 24px;
        }
    </style>
</head>
<body style="height: 336px; width: 62%;">
<form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
        </telerik:RadScriptManager>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="ddlTipoPersona">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="ddlTipoDoc" />
                        <telerik:AjaxUpdatedControl ControlID="Label1" />
                        <telerik:AjaxUpdatedControl ControlID="lblNombre" />
                        <telerik:AjaxUpdatedControl ControlID="lblApellidoMaterno" />
                        <telerik:AjaxUpdatedControl ControlID="txtApellidoMaterno" />
                        <telerik:AjaxUpdatedControl ControlID="lblPrimerNombre" />
                        <telerik:AjaxUpdatedControl ControlID="txtPrimerNombre" />
                        <telerik:AjaxUpdatedControl ControlID="lblSegundoNombre" />
                        <telerik:AjaxUpdatedControl ControlID="txtSegundoNombre" />
                        <telerik:AjaxUpdatedControl ControlID="RadNumeroRuc" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
    </telerik:RadAjaxManager>
<fieldset style="width: 740px">
   <table style="width: 100%; width: 733px;">
    <tr>
        <td rowspan="14" class="style8">
            &nbsp;</td>
        <td style="font-size: 12px;" class="style1">
            Tipo Persona :</td>
        <td style="font-size: 12px;" class="style1">
            </td>
        <td class="style1">
            <asp:DropDownList ID="ddlTipoPersona" runat="server" Font-Size="8pt" 
                TabIndex="1" Width="255px" AutoPostBack="True">
                <asp:ListItem Value="02">Persona Jurídica</asp:ListItem>
                <asp:ListItem Value="01">Persona Natural</asp:ListItem>
                <asp:ListItem Value="03">Sujeto No Domiciliado</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style1" style="font-size: 12px">
            Ciudad :</td>
        <td class="style2">
            <asp:TextBox ID="txtCiudad" runat="server" Font-Size="8pt" TabIndex="5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            Tipo Doc. :</td>
        <td style="font-size: 12px;" class="style5">
            &nbsp;</td>
        <td class="style4">
            <asp:DropDownList ID="ddlTipoDoc" runat="server" DataSourceID="odsTipoDocId" 
                DataTextField="Descripcion" DataValueField="IdTipoDI" Font-Size="8pt" 
                TabIndex="1" Width="255px">
            </asp:DropDownList>
        </td>
        <td class="style12" style="font-size: 12px">
            Contacto :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtContacto" runat="server" Width="230px" Font-Size="8pt" 
                TabIndex="7"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            <asp:Label ID="Label1" runat="server" Text="Número :"></asp:Label>
        </td>
        <td style="font-size: 12px;" class="style5">
            <asp:RequiredFieldValidator ID="validarRuc" runat="server" 
                ControlToValidate="RadNumeroRuc" ErrorMessage="Ingrese RUC" Font-Size="7pt" 
                ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        </td>
        <td class="style4">
            <telerik:RadNumericTextBox ID="RadNumeroRuc" Runat="server" MaxLength="11">
                <NumberFormat DecimalDigits="0" GroupSeparator="" GroupSizes="1" />
            </telerik:RadNumericTextBox>
        </td>
        <td class="style12" style="font-size: 12px">
            Teléfono :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtTelefono" runat="server" Font-Size="8pt" TabIndex="7"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            <asp:Label ID="lblNombre" runat="server" Text="Razón Social :"></asp:Label>
        </td>
        <td style="font-size: 12px;" class="style5">
            <asp:RequiredFieldValidator ID="validarRazonSocial" runat="server" 
                ControlToValidate="txtRazonSocialApellidoPaterno" ErrorMessage="Ingrese Razón Social" 
                Font-Size="7pt" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        </td>
        <td class="style4">
            <asp:TextBox ID="txtRazonSocialApellidoPaterno" runat="server" Width="250px" Font-Size="8pt" 
                TabIndex="2"></asp:TextBox>
        </td>
        <td class="style12" style="font-size: 12px">
            Teléfono 2 :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtTelefono2" runat="server" Font-Size="8pt" TabIndex="8"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            <asp:Label ID="lblApellidoMaterno" runat="server" Text="Apellido Materno :" 
                Visible="False"></asp:Label>
        </td>
        <td style="font-size: 12px;" class="style5">
            &nbsp;</td>
        <td class="style4">
            <asp:TextBox ID="txtApellidoMaterno" runat="server" Width="250px" Font-Size="8pt" 
                TabIndex="2" Visible="False"></asp:TextBox>
            </td>
        <td class="style12" style="font-size: 12px">
            E-Mail :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtMail" runat="server" Width="230px" Font-Size="8pt" 
                TabIndex="8"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            <asp:Label ID="lblPrimerNombre" runat="server" Text="Primer Nombre :" 
                Visible="False"></asp:Label>
        </td>
        <td style="font-size: 12px;" class="style5">
            &nbsp;</td>
        <td class="style4">
            <asp:TextBox ID="txtPrimerNombre" runat="server" Width="250px" Font-Size="8pt" 
                TabIndex="2" Visible="False"></asp:TextBox>
            </td>
        <td class="style12" style="font-size: 12px">
            Web :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtWeb" runat="server" Width="230px" Font-Size="8pt" 
                TabIndex="8"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            <asp:Label ID="lblSegundoNombre" runat="server" Text="Segundo Nombre :" 
                Visible="False"></asp:Label>
        </td>
        <td style="font-size: 12px;" class="style5">
            &nbsp;</td>
        <td class="style4">
            <asp:TextBox ID="txtSegundoNombre" runat="server" Width="250px" Font-Size="8pt" 
                TabIndex="2" Visible="False"></asp:TextBox>
            </td>
        <td class="style12" style="font-size: 12px">
            Celular 1 :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtCelular1" runat="server" Font-Size="8pt" TabIndex="9"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            Proveedor Interno :</td>
        <td style="font-size: 12px;" class="style5">
            &nbsp;</td>
        <td class="style4">
            <asp:CheckBox ID="cbInternoExterno" runat="server" />
            </td>
        <td class="style12" style="font-size: 12px">
            Celular 2 :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtCelular2" runat="server" Font-Size="8pt" TabIndex="10"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5" style="font-size: 12px;">
            Nombre Comercial :</td>
        <td class="style5" style="font-size: 12px;">
            &nbsp;</td>
        <td class="style4">
            <asp:TextBox ID="txtNombreComercial" runat="server" Width="250px" Font-Size="8pt" 
                TabIndex="3"></asp:TextBox>
        </td>
        <td class="style12" style="font-size: 12px">
            Tipo Cuenta :</td>
        <td style="width: 30%">
            <asp:DropDownList ID="ddlTipoCuenta" runat="server" Font-Size="8pt" 
                TabIndex="11">
                <asp:ListItem Value="C">Corriente</asp:ListItem>
                <asp:ListItem Value="M">Maestra</asp:ListItem>
                <asp:ListItem Value="A">Ahorros</asp:ListItem>
                <asp:ListItem Value="B">Interbancaria</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style5" style="font-size: 12px;">
            <asp:Label ID="Label3" runat="server" Text="Dirección :"></asp:Label>
        </td>
        <td class="style5" style="font-size: 12px;">
            &nbsp;</td>
        <td class="style4">
            <asp:TextBox ID="txtDireccion" runat="server" Width="250px" Font-Size="8pt" 
                TabIndex="3"></asp:TextBox>
        </td>
        <td style="font-size: 12px;" class="style12">
            Cuenta Abono :</td>
        <td style="width: 30%">
            <asp:TextBox ID="txtCuentaAbono" runat="server" Width="230px" Font-Size="8pt" 
                TabIndex="12"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5" style="font-size: 12px;">
            <asp:Label ID="Label4" runat="server" Text="Rubro :"></asp:Label>
        </td>
        <td class="style5" style="font-size: 12px;">
            &nbsp;</td>
        <td class="style4">
            <asp:TextBox ID="txtRubro" runat="server" Width="250px" Font-Size="8pt" 
                TabIndex="4"></asp:TextBox>
        </td>
        <td style="font-size: 12px;" class="style12">
            Moneda :</td>
        <td style="width: 30%">
            <asp:DropDownList ID="ddlMoneda" runat="server" DataSourceID="odsMoneda" 
                DataTextField="Nombre" DataValueField="IdMoneda" Font-Size="8pt" 
                TabIndex="13">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="font-size: 12px;" class="style5">
            &nbsp;</td>
        <td style="font-size: 12px;" class="style5">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td class="style12" style="font-size: 12px">
            &nbsp;</td>
        <td style="width: 30%">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="5" style="height: 10px; " align="center">
            <asp:Label ID="lblMensaje" runat="server" Font-Size="8pt" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="5" style="width: 100%">
            <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PerformInsert" 
                ImageUrl="~/img/Update.gif" ToolTip="Insertar" ValidationGroup="grupo" />
            &nbsp; <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                CommandName="Cancel" ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
        </td>
    </tr>
</table>
</fieldset>
            <asp:ObjectDataSource ID="odsTipoDocId" runat="server" 
                SelectMethod="GetTipoDocumentoIdentidadByTipoPersona" 
                TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoIdentidadBL" 
                OldValuesParameterFormatString="original_{0}">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlTipoPersona" Name="tipoPersona" 
                        PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="odsMoneda" runat="server" 
                SelectMethod="GetAllFromMoneda" 
                TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
    </form>
</body>
</html>
