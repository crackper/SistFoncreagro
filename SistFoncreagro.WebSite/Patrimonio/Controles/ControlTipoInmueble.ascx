<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlTipoInmueble.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlTipoInmueble" %>
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
   

    
    .RadComboBox_Hay
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Hay
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Hay
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Hay
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Hay
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Hay
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Hay
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox_Hay .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Hay .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Hay .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Hay .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Hay .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Hay .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Hay .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #272722;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Hay .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Hay .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Hay.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}


    
    </style>

<table class="style1">
    <tr>
        <td width="13%">
            Tipo:</td>
        <td width="87%">
            <asp:TextBox ID="TextBox1" runat="server" Width="50%" CssClass="Texto" 
                TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" Display="Dynamic" 
                ErrorMessage="Debe ingresar la Clasificación!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Cta. Activo Fijo:</td>
        <td width="20%" style="width: 27%">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" 
                 DataTextField="Cuenta" 
                                                                                                                                
                 DataValueField="Codigo" EnableLoadOnDemand="True" 
                 MarkFirstMatch="True" 
                                                                                                                                
                 ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                 TabIndex="2" 
                                                                                                                                
                 Width="70%" Skin="Default">
                                                                                                                            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            Cta. Depreciación:</td>
        <td>
                                                                                                                            <telerik:RadComboBox ID="RadComboBox7" Runat="server" 
                DataTextField="Cuenta" 
                                                                                                                                
                DataValueField="Codigo" EnableLoadOnDemand="True" 
                MarkFirstMatch="True" 
                                                                                                                                
                ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                TabIndex="3" 
                                                                                                                                
                Width="70%" Skin="Default">
                                                                                                                            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            Cta. Gasto:</td>
        <td>
                                                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" 
                DataTextField="Cuenta" 
                                                                                                                                
                DataValueField="Codigo" EnableLoadOnDemand="True" 
                MarkFirstMatch="True" 
                                                                                                                                
                ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                TabIndex="4" 
                                                                                                                                
                Width="70%" Skin="Default">
                                                                                                                            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            %
            Depreciación:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDepreciacion" DataTextField="Tipo" 
                DataValueField="IdPorcDepreciacion" AppendDataBoundItems="True" 
                CssClass="Texto" TabIndex="5" Width="50%">
                <asp:ListItem Selected="True" Value="0">------</asp:ListItem>
            </asp:DropDownList>
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

<asp:SqlDataSource ID="SqlTipos" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromTIPOESTADOBIEN" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>



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

<asp:ObjectDataSource ID="odsPlanContable3" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


                                                                                <asp:SqlDataSource ID="SqlDepreciacion" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromPorcDepreciacionDetallado" 
    SelectCommandType="StoredProcedure"></asp:SqlDataSource>




