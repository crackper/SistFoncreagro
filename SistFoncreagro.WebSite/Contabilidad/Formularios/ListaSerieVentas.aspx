<%@ Page Title="Series asignadas a Comprobantes de Venta" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaSerieVentas.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaSerieVentas" %>
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
                            series asignadas a comprobantes de ventas</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlSeries" 
                                GridLines="None" Skin="Hay" PageSize="15" AllowSorting="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlSeries" 
                        ClientDataKeyNames="IdSerie" DataKeyNames="IdSerie" 
                        NoMasterRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Serie" 
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
                                <HeaderStyle Width="2%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="TipoDocumento" 
            FilterControlAltText="Filter TipoDocumento column" HeaderText="Tipo Documento" 
            SortExpression="TipoDocumento" UniqueName="TipoDocumento" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="15%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Serie" 
            FilterControlAltText="Filter Serie column" HeaderText="Serie" 
            SortExpression="Serie" UniqueName="Serie" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="Proyecto" 
                                FilterControlAltText="FilterProyecto column" 
                                HeaderText="Proyecto" UniqueName="Proyecto">
                                <HeaderStyle HorizontalAlign="Center" Width="48%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="Actual" 
                                FilterControlAltText="Filter Actual column" 
                                HeaderText="Último emitido" UniqueName="Actual">
                                <HeaderStyle HorizontalAlign="Center" Width="13%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="Estado" 
                                FilterControlAltText="Filter Estado column" HeaderText="Estado" 
                                UniqueName="Estado">
                                <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdSerie" DataType="System.Int32" 
            FilterControlAltText="Filter IdContaVenta column" HeaderText="IdSerie" 
            SortExpression="IdSerie" UniqueName="IdSerie" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdProyecto" 
                                FilterControlAltText="Filter IdProyecto column" 
                                HeaderText="IdProyecto" UniqueName="IdProyecto" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdTipoDoumento" 
                                FilterControlAltText="Filter IdTipoDoumento column" 
                                HeaderText="IdTipoDocumento" UniqueName="IdTipoDoumento" Visible="False">
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            
                            UserControlName="~\Contabilidad\Controles\ControlSerieVenta.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:SqlDataSource ID="SqlSeries" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetAllFromSERIEDetallado" 
                    SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
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


