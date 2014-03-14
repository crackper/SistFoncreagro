<%@ Page Title="Reporte de Caja y Bancos para Conciliación" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepCajaBancosConciliacion.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepCajaBancosConciliacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;Parametros para mostrar el reporte de caja y bancos para conciliación</td>
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
                            Fecha:</td>
                        <td style="text-align: left" width="80%">

        
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
                            Proyecto:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="100%">
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
                                                                                                AllowCustomText="True" DataSourceID="SqlCuentasCaja1" AutoPostBack="True">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Cuenta Fin:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox4" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="Codigo" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                EnableAjaxSkinRendering="False" EnableVirtualScrolling="True" 
                                                                                                AllowCustomText="True" DataSourceID="SqlCuentasCaja1">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" BorderStyle="None" BorderWidth="1px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
           <asp:ObjectDataSource ID="odsProyecto" runat="server" 
        SelectMethod="GetAllFromProyecto" 
        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>                                                     
   
             

                                            
    <asp:SqlDataSource ID="SqlCuentasCaja1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetCuentasCaja" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
   
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadioButtonList1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox4" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
   
 </asp:Content>

