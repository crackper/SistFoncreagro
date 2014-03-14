<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlVentas.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlVentas" %>
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
   

    </style>
<table class="style1">
    <tr>
        <td width="8%">
            Catalogo:</td>
        <td colspan="5">
            <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
                DataSourceID="SqlCatalogo" DataTextField="Descripcion" 
                DataValueField="IdCatVenta" EnableLoadOnDemand="True" 
                EnableVirtualScrolling="True" MarkFirstMatch="True" Width="99%" 
                AllowCustomText="True" TabIndex="17">
            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            Cantidad:</td>
        <td width="8%">
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="1" 
                Width="60px" EnableAjaxSkinRendering="False" 
                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                EnableEmbeddedSkins="False" AutoPostBack="True" TabIndex="18">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                        </td>
        <td width="8%">
            P. Unitario:</td>
        <td width="8%">
            <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="0" 
                Width="60px" EnableAjaxSkinRendering="False" 
                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                EnableEmbeddedSkins="False" AutoPostBack="True" TabIndex="19">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                <NumberFormat DecimalDigits="5" />
            </telerik:RadNumericTextBox>
                                                                                        </td>
        <td width="8%">
            Importe:</td>
        <td>
            <telerik:RadNumericTextBox ID="RadNumericTextBox4" Runat="server" Value="1" 
                Width="60px" EnableAjaxSkinRendering="False" 
                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                EnableEmbeddedSkins="False" TabIndex="20">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                        </td>
    </tr>
    <tr>
        <td>
            Glosa</td>
        <td colspan="5">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Rows="2" TextMode="MultiLine" 
                                                                                                Width="99%" CssClass="TextBoxAlignIzquierda" TabIndex="21"></asp:TextBox>
                                                                                        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
            <asp:TextBox ID="TextBox3" runat="server" Visible="False" TabIndex="6"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" Visible="False" TabIndex="7"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    </table>

<asp:SqlDataSource ID="SqlCatalogo" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromCATALOGOVENTAS" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>


