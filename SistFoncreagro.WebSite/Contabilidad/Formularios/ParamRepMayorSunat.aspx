<%@ Page Title="Libros Electrónicos - Libro Mayor" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepMayorSunat.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepMayorSunat" %>
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
                            libros electrónicos - Libro Mayor</td>
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
                        <td width="2%">
                            Al:</td>
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
                        <td colspan="4" align="center">
                        <div style="width: 900px; overflow: auto; height: 500px;">
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" GridLines="None" Width="100%" Skin="Hay" 
                                DataSourceID="SqlDiario" PageSize="5">
<MasterTableView CommandItemDisplay="Top" NoMasterRecordsText="No existen registros." 
                                    DataSourceID="SqlDiario">
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
        <telerik:GridBoundColumn DataField="CodPlan" 
            FilterControlAltText="Filter CodPlan column" HeaderText="C3" ReadOnly="True" 
            SortExpression="CodPlan" UniqueName="CodPlan">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Cuenta" 
            FilterControlAltText="Filter Cuenta column" HeaderText="C4" 
            SortExpression="Cuenta" UniqueName="Cuenta">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Fecha" 
            FilterControlAltText="Filter Fecha column" HeaderText="C5" ReadOnly="True" 
            SortExpression="Fecha" UniqueName="Fecha">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Glosa" 
            FilterControlAltText="Filter Glosa column" HeaderText="C6" ReadOnly="True" 
            SortExpression="Glosa" UniqueName="Glosa">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CargoMN" DataType="System.Decimal" 
            FilterControlAltText="Filter CargoMN column" HeaderText="C7" 
            SortExpression="CargoMN" UniqueName="CargoMN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="AbonoMN" DataType="System.Decimal" 
            FilterControlAltText="Filter AbonoMN column" HeaderText="C8" 
            SortExpression="AbonoMN" UniqueName="AbonoMN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" DataType="System.Int32" 
            FilterControlAltText="Filter Estado column" HeaderText="C9" ReadOnly="True" 
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
                            <asp:SqlDataSource ID="SqlDiario" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="RepLibroDiarioSunat" 
                                SelectCommandType="StoredProcedure">
                                <SelectParameters>
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

