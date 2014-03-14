<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlClasificacionVentas.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlClasificacionVentas" %>
<style type="text/css">
    .style1
    {
        width: 100%;
         font-family: Arial;
         font-size: 8pt;
    }
.Texto
{
   
    font-family: Arial;
    font-size: 8pt;
}
.TextBoxAlignIzquierda
{
	text-align: left;
	text-transform: uppercase;
}
   

    .RadInput_Default
{
	font:12px "segoe ui",arial,sans-serif;
}

.RadInput
{
	vertical-align:middle;
}


    </style>

<table class="style1">
    <tr>
        <td width="13%">
            Clasificación</td>
        <td width="90%" colspan="4">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="¡Debe ingresar la Clasificación!" 
                ControlToValidate="TextBox1" Display="Dynamic"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Especie Animal:</td>
        <td>
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="SqlEspecie" DataTextField="especie" 
                                                                                                DataValueField="idespecieanimal" AppendDataBoundItems="True">
                                                                                                <asp:ListItem Selected="True" Value="N">Ninguno</asp:ListItem>
                                                                                            </asp:DropDownList>
                                                                                            </td>
        <td width="5%">
                                                                                            &nbsp;</td>
        <td>
                                                                                            &nbsp;</td>
        <td>
                                                                                            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
    </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    </table>

<asp:SqlDataSource ID="SqlEspecie" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromEspecieAnimal" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>





