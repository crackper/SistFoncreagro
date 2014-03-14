<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlContabilizacionVenta.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlContabilizacionVenta" %>
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
        <td width="15%">
            Clasificación</td>
        <td width="85%">
            <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
                DataSourceID="SqlClasificacion" DataTextField="Clasificacion" 
                DataValueField="IdClasificacion" EnableLoadOnDemand="True" 
                EnableVirtualScrolling="True" Width="100%" MarkFirstMatch="True">
            </telerik:RadComboBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="¡Debe ingresar la Clasificacion!" 
                ControlToValidate="RadComboBox1" Display="Dynamic"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Proyecto:</td>
        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox2" Runat="server" 
                AllowCustomText="True" 
                                                                                                
                AutoPostBack="False" DataSourceID="odsProyecto" 
                DataTextField="AreaProyecto" 
                                                                                                
                DataValueField="IdProyecto" 
                EnableLoadOnDemand="True" 
                                                                                                
                EnableVirtualScrolling="True" ItemsPerRequest="10" 
                MarkFirstMatch="True" 
                                                                                                
                ShowMoreResultsBox="True" 
                                                                                                
                ValidationGroup="Transaccion" Width="100%">
                                                                                            </telerik:RadComboBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="¡Debe ingresar el Proyecto!" ControlToValidate="RadComboBox2" Display="Dynamic"></asp:RequiredFieldValidator>
                                                                                            </td>
    </tr>
    <tr>
        <td>
            Cuenta Venta Interna:</td>
        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox3" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="IdPlan" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" ShowMoreResultsBox="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" DataSourceID="odsPlanContable" EnableAjaxSkinRendering="False" 
                EnableEmbeddedBaseStylesheet="False" 
                                                                                                
                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                                                                                            </telerik:RadComboBox>
                                                                                            </td>
    </tr>
    <tr>
        <td>
            Cuenta Venta Terceros:</td>
        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox4" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="IdPlan" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" ShowMoreResultsBox="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" DataSourceID="odsPlanContable1" EnableAjaxSkinRendering="False" 
                EnableEmbeddedBaseStylesheet="False" 
                                                                                                
                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
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
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
    </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                

        




<asp:ObjectDataSource ID="odsPlanContable" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:SqlDataSource ID="SqlClasificacion" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromCLASIFICACIONCATALOGOVENTAS" 
    SelectCommandType="StoredProcedure"></asp:SqlDataSource>

<asp:ObjectDataSource ID="odsPlanContable1" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

