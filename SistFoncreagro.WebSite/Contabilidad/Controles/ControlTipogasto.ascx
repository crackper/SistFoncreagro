<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlTipogasto.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlTipogasto" %>

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

   

    </style>

<table align="center" class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td>
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                    <tr class="Texto">
                                                                                        <td width="8%" style="text-align: left; font-size: 9pt;">
                                                                                            Descripción:</td>
                                                                                        <td width="92%">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="89%" 
                                                                                                style="font-family: Arial; font-size: 9pt"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="8%" style="text-align: left; font-size: 9pt;">
                                                                                            Cuenta:</td>
                                                                                        <td width="92%">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="IdPlan" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" ShowMoreResultsBox="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="90%" EmptyMessage="Ingrese la Cuenta..." style="font-family: Arial; font-size: 9pt">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Cuenta Contable!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    </table>
        </td>
    </tr>
    <tr>
        <td style="text-align: left">
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


