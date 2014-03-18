<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaCuentasCierre.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaCuentasCierre" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function onRequestStart(sender, args) {
            if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToWordButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToPdfButton") >= 0) {
                args.set_enableAjax(false);
            }
        }
    </script>
    <table align="center" class="tabla3" width="100%">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td style="height: 22px">
                            cuentas de cierre</td>
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
                <div style="overflow: auto">
                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlCuentasCierre" 
                                GridLines="None" Skin="Hay" PageSize="15" Width="120%">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlCuentasCierre" ClientDataKeyNames="IdCierre" 
                                    DataKeyNames="IdCierre" 
                        NoMasterRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Cuentas de Cierre" 
        exporttoexceltext="Exportar a Excel" showrefreshbutton="False" ShowExportToExcelButton="True" 
                            ShowExportToPdfButton="True">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                FilterControlAltText="Filter Editar column" UniqueName="Editar">
                                <HeaderStyle Width="1.5%" />
                            </telerik:GridEditCommandColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                ConfirmDialogType="RadWindow" 
                                ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter Eliminar column" ImageUrl="~\img\delete.gif" 
                                Text="Eliminar" UniqueName="Eliminar">
                                <HeaderStyle Width="1.5%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdCierre" DataType="System.Int32" 
                                FilterControlAltText="Filter IdCierre column" HeaderText="IdCierre" 
                                ReadOnly="True" SortExpression="IdCierre" UniqueName="IdCierre" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Descripcion" 
                                FilterControlAltText="Filter Descripcion column" HeaderText="Descripción" 
                                SortExpression="Descripcion" UniqueName="Descripcion">
                                <HeaderStyle HorizontalAlign="Center" Width="31%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta1" 
                                FilterControlAltText="Filter Cod_Cuenta1 column" 
                                HeaderText="Cta. de Traslado 1" SortExpression="Cod_Cuenta1" 
                                UniqueName="Cod_Cuenta1">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta2" 
                                FilterControlAltText="Filter Cod_Cuenta2 column" 
                                HeaderText="Cta. de Traslado 2" SortExpression="Cod_Cuenta2" 
                                UniqueName="Cod_Cuenta2">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta3" 
                                FilterControlAltText="Filter Cod_Cuenta3 column" 
                                HeaderText="Cta. de Traslado 3" SortExpression="Cod_Cuenta3" 
                                UniqueName="Cod_Cuenta3">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta4" 
                                FilterControlAltText="Filter Cod_Cuenta4 column" 
                                HeaderText="Cta. de Traslado 4" SortExpression="Cod_Cuenta4" 
                                UniqueName="Cod_Cuenta4">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta5" 
                                FilterControlAltText="Filter Cod_Cuenta5 column" 
                                HeaderText="Cta. de Traslado 5" SortExpression="Cod_Cuenta5" 
                                UniqueName="Cod_Cuenta5">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta6" 
                                FilterControlAltText="Filter Cod_Cuenta6 column" 
                                HeaderText="Cta. de Traslado 6" SortExpression="Cod_Cuenta6" 
                                UniqueName="Cod_Cuenta6">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta7" 
                                FilterControlAltText="Filter Cod_Cuenta7 column" 
                                HeaderText="Cta. de Traslado 7" SortExpression="Cod_Cuenta7" 
                                UniqueName="Cod_Cuenta7">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta8" 
                                FilterControlAltText="Filter Cod_Cuenta8 column" 
                                HeaderText="Cta. de Traslado 8" SortExpression="Cod_Cuenta8" 
                                UniqueName="Cod_Cuenta8">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta9" 
                                FilterControlAltText="Filter Cod_Cuenta9 column" 
                                HeaderText="Cta. de Traslado 9" SortExpression="Cod_Cuenta9" 
                                UniqueName="Cod_Cuenta9">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_Cuenta10" 
                                FilterControlAltText="Filter Cod_Cuenta10 column" 
                                HeaderText="Cta. de Traslado 10" SortExpression="Cod_Cuenta10" 
                                UniqueName="Cod_Cuenta10">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cod_CuentaReceptora" 
                                FilterControlAltText="Filter Cod_CuentaReceptora column" 
                                HeaderText="Cta. Receptora" SortExpression="Cod_CuentaReceptora" 
                                UniqueName="Cod_CuentaReceptora">
                                <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings>
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                </div>
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                </telerik:RadWindowManager>

    <asp:SqlDataSource ID="SqlCuentasCierre" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetAllFromCIERRECONTABLEDetallado" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                                            
             

                                            
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

