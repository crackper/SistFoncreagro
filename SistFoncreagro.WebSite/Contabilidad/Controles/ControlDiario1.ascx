<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlDiario1.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlDiario1" %>
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
.TextBoxAlignIzquierda
{
	text-align: left;
	text-transform: uppercase;
}
   .TextBoxAlignDerecha
{
	text-align: right;
	font-family: Arial;
    font-size: 8pt;
}  

    .style2
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: xx-small;
    }
    .style4
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: xx-small;
        text-align: right;
    }

    </style>



<table class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td style="text-align: left">
                                                                                <table cellpadding="0" cellspacing="0" >
                                                                                    <tr class="Texto">
                                                                                        <td width="6%">
                                                                                            Proveedor:</td>
                                                                                        <td width="72%">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" AllowCustomText="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                                                                                EmptyMessage="Ingrese el Auxiliar...">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox8" Display="Dynamic" Enabled="False" 
                                                                                                ErrorMessage="¡Debe ingresar el Coa!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="2%" style="text-align: left">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Cliente" 
                                                                                                CausesValidation="False" />
                                                                                        </td>
                                                                                        <td width="4%" style="text-align: center">
                                                                                            </td>
                                                                                        <td width="5%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td width="5%" style="text-align: center">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    
                                                                                    <tr class="Texto">
                                                                                        <td width="6%">
                                                                                            Cuenta:</td>
                                                                                        <td width="72%">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="IdPlan" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" ShowMoreResultsBox="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" DataSourceID="odsPlanContable" EmptyMessage="Ingrese la Cuenta..." EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ErrorMessage="¡Debe ingresar la Cuenta!" ControlToValidate="RadComboBox1" 
                                                                                                Display="Dynamic"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="2%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td colspan="4">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    
                                                                                    <tr class="Texto">
                                                                                        <td width="6%">
                                                                                            C. Costo:</td>
                                                                                        <td width="72%">
            <telerik:RadComboBox ID="RadComboBox2" Runat="server" Width="100%" 
                 EnableLoadOnDemand="True" MarkFirstMatch="True" 
                DataSourceID="SqlDSCCosto" DataTextField="CodigoElemGasto" 
                DataValueField="IdCCosto" AllowCustomText="True" 
                EmptyMessage="Ingrese C. Costo..." EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                EnableEmbeddedSkins="False">
            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" Enabled="False" 
                                                                                                ErrorMessage="¡Debe ingresar el C. Costo!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="2%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td width="5%">
                                                                                            &nbsp;</td>
                                                                                        <td width="4%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td width="5%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    
                                                                                    <tr class="Texto">
                                                                                        <td width="6%">
                                                                                            Glosa:</td>
                                                                                        <td width="72%">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="100%" 
                                                                                                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                        </td>
                                                                                        <td width="2%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td width="5%">
                                                                                            &nbsp;</td>
                                                                                        <td width="4%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td width="5%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" style="text-align: left">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    
                                                                                </table>
                                                                                                    </td>
    </tr>
    <tr>
        <td style="text-align: left">
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                
                                                                                   
                                                                                
                                                                                    <tr class="Texto">
                                                                                        <td width="6%" style="text-align: left">
                                                                                            <asp:Label ID="Label1" runat="server" Text="Debe:"></asp:Label>
                                                                                            <asp:Label ID="Label2" runat="server" Text="Debe MN:"></asp:Label>
                                                                                        </td>
                                                                                        <td width="10%" style="text-align: left">
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="0" 
                Width="60px" EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                            <asp:TextBox ID="NTextBox4" runat="server" Width="60px" ClientIDMode="Static" >0.00</asp:TextBox>
                                                                                           
                                                                                        </td>
                                                                                        <td style="text-align: center" width="8%">
                                                                                            <asp:Label ID="Label3" runat="server" Text="Haber:"></asp:Label>
                                                                                            <asp:Label ID="Label4" runat="server" Text="Haber MN:"></asp:Label>
                                                                                        </td>
                                                                                        <td width="10%" style="text-align: left">
            <telerik:RadNumericTextBox ID="RadNumericTextBox4" Runat="server" Value="0" 
                Width="60px" EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
                                                                                           
                                                                                            <asp:TextBox ID="NTextBox5" runat="server" Width="60px" ClientIDMode="Static">0.00</asp:TextBox>
                                                                                           
                                                                                        </td>
                                                                                        <td style="text-align: center" width="8%">
                                                                                            <asp:Label ID="Label5" runat="server" Text="Debe ME:"></asp:Label>
                                                                                        </td>
                                                                                        <td width="10%">
                                                                                           
                                                                                            <asp:TextBox ID="NTextBox6" runat="server" Width="60px" ClientIDMode="Static">0.00</asp:TextBox>
                                                                                           
                                                                                        </td>
                                                                                        <td width="8%">
                                                                                            <asp:Label ID="Label6" runat="server" Text="Haber ME:"></asp:Label>
                                                                                        </td>
                                                                                        <td width="40%">
                                                                                           
                                                                                            <asp:TextBox ID="NTextBox7" runat="server" Width="60px" ClientIDMode="Static">0.00</asp:TextBox>
                                                                                           
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                                    </td>
    </tr>
    <tr>
        <td style="text-align: left">
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                
                                                                                   
                                                                                
                                                                                    <tr class="Texto">
                                                                                        <td width="6%" style="text-align: left">
                                                                                            Tipo Doc:</td>
                                                                                        <td width="33%" style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsTipoDocumento" DataTextField="Documento" 
                                                                                                DataValueField="IdTipoDocumento" 
                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                                                                                Width="100%" EnableAjaxSkinRendering="False" 
                                                                                                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                EnableEmbeddedSkins="False">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                        <td style="text-align: center" width="5%">
                                                                                            Serie:</td>
                                                                                        <td width="5%" style="text-align: left">
                                                                                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="4" Width="30px"></asp:TextBox>
                                                                                        </td>
                                                                                        <td style="text-align: center" width="5%">
                                                                                            N° Doc:</td>
                                                                                        <td style="text-align: center" width="5%">
                                                                                            <telerik:RadTextBox ID="RadTextBox4" Runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="50px">
                                                                                            </telerik:RadTextBox>
                                                                                                    </td>
                                                                                        <td style="text-align: center" width="5%">
                                                                                            Moneda:</td>
                                                                                        <td style="text-align: center" width="8%">
                                                                                           
                                                                                                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="odsMoneda" 
                                                                                                            DataTextField="Nombre" DataValueField="IdMoneda" 
                                                                                                            style="font-family: Arial; font-size: 8pt" Width="70px">
                                                                                                        </asp:DropDownList>
                                                                                           
                                                                                                    </td>
                                                                                        <td style="text-align: center" width="5%">
                                                                                            &nbsp;</td>
                                                                                        <td width="23%">
                                                                                                        &nbsp;</td>
                                                                                        <td width="23%">
                                                                                                        &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                                                    </td>
    </tr>
    <tr>
        <td >
                                                                                <table class="style1" cellpadding="0" cellspacing="0">
                                                                                    <tr>
                                                                                        <td width="6%" class="Texto">
                                                                                            Fec. Emision:</td>
                                                                                        <td width="8%">
                                                                                            <asp:TextBox ID="txtDate1" runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate1" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender1" 
                                                                                                ControlToValidate="txtDate1" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" /></td>
                                                                                        <td width="10%" class="style4">
                                                                                            Fec. Vto:</td>
                                                                                        <td width="8%">
                                                                                            <asp:TextBox ID="txtDate2" runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="70px" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate2" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
                                                                                                ControlToValidate="txtDate2" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" /></td>
                                                                                        <td width="10%" class="style4">
                                                                                            Fec. Pago:</td>
                                                                                        <td>
                                                                                             <asp:TextBox ID="txtDate3" runat="server" 
                                                                                                ValidationGroup="Transaccion" Width="70px" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender3" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate3" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator3" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
                                                                                                ControlToValidate="txtDate3" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" /></td>
                                                                                    </tr>
                                                                                </table>
                                                                                                    </td>
    </tr>
    <tr>
        <td style="text-align: left" class="Texto">
            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderColor="White" 
                BorderStyle="None" ForeColor="White" Visible="False"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
            <asp:HiddenField ID="NHiddenField1" runat="server" ClientIDMode="Static" />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="RadComboBox6" Display="Dynamic" Enabled="False" 
                ErrorMessage="¡Debe ingresar el tipo de documento!"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="TextBox3" Display="Dynamic" Enabled="False" 
                ErrorMessage="¡Debe ingresar la serie!"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="RadTextBox4" Display="Dynamic" Enabled="False" 
                ErrorMessage="¡Debe ingresar el número de documento!"></asp:RequiredFieldValidator>
                                                                                                                                                                                          &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" ForeColor="Red"></asp:Label>
                                                                                                                                                                                          </td>
    </tr>
</table>

                                                <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
                                                    SelectMethod="GetAllFromTIPODOCUMENTO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
                                                </asp:ObjectDataSource>
                                                
        



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

<asp:ObjectDataSource ID="odsMoneda" runat="server" 
    SelectMethod="GetAllFromMoneda" 
    TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsPlanContable" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>




            
        




            
        




                                                



                                                
           




                                                
                                                
        









            
        




            
        




                                                



                                                
                                                
        






                                                
                                                
        



<asp:SqlDataSource ID="SqlDSCCosto" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetCCOSTOByIdProyecto1" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:ControlParameter ControlID="TextBox1" Name="idProyecto" 
            PropertyName="Text" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>


                                                
                                                
        






                                                
                                                
        








            
        




            
        




                                                



                                                
                                                
        






                                                
                                                
        









            
        




            
        




                                                



                                                
                                                
        






                                                
                                                
        



