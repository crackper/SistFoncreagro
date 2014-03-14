<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlCuentaBancaria.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlCuentaBancaria" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

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

   

    .style2
    {
        font-size: 9pt;
    }

   

    </style>

<table align="center" class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td>
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Descripción:</td>
                                                                                        <td colspan="3" style="width: 88%">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="80%" 
                                                                                                style="font-family: Arial; font-size: 9pt"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                ControlToValidate="TextBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Descripción!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Banco:</td>
                                                                                        <td colspan="3" style="width: 88%">
                                                                                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="odsBanco" 
                                                                                                DataTextField="Nombre" DataValueField="IdBanco" Width="350px" 
                                                                                                CssClass="style2" style="font-family: Arial">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Tipo Cuenta:</td>
                                                                                        <td width="50%">
                                                                                            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="odsTipoCta" 
                                                                                                DataTextField="Descripcion" DataValueField="IdTipoCtaBancaria" 
                                                                                                Width="350px" CssClass="style2" style="font-family: Arial">
                                                                                            </asp:DropDownList>
                                                                                            </td>
                                                                                        <td width="8%" style="font-size: 9pt">
                                                                                            Moneda:</td>
                                                                                        <td width="30%">
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="odsMoneda" 
                                                                                                DataTextField="Nombre" DataValueField="IdMoneda" Width="100px" 
                                                                                                CssClass="style2" style="font-family: Arial">
                                                                                            </asp:DropDownList>
                                                                                            </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            N° Cuenta:</td>
                                                                                        <td colspan="3" style="width: 88%">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Width="80%"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el N° de Cuenta!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Cta. Contable:</td>
                                                                                        <td colspan="3" style="width: 88%">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="IdPlan" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" ShowMoreResultsBox="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="81%" EmptyMessage="Ingrese la Cuenta..." style="font-family: Arial; font-size: 9pt">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Cuenta Contable!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="12%" style="text-align: left; font-size: 9pt;">
                                                                                            Sub Diario:</td>
                                                                                        <td colspan="3" style="width: 88%">
                                                                                            <telerik:RadComboBox ID="RadComboBox2" 
                Runat="server"  
                                                                                                
                DataTextField="Descripcion" 
                DataValueField="IdSubDiario" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" ShowMoreResultsBox="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="81%" EmptyMessage="Ingrese el Subdiario..." style="font-family: Arial; font-size: 9pt" DataSourceID="SqlSubdiario">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:SqlDataSource ID="SqlSubdiario" runat="server" 
                                                                                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="SELECT
	[sUBDIARIO].[Descripcion] ,
	[sUBDIARIO].[IdSubDiario] ,
	[sUBDIARIO].IdTipoProceso ,
	sUBDIARIO.estado,
	sUBDIARIO.IdOpFinanciera
	FROM [dbo].[SUBDIARIO] [sUBDIARIO]
	WHERE IdOpFinanciera=1
"></asp:SqlDataSource>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Subdiario!"></asp:RequiredFieldValidator>
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


<asp:ObjectDataSource ID="odsTipoCta" runat="server" 
    SelectMethod="GetAllFromTIPOCTABANCARIA" 
    TypeName="SistFoncreagro.BussinesLogic.TipoCtaBancariaBL">
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsBanco" runat="server" 
    SelectMethod="GetAllFromBANCO" TypeName="SistFoncreagro.BussinesLogic.BancoBL">
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMoneda" runat="server" 
    SelectMethod="GetAllFromMoneda" 
    TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>




<asp:ObjectDataSource ID="odsSubdiario" runat="server" 
    SelectMethod="GetSUBDIARIOByIdOpFinanciera" 
    TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="1" Name="IdOpFinanciera" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>





