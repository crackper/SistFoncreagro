<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlDetraccion.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlDetraccion" %>

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

   

    .RadInput_Default
{
	font:12px "segoe ui",arial,sans-serif;
}

.RadInput
{
	vertical-align:middle;
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

<table align="center" class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td>
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Código:</td>
                                                                                        <td width="88%">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Width="50px" MaxLength="3"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Código!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Descripción:</td>
                                                                                        <td width="88%">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="89%" 
                                                                                                style="font-family: Arial; font-size: 9pt"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                ControlToValidate="TextBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Descripción!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Porcentaje:</td>
                                                                                        <td width="88%">
            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" Value="0" 
                Width="30px">
                <NumberFormat DecimalDigits="1" />
            </telerik:RadNumericTextBox>%
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadNumericTextBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Porcentaje!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Cuenta Cargo:</td>
                                                                                        <td width="88%">
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
                                                                                            </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Cuenta 
                                                                                            Abono:</td>
                                                                                        <td width="88%">
                                                                                            <telerik:RadComboBox ID="RadComboBox2" 
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
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
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
<asp:ObjectDataSource ID="odsPlanContable1" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsPlanContable2" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<p>
    &nbsp;</p>



