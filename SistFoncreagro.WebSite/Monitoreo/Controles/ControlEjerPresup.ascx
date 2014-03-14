<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlEjerPresup.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlEjerPresup" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<table>
    <tr>
        <td align="right" >
            Tipo:</td>
        <td>
            <asp:DropDownList ID="CbTipo" runat="server" Width="168px">
                <asp:ListItem>BUDGET</asp:ListItem>
                <asp:ListItem>FORECAST</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Año Presupuestal:</td>
        <td>
            <telerik:RadNumericTextBox ID="TxtAnio" Runat="server" MaxLength="4" 
                MaxValue="9999" MinValue="1" DataType="System.Int32">
                <NumberFormat DecimalDigits="0" GroupSeparator="" />
            </telerik:RadNumericTextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TxtAnio" ErrorMessage="Valor Requerido"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Código:</td>
        <td>
            <asp:TextBox ID="TxtCodigo" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Fecha de Inicio:</td>
        <td>
            <telerik:RadDatePicker ID="RDIni" Runat="server">
            </telerik:RadDatePicker>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="RDIni" ErrorMessage="Valor requerido"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Fecha Final:</td>
        <td>
            <telerik:RadDatePicker ID="RDFin" Runat="server">
            </telerik:RadDatePicker>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="RDFin" ErrorMessage="Valor Requerido"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="right">
            Mes Inicial:</td>
        <td>
            <asp:DropDownList ID="CbMesIni" runat="server" Width="166px">
                <asp:ListItem Value="ENE">ENERO</asp:ListItem>
                <asp:ListItem Value="FEB">FEBRERO</asp:ListItem>
                <asp:ListItem Value="MAR">MARZO</asp:ListItem>
                <asp:ListItem Value="ABR">ABRIL</asp:ListItem>
                <asp:ListItem Value="MAY">MAYO</asp:ListItem>
                <asp:ListItem Value="JUN">JUNIO</asp:ListItem>
                <asp:ListItem Value="JUL">JULIO</asp:ListItem>
                <asp:ListItem Value="AGO">AGOSTO</asp:ListItem>
                <asp:ListItem Value="SEP">SEPTIEMBRE</asp:ListItem>
                <asp:ListItem Value="OCT">OCTUBRE</asp:ListItem>
                <asp:ListItem Value="NOV">NOVIEMBRE</asp:ListItem>
                <asp:ListItem Value="DIC">DICIEMBRE</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            Estado:</td>
        <td>
            <asp:DropDownList ID="CbEstado" runat="server" Width="168px">
                <asp:ListItem>PROCESO</asp:ListItem>
                <asp:ListItem>CERRADO</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >
            <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/Update.gif" CommandName = "PerformInsert"
            Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
            <asp:ImageButton ID="BtnActualizar" runat="server" CommandName = "Update"
                Visible="<%# not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>"
                ImageUrl="~/img/Update.gif" />
            <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/img/cancel.gif" CommandName = "Cancel"
                ToolTip = "Cancelar" />
        </td>
        <td>
            <asp:HiddenField ID="HFIdEjerPresup" runat="server" />
        </td>
    </tr>
    <tr>
        <td  colspan="2">
           </td>
    </tr>
    </table>

