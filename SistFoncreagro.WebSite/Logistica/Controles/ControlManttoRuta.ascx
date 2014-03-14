<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlManttoRuta.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlManttoRuta" %>
<table style="width: 620px">
    <tr>
        <td class="style2" style="width: 9%">
            &nbsp;</td>
        <td style="font-size: 9pt; " align="center">
            <table class="style1">
                <tr>
                    <td align="right" class="style3">
                        <asp:Label ID="lblCodigotitulo" runat="server" Text="Codigo :" Visible="False"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:Label ID="lblCodigo" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Nombre :</td>
                    <td align="left">
         <asp:TextBox ID="txtNombre" runat="server" Width="350px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtNombre" ErrorMessage="Ingrese descripción." 
                            ValidationGroup="grupo">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Descrípción :</td>
                    <td align="left">
            <asp:TextBox ID="txtDescripcion" runat="server" Width="350px" ValidationGroup="grupo" 
                            TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtDescripcion" ErrorMessage="Ingrese abreviatura." 
                            ValidationGroup="grupo">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style2" style="width: 9%">
            &nbsp;</td>
        <td style="font-size: 9pt; " align="center">
            <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PerformInsert" 
                ImageUrl="~/img/Update.gif" ToolTip="Insertar" ValidationGroup="grupo" />
            <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Update" 
                ImageUrl="~/img/Update.gif" ToolTip="Actualizar" 
                CausesValidation="False" />
            &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                CommandName="Cancel" ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
        </td>
    </tr>
    <tr>
        <td class="style2" style="width: 9%">
            &nbsp;</td>
        <td style="font-size: 9pt; " align="center">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ValidationGroup="grupo" />
        </td>
    </tr>
</table>