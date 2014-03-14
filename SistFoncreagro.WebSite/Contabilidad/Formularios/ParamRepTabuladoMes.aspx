<%@ Page Title="Reporte de Movimiento Tabulado Por Mes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepTabuladoMes.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepTabuladoMes" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;<table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA MOSTRAR EL REPORTE 
                            de movimiento tabulado por mes</td>
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
                            Desde:</td>
                        <td style="text-align: left" width="77%">

        
            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Hasta:</td>
                        <td style="text-align: left">

        
            <telerik:RadDatePicker ID="RadDatePicker2" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>

                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Proyecto:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox9" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                
                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                
                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                
                                ValidationGroup="Transaccion" Width="100%" TabIndex="1">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Cuenta Inicio:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="Codigo" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                
                                EnableAjaxSkinRendering="False" EnableVirtualScrolling="True" 
                                                                                                
                                AllowCustomText="True" DataSourceID="SqlCuentas" AutoPostBack="True">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Cuenta Fin:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox11" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="Codigo" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                
                                EnableAjaxSkinRendering="False" EnableVirtualScrolling="True" 
                                                                                                
                                AllowCustomText="True" DataSourceID="SqlCuentas">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Tipo:</td>
                        <td style="text-align: left">
                                                                                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Detallado" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" style="width: 28px" />
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>


                            <asp:SqlDataSource ID="SqlCuentas" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="GetCuentasDetalle" SelectCommandType="StoredProcedure">
                            </asp:SqlDataSource>

                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadComboBox11" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
                            </telerik:RadAjaxManager>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>


