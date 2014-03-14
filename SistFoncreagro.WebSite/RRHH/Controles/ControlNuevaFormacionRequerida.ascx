<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlNuevaFormacionRequerida.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlFormacionRequerida" %>
<table class="Texto" width="100%">
    <tr>
        <td width="20">
            &nbsp;</td>
        <td width="400">
            Formación
        </td>
        <td width="30">
            &nbsp;</td>
        <td width="130">
            Condición:</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td width="20">
            &nbsp;</td>
        <td width="400">
            <asp:TextBox ID="txtFormacion" runat="server" Width="395px"></asp:TextBox>
        </td>
        <td width="30">
            &nbsp;</td>
        <td width="130">
            <asp:DropDownList ID="ddlCondicion" runat="server" Width="128px">
                <asp:ListItem>O</asp:ListItem>
                <asp:ListItem>Y</asp:ListItem>
                <asp:ListItem Value="depreferencia">De preferencia</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td width="20">
            &nbsp;</td>
        <td width="400">
            <asp:ImageButton ID="ImgBtnGuardar" runat="server" 
                ImageUrl="~/img/Update.gif" />
            <asp:ImageButton ID="ImgBtnCancelar" runat="server" ImageUrl="~/img/Cancel.gif" 
                CommandName="Cancel" />
        </td>
        <td width="30">
            &nbsp;</td>
        <td width="130">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

