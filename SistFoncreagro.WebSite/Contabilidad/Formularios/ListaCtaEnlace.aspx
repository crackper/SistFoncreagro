<%@ Page Title="Cuentas de Enlace" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaCtaEnlace.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaCtaEnlace" %>
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
                            cuentas de enlace</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsCtasEnlace" 
                                GridLines="None" Skin="Hay" PageSize="15" 
                    AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="odsCtasEnlace" ClientDataKeyNames="IdCtaEnlace" 
                                    DataKeyNames="IdCtaEnlace">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Cuentas de Enlace" 
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
                                FilterControlAltText="Filter EditCommandColumn column" UniqueName="editar">
                            </telerik:GridEditCommandColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                                ConfirmDialogType="RadWindow" 
                                ConfirmText="¿Está seguro que desea Anular la Cuenta de Enlace?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                                Text="Eliminar" UniqueName="anular">
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdCtaEnlace" DataType="System.Int32" 
            FilterControlAltText="Filter IdCtaEnlace column" HeaderText="IdCtaEnlace" 
            SortExpression="IdCtaEnlace" UniqueName="IdCtaEnlace" Visible="False" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="StartsWith" 
                                ShowFilterIcon="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Origen" 
            FilterControlAltText="Filter Origen column" HeaderText="Origen" 
            SortExpression="Origen" UniqueName="Origen" ReadOnly="True" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="StartsWith" ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Destino" 
            FilterControlAltText="Filter Destino column" HeaderText="Destino" 
            SortExpression="Destino" UniqueName="Destino" ReadOnly="True" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="StartsWith" ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CtaOperacion" 
                                FilterControlAltText="Filter CtaOperacion column" HeaderText="Cta. Operación" 
                                ReadOnly="True" SortExpression="CtaOperacion" UniqueName="CtaOperacion" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="StartsWith" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CtaPagar" 
            FilterControlAltText="Filter CtaPagar column" HeaderText="Cta. Cobrar" 
            SortExpression="CtaPagar" UniqueName="CtaPagar" ReadOnly="True" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="StartsWith" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CtaCobrar" 
            FilterControlAltText="Filter CtaCobrar column" HeaderText="Cta. Pagar" 
            SortExpression="CtaCobrar" UniqueName="CtaCobrar" ReadOnly="True" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="StartsWith" 
                                ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Tipo" 
                                FilterControlAltText="Filter Tipo column" HeaderText="Tipo" SortExpression="Tipo" 
                                UniqueName="Tipo" AutoPostBackOnFilter="True" 
                                CurrentFilterFunction="Contains" ShowFilterIcon="False">
                                <HeaderStyle HorizontalAlign="Center" />
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
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                </telerik:RadWindowManager>
                <asp:ObjectDataSource ID="odsCtasEnlace" runat="server" 
                    SelectMethod="GetAllFromCUENTAENLACE" 
                    TypeName="SistFoncreagro.BussinesLogic.CuentaEnlaceBL">
                </asp:ObjectDataSource>
                                            
             

                                            
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
