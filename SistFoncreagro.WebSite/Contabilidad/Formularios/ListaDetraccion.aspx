<%@ Page Title="Tabla de Detracciones" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaDetraccion.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaDetraccion" %>
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
                            tabla de detracciones</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsdetraccion" 
                                GridLines="None" Skin="Hay" PageSize="15" 
                    AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="odsdetraccion" ClientDataKeyNames="IdDetraccion" 
                                    DataKeyNames="IdDetraccion" 
                        NoMasterRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Registro" 
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
                                FilterControlAltText="Filter EditCommandColumn column">
                            </telerik:GridEditCommandColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                                ConfirmDialogType="RadWindow" ConfirmText="¿Esta seguro de Anular el Registro?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                                Text="Eliminar" UniqueName="column">
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" DataField="Codigo" 
                                FilterControlAltText="Filter codigo column" HeaderText="Código" 
                                ShowFilterIcon="False" UniqueName="codigo">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdDetraccion" DataType="System.Int32" 
            FilterControlAltText="Filter IdDetraccion column" HeaderText="IdDetraccion" 
            SortExpression="IdDetraccion" UniqueName="IdDetraccion" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="ElementoAfecto" 
            FilterControlAltText="Filter ElementoAfecto column" HeaderText="Elemento Afecto" 
            SortExpression="ElementoAfecto" UniqueName="ElementoAfecto" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" ShowFilterIcon="False" 
                                FilterControlWidth="100%">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Porcentaje" 
            FilterControlAltText="Filter Porcentaje column" HeaderText="Porcentaje" 
            SortExpression="Porcentaje" UniqueName="Porcentaje" AllowFiltering="False" 
                                DataFormatString="{0:N1}" DataType="System.Decimal">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CtaCargo" 
            FilterControlAltText="Filter CtaCargo column" HeaderText="Cuenta Cargo" 
            SortExpression="CtaCargo" UniqueName="CtaCargo" AllowFiltering="False" DataType="System.Int32">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CuentaAbono" 
            FilterControlAltText="Filter CuentaAbono column" HeaderText="Cuenta Abono" 
            SortExpression="CuentaAbono" UniqueName="CuentaAbono" AllowFiltering="False" 
                                DataType="System.Int32">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            UserControlName="~\Contabilidad\Controles\ControlDetraccion.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="odsdetraccion" runat="server" 
                    SelectMethod="GetAllFromDetraccion" 
                    TypeName="SistFoncreagro.BussinesLogic.DetraccionBL"></asp:ObjectDataSource>
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

