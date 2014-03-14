<%@ Page Title="Parámetros de Contabilización" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaParametrosVentas.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaParametrosVentas" %>
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
                            parámetros de CONTABILIZACION</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlParametros" 
                                GridLines="None" Skin="Hay" PageSize="15" 
                    AllowFilteringByColumn="True" AllowSorting="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlParametros" 
                        ClientDataKeyNames="IdParametro" DataKeyNames="IdParametro" 
                        NoMasterRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Clasificación" 
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
                            <telerik:GridBoundColumn DataField="IdParametro" DataType="System.Int32" 
            FilterControlAltText="Filter IdParametro column" HeaderText="IdParametro" 
            SortExpression="IdParametro" UniqueName="IdParametro" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Parametro" 
                                FilterControlAltText="Filter Parametro column" 
                                HeaderText="Parametro" UniqueName="Parametro" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                FilterControlWidth="100%" ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="40%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cuenta" 
            FilterControlAltText="Filter Cuenta column" HeaderText="Cuenta Contable" 
            SortExpression="Cuenta" UniqueName="Cuenta" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" Width="40%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" UniqueName="Estado" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            
                            UserControlName="~\Contabilidad\Controles\ControlParametrosVentas.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:SqlDataSource ID="SqlParametros" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetAllFromPARAMETROSVENTASDetallado" 
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
