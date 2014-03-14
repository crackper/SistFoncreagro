<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlDetalleEncuesta.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlDetalleEncuesta" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
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
        <td width="12%">
            Criterio de Evaluación:</td>
        <td width="93%">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" 
                DataSourceID="SqlCriterios" 
                DataTextField="Descripcion" 
                                                                                                                                
                DataValueField="IdCaracteristica" 
                EnableLoadOnDemand="True" 
                                                                                                                                
                EnableVirtualScrolling="True" ItemsPerRequest="10" 
                MarkFirstMatch="True" 
                                                                                                                                
                ShowMoreResultsBox="True" TabIndex="16" 
                ValidationGroup="Transaccion" 
                                                                                                                                
                Width="50%" Skin="Hay" AutoPostBack="True">
                                                                                                                            </telerik:RadComboBox>
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
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             </td>
    </tr>
</table>

<asp:SqlDataSource ID="SqlCriterios" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetCARACTERISTICADetallado" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>


