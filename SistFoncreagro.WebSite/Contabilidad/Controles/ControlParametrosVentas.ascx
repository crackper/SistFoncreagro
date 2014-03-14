<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlParametrosVentas.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlParametrosVentas" %>
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
            Parámetro:</td>
        <td colspan="3">
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlParametro" 
                DataTextField="Parametro" DataValueField="IdTipoParametro">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td width="8%">
            Catalogo:</td>
        <td colspan="3">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="IdPlan" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" 
                EmptyMessage="Ingrese la Cuenta..." EnableVirtualScrolling="True">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Cuenta Contable!"></asp:RequiredFieldValidator>
                                                                                        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
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
    </tr>
    </table>

<asp:SqlDataSource ID="SqlParametro" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromTIPOPARAMETROVENTAS" 
    SelectCommandType="StoredProcedure"></asp:SqlDataSource>
<asp:ObjectDataSource ID="odsPlanContable" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        







