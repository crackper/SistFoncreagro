<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlActitud.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlActitud" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>



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
   

    .style3
    {
        height: 26px;
    }
   

    </style>



<table class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td style="text-align: left">
                                                                                <table cellpadding="0" cellspacing="0" >
                                                                                                                                                                        
                                                                                    <tr class="Texto">
                                                                                        <td>
                                                                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Fecha:</td>
                                                                                                    <td class="style3" colspan="5">
                                                                                                    <asp:TextBox ID="txtDate" runat="server" TabIndex="1" 
                                                                                                        Width="70px" />
                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender" runat="server" 
                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                        TargetControlID="txtDate" />
                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator" runat="server" 
                                                                                                        ControlExtender="MaskedEditExtender" ControlToValidate="txtDate" 
                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                                                                                                        ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                        ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Actitud:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList4" runat="server" TabIndex="8">
                                                                                                                <asp:ListItem Value="APOYO TOTAL">APOYO TOTAL</asp:ListItem>
                                                                                                                <asp:ListItem>APOYO MODERADO</asp:ListItem>
                                                                                                                <asp:ListItem>NEUTRAL</asp:ListItem>
                                                                                                                <asp:ListItem Value="OPOSICON MODERADA">OPOSICION MODERADA</asp:ListItem>
                                                                                                                <asp:ListItem>OPOSICION RADICAL</asp:ListItem>
                                                                                                                <asp:ListItem>SIN DETERMINAR</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                    </td>
                                                                                                    <td class="style3">
                                                                                                        Poder:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList5" runat="server" TabIndex="8">
                                                                                                                <asp:ListItem>ALTO</asp:ListItem>
                                                                                                                <asp:ListItem>MEDIO</asp:ListItem>
                                                                                                                <asp:ListItem>BAJO</asp:ListItem>
                                                                                                                <asp:ListItem Value="NINGUNO"></asp:ListItem>
                                                                                                                <asp:ListItem>SIN DETERMINAR</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                    </td>
                                                                                                    <td class="style3">
                                                                                                        Dialogo:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList6" runat="server" TabIndex="8">
                                                                                                                <asp:ListItem>CON DIALOGO</asp:ListItem>
                                                                                                                <asp:ListItem>SIN DIALOGO</asp:ListItem>
                                                                                                                <asp:ListItem>INTRANSIGENTE</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td>
                                                                                                        Comentario:</td>
                                                                                                    <td colspan="5">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="100%" 
                                                                                                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td>
                                                                                                        Plan de Accion:</td>
                                                                                                    <td colspan="5">
                                                                                            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="100%" 
                                                                                                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                    
                                                                                    </table>
                                                                                                    </td>
    </tr>
    <tr>
        <td style="text-align: left; font-family: Arial; font-size: 8pt;">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             &nbsp;</td>
    </tr>
    </table>

        



                                                