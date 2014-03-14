<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlObservacionConvenio.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlObservacionConvenio" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 109px;
    }
</style>

<table class="style1" style="font-family: Arial; font-size: 9pt">
    <tr>
        <td class="style2">
            <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/Update.gif" CommandName = "PerformInsert"
            Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>"/>
            <asp:ImageButton ID="BtnActualizar" runat="server" CommandName = "Update"
                Visible="<%# not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>"
                ImageUrl="~/img/Update.gif" />
            <asp:ImageButton ID="BtnCancelar" runat="server" CommandName="Cancel" CausesValidation = "false"
                ImageUrl="~/img/cancel.gif"  />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="right" class="style2">
            Observacion:</td>
        <td>
            <asp:TextBox ID="TxtObs" runat="server" TextMode="MultiLine" Width="855px" style="text-transform:uppercase;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

