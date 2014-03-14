<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlVehiculo.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlVehiculo" %>
  <%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<style type="text/css">
    .style1
    {
        width: 100%;
         font-family: Arial;
    font-size: 8pt;
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
   

   

    </style>

   

    </style>

<table class="style1">
    <tr>
        <td width="10%">
            Marca:</td>
        <td width="38%">
                                                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="98%" 
                                                                                                                                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" 
                runat="server" 
                                                                                                                                
                ControlToValidate="TextBox1" 
                Display="Dynamic" 
                                                                                                                                
                ErrorMessage="¡Debe ingresar la Marca!"></asp:RequiredFieldValidator>
                                                                                                                            </td>
        <td width="12%">
            Modelo:</td>
        <td width="38%">
                                                                                                                            <asp:TextBox ID="TextBox2" runat="server" CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" 
                runat="server" 
                                                                                                                                
                ControlToValidate="TextBox2" 
                Display="Dynamic" 
                                                                                                                                
                ErrorMessage="¡Debe ingresar el Modelo!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Placa:</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" 
                runat="server" 
                                                                                                                                
                ControlToValidate="TextBox4" 
                Display="Dynamic" 
                                                                                                                                
                ErrorMessage="¡Debe ingresar la Placa!"></asp:RequiredFieldValidator>
        </td>
        <td>
            Tipo:</td>
        <td>
                                                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" Width="140px">
                                                                                                                                <asp:ListItem>PROPIO</asp:ListItem>
                                                                                                                                <asp:ListItem>ALQUILADO</asp:ListItem>
                                                                                                                            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Implementación:</td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Selected="True" Value="S">CONFORME</asp:ListItem>
                <asp:ListItem Value="N">NO CONFORME</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            Mantenimiento:</td>
        <td>
                                                                                                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                                                                                                                                <asp:ListItem Selected="True" Value="S">CONFORME</asp:ListItem>
                                                                                                                                <asp:ListItem Value="N">NO CONFORME</asp:ListItem>
                                                                                                                            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            Observaciones:</td>
        <td colspan="3">
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="98%" 
                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Incidentes:</td>
        <td colspan="3">
            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Width="98%" 
                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:ImageButton ID="ImageButton15" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton16" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
<asp:ImageButton ID="ImageButton17" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             </td>
    </tr>
</table>








                                                



