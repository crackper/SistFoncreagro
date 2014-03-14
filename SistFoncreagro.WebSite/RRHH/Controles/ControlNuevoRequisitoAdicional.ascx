<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlNuevoRequisitoAdicional.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlNuevoRequisitoAdicional" %>
<table width="100%">
    <tr>
        <td width="20">
            &nbsp;</td>
        <td width="300">
            Requisito adicional:</td>
        <td width="20">
            &nbsp;</td>
        <td width="200">
            Condición:</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td width="20">
            &nbsp;</td>
        <td width="300">
            <asp:TextBox ID="txtRequisito" runat="server" Width="295px"></asp:TextBox>
        </td>
        <td width="20">
            &nbsp;</td>
        <td width="200">
            <asp:DropDownList ID="ddlCondicion" runat="server" Width="195px">
                <asp:ListItem Value="I">Indispensable</asp:ListItem>
                <asp:ListItem Value="P">De Preferencia</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td width="20">
            &nbsp;</td>
        <td width="300">
            <asp:ImageButton ID="ImgBtnGuardar" runat="server" 
                ImageUrl="~/img/Update.gif" />
&nbsp;<asp:ImageButton ID="ImgBtnCancelar" runat="server" ImageUrl="~/img/Cancel.gif" 
                CommandName="Cancel" />
        </td>
        <td width="20">
            &nbsp;</td>
        <td width="200">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

