<%@ Page Title="Balance de Comprobación Por Área" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepBalanceComprobacionXarea.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepBalanceComprobacionXarea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;Parametros para mostrar el REPORTE DEL BALANCE DE COMPROBACIÓN</td>
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
                        <td style="width: 106px">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            Proyecto:</td>
                        <td colspan="3">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="False" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td>
                            Nivel:</td>
                        <td>
                                                                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                                                                                <asp:ListItem Value="M">Mayor</asp:ListItem>
                                                                                                <asp:ListItem Value="S">Sub Divisionaria</asp:ListItem>
                                                                                                <asp:ListItem Selected="True" Value="C">Cuenta</asp:ListItem>
                                                                                            </asp:RadioButtonList>
                                                                                        </td>
                        <td>
                            Tipo:</td>
                        <td style="width: 106px">
                                                                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                                                                                                <asp:ListItem Value="A">Apertura</asp:ListItem>
                                                                                                <asp:ListItem Value="T">Traslado</asp:ListItem>
                                                                                                <asp:ListItem Value="C">Cierre</asp:ListItem>
                                                                                                <asp:ListItem Selected="True" Value="N">Ninguno</asp:ListItem>
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
                                                        <telerik:AjaxSetting AjaxControlID="RadioButtonList1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="Label3" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox3" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
   
 </asp:Content>

