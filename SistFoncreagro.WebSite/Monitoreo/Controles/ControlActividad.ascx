<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlActividad.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlActividad" %>
<table style="font-family: Arial; font-size: 9pt">
    <tr>
        <td align="right" >
            Código:</td>
        <td>
            <asp:TextBox ID="TxtCodigo" runat="server" style="text-transform :uppercase" 
                MaxLength="3" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="TxtIdActividad" runat="server" 
                style="text-transform :uppercase" Visible="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Nombre:</td>
        <td class="style4">
            <asp:TextBox ID="TxtNombre" runat="server" Height="50px" TextMode="MultiLine" 
                Width="700px" style="text-transform :uppercase"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Descripción:</td>
        <td class="style6">
            <asp:TextBox ID="TxtDesc" runat="server" Height="50px" TextMode="MultiLine" 
                Width="700px" style="text-transform :uppercase"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/Update.gif" CommandName = "PerformInsert"
            Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
            <asp:ImageButton ID="BtnActualizar" runat="server" CommandName = "Update"
                ImageUrl="~/img/Update.gif"
                
                Visible="<%# not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/cancel.gif" 
                ToolTip="Cancelar" CommandName = "Cancel" CausesValidation="False" 
                />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    </table>

