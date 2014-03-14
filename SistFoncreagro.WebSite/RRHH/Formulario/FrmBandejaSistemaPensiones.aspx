<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmBandejaSistemaPensiones.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmBandejaSistemaPensiones" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 931px; margin-left: 0px">
        <fieldset>
                <legend style="font-family: Arial; font-size: 15px; width: 214px;">Sistema de 
                    pensiones</legend>
                    <br />
                    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsAportesPorPeriodo" 
                        GridLines="None" Skin="Hay" AllowSorting="True" Width="500px">
                        <GroupingSettings CaseSensitive="False" 
                            GroupSplitDisplayFormat="Mostrando {0} de {1} items." />
                        <ClientSettings AllowColumnHide="True" 
                            AllowColumnsReorder="True">
                            <DataBinding EnableCaching="True">
                            </DataBinding>
                            <Selecting AllowRowSelect="True" />
                            <ClientMessages DragToGroupOrReorder="Arrastre el Item con el que desea Agrupar los datos" 
                                DropHereToReorder="Coloque aqui para reordenar" 
                                PagerTooltipFormatString="Pagina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;" />
                        </ClientSettings>
<MasterTableView datasourceid="odsAportesPorPeriodo" pagesize="15" CommandItemDisplay="Top" 
                            NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Nuevo Sistema de Pensiones" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Refrescar" ShowExportToExcelButton="True" 
        ShowExportToPdfButton="True"></CommandItemSettings>
<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridTemplateColumn UniqueName="TemplateColumn1" AllowFiltering="False" 
            FilterControlAltText="filtro1" FilterControlWidth="110px">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          PostBackUrl='<%# "FrmSistemaPensiones.aspx?Resultado=a&IdSistemaPensiones=" & Eval("IdSistemaPensiones") & "&IdPeriodo="&Eval("IdPeridoDeclaracion") & "&IdTipoSp="&Eval("IdTipoSistemaPensiones") %>'
          ToolTip="Editar Requerimiento de Compra" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" />
       </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="IdPeridoDeclaracion" 
            DataType="System.Int32" 
            FilterControlAltText="Filter IdPeridoDeclaracion column" 
            HeaderText="IdPeridoDeclaracion" SortExpression="IdPeridoDeclaracion" 
            UniqueName="IdPeridoDeclaracion" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdSistemaPensiones" DataType="System.Int32" 
            FilterControlAltText="Filter IdSistemaPensiones column" 
            HeaderText="IdSistemaPensiones" SortExpression="IdSistemaPensiones" 
            UniqueName="IdSistemaPensiones" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdAporteSp" DataType="System.Int32" 
            FilterControlAltText="Filter IdAporteSp column" HeaderText="IdAporteSp" 
            SortExpression="IdAporteSp" UniqueName="IdAporteSp" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdAportesPorPerido" DataType="System.Int32" 
            FilterControlAltText="Filter IdAportesPorPerido column" HeaderText="IdAportesPorPerido" 
            SortExpression="IdAportesPorPerido" UniqueName="IdAportesPorPerido" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombrePeridoDeclaracion" 
            FilterControlAltText="Filter NombrePeridoDeclaracion column" 
            HeaderText="Perido de Declaración" SortExpression="NombrePeridoDeclaracion" 
            UniqueName="NombrePeridoDeclaracion" ReadOnly="True">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" Width="200px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombreSistemPensiones" 
            FilterControlAltText="Filter NombreSistemPensiones column" 
            HeaderText="Sistema de Pensión" ReadOnly="True" 
            SortExpression="NombreSistemPensiones" UniqueName="NombreSistemPensiones">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" Width="300px" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="Template">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <PagerStyle PagerTextFormat="Change página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, items &lt;strong&gt;{2}&lt;/strong&gt; to &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
        PageSizeLabelText="Tamaño de Página" />
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                    </telerik:RadGrid>
                <asp:ObjectDataSource ID="odsAportesPorPeriodo" runat="server" 
                    SelectMethod="GetFromAportePorPeriodoBandeja" 
                    TypeName="SistFoncreagro.BussinesLogic.AportesPorPeriodoBL">
                </asp:ObjectDataSource>
        </fieldset>     
    </div>
</asp:Content>
