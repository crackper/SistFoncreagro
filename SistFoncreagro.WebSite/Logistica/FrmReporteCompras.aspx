<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmReporteCompras.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmReporteCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla5">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA MOSTRAR reporte de compras</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Logistica/DefaultLogistica.aspx" 
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
                        <td colspan="3">
            Indique los datos solicitados, luego haga clic en el botón &quot;Mostrar&quot;.</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Área/Proyecto :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                                                                                            <telerik:RadComboBox ID="rcmbProyecto" Runat="server" AllowCustomText="True" 
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
                            Proveedor :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                                                                                            <telerik:RadComboBox ID="rcmbProveedor" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="98%" 
                                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" TabIndex="9">
                                                                                            </telerik:RadComboBox>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Producto :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                                <telerik:RadComboBox ID="rcmbProducto" Runat="server" 
                                    DataSourceID="odsCatalogoBusqueda" DataTextField="CodigoDescripcion" 
                                    DataValueField="IdCatalogo" 
            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" 
                                    style="margin-left: 0px" ValidationGroup="poducto" Width="98%" 
                                    EmptyMessage="Ingrese el producto o servicio..." TabIndex="11">
                                </telerik:RadComboBox>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Fecha :</td>
                        <td width="2%">
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                            Desde :&nbsp;

        
            <telerik:RadDatePicker ID="rdpFechaInicio" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        &nbsp; Hasta :&nbsp;

        
            <telerik:RadDatePicker ID="rdpFechaFin" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            &nbsp;</td>
                        <td width="2%">
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            &nbsp;</td>
                        <td width="2%">
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" />
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsCatalogoBusqueda" runat="server" 
                                    SelectMethod="GetAllFromCatalogoFullByParametro" 
                                    
        TypeName="SistFoncreagro.BussinesLogic.CatalogoBL" 
        OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="$" Name="parametro" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
