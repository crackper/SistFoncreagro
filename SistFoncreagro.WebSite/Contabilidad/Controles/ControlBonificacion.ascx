<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlBonificacion.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlBonificacion" %>
<style type="text/css">
    .style1
    {
        width: 100%;
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
            Concepto:</td>
        <td colspan="3">
            <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
                DataSourceID="SqlTipoBonificacion" DataTextField="Descripcion" 
                DataValueField="IdTipoBonificacion" EnableLoadOnDemand="True" 
                EnableVirtualScrolling="True" MarkFirstMatch="True" Width="99%">
            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            Cantidad:</td>
        <td width="8%">
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="1" 
                Width="50px" EnableAjaxSkinRendering="False" 
                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                EnableEmbeddedSkins="False">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                        </td>
        <td width="8%">
            Importe:</td>
        <td>
            <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="0" 
                Width="50px" EnableAjaxSkinRendering="False" 
                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                EnableEmbeddedSkins="False">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                        </td>
    </tr>
    <tr>
        <td>
            Glosa</td>
        <td colspan="3">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Rows="2" TextMode="MultiLine" 
                                                                                                Width="99%" CssClass="TextBoxAlignIzquierda"></asp:TextBox>
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
        </td>
    </tr>
    </table>

<asp:SqlDataSource ID="SqlTipoBonificacion" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromTIPOBONIFICACION" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>



