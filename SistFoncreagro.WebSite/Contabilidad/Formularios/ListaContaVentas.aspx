<%@ Page Title="Contabilizacion de Ventas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaContaVentas.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaContaVentas" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <script type="text/javascript">
       function onRequestStart(sender, args) {
           if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToWordButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToPdfButton") >= 0) {
               args.set_enableAjax(false);
           }
       }
    </script>
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td style="height: 22px">
                            Contabilizacion de ventas</td>
                        <td style="height: 22px">
                        </td>
                        <td style="text-align: right; width:110px; height: 22px;">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlContabilizacion" 
                                GridLines="None" Skin="Hay" PageSize="15" 
                    AllowFilteringByColumn="True" AllowSorting="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlContabilizacion" 
                        ClientDataKeyNames="IdContaVenta" DataKeyNames="IdContaVenta" 
                        NoMasterRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Contabilización" 
        exporttoexceltext="Exportar a Excel" showrefreshbutton="False" ShowExportToExcelButton="True">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                FilterControlAltText="Filter EditCommandColumn column" UniqueName="Editar">
                                <HeaderStyle Width="2%" />
                            </telerik:GridEditCommandColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                                ConfirmDialogType="RadWindow" 
                                ConfirmText="¿Está seguro que desea anular el Registro?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter Anular column" ImageUrl="~\img\delete.gif" 
                                Text="Anular" UniqueName="Anular">
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdContaVenta" DataType="System.Int32" 
            FilterControlAltText="Filter IdContaVenta column" HeaderText="IdContaVenta" 
            SortExpression="IdContaVenta" UniqueName="IdContaVenta" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Clasificacion" 
            FilterControlAltText="Filter Clasificacion column" HeaderText="Clasificación" 
            SortExpression="Clasificacion" UniqueName="Clasificacion" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="40%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Proyecto" 
            FilterControlAltText="Filter Proyecto column" HeaderText="Proyecto" 
            SortExpression="Proyecto" UniqueName="Proyecto" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="60%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="CodigoVentaInterna" 
                                FilterControlAltText="Filter CodigoVentaInterna column" 
                                HeaderText="Cuenta Interna" UniqueName="CodigoVentaInterna">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="CodigoventaExterna" 
                                FilterControlAltText="Filter CodigoventaExterna column" 
                                HeaderText="Cuenta Terceros" UniqueName="CodigoventaExterna">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="Estado" 
                                FilterControlAltText="Filter Estado column" HeaderText="Estado" 
                                UniqueName="Estado">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdPlanVentaInterna" 
                                FilterControlAltText="Filter IdPlanVentaInterna column" 
                                HeaderText="IdPlanVentaInterna" UniqueName="IdPlanVentaInterna" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdPlanVentaExterna" 
                                FilterControlAltText="Filter IdPlanVentaExterna column" 
                                HeaderText="IdPlanVentaExterna" UniqueName="IdPlanVentaExterna" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdProyecto" 
                                FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
                                UniqueName="IdProyecto" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdClasificacion" 
                                FilterControlAltText="Filter IdClasificacion column" 
                                HeaderText="IdClasificacion" UniqueName="IdClasificacion" Visible="False">
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            
                            UserControlName="~\Contabilidad\Controles\ControlContabilizacionVenta.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:SqlDataSource ID="SqlContabilizacion" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetCONTABILIZACIONVENTADetallado" 
                    SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                </telerik:RadWindowManager>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" 
                    runat="server">
                    <ClientEvents OnRequestStart="onRequestStart" />
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                </telerik:RadAjaxManager>
            </td>
        </tr>
    </table>
</asp:Content>


