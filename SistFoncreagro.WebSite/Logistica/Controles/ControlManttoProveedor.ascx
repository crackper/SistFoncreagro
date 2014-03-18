<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlManttoProveedor.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlManttoProveedor" %>

<style type="text/css">
    .style2
    {
    }
    .style10
    {
        width: 250px;
    }
</style>
<table style="with: 100%">
    <tr>
        <td rowspan="10" style="width: 2%">
            &nbsp;</td>
        <td colspan="2" style="height: 10px; width: 50%;">
        </td>
        <td style="width: 6%" rowspan="9">
            &nbsp;</td>
        <td style="height: 10px; width: 40%;" colspan="2">
            </td>
        <td class="style2" style="width: 2%" rowspan="10">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2" style="width: 40%">
            DATOS GENERALES</td>
        <td colspan="2" style="width: 40%">
            OTROS</td>
    </tr>
    <tr>
        <td style="width: 10%">
            <asp:Label ID="Label1" runat="server" Text="Ruc :"></asp:Label>
        </td>
        <td class="style10" style="width: 40%">
            <asp:TextBox ID="txtRuc" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtRuc" ErrorMessage="Ingrese RUC" Font-Size="8pt" 
                ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        </td>
        <td style="width: 10%">
            <asp:Label ID="Label6" runat="server" Text="Contacto :"></asp:Label>
        </td>
        <td style="width: 30%">
            <asp:TextBox ID="txtContacto" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 10%">
            <asp:Label ID="Label8" runat="server" Text="Razón Social :"></asp:Label>
        </td>
        <td class="style10" style="width: 40%">
            <asp:TextBox ID="txtRazonSocial" runat="server" Width="310px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtRazonSocial" ErrorMessage="Ingrese Razón Social" 
                Font-Size="8pt" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        </td>
        <td style="width: 10%">
            <asp:Label ID="Label9" runat="server" Text="Web :"></asp:Label>
        </td>
        <td style="width: 30%">
            <asp:TextBox ID="txtWeb" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 10%">
            <asp:Label ID="Label3" runat="server" Text="Dirección :"></asp:Label>
        </td>
        <td class="style10" style="width: 40%">
            <asp:TextBox ID="txtDireccion" runat="server" Width="310px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtDireccion" ErrorMessage="Ingrese Dirección" 
                Font-Size="8pt" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        </td>
        <td style="width: 10%">
            <asp:Label ID="Label10" runat="server" Text="E-Mail :"></asp:Label>
        </td>
        <td style="width: 30%">
            <asp:TextBox ID="txtMail" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 10%">
            <asp:Label ID="Label4" runat="server" Text="Rubro :"></asp:Label>
        </td>
        <td class="style10" style="width: 40%">
            <asp:TextBox ID="txtRubro" runat="server" Width="310px"></asp:TextBox>
        </td>
        <td style="width: 10%">
            <asp:Label ID="Label11" runat="server" Text="Teléfono 2 :"></asp:Label>
        </td>
        <td style="width: 30%">
            <asp:TextBox ID="txtTelefono2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 10%">
            <asp:Label ID="Label5" runat="server" Text="Ciudad :"></asp:Label>
        </td>
        <td class="style10" style="width: 40%">
            <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
        </td>
        <td style="width: 10%">
            <asp:Label ID="Label12" runat="server" Text="Celular 1 :"></asp:Label>
        </td>
        <td style="width: 30%">
            <asp:TextBox ID="txtCelular1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 10%">
            <asp:Label ID="Label7" runat="server" Text="Teléfono :"></asp:Label>
        </td>
        <td class="style10" style="width: 40%">
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        </td>
        <td style="width: 10%">
            <asp:Label ID="Label13" runat="server" Text="Celular 2 :"></asp:Label>
        </td>
        <td style="width: 30%">
            <asp:TextBox ID="txtCelular2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="height: 10px; width: 50%;">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ValidationGroup="grupo" Font-Size="8pt" />
        </td>
        <td style="height: 10px; width: 40%;" colspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" colspan="5" style="width: 100%">
            <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PerformInsert" 
                ImageUrl="~/img/Update.gif" ToolTip="Insertar" ValidationGroup="grupo" />
            <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Update" 
                ImageUrl="~/img/Update.gif" ToolTip="Actualizar" 
                CausesValidation="False" ValidationGroup="grupo" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                CommandName="Cancel" ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
        </td>
    </tr>
</table>


