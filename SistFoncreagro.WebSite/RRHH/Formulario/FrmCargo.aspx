<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmCargo.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmCargo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center><table style="border: 1px solid #000000; width: 100%">
        <tr>
            <td>
                <table class="fondoTabla" 
                    style="border-width: 0px; padding: 0px; margin: 0px; background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td class="Titulos" align="left">
                            REGIStro de cargos</td>
                        <td width="40px">
                            &nbsp;</td>
                        <td style="text-align: right; width:110px" align="right">
                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Cancel.gif" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                    <AjaxSettings>
                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                <telerik:AjaxUpdatedControl ControlID="Label1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                    </AjaxSettings>
                </telerik:RadAjaxManager>
            </td>
        </tr>
        <tr>
            <td>
                    <asp:ObjectDataSource ID="ODSTabla" runat="server" 
                        SelectMethod="GetAllFromCargo" 
                        TypeName="SistFoncreagro.BussinesLogic.CargoBL">
                    </asp:ObjectDataSource>
                                     
                    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" AllowFilteringByColumn="True"
                        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="ODSTabla" 
                        GridLines="None" ShowGroupPanel="True" Skin="Hay" Width="760px">
                        <GroupingSettings CaseSensitive="False" 
                            GroupSplitDisplayFormat="Mostrando {0} de {1} items." />
                        <ClientSettings AllowDragToGroup="True" AllowColumnHide="True" 
                            AllowColumnsReorder="True">
                            <DataBinding EnableCaching="True">
                            </DataBinding>
                            <Selecting AllowRowSelect="True" />
                            <ClientMessages DragToGroupOrReorder="Arrastre el Item con el que desea Agrupar los datos" 
                                DropHereToReorder="Coloque aqui para reordenar" 
                                PagerTooltipFormatString="Pagina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;" />
                        </ClientSettings>
                        <AlternatingItemStyle HorizontalAlign="Left" />
<MasterTableView datasourceid="ODSTabla" pagesize="15" CommandItemDisplay="Top" 
                            NoMasterRecordsText="No existen registros." ClientDataKeyNames="IdCargo" 
                            DataKeyNames="IdCargo">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Nuevo Cargo" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Refrescar" ShowExportToExcelButton="True" 
        ShowExportToPdfButton="True"></CommandItemSettings>


<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>



    <Columns>
        <telerik:GridTemplateColumn AllowFiltering="False" 
            FilterControlAltText="Filter TemplateColumn column" UniqueName="TemplateColumn">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Edit" 
                    ImageUrl="~/img/Edit.gif" />
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea eliminar el registro?" 
            ConfirmTitle="Eiminar Cargo" FilterControlAltText="Filter column column" 
            ImageUrl="~/img/Delete.gif" UniqueName="column">
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdCargo" 
            FilterControlAltText="Filter IdCargo column" HeaderText="IdCargo" 
            SortExpression="IdCargo" UniqueName="IdCargo" DataType="System.Int32" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NomCargo" 
            FilterControlAltText="Filter NomCargo column" HeaderText="NomCargo" 
            SortExpression="NomCargo" UniqueName="NomCargo" CurrentFilterFunction="Contains" 
            FilterControlWidth="90%" ShowFilterIcon="False" 
            SortedBackColor="ActiveCaption" AutoPostBackOnFilter="True">
            <HeaderStyle Width="300px" />
            <ItemStyle Width="300px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DescCargo" 
            FilterControlAltText="Filter DescCargo column" HeaderText="DescCargo" 
            SortExpression="DescCargo" UniqueName="DescCargo" 
            CurrentFilterFunction="Contains" FilterControlWidth="90%" 
            ShowFilterIcon="False" SortedBackColor="ActiveCaption" 
            AutoPostBackOnFilter="True">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~/RRHH/Controles/ControlNuevoCargo.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <PagerStyle PagerTextFormat="Change página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, items &lt;strong&gt;{2}&lt;/strong&gt; to &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
        PageSizeLabelText="Tamaño de Página" />
</MasterTableView>

                        <ItemStyle HorizontalAlign="Left" />

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                    </telerik:RadGrid>
                    
                    </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 76px">
                &nbsp;</td>
        </tr>
    </table></center>
</asp:Content>
