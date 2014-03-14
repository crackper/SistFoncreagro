<%@ Page Title="Libro de Inventarios y Balances - Detalle del saldo de la Cuenta 14 - Cuentas por Cobrar a Accionistas (o Socios) y Personal" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepSaldoCuenta14.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepSaldoCuenta14" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            PARÁMETROS PARA MOSTRAR el saldo de la cuenta 14 - CUENTAS POR COBRAR A 
                            ACCIONISTAS (O SOCIOS) Y PERSONAL</td>
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
                <table align="center" class="style1" >
                    <tr class="Texto">
                        <td colspan="2">
            Indique los datos solicitados, luego haga clic en el botón &quot;Mostrar&quot;.</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Proyecto:</td>
                        <td style="text-align: left" width="90%">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="False" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Personal:</td>
                        <td style="text-align: left" width="90%">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                
                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                
                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                
                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="98%" 
                                                                                                
                                EnableAjaxSkinRendering="False" TabIndex="9">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Moneda:</td>
                        <td style="text-align: left">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem Selected="True" Value="1">Soles</asp:ListItem>
                                <asp:ListItem Value="2">Dólares</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Hasta:</td>
                        <td style="text-align: left">

        
            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" />
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
