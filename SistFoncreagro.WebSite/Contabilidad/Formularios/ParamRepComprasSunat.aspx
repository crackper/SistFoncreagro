<%@ Page Title="Libros Electrónicos - Registro de Compras" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.Master" CodeBehind="ParamRepComprasSunat.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepComprasSunat" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
    function onRequestStart(sender, args) {
        if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToCsvButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToPdfButton") >= 0) {
            args.set_enableAjax(false);
        }
    }
    </script>
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            libros electrónicos - Registro de compras</td>
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
                        <td width="6%">
                            Desde:</td>
                        <td >

        
            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px" AutoPostBack="True">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        </td>
                        <td >

        
                            &nbsp;</td>
                        <td style="text-align: left; ">
                                                                        &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Hasta:</td>
                        <td style="text-align: left; " width="15%">

        
            <telerik:RadDatePicker ID="RadDatePicker2" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px" AutoPostBack="True">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            



                        </td>
                        <td style="text-align: left; " width="15%">

        
                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Proceso.gif" 
                                ToolTip="Generar Archivo" />




                        </td>
                        <td style="text-align: left; ">
                                                                        &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td colspan="4">
                        <div style="width: 1100px; overflow: auto; height: 500px; position: static;">
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" GridLines="None" Width="100%" Skin="Hay" 
                                DataSourceID="SqlDCompras" PageSize="5">
