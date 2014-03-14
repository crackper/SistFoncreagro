<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlManttoMarca.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlManttoMarca" %>
<table style="width: 500px">
    <tr>
        <td class="style2" style="width: 12%">
            &nbsp;</td>
        <td style="font-size: 9pt; width: 12%;">
            Descripción :</td>
        <td style="width: 34%;">
         <asp:TextBox ID="txtDescripcion" runat="server" Width="250px"></asp:TextBox>
        </td>
        <td style="width: 8%" align="right">
            <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PerformInsert" 
                ImageUrl="~/img/Update.gif" ToolTip="Insertar" ValidationGroup="grupo" />
            <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Update" 
                ImageUrl="~/img/Update.gif" ToolTip="Actualizar" 
                CausesValidation="False" ValidationGroup="grupo" />
            <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                CommandName="Cancel" ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
        </td>
    </tr>
</table>


