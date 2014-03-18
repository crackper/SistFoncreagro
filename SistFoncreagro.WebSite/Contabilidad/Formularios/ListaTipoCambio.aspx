<%@ Page Title="Tipo de Cambio" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaTipoCambio.aspx.vb" Inherits="SistFoncreagro.WebSite.RegTipoCambio" %>

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
                        <td >
                            Tipo de Cambio</td>
                        <td  >
                            &nbsp;</td>
                        <td style="text-align: right; width:110px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" ImageAlign="Right" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" width="100%" >
                    <tr>
                        <td >
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" CellSpacing="0" 
                                DataSourceID="odsTipocambio" GridLines="None" Width="100%" 
                                CssClass="grid" Culture="eu-ES" Skin="Hay">
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView DataKeyNames="IdTipoCambio" DataSourceID="odsTipocambio" ClientDataKeyNames="IdTipoCambio" 
                                    CommandItemDisplay="Top" NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Refrescar" ShowExportToExcelButton="True" 
        ShowExportToPdfButton="True" 
        ShowRefreshButton="False"></CommandItemSettings>

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
        <telerik:GridButtonColumn ButtonCssClass="cursor" ButtonType="ImageButton" 
            CommandName="Delete" ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea Eliminar el Registro de Tipo de Cambio?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
            UniqueName="column" Text="Eliminar">
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdTipoCambio" DataType="System.Int32" 
            FilterControlAltText="Filter IdTipoCambio column" HeaderText="IdTipoCambio" 
            ReadOnly="True" SortExpression="IdTipoCambio" UniqueName="IdTipoCambio" 
            Visible="False">
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Moneda.Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Moneda" 
            SortExpression="Moneda.Nombre" UniqueName="Moneda.Nombre">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Anio" DataType="System.Int32" 
            FilterControlAltText="Filter Anio column" HeaderText="Año" 
            SortExpression="Anio" UniqueName="Anio">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="Mes" UniqueName="TemplateColumn">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" 
                    Text='<%# NomMes(Eval("Mes")) %>'></asp:Label>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn AllowFiltering="False" DataField="CompraCierre" 
            DataType="System.Decimal" FilterControlAltText="Filter CompraCierre column" 
            HeaderText="Cierre Compra" SortExpression="CompraCierre" 
            UniqueName="CompraCierre">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AllowFiltering="False" DataField="VentaCierre" 
            DataType="System.Decimal" FilterControlAltText="Filter VentaCierre column" 
            HeaderText="Cierre Venta" SortExpression="VentaCierre" 
            UniqueName="VentaCierre">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Mes" 
            FilterControlAltText="Filter NomMes column" HeaderText="Mes" SortExpression="Mes" 
            UniqueName="NomMes" Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>
                            <asp:ObjectDataSource ID="odsTipocambio" runat="server" 
                                SelectMethod="GetTIPOCAMBIOByAnio" 
                                TypeName="SistFoncreagro.BussinesLogic.TipocambioBL">
                                <SelectParameters>
                                    <asp:SessionParameter Name="Anio" SessionField="Anio" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                <ClientEvents OnRequestStart="onRequestStart" />
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                LoadingPanelID="RadAjaxLoadingPanel1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                LoadingPanelID="RadAjaxLoadingPanel1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
                            </telerik:RadAjaxManager>
                            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
    </table>
</asp:Content>
