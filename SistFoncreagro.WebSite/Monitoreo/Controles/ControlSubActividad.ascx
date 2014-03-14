<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlSubActividad.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlSubActividad" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>



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
   

    .style3
    {
        height: 26px;
    }
   

    </style>



<table class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td style="text-align: left">
                                                                                <table cellpadding="0" cellspacing="0" >
                                                                                                                                                                        
                                                                                    <tr class="Texto">
                                                                                        <td>
                                                                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Actividad:</td>
                                                                                                    <td class="style3" colspan="5">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="Actividad" 
                                                                                                DataValueField="IdProyAct" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                                                                                            AutoPostBack="True" DataSourceID="SqlActividad">
                                                                                            </telerik:RadComboBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Elemento Gasto:</td>
                                                                                                    <td class="style3" colspan="5">
                                                                                            <telerik:RadComboBox ID="RadComboBox9" Runat="server" DataTextField="NomElemGasto" 
                                                                                                DataValueField="IdElemGasto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                                                                                            AutoPostBack="True" DataSourceID="SqlElementoGasto">
                                                                                            </telerik:RadComboBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Codigo</td>
                                                                                                    <td class="style3">
                                                                                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                                                                        </td>
                                                                                                    <td class="style3">
                                                                                                        Unidad:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                                                                                    </td>
                                                                                                    <td class="style3">
                                                                                                        Porcentaje:</td>
                                                                                                    <td class="style3">
                                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server">
                                                                                                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                                <NumberFormat DecimalDigits="0" />
                                                                                                            </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                    
                                                                                    </table>
                                                                                                    </td>
    </tr>
    <tr>
        <td style="text-align: left; font-family: Arial; font-size: 8pt;">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             &nbsp;</td>
    </tr>
    </table>

        



                                                <asp:SqlDataSource ID="SqlActividad" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetCompActProy" 
    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:SessionParameter DefaultValue="" Name="IdProyecto" 
                                                            SessionField="IdProyecto" Type="Int32" />
                                                    </SelectParameters>
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlElementoGasto" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromELEMENTOGASTO" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>


        



                                                