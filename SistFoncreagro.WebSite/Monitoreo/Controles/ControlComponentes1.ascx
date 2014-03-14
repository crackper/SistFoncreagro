<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlComponentes1.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlComponentes1" %>

<table style="font-family: Arial; font-size: 9pt">
    <tr>
        <td align="right" >
            Código:</td>
        <td>
            <asp:TextBox ID="TxtCodigo" runat="server" style="text-transform :uppercase" 
                MaxLength="3" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Nombre:</td>
        <td >
            <asp:TextBox ID="TxtNombre" runat="server" Height="50px" TextMode="MultiLine" 
                Width="700px" style="text-transform :uppercase"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Descripción:</td>
        <td>
            <asp:TextBox ID="TxtDesc" runat="server" Height="50px" TextMode="MultiLine" 
                Width="700px" style="text-transform :uppercase"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" >
            <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/Update.gif" CommandName = "PerformInsert"
            Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
            <asp:ImageButton ID="BtnActualizar" runat="server" CommandName = "Update"
                ImageUrl="~/img/Update.gif"
                
                Visible="<%# not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/cancel.gif" 
                ToolTip="Cancelar" CommandName = "Cancel" CausesValidation="False" 
                />
            <asp:TextBox ID="TxtIdComponente" runat="server" 
                style="text-transform :uppercase" Visible="False"></asp:TextBox>
        </td>
    </tr>
    </table>

