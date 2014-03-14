<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlNuevogradoSalarial.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlNuevogradoSalarial" %>
<style type="text/css">

    .style3
    {
        width: 20px;
    }
    .style4
    {
        width: 150px;
    }
</style>
 
 <table class="Texto" width="100%">
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td width="110">
            <asp:TextBox ID="TxtId" runat="server" Height="19px" Visible="False" 
                Width="29px"></asp:TextBox>
        </td>
        <td width="110">
            &nbsp;</td>
        <td width="20">
            &nbsp;</td>
        <td width="120">
            <asp:TextBox ID="txtIdAnterior" runat="server" Height="19px" Width="20px"></asp:TextBox>
        </td>
        <td width="120">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td class="texto" width="110" align="left">
            Grado Salarial:</td>
        <td width="110">
            <asp:TextBox ID="txtGrado" runat="server" Width="100px"></asp:TextBox>
        </td>
        <td width="20">
            &nbsp;</td>
        <td class="texto" width="120">
            Siguiente al grado:</td>
        <td width="120">
            <asp:TextBox ID="txtGradoAnterior" runat="server" Width="100px"></asp:TextBox>
        </td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td width="110" align="left">
            &nbsp;</td>
        <td width="110">
           
        </td>
        <td width="20">
           
            &nbsp;</td>
        <td width="120">
           
            &nbsp;</td>
        <td width="120">
           
            &nbsp;</td>
        <td class="style4">
           
            &nbsp;</td>
        <td>
           
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td width="630" align="left" colspan="6">
            <table width="100%">
                <tr>
                    <td width="190">
                        Remuneración Mínima</td>
                    <td width="20">
                        &nbsp;</td>
                    <td width="190">
                        Remuneración Promedio</td>
                    <td width="20">
                        &nbsp;</td>
                    <td>
                        Remuneración Máxima</td>
                </tr>
                <tr>
                    <td width="190">
                        <asp:TextBox ID="txtRemMin" runat="server" Width="160px"></asp:TextBox>
                    </td>
                    <td width="20">
                        &nbsp;</td>
                    <td width="190">
                        <asp:TextBox ID="txtRemProm" runat="server" Width="160px"></asp:TextBox>
                    </td>
                    <td width="20">
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtRemMax" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td width="110" align="center">
            &nbsp;</td>
        <td width="110">
            &nbsp;</td>
        <td width="20">
            &nbsp;</td>
        <td width="120">
            &nbsp;</td>
        <td width="120">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" width="20">
            &nbsp;</td>
        <td align="left">
            <asp:ImageButton ID="ImgBtnGuardar" runat="server" 
                ImageUrl="~/img/Update.gif" />
&nbsp;<asp:ImageButton ID="ImgBtnCancelar" runat="server" ImageUrl="~/img/Cancel.gif" 
                CommandName="Cancel" />
        &nbsp;</td>
        <td width="110">
            &nbsp;</td>
        <td width="20">
            &nbsp;</td>
        <td width="120">
            &nbsp;</td>
        <td width="120">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>


