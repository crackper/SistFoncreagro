<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlRecibo.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlRecibo" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<style type="text/css">

    .Texto
{
    font-family: Arial;
    font-size: 9pt;
}

    .tabla4
    {
        width: 100%;
    margin-right: 17px;
}
    </style>
                                                                    <table cellpadding="0" cellspacing="0" style="width: 70%">
                                                                        <tr>
                                                                            <td class="Texto" style="font-weight: 700">
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <table cellpadding="2" cellspacing="0" class="tabla4">
                                                                                    <tr class="Texto">
                                                                                        <td width="10%">
                                                                                            Monto:</td>
                                                                                        <td width="40%">
                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" Value="0" 
                                                                                                Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedSkins="False">
                                                                                                <NumberFormat DecimalDigits="2" />
                                                                                            </telerik:RadNumericTextBox>
                                                                                        </td>
                                                                                        <td width="8%">
                                                                                            Fecha:</td>
                                                                                        <td style="width: 42%">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="70px" Enabled="False" />
                                                                                           <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate" />
                                                                                                  <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender1" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                        </td>
                                                                                    </tr>
                                                                                   
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <table cellpadding="0" class="tabla4">
                                                                                    <tr class="Texto">
                                                                                        <td width="10%">
                                                                                            Proyecto:</td>
                                                                                        <td style="width: 90%">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                 ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" >
                                                                                            </telerik:RadComboBox>
                                                                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                      
                                                                                        </td>
                                                                                    </tr>
                                                                                   
                                                                                    <tr class="Texto">
                                                                                        <td width="10%">
                                                                                            Personal:</td>
                                                                                        <td style="width: 90%">
                                                                                            <telerik:RadComboBox ID="RadComboBox4" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsPersonal" DataTextField="nombreCompleto" 
                                                                                                DataValueField="IdPersonal" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                 ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" >
                                                                                            </telerik:RadComboBox>
                                                                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                ControlToValidate="RadComboBox4" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Personal!"></asp:RequiredFieldValidator>
                                                                                      
                                                                                        </td>
                                                                                    </tr>
                                                                                   
                                                                                    <tr class="Texto">
                                                                                        <td width="10%">
                                                                                            C. Costo:</td>
                                                                                        <td style="width: 90%">
                                                                                            
                                                                                            <telerik:RadComboBox ID="RadComboBox5" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsCCosto" DataTextField="CodigoElementoGasto" 
                                                                                                DataValueField="IdCCosto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                 ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" >
                                                                                            </telerik:RadComboBox>
                                                                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                                                ControlToValidate="RadComboBox5" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el C. Costo!"></asp:RequiredFieldValidator>
                                                                                      
                                                                                        </td>
                                                                                    </tr>
                                                                                   
                                                                                    <tr class="Texto">
                                                                                        <td width="10%">
                                                                                            Glosa:</td>
                                                                                        <td style="width: 90%">
                                                                                            
                                                                                            <telerik:RadTextBox ID="RadTextBox4" Runat="server" Rows="1" 
                                                                                                TextMode="MultiLine" ValidationGroup="Transaccion" Width="97%">
                                                                                                       </telerik:RadTextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                ErrorMessage="¡Debe ingresar la Glosa!" Display="Dynamic" 
                                                                                                ControlToValidate="RadTextBox4"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto">
                                                                                        <td colspan="2" style="font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
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
                                                        
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                
                                                        
<asp:ObjectDataSource ID="odsPersonal" runat="server" 
    SelectMethod="GetAllFromPersonal" 
    TypeName="SistFoncreagro.BussinesLogic.PersonalBL">
</asp:ObjectDataSource>

                                                
                                                        







                                                
                                                
        



<asp:ObjectDataSource ID="odsCCosto" runat="server" 
    SelectMethod="GetCCOSTOByIdProyecto" 
    TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
    <SelectParameters>
        <asp:ControlParameter ControlID="RadComboBox3" Name="_IdProyecto" 
            PropertyName="SelectedValue" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>


                                                
                                                
        






                                                
                                                
        





                                                
                                                        
