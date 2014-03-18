<%@ Page Title="Duplicar/Revertir Comprobante" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="BuscarComprobante.aspx.vb" Inherits="SistFoncreagro.WebSite.BuscarComprobante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;DUPLICAR/REVERTIR documento</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" CausesValidation="False" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="style1" width="100%" >
                    <tr class="Texto">
                        <td colspan="2">
            Indique los datos solicitados, luego haga clic en el botón &quot;Procesar&quot;.</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td width="15%">
                            Ejercicio:</td>
                        <td style="text-align: left" width="77%">
                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                                DataType="System.Int32" ShowSpinButtons="True" Width="70px">
                                <NumberFormat DecimalDigits="0" GroupSeparator="" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="RadNumericTextBox1" Display="Dynamic" 
                                ErrorMessage="¡Debe ingresar el Año de Ejercicio!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Mes de Proceso:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" DataTextField="Codigo" 
                                                                                                DataValueField="IdSubDiario" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                Width="100px">
                                                                                                <Items>
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Enero" Value="1" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Febrero" Value="2" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Marzo" Value="3" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Abril" Value="4" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Mayo" Value="5" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Junio" Value="6" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Julio" Value="7" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Agosto" Value="8" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Setiembre" Value="9" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Octubre" Value="10" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Noviembre" Value="11" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Diciembre" Value="12" 
                                                                                                        Owner="RadComboBox1" />
                                                                                                </Items>
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Mes de Proceso!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            SubDiario Origen:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox2" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsSubDiario" DataTextField="Codigo" 
                                                                                                DataValueField="IdSubDiario" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                Width="100%" Font-Names="Arial" Font-Size="8pt" 
                                                                                                style="font-family: Arial; font-size: 8pt">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el SubDiario Origen!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Comprobante:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadTextBox ID="RadTextBox2" Runat="server" MaxLength="4" 
                                                                                                ValidationGroup="Transaccion" Width="70px">
                                                                                                <ClientEvents OnValueChanged="ponerCeros" />
                                                                                            </telerik:RadTextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                                                ControlToValidate="RadTextBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Comprobante!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                            </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            SubDiario Destino:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsSubDiario" DataTextField="Codigo" 
                                                                                                DataValueField="IdSubDiario" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                Width="100%" Font-Names="Arial" Font-Size="8pt" 
                                                                                                style="font-family: Arial; font-size: 8pt">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el SubDiario Destino!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                            </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Acción:</td>
                        <td style="text-align: left">
                                                                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                                                                                <asp:ListItem Value="D">Duplicar</asp:ListItem>
                                                                                                <asp:ListItem Value="R">Revertir</asp:ListItem>
                                                                                            </asp:RadioButtonList>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                ControlToValidate="RadioButtonList1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe elegir una Acción!"></asp:RequiredFieldValidator>
                                                                                            </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Proceso.gif" 
                ToolTip="Procesar" AccessKey="s" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
                                                               
                                                <asp:ObjectDataSource ID="odsSubDiario" runat="server" 
                                                    SelectMethod="GetAllSUBDIARIO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL"></asp:ObjectDataSource>

        

         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>

    <asp:ObjectDataSource ID="OdsOpFinanc" runat="server" 
    SelectMethod="GetAllFromOperacionFinanciera" 
    TypeName="SistFoncreagro.BussinesLogic.OperacionFinancieraBL">
</asp:ObjectDataSource>

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadComboBox4">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadComboBox3" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
       function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }
        function ponerCeros() {
            var obj = $find("<%= RadTextBox2.ClientID %>");
            while (obj.get_value().length < 6)
                obj.set_value('0' + obj.get_value());
        }
        function alertCallBackFn(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Abrir");
        }
        function confirmCallBackFn(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Generar|" + arg);
        }
       

        
     </script>
    </telerik:RadCodeBlock>
                                                </asp:Content>
