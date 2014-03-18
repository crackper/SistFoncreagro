<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlTransaccion.ascx.vb" Inherits="SistFoncreagro.WebSite.LineaCompras_Control" %>

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

<table align="center" class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td>
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                    <tr class="Texto">
                                                                                        <td width="8%" style="text-align: left">
                                                                                            Cuenta:</td>
                                                                                        <td width="92%">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="IdPlan" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" EmptyMessage="Ingrese la Cuenta..." EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                EnableAjaxSkinRendering="False" EnableVirtualScrolling="True">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Cuenta Contable!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="8%" style="text-align: left" >
                                                                                            C. Costo:</td>
                                                                                        <td width="92%">
            <telerik:RadComboBox ID="RadComboBox2" Runat="server" Width="100%" 
                 EnableLoadOnDemand="True" MarkFirstMatch="True" 
                DataSourceID="SqlDataSource1" DataTextField="CodigoElemGasto" 
                DataValueField="IdCCosto" AllowCustomText="True" 
                EmptyMessage="Ingrese C. Costo..." EnableAjaxSkinRendering="False">
            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el C. Costo!" Enabled="False"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
        </td>
    </tr>
    <tr>
        <td>
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                
                                                                                    <tr class="Texto">
                                                                                        <td width="8%" style="text-align: left">
                                                                                            Cargo:</td>
                                                                                        <td width="10%" style="text-align: left">
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="0" 
                Width="50px" EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                        </td>
                                                                                        <td style="text-align: center" width="8%">
                                                                                            Abono:</td>
                                                                                        <td width="10%" style="text-align: left">
            <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="0" 
                Width="50px" EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                        </td>
                                                                                        <td style="text-align: center" width="8%">
                                                                                            Glosa:</td>
                                                                                        <td width="56%">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Rows="2" TextMode="MultiLine" 
                                                                                                Width="99%" CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
        </td>
    </tr>
    <tr>
        <td style="text-align: left">
            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderColor="White" 
                BorderStyle="None" ForeColor="White" Visible="False"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" /></td>
    </tr>
</table>
<asp:ObjectDataSource ID="odsPlanContable" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        




<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetCCOSTOByIdProyecto1" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:ControlParameter ControlID="TextBox1" Name="idProyecto" 
            PropertyName="Text" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>


                                                
                                                
        






                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContableCompras" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameterCompras" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

        




