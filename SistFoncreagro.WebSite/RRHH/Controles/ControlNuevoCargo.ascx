<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlNuevoCargo.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlNuevoCargo" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 400px;
    }
    .style3
    {
        width: 20px;
    }
</style>
 <div>
 
 <table class="style1">
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="style2" width="400">
            <asp:TextBox ID="TxtIdCargo" runat="server" Height="19px" Visible="False" 
                Width="29px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="style2" width="400" align="left">
            Nombre de Cargo:</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="style2" width="400" align="left">
            <asp:TextBox ID="txtNomCargo" runat="server" TextMode="MultiLine" Width="380px"></asp:TextBox>
        </td>
        <td>
           
        </td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="style2" width="400" align="left">
            Descripción de Cargo:</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="style2" width="400" align="left">
            <asp:TextBox ID="txtDescCargo" runat="server" TextMode="MultiLine" 
                Width="380px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="style2" width="400" align="center">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="style2" width="400" align="left">
            <asp:ImageButton ID="ImgBtnGuardar" runat="server" 
                ImageUrl="~/img/Update.gif" />
&nbsp;<asp:ImageButton ID="ImgBtnCancelar" runat="server" ImageUrl="~/img/Cancel.gif" 
                CommandName="Cancel" />
        &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

</div>