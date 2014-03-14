<%@ Control Language ="VB"  AutoEventWireup ="false" CodeBehind="Datos_Convenio.ascx.vb" Inherits="SistFoncreagro.WebSite.Datos_Convenio" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<style type="text/css">
    .style1
    {
        width: 93%;
        height: 290px;
    }
    .style11
    {
        height: 36px;
        width: 332px;
    }
    .style13
    {
        height: 36px;
        width: 372px;
    }
    .style14
    {
        height: 37px;
        width: 372px;
    }
    .style17
    {
        height: 36px;
        width: 33px;
    }
    .style18
    {
        height: 37px;
        width: 33px;
    }
    .style19
    {
        width: 118px;
        height: 36px;
    }
    .style20
    {
        width: 118px;
        height: 37px;
    }
    .style21
    {
        text-align: center;
    }
    .style22
    {
        width: 89px;
        height: 36px;
    }
    .style23
    {
        width: 89px;
        height: 37px;
    }
    .style24
    {
        width: 332px;
    }
</style>


<table class="style1">
    <tr>
        <td align="right" class="style22">
            Código:</td>
        <td class="style13">
            <asp:TextBox ID="TxtCodigo" runat="server" style='text-transform:uppercase;' MaxLength="10"></asp:TextBox>
        </td>
        <td class="style17">
        </td>
        <td align="right" class="style19">
            Fase Contractual:</td>
        <td class="style11">
            <asp:DropDownList ID="CbFase" runat="server">
                <asp:ListItem>VIGENTE</asp:ListItem>
                <asp:ListItem>POR VENCER</asp:ListItem>
                <asp:ListItem>VENCIDO</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" class="style22">
            Nombre:</td>
        <td class="style13">
            <asp:TextBox ID="TxtNombre" runat="server" Height="56px" Width="370px" 
                style='text-transform:uppercase;' TextMode="MultiLine"></asp:TextBox>
        </td>
        <td class="style17">
        </td>
        <td align="right" class="style19">
            Estado:</td>
        <td class="style11">
            <asp:DropDownList ID="CbEstado" runat="server">
                <asp:ListItem>IMPLEMENTACION</asp:ListItem>
                <asp:ListItem>EJECUCION</asp:ListItem>
                <asp:ListItem>ADENDA</asp:ListItem>
                <asp:ListItem>CIERRE</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" class="style22">
            Alias:</td>
        <td class="style13">
            <asp:TextBox ID="TxtAlias" runat="server" Width="371px" 
                style='text-transform:uppercase;'></asp:TextBox>
        </td>
        <td class="style17">
        </td>
        <td align="right" class="style19">
            Fecha de firma:</td>
        <td class="style11">
            <asp:TextBox ID="TxtFeFirma" runat="server" ValidationGroup="DtVal" Width = "120px" />
            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                TargetControlID="TxtFeFirma" AcceptNegative="None" CultureName="en-GB" 
                Mask="99/99/9999" MaskType="Date" />
            <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                ControlExtender="MaskedEditExtender1" ControlToValidate="TxtFeFirma" 
                Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                InvalidValueMessage="¡Fecha Incorrecta!" />
        </td>
    </tr>
    <tr>
        <td align="right" class="style22"</td>
            Tipo:
           <td class="style13">
                <asp:DropDownList ID="CbTipoConvenio" runat="server" 
                        DataSourceID="OdsTipoConvenio" DataTextField="NomTipConv" 
                    DataValueField="IdTipConv" Width="198px">
                </asp:DropDownList>
            </td>
        <td class="style17">
        </td>
        <td align="right" class="style19">
            Fecha Inicio:</td>
        <td class="style11">
            <asp:TextBox ID="TxtFeIni" runat="server" ValidationGroup ="DtVal" Width = "120px"/>
            <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                TargetControlID="TxtFeIni" AcceptNegative="None" CultureName="en-GB" 
                Mask="99/99/9999" MaskType="Date" />
            <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                ControlExtender="MaskedEditExtender2" ControlToValidate="TxtFeIni" 
                Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                InvalidValueMessage="¡Fecha Incorrecta!" />
        </td>
    </tr>
    <tr>
        <td align="right" class="style22">
            Moneda:</td>
        <td class="style13">
            <asp:DropDownList ID="CbMoneda" runat="server" DataSourceID="OdsMoneda" 
                DataTextField="Nombre" DataValueField="IdMoneda" Width="195px">
            </asp:DropDownList>
        </td>
        <td class="style17">
            &nbsp;</td>
        <td align="right" class="style19">
            Fecha Fin:</td>
        <td class="style11">
            <asp:TextBox ID="TxtFeFin" runat="server" ValidationGroup ="DtVal" Width = "120px"/>
            <asp:MaskedEditExtender ID="MaskedEditExtender3" runat="server" 
                TargetControlID="TxtFeFin" AcceptNegative="None" CultureName="en-GB" 
                Mask="99/99/9999" MaskType="Date" />
            <asp:MaskedEditValidator ID="MaskedEditValidator3" runat="server" 
                ControlExtender="MaskedEditExtender3" ControlToValidate="TxtFeFin" 
                Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                InvalidValueMessage="¡Fecha Incorrecta!" />
        </td>
    </tr>
    <tr>
        <td align="right" class="style22">
            Monto Inicial:</td>
        <td class="style13">
            <telerik:RadNumericTextBox ID="TxtMontoIni" Runat="server">
            </telerik:RadNumericTextBox>
        </td>
        <td class="style17">
            &nbsp;</td>
        <td align="right" class="style19">
            Responsable</td>
        <td class="style11">
            <asp:TextBox ID="TxtResponsable" runat="server" Width="336px" 
                style='text-transform:uppercase;'></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" class="style23">
            Monto Total:</td>
        <td class="style14">
            <telerik:RadNumericTextBox ID="TxtTotal" Runat="server">
            </telerik:RadNumericTextBox>
        </td>
        <td class="style18">
            &nbsp;</td>
        <td align="right" class="style20"Financiador:</td>
            Financiador:<td class="style24">


<telerik:RadComboBox ID="CbFinanciador" Runat="server" AllowCustomText="True" 
                DataSourceID="OdsFinanciador" DataTextField="RazonSocial" 
                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                MarkFirstMatch="True" Width="405px" Height="22px">
</telerik:RadComboBox>



        </td>
    </tr>
    <tr>
        <td class="style21" colspan="5" >
            <asp:ImageButton ID="BtnGrabar" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Insertar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                />
            <asp:ImageButton ID="BtnActualizar" runat="server" CommandName="Update"
    ImageUrl="~/img/Update.gif" ToolTip="Actualizar cambios" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
               />
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancelar.gif" ToolTip="Cancelar" Height="37px" Width="91px" /></td>
    </tr>
</table>






            <asp:ObjectDataSource ID="OdsFinanciador" runat="server" 
                SelectMethod="GetAllFromProveedorCliente" 
                TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="OdsTipoConvenio" runat="server" 
                SelectMethod="GetAllFromTipoConvenio" 
                TypeName="SistFoncreagro.BussinesLogic.TipoConvenioBL">
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="OdsMoneda" runat="server" 
                SelectMethod="GetAllFromMoneda" 
                TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
        






