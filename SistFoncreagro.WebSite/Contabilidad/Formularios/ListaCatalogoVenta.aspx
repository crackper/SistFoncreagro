<%@ Page Title="Catálogo de Ventas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaCatalogoVenta.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaCatalogoVenta" %>
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
                            Catalogo de ventas</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlCatalogo" 
                                GridLines="None" Skin="Hay" PageSize="15" 
                    AllowFilteringByColumn="True" AllowSorting="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlCatalogo" 
                        ClientDataKeyNames="IdCatVenta" DataKeyNames="IdCatVenta" 
                        NoMasterRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Catálogo" 
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
                            <telerik:GridBoundColumn DataField="IdCatVenta" DataType="System.Int32" 
            FilterControlAltText="Filter IdContaVenta column" HeaderText="IdCatVenta" 
            SortExpression="IdCatVenta" UniqueName="IdCatVenta" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripción" 
            SortExpression="Descripcion" UniqueName="Descripcion" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="40%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Clasificacion" 
                                FilterControlAltText="Filter Clasificacion column" 
                                HeaderText="Clasificación" UniqueName="Clasificacion" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                FilterControlWidth="100%" ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="40%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="UnidadMedida" 
            FilterControlAltText="Filter UnidadMedida column" HeaderText="U.Medida" 
            SortExpression="UnidadMedida" UniqueName="UnidadMedida" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False" AllowFiltering="False">
                                <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="Estado" 
                                FilterControlAltText="Filter Estado column" 
                                HeaderText="Estado" UniqueName="Estado">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn AllowFiltering="False" DataField="IdUnidadMedida" 
                                FilterControlAltText="Filter IdUnidadMedida column" HeaderText="IdUnidadMedida" 
                                UniqueName="IdUnidadMedida" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="PrecioReferencia" 
                                FilterControlAltText="Filter PrecioReferencia column" 
                                HeaderText="PrecioReferencia" UniqueName="PrecioReferencia" 
                                Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="AfectoIGV" 
                                FilterControlAltText="Filter AfectoIGV column" 
                                HeaderText="AfectoIGV" UniqueName="AfectoIGV" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="AfectoDetraccion" 
                                FilterControlAltText="Filter AfectoDetraccion column" HeaderText="AfectoDetraccion" 
                                UniqueName="AfectoDetraccion" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdClasificacion" 
                                FilterControlAltText="Filter IdClasificacion column" 
                                HeaderText="IdClasificacion" UniqueName="IdClasificacion" Visible="False">
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            
                            UserControlName="~\Contabilidad\Controles\ControlCatalogoVenta.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:SqlDataSource ID="SqlCatalogo" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetCATALOGOVENTADetallado" 
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



