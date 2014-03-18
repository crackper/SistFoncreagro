<%@ Page Title="Libros Electrónicos - Registro de Ventas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepVentasSunat.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepVentasSunat" %>
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
                            libros electrónicos - Registro de ventas</td>
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
                        <div style="width: 1100px; overflow: auto; height: 500px;">
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" GridLines="None" Width="100%" Skin="Hay" 
                                DataSourceID="SqlVentas" PageSize="5">
<MasterTableView CommandItemDisplay="Top" NoMasterRecordsText="No existen registros." 
                                    DataSourceID="SqlVentas">
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
            FilterControlAltText="Filter Periodo column" HeaderText="C1" ReadOnly="True" 
            SortExpression="Periodo" UniqueName="Periodo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="C2" ReadOnly="True" 
            SortExpression="Codigo" UniqueName="Codigo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaDocumento" 
            FilterControlAltText="Filter FechaDocumento column" HeaderText="C3" 
            ReadOnly="True" SortExpression="FechaDocumento" 
            UniqueName="FechaDocumento" DataFormatString="{0:dd/MM/yyyy}">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaVencimiento" 
            FilterControlAltText="Filter FechaVencimiento column" HeaderText="C4" 
            ReadOnly="True" SortExpression="FechaVencimiento" 
            UniqueName="FechaVencimiento" DataFormatString="{0:dd/MM/yyyy}">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoDoc" 
            FilterControlAltText="Filter TipoDoc column" HeaderText="C5" 
            SortExpression="TipoDoc" UniqueName="TipoDoc">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SerieDocumento" 
            FilterControlAltText="Filter SerieDocumento column" HeaderText="C6" 
            SortExpression="SerieDocumento" UniqueName="SerieDocumento">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDocumento" DataType="System.Int64" 
            FilterControlAltText="Filter NroDocumento column" HeaderText="C7" 
            SortExpression="NroDocumento" UniqueName="NroDocumento">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ImpTotal" DataType="System.Int32" 
            FilterControlAltText="Filter ImpTotal column" HeaderText="C8" ReadOnly="True" 
            SortExpression="ImpTotal" UniqueName="ImpTotal">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoDocCliente" 
            FilterControlAltText="Filter TipoDocCliente column" HeaderText="C9" 
            SortExpression="TipoDocCliente" UniqueName="TipoDocCliente">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Ruc" 
            FilterControlAltText="Filter Ruc column" HeaderText="C10" SortExpression="Ruc" 
            UniqueName="Ruc">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="RazonSocial" 
            FilterControlAltText="Filter RazonSocial column" HeaderText="C11" 
            SortExpression="RazonSocial" UniqueName="RazonSocial">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ValorExportacion" DataType="System.Decimal" 
            FilterControlAltText="Filter ValorExportacion column" HeaderText="C12" 
            ReadOnly="True" SortExpression="ValorExportacion" UniqueName="ValorExportacion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="BaseImponible" DataType="System.Decimal" 
            FilterControlAltText="Filter BaseImponible column" HeaderText="C13" 
            ReadOnly="True" SortExpression="BaseImponible" UniqueName="BaseImponible">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="BaseExonerada" DataType="System.Decimal" 
            FilterControlAltText="Filter BaseExonerada column" HeaderText="C14" 
            ReadOnly="True" SortExpression="BaseExonerada" UniqueName="BaseExonerada">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="BaseInafecta" DataType="System.Decimal" 
            FilterControlAltText="Filter BaseInafecta column" HeaderText="C15" 
            ReadOnly="True" SortExpression="BaseInafecta" UniqueName="BaseInafecta">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Isc" DataType="System.Decimal" 
            FilterControlAltText="Filter Isc column" HeaderText="C16" ReadOnly="True" 
            SortExpression="Isc" UniqueName="Isc">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="MontoIgv" DataType="System.Decimal" 
            FilterControlAltText="Filter MontoIgv column" HeaderText="C17" ReadOnly="True" 
            SortExpression="MontoIgv" UniqueName="MontoIgv">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="BaseIvap" DataType="System.Decimal" 
            FilterControlAltText="Filter BaseIvap column" HeaderText="C18" ReadOnly="True" 
            SortExpression="BaseIvap" UniqueName="BaseIvap">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Ivap" DataType="System.Decimal" 
            FilterControlAltText="Filter Ivap column" HeaderText="C19" ReadOnly="True" 
            SortExpression="Ivap" UniqueName="Ivap">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Otros" DataType="System.Decimal" 
            FilterControlAltText="Filter Otros column" HeaderText="C20" ReadOnly="True" 
            SortExpression="Otros" UniqueName="Otros">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Total" DataType="System.Decimal" 
            FilterControlAltText="Filter Total column" HeaderText="C21" ReadOnly="True" 
            SortExpression="Total" UniqueName="Total">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoCambio" DataType="System.Decimal" 
            FilterControlAltText="Filter TipoCambio column" HeaderText="C22" 
            ReadOnly="True" SortExpression="TipoCambio" UniqueName="TipoCambio">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaDocRef" 
            FilterControlAltText="Filter FechaDocRef column" HeaderText="C23" 
            ReadOnly="True" SortExpression="FechaDocRef" UniqueName="FechaDocRef">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoDocRef" 
            FilterControlAltText="Filter TipoDocRef column" HeaderText="C24" 
            ReadOnly="True" SortExpression="TipoDocRef" UniqueName="TipoDocRef">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SerieDocRef" 
            FilterControlAltText="Filter SerieDocRef column" HeaderText="C25" 
            ReadOnly="True" SortExpression="SerieDocRef" UniqueName="SerieDocRef">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDocRef" 
            FilterControlAltText="Filter NroDocRef column" HeaderText="C26" ReadOnly="True" 
            SortExpression="NroDocRef" UniqueName="NroDocRef">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" DataType="System.Int32" 
            FilterControlAltText="Filter Estado column" HeaderText="C27" ReadOnly="True" 
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
                            <asp:SqlDataSource ID="SqlVentas" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="RepVentasSunat" 
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