<MasterTableView CommandItemDisplay="Top" NoMasterRecordsText="No existen registros." 
                                    DataSourceID="SqlDCompras">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        ExportToCsvText="Exportar a texto" ExportToExcelText="Exportar a Excel" 
        ShowAddNewRecordButton="False" ShowExportToCsvButton="True" 
        ShowExportToExcelButton="True" ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="Periodo" 
            FilterControlAltText="Filter Periodo column" HeaderText="C1" 
            UniqueName="Periodo" ReadOnly="True" SortExpression="Periodo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="codigo" 
            FilterControlAltText="Filter codigo column" 
            HeaderText="C2" UniqueName="codigo" ReadOnly="True" 
            SortExpression="codigo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaDocumento" 
            FilterControlAltText="Filter FechaDocumento column" HeaderText="C3" 
            UniqueName="FechaDocumento" ReadOnly="True" 
            SortExpression="FechaDocumento" DataFormatString="{0:dd/MM/yyyy}">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaVencimiento" 
            FilterControlAltText="Filter FechaVencimiento column" HeaderText="C4" 
            UniqueName="FechaVencimiento" ReadOnly="True" 
            SortExpression="FechaVencimiento" DataFormatString="{0:dd/MM/yyyy}">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoDoc" 
            FilterControlAltText="Filter TipoDoc column" 
            HeaderText="C5" UniqueName="TipoDoc" ReadOnly="True" 
            SortExpression="TipoDoc">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SerieDocumento" 
            FilterControlAltText="Filter SerieDocumento column" 
            HeaderText="C6" UniqueName="SerieDocumento" ReadOnly="True" 
            SortExpression="SerieDocumento">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="AnioDua" 
            FilterControlAltText="Filter AnioDua column" HeaderText="C7" 
            UniqueName="AnioDua" DataType="System.Int32" ReadOnly="True" 
            SortExpression="AnioDua">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDocumento" 
            FilterControlAltText="Filter NroDocumento column" UniqueName="NroDocumento" 
            HeaderText="C8" DataType="System.Int64" ReadOnly="True" 
            SortExpression="NroDocumento">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ImpTotal" 
            FilterControlAltText="Filter ImpTotal column" 
            HeaderText="C9" UniqueName="ImpTotal" DataType="System.Int32" 
            ReadOnly="True" SortExpression="ImpTotal">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoProveedor" 
            FilterControlAltText="Filter TipoProveedor column" UniqueName="TipoProveedor" 
            HeaderText="C10" ReadOnly="True" SortExpression="TipoProveedor">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Ruc" 
            FilterControlAltText="Filter Ruc column" UniqueName="Ruc" 
            HeaderText="C11" ReadOnly="True" SortExpression="Ruc">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="RazonSocial" 
            FilterControlAltText="Filter RazonSocial column" HeaderText="C12" 
            UniqueName="RazonSocial" ReadOnly="True" SortExpression="RazonSocial">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="BaseImponible1" 
            FilterControlAltText="Filter BaseImponible1 column" UniqueName="BaseImponible1" 
            HeaderText="C13" DataType="System.Decimal" ReadOnly="True" 
            SortExpression="BaseImponible1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Igv1" DataType="System.Decimal" 
            FilterControlAltText="Filter Igv1 column" HeaderText="C14" ReadOnly="True" 
            SortExpression="Igv1" UniqueName="Igv1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="BaseImponible2" DataType="System.Decimal" 
            FilterControlAltText="Filter BaseImponible2 column" HeaderText="C15" 
            ReadOnly="True" SortExpression="BaseImponible2" 
            UniqueName="BaseImponible2">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Igv2" DataType="System.Decimal" 
            FilterControlAltText="Filter Igv2 column" HeaderText="C16" ReadOnly="True" 
            SortExpression="Igv2" UniqueName="Igv2">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="BaseImponible3" DataType="System.Decimal" 
            FilterControlAltText="Filter BaseImponible3 column" HeaderText="C17" 
            ReadOnly="True" SortExpression="BaseImponible3" 
            UniqueName="BaseImponible3">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Igv3" DataType="System.Decimal" 
            FilterControlAltText="Filter Igv3 column" HeaderText="C18" ReadOnly="True" 
            SortExpression="Igv3" UniqueName="Igv3">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ValorNoGravadas" DataType="System.Decimal" 
            FilterControlAltText="Filter ValorNoGravadas column" 
            HeaderText="C19" ReadOnly="True" SortExpression="ValorNoGravadas" 
            UniqueName="ValorNoGravadas">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ImpSelectivo" DataType="System.Decimal" 
            FilterControlAltText="Filter ImpSelectivo column" HeaderText="C20" 
            ReadOnly="True" SortExpression="ImpSelectivo" UniqueName="ImpSelectivo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Otros" DataType="System.Decimal" 
            FilterControlAltText="Filter Otros column" HeaderText="C21" ReadOnly="True" 
            SortExpression="Otros" UniqueName="Otros">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Total" DataType="System.Decimal" 
            FilterControlAltText="Filter Total column" HeaderText="C22" ReadOnly="True" 
            SortExpression="Total" UniqueName="Total">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoCambio" DataType="System.Decimal" 
            FilterControlAltText="Filter TipoCambio column" HeaderText="C23" 
            ReadOnly="True" SortExpression="TipoCambio" UniqueName="TipoCambio" 
            DataFormatString="{0:N3}">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaDocRef" 
            FilterControlAltText="Filter FechaDocRef column" HeaderText="C24" 
            ReadOnly="True" SortExpression="FechaDocRef" UniqueName="FechaDocRef" 
            DataFormatString="{0:dd/MM/yyyy}">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoDocRef" 
            FilterControlAltText="Filter TipoDocRef column" HeaderText="C25" 
            ReadOnly="True" SortExpression="TipoDocRef" UniqueName="TipoDocRef">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SerieDocRef" 
            FilterControlAltText="Filter SerieDocRef column" HeaderText="C26" 
            ReadOnly="True" SortExpression="SerieDocRef" UniqueName="SerieDocRef">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDocRef" 
            FilterControlAltText="Filter NroDocRef column" HeaderText="C27" 
            ReadOnly="True" SortExpression="NroDocRef" UniqueName="NroDocRef">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DocNoDomiciliado" 
            FilterControlAltText="Filter DocNoDomiciliado column" 
            HeaderText="C28" ReadOnly="True" SortExpression="DocNoDomiciliado" 
            UniqueName="DocNoDomiciliado">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FecDetraccion" 
            FilterControlAltText="Filter FecDetraccion column" HeaderText="C29" 
            ReadOnly="True" SortExpression="FecDetraccion" UniqueName="FecDetraccion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DocDetraccion" DataType="System.Int32" 
            FilterControlAltText="Filter DocDetraccion column" HeaderText="C30" 
            ReadOnly="True" SortExpression="DocDetraccion" UniqueName="DocDetraccion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CompRetencion" DataType="System.Int32" 
            FilterControlAltText="Filter CompRetencion column" HeaderText="C31" 
            ReadOnly="True" SortExpression="CompRetencion" UniqueName="CompRetencion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" DataType="System.Int32" 
            FilterControlAltText="Filter Estado column" HeaderText="C32" ReadOnly="True" 
            SortExpression="Estado" UniqueName="Estado">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="text-align: center">
                            <asp:SqlDataSource ID="SqlDCompras" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="RepComprasSunat" 
                                SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="RadDatePicker1" Name="fechaIni" 
                                        PropertyName="SelectedDate" Type="DateTime" />
                                    <asp:ControlParameter ControlID="RadDatePicker2" Name="fechaFin" 
                                        PropertyName="SelectedDate" Type="DateTime" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                            <ClientEvents OnRequestStart="onRequestStart" />
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="RadDatePicker1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadDatePicker2">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
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
