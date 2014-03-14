<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlManttoUnidadMedida.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlManttoUnidadMedida" %>
<table style="width: 620px">
    <tr>
        <td class="style2" style="width: 9%">
            &nbsp;</td>
        <td style="font-size: 9pt; " align="center">
            <table class="style1">
                <tr>
                    <td align="right" class="style3">
                        Descripción :</td>
                    <td align="left">
         <asp:TextBox ID="txtDescripcion" runat="server" Width="220px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtDescripcion" ErrorMessage="Ingrese descripción." 
                            ValidationGroup="grupo">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Abreviatura :</td>
                    <td align="left">
            <asp:TextBox ID="txtAbreviacion" runat="server" Width="220px" ValidationGroup="grupo"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtAbreviacion" ErrorMessage="Ingrese abreviatura." 
                            ValidationGroup="grupo">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="txtAbreviacion" 
                            ErrorMessage="La abreviatura será sólo entre 1 y 5 letras." 
                            ValidationExpression="\D{1,5}" ValidationGroup="grupo">*</asp:RegularExpressionValidator>
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


