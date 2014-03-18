<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlDocumento.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlDocumento" %>
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
    
   
</style>

<table align="center" class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td>
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                    <tr class="Texto">
                                                                                        <td width="8%" style="text-align: left; width: 100%;">
                                                                                            <table class="style1">
                                                                                                <tr>
                                                                                                    <td width="10%">
                                                                                                        Tipo Documento:</td>
                                                                                                    <td width="60%">
                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsDocumentoContabilizado" DataTextField="Documento" 
                                                                                                DataValueField="IdDocumentoCont" 
                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                                                                                Width="98%" EmptyMessage="Ingrese el Tipo de Documento...">
                                                                                            </telerik:RadComboBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                            ControlToValidate="RadComboBox6" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar el Tipo de Documento!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        Fecha Emisión:</td>
                                                                                                    <td width="8%">
                                                                                            <asp:TextBox ID="txtDate1" runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate1" />
                                                                                                <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
                                                                                                ControlToValidate="txtDate1" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        T. Cambio:</td>
                                                                                                    <td width="6%">
            <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="0" 
                Width="50px">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                <NumberFormat DecimalDigits="4" />
            </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td>
                                                                                                        Proveedor:</td>
                                                                                                    <td width="65%">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" AllowCustomText="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="94%" 
                                                                                                EmptyMessage="Ingrese el Auxiliar...">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Cliente" 
                                                                                                CausesValidation="False" />
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                            ControlToValidate="RadComboBox8" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar el Proveedor!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td width="5%">
                                                                                                        Serie:</td>
                                                                                                    <td width="8%">
                                                                                            <telerik:RadTextBox ID="RadTextBox2" Runat="server" MaxLength="4" 
                                                                                                ValidationGroup="Transaccion" Width="70px" ClientIDMode="Static">
                                                                                                <ClientEvents OnValueChanged="ponerCeros" />
                                                                                               
                                                                                            </telerik:RadTextBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                            ControlToValidate="RadTextBox2" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar la Serie!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        N° Doc.:</td>
                                                                                                    <td width="6%">
                                                                                            <telerik:RadTextBox ID="RadTextBox4" Runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="50px">
                                                                                            </telerik:RadTextBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                                                            ControlToValidate="RadTextBox4" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar el N° de Documento!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td>
                                                                                                        C. Costo:</td>
                                                                                                    <td colspan="3" style="width: 73%">
            <telerik:RadComboBox ID="RadComboBox2" Runat="server" Width="99.7%" 
                 EnableLoadOnDemand="True" MarkFirstMatch="True" 
                DataSourceID="odsCCosto" DataTextField="CodigoElementoGasto" 
                DataValueField="IdCCosto" AllowCustomText="True" 
                EmptyMessage="Ingrese C. Costo...">
            </telerik:RadComboBox>
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        Monto:</td>
                                                                                                    <td width="6%">
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="0" 
                Width="50px">
            </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td width="8%" style="text-align: left; width: 100%;">
                                                                                            <table class="style1" cellpadding="0" cellspacing="0">
                                                                                                <tr>
                                                                                                    <td width="10%">
                                                                                                        Tipo Gasto:</td>
                                                                                                    <td width="40%">
            <telerik:RadComboBox ID="RadComboBox9" Runat="server" Width="99.7%" 
                 EnableLoadOnDemand="True" MarkFirstMatch="True" 
                DataSourceID="odsTipoGasto" DataTextField="Descripcion" 
                DataValueField="IdTipoGasto" AllowCustomText="True" 
                EmptyMessage="Ingrese Tipo de Gasto...">
            </telerik:RadComboBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                            ControlToValidate="RadComboBox9" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar el Tipo de Gasto!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td width="8%" style="text-align: center">
                                                                                                        Glosa:</td>
                                                                                                    <td width="42%">
            <telerik:RadTextBox ID="RadTextBox3" Runat="server" Rows="1" 
                TextMode="MultiLine" Width="98%">
            </telerik:RadTextBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                            ControlToValidate="RadTextBox3" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar la Glosa!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td colspan="4">
                                                                                                        <table class="style1">
                                                                                                            <tr>
                                                                                                                <td width="10%">
                                                                                                                    Fecha vencimiento:</td>
                                                                                                                <td width="8%">
                                                                                                                     <asp:TextBox ID="txtDate2" runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate2" />
                                                                                                <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
                                                                                                ControlToValidate="txtDate2" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                                                            ControlToValidate="txtDate2" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar la Fecha de vencimiento!"></asp:RequiredFieldValidator>
                                                                                                                </td>
                                                                                                                <td width="8%">
                                                                                                                    Fecha Pago:</td>
                                                                                                                <td>
                                                                                                                   <asp:TextBox ID="txtDate3" runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender3" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate3" />
                                                                                                <asp:MaskedEditValidator ID="MaskedEditValidator3" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender3" 
                                                                                                ControlToValidate="txtDate3" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                                                                            ControlToValidate="txtDate3" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar la Fecha de Pago !"></asp:RequiredFieldValidator>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </td>
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
<asp:ObjectDataSource ID="odsPlanContable" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>




            
        




                                                
                                                
        



<asp:ObjectDataSource ID="odsCCosto" runat="server" 
    SelectMethod="GetCCOSTOByIdProyecto" 
    TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
    <SelectParameters>
        <asp:ControlParameter ControlID="TextBox1" Name="_IdProyecto" 
            PropertyName="Text" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>


                                                
                                                
        






                                                
                                                
        



                                                <asp:ObjectDataSource ID="odsTipoGasto" 
    runat="server" SelectMethod="GetAllFromTIPOGASTO" 
    TypeName="SistFoncreagro.BussinesLogic.TipoGastoBL"></asp:ObjectDataSource>
        




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

                                                
                                                
                                                <asp:ObjectDataSource ID="odsDocumentoContabilizado" runat="server" 
                                                    SelectMethod="GetAllFromDOCUMENTOCONTABILIZADO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.DocumentoContabilizadoBL">
                                                </asp:ObjectDataSource>
                                                

                                                
                                                
        