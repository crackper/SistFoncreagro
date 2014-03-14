<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaAutorizacion.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaAutorizacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Autorizacion</title>
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
.Texto
{
   
    font-family: Arial;
    font-size: 8pt;
}
.TextBoxAlignIzquierda
{
	text-align: left;
	text-transform: uppercase;
}
   

    a:link, a:visited
{
    color: #034af3;
}


    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" width="50%">
            <tr>
                <td colspan="4" style="font-weight: 700; font-size: small; text-align: center;">
                    <asp:Label ID="Label1" runat="server" CssClass="Texto" Font-Size="10pt" 
                        Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="font-size: 4pt">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="Texto">
                    Fecha Permiso: </td>
                <td class="Texto">

        
            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                </td>
                <td class="Texto">
                    Estado:</td>
                <td class="Texto">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="Texto" 
                        TabIndex="2">
                        <asp:ListItem Value="1">Activo</asp:ListItem>
                        <asp:ListItem Value="0">Inactivo</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="Texto">
                    Hora Inicio:</td>
                <td class="Texto">
                   <asp:TextBox ID="TextBox12" runat="server" Width="70px" TabIndex="3"></asp:TextBox>
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender4" 
                        runat="server" 
                                                                                                                        
                        AcceptAMPM="true" ErrorTooltipEnabled="true" 
                        InputDirection="RightToLeft" 
                                                                                                                        
                        Mask="99:99" 
                        MaskType="Time" 
                                                                                                                        
                        OnFocusCssClass="MaskedEditFocus" 
                        OnInvalidCssClass="MaskedEditError" 
                                                                                                                        
                        TargetControlID="TextBox12" UserTimeFormat="TwentyFourHour">
                                                                                                                    </asp:MaskedEditExtender>
                                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                                        ControlToValidate="TextBox12" Display="Dynamic" 
                                                                                                                        ErrorMessage="¡Debe ingresar la Hora!"></asp:RequiredFieldValidator></td>
                <td class="Texto">
                    Hora FIn:</td>
                <td class="Texto">
                    <asp:TextBox ID="TextBox1" runat="server" 
                        TabIndex="4" 
                                                                                                                        
                        Width="70px" />
                                                                                                                   
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender1" 
                        runat="server" 
                                                                                                                        
                        AcceptAMPM="true" ErrorTooltipEnabled="true" 
                        InputDirection="RightToLeft" 
                                                                                                                        
                        Mask="99:99" MaskType="Time" 
                        MessageValidatorTip="true" 
                                                                                                                        
                        OnFocusCssClass="MaskedEditFocus" 
                        OnInvalidCssClass="MaskedEditError" 
                                                                                                                        
                        TargetControlID="TextBox1" UserTimeFormat="TwentyFourHour">
                                                                                                                    </asp:MaskedEditExtender>
                                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                                        ControlToValidate="TextBox1" Display="Dynamic" 
                                                                                                                        ErrorMessage="¡Debe ingresar la Hora!"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="Texto" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="Texto" colspan="4">
                    <table class="style1">
                        <tr>
                            <td style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Grabar" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
   
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
   
    </form>
</body>
</html>
