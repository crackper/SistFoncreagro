<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlNuevaHabilidad.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlNuevaHabilidad" %>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>

<table class="style1" width="100%">
    <tr>
        <td width="20">
            &nbsp;</td>
        <td align="left" valign="bottom" width="300">
            Elija una Habilidad:</td>
        <td width="20">
            &nbsp;</td>
        <td align="left" rowspan="2" valign="top" width="350">
            <asp:TextBox ID="txtDescripcion" runat="server" BorderColor="#666666" 
                BorderStyle="Solid" BorderWidth="1px" Height="50px" TextMode="MultiLine" 
                Width="345px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td width="20">
            &nbsp;</td>
        <td valign="top" width="300">
            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" 
                DataSourceID="XmlDS" EnableLoadOnDemand="True" Skin="Hay" Width="290px">
            </telerik:RadComboBox>
            <asp:XmlDataSource ID="XmlDS" runat="server" 
                DataFile="~/RRHH/XML/XMLVarios.xml" XPath="Varios/Habilidades/habilidad">
            </asp:XmlDataSource>
        </td>
        <td width="20">
            &nbsp;</td>
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
        <td width="350">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

