<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlCatalogoVenta.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlCatalogoVenta" %>
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
            <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
                DataSourceID="SqlClasificacion" DataTextField="Clasificacion" 
                DataValueField="IdClasificacion" EnableLoadOnDemand="True" 
                EnableVirtualScrolling="True" Width="100%" MarkFirstMatch="True">
            </telerik:RadComboBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="¡Debe ingresar la Clasificación!" 
                ControlToValidate="RadComboBox1" Display="Dynamic"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Descripción:</td>
        <td colspan="4">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="TextBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la descripción!"></asp:RequiredFieldValidator>
                                                                                            </td>
    </tr>
    <tr>
        <td>
            Unidad de Medida:</td>
        <td>
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="SqlUnidadMedida" DataTextField="Descripcion" 
                                                                                                DataValueField="IdUnidadMedida">
                                                                                            </asp:DropDownList>
                                                                                            </td>
        <td width="5%">
                                                                                            Tipo:</td>
        <td>
                                                                                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlTipo" 
                                                                                                DataTextField="Tipo" DataValueField="IdTipoVenta">
                                                                                            </asp:DropDownList>
                                                                                            </td>
        <td>
                                                                                            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Precio Referencia:</td>
        <td>
                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" Width="50px" 
                                                                                                Value="0">
                                                                                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                            </telerik:RadNumericTextBox>
                                                                                            </td>
        <td>
                                                                                            &nbsp;</td>
        <td>
                                                                                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Afecto IGV" />
                                                                                            </td>
        <td>
                                                                                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Afecto Detracción" />
                                                                                            </td>
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

<asp:SqlDataSource ID="SqlClasificacion" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromCLASIFICACIONCATALOGOVENTAS" 
    SelectCommandType="StoredProcedure"></asp:SqlDataSource>

<asp:SqlDataSource ID="SqlUnidadMedida" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromUnidadMedidad" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlTipo" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromTIPOVENTA" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>


