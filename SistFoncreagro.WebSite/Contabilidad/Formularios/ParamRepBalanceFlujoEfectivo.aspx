<%@ Page Title="Balance de Comprobación - Flujo de Efectivo" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepBalanceFlujoEfectivo.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepBalanceFlujoEfectivo" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;Parametros para mostrar el REPORTE DEL BALANCE DE COMPROBACIÓN - flujo de efectivo </td>
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
                <table class="style1" width="100%">
                    <tr>
                        <td colspan="4">
            Indique los datos solicitados, luego haga clic en el botón &quot;Mostrar&quot;.</td>
                    </tr>
                    <tr>
                        <td width="12%">
                            Fecha:</td>
                        <td>

        
            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            Tipo:</td>
                        <td colspan="3">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="50%" AutoPostBack="True">
                                                                                                <Items>
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="General" Value="G" 
                                                                                                        Selected="True" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Institucional" 
                                                                                                        Value="I" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Proyectos" Value="P" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Proyecto específico" Value="A" />
                                                                                                </Items>
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td>
                            Proyecto:</td>
                        <td colspan="3">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1" Enabled="False">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td>
                            Moneda:</td>
                        <td>
                                                                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                                                                                                <asp:ListItem Value="1" Selected="True">Soles</asp:ListItem>
                                                                                                <asp:ListItem Value="2">Dolares</asp:ListItem>
                                                                                            </asp:RadioButtonList>
                                                                                        </td>
                        <td>
                            Nivel:</td>
                        <td>
                                                                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                                                                                <asp:ListItem Value="M" Selected="True">Mayor</asp:ListItem>
                                                                                                <asp:ListItem Value="D">Divisionaria</asp:ListItem>
                                                                                                <asp:ListItem Value="S">Sub Divisionaria</asp:ListItem>
                                                                                            </asp:RadioButtonList>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="font-size: 4pt">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" BorderStyle="None" BorderWidth="1px" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="font-size: 4pt">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
           <asp:ObjectDataSource ID="odsProyecto" runat="server" 
        SelectMethod="GetAllFromProyecto" 
        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>                                                     
   
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox3" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadioButtonList1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox3" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
   
 </asp:Content>


