<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlInstConvenio.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlInstConvenio" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        font-family: Arial;
        font-size: 9pt;
    }
</style>

<table class="style1">
    <tr>
        <td>
            <span class="style2">Institución:</span>
            <telerik:RadComboBox ID="CbInstitucion" Runat="server" Width = "500px" 
                DataSourceID="OdsInstituciones" DataTextField="RazonSocial" 
                DataValueField="IdProveedorCliente" Skin="Hay" CssClass="style2">
            </telerik:RadComboBox>
            <asp:ObjectDataSource ID="OdsInstituciones" runat="server" 
                SelectMethod="GetAllFromProveedorCliente" 
                TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
            </asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Tipo:
            <asp:DropDownList ID="CbTipo" runat="server" Width="178px">
                <asp:ListItem>FINANCIADOR</asp:ListItem>
                <asp:ListItem>EJECUTOR</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Update.gif" 
                CommandName = "PerformInsert" ToolTip="Grabar"/>
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/cancel.gif" CommandName = "Cancel"
                ToolTip="Cancelar" CssClass="style2" />
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
    </tr>
</table>

