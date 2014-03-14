<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlConciliacion.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlConciliacion" %>
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

    .tabla4
    {
        width: 100%;
    margin-right: 17px;
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
                                                                                        <td width="8%" style="text-align: left; width: 100%;">
                                                                                            <table class="style1">
                                                                                                <tr>
                                                                                                    <td width="8%">
                                                                                                        Tipo Mov.:</td>
                                                                                                    <td width="65%">
                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" 
                                                                                                DataSourceID="SqlTipo" DataTextField="Descripcion" 
                                                                                                DataValueField="IdTipoMovimiento" 
                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                                                                                Width="98%">
                                                                                            </telerik:RadComboBox>
                                                                                                    </td>
                                                                                                    <td width="5%">
                                                                                                        Fecha:</td>
                                                                                                    <td width="8%">
                                                                                            <asp:TextBox ID="txtDate1" runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate1" />
                                                                                                <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
                                                                                                ControlToValidate="txtDate1" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="6%">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td width="8%">
                                                                                                        Coa:</td>
                                                                                                    <td width="65%">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" AllowCustomText="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="98%" 
                                                                                                EmptyMessage="Ingrese el Auxiliar...">
                                                                                            </telerik:RadComboBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                            ControlToValidate="RadComboBox8" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar el Proveedor!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td width="5%">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Cliente" 
                                                                                                CausesValidation="False" />
                                                                                                        </td>
                                                                                                    <td width="8%">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="8%">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="6%">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td width="8%">
                                                                                                        Glosa:</td>
                                                                                                    <td colspan="3" style="width: 73%">
            <telerik:RadTextBox ID="RadTextBox3" Runat="server" Rows="1" 
                TextMode="MultiLine" Width="98%" CssClass="TextBoxAlignIzquierda">
            </telerik:RadTextBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                            ControlToValidate="RadTextBox3" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar la Glosa!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="6%">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td width="8%">
                                                                                                        Monto:</td>
                                                                                                    <td colspan="3" style="width: 73%">
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="0" 
                Width="50px">
            </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="6%">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                                </table>
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
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
        </td>
    </tr>
</table>
        




                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
       

       
                  
         
     </script>
    </telerik:RadCodeBlock>

                                                
                                                
                                                <asp:SqlDataSource ID="SqlTipo" 
    runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="SELECT IdTipoMovimiento, Descripcion FROM TIPOMOVIMIENTO">
</asp:SqlDataSource>

                                                

                                                
                                                
        